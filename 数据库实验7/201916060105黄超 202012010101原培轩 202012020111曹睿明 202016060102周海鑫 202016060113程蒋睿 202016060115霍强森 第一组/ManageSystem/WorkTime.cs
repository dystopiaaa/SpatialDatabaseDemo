using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationManageSystem
{
    public partial class WorkTime : Form
    {
        private StatForm form;
        public WorkTime(StatForm frm)
        {
            InitializeComponent();
            this.form = frm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.WtFrom = y1.Text + "-" + m1.Text + "-" + d1.Text;
            form.WtTo = y2.Text + "-" + m2.Text + "-" + d2.Text;
            this.Close();
        }
    }
}
