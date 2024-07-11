using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ImageEditor
{
    public partial class Form1 : Form
    {
        Image img;
        OpenFileDialog ofd = new OpenFileDialog();

        //cropping points
        Point a;
        Point b;
        Boolean mouseDown = false;
        Boolean isDragging = false;
        Point textPosition;


        Rectangle Rect = new Rectangle();
        private float contrast_img;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_open_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            ofd.Filter = "images|*.png;*.jpg;*.jpeg;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(ofd.FileName);
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                txt_imgpath.Text = ofd.FileName;
                img = Image.FromFile(ofd.FileName);
                lbl_size.Text = pictureBox2.Image.Size.ToString(); // To displaye the image size//

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG|*.JPG|PNG|*.PNG|GIF|*.GIF|BMP|*.BMP|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Bitmap bitmap = new Bitmap(pictureBox1.Image))
                    {
                        bitmap.Save(sfd.FileName, ImageFormat.Jpeg);
                    }
                    MessageBox.Show("Image Saved Successfully.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        new Image Resize(Image image, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, width, height);
            graphic.Dispose();
            return bmp;
        }

        private void btn_resize_Click(object sender, EventArgs e)
        {
            if (txt_height.Text != string.Empty && txt_width.Text != string.Empty)
            {
                int width = Convert.ToInt32(txt_width.Text), height = Convert.ToInt32(txt_height.Text);
                img = Resize(img, width, height);
                pictureBox1.Image = img;
                txt_width.Text = "";
                txt_height.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid value for height or width");
            }
        }

        private void txt_width_TextChanged(object sender, EventArgs e)
        {

        }

        void reload()
        {
            img = Image.FromFile(ofd.FileName);
            pictureBox1.Image = img;
        }
        private void btn_reload_Click(object sender, EventArgs e)
        {
            txt_width.Text = "";
            txt_height.Text = "";
            trk_hue.Value = 0;
            trk_contrast.Value = 0;
            trk_bright.Value = 0;
            reload();
        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            pictureBox1.Refresh();
        }

        private void btn_stretch_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_center_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            isDragging = false;
            a = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                b = e.Location;
                isDragging = true;
                Refresh();
            }
        }
        private Rectangle GetRect()
        {
            Rect = new Rectangle();
            Rect.X = Math.Min(a.X, b.X);
            Rect.Y = Math.Min(a.Y, b.Y);
            Rect.Width = Math.Abs(a.X - b.X);
            Rect.Height = Math.Abs(a.Y - b.Y);
            return Rect;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {            
            if (mouseDown == true)
            {
                b = e.Location;
                mouseDown = false;

                if (isDragging)
                {
                    Rect = GetRect();

                    // Ensure Rect dimensions are valid
                    if (Rect.Width > 0 && Rect.Height > 0 && pictureBox1.Image != null)
                    {
                        Bitmap bitm = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
                        Bitmap crop = new Bitmap(Rect.Width, Rect.Height);
                        using (Graphics g = Graphics.FromImage(crop))
                        {
                            g.DrawImage(bitm, 0, 0, Rect, GraphicsUnit.Pixel);
                        }
                        pictureBox1.Image = crop;
                    }
                    else
                    {
                        MessageBox.Show("Invalid crop area.");
                    }
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (Rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Aqua, GetRect());
            }
        }

        void hue()
        {
            img = pictureBox1.Image;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][] {
             new float[] {1,0,(trk_hue.Value),0,0,0,0},
             new float[] {0,1,0,0,0},
             new float[] {0,0,0,0,0},
             new float[] {0,0,0,1,0},
             new float[]{0,0,0,0,1} });
            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox1.Image = bmpinverted;
        }

        private void trk_hue_ValueChanged(object sender, EventArgs e)
        {
            reload();
            hue();
        }

        void contrast()
        {
            contrast_img = 0.2f * trk_contrast.Value;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][] {
              new float[]{ contrast_img, 0f,0f,0f,0f },
              new float[]{0f, contrast_img, 0f,0f,0f },
              new float[]{0f,0f, contrast_img, 0f,0f },
              new float[]{0f,0f,0f,1f,0f },
              new float[]{0.001f,0.001f,0.001f,0f,1f} });
            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox1.Image = bmpinverted;
        }

        private void trk_contrast_ValueChanged(object sender, EventArgs e)
        {
            contrast();
        }

        void bright()
        {
            img = pictureBox1.Image;
            float fvalue = trk_bright.Value / 50f;
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmpicture = new ColorMatrix(new float[][] {
            new float[] {1,0,0,0,0},
             new float[] {0,1,0,0,0},
             new float[] {0,0,1,0,0 },
             new float[] {0,0,0,0,0},
             new float[]{fvalue,fvalue,fvalue,1,1} });
            ia.SetColorMatrix(cmpicture);
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            grps.Dispose();
            pictureBox1.Image = bmpinverted;
        }

        private void trk_bright_ValueChanged(object sender, EventArgs e)
        {
            bright();
        }

        private void trk_bright_Scroll(object sender, EventArgs e)
        {
            reload();
        }

        private void lbl_size_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && !string.IsNullOrEmpty(txt_text.Text) && textPosition != Point.Empty)
            {
                Bitmap bitmap = new Bitmap(pictureBox1.Image);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    using (Font font = new Font("Arial", 20))
                    {
                        using (SolidBrush brush = new SolidBrush(Color.Red))
                        {
                            g.DrawString(txt_text.Text, font, brush, textPosition);
                        }
                    }
                }
                pictureBox1.Image = bitmap;
                textPosition = Point.Empty; // Reset the position after adding text
            }
            else
            {
                MessageBox.Show("Please load an image, enter some text, and click on the image to set the position.");
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isDragging)
            {
                textPosition = e.Location;
                MessageBox.Show($"Text position set to: {textPosition}");
            }
        }

        private void trk_blur_ValueChanged(object sender, EventArgs e)
        {
            reload();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

