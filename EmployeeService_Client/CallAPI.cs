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
            tboxResponse.Text = "";

            var response = await RestHelper.GetAll(); // 

            tboxResponse.Text = RestHelper.FormatterJson(response);
        }

        private async void btonGet_Click(object sender, EventArgs e)
        {
            tboxResponse.Text = "";

            var response = await RestHelper.GetOne(Convert.ToInt32(tboxID.Text)); 

            tboxResponse.Text = RestHelper.FormatterJson(response);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btonPost_Click(object sender, EventArgs e)
        {
            tboxResponse.Text = "";

            var response = await RestHelper.Post(tboxName.Text, tboxPosition.Text, tboxAge.Text, tboxSalary.Text);

            tboxResponse.Text = RestHelper.FormatterJson(response);
        }
    }
}
