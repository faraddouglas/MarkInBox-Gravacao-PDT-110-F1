namespace MarkInBox_Gravação_PDT_110_F1 {
    partial class Relatorios {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnBuscarRelatorio = new MaterialSkin.Controls.MaterialButton();
            this.btnExportarExcel = new MaterialSkin.Controls.MaterialButton();
            this.tbMatricula = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbDateTimeInicial = new System.Windows.Forms.MaskedTextBox();
            this.tbDateTimeFinal = new System.Windows.Forms.MaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.desenhoMotor = new System.Windows.Forms.ColumnHeader();
            this.receitaMarkinbox = new System.Windows.Forms.ColumnHeader();
            this.numeroLinhas = new System.Windows.Forms.ColumnHeader();
            this.linha01 = new System.Windows.Forms.ColumnHeader();
            this.linha02 = new System.Windows.Forms.ColumnHeader();
            this.linha03 = new System.Windows.Forms.ColumnHeader();
            this.linha04 = new System.Windows.Forms.ColumnHeader();
            this.linha05 = new System.Windows.Forms.ColumnHeader();
            this.dataGravacao = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnBuscarRelatorio
            // 
            this.btnBuscarRelatorio.AutoSize = false;
            this.btnBuscarRelatorio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarRelatorio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarRelatorio.Depth = 0;
            this.btnBuscarRelatorio.HighEmphasis = true;
            this.btnBuscarRelatorio.Icon = null;
            this.btnBuscarRelatorio.Location = new System.Drawing.Point(761, 81);
            this.btnBuscarRelatorio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarRelatorio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarRelatorio.Name = "btnBuscarRelatorio";
            this.btnBuscarRelatorio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarRelatorio.Size = new System.Drawing.Size(158, 36);
            this.btnBuscarRelatorio.TabIndex = 0;
            this.btnBuscarRelatorio.Text = "Buscar";
            this.btnBuscarRelatorio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarRelatorio.UseAccentColor = false;
            this.btnBuscarRelatorio.UseVisualStyleBackColor = true;
            this.btnBuscarRelatorio.Click += new System.EventHandler(this.btnBuscarRelatorio_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AutoSize = false;
            this.btnExportarExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportarExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportarExcel.Depth = 0;
            this.btnExportarExcel.HighEmphasis = true;
            this.btnExportarExcel.Icon = null;
            this.btnExportarExcel.Location = new System.Drawing.Point(761, 126);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportarExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportarExcel.Size = new System.Drawing.Size(158, 36);
            this.btnExportarExcel.TabIndex = 1;
            this.btnExportarExcel.Text = "Exportar";
            this.btnExportarExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportarExcel.UseAccentColor = false;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // tbMatricula
            // 
            this.tbMatricula.AnimateReadOnly = false;
            this.tbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMatricula.Depth = 0;
            this.tbMatricula.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMatricula.LeadingIcon = null;
            this.tbMatricula.Location = new System.Drawing.Point(23, 112);
            this.tbMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMatricula.MaxLength = 11;
            this.tbMatricula.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMatricula.Multiline = false;
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(178, 50);
            this.tbMatricula.TabIndex = 4;
            this.tbMatricula.Text = "";
            this.tbMatricula.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(23, 91);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Matrícula";
            // 
            // tbDateTimeInicial
            // 
            this.tbDateTimeInicial.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDateTimeInicial.Location = new System.Drawing.Point(311, 126);
            this.tbDateTimeInicial.Mask = "00/00/0000 90:00";
            this.tbDateTimeInicial.Name = "tbDateTimeInicial";
            this.tbDateTimeInicial.Size = new System.Drawing.Size(195, 36);
            this.tbDateTimeInicial.TabIndex = 7;
            this.tbDateTimeInicial.ValidatingType = typeof(System.DateTime);
            // 
            // tbDateTimeFinal
            // 
            this.tbDateTimeFinal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDateTimeFinal.Location = new System.Drawing.Point(521, 126);
            this.tbDateTimeFinal.Mask = "00/00/0000 90:00";
            this.tbDateTimeFinal.Name = "tbDateTimeFinal";
            this.tbDateTimeFinal.Size = new System.Drawing.Size(195, 36);
            this.tbDateTimeFinal.TabIndex = 8;
            this.tbDateTimeFinal.ValidatingType = typeof(System.DateTime);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(241, 136);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(19, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "ou";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(311, 91);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Data inicial";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(521, 91);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(71, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Data finla";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.desenhoMotor,
            this.receitaMarkinbox,
            this.numeroLinhas,
            this.linha01,
            this.linha02,
            this.linha03,
            this.linha04,
            this.linha05,
            this.dataGravacao});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.Location = new System.Drawing.Point(23, 193);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(896, 429);
            this.materialListView1.TabIndex = 12;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            // 
            // desenhoMotor
            // 
            this.desenhoMotor.Text = "Desenho";
            this.desenhoMotor.Width = 120;
            // 
            // receitaMarkinbox
            // 
            this.receitaMarkinbox.Text = "Receita Mark.";
            this.receitaMarkinbox.Width = 180;
            // 
            // numeroLinhas
            // 
            this.numeroLinhas.Text = "Nº Linhas";
            this.numeroLinhas.Width = 120;
            // 
            // linha01
            // 
            this.linha01.Text = "Linha 01";
            this.linha01.Width = 150;
            // 
            // linha02
            // 
            this.linha02.Text = "Linha 02";
            this.linha02.Width = 150;
            // 
            // linha03
            // 
            this.linha03.Text = "Linha 03";
            this.linha03.Width = 150;
            // 
            // linha04
            // 
            this.linha04.Text = "Linha 04";
            this.linha04.Width = 150;
            // 
            // linha05
            // 
            this.linha05.Text = "Linha 05";
            this.linha05.Width = 150;
            // 
            // dataGravacao
            // 
            this.dataGravacao.Text = "Data";
            this.dataGravacao.Width = 200;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 645);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.tbDateTimeFinal);
            this.Controls.Add(this.tbDateTimeInicial);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnBuscarRelatorio);
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.Relatorios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnBuscarRelatorio;
        private MaterialSkin.Controls.MaterialButton btnExportarExcel;
        private MaterialSkin.Controls.MaterialTextBox tbMatricula;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaskedTextBox tbDateTimeInicial;
        private MaskedTextBox tbDateTimeFinal;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader id;
        private ColumnHeader desenhoMotor;
        private ColumnHeader receitaMarkinbox;
        private ColumnHeader numeroLinhas;
        private ColumnHeader linha01;
        private ColumnHeader linha02;
        private ColumnHeader linha03;
        private ColumnHeader linha04;
        private ColumnHeader linha05;
        private ColumnHeader dataGravacao;
    }
}