using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Server.MirEnvir;

namespace Server
{
    public partial class GameShop : Form
    {

        GameShopItem SelectedItem;

        public Envir Envir
        {
            get { return SMain.EditEnvir; }
        }


        public GameShop()
        {
            InitializeComponent();

            LoadGameShopItems();
        }

        private void GameShop_Load(object sender, EventArgs e)
        {

        }

        private void GameShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Envir.SaveDB();
        }

        public class ListBoxItem
        {
            public string DisplayMember { get; set; }
            public object ValueMember { get; set; }

            public override string ToString()
            {
                return DisplayMember;
            }
        }

        private void LoadGameShopItems()
        {
            GameShopListBox.Items.Clear();
            for (int i = 0; i < SMain.EditEnvir.GameShopInfoList.Count; i++)
            {
                //GameShopItems_listbox.Items.Add(Envir.GameShopInfoList[i]);
                GameShopListBox.Items.Add(SMain.EditEnvir.GameShopInfoList[i]);
            }
        }

        private void GameShopListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInterface();
        }

        public void UpdateInterface(bool refreshList = false)
        {
            GoldPrice_textbox.Text = String.Empty;
            GPPrice_textbox.Text = String.Empty;
            Quantity_textbox.Text = String.Empty;
            TotalQuantity_textbox.Text = String.Empty;
            Class_combo.Text = "NONE";
            Catagory_combo.Text = "NONE";
            Page1Priority_checkbox.Checked = false;
            
            SelectedItem = (GameShopItem)GameShopListBox.SelectedItem;

            GoldPrice_textbox.Text = SelectedItem.GoldPrice.ToString();
            GPPrice_textbox.Text = SelectedItem.GPPrice.ToString();
            Quantity_textbox.Text = SelectedItem.Quantity.ToString();
            TotalQuantity_textbox.Text = SelectedItem.TotalQuantity.ToString();
            Class_combo.Text = SelectedItem.Class;
            Catagory_combo.Text = SelectedItem.Catagory;
            Page1Priority_checkbox.Checked = SelectedItem.PagePriority;
        }

        private void GoldPrice_textbox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;

            long temp;

            if (!long.TryParse(ActiveControl.Text, out temp))
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }

            ActiveControl.BackColor = SystemColors.Window;
            SelectedItem.GoldPrice = temp;
        }

        private void GPPrice_textbox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;

            long temp;

            if (!long.TryParse(ActiveControl.Text, out temp))
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }

            ActiveControl.BackColor = SystemColors.Window;
            SelectedItem.GPPrice = temp;
        }

        private void Quantity_textbox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;

            byte temp;

            if (!byte.TryParse(ActiveControl.Text, out temp))
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }

            ActiveControl.BackColor = SystemColors.Window;
            SelectedItem.Quantity = temp;
        }

        private void Class_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            string temp = ActiveControl.Text;

            SelectedItem.Class = temp;
        }

        private void Catagory_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;
            string temp = ActiveControl.Text;

            SelectedItem.Catagory = temp;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TotalQuantity_textbox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;

            byte temp;

            if (!byte.TryParse(ActiveControl.Text, out temp))
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }

            ActiveControl.BackColor = SystemColors.Window;
            SelectedItem.TotalQuantity = temp;
        }

        private void Page1Priority_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;

            SelectedItem.PagePriority = Page1Priority_checkbox.Checked;
        }
    }
}
