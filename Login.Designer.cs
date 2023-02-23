namespace MarkInBox_Gravação_PDT_110_F1 {
    partial class Login {
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.tbSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.tbUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(111, 150);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Usuário:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(120, 229);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Senha:";
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = false;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = global::MarkInBox_Gravação_PDT_110_F1.Properties.Resources.icons8_login_rounded_32;
            this.btnLogout.Location = new System.Drawing.Point(97, 318);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(198, 45);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Cancelar";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = global::MarkInBox_Gravação_PDT_110_F1.Properties.Resources.icons8_logout_rounded_32;
            this.btnLogin.Location = new System.Drawing.Point(327, 318);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(198, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = true;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.AnimateReadOnly = false;
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenha.Depth = 0;
            this.tbSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSenha.LeadingIcon = null;
            this.tbSenha.Location = new System.Drawing.Point(188, 213);
            this.tbSenha.MaxLength = 8;
            this.tbSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSenha.Multiline = false;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Password = true;
            this.tbSenha.Size = new System.Drawing.Size(312, 50);
            this.tbSenha.TabIndex = 3;
            this.tbSenha.Text = "";
            this.tbSenha.TrailingIcon = null;
            // 
            // tbUsuario
            // 
            this.tbUsuario.AnimateReadOnly = false;
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuario.Depth = 0;
            this.tbUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUsuario.LeadingIcon = null;
            this.tbUsuario.Location = new System.Drawing.Point(188, 134);
            this.tbUsuario.MaxLength = 50;
            this.tbUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUsuario.Multiline = false;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(312, 50);
            this.tbUsuario.TabIndex = 2;
            this.tbUsuario.Text = "";
            this.tbUsuario.TrailingIcon = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 437);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.VisibleChanged += new System.EventHandler(this.Login_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialTextBox tbSenha;
        private MaterialSkin.Controls.MaterialTextBox tbUsuario;
    }
}