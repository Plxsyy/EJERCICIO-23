using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            String itemAñadir = textBox1.Text;
            
            if (radioButtonListBox.Checked == true)
            {

                if (textBox1.Text == "" || listBox.Items.Contains(itemAñadir))
                {
                    MessageBox.Show("No se ha introducido el valor adecuado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int countListBox = int.Parse(textBoxListBox.Text);
                    listBox.Items.Add(itemAñadir);
                    countListBox++;
                    textBoxListBox.Text = countListBox.ToString();
                    textBox1.Text = string.Empty;
                }
            }
            else if (radioButtonComboBox.Checked == true)
            {

                if (textBox1.Text == "" || listBox.Items.Contains(itemAñadir))
                {
                    MessageBox.Show("No se ha introducido ningun valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int countComboBox = int.Parse(textBoxComboBox.Text);
                    comboBox1.Items.Add(itemAñadir);
                    countComboBox++;
                    textBoxComboBox.Text = countComboBox.ToString();
                    textBox1.Text = string.Empty;

                }
            }
            if (radioButtonCheckedListBox.Checked ==true) 
            {

                if (textBox1.Text == ""|| listBox.Items.Contains(itemAñadir))
                {
                    MessageBox.Show("No se ha introducido ningun valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int countCheckedListBox = int.Parse(textBoxCheckedListBox.Text);
                    checkedListBox1.Items.Add(itemAñadir);
                    countCheckedListBox++;
                    textBoxCheckedListBox.Text = countCheckedListBox.ToString();
                    textBox1.Text = string.Empty;

                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String itemEliminar = textBox1.Text;

            if (radioButtonListBox.Checked == true)
            {

                if (textBox1.Text == "" || !listBox.Items.Contains(itemEliminar))
                {
                    MessageBox.Show("No se ha introducido el valor adecuado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = string.Empty;

                }
                else
                {
                    int countListBox = int.Parse(textBoxListBox.Text);
                    listBox.Items.Remove(itemEliminar);
                    countListBox--;
                    textBoxListBox.Text = countListBox.ToString();
                    textBox1.Text = string.Empty;
                }
            }
            else if (radioButtonComboBox.Checked == true )
            {

                if (textBox1.Text == "" || !listBox.Items.Contains(itemEliminar))
                {
                    MessageBox.Show("No se ha introducido ningun valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = string.Empty;

                }
                else
                {
                    int countComboBox = int.Parse(textBoxComboBox.Text);
                    comboBox1.Items.Remove(itemEliminar);
                    countComboBox--;
                    textBoxComboBox.Text = countComboBox.ToString();
                    textBox1.Text = string.Empty;

                }
            }
            if (radioButtonCheckedListBox.Checked ==true ) 
            {

                if (textBox1.Text == "" || !listBox.Items.Contains(itemEliminar))
                {
                    MessageBox.Show("No se ha introducido ningun valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = string.Empty;

                }
                else
                {
                    int countCheckedListBox = int.Parse(textBoxCheckedListBox.Text);
                    checkedListBox1.Items.Remove(itemEliminar);
                    countCheckedListBox--;
                    textBoxCheckedListBox.Text = countCheckedListBox.ToString();
                    textBox1.Text = string.Empty;

                }
            }
        }
    }
}
