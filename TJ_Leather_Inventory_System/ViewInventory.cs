using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Test_4
{
    public partial class ViewInventory : Form
    {
        public ViewInventory()
        {
            InitializeComponent();
        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_tjDataSet.tblItems' table. You can move, or remove it, as needed.
            this.tblItemsTableAdapter.Fill(this.db_tjDataSet.tblItems);

        }
    }
}
