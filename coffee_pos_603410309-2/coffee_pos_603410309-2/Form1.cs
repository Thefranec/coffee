using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_603410309_2
{
    public partial class Form1 : Form
    {
        string ff = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }

        public void frong(string menu, string bath)
        {
            string[] f = { menu, bath };
            var h = new ListViewItem(f);
            listView1.Items.Add(h);
            frongjj();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frong("Esspresso(Hot)", "35");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frong("Esspresso(Ice)", "45");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frong("Esspresso(Frappe)", "50");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frong("Americano(Hot)", "35");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frong("Americano(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frong("Latte(Hot)", "35");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frong("Latte(Ice)", "45");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frong("Latte(Frappe)", "50");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frong("Mocha(Hot)", "35");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frong("Mocha(Ice)", "40");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frong("Mocha(Frappe)", "50");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frong("Cappuccino(Hot)", "35");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frong("Cappuccino(Ice)", "45");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            frong("Cappuccino(Frappe)", "50");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            frong("CreenTea(Hot)", "20");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            frong("GreenTea(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            frong("GreenTea(Frappe)", "30");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            frong("ThaiTea(Hot)", "20");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            frong("ThaiTea(Ice)", "25");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            frong("ThaiTea(Frappe)", "30");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            frong("CoCoa(Hot)", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            frong("CoCoa(Ice)", "25");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            frong("CoCoa(Frappe)", "30");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            frong("Milk(Hot)", "20");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            frong("Milk(Ice)", "25");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            frong("Milk(Frappe)", "30");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            frong("MilkTea(Ice)", "25");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            frong("MilkTea(Frappe)", "30");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            frong("LemonTea(Ice)", "20");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            frong("LemonTea(Frappe)", "30");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            frong("Esspresso(Hot)", "20");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            frong("Esspresso(Ice)", "25");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            frong("Esspresso(Frappe)", "30");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            frong("Americano(Hot)", "20");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            frong("Americano(Ice)", "25");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            frong("Americano(Frappe)", "30");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            frong("Latte(Hot)", "20");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            frong("Latte(Ice)", "25");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            frong("Latte(Frappe)", "30");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            frong("ITalian Soda", "25");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            frong("Red lime Soda", "25");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            frong("Honeg lime Soda", "25");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณต้องการออกจากระบบใช่ไหม");
            this.Close();

        }

        double Z;
        public string[] frongjj()
        {
            Z = 0;
            string[] H = new string[listView1.Items.Count];
            int li = listView1.Items.Count;
            for (int i = 0; i < li; i++)
            {
                Z += double.Parse(listView1.Items[i].SubItems[1].Text);
                H[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label30.Text = Z.ToString();
            return H;
        }
        public string[] infrongjj()
        {
            string[] H = new string[listView1.Items.Count];
            int li = listView1.Items.Count;
            for (int i = 0; i < li; i++)
            {
                H[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return H;
        }
        public void zero()
        {
            string[] kc = frongjj();
            string[] jj = infrongjj();
            string file1 = "Fraec1998@coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string filebill1 = "Fraec1998@coffee";
            filebill1 += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd//mm/yyyy") + "\r\n" + "\r\n";
            filebill1 += "menu" + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                filebill1 += kc[i] + new string(' ', 20) + jj[i] + "  Bath" + "\r\n";
            }
            filebill1 += "\r\n";
            filebill1 += "Total Price : " + label30.Text;
            System.IO.File.WriteAllText(ff + @"\" + file1 + ".txt", filebill1);
            textBox2.Text += filebill1 + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + ff + @"\" + file1 + "txt";

        }
        bool ko = false;
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (ko == false)
            {
                tabControl1.TabPages.Insert(1, Payment);
                ko = true;
                tabControl1.SelectedTab = Payment;
            }
            else tabControl1.SelectedTab = Payment;

            if (listView1.Items.Count > 0)
                zero();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ko = false;
            tabControl1.Controls.Remove(Payment); label30.Text = "";
            textBox2.Text = "";
        }
    }
}
