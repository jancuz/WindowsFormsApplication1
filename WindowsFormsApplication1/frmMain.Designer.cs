namespace WindowsFormsApplication1
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmbossingImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSharpeningImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmoothImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNormalView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDiffuseImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsToolBar = new System.Windows.Forms.ToolStrip();
            this.tsbBrush = new System.Windows.Forms.ToolStripButton();
            this.tsbColor = new System.Windows.Forms.ToolStripButton();
            this.tsbThikness = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiThikness1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThikness2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThikness3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThikness4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbStar = new System.Windows.Forms.ToolStripButton();
            this.tsbLine = new System.Windows.Forms.ToolStripButton();
            this.tsbEllips = new System.Windows.Forms.ToolStripButton();
            this.tsbEraser = new System.Windows.Forms.ToolStripButton();
            this.tsbZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsbZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsmiRotateLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRotateRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRotateOX = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRotateOY = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tsToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiPicture,
            this.tsmiWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.tsmiWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreate,
            this.tsmiSaveAs,
            this.tsmiSave,
            this.tsmiOpen,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiCreate
            // 
            this.tsmiCreate.Name = "tsmiCreate";
            this.tsmiCreate.Size = new System.Drawing.Size(162, 22);
            this.tsmiCreate.Text = "Создать";
            this.tsmiCreate.Click += new System.EventHandler(this.tsmiCreate_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(162, 22);
            this.tsmiSaveAs.Text = "Сохранить как...";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(162, 22);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(162, 22);
            this.tsmiOpen.Text = "Открыть";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(162, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiPicture
            // 
            this.tsmiPicture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmbossingImage,
            this.tsmiSharpeningImage,
            this.tsmiSmoothImage,
            this.tsmiNormalView,
            this.tsmiZoomOut,
            this.tsmiZoomIn,
            this.tsmiDiffuseImage,
            this.tsmiRotateLeft,
            this.tsmiRotateRight,
            this.tsmiRotateOX,
            this.tsmiRotateOY});
            this.tsmiPicture.Name = "tsmiPicture";
            this.tsmiPicture.Size = new System.Drawing.Size(65, 20);
            this.tsmiPicture.Text = "Рисунок";
            // 
            // tsmiEmbossingImage
            // 
            this.tsmiEmbossingImage.Name = "tsmiEmbossingImage";
            this.tsmiEmbossingImage.Size = new System.Drawing.Size(243, 22);
            this.tsmiEmbossingImage.Text = "Тиснение изображения";
            this.tsmiEmbossingImage.Click += new System.EventHandler(this.tsmiEmbossingImage_Click);
            // 
            // tsmiSharpeningImage
            // 
            this.tsmiSharpeningImage.Name = "tsmiSharpeningImage";
            this.tsmiSharpeningImage.Size = new System.Drawing.Size(243, 22);
            this.tsmiSharpeningImage.Text = "Заострение изображения";
            this.tsmiSharpeningImage.Click += new System.EventHandler(this.tsmiSharpeningImage_Click);
            // 
            // tsmiSmoothImage
            // 
            this.tsmiSmoothImage.Name = "tsmiSmoothImage";
            this.tsmiSmoothImage.Size = new System.Drawing.Size(243, 22);
            this.tsmiSmoothImage.Text = "Сглаживание изображения";
            this.tsmiSmoothImage.Click += new System.EventHandler(this.tsmiSmoothImage_Click);
            // 
            // tsmiNormalView
            // 
            this.tsmiNormalView.Name = "tsmiNormalView";
            this.tsmiNormalView.Size = new System.Drawing.Size(243, 22);
            this.tsmiNormalView.Text = "Нормальный вид";
            this.tsmiNormalView.Click += new System.EventHandler(this.tsmiNormalView_Click_1);
            // 
            // tsmiZoomOut
            // 
            this.tsmiZoomOut.Name = "tsmiZoomOut";
            this.tsmiZoomOut.Size = new System.Drawing.Size(243, 22);
            this.tsmiZoomOut.Text = "Уменьшение";
            this.tsmiZoomOut.Click += new System.EventHandler(this.tsmiZoomOut_Click_1);
            // 
            // tsmiZoomIn
            // 
            this.tsmiZoomIn.Name = "tsmiZoomIn";
            this.tsmiZoomIn.Size = new System.Drawing.Size(243, 22);
            this.tsmiZoomIn.Text = "Увеличение";
            this.tsmiZoomIn.Click += new System.EventHandler(this.tsmiZoomIn_Click_1);
            // 
            // tsmiDiffuseImage
            // 
            this.tsmiDiffuseImage.Name = "tsmiDiffuseImage";
            this.tsmiDiffuseImage.Size = new System.Drawing.Size(243, 22);
            this.tsmiDiffuseImage.Text = "Размытие изображения";
            this.tsmiDiffuseImage.Click += new System.EventHandler(this.tsmiDiffuseImage_Click);
            // 
            // tsmiWindow
            // 
            this.tsmiWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCascade,
            this.tsmiTileHorizontal,
            this.tsmiTileVertical,
            this.tsmiArrangeIcons});
            this.tsmiWindow.Name = "tsmiWindow";
            this.tsmiWindow.Size = new System.Drawing.Size(48, 20);
            this.tsmiWindow.Text = "Окно";
            // 
            // tsmiCascade
            // 
            this.tsmiCascade.Name = "tsmiCascade";
            this.tsmiCascade.Size = new System.Drawing.Size(187, 22);
            this.tsmiCascade.Text = "Каскадом";
            this.tsmiCascade.Click += new System.EventHandler(this.tsmiCascade_Click);
            // 
            // tsmiTileHorizontal
            // 
            this.tsmiTileHorizontal.Name = "tsmiTileHorizontal";
            this.tsmiTileHorizontal.Size = new System.Drawing.Size(187, 22);
            this.tsmiTileHorizontal.Text = "Слева направо";
            this.tsmiTileHorizontal.Click += new System.EventHandler(this.tsmiTileHorizontal_Click);
            // 
            // tsmiTileVertical
            // 
            this.tsmiTileVertical.Name = "tsmiTileVertical";
            this.tsmiTileVertical.Size = new System.Drawing.Size(187, 22);
            this.tsmiTileVertical.Text = "Сверху вниз";
            this.tsmiTileVertical.Click += new System.EventHandler(this.tsmiTileVertical_Click);
            // 
            // tsmiArrangeIcons
            // 
            this.tsmiArrangeIcons.Name = "tsmiArrangeIcons";
            this.tsmiArrangeIcons.Size = new System.Drawing.Size(187, 22);
            this.tsmiArrangeIcons.Text = "Упорядочить значки";
            this.tsmiArrangeIcons.Click += new System.EventHandler(this.tsmiArrangeIcons_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tsToolBar
            // 
            this.tsToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBrush,
            this.tsbColor,
            this.tsbThikness,
            this.tsbStar,
            this.tsbLine,
            this.tsbEllips,
            this.tsbEraser,
            this.tsbZoomIn,
            this.tsbZoomOut});
            this.tsToolBar.Location = new System.Drawing.Point(0, 24);
            this.tsToolBar.Name = "tsToolBar";
            this.tsToolBar.Size = new System.Drawing.Size(809, 25);
            this.tsToolBar.TabIndex = 3;
            this.tsToolBar.Text = "toolStrip1";
            // 
            // tsbBrush
            // 
            this.tsbBrush.Checked = true;
            this.tsbBrush.CheckOnClick = true;
            this.tsbBrush.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.tsbBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBrush.Image = ((System.Drawing.Image)(resources.GetObject("tsbBrush.Image")));
            this.tsbBrush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBrush.Name = "tsbBrush";
            this.tsbBrush.Size = new System.Drawing.Size(23, 22);
            this.tsbBrush.Text = "Перо";
            this.tsbBrush.Click += new System.EventHandler(this.tsbInstrument_Click);
            // 
            // tsbColor
            // 
            this.tsbColor.BackColor = System.Drawing.Color.Red;
            this.tsbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbColor.ForeColor = System.Drawing.Color.Red;
            this.tsbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColor.Name = "tsbColor";
            this.tsbColor.Size = new System.Drawing.Size(23, 22);
            this.tsbColor.Text = "Цвет";
            this.tsbColor.Click += new System.EventHandler(this.tsbColor_Click);
            // 
            // tsbThikness
            // 
            this.tsbThikness.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbThikness.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThikness1,
            this.tsmiThikness2,
            this.tsmiThikness3,
            this.tsmiThikness4});
            this.tsbThikness.Image = ((System.Drawing.Image)(resources.GetObject("tsbThikness.Image")));
            this.tsbThikness.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThikness.Name = "tsbThikness";
            this.tsbThikness.Size = new System.Drawing.Size(32, 22);
            this.tsbThikness.Text = "Толщина";
            // 
            // tsmiThikness1
            // 
            this.tsmiThikness1.Name = "tsmiThikness1";
            this.tsmiThikness1.Size = new System.Drawing.Size(80, 22);
            this.tsmiThikness1.Text = "1";
            this.tsmiThikness1.Click += new System.EventHandler(this.tsmiThikness1_Click);
            // 
            // tsmiThikness2
            // 
            this.tsmiThikness2.Name = "tsmiThikness2";
            this.tsmiThikness2.Size = new System.Drawing.Size(80, 22);
            this.tsmiThikness2.Text = "2";
            this.tsmiThikness2.Click += new System.EventHandler(this.tsmiThikness2_Click);
            // 
            // tsmiThikness3
            // 
            this.tsmiThikness3.Name = "tsmiThikness3";
            this.tsmiThikness3.Size = new System.Drawing.Size(80, 22);
            this.tsmiThikness3.Text = "3";
            this.tsmiThikness3.Click += new System.EventHandler(this.tsmiThikness3_Click);
            // 
            // tsmiThikness4
            // 
            this.tsmiThikness4.Name = "tsmiThikness4";
            this.tsmiThikness4.Size = new System.Drawing.Size(80, 22);
            this.tsmiThikness4.Text = "4";
            this.tsmiThikness4.Click += new System.EventHandler(this.tsmiThikness4_Click);
            // 
            // tsbStar
            // 
            this.tsbStar.CheckOnClick = true;
            this.tsbStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStar.Image = ((System.Drawing.Image)(resources.GetObject("tsbStar.Image")));
            this.tsbStar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStar.Name = "tsbStar";
            this.tsbStar.Size = new System.Drawing.Size(23, 22);
            this.tsbStar.Text = "Звезда";
            // 
            // tsbLine
            // 
            this.tsbLine.CheckOnClick = true;
            this.tsbLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbLine.Image")));
            this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLine.Name = "tsbLine";
            this.tsbLine.Size = new System.Drawing.Size(23, 22);
            this.tsbLine.Text = "Линия";
            this.tsbLine.Click += new System.EventHandler(this.tsbLine_Click);
            // 
            // tsbEllips
            // 
            this.tsbEllips.CheckOnClick = true;
            this.tsbEllips.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEllips.Image = ((System.Drawing.Image)(resources.GetObject("tsbEllips.Image")));
            this.tsbEllips.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEllips.Name = "tsbEllips";
            this.tsbEllips.Size = new System.Drawing.Size(23, 22);
            this.tsbEllips.Text = "Эллипс";
            this.tsbEllips.Click += new System.EventHandler(this.tsbEllips_Click);
            // 
            // tsbEraser
            // 
            this.tsbEraser.CheckOnClick = true;
            this.tsbEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEraser.Image = ((System.Drawing.Image)(resources.GetObject("tsbEraser.Image")));
            this.tsbEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEraser.Name = "tsbEraser";
            this.tsbEraser.Size = new System.Drawing.Size(23, 22);
            this.tsbEraser.Text = "Ластик";
            this.tsbEraser.Click += new System.EventHandler(this.tsbErraser_Click);
            // 
            // tsbZoomIn
            // 
            this.tsbZoomIn.CheckOnClick = true;
            this.tsbZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoomIn.Image")));
            this.tsbZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZoomIn.Name = "tsbZoomIn";
            this.tsbZoomIn.Size = new System.Drawing.Size(23, 22);
            this.tsbZoomIn.Text = "Увеличение";
            this.tsbZoomIn.Click += new System.EventHandler(this.tsbZoomIn_Click);
            // 
            // tsbZoomOut
            // 
            this.tsbZoomOut.CheckOnClick = true;
            this.tsbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoomOut.Image")));
            this.tsbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZoomOut.Name = "tsbZoomOut";
            this.tsbZoomOut.Size = new System.Drawing.Size(23, 22);
            this.tsbZoomOut.Text = "Уменьшение";
            this.tsbZoomOut.Click += new System.EventHandler(this.tsbZoomOut_Click);
            // 
            // tsmiRotateLeft
            // 
            this.tsmiRotateLeft.Name = "tsmiRotateLeft";
            this.tsmiRotateLeft.Size = new System.Drawing.Size(243, 22);
            this.tsmiRotateLeft.Text = "Поворот на 90° налево";
            this.tsmiRotateLeft.Click += new System.EventHandler(this.tsmiRotateLeft_Click);
            // 
            // tsmiRotateRight
            // 
            this.tsmiRotateRight.Name = "tsmiRotateRight";
            this.tsmiRotateRight.Size = new System.Drawing.Size(243, 22);
            this.tsmiRotateRight.Text = "Поворот на 90° направо";
            this.tsmiRotateRight.Click += new System.EventHandler(this.tsmiRotateRight_Click);
            // 
            // tsmiRotateOX
            // 
            this.tsmiRotateOX.Name = "tsmiRotateOX";
            this.tsmiRotateOX.Size = new System.Drawing.Size(243, 22);
            this.tsmiRotateOX.Text = "Симметрия относитеельно ОХ";
            this.tsmiRotateOX.Click += new System.EventHandler(this.tsmiRotateOX_Click);
            // 
            // tsmiRotateOY
            // 
            this.tsmiRotateOY.Name = "tsmiRotateOY";
            this.tsmiRotateOY.Size = new System.Drawing.Size(243, 22);
            this.tsmiRotateOY.Text = "Симметрия относительно ОУ";
            this.tsmiRotateOY.Click += new System.EventHandler(this.tsmiRotateOY_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(809, 481);
            this.Controls.Add(this.tsToolBar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Графический редактор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsToolBar.ResumeLayout(false);
            this.tsToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreate;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiPicture;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiCascade;
        private System.Windows.Forms.ToolStripMenuItem tsmiTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmiTileVertical;
        private System.Windows.Forms.ToolStripMenuItem tsmiArrangeIcons;
        private System.Windows.Forms.ToolStripButton tsbColor;
        private System.Windows.Forms.ToolStripButton tsbZoomIn;
        private System.Windows.Forms.ToolStripButton tsbZoomOut;
        private System.Windows.Forms.ToolStripSplitButton tsbThikness;
        private System.Windows.Forms.ToolStripMenuItem tsmiThikness1;
        private System.Windows.Forms.ToolStripMenuItem tsmiThikness2;
        private System.Windows.Forms.ToolStripMenuItem tsmiThikness3;
        private System.Windows.Forms.ToolStripMenuItem tsmiThikness4;
        public System.Windows.Forms.ToolStripButton tsbBrush;
        public System.Windows.Forms.ToolStripButton tsbStar;
        public System.Windows.Forms.ToolStripButton tsbLine;
        public System.Windows.Forms.ToolStripButton tsbEllips;
        public System.Windows.Forms.ToolStripButton tsbEraser;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmbossingImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSharpeningImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmoothImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiNormalView;
        private System.Windows.Forms.ToolStripMenuItem tsmiZoomOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiZoomIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiDiffuseImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotateLeft;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotateRight;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotateOX;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotateOY;
        public System.Windows.Forms.ToolStrip tsToolBar;
    }
}

