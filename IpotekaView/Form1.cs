using BL.Factories.Housing;
using BL.Factories.Sitizens;
using BL.Housing;
using BL.Housing.Factories;
using BL.Interfaces;
using BL.Services;
using BL.Sitizens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpotekaView
{
    public partial class Form1 : Form
    {
        private Dictionary<string, House> houses = new Dictionary<string, House>(3);
        private Dictionary<string, Sitizen> sitizens = new Dictionary<string, Sitizen>(3);
        private ICalculator calculator;
        public Form1()
        {
            InitializeComponent();

            this.calculator = new RateCalculator();

            this.houses.Add("Жильё от застройщика", new NotRentedFactory().Create());
            this.houses.Add("Обычное жильё", new CommonFactory().Create());
            this.houses.Add("Жильё с рисками", new RiskyFactory().Create());

            foreach (string key in this.houses.Keys)
            {
                comboBox1.Items.Add(key);
            }
            comboBox1.SelectedIndex = 0;

            this.sitizens.Add("Гражданин старшей возрастной категории", new OlderAgeFactory().Create());
            this.sitizens.Add("Обычный гражданин", new CommonSitizenFactory().Create());
            this.sitizens.Add("Сотрудник банка", new PriviligedFactory().Create());

            foreach (string key in this.sitizens.Keys)
            {
                comboBox2.Items.Add(key);
            }
            comboBox2.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedHouse = comboBox1.SelectedItem.ToString();
            string selectedCitizen = comboBox2.SelectedItem.ToString();
            double result = this.calculator.Calc(this.houses[selectedHouse], this.sitizens[selectedCitizen]);

            label5.Text = result.ToString() + "%";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
