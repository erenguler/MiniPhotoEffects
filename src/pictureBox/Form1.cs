using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DialogResult.OK == ofd.ShowDialog())
            {
                foreach (string s in ofd.FileNames)
                    if (System.IO.File.Exists(s))
                    {
                        Form2 f = new Form2();
                        f.MdiParent = this;
                        f.Text = System.IO.Path.GetFileName(s);
                        f.pictureBox1.Load(s);
                        f.Show();
                    }
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            Form2 f = (Form2)ActiveMdiChild;


            if (DialogResult.OK == sfd.ShowDialog())
            {
                System.Drawing.Imaging.ImageFormat format;
                string s;

                s = System.IO.Path.GetExtension(sfd.FileName);
                s = s.ToLower();

                if (s == ".bmp")
                    format = System.Drawing.Imaging.ImageFormat.Bmp;
                else if (s == ".jpg" || s == ".jpeg")
                    format = System.Drawing.Imaging.ImageFormat.Jpeg;
                if (s == ".gif")
                    format = System.Drawing.Imaging.ImageFormat.Gif;
                else
                    format = System.Drawing.Imaging.ImageFormat.Png;

                Bitmap bmp = new Bitmap(f.pictureBox1.Image);

                bmp.Save(sfd.FileName, format);

                f.Text = System.IO.Path.GetFileName(sfd.FileName);
            }
        }

        private void cikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            Form2 f = (Form2)ActiveMdiChild;
            Bitmap bmp = new Bitmap(f.pictureBox1.Image);


            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int a = c.A;

                    int r = 255 - c.R;
                    int g = 255 - c.G;
                    int b = 255 - c.B;

                    c = Color.FromArgb(a, r, g, b);
                    bmp.SetPixel(x, y, c);

                }

            f.pictureBox1.Image = bmp;
        }

        private void koyulastirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            Form2 f = (Form2)ActiveMdiChild;
            Bitmap bmp = new Bitmap(f.pictureBox1.Image);

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int a = c.A;

                    int r = (9 * c.R) / 10;
                    int g = (9 * c.G) / 10;
                    int b = (9 * c.B) / 10;

                    c = Color.FromArgb(a, r, g, b);
                    bmp.SetPixel(x, y, c);
                }

            f.pictureBox1.Image = bmp;
        }

        private void aciklastirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            Form2 f = (Form2)ActiveMdiChild;
            Bitmap bmp = new Bitmap(f.pictureBox1.Image);


            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int a = c.A;

                    int r = c.R + 20;
                    if (r > 255)
                        r = 255;

                    int g = c.G + 20;
                    if (g > 255)
                        g = 255;

                    int b = c.B + 20;
                    if (b > 255)
                        b = 255;

                    c = Color.FromArgb(a, r, g, b);
                    bmp.SetPixel(x, y, c);
                }

            f.pictureBox1.Image = bmp;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            Form2 f = (Form2)ActiveMdiChild;
            Bitmap bmp = new Bitmap(f.pictureBox1.Image);

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int a = c.A;

                    int t = (c.R + c.G + c.B) / 3;

                    c = Color.FromArgb(a, t, t, t);
                    bmp.SetPixel(x, y, c);
                }

            f.pictureBox1.Image = bmp;
        }

        private void siyahBeyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            Form2 f = (Form2)ActiveMdiChild;
            Bitmap bmp = new Bitmap(f.pictureBox1.Image);

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int a = c.A;

                    int t = (c.R + c.G + c.B) / 3;

                    if (t < 122)
                        t = 0;
                    else
                        t = 255;

                    c = Color.FromArgb(a, t, t, t);
                    bmp.SetPixel(x, y, c);
                }

            f.pictureBox1.Image = bmp;
        }

        private void kabartmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            Form2 f = (Form2)ActiveMdiChild;
            Bitmap bmp = new Bitmap(f.pictureBox1.Image);

            for (int y = 0; y < bmp.Height - 1; y++)
                for (int x = 0; x < bmp.Width - 1; x++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int a = c.A;

                    int t1 = (c.R + c.G + c.B) / 3;

                    c = bmp.GetPixel(x + 1, y + 1);
                    int t2 = (c.R + c.G + c.B) / 3;

                    int t = 10 * (t1 - t2) + 100;

                    if (t < 0)
                        t = 0;
                    if (t > 255)
                        t = 255;


                    c = Color.FromArgb(a, t, t, t);
                    bmp.SetPixel(x, y, c);
                }

            f.pictureBox1.Image = bmp;
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;

            f.Show();
            f.Text = "Yeni Resim";
        }

        private void bulanikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            Form2 f = (Form2)ActiveMdiChild;
            Bitmap bmp = new Bitmap(f.pictureBox1.Image);

            int n = 1;
            for (int x = n; x < bmp.Width - n; x++)
                for (int y = n; y < bmp.Height - n; y++)
                {
                    Color c = bmp.GetPixel(x, y);
                    Color c1 = bmp.GetPixel(x, y - n);  // 0 0 0
                    Color c2 = bmp.GetPixel(x, y + n);  // 0 1 0
                    Color c3 = bmp.GetPixel(x - n, y);  // 0 0 -1
                    Color c4 = bmp.GetPixel(x + n, y);

                    int a = c.A;

                    int r = (c1.R + c2.R + c3.R + c4.R) / 4;
                    int g = (c1.G + c2.G + c3.G + c4.G) / 4;
                    int b = (c1.B + c2.B + c3.B + c4.B) / 4;

                    c = Color.FromArgb(a, r, g, b);
                    bmp.SetPixel(x, y, c);
                }

            f.pictureBox1.Image = bmp;
        }


    }
}
