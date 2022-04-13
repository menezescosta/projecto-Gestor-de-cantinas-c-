using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectoPazito1
{
    public partial class stock : Form
    {
        MySqlConnection connection = new MySqlConnection("user=root;server=localhost;password='';database=projectocantina");
        public stock()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stock_Load(object sender, EventArgs e)
        {

        }
    }
}
