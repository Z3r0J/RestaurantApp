using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace RestaurantApp
{
    public partial class FrmPeopleQuantity : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public FrmPeopleQuantity()
        {
            InitializeComponent();
        }

        private void LoadComboBox() {
            ComboBoxItem DefaultOption = new ComboBoxItem()
            {
                Text = "Select a option",
                Value = null

            };
            ComboBoxItem OnePerson = new ComboBoxItem() {

                Text = "1 Person",
                Value = 1
            };
            ComboBoxItem TwoPeople = new ComboBoxItem()
            {
                Text = "2 People",
                Value = 2
            };

            ComboBoxItem ThreePeople = new ComboBoxItem()
            {
                Text = "3 People",
                Value = 3
            };
            ComboBoxItem FourPeople = new ComboBoxItem()
            {
                Text = "4 People",
                Value = 4
            };

            CbxCantidadDePersonas.Items.Add(DefaultOption);
            CbxCantidadDePersonas.Items.Add(OnePerson);
            CbxCantidadDePersonas.Items.Add(TwoPeople);
            CbxCantidadDePersonas.Items.Add(ThreePeople);
            CbxCantidadDePersonas.Items.Add(FourPeople);
        }

        private void FrmCantidadPersona_Load(object sender, EventArgs e)
        {
            LoadComboBox();
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

        private void PnInit_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
