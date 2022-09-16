using Infra;
using System;
using System.Data;
using System.Windows.Forms;
using BLL;

namespace UIPrincipal
{
    public partial class Login : Form
    {
        public bool Logou;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            logoopbx.ImageLocation = Environment.CurrentDirectory + @"\Imagens\ImagemLongin.png";
            logoPbx.ImageLocation = Environment.CurrentDirectory + @"\Imagens\senai_logo.png";
        }

        private void SAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salvarString_Click(object sender, EventArgs e)
        {
            UsuarioLogado.conexaoAtual = cBxServidorBanco.Text;
            ArquivoBanco.Gravarbanco(Convert.ToString(cBxServidorBanco.Text));
        }
        /*###################################################################################################################################*/
        private void AbrirFormEnPanel(object Formhijo) //formulario sobre formulario
        {
            if (this.panelConteiner.Controls.Count > 0)
                this.panelConteiner.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelConteiner.Controls.Add(fh);
            this.panelConteiner.Tag = fh;
            fh.Show();
        }

        private void AddServidor_Click(object sender, EventArgs e) // abrindo o formulario dentro do painel
        {
            AbrirFormEnPanel(new FormAddServidor());
            logoopbx.Visible = true;                    //quando o formulario for fechado torna a pintureBox visivel
            panelConteiner.Controls.Add(logoopbx);      //add o a pintureBox novamente
        }
        /*###################################################################################################################################*/

        private void cBxServidorBanco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logar_Click(object sender, EventArgs e)
        {
            string nome;
            string senha;

            AgenteBLL agenteBLL = new AgenteBLL();
            BindingSource AgenteBindingSource = new BindingSource();
            AgenteBindingSource.DataSource = agenteBLL.Buscar(textBoxUsuario.Text);

            ProfessorBLL professorBLL = new ProfessorBLL();
            BindingSource professorBindingSource = new BindingSource();
            professorBindingSource.DataSource = professorBLL.Buscar(textBoxUsuario.Text);

            AlunoBLL alunoBLL = new AlunoBLL();
            BindingSource alunoBindingSource = new BindingSource();
            alunoBindingSource.DataSource = alunoBLL.Buscar(textBoxUsuario.Text);

            /* COMEÇO DE VALIDAÇÃO DE SENHA E USUARIO COM CONDIÇÕES */

            if (AgenteBindingSource.Count != 0)
            {
                nome = ((DataRowView)AgenteBindingSource.Current).Row["NomeUsuario"].ToString();
                senha = ((DataRowView)AgenteBindingSource.Current).Row["Senha"].ToString();


                // if (nome == textBoxUsuario.Text && Infra.Criptografia.verificarHash(textBoxSenha.Text, senha))
                if (nome == textBoxUsuario.Text && senha == textBoxSenha.Text)
                {
                    Logou = true;
                    this.Visible = !this.Visible;
                    using (PrincipalAgente frn = new PrincipalAgente())
                    {
                        frn.ShowDialog();
                    }
                    this.Visible = !this.Visible;
                    Close();
                }

            }
            else
            {
                if (professorBindingSource.Count != 0)
                {
                    nome = ((DataRowView)professorBindingSource.Current).Row["NomeUsuario"].ToString();
                    senha = ((DataRowView)professorBindingSource.Current).Row["Senha"].ToString();
                    if (nome == textBoxUsuario.Text && Infra.Criptografia.verificarHash(textBoxSenha.Text, senha))
                    {
                        Logou = true;
                        this.Visible = !this.Visible;
                        using (PrincipalProfessor frn = new PrincipalProfessor())
                        {
                            frn.ShowDialog();
                        }
                        this.Visible = !this.Visible;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("USUÁRIO OU SENHA INCORRETOS!");
                        textBoxSenha.Text = "";
                        textBoxSenha.Focus();
                    }
                }

                else
                {
                    if (alunoBindingSource.Count != 0)
                    {
                        nome = ((DataRowView)alunoBindingSource.Current).Row["NomeUsuario"].ToString();
                        senha = ((DataRowView)alunoBindingSource.Current).Row["Senha"].ToString();

                        if (nome == textBoxUsuario.Text && Infra.Criptografia.verificarHash(textBoxSenha.Text, senha))
                        {
                            Logou = true;
                            this.Visible = !this.Visible;
                            using (PrincipalAluno frn = new PrincipalAluno())
                            {
                                frn.ShowDialog();
                            }
                            this.Visible = !this.Visible;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("USUÁRIO OU SENHA INCORRETOS!");
                            textBoxSenha.Text = "";
                            textBoxSenha.Focus();
                        }
                    }

                    else
                    {
                        MessageBox.Show("USUÁRIO OU SENHA INCORRETOS!");
                        textBoxSenha.Text = "";
                        textBoxSenha.Focus();
                    }/* AGENTE PEDAGOGICO VALIDAÇÃO */
                }
            }

        }
    }
}
