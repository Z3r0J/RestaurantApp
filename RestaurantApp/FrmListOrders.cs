using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class FrmListOrders : Form
    {
        private ServiceOrders serviceOrders;
        public FrmListOrders()
        {
            InitializeComponent();
            serviceOrders = new ServiceOrders();
            UploadListBox();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void UploadListBox()
        {
            string Design = $"*******************************************************************************************************************************************************************************************************************************************";
            List<Orders> orders = serviceOrders.GetOrders();

            LbxOrders.BeginUpdate();

            LbxOrders.Items.Clear();
            foreach (Orders item in orders)
            {
                LbxOrders.Items.Add(Design);
                LbxOrders.Items.Add(item.GetOrders());
            }

            LbxOrders.EndUpdate();

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmHome.Instancia.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
