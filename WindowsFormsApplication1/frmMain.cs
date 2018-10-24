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
    public partial class frmMain : Form
    {
        public enum Item { Brush = 0, Line, Ellips, Eraser, Star, ZoomIn, ZoomOut }
        public static Item tool = Item.Brush;
        static float width = 2;
        static int zoomDecr = 2;
        static int zoomIncr = 2;
        frmChild frm;

        public frmMain()
        {
            InitializeComponent();
        }

        // сохранить
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            frmChild child = this.ActiveMdiChild as frmChild;
            if (child != null)
            {
                child.is_changed = false;
                if (child.Filename != null)
                {
                    child.Save(child.Filename);
                }
                else tsmiSaveAs_Click(sender, e);
            }
        }

        // сохранить как...
        public void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap File (*.bmp)|*.bmp|JPEG(*.jpeg)|*.jpeg|GIF(*.gif)|*.gif|TIF(*.tif)|*.tif";
            sfd.Title = "Сохранение изображения";
            frmChild child = this.ActiveMdiChild as frmChild;
            if (child != null)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    child.Save(sfd.FileName);
                    child.Filename = sfd.FileName;
                }
            }
        }

        // открыть изображение
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap File (*.bmp)|*.bmp|JPEG(*.jpeg)|*.jpeg|GIF(*.gif)|*.gif|TIF(*.tif)|*.tif";
            ofd.Title = "Открытие файла";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tsmiCreate_Click(sender, e);
                frmChild child = this.ActiveMdiChild as frmChild;
                Image openIm = new Bitmap(ofd.FileName);
                child.Open(openIm);
                child.Filename = ofd.FileName;
            }
        }

        // создать изображение
        private void tsmiCreate_Click(object sender, EventArgs e)
        {
            frm = new frmChild();
            frm.Text = frm.Text + " " + (this.MdiChildren.Length + 1).ToString(); //к названию добавляется номер
            frm.MdiParent = this;
            frm.Create();
            frm.Show();
        }

        // окно...
        private void tsmiCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tsmiTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiArrangeIcons_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        // изменение цвета
        private void tsbColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                tsbColor.BackColor = c.Color;
                frmChild.ChangeColor(c.Color);
            }
        }

        // нажатие на клавишу "Перо"
        private void tsbInstrument_Click(object sender, EventArgs e)
        {
            Block();
            tsbBrush.Checked = true;
            tool = Item.Brush;
        }

        // нажатие на клавишу "Линия"
        private void tsbLine_Click(object sender, EventArgs e)
        {
            Block();
            tsbLine.Checked = true;
            tool = Item.Line;
        }

        // нажатие на клавишу "Эллипс"
        private void tsbEllips_Click(object sender, EventArgs e)
        {
            Block();
            tsbEllips.Checked = true;
            tool = Item.Ellips;
        }

        // нажатие на клавишу "Ластик"
        private void tsbErraser_Click(object sender, EventArgs e)
        {
            Block();
            tsbEraser.Checked = true;
            tool = Item.Eraser;
        }

        // изменение толщины
        private void tsmiThikness1_Click(object sender, EventArgs e)
        {
            width = Convert.ToInt32(tsmiThikness1.Text);
            frmChild.ChangeThikness(width);
        }

        private void tsmiThikness2_Click(object sender, EventArgs e)
        {
            width = Convert.ToInt32(tsmiThikness2.Text);
            frmChild.ChangeThikness(width);
        }

        private void tsmiThikness3_Click(object sender, EventArgs e)
        {
            width = Convert.ToInt32(tsmiThikness3.Text);
            frmChild.ChangeThikness(width);
        }

        private void tsmiThikness4_Click(object sender, EventArgs e)
        {
            width = Convert.ToInt32(tsmiThikness4.Text);
            frmChild.ChangeThikness(width);
        }

        // блокирование элементов ToolBar
        public void Block()
        {
            tsbBrush.Checked = false;
            tsbEllips.Checked = false;
            tsbEraser.Checked = false;
            tsbLine.Checked = false;
            tsbStar.Checked = false;
            tsbZoomOut.Checked = false;
            tsbZoomIn.Checked = false;
        }

        // нажатие на клавишу "Зум+"
        private void tsbZoomIn_Click(object sender, EventArgs e)
        {
            Block();
            tsbZoomIn.Checked = true;
            tool = Item.ZoomIn;
            frm.ZoomIncr(zoomIncr);
        }

        // нажатие на клавишу "Зум-"
        private void tsbZoomOut_Click(object sender, EventArgs e)
        {
            Block();
            tsbZoomOut.Checked = true;
            tool = Item.ZoomOut;
            frm.ZoomDecr(zoomDecr);
        }

        // выход из редактора
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                frmChild child = this.MdiChildren[i] as frmChild;
                child.frmClose();
                child.is_changed = false;
            }
            this.Close();
        }

        // выход из редактора
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                frmChild child = this.MdiChildren[i] as frmChild;
                child.frmClose();
                child.is_changed = false;
            }
            this.Close();
        }

        // тиснение изображения
        private void tsmiEmbossingImage_Click(object sender, EventArgs e)
        {
            if(frm != null)
                frm.Function1();
        }

        // заострение изображения
        private void tsmiSharpeningImage_Click(object sender, EventArgs e)
        {
            if (frm != null)
                frm.Function2();
        }

        // сглаживание изображения
        private void tsmiSmoothImage_Click(object sender, EventArgs e)
        {
            if (frm != null)
                frm.Function3();
        }

        // нормальный вид
        private void tsmiNormalView_Click_1(object sender, EventArgs e)
        {
            if (frm != null)
                frm.Function4();
        }

        // уменьшение изображения
        private void tsmiZoomOut_Click_1(object sender, EventArgs e)
        {
            if (frm != null)
            {
                Block();
                tool = Item.ZoomOut;
                frm.Function5();
            }
        }

        // увеличение изображения
        private void tsmiZoomIn_Click_1(object sender, EventArgs e)
        {
            if (frm != null)
            {
                Block();
                tool = Item.ZoomIn;
                frm.Function6();
            }
        }

        // размытие изображения
        private void tsmiDiffuseImage_Click(object sender, EventArgs e)
        {
            if (frm != null)
                frm.Function7();
        }

        // поворот влево
        private void tsmiRotateLeft_Click(object sender, EventArgs e)
        {
            if (frm != null)
                frm.Function8();
        }

        // поворот вправо
        private void tsmiRotateRight_Click(object sender, EventArgs e)
        {
            if (frm != null)
                frm.Function9();
        }

        // симметрия относительно ОХ
        private void tsmiRotateOX_Click(object sender, EventArgs e)
        {
            if (frm != null)
                frm.Function10();
        }

        // симметрия относительно ОУ
        private void tsmiRotateOY_Click(object sender, EventArgs e)
        {
            if (frm != null)
                frm.Function11();
        }
    }
}
