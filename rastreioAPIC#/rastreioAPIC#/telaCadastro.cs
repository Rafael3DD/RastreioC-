using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace rastreioAPIC_
{
    public partial class telaCadastro : Form
    {
        public class DadosProduto
        {
            public string trackingNumber { get; set; }
            public string shipmentReference { get; set; }
            public string destinationPostCode { get; set; }
            public DateTime shippingDate { get; set; }
        }
        public telaCadastro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DadosProduto dadosProduto = new DadosProduto
            {
                trackingNumber = codigoRastreio.Text,
                shipmentReference = nomeProduto.Text,
                destinationPostCode = destino.Text,
                shippingDate = data.Value
            };
            //string json = JsonSerializer.Serialize(dadosProduto, new JsonSerializerOptions { WriteIndented = true });
            string dadosJson = JsonConvert.SerializeObject(dadosProduto);


            Console.WriteLine(dadosJson);



            //Console.WriteLine(nomeProduto.Text);
            //Console.WriteLine(codigoRastreio.Text);
            //Console.WriteLine(destino.Text);
            //Console.WriteLine(data.Value);
        }
    }
}
