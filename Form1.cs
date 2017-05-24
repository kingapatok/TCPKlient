using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
namespace TCPKlient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przycisk_polacz_Click(object sender, EventArgs e)
        {
            string host = Adress.Text;
            int port = System.Convert.ToInt32(My_port.Value);
            try
            {
                TcpClient klient = new TcpClient(host, port);
                info_o_polonczeniu.Items.Add("Nawiązano połączenie z " + host + "na porcie:" + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                info_o_polonczeniu.Items.Add("Błąd: Nie udało się nawiązać połączenia!");
                MessageBox.Show(ex.ToString(), "Błąd");
            }
        }


    }
}
