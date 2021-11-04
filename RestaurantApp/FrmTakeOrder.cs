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
    public partial class FrmTakeOrder : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public FrmTakeOrder()
        {
            InitializeComponent();
        }


        private void FrmTakeOrder_Load(object sender, EventArgs e)
        {
            LoadComboBoxEntry();
            LoadComboBoxMain();
            LoadComboBoxDessert();
            LoadComboBoxBeverage();
        }

        private void PnInit_MouseDown(object sender, MouseEventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadComboBoxEntry()
        {
            ComboBoxItem DefaultOption = new ComboBoxItem {
                Text = "Select a option",
                Value = null
            };

            ComboBoxItem EntryOne = new ComboBoxItem
            {
                Text = "Chicken Mini-Empanadas",
                Value = "Chicken Mini-Empanadas"
            };


            ComboBoxItem EntryTwo = new ComboBoxItem
            {
                Text = "Cheese croquettes",
                Value = "Cheese croquettes"
            };

            ComboBoxItem EntryThree = new ComboBoxItem
            {
                Text = "Bread with Garlic Butter",
                Value = "Bread with Garlic Butter"
            };

            ComboBoxItem EntryFour = new ComboBoxItem
            {
                Text = "Chicken Quipes",
                Value = "Chicken Quipes"
            };

            ComboBoxItem EntryFive = new ComboBoxItem
            {
                Text = "Cheese Balls",
                Value = "Cheese Balls"
            };

            CbxEntryDishes.Items.Add(DefaultOption);
            CbxEntryDishes.Items.Add(EntryOne);
            CbxEntryDishes.Items.Add(EntryTwo);
            CbxEntryDishes.Items.Add(EntryThree);
            CbxEntryDishes.Items.Add(EntryFour);
            CbxEntryDishes.Items.Add(EntryFive);
            CbxEntryDishes.SelectedIndex = 0;
        }

        private void LoadComboBoxMain()
        {
            ComboBoxItem DefaultOption = new ComboBoxItem
            {
                Text = "Select a option",
                Value = null
            };

            ComboBoxItem MainOne = new ComboBoxItem
            {
                Text = "Cedar-Plank Salmon",
                Value = "Cedar-Plank Salmon"
            };


            ComboBoxItem MainTwo = new ComboBoxItem
            {
                Text = "Braised Chicken Legs With Grapes and Fennel",
                Value = "Braised Chicken Legs"
            };

            ComboBoxItem MainThree = new ComboBoxItem
            {
                Text = "Seared Scallops With Brown Butter and Lemon Pan Sauce",
                Value = "Seared Scallops With Brown Butter"
            };

            ComboBoxItem MainFour = new ComboBoxItem
            {
                Text = "Double-Stack Mushroom and Chicken Cheeseburgers",
                Value = "Double Mushroom and Chicken Cheeseburgers"
            };

            ComboBoxItem MainFive = new ComboBoxItem
            {
                Text = "Porterhouse Steak with mashed Potatoes",
                Value = "PorterHouse Steak With mashe Potatoes"
            };

            ComboBoxItem MainSix = new ComboBoxItem
            {
                Text = "Habanero BBQ Shrimp",
                Value = "Habanero BBQ Shrimp"
            };

            ComboBoxItem MainSeven = new ComboBoxItem
            {
                Text = "NY Steak with Garlic Butter and Asparagus",
                Value = "NY Steak with Garlic Butter and Asparagus"
            };

            ComboBoxItem MainEight = new ComboBoxItem
            {
                Text = "A5 Japanese Wagyu Steak, Roasted with Whiskeys Chips",
                Value = "A5 Japanese Wagyu Steak"
            };
            ComboBoxItem MainNine = new ComboBoxItem
            {
                Text = "Slow-Roasted Salmon with Fennel, Citrus, and Chiles",
                Value = "Slow-Roasted Salmon with Fennel, Citrus, and Chiles"
            };
            ComboBoxItem MainTen = new ComboBoxItem
            {
                Text = "Soy-Basted Pork Chops with Herbs and Jalapeños",
                Value = "Soy-Basted Pork Chops with Herbs and Jalapeños"
            };

            CbxMainDishes.Items.Add(DefaultOption);
            CbxMainDishes.Items.Add(MainOne);
            CbxMainDishes.Items.Add(MainTwo);
            CbxMainDishes.Items.Add(MainThree);
            CbxMainDishes.Items.Add(MainFour);
            CbxMainDishes.Items.Add(MainFive);

            CbxMainDishes.Items.Add(MainSix);
            CbxMainDishes.Items.Add(MainSeven);
            CbxMainDishes.Items.Add(MainEight);
            CbxMainDishes.Items.Add(MainNine);
            CbxMainDishes.Items.Add(MainTen);
            CbxMainDishes.SelectedIndex = 0;
        }

        private void LoadComboBoxDessert()
        {
            ComboBoxItem DefaultOption = new ComboBoxItem
            {
                Text = "Select a option",
                Value = null
            };

            ComboBoxItem DessertOne = new ComboBoxItem
            {
                Text = "Tiramisu Layer Cake",
                Value = "Tiramisu Layer Cake"
            };


            ComboBoxItem DessertTwo = new ComboBoxItem
            {
                Text = "Pineapple Flip Cake",
                Value = "Pineapple Flip Cake"
            };

            ComboBoxItem DessertThree = new ComboBoxItem
            {
                Text = "Lemon Souffles",
                Value = "Lemon Souffles"
            };

            ComboBoxItem DessertFour = new ComboBoxItem
            {
                Text = "Chocolate Fondue",
                Value = "Chocolate Fondue"
            };

            ComboBoxItem DessertFive = new ComboBoxItem
            {
                Text = "Brownie Sundae",
                Value = "Brownie Sundae"
            };

            CbxDessertDishes.Items.Add(DefaultOption);
            CbxDessertDishes.Items.Add(DessertOne);
            CbxDessertDishes.Items.Add(DessertTwo);
            CbxDessertDishes.Items.Add(DessertThree);
            CbxDessertDishes.Items.Add(DessertFour);
            CbxDessertDishes.Items.Add(DessertFive);
            CbxDessertDishes.SelectedIndex = 0;
        }

        private void LoadComboBoxBeverage()
        {
            ComboBoxItem DefaultOption = new ComboBoxItem
            {
                Text = "Select a option",
                Value = null
            };

            ComboBoxItem BeverageOne = new ComboBoxItem
            {
                Text = "Water",
                Value = "Water"
            };


            ComboBoxItem BeverageTwo = new ComboBoxItem
            {
                Text = "Soda",
                Value = "Soda"
            };

            ComboBoxItem BeverageThree = new ComboBoxItem
            {
                Text = "Wine",
                Value = "Wine"
            };

            ComboBoxItem BeverageFour = new ComboBoxItem
            {
                Text = "Juice",
                Value = "Juice"
            };

            ComboBoxItem BeverageFive = new ComboBoxItem
            {
                Text = "Cider",
                Value = "Cider"
            };

            CbxBeverage.Items.Add(DefaultOption);
            CbxBeverage.Items.Add(BeverageOne);
            CbxBeverage.Items.Add(BeverageTwo);
            CbxBeverage.Items.Add(BeverageThree);
            CbxBeverage.Items.Add(BeverageFour);
            CbxBeverage.Items.Add(BeverageFive);
            CbxBeverage.SelectedIndex = 0;
        }
    }
}
