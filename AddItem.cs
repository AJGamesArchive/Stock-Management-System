using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class AddItem : Form
    {
        private StockSystem stockSystem;
        public AddItem(StockSystem stockSystem)
        {
            InitializeComponent();
            this.stockSystem = stockSystem;
        }
    }
}
