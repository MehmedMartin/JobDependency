using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobDependency
{
    class Jobs
    {
        
       
        public IList<String> GetJobs() {
            return new List<String>
            {
                "A",
                "B",
                "C",
                "D",
                "E",
                "F",
          };
        }

        public void ComboBoxSource (ComboBox comboBox,IList<String> getJobs)
        {    
            
            comboBox.DataSource = getJobs;      
        }
    
    }
}
