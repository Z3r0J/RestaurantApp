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
            CbxCantidadDePersonas.SelectedIndex = 0;
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

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            IteratorQuantityPeople();
        }


        private void IteratorQuantityPeople()
        {
            ComboBoxItem QuantityPeople = CbxCantidadDePersonas.SelectedItem as ComboBoxItem;
            if (QuantityPeople.Value == null)
            {

            }
            else
            {
                FrmTakeOrder[] takeOrders = new FrmTakeOrder[4];
                RepositoryOrders.Instancia.PeopleQuantity = (int)QuantityPeople.Value;

                for (int i = 0; i < RepositoryOrders.Instancia.PeopleQuantity; i++)
                {
                    takeOrders[i] = new FrmTakeOrder(i + 1);
                    takeOrders[i].ShowDialog();
                }

                FrmQuestion question = new FrmQuestion("Do you want to Add all orders from this table?");

                DialogResult result = question.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ServiceOrders[] serviceOrders = new ServiceOrders[4];
                    Orders[] orders = new Orders[4];

                    for (int i = 0; i < RepositoryOrders.Instancia.PeopleQuantity; i++)
                    {
                        orders[i] = new Orders()
                        {
                            ClientName = takeOrders[i].txtName.Text,
                            MainDish = takeOrders[i].CbxMainDishes.Text,
                            EntryDish = takeOrders[i].CbxEntryDishes.Text,
                            DessertDish = takeOrders[i].CbxDessertDishes.Text,
                            Beverage = takeOrders[i].CbxBeverage.Text
                        };
                        serviceOrders[i] = new ServiceOrders();
                        serviceOrders[i].Add(orders[i]);
                    }


                }
                else
                {
                    this.Close();
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPeopleQuantity_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmHome.Instancia.Show();
        }
    }
}
