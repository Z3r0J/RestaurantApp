using System;
using System.Windows.Forms;
using System.Threading;
using BusinessLayer;
using System.Runtime.InteropServices;

namespace RestaurantApp
{
    public sealed partial class FrmHome : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        public static FrmHome Instancia { get; } = new FrmHome();
        private FrmHome()
        {
            InitializeComponent();
        }    
        private void PnInicial_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            FrmPeopleQuantity order = new FrmPeopleQuantity();
            order.Show();
            this.Hide();
        }
        private void btnMesa2_Click(object sender, EventArgs e)
        {
            FrmPeopleQuantity order = new FrmPeopleQuantity();
            order.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmHome_Load(object sender, EventArgs e)
        {

            dynamic[] button = { btnMesa1, btnMesa2, btnMesa3, btnMesa4, btnMesa5, btnMesa6, btnMesa7, btnMesa8 };
            for (int i = 0; i < 8; i++)
            {
                button[i].Text = $"Table {i + 1}";
            }

        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            FrmPeopleQuantity order = new FrmPeopleQuantity();
            order.Show();
            this.Hide();
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            FrmPeopleQuantity order = new FrmPeopleQuantity();
            order.Show();
            this.Hide();
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            FrmPeopleQuantity order = new FrmPeopleQuantity();
            order.Show();
            this.Hide();
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            FrmPeopleQuantity order = new FrmPeopleQuantity();
            order.Show();
            this.Hide();
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            FrmPeopleQuantity order = new FrmPeopleQuantity();
            order.Show();
            this.Hide();
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            FrmPeopleQuantity order = new FrmPeopleQuantity();
            order.Show();
            this.Hide();
        }

        private void BtnVerOrdenes_Click(object sender, EventArgs e)
        {
            FrmListOrders listOrders = new FrmListOrders();
            this.Hide();
            listOrders.Show();
        }
    }
}
