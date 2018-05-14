using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// RandomAvatarGenerator
///  v 0.1
///  -displaying image
///  -4 types of mirror
///  -5 sizes (3x3, 5x5, ,25x25, 15x15, 75x75)
///  v 0.2
///  -saving image to file
///  -added status bar with info about saved image
///  v 0.5
///  -removed New and Load buttons from menu
///  -rotating image
///  -fixed grid problems caused by AntiAlias mode
///  -turning grid on and off (or random)
///  -fixed no-mirror feature
///   

namespace RandomAvatarGenerator__v_0._1_
{
    public partial class mainwindow : Form
    {
        Random _rand = new Random();
        Bitmap avatar = new Bitmap(300, 300);
        Bitmap gridLines = new Bitmap(300, 300);
        int size = 3;
        Brush firstColor = Brushes.Black;
        Brush secondColor = Brushes.Yellow;
        Color gridColor = Color.Aqua;
        Boolean grid = true;

        public mainwindow()
        {
            InitializeComponent();

        }

        //Drawing the big avatar
        private void imageViewerPanel_Paint(object sender, PaintEventArgs e)
        {
            grider();
            e.Graphics.DrawImage(avatar, new Point(0, 0));
            if(grid)
                e.Graphics.DrawImage(gridLines, new Point(0, 0));
        }

        //Clicking the "3x3" button
        private void buttonSize3_Click(object sender, EventArgs e)
        {
            size = 3;
            randomizer();
        }

        //clicking the "5x5" button
        private void buttonSize5_Click(object sender, EventArgs e)
        {
            size = 5;
            randomizer();
        }

        //clicking the "15x15" button
        private void buttonSize15_Click(object sender, EventArgs e)
        {
            size = 15;
            randomizer();
        }

        //clicking the "25x25" button
        private void buttonSize25_Click(object sender, EventArgs e)
        {
            size = 25;
            randomizer();
        }

        //clicking the "75x75" button
        private void buttonSize75_Click(object sender, EventArgs e)
        {
            size = 75;
            randomizer();
        }

        //creating avatar and showing it
        private void randomizer()
        {
            int[,] map = new int[size, size];

            //filling array with 1 or 0 (1-first color, 0-second color)
            //no mirror
            if (checkVertical.Checked == false && checkHorizontal.Checked == false && checkDiagonal.Checked == false)
                for (int i = 0; i < size; i++)
                {
                    for (int y = 0; y < size; y++)
                    {
                        map[i, y] = _rand.Next(2);
                    }
                }

            //vertical mirror
            if (checkVertical.Checked && checkHorizontal.Checked == false)
                for (int i = 0; i < size; i++)
                {
                    for (int y = 0; y < size / 2; y++)
                    {
                        map[i, y] = _rand.Next(2);
                        map[i, size - y - 1] = map[i, y];
                    }
                    map[i, size / 2] = _rand.Next(2);
                }

            //horizontal mirror
            if (checkHorizontal.Checked && checkVertical.Checked == false)
                for (int i = 0; i < size; i++)
                {
                    for (int y = 0; y < size / 2; y++)
                    {
                        map[y, i] = _rand.Next(2);
                        map[size - y - 1, i] = map[y, i];
                    }
                    map[size / 2, i] = _rand.Next(2);
                }

            //diagonal mirror
            if (checkDiagonal.Checked)
                for (int i = 0; i < size; i++)
                {
                    for (int y = 0; y < size / 2; y++)
                    {
                        map[i, y] = _rand.Next(2);
                        map[y, i] = map[i, y];
                        map[size - y - 1, i] = map[i, y];
                        map[i, size - y - 1] = map[i, y];
                    }
                    map[size / 2, size / 2] = _rand.Next(2);
                }

            //cross mirror
            if (checkHorizontal.Checked && checkVertical.Checked)
            {
                //filling around the cross
                for (int i = 0; i < size / 2; i++)
                {
                    for (int y = 0; y < size / 2; y++)
                    {
                        map[i, y] = _rand.Next(2);
                        map[i, size - y - 1] = map[i, y];
                        map[size - i - 1, y] = map[i, y];
                        map[size - i - 1, size - y - 1] = map[i, y];
                    }
                    map[i, size / 2] = _rand.Next(2);
                    map[size - i - 1, size / 2] = map[i, size / 2];
                    map[size / 2, i] = map[i, size / 2];
                    map[size / 2, size - i - 1] = map[i, size / 2];
                }
            }

            //copy array to bitmap
            using (Graphics g = Graphics.FromImage(avatar))
            {
                //if grid==true, turn AntiAlias to show the grid
                //if(grid)
                    //g.SmoothingMode = SmoothingMode.AntiAlias;
                //filling bitmap with gridcolor color
                //g.Clear(gridColor);

                for (int i = 0; i < size; i++)
                    for (int y = 0; y < size; y++)
                        if (map[i, y] == 1)
                            g.FillRectangle(firstColor, new Rectangle(y * (300 / size), i * (300 / size), (300 / size), (300 / size)));
                        else
                            g.FillRectangle(secondColor, new Rectangle(y * (300 / size), i * (300 / size), (300 / size), (300 / size)));
            }

            //random grid on and off
            if(radioButtonRandom.Checked)
            {
                int detRandom = _rand.Next(2);
                if (detRandom == 0) grid = true;
                else grid = false;
            }

            imageViewerPanel.Invalidate();
        }

