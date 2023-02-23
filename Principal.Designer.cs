using System.Runtime.InteropServices;

namespace MarkInBox_Gravação_PDT_110_F1
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTelaRelatorios = new MaterialSkin.Controls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkGravarMatriculaRepetida = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkStartAutomatico = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZerarValores = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.tbLeituraClassificacao = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbLeituraLinha05 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.tbLeituraLinha04 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tbLeituraLinha03 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.tbLeituraLinha02 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.tbLeituraLinha01 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.tbLeituraReceita = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tbLeituraMatricula = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tbLeituraDesenho = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnStartGravacao = new MaterialSkin.Controls.MaterialButton();
            this.comboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConectar = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTelaEditarReceitas = new MaterialSkin.Controls.MaterialButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnId = new System.Windows.Forms.ColumnHeader();
            this.columnDesenhoMotor = new System.Windows.Forms.ColumnHeader();
            this.columnReceitaMarkinBox = new System.Windows.Forms.ColumnHeader();
            this.columnLinha01 = new System.Windows.Forms.ColumnHeader();
            this.columnLinha02 = new System.Windows.Forms.ColumnHeader();
            this.columnLinha03 = new System.Windows.Forms.ColumnHeader();
            this.columnLinha04 = new System.Windows.Forms.ColumnHeader();
            this.columnLinha05 = new System.Windows.Forms.ColumnHeader();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialListView3 = new MaterialSkin.Controls.MaterialListView();
            this.idTextoFixo = new System.Windows.Forms.ColumnHeader();
            this.numeroTextoFixo = new System.Windows.Forms.ColumnHeader();
            this.textoFixo = new System.Windows.Forms.ColumnHeader();
            this.btnTelaCadastrarTextoFixo = new MaterialSkin.Controls.MaterialButton();
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.idReceitaMarkinbox = new System.Windows.Forms.ColumnHeader();
            this.numeroReceitaMarkinbox = new System.Windows.Forms.ColumnHeader();
            this.nomeReceitaMarkinbox = new System.Windows.Forms.ColumnHeader();
            this.numeroLinhas = new System.Windows.Forms.ColumnHeader();
            this.tipoLinha01 = new System.Windows.Forms.ColumnHeader();
            this.tipoLinha02 = new System.Windows.Forms.ColumnHeader();
            this.tipoLinha03 = new System.Windows.Forms.ColumnHeader();
            this.tipoLinha04 = new System.Windows.Forms.ColumnHeader();
            this.tipoLinha05 = new System.Windows.Forms.ColumnHeader();
            this.btnTelaEditarCadastrarReceitasMarkinbox = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tipBotaoStart = new System.Windows.Forms.ToolTip(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 48);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1018, 718);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnTelaRelatorios);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.ImageKey = "icons8-página-inicial-32.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1010, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // btnTelaRelatorios
            // 
            this.btnTelaRelatorios.AutoSize = false;
            this.btnTelaRelatorios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTelaRelatorios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTelaRelatorios.Depth = 0;
            this.btnTelaRelatorios.HighEmphasis = true;
            this.btnTelaRelatorios.Icon = null;
            this.btnTelaRelatorios.Location = new System.Drawing.Point(11, 608);
            this.btnTelaRelatorios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTelaRelatorios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTelaRelatorios.Name = "btnTelaRelatorios";
            this.btnTelaRelatorios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTelaRelatorios.Size = new System.Drawing.Size(330, 56);
            this.btnTelaRelatorios.TabIndex = 19;
            this.btnTelaRelatorios.Text = "Relatórios";
            this.btnTelaRelatorios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTelaRelatorios.UseAccentColor = false;
            this.btnTelaRelatorios.UseVisualStyleBackColor = true;
            this.btnTelaRelatorios.Click += new System.EventHandler(this.btnTelaRelatorios_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkGravarMatriculaRepetida);
            this.panel3.Controls.Add(this.checkStartAutomatico);
            this.panel3.Controls.Add(this.materialLabel12);
            this.panel3.Location = new System.Drawing.Point(11, 448);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 152);
            this.panel3.TabIndex = 18;
            // 
            // checkGravarMatriculaRepetida
            // 
            this.checkGravarMatriculaRepetida.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkGravarMatriculaRepetida.AutoSize = true;
            this.checkGravarMatriculaRepetida.Depth = 0;
            this.checkGravarMatriculaRepetida.Location = new System.Drawing.Point(39, 85);
            this.checkGravarMatriculaRepetida.Margin = new System.Windows.Forms.Padding(0);
            this.checkGravarMatriculaRepetida.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkGravarMatriculaRepetida.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkGravarMatriculaRepetida.Name = "checkGravarMatriculaRepetida";
            this.checkGravarMatriculaRepetida.ReadOnly = false;
            this.checkGravarMatriculaRepetida.Ripple = true;
            this.checkGravarMatriculaRepetida.Size = new System.Drawing.Size(219, 37);
            this.checkGravarMatriculaRepetida.TabIndex = 18;
            this.checkGravarMatriculaRepetida.Text = "Gravar Matrícula Repetida";
            this.checkGravarMatriculaRepetida.UseVisualStyleBackColor = true;
            this.checkGravarMatriculaRepetida.Click += new System.EventHandler(this.checkGravarMatriculaRepetida_Click);
            // 
            // checkStartAutomatico
            // 
            this.checkStartAutomatico.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkStartAutomatico.AutoSize = true;
            this.checkStartAutomatico.Depth = 0;
            this.checkStartAutomatico.Location = new System.Drawing.Point(39, 47);
            this.checkStartAutomatico.Margin = new System.Windows.Forms.Padding(0);
            this.checkStartAutomatico.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkStartAutomatico.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkStartAutomatico.Name = "checkStartAutomatico";
            this.checkStartAutomatico.ReadOnly = false;
            this.checkStartAutomatico.Ripple = true;
            this.checkStartAutomatico.Size = new System.Drawing.Size(155, 37);
            this.checkStartAutomatico.TabIndex = 17;
            this.checkStartAutomatico.Text = "Start Automático";
            this.checkStartAutomatico.UseVisualStyleBackColor = true;
            this.checkStartAutomatico.Click += new System.EventHandler(this.checkStartAutomatico_Click);
            // 
            // materialLabel12
            // 
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel12.Location = new System.Drawing.Point(3, 7);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(323, 48);
            this.materialLabel12.TabIndex = 16;
            this.materialLabel12.Text = "Configurações";
            this.materialLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarkInBox_Gravação_PDT_110_F1.Properties.Resources.LogoConecsaFPT_330_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 187);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnZerarValores);
            this.panel2.Controls.Add(this.materialLabel13);
            this.panel2.Controls.Add(this.tbLeituraClassificacao);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.tbLeituraLinha05);
            this.panel2.Controls.Add(this.materialLabel11);
            this.panel2.Controls.Add(this.tbLeituraLinha04);
            this.panel2.Controls.Add(this.materialLabel10);
            this.panel2.Controls.Add(this.tbLeituraLinha03);
            this.panel2.Controls.Add(this.materialLabel9);
            this.panel2.Controls.Add(this.tbLeituraLinha02);
            this.panel2.Controls.Add(this.materialLabel8);
            this.panel2.Controls.Add(this.tbLeituraLinha01);
            this.panel2.Controls.Add(this.materialLabel14);
            this.panel2.Controls.Add(this.tbLeituraReceita);
            this.panel2.Controls.Add(this.materialLabel6);
            this.panel2.Controls.Add(this.tbLeituraMatricula);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.tbLeituraDesenho);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Location = new System.Drawing.Point(346, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 663);
            this.panel2.TabIndex = 8;
            // 
            // btnZerarValores
            // 
            this.btnZerarValores.AutoSize = false;
            this.btnZerarValores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnZerarValores.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnZerarValores.Depth = 0;
            this.btnZerarValores.HighEmphasis = true;
            this.btnZerarValores.Icon = null;
            this.btnZerarValores.Location = new System.Drawing.Point(132, 599);
            this.btnZerarValores.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnZerarValores.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnZerarValores.Name = "btnZerarValores";
            this.btnZerarValores.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnZerarValores.Size = new System.Drawing.Size(330, 56);
            this.btnZerarValores.TabIndex = 20;
            this.btnZerarValores.Text = "Zerar Valores";
            this.btnZerarValores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnZerarValores.UseAccentColor = false;
            this.btnZerarValores.UseVisualStyleBackColor = true;
            this.btnZerarValores.Click += new System.EventHandler(this.btnZerarValores_Click);
            // 
            // materialLabel13
            // 
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel13.Location = new System.Drawing.Point(10, 187);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(86, 38);
            this.materialLabel13.TabIndex = 18;
            this.materialLabel13.Text = "Cassificação:";
            this.materialLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLeituraClassificacao
            // 
            this.tbLeituraClassificacao.AnimateReadOnly = false;
            this.tbLeituraClassificacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeituraClassificacao.Depth = 0;
            this.tbLeituraClassificacao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLeituraClassificacao.LeadingIcon = null;
            this.tbLeituraClassificacao.Location = new System.Drawing.Point(104, 181);
            this.tbLeituraClassificacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeituraClassificacao.MaxLength = 14;
            this.tbLeituraClassificacao.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLeituraClassificacao.Multiline = false;
            this.tbLeituraClassificacao.Name = "tbLeituraClassificacao";
            this.tbLeituraClassificacao.Size = new System.Drawing.Size(455, 50);
            this.tbLeituraClassificacao.TabIndex = 17;
            this.tbLeituraClassificacao.Text = "";
            this.tbLeituraClassificacao.TrailingIcon = null;
            this.tbLeituraClassificacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLeituraClassificacao_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel3.Location = new System.Drawing.Point(10, 541);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(86, 38);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "linha 05:";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLeituraLinha05
            // 
            this.tbLeituraLinha05.AnimateReadOnly = false;
            this.tbLeituraLinha05.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeituraLinha05.Depth = 0;
            this.tbLeituraLinha05.Enabled = false;
            this.tbLeituraLinha05.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLeituraLinha05.LeadingIcon = null;
            this.tbLeituraLinha05.Location = new System.Drawing.Point(104, 535);
            this.tbLeituraLinha05.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeituraLinha05.MaxLength = 40;
            this.tbLeituraLinha05.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLeituraLinha05.Multiline = false;
            this.tbLeituraLinha05.Name = "tbLeituraLinha05";
            this.tbLeituraLinha05.Size = new System.Drawing.Size(455, 50);
            this.tbLeituraLinha05.TabIndex = 15;
            this.tbLeituraLinha05.Text = "";
            this.tbLeituraLinha05.TrailingIcon = null;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel11.Location = new System.Drawing.Point(10, 482);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(86, 38);
            this.materialLabel11.TabIndex = 14;
            this.materialLabel11.Text = "linha 04:";
            this.materialLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLeituraLinha04
            // 
            this.tbLeituraLinha04.AnimateReadOnly = false;
            this.tbLeituraLinha04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeituraLinha04.Depth = 0;
            this.tbLeituraLinha04.Enabled = false;
            this.tbLeituraLinha04.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLeituraLinha04.LeadingIcon = null;
            this.tbLeituraLinha04.Location = new System.Drawing.Point(104, 476);
            this.tbLeituraLinha04.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeituraLinha04.MaxLength = 40;
            this.tbLeituraLinha04.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLeituraLinha04.Multiline = false;
            this.tbLeituraLinha04.Name = "tbLeituraLinha04";
            this.tbLeituraLinha04.Size = new System.Drawing.Size(455, 50);
            this.tbLeituraLinha04.TabIndex = 13;
            this.tbLeituraLinha04.Text = "";
            this.tbLeituraLinha04.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel10.Location = new System.Drawing.Point(10, 423);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(86, 38);
            this.materialLabel10.TabIndex = 12;
            this.materialLabel10.Text = "linha 03:";
            this.materialLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLeituraLinha03
            // 
            this.tbLeituraLinha03.AnimateReadOnly = false;
            this.tbLeituraLinha03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeituraLinha03.Depth = 0;
            this.tbLeituraLinha03.Enabled = false;
            this.tbLeituraLinha03.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLeituraLinha03.LeadingIcon = null;
            this.tbLeituraLinha03.Location = new System.Drawing.Point(104, 417);
            this.tbLeituraLinha03.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeituraLinha03.MaxLength = 40;
            this.tbLeituraLinha03.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLeituraLinha03.Multiline = false;
            this.tbLeituraLinha03.Name = "tbLeituraLinha03";
            this.tbLeituraLinha03.Size = new System.Drawing.Size(455, 50);
            this.tbLeituraLinha03.TabIndex = 11;
            this.tbLeituraLinha03.Text = "";
            this.tbLeituraLinha03.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel9.Location = new System.Drawing.Point(10, 364);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(86, 38);
            this.materialLabel9.TabIndex = 10;
            this.materialLabel9.Text = "linha 02:";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLeituraLinha02
            // 
            this.tbLeituraLinha02.AnimateReadOnly = false;
            this.tbLeituraLinha02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeituraLinha02.Depth = 0;
            this.tbLeituraLinha02.Enabled = false;
            this.tbLeituraLinha02.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLeituraLinha02.LeadingIcon = null;
            this.tbLeituraLinha02.Location = new System.Drawing.Point(104, 358);
            this.tbLeituraLinha02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeituraLinha02.MaxLength = 40;
            this.tbLeituraLinha02.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLeituraLinha02.Multiline = false;
            this.tbLeituraLinha02.Name = "tbLeituraLinha02";
            this.tbLeituraLinha02.Size = new System.Drawing.Size(455, 50);
            this.tbLeituraLinha02.TabIndex = 9;
            this.tbLeituraLinha02.Text = "";
            this.tbLeituraLinha02.TrailingIcon = null;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel8.Location = new System.Drawing.Point(10, 305);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(86, 38);
            this.materialLabel8.TabIndex = 8;
            this.materialLabel8.Text = "Linha 01:";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLeituraLinha01
            // 
            this.tbLeituraLinha01.AnimateReadOnly = false;
            this.tbLeituraLinha01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeituraLinha01.Depth = 0;
            this.tbLeituraLinha01.Enabled = false;
            this.tbLeituraLinha01.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLeituraLinha01.LeadingIcon = null;
            this.tbLeituraLinha01.Location = new System.Drawing.Point(104, 299);
            this.tbLeituraLinha01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeituraLinha01.MaxLength = 40;
            this.tbLeituraLinha01.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLeituraLinha01.Multiline = false;
            this.tbLeituraLinha01.Name = "tbLeituraLinha01";
            this.tbLeituraLinha01.Size = new System.Drawing.Size(455, 50);
            this.tbLeituraLinha01.TabIndex = 7;
            this.tbLeituraLinha01.Text = "";
            this.tbLeituraLinha01.TrailingIcon = null;
            // 
            // materialLabel14
            // 
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel14.Location = new System.Drawing.Point(10, 246);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(86, 38);
            this.materialLabel14.TabIndex = 6;
            this.materialLabel14.Text = "Receita:";
            this.materialLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLeituraReceita
            // 
            this.tbLeituraReceita.AnimateReadOnly = false;
            this.tbLeituraReceita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeituraReceita.Depth = 0;
            this.tbLeituraReceita.Enabled = false;
            this.tbLeituraReceita.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLeituraReceita.LeadingIcon = null;
            this.tbLeituraReceita.Location = new System.Drawing.Point(104, 240);
            this.tbLeituraReceita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeituraReceita.MaxLength = 10;
            this.tbLeituraReceita.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLeituraReceita.Multiline = false;
            this.tbLeituraReceita.Name = "tbLeituraReceita";
            this.tbLeituraReceita.Size = new System.Drawing.Size(455, 50);
            this.tbLeituraReceita.TabIndex = 5;
            this.tbLeituraReceita.Text = "";
            this.tbLeituraReceita.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel6.Location = new System.Drawing.Point(10, 128);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(86, 38);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Matrícula:";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLeituraMatricula
            // 
            this.tbLeituraMatricula.AnimateReadOnly = false;
            this.tbLeituraMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeituraMatricula.Depth = 0;
            this.tbLeituraMatricula.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLeituraMatricula.LeadingIcon = null;
            this.tbLeituraMatricula.Location = new System.Drawing.Point(104, 122);
            this.tbLeituraMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeituraMatricula.MaxLength = 11;
            this.tbLeituraMatricula.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLeituraMatricula.Multiline = false;
            this.tbLeituraMatricula.Name = "tbLeituraMatricula";
            this.tbLeituraMatricula.Size = new System.Drawing.Size(455, 50);
            this.tbLeituraMatricula.TabIndex = 3;
            this.tbLeituraMatricula.Text = "";
            this.tbLeituraMatricula.TrailingIcon = null;
            this.tbLeituraMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLeituraMatricula_KeyPress);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel5.Location = new System.Drawing.Point(10, 69);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 38);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Desenho:";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLeituraDesenho
            // 
            this.tbLeituraDesenho.AnimateReadOnly = false;
            this.tbLeituraDesenho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeituraDesenho.Depth = 0;
            this.tbLeituraDesenho.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbLeituraDesenho.LeadingIcon = null;
            this.tbLeituraDesenho.Location = new System.Drawing.Point(104, 63);
            this.tbLeituraDesenho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLeituraDesenho.MaxLength = 15;
            this.tbLeituraDesenho.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLeituraDesenho.Multiline = false;
            this.tbLeituraDesenho.Name = "tbLeituraDesenho";
            this.tbLeituraDesenho.Size = new System.Drawing.Size(455, 50);
            this.tbLeituraDesenho.TabIndex = 1;
            this.tbLeituraDesenho.Text = "";
            this.tbLeituraDesenho.TrailingIcon = null;
            this.tbLeituraDesenho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLeituraDesenho_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(3, 8);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(589, 48);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Leitura da Ficha do Motor";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.btnStartGravacao);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.btnConectar);
            this.panel1.Location = new System.Drawing.Point(11, 205);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 232);
            this.panel1.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(3, 7);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(323, 61);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Comnunicação: RS232 MarkinBox";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartGravacao
            // 
            this.btnStartGravacao.AutoSize = false;
            this.btnStartGravacao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartGravacao.BackColor = System.Drawing.Color.White;
            this.btnStartGravacao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStartGravacao.Depth = 0;
            this.btnStartGravacao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartGravacao.HighEmphasis = true;
            this.btnStartGravacao.Icon = global::MarkInBox_Gravação_PDT_110_F1.Properties.Resources.icons8_play_32;
            this.btnStartGravacao.Location = new System.Drawing.Point(176, 141);
            this.btnStartGravacao.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartGravacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartGravacao.Name = "btnStartGravacao";
            this.btnStartGravacao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStartGravacao.Size = new System.Drawing.Size(140, 76);
            this.btnStartGravacao.TabIndex = 5;
            this.btnStartGravacao.Text = "Start Gravação";
            this.btnStartGravacao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStartGravacao.UseAccentColor = true;
            this.btnStartGravacao.UseVisualStyleBackColor = false;
            this.btnStartGravacao.Click += new System.EventHandler(this.btnStartGravacao_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoResize = false;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox1.Depth = 0;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.DropDownHeight = 174;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 121;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 43;
            this.comboBox1.Location = new System.Drawing.Point(117, 76);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 49);
            this.comboBox1.StartIndex = 0;
            this.comboBox1.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(23, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Porta Serial:";
            // 
            // btnConectar
            // 
            this.btnConectar.AutoSize = false;
            this.btnConectar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConectar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConectar.Depth = 0;
            this.btnConectar.HighEmphasis = true;
            this.btnConectar.Icon = global::MarkInBox_Gravação_PDT_110_F1.Properties.Resources.icons8_connected_32;
            this.btnConectar.Location = new System.Drawing.Point(12, 141);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConectar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConectar.Size = new System.Drawing.Size(140, 76);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConectar.UseAccentColor = false;
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnTelaEditarReceitas);
            this.tabPage2.Controls.Add(this.materialListView1);
            this.tabPage2.ImageKey = "icons8-lista-de-tarefas-32.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1010, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Receitas";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btnTelaEditarReceitas
            // 
            this.btnTelaEditarReceitas.AutoSize = false;
            this.btnTelaEditarReceitas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTelaEditarReceitas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTelaEditarReceitas.Depth = 0;
            this.btnTelaEditarReceitas.DrawShadows = false;
            this.btnTelaEditarReceitas.HighEmphasis = true;
            this.btnTelaEditarReceitas.Icon = global::MarkInBox_Gravação_PDT_110_F1.Properties.Resources.icons8_pencil_32;
            this.btnTelaEditarReceitas.Location = new System.Drawing.Point(17, 93);
            this.btnTelaEditarReceitas.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelaEditarReceitas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTelaEditarReceitas.Name = "btnTelaEditarReceitas";
            this.btnTelaEditarReceitas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTelaEditarReceitas.Size = new System.Drawing.Size(281, 40);
            this.btnTelaEditarReceitas.TabIndex = 1;
            this.btnTelaEditarReceitas.Text = "CADASTRAR/EDITAR/Deletar Receitas";
            this.btnTelaEditarReceitas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTelaEditarReceitas.UseAccentColor = false;
            this.btnTelaEditarReceitas.UseVisualStyleBackColor = true;
            this.btnTelaEditarReceitas.Click += new System.EventHandler(this.btnCadastrarEditarReceitas_Click);
            // 
            // materialListView1
            // 
            this.materialListView1.AccessibleName = "staticMaterialListView1";
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnDesenhoMotor,
            this.columnReceitaMarkinBox,
            this.columnLinha01,
            this.columnLinha02,
            this.columnLinha03,
            this.columnLinha04,
            this.columnLinha05});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.Location = new System.Drawing.Point(17, 139);
            this.materialListView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialListView1.MinimumSize = new System.Drawing.Size(175, 75);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(925, 489);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            // 
            // columnDesenhoMotor
            // 
            this.columnDesenhoMotor.Text = "Desenho do Motor";
            this.columnDesenhoMotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDesenhoMotor.Width = 200;
            // 
            // columnReceitaMarkinBox
            // 
            this.columnReceitaMarkinBox.Text = "Receita MarkinBox";
            this.columnReceitaMarkinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnReceitaMarkinBox.Width = 200;
            // 
            // columnLinha01
            // 
            this.columnLinha01.Text = "Linha 01";
            this.columnLinha01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnLinha01.Width = 230;
            // 
            // columnLinha02
            // 
            this.columnLinha02.Text = "Linha 02";
            this.columnLinha02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnLinha02.Width = 230;
            // 
            // columnLinha03
            // 
            this.columnLinha03.Text = "Linha 03";
            this.columnLinha03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnLinha03.Width = 230;
            // 
            // columnLinha04
            // 
            this.columnLinha04.Text = "Linha 04";
            this.columnLinha04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnLinha04.Width = 230;
            // 
            // columnLinha05
            // 
            this.columnLinha05.Text = "Linha 05";
            this.columnLinha05.Width = 230;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialListView3);
            this.tabPage3.Controls.Add(this.btnTelaCadastrarTextoFixo);
            this.tabPage3.Controls.Add(this.materialListView2);
            this.tabPage3.Controls.Add(this.btnTelaEditarCadastrarReceitasMarkinbox);
            this.tabPage3.ImageKey = "icons8-engineering-32.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1010, 675);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadastros Padrão";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // materialListView3
            // 
            this.materialListView3.AccessibleName = "staticMaterialListView2";
            this.materialListView3.AutoSizeTable = false;
            this.materialListView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idTextoFixo,
            this.numeroTextoFixo,
            this.textoFixo});
            this.materialListView3.Depth = 0;
            this.materialListView3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialListView3.FullRowSelect = true;
            this.materialListView3.Location = new System.Drawing.Point(660, 140);
            this.materialListView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialListView3.MinimumSize = new System.Drawing.Size(175, 75);
            this.materialListView3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView3.Name = "materialListView3";
            this.materialListView3.OwnerDraw = true;
            this.materialListView3.Size = new System.Drawing.Size(281, 489);
            this.materialListView3.TabIndex = 7;
            this.materialListView3.UseCompatibleStateImageBehavior = false;
            this.materialListView3.View = System.Windows.Forms.View.Details;
            // 
            // idTextoFixo
            // 
            this.idTextoFixo.Text = "Id";
            // 
            // numeroTextoFixo
            // 
            this.numeroTextoFixo.Text = "Número";
            this.numeroTextoFixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeroTextoFixo.Width = 100;
            // 
            // textoFixo
            // 
            this.textoFixo.Text = "Texto Fixo";
            this.textoFixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textoFixo.Width = 200;
            // 
            // btnTelaCadastrarTextoFixo
            // 
            this.btnTelaCadastrarTextoFixo.AutoSize = false;
            this.btnTelaCadastrarTextoFixo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTelaCadastrarTextoFixo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTelaCadastrarTextoFixo.Depth = 0;
            this.btnTelaCadastrarTextoFixo.DrawShadows = false;
            this.btnTelaCadastrarTextoFixo.HighEmphasis = true;
            this.btnTelaCadastrarTextoFixo.Icon = global::MarkInBox_Gravação_PDT_110_F1.Properties.Resources.icons8_pencil_32;
            this.btnTelaCadastrarTextoFixo.Location = new System.Drawing.Point(660, 94);
            this.btnTelaCadastrarTextoFixo.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelaCadastrarTextoFixo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTelaCadastrarTextoFixo.Name = "btnTelaCadastrarTextoFixo";
            this.btnTelaCadastrarTextoFixo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTelaCadastrarTextoFixo.Size = new System.Drawing.Size(281, 40);
            this.btnTelaCadastrarTextoFixo.TabIndex = 6;
            this.btnTelaCadastrarTextoFixo.Text = "CADASTRAR/EDITAR/DELETAR TEXTOS FIXOS";
            this.btnTelaCadastrarTextoFixo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTelaCadastrarTextoFixo.UseAccentColor = false;
            this.btnTelaCadastrarTextoFixo.UseVisualStyleBackColor = true;
            this.btnTelaCadastrarTextoFixo.Click += new System.EventHandler(this.btnTelaCadastrarTextoFixo_Click);
            // 
            // materialListView2
            // 
            this.materialListView2.AccessibleName = "staticMaterialListView2";
            this.materialListView2.AutoSizeTable = false;
            this.materialListView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idReceitaMarkinbox,
            this.numeroReceitaMarkinbox,
            this.nomeReceitaMarkinbox,
            this.numeroLinhas,
            this.tipoLinha01,
            this.tipoLinha02,
            this.tipoLinha03,
            this.tipoLinha04,
            this.tipoLinha05});
            this.materialListView2.Depth = 0;
            this.materialListView2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.Location = new System.Drawing.Point(18, 140);
            this.materialListView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialListView2.MinimumSize = new System.Drawing.Size(175, 75);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Size = new System.Drawing.Size(611, 489);
            this.materialListView2.TabIndex = 5;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            // 
            // idReceitaMarkinbox
            // 
            this.idReceitaMarkinbox.Text = "Id";
            // 
            // numeroReceitaMarkinbox
            // 
            this.numeroReceitaMarkinbox.Text = "Número";
            this.numeroReceitaMarkinbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeroReceitaMarkinbox.Width = 100;
            // 
            // nomeReceitaMarkinbox
            // 
            this.nomeReceitaMarkinbox.Text = "Nome";
            this.nomeReceitaMarkinbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nomeReceitaMarkinbox.Width = 150;
            // 
            // numeroLinhas
            // 
            this.numeroLinhas.Text = "Qtd. Linhas";
            this.numeroLinhas.Width = 120;
            // 
            // tipoLinha01
            // 
            this.tipoLinha01.Text = "Tipo Linha 01";
            this.tipoLinha01.Width = 150;
            // 
            // tipoLinha02
            // 
            this.tipoLinha02.Text = "Tipo Linha 02";
            this.tipoLinha02.Width = 150;
            // 
            // tipoLinha03
            // 
            this.tipoLinha03.Text = "Tipo linha 03";
            this.tipoLinha03.Width = 150;
            // 
            // tipoLinha04
            // 
            this.tipoLinha04.Text = "Tipo Linha 04";
            this.tipoLinha04.Width = 150;
            // 
            // tipoLinha05
            // 
            this.tipoLinha05.Text = "Tipo Linha 05";
            this.tipoLinha05.Width = 150;
            // 
            // btnTelaEditarCadastrarReceitasMarkinbox
            // 
            this.btnTelaEditarCadastrarReceitasMarkinbox.AutoSize = false;
            this.btnTelaEditarCadastrarReceitasMarkinbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTelaEditarCadastrarReceitasMarkinbox.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTelaEditarCadastrarReceitasMarkinbox.Depth = 0;
            this.btnTelaEditarCadastrarReceitasMarkinbox.DrawShadows = false;
            this.btnTelaEditarCadastrarReceitasMarkinbox.HighEmphasis = true;
            this.btnTelaEditarCadastrarReceitasMarkinbox.Icon = global::MarkInBox_Gravação_PDT_110_F1.Properties.Resources.icons8_pencil_32;
            this.btnTelaEditarCadastrarReceitasMarkinbox.Location = new System.Drawing.Point(18, 94);
            this.btnTelaEditarCadastrarReceitasMarkinbox.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelaEditarCadastrarReceitasMarkinbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTelaEditarCadastrarReceitasMarkinbox.Name = "btnTelaEditarCadastrarReceitasMarkinbox";
            this.btnTelaEditarCadastrarReceitasMarkinbox.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTelaEditarCadastrarReceitasMarkinbox.Size = new System.Drawing.Size(281, 40);
            this.btnTelaEditarCadastrarReceitasMarkinbox.TabIndex = 4;
            this.btnTelaEditarCadastrarReceitasMarkinbox.Text = "CADASTRAR/EDITAR/DELETAR RECEITAS MARKINBOX";
            this.btnTelaEditarCadastrarReceitasMarkinbox.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTelaEditarCadastrarReceitasMarkinbox.UseAccentColor = false;
            this.btnTelaEditarCadastrarReceitasMarkinbox.UseVisualStyleBackColor = true;
            this.btnTelaEditarCadastrarReceitasMarkinbox.Click += new System.EventHandler(this.btnTelaEditarCadastrarReceitasMarkinbox_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-lista-de-tarefas-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-página-inicial-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-engineering-32.png");
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Padding = new System.Windows.Forms.Padding(3, 48, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Conecsa MarkinBox V1.0.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_Closed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerCOM;
        private Button btnCadastrarReceitas;
        private TextBox desenhoMotor;
        private TextBox receitaMarkinbox;
        private TextBox linha01;
        private TextBox linha02;
        private TextBox linha03;
        private TextBox linha04;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox comboBox1;
        private MaterialSkin.Controls.MaterialButton btnConectar;
        private MaterialSkin.Controls.MaterialButton btnStartGravacao;
        private ColumnHeader columnId;
        private ColumnHeader columnDesenhoMotor;
        private ColumnHeader columnReceitaMarkinBox;
        private ColumnHeader columnLinha01;
        private ColumnHeader columnLinha02;
        private ColumnHeader columnLinha03;
        private ColumnHeader columnLinha04;
        private MaterialSkin.Controls.MaterialButton btnTelaEditarReceitas;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox tbLeituraReceita;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox tbLeituraMatricula;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox tbLeituraDesenho;
        public MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox tbLeituraLinha04;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox tbLeituraLinha03;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox tbLeituraLinha02;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox tbLeituraLinha01;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckbox checkStartAutomatico;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox tbLeituraLinha05;
        private TabPage tabPage3;
        public MaterialSkin.Controls.MaterialListView materialListView2;
        private ColumnHeader id;
        private ColumnHeader nome;
        private ColumnHeader numero;
        private MaterialSkin.Controls.MaterialButton btnTelaEditarCadastrarReceitasMarkinbox;
        public MaterialSkin.Controls.MaterialListView materialListView3;
        private ColumnHeader idTextoFixo;
        private ColumnHeader numeroTextoFixo;
        private ColumnHeader textoFixo;
        private MaterialSkin.Controls.MaterialButton btnTelaRelatorios;
        private ColumnHeader idReceitaMarkinbox;
        private ColumnHeader numeroReceitaMarkinbox;
        private ColumnHeader nomeReceitaMarkinbox;
        private MaterialSkin.Controls.MaterialButton btnTelaCadastrarTextoFixo;
        private ColumnHeader columnLinha05;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialTextBox tbLeituraClassificacao;
        private ColumnHeader numeroLinhas;
        private ColumnHeader tipoLinha01;
        private ColumnHeader tipoLinha02;
        private ColumnHeader tipoLinha03;
        private ColumnHeader tipoLinha04;
        private ColumnHeader tipoLinha05;
        private PictureBox pictureBox1;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialCheckbox checkGravarMatriculaRepetida;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialButton btnZerarValores;
        private ToolTip tipBotaoStart;
    }
}