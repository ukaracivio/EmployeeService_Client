using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeeService_Client
{
    public partial class CallAPI : Form
    {
        public CallAPI()
        {
            InitializeComponent();
        }

        private async void btonGetAll_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.GetAll(); // 

            tboxResponse.Text = response;
        }
    }
}
