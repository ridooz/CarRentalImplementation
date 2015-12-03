using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalImplementation
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void buttonNej_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonJa_Click(object sender, EventArgs e)
        {
            Rent rentform = new Rent();
            rentform.Show();
            this.Close();
        }
    }
}
