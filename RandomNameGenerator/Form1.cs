using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNameGenerator
{
    public partial class RandomNameGenerator : Form
    {
        //List<string> l1;

  
        public RandomNameGenerator()
        {
            InitializeComponent();
            
        }
        private int EatMyRandom()
        {
                Random random = new Random();
                return random.Next(listbox1.Items.Count - 1);
        }

             
        private void button1_Click(object sender, EventArgs e)
        {
            /*listbox2.Items.Add(listbox1.SelectedItem);*///adding first name from listbox1
            /*listbox1.Items.Remove(listbox1.SelectedItem);*///removing but cannot remove from datasource(binding)
            
            if(listbox1.Items.Count > 0)
            {
            int choice = EatMyRandom();
            listbox2.Items.Add(listbox1.Items[choice]);
            listbox1.Items.Remove(listbox1.Items[choice]);
            }
            else
            {
                button1.Enabled = false;
            }


            //if(listbox1.Items == "")create a show message box that all names have been clear.
            //{

            //}
        }

        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
          

            //List<string> l1 = new List<string>();
            //l1.Add("scott");
            //listbox1.Items.Add(l1);

        }

    }
}
