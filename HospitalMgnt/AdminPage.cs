using HospitalMgnt.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMgnt
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Done....");
        }
        //Functionality for Add button
        private bool isCollapsedAdd;
        private void timer_AddPanel_Tick(object sender, EventArgs e)
        {
            if (isCollapsedAdd)
            {
                buttonAdd.Image = Resources.collapse_arrow;
                panel_Add.Height += 10;
                if (panel_Add.Size==panel_Add.MaximumSize)
                {
                    timer_AddPanel.Stop();
                    isCollapsedAdd = false;
                }
            }
            else
            {
                buttonAdd.Image = Resources.expand_arrow;
                panel_Add.Height -= 10;
                if (panel_Add.Size == panel_Add.MinimumSize)
                {
                    timer_AddPanel.Stop();
                    isCollapsedAdd = true;
                }
            }
            
        }
        private void buttonAdd_MouseEnter(object sender, EventArgs e)
        {
            buttonAdd.Image = Resources.expand_arrow;
        }

        private void buttonAdd_MouseLeave(object sender, EventArgs e)
        {
             panel_Add.Size = panel_Add.MinimumSize;
             buttonAdd.Image = Resources.addImage;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //code goes here....


            timer_AddPanel.Start();//Timer for dropdown menu

        }//Functionality for Add button END here...


        //Functionality for Update button
        private bool isCollapsedUpdate;
        private void timer_UpdatePanel_Tick(object sender, EventArgs e)
        {
            if (isCollapsedUpdate)
            {
                buttonUpdate.Image = Resources.collapse_arrow;
                panel_Update.Height += 10;
                if (panel_Update.Size == panel_Update.MaximumSize)
                {
                    timer_UpdatePanel.Stop();
                    isCollapsedUpdate = false;
                }
            }
            else
            {
                buttonUpdate.Image = Resources.expand_arrow;
                panel_Update.Height -= 10;
                if (panel_Update.Size == panel_Update.MinimumSize)
                {
                    timer_UpdatePanel.Stop();
                    isCollapsedUpdate = true;
                }
            }
        }
        private void buttonUpdate_MouseEnter(object sender, EventArgs e)
        {
            buttonUpdate.Image = Resources.expand_arrow;
        }
        private void buttonUpdate_MouseLeave(object sender, EventArgs e)
        {
            panel_Update.Size = panel_Update.MinimumSize;
            buttonUpdate.Image = Resources.update;   
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Codes goes here...

            timer_UpdatePanel.Start();
        }//Functionality for Update button END here...

        //Functionality for Delete button 
        private bool isCollapsedDelete;
        private void timer_DeletePanel_Tick(object sender, EventArgs e)
        {   
            if (isCollapsedDelete)
            {
                buttonDelete.Image = Resources.collapse_arrow;
                panel_Delete.Height += 10;
                if (panel_Delete.Size == panel_Delete.MaximumSize)
                {
                    timer_DeletePanel.Stop();
                    isCollapsedDelete = false;
                }
            }
            else
            {
                buttonDelete.Image = Resources.expand_arrow;
                panel_Delete.Height -= 10;
                if (panel_Delete.Size == panel_Delete.MinimumSize)
                {
                    timer_DeletePanel.Stop();
                    isCollapsedDelete = true;
                }
            }
        }
        private void buttonDelete_MouseEnter(object sender, EventArgs e)
        {
            buttonDelete.Image = Resources.expand_arrow;
        }

        private void buttonDelete_MouseLeave(object sender, EventArgs e)
        {
            buttonDelete.Image = Resources.delete;
            panel_Delete.Size = panel_Delete.MinimumSize;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {


            timer_DeletePanel.Start();
        }//Functionality for Delete button END here...

        ////Functionality for Find button 
        private bool isCollapsedFind;

        private void timer_FindPanel_Tick(object sender, EventArgs e)
        {
            if (isCollapsedFind)
            {
                buttonFind.Image = Resources.collapse_arrow;
                panel_Find.Height += 10;
                if (panel_Find.Size == panel_Find.MaximumSize)
                {
                    timer_FindPanel.Stop();
                    isCollapsedFind = false;
                }
            }
            else
            {
                buttonFind.Image = Resources.expand_arrow;
                panel_Find.Height -= 10;
                if (panel_Find.Size == panel_Find.MinimumSize)
                {
                    timer_FindPanel.Stop();
                    isCollapsedFind = true;
                }
            }
        }

        private void buttonFind_MouseEnter(object sender, EventArgs e)
        {
            buttonFind.Image = Resources.expand_arrow;
        }

        private void buttonFind_MouseLeave(object sender, EventArgs e)
        {
            panel_Find.Size = panel_Find.MinimumSize;
            buttonFind.Image = Resources.find;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            timer_FindPanel.Start();
        }//Functionality for Find button END here...
    }
}
