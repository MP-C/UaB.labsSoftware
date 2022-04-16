using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Formulario_correto
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void btnEfetuarDonativo_Click(object sender, EventArgs e)
        {
            Donativo donativo = new Donativo();
            donativo.Nome = txtNome.Text;
            donativo.Morada = txtMorada.Text;
            donativo.CodigoPostal = txtCodigoPostal.Text;
            donativo.Cidade = txtCidade.Text;
            donativo.Pais = txtPais.Text;  
            donativo.Telemovel = txtTelemovel.Text;
            donativo.Valor = float.Parse(txtValor.Text);
            donativo.Anonimato = comboAnonimato.Text;
            donativo.Mensagem = txtMensagem.Text;

            //Environment.ExpandEnvironmentVariables("%AppData%\\aquivo.json");
            //string fileName = Environment.ExpandEnvironmentVariables(@"%AppData%\arquivo.json");
            //string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string fileName = (@"C:\Users\gonca\Desktop\Desenvolvimento de Software\Json_teste\arquivo.json");

            String existingFileContents = File.ReadAllText(fileName);


            FicheiroDonativos json = JsonConvert.DeserializeObject<FicheiroDonativos>(existingFileContents);

            
            json.donativos.Add(donativo);

            //Confirmação aqui antes de acrescentar
            if (MessageBox.Show("Pretende confirmar o donativo?", "Confirmação de Donativo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("O seu donativo no valor de "+ donativo.Valor +" euros foi efetuado com sucesso.", "Donativo efetuado", MessageBoxButtons.OK);
            }
            else
            {
                this.Activate();
            }


            String newFileContents = JsonConvert.SerializeObject(json, Formatting.Indented);
            File.WriteAllText(fileName, newFileContents);
            /**
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\gonca\Desktop\Desenvolvimento de Software\Json_teste\arquivo.json"))
                {
                    sw.WriteLine(donativo.JsonSerializar(donativo));
                }
                MessageBox.Show("Donativo efectuado. Obrigado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }*/
            decimal total = json.donativos.Sum(x => Convert.ToDecimal(x.Valor));
            MessageBox.Show("Total de donativos efetuados até ao momento " + total + " euros.", "Total de Donativos", MessageBoxButtons.OK);
            //MessageBox.Show("Total: " + total);
            Application.Exit();

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
           /** if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            **/
        }

        private void txtTelemovel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende fechar a aplicação?", "Fechar Aplicação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("A aplicação foi fechada com sucesso.", "Aplicação Encerrada!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void txtTelemovel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que a tecla CTRL não está acionada ou qualquer caracter não numérico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que a tecla CTRL não está acionada ou qualquer caracter não numérico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que a tecla CTRL não está acionada ou qualquer caracter não numérico
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Recebe apenas Alfabeto
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Recebe apenas Alfabeto
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Recebe apenas Alfabeto
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
