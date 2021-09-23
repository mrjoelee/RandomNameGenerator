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
            //l1 = new List<string>();
            //l1.Add("Scott");
            //l1.Add("Jay");
            //l1.Add("Torrie");
            //l1.Add("Dennis");
            //l1.Add("Joshua");
            //l1.Add("Joe");
            //l1.Add("Michael");
            //l1.Add("Daniel");
            //l1.Add("Billy");
            //l1.Add("Coung");
            //l1.Add("Erick");
            //l1.Add("Lumiere");
            //l1.Add("Austin");
            //listbox1.DataSource = l1;
            
        }
        private int EatMyRandom()
        {
            
            if(listbox1.Items.Count > 0) 
            {
                Random random = new Random();
                return random.Next(listbox1.Items.Count - 1);
            }
            else
            {
                listbox1.Items.Add("");
            }
            return (int)MessageBox.Show("No more Names");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*listbox2.Items.Add(listbox1.SelectedItem);*///adding first name from listbox1
            /*listbox1.Items.Remove(listbox1.SelectedItem);*///removing but cannot remove from datasource(binding)
            int choice = EatMyRandom();
            listbox2.Items.Add(listbox1.Items[choice]);
            listbox1.Items.Remove(listbox1.Items[choice]);
            //if(listbox1.Items == "")create a show message box that all names have been clear.
            //{

            //}
        }

        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
