using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaradayCarRental.Control;
using FaradayCarRental.Entities;

namespace CarRentalImplementation
{
    public partial class Form1 : Form
    {
        private Controller controller;
        private List<RentalCar> availableCars;
        private string[] cities;
        private string selected;

        public string Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        public Form1(string selected)
        {
            this.selected = Selected;
        }
        

        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
            cities = new string[] { "Lyngby", "Kastrup" };

            comboBox1.DataSource = cities;            
            comboBox1.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            availableCars = controller.ShowAvailableCars(comboBox1.SelectedValue as string);

            listBox1.DisplayMember = "ToString";
            listBox1.ValueMember = "LicensePlate";

            listBox1.Items.Clear();
            foreach (RentalCar car in availableCars)
            {
                listBox1.Items.Add(car);
            }
        }

        private void buttonChooseCar_Click(object sender, EventArgs e)
        {
            selected = listBox1.SelectedItem.ToString();
            if(listBox1.SelectedItem != null && textBoxDatoStart != null && textBoxDatoSlut != null)
            {

                RentalCar car = listBox1.SelectedItem as RentalCar;

                DateTime dateStart = Convert.ToDateTime(textBoxDatoStart.Text);
                DateTime dateSlut = Convert.ToDateTime(textBoxDatoSlut.Text);
                
                Confirmation conform = new Confirmation(car, dateStart, dateSlut);
                conform.Show();
            }
            else
            {
                MessageBox.Show("Du skal vælge bil + indtaste start- og slutdato");
            }
        }


    }
}
