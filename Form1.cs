using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void addItemsToList(string item)
        {
            string i = item.Trim();
            if(i != "")
            {
                Lista.Items.Add(i);
            }


            
        }
        private void enterPressed(object sender,System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               addItemsToList(valor.Text);
                valor.Text = " ";
            } else if(e.KeyCode == Keys.Delete)
            {
                if (Lista.SelectedItem != null)
                {
                    Lista.Items.Remove(Lista.SelectedItem);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addItemsToList(valor.Text);
            valor.Text = "";
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedItem != null)
            {
                Lista.Items.Remove(Lista.SelectedItem);
            }
        }
    }
}