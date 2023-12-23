using System;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text;

namespace Airway
{
    public partial class InterfaceChooseForm : Form
    {
        public InterfaceChooseForm()
        {
            InitializeComponent();
        }

        private void InterfaceChooseForm_Load(object sender, EventArgs e)
        {
            var adapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceStatistics stats = adapter.GetIPStatistics();

                NetworkInterfaceListView.Items.Add(new ListViewItem(new String[] {
                    adapter.Name,
                    adapter.Description,
                    adapter.NetworkInterfaceType.ToString(),
                    adapter.GetPhysicalAddress().ToString(),
                    adapter.OperationalStatus.ToString(),
                    adapter.Speed.ToString(),
                    stats.BytesReceived.ToString(),
                    stats.BytesSent.ToString()
                }));
            }
        }
    }
}
