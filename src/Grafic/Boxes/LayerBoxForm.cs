using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Grafic;
using Grafic.MyGrafics;
using System.Diagnostics;

namespace Grafic.Boxes
{
    public partial class LayerBoxForm : Form
    {
        public MainForm frmMainForm;                        //for refreshing the MainForm

        //Add Item
        public void AddBackgroundItem()
        {
            ListViewItem objListItem;
            objListItem = lstLayerList.Items.Add("背景");
            objListItem.Checked = true;
            objListItem.Selected = true;
            
        }

        public void AddItem(int num,int type)
        {
            foreach (ListViewItem l in lstLayerList.Items)       //Unselect the selected ones
            {
                if (l.Selected == true)
                    l.Selected = false;                                  
            }
            ListViewItem objListItem;
            objListItem = lstLayerList.Items.Insert(0,"形状 " + num.ToString());    //Add at first line
            objListItem.Checked = true;
            objListItem.Selected = true;            //always selected the new one
            switch (type)
            {
                case 1:
                    objListItem.SubItems.Add("直线");
                    break;
                case 2:
                    objListItem.SubItems.Add("矩形");
                    break;
                case 3:
                    objListItem.SubItems.Add("椭圆形");
                    break;
                case 4:
                    objListItem.SubItems.Add("圆角矩形");
                    break;
                case 5:
                    objListItem.SubItems.Add("文本");
                    break;
                case 6:
                    objListItem.SubItems.Add("曲线");
                    break;
                case 7:
                    objListItem.SubItems.Add("形状");
                    break;
                default:
                    break;
            }
        }

        //Clear Items
        public void ClearItem()
        {
            lstLayerList.Items.Clear();
        }

        public LayerBoxForm()
        {
            InitializeComponent();
        }

        private void LayerBoxForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();                               //hide the form when you close it
            MainForm.g_blLayerBoxIsShow = false;
        }

        private void lstLayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Decide which shape is selected according to the Selection in LayerList
            foreach (Shape s in MainForm.g_lstShapeList)
            {
                s.m_blSelected = false;
            }
            MainForm.g_lstSelectedShapeList.Clear();                     //Begin from none Shape selected
            foreach (ListViewItem l in lstLayerList.SelectedItems)
            {
                if (l.Index != (lstLayerList.Items.Count - 1))              //the backgound is in the lstLayerList but not in the ShapeList
                {
                    MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1 - l.Index].m_blSelected = true;
                }
            }
            
            foreach (Shape s in MainForm.g_lstShapeList)     //Adjust the SelectedShapeList
            {
                if(s.m_blSelected==true)
                {
                    MainForm.g_lstSelectedShapeList.Add(s);
                }
            }
        }

        private void lstLayerList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            foreach (ListViewItem l in lstLayerList.Items)              //If the item is not checked,the shape is visible
            {
                if (l.Index != (lstLayerList.Items.Count - 1))
                {
                    if (l.Checked == true)
                    {
                        MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1 - l.Index].m_blVisible= true;
                    }
                    else
                    {
                        MainForm.g_lstShapeList[MainForm.g_lstShapeList.Count - 1 - l.Index].m_blVisible = false;
                    }
                    frmMainForm.pnlBackground.Invalidate();
                }
            }
        }



    }
}
