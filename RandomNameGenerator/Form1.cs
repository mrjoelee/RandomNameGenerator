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
        List<string> l1;
  
        public RandomNameGenerator()
        {
            InitializeComponent();
            l1 = new List<string>();
            l1.Add("Scott");
            l1.Add("Jay");
            l1.Add("Torrie");
            l1.Add("Dennis");
            l1.Add("Joshua");
            l1.Add("Joe");
            l1.Add("Michael");
            l1.Add("Daniel");
            l1.Add("Billy");
            l1.Add("Coung");
            l1.Add("Erick");
            l1.Add("Lumiere");
            l1.Add("Austin");
            listbox1.DataSource = l1;
            
        }
        private int EatMyRandom()
        {
            Random random = new Random();
            return random.Next(0,13);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
