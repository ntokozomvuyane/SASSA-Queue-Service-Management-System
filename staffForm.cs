
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sassa_Queue_And_Service_Management_System
{
    public partial class staffForm : Form
    {
        List<QueueItem> queue = new List<QueueItem>();
        QueueItem currentPerson = null;

        public staffForm()
        {
            InitializeComponent();

            queue.Add(new QueueItem
            {
                QueueNumber = "Q0001",
                Reference = "REF001",
                Service = "Grant Application",
                Status = "Waiting"
            });

            queue.Add(new QueueItem
            {
                QueueNumber = "Q0002",
                Reference = "REF002",
                Service = "ID Application",
                Status = "Waiting"
            });

            RefreshQueue();
        }

        private void LoadQueue()
        {
            string filepath = "queue.txt";

            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] data = line.Split('|');

                        if (data.Length == 4)
                        {
                            QueueItem item = new QueueItem();

                            item.QueueNumber = data[0];
                            item.Reference = data[1];
                            item.Service = data[2];
                            item.Status = data[3];

                            queue.Add(item);
                        }
                    }
                }
            }

            RefreshQueue();
        }

        private void SaveQueue()
        {
            List<string> lines = new List<string>();

            foreach (QueueItem item in queue)
            {
                lines.Add(
                    item.QueueNumber + "|" +
                    item.Reference + "|" +
                    item.Service + "|" +
                    item.Status
                );
            }

            File.WriteAllLines("queue.txt", lines);
        }

        private void RefreshQueue()
        {
            dgvQueue.DataSource = null;
            dgvQueue.DataSource = queue;
        }

        private void staffForm_Load(object sender, EventArgs e)
        {
            RefreshQueue();
            SaveQueue();
        }

        private void btnCallNext_Click(object sender, EventArgs e)
        {
            if (currentPerson != null)
            {
                MessageBox.Show("A person is already being served.");
                return;
            }

            foreach (QueueItem item in queue)
            {
                if (item.Status == "Waiting")
                {
                    currentPerson = item;

                    currentPerson.Status = "Serving";

                    lblCurrently.Text =
                        "Currently Serving: " +
                        currentPerson.QueueNumber;

                    RefreshQueue();
                    SaveQueue();

                    return;
                }
            }

            MessageBox.Show("No people waiting.");
        }

        private void pnlQueue_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (currentPerson == null)
            {
                MessageBox.Show(
                    "No person is currently being served."
                );

                return;
            }

            currentPerson.Status = "Completed";

            currentPerson = null;

            lblCurrently.Text =
                "Currently Serving: None";

            RefreshQueue();
            SaveQueue();
        }

        private void btnNo_Show_Click(object sender, EventArgs e)
        {
            if (currentPerson == null)
            {
                MessageBox.Show(
                    "No person is currently being served."
                );

                return;
            }

            currentPerson.Status = "No Show";

            MessageBox.Show(
                currentPerson.QueueNumber +
                " is a No Show."
            );

            currentPerson = null;

            lblCurrently.Text =
                "Currently Serving: None";

            RefreshQueue();
            SaveQueue();
        }
    }
}

