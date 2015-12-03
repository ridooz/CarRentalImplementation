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
    public partial class Rent : Form
    {

        
        public Rent()
        {
            
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != null && textBox2.Text != null)
            {
                //this.listbox.Items.Remove(listbox.SelectedItem);         
                //MessageBox.Show("Bilen er blevet udlejet til " + textBox2.Text);
                // ff.Fjern();

                //Result form = new Result();
                //form.Show();
                
                //this.Close();

                Form1 form = new Form1();
                
                textBox3.Text = "Driver name: " + textBox2.Text + System.Environment.NewLine
                + "DriverLicense: " + textBox1.Text + System.Environment.NewLine
                + form.Selected;
                
            }
        }        
    }
}
