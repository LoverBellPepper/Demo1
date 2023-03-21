using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FiveForm
{
    public partial class FiveForm : Form
    {
        public FiveForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FiveForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new
            System.Drawing.Drawing2D.GraphicsPath();
            Point[] mp = new Point[4];
            mp[0] = new Point(0, 0);
            mp[1] = new Point(300, 0);
            mp[2] = new Point(0, 300);
            mp[3] = new Point(300, 300);

            gp.AddPolygon(mp);
            Region rg = new Region(gp);
            this.Region = rg;

            //mp[0] = new Point(0, 150);
            //mp[1] = new Point(50, 300);
            //mp[2] = new Point(420, 300);
            //mp[3] = new Point(650, 150);
            //mp[4] = new Point(400, 0);

        }
    }
}
