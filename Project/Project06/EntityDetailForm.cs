using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project06
{
    public partial class EntityDetailForm : Form
    {

        public long EntityId; 
        public string EntityName; 
        public double EntityValue; 
        public EntitySummaryForm EntitySummaryForm; 

        public EntityDetailForm()
        {
            InitializeComponent();
        }

        public void LoadValues(long entityId, string entityName, double entityValue) 
        {
            EntityId = entityId; 
            EntityName = entityName;
            EntityValue = entityValue; 
            Text = EntityId + " " + EntityName + " " + EntityValue; 

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            EntitySummaryForm.StoreValues(EntityId, "Yeni " + EntityName, 100 + EntityValue); 
            Close(); 
        }
    }
}
