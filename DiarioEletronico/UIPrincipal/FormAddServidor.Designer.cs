
namespace UIPrincipal
{
    partial class FormAddServidor
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
            this.groupBoxDadosBancoSQL = new System.Windows.Forms.GroupBox();
            this.textBoxNomeBanco = new System.Windows.Forms.TextBox();
            this.labelNomeBanco = new System.Windows.Forms.Label();
            this.textBoxVersaoSQL = new System.Windows.Forms.TextBox();
            this.labelVersaoSQL = new System.Windows.Forms.Label();
            this.labelNomeServidor = new System.Windows.Forms.Label();
            this.textBoxNomeServidor = new System.Windows.Forms.TextBox();
            this.panelAddServidor = new System.Windows.Forms.Panel();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxDadosServidor = new System.Windows.Forms.GroupBox();
            this.checkBoxDiretorioLocal = new System.Windows.Forms.CheckBox();
            this.textBoxNomeMaquinaLocalOuIP = new System.Windows.Forms.TextBox();
            this.labelNomeMaquinaPC = new System.Windows.Forms.Label();
            this.groupBoxDadosLogin = new System.Windows.Forms.GroupBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.checkBoxAutenticacaoWindows = new System.Windows.Forms.CheckBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxDadosBancoSQL.SuspendLayout();
            this.panelAddServidor.SuspendLayout();
            this.groupBoxDadosServidor.SuspendLayout();
            this.groupBoxDadosLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDadosBancoSQL
            // 
            this.groupBoxDadosBancoSQL.Controls.Add(this.textBoxNomeBanco);
            this.groupBoxDadosBancoSQL.Controls.Add(this.labelNomeBanco);
            this.groupBoxDadosBancoSQL.Controls.Add(this.textBoxVersaoSQL);
            this.groupBoxDadosBancoSQL.Controls.Add(this.labelVersaoSQL);
            this.groupBoxDadosBancoSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxDadosBancoSQL.ForeColor = System.Drawing.Color.White;
            this.groupBoxDadosBancoSQL.Location = new System.Drawing.Point(69, 89);
            this.groupBoxDadosBancoSQL.Name = "groupBoxDadosBancoSQL";
            this.groupBoxDadosBancoSQL.Size = new System.Drawing.Size(344, 85);
            this.groupBoxDadosBancoSQL.TabIndex = 20;
            this.groupBoxDadosBancoSQL.TabStop = false;
            this.groupBoxDadosBancoSQL.Text = "DADOS DO BANCO SQL";
            // 
            // textBoxNomeBanco
            // 
            this.textBoxNomeBanco.Location = new System.Drawing.Point(9, 39);
            this.textBoxNomeBanco.Name = "textBoxNomeBanco";
            this.textBoxNomeBanco.Size = new System.Drawing.Size(130, 24);
            this.textBoxNomeBanco.TabIndex = 0;
            // 
            // labelNomeBanco
            // 
            this.labelNomeBanco.AutoSize = true;
            this.labelNomeBanco.ForeColor = System.Drawing.Color.White;
            this.labelNomeBanco.Location = new System.Drawing.Point(6, 19);
            this.labelNomeBanco.Name = "labelNomeBanco";
            this.labelNomeBanco.Size = new System.Drawing.Size(138, 17);
            this.labelNomeBanco.TabIndex = 7;
            this.labelNomeBanco.Text = "NOME DO BANCO:";
            // 
            // textBoxVersaoSQL
            // 
            this.textBoxVersaoSQL.Location = new System.Drawing.Point(145, 39);
            this.textBoxVersaoSQL.Name = "textBoxVersaoSQL";
            this.textBoxVersaoSQL.Size = new System.Drawing.Size(122, 24);
            this.textBoxVersaoSQL.TabIndex = 1;
            // 
            // labelVersaoSQL
            // 
            this.labelVersaoSQL.AutoSize = true;
            this.labelVersaoSQL.ForeColor = System.Drawing.Color.White;
            this.labelVersaoSQL.Location = new System.Drawing.Point(142, 19);
            this.labelVersaoSQL.Name = "labelVersaoSQL";
            this.labelVersaoSQL.Size = new System.Drawing.Size(171, 17);
            this.labelVersaoSQL.TabIndex = 8;
            this.labelVersaoSQL.Text = "VERSAO SQL SERVER:";
            // 
            // labelNomeServidor
            // 
            this.labelNomeServidor.AutoSize = true;
            this.labelNomeServidor.ForeColor = System.Drawing.Color.White;
            this.labelNomeServidor.Location = new System.Drawing.Point(69, 28);
            this.labelNomeServidor.Name = "labelNomeServidor";
            this.labelNomeServidor.Size = new System.Drawing.Size(163, 17);
            this.labelNomeServidor.TabIndex = 21;
            this.labelNomeServidor.Text = "NOME DO SERVIDOR:";
            // 
            // textBoxNomeServidor
            // 
            this.textBoxNomeServidor.Location = new System.Drawing.Point(69, 48);
            this.textBoxNomeServidor.Name = "textBoxNomeServidor";
            this.textBoxNomeServidor.Size = new System.Drawing.Size(344, 24);
            this.textBoxNomeServidor.TabIndex = 19;
            // 
            // panelAddServidor
            // 
            this.panelAddServidor.BackColor = System.Drawing.Color.Black;
            this.panelAddServidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAddServidor.Controls.Add(this.button2);
            this.panelAddServidor.Controls.Add(this.button1);
            this.panelAddServidor.Controls.Add(this.groupBoxDadosLogin);
            this.panelAddServidor.Controls.Add(this.groupBoxDadosServidor);
            this.panelAddServidor.Controls.Add(this.groupBoxDadosBancoSQL);
            this.panelAddServidor.Controls.Add(this.buttonSalvar);
            this.panelAddServidor.Controls.Add(this.labelNomeServidor);
            this.panelAddServidor.Controls.Add(this.buttonCancelar);
            this.panelAddServidor.Controls.Add(this.textBoxNomeServidor);
            this.panelAddServidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddServidor.Location = new System.Drawing.Point(0, 0);
            this.panelAddServidor.Name = "panelAddServidor";
            this.panelAddServidor.Size = new System.Drawing.Size(484, 461);
            this.panelAddServidor.TabIndex = 22;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Location = new System.Drawing.Point(668, 312);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(749, 312);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBoxDadosServidor
            // 
            this.groupBoxDadosServidor.Controls.Add(this.checkBoxDiretorioLocal);
            this.groupBoxDadosServidor.Controls.Add(this.textBoxNomeMaquinaLocalOuIP);
            this.groupBoxDadosServidor.Controls.Add(this.labelNomeMaquinaPC);
            this.groupBoxDadosServidor.ForeColor = System.Drawing.Color.White;
            this.groupBoxDadosServidor.Location = new System.Drawing.Point(69, 189);
            this.groupBoxDadosServidor.Name = "groupBoxDadosServidor";
            this.groupBoxDadosServidor.Size = new System.Drawing.Size(344, 95);
            this.groupBoxDadosServidor.TabIndex = 22;
            this.groupBoxDadosServidor.TabStop = false;
            this.groupBoxDadosServidor.Text = "DADOS DA MAQUINA SERVIDOR";
            // 
            // checkBoxDiretorioLocal
            // 
            this.checkBoxDiretorioLocal.AutoSize = true;
            this.checkBoxDiretorioLocal.ForeColor = System.Drawing.Color.White;
            this.checkBoxDiretorioLocal.Location = new System.Drawing.Point(39, 69);
            this.checkBoxDiretorioLocal.Name = "checkBoxDiretorioLocal";
            this.checkBoxDiretorioLocal.Size = new System.Drawing.Size(156, 21);
            this.checkBoxDiretorioLocal.TabIndex = 1;
            this.checkBoxDiretorioLocal.Text = "Usar Diretorio Local";
            this.checkBoxDiretorioLocal.UseVisualStyleBackColor = true;
            // 
            // textBoxNomeMaquinaLocalOuIP
            // 
            this.textBoxNomeMaquinaLocalOuIP.Location = new System.Drawing.Point(34, 40);
            this.textBoxNomeMaquinaLocalOuIP.Name = "textBoxNomeMaquinaLocalOuIP";
            this.textBoxNomeMaquinaLocalOuIP.Size = new System.Drawing.Size(219, 24);
            this.textBoxNomeMaquinaLocalOuIP.TabIndex = 0;
            // 
            // labelNomeMaquinaPC
            // 
            this.labelNomeMaquinaPC.AutoSize = true;
            this.labelNomeMaquinaPC.ForeColor = System.Drawing.Color.White;
            this.labelNomeMaquinaPC.Location = new System.Drawing.Point(37, 20);
            this.labelNomeMaquinaPC.Name = "labelNomeMaquinaPC";
            this.labelNomeMaquinaPC.Size = new System.Drawing.Size(189, 17);
            this.labelNomeMaquinaPC.TabIndex = 12;
            this.labelNomeMaquinaPC.Text = "IP OU NOME DA MAQUINA:";
            // 
            // groupBoxDadosLogin
            // 
            this.groupBoxDadosLogin.Controls.Add(this.textBoxUsuario);
            this.groupBoxDadosLogin.Controls.Add(this.checkBoxAutenticacaoWindows);
            this.groupBoxDadosLogin.Controls.Add(this.textBoxSenha);
            this.groupBoxDadosLogin.Controls.Add(this.labelUsuario);
            this.groupBoxDadosLogin.Controls.Add(this.labelSenha);
            this.groupBoxDadosLogin.ForeColor = System.Drawing.Color.White;
            this.groupBoxDadosLogin.Location = new System.Drawing.Point(69, 290);
            this.groupBoxDadosLogin.Name = "groupBoxDadosLogin";
            this.groupBoxDadosLogin.Size = new System.Drawing.Size(344, 85);
            this.groupBoxDadosLogin.TabIndex = 23;
            this.groupBoxDadosLogin.TabStop = false;
            this.groupBoxDadosLogin.Text = "DADOS DE LOGIN";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(9, 35);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(133, 24);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // checkBoxAutenticacaoWindows
            // 
            this.checkBoxAutenticacaoWindows.AutoSize = true;
            this.checkBoxAutenticacaoWindows.ForeColor = System.Drawing.Color.White;
            this.checkBoxAutenticacaoWindows.Location = new System.Drawing.Point(9, 61);
            this.checkBoxAutenticacaoWindows.Name = "checkBoxAutenticacaoWindows";
            this.checkBoxAutenticacaoWindows.Size = new System.Drawing.Size(230, 21);
            this.checkBoxAutenticacaoWindows.TabIndex = 2;
            this.checkBoxAutenticacaoWindows.Text = "Usar Autenticação do Windows";
            this.checkBoxAutenticacaoWindows.UseVisualStyleBackColor = true;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(148, 35);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(190, 24);
            this.textBoxSenha.TabIndex = 1;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(6, 19);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(77, 17);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "USUARIO:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(145, 19);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(61, 17);
            this.labelSenha.TabIndex = 10;
            this.labelSenha.Text = "SENHA:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(71, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(326, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 25;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormAddServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelAddServidor);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormAddServidor";
            this.ShowIcon = false;
            this.groupBoxDadosBancoSQL.ResumeLayout(false);
            this.groupBoxDadosBancoSQL.PerformLayout();
            this.panelAddServidor.ResumeLayout(false);
            this.panelAddServidor.PerformLayout();
            this.groupBoxDadosServidor.ResumeLayout(false);
            this.groupBoxDadosServidor.PerformLayout();
            this.groupBoxDadosLogin.ResumeLayout(false);
            this.groupBoxDadosLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDadosBancoSQL;
        private System.Windows.Forms.TextBox textBoxNomeBanco;
        private System.Windows.Forms.Label labelNomeBanco;
        private System.Windows.Forms.TextBox textBoxVersaoSQL;
        private System.Windows.Forms.Label labelVersaoSQL;
        private System.Windows.Forms.Label labelNomeServidor;
        private System.Windows.Forms.TextBox textBoxNomeServidor;
        private System.Windows.Forms.Panel panelAddServidor;
        private System.Windows.Forms.GroupBox groupBoxDadosServidor;
        private System.Windows.Forms.CheckBox checkBoxDiretorioLocal;
        private System.Windows.Forms.TextBox textBoxNomeMaquinaLocalOuIP;
        private System.Windows.Forms.Label labelNomeMaquinaPC;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxDadosLogin;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.CheckBox checkBoxAutenticacaoWindows;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
    }
}