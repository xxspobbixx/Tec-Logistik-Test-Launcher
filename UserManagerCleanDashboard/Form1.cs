using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;
using UserManagerCleanDashboard.UserControls;
using System.IO;
using System.Timers;


namespace UserManagerCleanDashboard
{
    public partial class MainPage : Form
    {


        public MainPage()
        {
            InitializeComponent();
            new SiticoneShadowForm(this);
            new SiticoneDragControl(TopHeader);
            new SiticoneDragControl(LogoHub);
            new SiticoneDragControl(DragPanel);
           



            lblusername.Refresh();
            /*label2.Text = DateTime.Now.ToString("dd MM yyyy");
            label3.Text = DateTime.Now.ToString("HH:mm");*/
            // add controls
            PanelSlider.Controls.Add(new Dashboard());
            PanelSlider.Controls.Add(new Chat());
            PanelSlider.Controls.Add(new Notifications());
            PanelSlider.Controls.Add(new Sales());
            PanelSlider.Controls.Add(new Settings());
            PanelSlider.Controls.Add(new Reports());
            PanelSlider.Controls.Add(new Roles());
            PanelSlider.Controls.Add(new Accounts());
            PanelSlider.Controls.Add(new Invoices());
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Dashboard", true);
        }

        private void ChatBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Chat", true);
        }

        private void NotificationBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Notifications", true);
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Sales", true);
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Settings", true);
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Reports", false);
        }
        private void RolesBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Roles", false);
        }

        private void AccountsBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Accounts", false);
        }

        private void InvoicesBtn_Click(object sender, EventArgs e)
        {
            UISwitch("Invoices", false);
        }

        // panel switch
        private void UISwitch(string ui, bool isSideNav)
        {
            switch (ui)
            {
                case "Dashboard":
                    PanelSlider.Controls.Find("Dashboard", false)[0].BringToFront();
                    break;
                case "Notifications":
                    PanelSlider.Controls.Find("Notifications", false)[0].BringToFront();
                    break;
                case "Sales":
                    PanelSlider.Controls.Find("Sales", false)[0].BringToFront();
                    break;
                case "Settings":
                    PanelSlider.Controls.Find("Settings", false)[0].BringToFront();
                    break;
                case "Reports":
                    PanelSlider.Controls.Find("Reports", false)[0].BringToFront();
                    break;
                case "Roles":
                    PanelSlider.Controls.Find("Roles", false)[0].BringToFront();
                    break;
                case "Accounts":
                    PanelSlider.Controls.Find("Accounts", false)[0].BringToFront();
                    break;
                case "Invoices":
                    PanelSlider.Controls.Find("Invoices", false)[0].BringToFront();
                    break;
                case "Chat":
                    PanelSlider.Controls.Find("Chat", false)[0].BringToFront();
                    break;
            }

            switch (isSideNav)
            {
                case true:
                    foreach (SiticoneButton button in DragPanel.Controls.OfType<SiticoneButton>())
                    {
                        button.Checked = false;
                    }
                    break;
                default:
                    foreach (SiticoneButton button in SideNavButtonContainer.Controls.OfType<SiticoneButton>())
                    {
                        button.Checked = false;
                    }
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TopHeader_Paint(object sender, PaintEventArgs e)
        {
            lblusername.Text = Environment.UserDomainName;
        }

        private void Username_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PanelSlider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DragPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }
    }
}
