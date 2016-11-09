using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Management {
    public partial class Form2: Form {
        public Form2() {
            InitializeComponent();
        }

        private void vATTUBindingNavigatorSaveItem_Click(object sender,EventArgs e) {
            this.Validate();
            this.vATTUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Form2_Load(object sender,EventArgs e) {
            // TODO: This line of code loads data into the 'dS.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter.Fill(this.dS.VATTU);
            Debug.WriteLine(dS.VATTU.Rows.Count);
        }
    }
}
