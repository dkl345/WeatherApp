using Microsoft.Extensions.Configuration;

namespace WetterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var configuration = new ConfigurationBuilder().AddUserSecrets<ApiCalls>().Build();
            var apiCalls = new ApiCalls(configuration);
            
        }
    }
}
