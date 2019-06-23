using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobDependency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // I initialized the jobs class here so we access the methods of that class.
            Jobs jobs = new Jobs();
            int x = 0;
            int y = 0;
            int i = 0;

            //Makes a enumerable list from all the comboboxes from this Class
            IEnumerable<ComboBox> comboboxes = this.Controls.OfType<ComboBox>();
           
           

            /*  if (comboboxes.GroupBy(n => n.Text).Any(c => c.Count() > 1)) {

              }*/

            //Instead of adding one by one I used foreach loop and my method to fill all comboboxes.
            foreach (var item in comboboxes)
            {
                jobs.ComboBoxSource(item, jobs.GetJobs());
                //I made the combobox selected index -1 so comboboxes will be blank at start.
                item.SelectedIndex = -1;
                
            }
            
         
        }

        public void CheckErrorsbtn_Click(object sender, EventArgs e)
        {
            ComboBoxMethods methods = new ComboBoxMethods();
            
            for (int i = 1; i < methods.DependencyComboBoxes.LongCount(); i++)
            {
                if (methods.JobComboBoxes[i] == methods.DependencyComboBoxes[i]) {

                    MessageBox.Show("Jobs cannot depend on themselfs");
                    foreach (var item in methods.Comboboxes)
                    {
                        item.SelectedIndex = -1;
                        

                    }
                    
                    return;

                }
            }
                    
        }
    }
}
