namespace WindowsFormsApp9
{
    partial class frmAddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudent));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtinternationalCode = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtFatherName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtFamily = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtAddress = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.groupPanel2);
            this.bunifuGradientPanel1.Controls.Add(this.groupPanel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(736, 379);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.Controls.Add(this.btnSave);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(293, 315);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(431, 46);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(3, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnExit.Size = new System.Drawing.Size(90, 25);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSave.Location = new System.Drawing.Point(332, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ثبت ";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtinternationalCode);
            this.groupPanel1.Controls.Add(this.txtFatherName);
            this.groupPanel1.Controls.Add(this.txtFamily);
            this.groupPanel1.Controls.Add(this.txtName);
            this.groupPanel1.Controls.Add(this.txtAddress);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(293, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(431, 297);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "مشخصات دانش آموزان";
            // 
            // txtinternationalCode
            // 
            this.txtinternationalCode.AcceptsReturn = false;
            this.txtinternationalCode.AcceptsTab = false;
            this.txtinternationalCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtinternationalCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtinternationalCode.BackColor = System.Drawing.Color.White;
            this.txtinternationalCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtinternationalCode.BackgroundImage")));
            this.txtinternationalCode.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtinternationalCode.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtinternationalCode.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtinternationalCode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtinternationalCode.BorderRadius = 1;
            this.txtinternationalCode.BorderThickness = 2;
            this.txtinternationalCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtinternationalCode.DefaultFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinternationalCode.DefaultText = "";
            this.txtinternationalCode.FillColor = System.Drawing.Color.White;
            this.txtinternationalCode.HideSelection = true;
            this.txtinternationalCode.IconLeft = null;
            this.txtinternationalCode.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtinternationalCode.IconPadding = 10;
            this.txtinternationalCode.IconRight = ((System.Drawing.Image)(resources.GetObject("txtinternationalCode.IconRight")));
            this.txtinternationalCode.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtinternationalCode.Location = new System.Drawing.Point(140, 164);
            this.txtinternationalCode.MaxLength = 32767;
            this.txtinternationalCode.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtinternationalCode.Modified = false;
            this.txtinternationalCode.Name = "txtinternationalCode";
            this.txtinternationalCode.PasswordChar = '\0';
            this.txtinternationalCode.ReadOnly = false;
            this.txtinternationalCode.SelectedText = "";
            this.txtinternationalCode.SelectionLength = 0;
            this.txtinternationalCode.SelectionStart = 0;
            this.txtinternationalCode.ShortcutsEnabled = true;
            this.txtinternationalCode.Size = new System.Drawing.Size(267, 35);
            this.txtinternationalCode.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtinternationalCode.TabIndex = 3;
            this.txtinternationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtinternationalCode.TextMarginLeft = 5;
            this.txtinternationalCode.TextPlaceholder = "کدملی را وارد نمایید ....";
            this.txtinternationalCode.UseSystemPasswordChar = false;
            // 
            // txtFatherName
            // 
            this.txtFatherName.AcceptsReturn = false;
            this.txtFatherName.AcceptsTab = false;
            this.txtFatherName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFatherName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFatherName.BackColor = System.Drawing.Color.White;
            this.txtFatherName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFatherName.BackgroundImage")));
            this.txtFatherName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtFatherName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtFatherName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtFatherName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtFatherName.BorderRadius = 1;
            this.txtFatherName.BorderThickness = 2;
            this.txtFatherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFatherName.DefaultFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.DefaultText = "";
            this.txtFatherName.FillColor = System.Drawing.Color.White;
            this.txtFatherName.HideSelection = true;
            this.txtFatherName.IconLeft = null;
            this.txtFatherName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtFatherName.IconPadding = 10;
            this.txtFatherName.IconRight = ((System.Drawing.Image)(resources.GetObject("txtFatherName.IconRight")));
            this.txtFatherName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtFatherName.Location = new System.Drawing.Point(140, 114);
            this.txtFatherName.MaxLength = 32767;
            this.txtFatherName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtFatherName.Modified = false;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.PasswordChar = '\0';
            this.txtFatherName.ReadOnly = false;
            this.txtFatherName.SelectedText = "";
            this.txtFatherName.SelectionLength = 0;
            this.txtFatherName.SelectionStart = 0;
            this.txtFatherName.ShortcutsEnabled = true;
            this.txtFatherName.Size = new System.Drawing.Size(267, 35);
            this.txtFatherName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtFatherName.TabIndex = 2;
            this.txtFatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFatherName.TextMarginLeft = 5;
            this.txtFatherName.TextPlaceholder = "نام پدر را وارد نمایید ....";
            this.txtFatherName.UseSystemPasswordChar = false;
            // 
            // txtFamily
            // 
            this.txtFamily.AcceptsReturn = false;
            this.txtFamily.AcceptsTab = false;
            this.txtFamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFamily.BackColor = System.Drawing.Color.White;
            this.txtFamily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFamily.BackgroundImage")));
            this.txtFamily.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtFamily.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtFamily.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtFamily.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtFamily.BorderRadius = 1;
            this.txtFamily.BorderThickness = 2;
            this.txtFamily.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFamily.DefaultFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamily.DefaultText = "";
            this.txtFamily.FillColor = System.Drawing.Color.White;
            this.txtFamily.HideSelection = true;
            this.txtFamily.IconLeft = null;
            this.txtFamily.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtFamily.IconPadding = 10;
            this.txtFamily.IconRight = ((System.Drawing.Image)(resources.GetObject("txtFamily.IconRight")));
            this.txtFamily.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtFamily.Location = new System.Drawing.Point(140, 63);
            this.txtFamily.MaxLength = 32767;
            this.txtFamily.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtFamily.Modified = false;
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.PasswordChar = '\0';
            this.txtFamily.ReadOnly = false;
            this.txtFamily.SelectedText = "";
            this.txtFamily.SelectionLength = 0;
            this.txtFamily.SelectionStart = 0;
            this.txtFamily.ShortcutsEnabled = true;
            this.txtFamily.Size = new System.Drawing.Size(267, 35);
            this.txtFamily.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtFamily.TabIndex = 1;
            this.txtFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFamily.TextMarginLeft = 5;
            this.txtFamily.TextPlaceholder = "نام خانوادگی را وارد نمایید ....";
            this.txtFamily.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName.BackgroundImage")));
            this.txtName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtName.BorderRadius = 1;
            this.txtName.BorderThickness = 2;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.DefaultFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.HideSelection = true;
            this.txtName.IconLeft = null;
            this.txtName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.IconPadding = 10;
            this.txtName.IconRight = ((System.Drawing.Image)(resources.GetObject("txtName.IconRight")));
            this.txtName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(140, 13);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtName.Modified = false;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = false;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(267, 35);
            this.txtName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginLeft = 5;
            this.txtName.TextPlaceholder = "نام را وارد نمایید ...";
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = false;
            this.txtAddress.AcceptsTab = false;
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAddress.BackgroundImage")));
            this.txtAddress.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtAddress.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAddress.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtAddress.BorderRadius = 1;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.DefaultFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.DefaultText = "";
            this.txtAddress.FillColor = System.Drawing.Color.White;
            this.txtAddress.HideSelection = true;
            this.txtAddress.IconLeft = null;
            this.txtAddress.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddress.IconPadding = 10;
            this.txtAddress.IconRight = null;
            this.txtAddress.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddress.Location = new System.Drawing.Point(3, 209);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtAddress.Modified = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(404, 35);
            this.txtAddress.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txtAddress.TabIndex = 4;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.TextMarginLeft = 5;
            this.txtAddress.TextPlaceholder = "آدرس را وارد نمایید ......";
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(71)))), ((int)(((byte)(42))))));
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 379);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddStudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAddress;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtinternationalCode;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtFatherName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtFamily;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}