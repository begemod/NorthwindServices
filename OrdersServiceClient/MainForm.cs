namespace OrdersServiceWinFormClient
{
    using System;
    using System.Linq;
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
            this.AppendMessage(string.Format("Order with Id={0} has been processed.", orderId));
        }

        private async void OnBtnSubscribeClick(object sender, System.EventArgs e)
        {
            try
            {
                this.btnSubscribe.Enabled = false;

                var success = await this.ordersServiceClient.SubscribeAsync(this.clientId);

                if (success)
                {
                    this.AppendMessage("You successfully subscribed on messages from Orders Service.");
                }
            }
            catch (CommunicationException exception)
            {
                this.AppendMessage("An error occured on attempt of subscribing to messages from service.");
                this.AppendMessage(exception.Message);
            }
            finally
            {
                this.btnSubscribe.Enabled = true;
            }
        }

        private async void OnBtnUnsubscribeClick(object sender, System.EventArgs e)
        {
            try
            {
                this.btnUnsubscribe.Enabled = false;

                var success = await this.ordersServiceClient.UnsubscribeAsync(this.clientId);

                if (success)
                {
                    this.AppendMessage("You successfully unsubscribed from messages from Orders Service.");
                }
            }
            catch (CommunicationException exception)
            {
                this.AppendMessage("An error occured on attempt of unsubscribing from messages.");
                this.AppendMessage(exception.Message);
            }
            finally
            {
                this.btnUnsubscribe.Enabled = true;
            }
        }

        private void AppendMessage(string message)
        {
            this.txtMessages.AppendText(message + "\n");
        }

        private async void OnBtnChangeOrderStatusClick(object sender, System.EventArgs e)
        {
            using (var client = new OrdersServiceClient())
            {
                try
                {
                    this.btnChangeOrderStatus.Enabled = false;

                    var allOrders = await client.GetAllAsync();

                    if (!allOrders.Any())
                    {
                        this.AppendMessage("There is no one order in DB.");
                        return;
                    }

                    var orderInNewState = allOrders.FirstOrDefault(o => o.OrderState.Equals(OrderState.New));
                    if (orderInNewState == null)
                    {
                        this.AppendMessage("There is no one New order in DB.");
                        return;
                    }

                    orderInNewState.RequiredDate = DateTime.Now.AddDays(1);

                    await client.UpdateOrderAsync(orderInNewState);

                    await client.ProcessOrderAsync(orderInNewState.OrderId);
                }
                catch (CommunicationException exception)
                {
                    this.AppendMessage("An error occured on attempt of changing order status.");
                    this.AppendMessage(exception.Message);
                }
                finally
                {
                    this.btnChangeOrderStatus.Enabled = true;
                }
            }
        }
    }
}
