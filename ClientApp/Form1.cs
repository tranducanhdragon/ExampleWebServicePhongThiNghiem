using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceReferencePhongThiNghiem;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThietBiDM_Click(object sender, EventArgs e)
        {
            WebServicePhongThiNghiemSoap tb = new WebServicePhongThiNghiemSoapClient();

        }
    }
}
