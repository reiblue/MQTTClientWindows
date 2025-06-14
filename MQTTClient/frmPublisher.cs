using System.Threading.Tasks;
using System;

namespace MQTTClient
{
    public partial class frmPublisher : Form
    {
        public frmPublisher()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            

            try
            {
                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;

                var publisher = new MqttPublisher(txtIPBroker.Text); // Ou IP do broker

                publisher.ConnectAsync();

                publisher.PublishAsync(txtTopic.Text, rtxtMessage.Text);

                publisher.DisconnectAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
