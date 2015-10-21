namespace OrdersServiceClient
{
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void OnBtnSubscribeClick(object sender, System.EventArgs e)
        {
        }

        private void OnBtnUnsubscribeClick(object sender, System.EventArgs e)
        {
        }

        private void AppendMessage(string message)
        {
            this.txtMessages.AppendText(message);
        }
    }
}
