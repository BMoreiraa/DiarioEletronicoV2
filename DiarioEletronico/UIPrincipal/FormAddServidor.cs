using Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormAddServidor : Form
    {
        public FormAddServidor()
        {
            InitializeComponent();
        }

        private void groupBoxDadosBancoSQL_Enter(object sender, EventArgs e)
        {
            //groupBoxDadosBancoSQL.
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string dadosLogin = $"User ID = {textBoxUsuario.Text}; Password = {textBoxSenha.Text}";

            if (checkBoxAutenticacaoWindows.Checked)
                dadosLogin = "Integrated Security = True";

            if (checkBoxDiretorioLocal.Checked)
                textBoxNomeMaquinaLocalOuIP.Text = ".";

            string stringDeConexao = $@"{textBoxNomeServidor.Text}|Initial Catalog = {textBoxNomeBanco.Text}; Data Source = {textBoxNomeMaquinaLocalOuIP.Text}\{textBoxVersaoSQL.Text}; {dadosLogin}";
            ArquivoBanco.GravaStringDeConexaoNoArquivo(stringDeConexao);
            Close();


        }
    }
}
