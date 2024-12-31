using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rastreioAPIC_.API;

namespace rastreioAPIC_ {
    public partial class telaBuscarProduto : Form {
        private DataTable table;
        public telaBuscarProduto(dynamic produtos) {
            InitializeComponent();
            InicializarTabela();
            PreencherTabela(produtos);
        }


        //DataTable table = new DataTable();
        //table.Columns.Add("Nome", typeof(string));
        //table.Columns.Add("Código de Rastreio", typeof(string));
        //table.Columns.Add("Data", typeof(string));
        //table.Columns.Add("Destino", typeof(string));

        //table.Rows.Add("Produto 1", "2424", "31/12/2024", "Casa");
        //table.Rows.Add("Produto 2", "2425", "01/01/2025", "Escritório");
        //table.Rows.Add("Produto 3", "2426", "05/01/2025", "Loja");

        private void InicializarTabela() {
            table = new DataTable();
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Código de Rastreio", typeof(string));
            table.Columns.Add("Data", typeof(string));
            table.Columns.Add("Destino", typeof(string));
            table.Columns.Add("Ação", typeof(string));

            dataGridView.DataSource = table;  // Conecta o DataTable ao DataGridView

            // Mantém o tamanho do DataGridView conforme definido no Designer
            dataGridView.Dock = DockStyle.None;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adiciona um botão de ação
            DataGridViewButtonColumn botaoAcao = new DataGridViewButtonColumn();
            botaoAcao.Name = "Ação";
            botaoAcao.HeaderText = "Ação";
            botaoAcao.Text = "Rastreio Detalhado";
            botaoAcao.UseColumnTextForButtonValue = true;  // Exibe o texto como botão
            dataGridView.Columns.Add(botaoAcao);
        }

        private void PreencherTabela(dynamic produtos) {
            foreach (var prod in produtos) {
                string nome = prod.shipmentReference ?? "N/A";
                string trackingNumber = prod.trackingNumber ?? "N/A";
                string data = prod.createdAt ?? "N/A";
                string destino = prod.destino ?? "N/A";

                table.Rows.Add(nome, trackingNumber, data, destino, "Ação");  // table está acessível aqui
            }
        }

        // Caso precise interagir com a célula
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Ação" && e.RowIndex >= 0) {
                string codigoDeRastreio = dataGridView.Rows[e.RowIndex].Cells["Código de Rastreio"].Value.ToString();



                //Console.WriteLine($"Você clicou no trackingNumber: {codigoDeRastreio}");
            }
        }
    }
}
