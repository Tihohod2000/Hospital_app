namespace Project_of_store
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToT = new System.Windows.Forms.Label();
            this.grid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay_button = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton9 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton7 = new Guna.UI.WinForms.GunaGradientButton();
            this.Finder = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pnl = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuGradientPanel2);
            this.bunifuPanel1.Controls.Add(this.gunaGradientButton9);
            this.bunifuPanel1.Controls.Add(this.gunaGradientButton1);
            this.bunifuPanel1.Controls.Add(this.gunaGradientButton7);
            this.bunifuPanel1.Controls.Add(this.Finder);
            this.bunifuPanel1.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuPanel1.Controls.Add(this.gunaControlBox1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1135, 615);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderRadius = 20;
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Controls.Add(this.lblToT);
            this.bunifuGradientPanel2.Controls.Add(this.grid);
            this.bunifuGradientPanel2.Controls.Add(this.Pay_button);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(815, 74);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(307, 532);
            this.bunifuGradientPanel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Общая цена:";
            // 
            // lblToT
            // 
            this.lblToT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToT.AutoSize = true;
            this.lblToT.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.lblToT.ForeColor = System.Drawing.Color.White;
            this.lblToT.Location = new System.Drawing.Point(154, 402);
            this.lblToT.Name = "lblToT";
            this.lblToT.Size = new System.Drawing.Size(26, 30);
            this.lblToT.TabIndex = 8;
            this.lblToT.Text = "0";
            // 
            // grid
            // 
            this.grid.AllowCustomTheming = false;
            this.grid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeight = 40;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.count,
            this.Цена});
            this.grid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.grid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.Name = null;
            this.grid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.grid.HeaderBgColor = System.Drawing.Color.Empty;
            this.grid.HeaderForeColor = System.Drawing.Color.White;
            this.grid.Location = new System.Drawing.Point(4, 10);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 40;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(300, 354);
            this.grid.TabIndex = 7;
            this.grid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Title
            // 
            this.Title.HeaderText = "Товар";
            this.Title.Name = "Title";
            // 
            // count
            // 
            this.count.HeaderText = "Количество";
            this.count.Name = "count";
            // 
            // Цена
            // 
            this.Цена.HeaderText = "Цена";
            this.Цена.Name = "Цена";
            // 
            // Pay_button
            // 
            this.Pay_button.Animated = true;
            this.Pay_button.AnimationHoverSpeed = 0.07F;
            this.Pay_button.AnimationSpeed = 0.03F;
            this.Pay_button.BackColor = System.Drawing.Color.Transparent;
            this.Pay_button.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.Pay_button.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.Pay_button.BorderColor = System.Drawing.Color.Black;
            this.Pay_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Pay_button.FocusedColor = System.Drawing.Color.Empty;
            this.Pay_button.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pay_button.ForeColor = System.Drawing.Color.White;
            this.Pay_button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Pay_button.Image = null;
            this.Pay_button.ImageSize = new System.Drawing.Size(20, 20);
            this.Pay_button.Location = new System.Drawing.Point(3, 435);
            this.Pay_button.Name = "Pay_button";
            this.Pay_button.OnHoverBaseColor1 = System.Drawing.Color.Fuchsia;
            this.Pay_button.OnHoverBaseColor2 = System.Drawing.Color.SlateBlue;
            this.Pay_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Pay_button.OnHoverForeColor = System.Drawing.Color.White;
            this.Pay_button.OnHoverImage = null;
            this.Pay_button.OnPressedColor = System.Drawing.Color.Black;
            this.Pay_button.Radius = 10;
            this.Pay_button.Size = new System.Drawing.Size(300, 85);
            this.Pay_button.TabIndex = 6;
            this.Pay_button.Text = "Перейти к оплате";
            this.Pay_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pay_button.Click += new System.EventHandler(this.Pay_button_Click);
            // 
            // gunaGradientButton9
            // 
            this.gunaGradientButton9.Animated = true;
            this.gunaGradientButton9.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton9.AnimationSpeed = 0.03F;
            this.gunaGradientButton9.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton9.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton9.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton9.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton9.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton9.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton9.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.gunaGradientButton9.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton9.Image = null;
            this.gunaGradientButton9.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton9.Location = new System.Drawing.Point(970, 31);
            this.gunaGradientButton9.Margin = new System.Windows.Forms.Padding(10);
            this.gunaGradientButton9.Name = "gunaGradientButton9";
            this.gunaGradientButton9.OnHoverBaseColor1 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton9.OnHoverBaseColor2 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton9.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton9.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton9.OnHoverImage = null;
            this.gunaGradientButton9.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton9.Radius = 20;
            this.gunaGradientButton9.Size = new System.Drawing.Size(152, 42);
            this.gunaGradientButton9.TabIndex = 6;
            this.gunaGradientButton9.Text = "Clear ALL";
            this.gunaGradientButton9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton9.Click += new System.EventHandler(this.gunaGradientButton9_Click);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.Animated = true;
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(754, 34);
            this.gunaGradientButton1.Margin = new System.Windows.Forms.Padding(10);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 6;
            this.gunaGradientButton1.Size = new System.Drawing.Size(55, 39);
            this.gunaGradientButton1.TabIndex = 7;
            this.gunaGradientButton1.Text = "Find";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // gunaGradientButton7
            // 
            this.gunaGradientButton7.Animated = true;
            this.gunaGradientButton7.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton7.AnimationSpeed = 0.03F;
            this.gunaGradientButton7.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton7.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton7.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton7.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton7.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton7.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.gunaGradientButton7.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton7.Image = null;
            this.gunaGradientButton7.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton7.Location = new System.Drawing.Point(815, 31);
            this.gunaGradientButton7.Margin = new System.Windows.Forms.Padding(10);
            this.gunaGradientButton7.Name = "gunaGradientButton7";
            this.gunaGradientButton7.OnHoverBaseColor1 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton7.OnHoverBaseColor2 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton7.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton7.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton7.OnHoverImage = null;
            this.gunaGradientButton7.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton7.Radius = 20;
            this.gunaGradientButton7.Size = new System.Drawing.Size(152, 42);
            this.gunaGradientButton7.TabIndex = 7;
            this.gunaGradientButton7.Text = "Clear";
            this.gunaGradientButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton7.Click += new System.EventHandler(this.gunaGradientButton7_Click);
            // 
            // Finder
            // 
            this.Finder.AcceptsReturn = false;
            this.Finder.AcceptsTab = false;
            this.Finder.AnimationSpeed = 200;
            this.Finder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Finder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Finder.AutoSizeHeight = true;
            this.Finder.BackColor = System.Drawing.Color.Transparent;
            this.Finder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Finder.BackgroundImage")));
            this.Finder.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Finder.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Finder.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Finder.BorderColorIdle = System.Drawing.Color.Silver;
            this.Finder.BorderRadius = 1;
            this.Finder.BorderThickness = 1;
            this.Finder.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Finder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Finder.DefaultFont = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Finder.DefaultText = "";
            this.Finder.FillColor = System.Drawing.Color.White;
            this.Finder.HideSelection = true;
            this.Finder.IconLeft = null;
            this.Finder.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Finder.IconPadding = 10;
            this.Finder.IconRight = null;
            this.Finder.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Finder.Lines = new string[0];
            this.Finder.Location = new System.Drawing.Point(0, 34);
            this.Finder.MaxLength = 32767;
            this.Finder.MinimumSize = new System.Drawing.Size(1, 1);
            this.Finder.Modified = false;
            this.Finder.Multiline = false;
            this.Finder.Name = "Finder";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Finder.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Finder.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Finder.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Finder.OnIdleState = stateProperties4;
            this.Finder.Padding = new System.Windows.Forms.Padding(3);
            this.Finder.PasswordChar = '\0';
            this.Finder.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Finder.PlaceholderText = "Find.....";
            this.Finder.ReadOnly = false;
            this.Finder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Finder.SelectedText = "";
            this.Finder.SelectionLength = 0;
            this.Finder.SelectionStart = 0;
            this.Finder.ShortcutsEnabled = true;
            this.Finder.Size = new System.Drawing.Size(752, 39);
            this.Finder.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Finder.TabIndex = 10;
            this.Finder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Finder.TextMarginBottom = 0;
            this.Finder.TextMarginLeft = 3;
            this.Finder.TextMarginTop = 1;
            this.Finder.TextPlaceholder = "Find.....";
            this.Finder.UseSystemPasswordChar = false;
            this.Finder.WordWrap = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 30;
            this.bunifuGradientPanel1.Controls.Add(this.pnl);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 74);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(809, 534);
            this.bunifuGradientPanel1.TabIndex = 9;
            // 
            // pnl
            // 
            this.pnl.AutoScroll = true;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(809, 534);
            this.pnl.TabIndex = 0;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1084, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1141, 615);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToT;
        private Bunifu.UI.WinForms.BunifuDataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private Guna.UI.WinForms.GunaGradientButton Pay_button;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton9;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton7;
        private Bunifu.UI.WinForms.BunifuTextBox Finder;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnl;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}

