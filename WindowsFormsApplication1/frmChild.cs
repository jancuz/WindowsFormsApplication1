using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmChild : Form
    {
        /*class twoPoints
        {
            public Point p1, p2;
            public twoPoints(Point p1, Point p2)
            {
                this.p1 = p1;
                this.p2 = p2;
            }
        }*/

        private Bitmap btmp; //текущее изображение
        public string Filename; //путь до файла
        public bool is_changed = false;
        public bool zoom_change = false;
        Size old;
        /*List<twoPoints> points = new List<twoPoints>();
        List<Rectangle> ellips = new List<Rectangle>();
        int x;
        int y;
        int w;
        int h;
        Point point1, point2;*/
        int oldX, oldY, newX, newY;
        //Bitmap bmp;
        static Color color = Color.Red;
        static float width = 2;
        //Graphics g;

        public frmChild()
        {
            InitializeComponent();
            btmp = new Bitmap(pictureBox1.Width, pictureBox1.Height); //битмап размером с pictureBox
            //g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)// если нажата ЛКМ
            {
                Image old = pictureBox1.Image;
                Graphics g = Graphics.FromImage(btmp);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                if (old != null) g.DrawImage(old, 0, 0);
                switch (frmMain.tool)
                {
                    case frmMain.Item.Brush:
                        {
                            is_changed = true;
                            g.DrawLine(new Pen(color, width), oldX, oldY, e.X, e.Y);
                            oldX = e.X;
                            oldY = e.Y;
                            pictureBox1.Refresh();
                            break;
                        }
                    case frmMain.Item.Eraser:
                        {
                            is_changed = true;
                            g.DrawLine(new Pen(pictureBox1.BackColor, width), oldX, oldY, e.X, e.Y);
                            oldX = e.X;
                            oldY = e.Y;
                            pictureBox1.Refresh();
                            break;
                        }
                    case frmMain.Item.Ellips:
                        {
                            is_changed = true;
                            newX = e.X - oldX;
                            newY = e.Y - oldY;
                            pictureBox1.Refresh();
                            break;
                        }
                    case frmMain.Item.Line:
                        {
                            is_changed = true;
                            newX = e.X;
                            newY = e.Y;
                            pictureBox1.Refresh();
                            break;
                        }
                }
                pictureBox1.Image = btmp; //вывод на pictureBox
            }

                                     /*if (e.Button == MouseButtons.Left && frmMain.draw)
                             {
                                 Graphics g = Graphics.FromImage(pictureBox1.Image);

                                 g.DrawLine(new Pen(color, width), oldX, oldY, e.X, e.Y);
                                 oldX = e.X;
                                 oldY = e.Y;
                                 pictureBox1.Refresh();
                                 return;
                             }
                             if (e.Button == MouseButtons.Left && frmMain.drawLine)
                             {
                                 point2 = e.Location;
                                 pictureBox1.Refresh();
                             }
                             if (e.Button == MouseButtons.Left && frmMain.drawEllips)
                             {
                                 if (x == 0 || y == 0)
                                 {
                                     x = e.X;
                                     y = e.Y;
                                 }
                                 else
                                 {
                                     w = e.X - x;
                                     h = e.Y - y;
                                 }
                                 pictureBox1.Refresh();
                             }
                             if (e.Button == MouseButtons.Left && frmMain.erraser)
                             {
                                 Graphics g = Graphics.FromImage(pictureBox1.Image);

                                 g.DrawLine(new Pen(pictureBox1.BackColor, width), oldX, oldY, e.X, e.Y);
                                 oldX = e.X;
                                 oldY = e.Y;
                                 //pictureBox1.Refresh();
                                 return;
                             }*/
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;//начальные координаты
            oldY = e.Y;

            /*if (e.Button == MouseButtons.Left && frmMain.draw)
            {
                oldX = e.X;
                oldY = e.Y;
                return;
            }
            if (e.Button == MouseButtons.Left && frmMain.drawLine)
            {
                point1 = e.Location;
            }
            if (e.Button == MouseButtons.Left && frmMain.erraser)
            {
                oldX = e.X;
                oldY = e.Y;
                return;
            }*/
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (frmMain.tool)
            {

                case frmMain.Item.Ellips:
                    {
                        is_changed = true;
                        Graphics g = Graphics.FromImage(pictureBox1.Image);
                        g.DrawEllipse(new Pen(color, width), oldX, oldY, newX, newY);
                        g.Save();
                        break;
                    }
                case frmMain.Item.Line:
                    {
                        is_changed = true;
                        Graphics g = Graphics.FromImage(pictureBox1.Image);
                        g.DrawLine(new Pen(color, width), oldX, oldY, newX, newY);
                        g.Save();
                        break;
                    }
            }

            /*if (frmMain.drawLine)
            {
                points.Add(new twoPoints(point1, point2));
                return;
            }
            if (frmMain.drawEllips)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawEllipse(new Pen(Color.Black), x, y, w, h);
                g.Save();
                ellips.Add(new Rectangle(x, y, w, h));
                x = 0;
                y = 0;
                w = 0;
                h = 0;
            }*/
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (frmMain.tool)
            {

                case frmMain.Item.Ellips:
                    {
                        e.Graphics.DrawEllipse(new Pen(color, width), oldX, oldY, newX, newY);
                        e.Graphics.Save();
                        break;
                    }
                case frmMain.Item.Line:
                    {
                        e.Graphics.DrawLine(new Pen(color, width), oldX, oldY, newX, newY);
                        e.Graphics.Save(); break;
                    }
            }

            /*if (frmMain.drawLine)
            {
                foreach (twoPoints tp in points)
                {
                    Graphics g = Graphics.FromImage(pictureBox1.Image);
                    g.DrawLine(Pens.Black, tp.p1, tp.p2);
                }
                //g.DrawLine(Pens.Black, point1, point2);
                return;
            }
            if (frmMain.drawEllips)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                g.DrawEllipse(Pens.Black, x, y, w, h);
                g.Save();
                for (int i = 0; i < ellips.Count; i++)
                {
                    g.DrawEllipse(Pens.Black, ellips[i]);
                }
            }*/
        }

        /*private void frmChild_Resize(object sender, EventArgs e)
        {
            //var size = pictureBox1.Size;
            //bmp = new Bitmap(bmp, size);
            //pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }*/

        // создание нового изображения
        public void Create()
        {
            btmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btmp;
        }

        // закрытие формы
        private void frmChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmClose(ref e);
        }

        // сохранение изображения при закрытии формы
        public void frmClose(ref FormClosingEventArgs e)
        {
            if (is_changed)
            {
                // сохраняем?
                DialogResult tr = MessageBox.Show("Сохранить изображение перед закрытием?", this.Text, MessageBoxButtons.YesNoCancel);

                if (tr == DialogResult.Yes) //сохранение нужно
                {
                    if (Filename != null) //сохранение по известному пути
                    {
                        var tmpIm = pictureBox1.Image;
                        var tmpBM = new Bitmap(tmpIm);
                        tmpBM.Save(Filename);
                    }
                    else // сохранение нового файла
                    {
                        this.SaveAs();
                    }
                }
                else // сохранение не нужно/отменено
                {
                    if (tr == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        // сохранение изображения при закрытии формы
        public void frmClose()
        {
            if (is_changed)
            {
                // сохраняем?
                DialogResult tr = MessageBox.Show("Сохранить изображение перед закрытием?", this.Text, MessageBoxButtons.YesNoCancel);

                if (tr == DialogResult.Yes) //сохранение нужно
                {
                    if (Filename != null) //сохранение по известному пути
                    {
                        var tmpIm = pictureBox1.Image;
                        var tmpBM = new Bitmap(tmpIm);
                        tmpBM.Save(Filename);
                    }
                    else // сохранение нового файла
                    {
                        this.SaveAs();
                    }
                }
            }
        }

        // сохранение файла
        public void Save(string _path)
        {
            pictureBox1.Image.Save(_path);
        }

        // сохранение файла по заданному пути
        public void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap File (*.bmp)|*.bmp|JPEG(*.jpeg)|*.jpeg|GIF(*.gif)|*.gif|TIF(*.tif)|*.tif";
            if (sfd.ShowDialog() == DialogResult.OK) //выбор местасохранения
            {
                pictureBox1.Image.Save(sfd.FileName); //сохранение на выбранное место
            }
        }

        // открытие файла
        public void Open(Image openIm)
        {
            pictureBox1.Width = openIm.Width;
            pictureBox1.Height = openIm.Height;
            pictureBox1.Image = openIm;
        }

        // изменение цвета
        public static void ChangeColor(Color c)
        {
            color = c;
        }

        // изменение толщины
        public static void ChangeThikness(float w)
        {
            width = w;
        }

        // увеличение изображения
        public void ZoomIncr(int zoomFactor)
        {
            //Size newSize = new Size((int)(bmp.Width * zoomFactor), (int)(bmp.Height * zoomFactor));
            //bmp = new Bitmap(bmp, newSize);
            //pictureBox1.Image = bmp;

            if (zoom_change == false)
            {
                old = pictureBox1.Image.Size;
                zoom_change = true;
            }

            is_changed = true;
            Size newSize = new Size((int)(btmp.Width * zoomFactor), (int)(btmp.Height * zoomFactor));
            if (newSize.Width <= this.MaximumSize.Width && newSize.Height <= this.MaximumSize.Height)
            {
                btmp = new Bitmap(btmp, newSize);
                this.Size = new Size((int)(this.Width * zoomFactor), (int)(this.Height * zoomFactor));
                //pictureBox1.Refresh();
                pictureBox1.Image = btmp;
            }
        }

        // уменьшение изображения
        public void ZoomDecr(int zoomFactor)
        {
            if (zoom_change == false)
            {
                old = pictureBox1.Image.Size;
                zoom_change = true;
            }

            is_changed = true;
            Size newSize = new Size((int)(btmp.Width / zoomFactor), (int)(btmp.Height / zoomFactor));
            if (newSize.Width > this.MinimumSize.Width && newSize.Height > this.MinimumSize.Height)
            {
                btmp = new Bitmap(btmp, newSize);
                this.Size = new Size((int)(this.Width / zoomFactor), (int)(this.Height / zoomFactor));
                pictureBox1.Image = btmp;
            }
        }

        // динамическое изменение размера формы
        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            is_changed = true;
            Size newSize = new Size((int)(this.Width), (int)(this.Height));
            btmp = new Bitmap(btmp, newSize);
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            pictureBox1.Image = btmp;
        }

        // тиснение изображения
        public void Function1()
        {
            is_changed = true;
            if (pictureBox1.Image == null) return;
            var tempbmp = new Bitmap(pictureBox1.Image);
            int DispX = 1;
            int DispY = 1;
            int red, green, blue;
            var name = this.Text;

            for (int i = 0; i < tempbmp.Height - 2; i++)
            {
                for (int j = 0; j < tempbmp.Width - 2; j++)
                {
                    System.Drawing.Color pixel1, pixel2;
                    pixel1 = tempbmp.GetPixel(j, i);
                    pixel2 = tempbmp.GetPixel(j + DispX, i + DispY);
                    red = Math.Min(Math.Abs(Convert.ToInt32(pixel1.R) - Convert.ToInt32(pixel2.R)) + 128, 255);
                    green = Math.Min(Math.Abs(Convert.ToInt32(pixel1.G) - Convert.ToInt32(pixel2.G)) + 128, 255);
                    blue = Math.Min(Math.Abs(Convert.ToInt32(pixel1.B) - Convert.ToInt32(pixel2.B)) + 128, 255);
                    btmp.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }

                if (i % 10 == 0)
                {
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    this.Text = (100 * i / (pictureBox1.Image.Height - 2)).ToString() + "%";
                }
            }
            this.Text = name;
            pictureBox1.Refresh();
        }

        // заострение изображения
        public void Function2()
        {
            is_changed = true;
            if (pictureBox1.Image == null) return;
            var tempbmp = new Bitmap(pictureBox1.Image);
            int DX = 1;
            int DY = 1;
            int red, green, blue;
            var name = this.Text;

            for (int i = DX; i < tempbmp.Height - DX - 1; i++)
            {
                for (int j = DY; j < tempbmp.Width - DY - 1; j++)
                {
                    red = Convert.ToInt32(tempbmp.GetPixel(j, i).R + 0.5 * tempbmp.GetPixel(j, i).R - 
                        tempbmp.GetPixel(j - DX, i - DY).R);
                    green = Convert.ToInt32(tempbmp.GetPixel(j, i).G + 0.7 * tempbmp.GetPixel(j, i).G - 
                        tempbmp.GetPixel(j - DX, i - DY).G);
                    blue = Convert.ToInt32(tempbmp.GetPixel(j, i).B + 0.5 * tempbmp.GetPixel(j, i).B - 
                        tempbmp.GetPixel(j - DX, i - DY).B);
                    red = Math.Min(Math.Max(red, 0), 255);
                    green = Math.Min(Math.Max(green, 0), 255);
                    blue = Math.Min(Math.Max(blue, 0), 255);
                    btmp.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }
                if (i % 10 == 0)
                {
                    pictureBox1.Invalidate();
                    this.Text = (100 * i / (pictureBox1.Image.Height - 2)).ToString() + "%";
                    pictureBox1.Refresh();
                }
            }
            this.Text = name;
            pictureBox1.Refresh();
        }

        // сглаживание изображения
        public void Function3()
        {
            is_changed = true;
            if (pictureBox1.Image == null) return;
            var tempbmp = new Bitmap(pictureBox1.Image);
            int DX = 1;
            int DY = 1;
            int red, green, blue;
            var name = this.Text;

            for (int i = DX; i < tempbmp.Height - DX - 1; i++)
            {
                for (int j = DY; j < tempbmp.Width - DY - 1; j++)
                {
                    red = Convert.ToInt32((Convert.ToInt32(tempbmp.GetPixel(j - 1, i - 1).R) + 
                            Convert.ToInt32(tempbmp.GetPixel(j - 1, i).R) + 
                            Convert.ToInt32(tempbmp.GetPixel(j - 1, i + 1).R) + 
                            Convert.ToInt32(tempbmp.GetPixel(j, i - 1).R) + 
                            Convert.ToInt32(tempbmp.GetPixel(j, i).R) + 
                            Convert.ToInt32(tempbmp.GetPixel(j, i + 1).R) + 
                            Convert.ToInt32(tempbmp.GetPixel(j + 1, i - 1).R) + 
                            Convert.ToInt32(tempbmp.GetPixel(j + 1, i).R) + 
                            Convert.ToInt32(tempbmp.GetPixel(j + 1, i + 1).R)) / 9);

                    green = Convert.ToInt32((Convert.ToInt32(tempbmp.GetPixel(j - 1, i - 1).G) +
                            Convert.ToInt32(tempbmp.GetPixel(j - 1, i).G) +
                            Convert.ToInt32(tempbmp.GetPixel(j - 1, i + 1).G) +
                            Convert.ToInt32(tempbmp.GetPixel(j, i - 1).G) +
                            Convert.ToInt32(tempbmp.GetPixel(j, i).G) +
                            Convert.ToInt32(tempbmp.GetPixel(j, i + 1).G) +
                            Convert.ToInt32(tempbmp.GetPixel(j + 1, i - 1).G) +
                            Convert.ToInt32(tempbmp.GetPixel(j + 1, i).G) +
                            Convert.ToInt32(tempbmp.GetPixel(j + 1, i + 1).G)) / 9);

                    blue = Convert.ToInt32((Convert.ToInt32(tempbmp.GetPixel(j - 1, i - 1).B) +
                            Convert.ToInt32(tempbmp.GetPixel(j - 1, i).B) +
                            Convert.ToInt32(tempbmp.GetPixel(j - 1, i + 1).B) +
                            Convert.ToInt32(tempbmp.GetPixel(j, i - 1).B) +
                            Convert.ToInt32(tempbmp.GetPixel(j, i).B) +
                            Convert.ToInt32(tempbmp.GetPixel(j, i + 1).B) +
                            Convert.ToInt32(tempbmp.GetPixel(j + 1, i - 1).B) +
                            Convert.ToInt32(tempbmp.GetPixel(j + 1, i).B) +
                            Convert.ToInt32(tempbmp.GetPixel(j + 1, i + 1).B)) / 9);
                    red = Math.Min(Math.Max(red, 0), 255);
                    green = Math.Min(Math.Max(green, 0), 255);
                    blue = Math.Min(Math.Max(blue, 0), 255);
                    btmp.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }
                if (i % 10 == 0)
                {
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    this.Text = (100 * i / (pictureBox1.Image.Height - 2)).ToString() + "%"; }
            }
            this.Text = name;
            pictureBox1.Refresh();
        }

        // нормальный вид
        public void Function4()
        {
            is_changed = true;
            if (pictureBox1.Image == null) return;
            if (zoom_change == false) return;
            btmp = new Bitmap(btmp, old);
            this.Size = old;
            pictureBox1.Image = btmp;
        }

        // уменьшение изображения
        public void Function5()
        {
            if (pictureBox1.Image == null) return;
            if (zoom_change == false)
            {
                old = pictureBox1.Image.Size;
                zoom_change = true;
            }
            is_changed = true;
            Size newSize = new Size((int)(btmp.Width / 2), (int)(btmp.Height / 2));

            btmp = new Bitmap(btmp, newSize);
            this.Size = new Size((int)(this.Width / 2), (int)(this.Height / 2));
            pictureBox1.Image = btmp;
        }

        // увеличение изображения
        public void Function6()
        {
            if (pictureBox1.Image == null) return;
            if (zoom_change == false)
            {
                old = pictureBox1.Image.Size;
                zoom_change = true;
            }
            is_changed = true;
            Size newSize = new Size((int)(btmp.Width * 2), (int)(btmp.Height * 2));

            btmp = new Bitmap(btmp, newSize);
            this.Size = new Size((int)(this.Width * 2), (int)(this.Height * 2));
            pictureBox1.Image = btmp;
        }

        // размытие изображения
        public void Function7()
        {
            Random rnd = new Random();
            var tempbmp = new Bitmap(pictureBox1.Image);
            int DX, DY;
            int red, green, blue;
            var name = this.Text;

            for (int i = 3; i < tempbmp.Height - 3; i++)
            {
                for (int j = 3; j < tempbmp.Width - 3; j++)
                {
                    DX = (int)(rnd.NextDouble() * 4 - 2);
                    DY = (int)(rnd.NextDouble() * 4 - 2);
                    red = tempbmp.GetPixel(j + DX, i + DY).R;
                    green = tempbmp.GetPixel(j + DX, i + DY).G;
                    blue = tempbmp.GetPixel(j + DX, i + DY).B;
                    btmp.SetPixel(j, i, Color.FromArgb(red, green, blue));
                }
                this.Text = Convert.ToInt32(100 * i / (tempbmp.Height - 2)).ToString() + "%";
                if (i % 10 == 0)
                {
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    this.Text = Convert.ToInt32(100 * i / (pictureBox1.Image.Height - 2)).ToString() + "%";
                }
            }
            this.Text = name;
            pictureBox1.Refresh();
        }

        // поворот налево
        public void Function8()
        {
            is_changed = true;
            if (pictureBox1.Image == null) return;
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Width = pictureBox1.Height * pictureBox1.Image.Width / pictureBox1.Image.Height;
        }
        
        // поворот направо
        public void Function9()
        {
            is_changed = true;
            if (pictureBox1.Image == null) return;
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Width = pictureBox1.Height * pictureBox1.Image.Width / pictureBox1.Image.Height;
        }

        // горизонтальное отображение
        public void Function10()
        {
            is_changed = true;
            if (pictureBox1.Image == null) return;
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();
        }

        // вертикальное отображение
        public void Function11()
        {
            is_changed = true;
            if (pictureBox1.Image == null) return;
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();
        }
    }
}
