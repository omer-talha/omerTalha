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
    public partial class EntitySummaryForm : Form
    {
        public EntitySummaryForm()
        {
            InitializeComponent();
        }

        private void detailButton_Click(object sender, EventArgs e)
        {
            EntityDetailForm entityDetailForm = new EntityDetailForm(); 
            entityDetailForm.EntitySummaryForm = this;
            entityDetailForm.LoadValues(123, "Beykent", 12.34); 
            entityDetailForm.Show();
        }
        public void StoreValues(long entityId, string entityName, double entityValue)
        {
            MessageBox.Show(entityId + " " + entityName + " " + entityValue); 

        }

        private void EntitySummaryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
