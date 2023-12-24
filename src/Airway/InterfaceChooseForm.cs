using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Airway
{
    /// <summary>
    /// The form from which you begin working with the program.
    /// </summary>
    public partial class InterfaceChooseForm : Form
    {
        public InterfaceChooseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A list of network interfaces.
        /// </summary>
        private List<NetworkInterface> interfaces;

        /// <summary>
        /// Method to get all network interfaces and save them in the list.
        /// </summary>
        private void UpdateNetworkInterfaces()
        {
            if (interfaces != null)
                interfaces.Clear();

            interfaces = NetworkInterface.GetAllNetworkInterfaces().ToList<NetworkInterface>();
        }

        /// <summary>
        /// Handle form loading: make a table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InterfaceChooseForm_Load(object sender, EventArgs e)
        {
            UpdateNetworkInterfaces();

            foreach (NetworkInterface adapter in interfaces)
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

        /// <summary>
        /// Handle a double click on interface in the listview: make task and open second form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NetworkInterfaceListView_DoubleClick(object sender, EventArgs e)
        {
            Task.Task task = new Task.Task();
            task.networkInterface = interfaces[NetworkInterfaceListView.SelectedItems[0].Index];

            VisualizerForm visualizer_form = new VisualizerForm(task);
            visualizer_form.Show();
            this.Hide();
        }
    }
}
