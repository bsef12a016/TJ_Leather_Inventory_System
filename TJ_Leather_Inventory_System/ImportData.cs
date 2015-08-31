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
    public partial class ImportData : Form
    {
        public ImportData()
        {
            InitializeComponent();
        }

        private void ImportData_Load(object sender, EventArgs e)
        {
            SaveFileDialog impFileDialog1 = new SaveFileDialog();
            impFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            impFileDialog1.Title = "Save an Image File";
            impFileDialog1.ShowDialog();
        }
    }
}
