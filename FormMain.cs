using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace JabRegister
{
    public partial class FormMain : MaterialForm
    {
        cl_user user = new cl_user();
        cl_controluser controlUser = new cl_controluser();

        public FormMain()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900,
                Primary.Blue900, Accent.Orange200,
                TextShade.WHITE
            );
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nm = txtName.Text;
            string cpf = txtCpf.Text.Replace("_", "");
            string tel = txtTel.Text.Replace("_", "");
            string email = txtEmail.Text.Replace(" ", "");
            string genero = (rdoGenF.Checked ? "F" : (rdoGenM.Checked ? "M" : (rdoGenO.Checked ? "O" : "?")));
            string endereco = txtEndereco.Text;
            string dtNasc = dtpDtNasc.Value.ToString("yyyy-MM-dd");

            // Verificação Simples
            if (nm.Length < 3 || cpf.Length < 14 || tel.Length < 14 || email.Length < 3 || endereco.Length < 3 || genero == "?")
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
            }
            else
            {
                user.Nome = nm;
                user.Cpf = cpf;
                user.Tel = tel;
                user.Email = email;
                user.Genero = genero;
                user.Endereco = endereco;
                user.Dtnasc = dtNasc;

                MessageBox.Show(
                    controlUser.register(user) //Retorna uma string
                );
            }
        }
    }
}
