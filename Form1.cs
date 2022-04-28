using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2_Solucao_Exe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarPasta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pastaEscolhida = new FolderBrowserDialog();
            //alterando a propriedade para exibir o botão Nova pasta
            pastaEscolhida.ShowNewFolderButton = true;

            DialogResult result = pastaEscolhida.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = pastaEscolhida.SelectedPath;
                Environment.SpecialFolder root = pastaEscolhida.RootFolder;
            }


        }
    }
}
