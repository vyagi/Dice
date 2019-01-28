using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DieLogic;

namespace Dice.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new Object []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            comboBox1.SelectedIndex = 0;
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            var numberOfDice = (int)comboBox1.SelectedItem;
            Die die = new Die();
            rolledDiceTextBox.Clear();
            for (int eachDie = 0; eachDie < numberOfDice; eachDie++)
            {
                die.Roll();
                var result = die.Show();
                rolledDiceTextBox.Text = rolledDiceTextBox.Text + " " + result.ToString();
            }

        }
    }
}
