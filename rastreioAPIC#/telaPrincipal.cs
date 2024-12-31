using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rastreioAPIC_.API;
using static rastreioAPIC_.telaCadastro;

namespace rastreioAPIC_
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telaCadastro telacadastro = new telaCadastro();
            telacadastro.ShowDialog();
        }



        private async void buscar_Click(object sender, EventArgs e) {
            buscar buscar =  new buscar();
            dynamic produtos = await buscar.buscarProdutos();

            foreach (var prod in produtos) {
                Console.WriteLine(prod);

            }

            telaBuscarProduto telaBuscarProduto = new telaBuscarProduto(produtos);
            telaBuscarProduto.ShowDialog();

            

        }
    }
}
