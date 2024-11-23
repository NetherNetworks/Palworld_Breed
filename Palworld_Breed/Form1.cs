using Palworld_Breed.classes;
using Palworld_Breed.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palworld_Breed
{
    public partial class Form1 : Form
    {
        private page_paldex page1 = new page_paldex();
        private page_AZV_parents page2 = new page_AZV_parents();
        

        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {           
            page1.Dock = DockStyle.Fill;
            page1.Name = "page1";
            panel_main.Controls.Add(page1);

            page2.Dock = DockStyle.Fill;
            page2.Name = "page2";
            panel_main.Controls.Add(page2);
            
        }

        private void btn_paldex_Click(object sender, EventArgs e)
        {
            ShowPage(enums.Pages.page1);
        }

        private void btn_breed_Click(object sender, EventArgs e)
        {
            ShowPage(enums.Pages.page2);
            
           

        }

        


        #endregion

        #region Shared Functions

        private void ShowPage(enums.Pages selectedPage)
        {
            int i;

            for (i = 0; i < panel_main.Controls.Count; i++)
            {
                if (i == (int)selectedPage)
                {
                    panel_main.Controls[i].Visible = true;
                }
                else
                {
                    panel_main.Controls[i].Visible = false;
                }
            }
        }

        #endregion

        
    }
}
