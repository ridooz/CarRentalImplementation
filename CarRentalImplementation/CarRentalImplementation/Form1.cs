﻿using System;
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

            listBox1.Items.Clear();
            foreach (RentalCar car in availableCars)
            {
                listBox1.Items.Add("LicencePlate: " + car.LicensePlate + ", type: " + car.Type.TypeName + ", current location: " + car.CurrentLocation.City + "\n");
            }
        }

        private void buttonChooseCar_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                Confirmation conform = new Confirmation();
                conform.Show();
            }
        }


    }
}