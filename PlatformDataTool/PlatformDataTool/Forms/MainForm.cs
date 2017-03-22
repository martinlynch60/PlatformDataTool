using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlatformDataTool.Objects;

namespace PlatformDataTool.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitialiseSubscriptionsTab();
        }

        private void InitialiseSubscriptionsTab()
        {
            this.Application.DataSource = GetApplications();

        }

        private IList<Objects.Application> GetApplications()
        {
            var applications = new List<Objects.Application>()
            {
                new Objects.Application(){Id = Guid.Empty, Name = "(All)"},  
                new Objects.Application(){Id = Guid.Parse("7101990C-7B34-49AF-9EE1-03286DCF845C"), Name = "Approve"},  
                new Objects.Application(){Id = Guid.Parse("6EAED54E-7EAD-4969-8DCD-30465482F2BF"), Name = "Expense"},  
            };

            return applications;
        }
    }
}
