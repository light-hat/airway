using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airway.Task;
using System.Net.NetworkInformation;

namespace Airway
{
    /// <summary>
    /// A form that allows you to interact with the network interface.
    /// </summary>
    public partial class VisualizerForm : Form
    {
        public VisualizerForm(Task.Task task)
        {
            InitializeComponent();
            _task = task;
            this.Text = String.Format("Capture from {0}", _task.networkInterface.Name);
        }

        /// <summary>
        /// A task object that contains all the information needed for the form.
        /// </summary>
        private Task.Task _task;

        /// <summary>
        /// Handle closing application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisualizerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            // TODO: диалоговое окно, мол, точно ли хотите выйти
        }
    }
}
