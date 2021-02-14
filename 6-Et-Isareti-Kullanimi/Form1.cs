using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Et_Isareti_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // string HataliKullanim = "Hüseyin \ DEMİRDÖĞER";

            string Cozum1 = "Hüseyin \\ DEMİRDÖĞER";

            string Cozum2 = @"Hüseyin \ DEMİRDÖĞER";

        }
    }
}