        //creating grid bitmap
        private void grider()
        {
            Pen pen = new Pen(gridColor, 1);
            using(Graphics g = Graphics.FromImage(gridLines))
            {
                g.Clear(Color.Fuchsia);

                for (int i = 0; i < size; i++)
                    for (int y = 0; y < size; y++)
                    {
                        g.DrawLine(pen, new Point(0, y * (300 / size)), new Point(300, y * (300 / size)));
                        g.DrawLine(pen, new Point(y * (300 / size), 0), new Point(y * (300 / size), 300));
                    }
            }

            gridLines.MakeTransparent(Color.Fuchsia);
            
        }

        private void checkVertical_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHorizontal.Checked || checkVertical.Checked)
                checkDiagonal.Enabled = false;
            else
                checkDiagonal.Enabled = true;
        }

        private void checkHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHorizontal.Checked || checkVertical.Checked)
                checkDiagonal.Enabled = false;
            else
                checkDiagonal.Enabled = true;
        }

        private void checkDiagonal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDiagonal.Checked)
                checkVertical.Enabled = checkHorizontal.Enabled = false;
            else
                checkVertical.Enabled = checkHorizontal.Enabled = true;
        }

        //Clicking the "Randomize" button
        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            randomizer();
        }

        //Clicking the "Save image" button
        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "default.jpg";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.ShowDialog();
        }

        //Saving image to file when user clicks "Ok" in "savedialog popup"
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //adding grid to the avatar (if grid is ON)
            if(grid)
            {
                using (Graphics g = Graphics.FromImage(avatar))
                {
                    g.DrawImage(gridLines, 0, 0);
                }
            }

            string fileName = saveFileDialog1.FileName;
            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    avatar.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                case 2:
                    avatar.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp); break;
                case 3:
                    avatar.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif); break;
            }
            statusBarLabel1.Text = "File saved to: " + fileName;
        }

        //Clicking the "Rotate" button
        private void buttonRotate_Click(object sender, EventArgs e)
        {
            avatar.RotateFlip(RotateFlipType.Rotate90FlipNone);
            imageViewerPanel.Invalidate();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if(rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            if(rb.Checked)
            {
                switch (rb.Text)
                {
                    case "On":
                        grid = true; break;
                    case "Off":
                        grid = false; break;
                    case "Random":
                        {
                            int detRandom = _rand.Next(2);
                            if (detRandom == 0) grid = true;
                            else grid = false;
                        }; break;
                }
                imageViewerPanel.Invalidate();
            }
        }
    }
}
