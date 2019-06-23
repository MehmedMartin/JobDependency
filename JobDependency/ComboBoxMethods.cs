using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobDependency
{
    class ComboBoxMethods
    {
        Form1 form1 = new Form1();
        IEnumerable<ComboBox> comboboxes;
        ComboBox[] dependencyComboBoxes;
        ComboBox[] jobComboBoxes;

        public ComboBoxMethods()
        {
            comboboxes = form1.Controls.OfType<ComboBox>();
            dependencyComboBoxes = new ComboBox[comboboxes.LongCount()];
            jobComboBoxes = new ComboBox[comboboxes.LongCount()];
        }

        public IEnumerable<ComboBox> Comboboxes
        {
            get
            {
                return  form1.Controls.OfType<ComboBox>();
            }

            set
            {
                comboboxes = value;
            }
        }

        public ComboBox[] JobComboBoxes
        {
            get
            {
                int x = 0;
                foreach (var item in comboboxes)
                {

                    if (item.Name.Contains("job"))
                    {
                        jobComboBoxes[x] = item;
                        x++;
                    }
                };
                return jobComboBoxes;
            }

            set
            {
                jobComboBoxes = value;
            }
        }

        public ComboBox[] DependencyComboBoxes
        {
            get
            {
                int y = 0;
                foreach (var item in comboboxes)
                {
                    if (item.Name.Contains("dependency"))
                    {
                        dependencyComboBoxes[y] = item;
                        y++;
                    }
                }
                return dependencyComboBoxes;
            }

            set
            {
                dependencyComboBoxes = value;
            }
        }

        
       
}
    }
