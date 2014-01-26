using System;
using System.Windows.Forms;

namespace NrpDrawer
{
    public partial class Form1 : Form
    {
        private readonly DbController controller = new DbController();
        private bool db_loaded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void openDatabaseFileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (dbOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    controller.Disconnect();
                    controller.Connect(dbOpenFileDialog.FileName);
                    db_loaded = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    db_loaded = false;
                }
            }
        }

        private void showSpecificButton_Click(object sender, EventArgs e)
        {
            controller.GetFromCurrentDate(showSpecyficDateTimePicker.Value);
        }
    }
}
