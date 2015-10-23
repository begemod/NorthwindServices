namespace OrdersServiceWinFormClient
{
    using System;
    using System.ServiceModel;
    using System.Windows.Forms;
    using OrdersServiceWinFormClient.WCFOrdersService;

    public partial class MainForm : Form, IOrdersSubscriptionServiceCallback
    {
        private readonly OrdersSubscriptionServiceClient ordersServiceClient;

        private readonly string clientId = Guid.NewGuid().ToString();

        public MainForm()
        {
            this.InitializeComponent();
            this.ordersServiceClient = new OrdersSubscriptionServiceClient(new InstanceContext(this));
            this.AppendMessage(string.Format("Client ID: {0}", this.clientId));
        }

        public void OrderStatusIsChanged(int orderId)
        {
            this.AppendMessage(orderId.ToString());
        }

        private async void OnBtnSubscribeClick(object sender, System.EventArgs e)
        {
            try
            {
                var success = await this.ordersServiceClient.SubscribeAsync(this.clientId);

                if (success)
                {
                    this.AppendMessage("You successfully subscribed on messages from Orders Service.");
                }
            }
            catch (CommunicationObjectFaultedException exception)
            {
                this.AppendMessage("An error occured on attempt of subscribing to messages from service.");
                this.AppendMessage(exception.Message);
            }
            catch (FaultException exception)
            {
                this.AppendMessage("An error occured on attempt of subscribing to messages from service.");
                this.AppendMessage(exception.Message);
            }
        }

        private async void OnBtnUnsubscribeClick(object sender, System.EventArgs e)
        {
            try
            {
                var success = await this.ordersServiceClient.UnsubscribeAsync(this.clientId);

                if (success)
                {
                    this.AppendMessage("You successfully unsubscribed from messages from Orders Service.");
                }
            }
            catch (CommunicationObjectFaultedException exception)
            {
                this.AppendMessage("An error occured on attempt of unsubscribing from messages.");
                this.AppendMessage(exception.Message);
            }
            catch (FaultException exception)
            {
                this.AppendMessage("An error occured on attempt of unsubscribing from messages.");
                this.AppendMessage(exception.Message);
            }
        }

        private void AppendMessage(string message)
        {
            this.txtMessages.AppendText(message + "\n");
        }

        private void OnBtnChangeOrderStatusClick(object sender, System.EventArgs e)
        {
            using (var client = new OrdersServiceClient())
            {
                client.ProcessOrder(new OrderDTO());
            }
        }
    }
}
