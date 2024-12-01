using Palworld_Breed.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palworld_Breed.pages
{
    public partial class page_AZV_parents : UserControl
    {
        Pal selectedPal1 = new Pal();
        Pal selectedPal2 = new Pal();


        public page_AZV_parents()
        {
            InitializeComponent();
            
            cb_parent1.DataSource = CC_SQliteDatabase.listOfPals();
            cb_parent2.DataSource = CC_SQliteDatabase.listOfPals();
        }        

        private void Cb_Parent1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCBPicture(cb_parent1, pb_parent1);
            lbl_crvalue1.Text = ((Pal)cb_parent1.SelectedItem).Combi_Rank.ToString();

            ChildCalculation();
        }

        private void Cb_Parent2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCBPicture(cb_parent2, pb_parent2);
            lbl_crvalue2.Text = ((Pal)cb_parent2.SelectedItem).Combi_Rank.ToString();

            ChildCalculation();
        }

        private void loadCBPicture(ComboBox cb, PictureBox pb)
        {
            pb.Image = CC_Converter.ByteArrayToImage(((Pal)cb.SelectedItem).Picture);
        }

        
        private void ChildCalculation()
        {
            int index;
            double differenceLow, differenceHigh;

            if (cb_parent1.SelectedItem != null && cb_parent2.SelectedItem != null)
            {
                double childCombiRank = (((Pal)cb_parent1.SelectedItem).Combi_Rank + ((Pal)cb_parent2.SelectedItem).Combi_Rank) / 2;

                List<Pal> palList = CC_SQliteDatabase.listOfPals();

                //bool matchFound = palList.Any(pal => pal.Combi_Rank == childCombiRank);

                index = palList.FindIndex(pal => (double)pal.Combi_Rank == childCombiRank);

                if (index != -1)
                {
                    pb_child.Image = CC_Converter.ByteArrayToImage(palList[index].Picture);
                    lbl_cr_child.Text = palList[index].Combi_Rank.ToString();
                    lbl_child_name.Text = palList[index].Name;
                    return;
                }

                for (int i = 0; i < palList.Count; i++)
                {
                    if ((double)palList[i].Combi_Rank > childCombiRank)
                    {
                        differenceLow = childCombiRank - (double)palList[i-1].Combi_Rank;
                        differenceHigh = (double)palList[i].Combi_Rank - childCombiRank;

                        if (differenceHigh == differenceLow)
                        {
                            if (palList[i].TB_Nr < palList[i-1].TB_Nr)
                            {
                                pb_child.Image = CC_Converter.ByteArrayToImage(palList[i].Picture);
                                lbl_cr_child.Text = palList[i].Combi_Rank.ToString();
                                lbl_child_name.Text = palList[i].Name;
                                return;
                            }
                            else
                            {
                                pb_child.Image = CC_Converter.ByteArrayToImage(palList[i-1].Picture);
                                lbl_cr_child.Text = palList[i-1].Combi_Rank.ToString();
                                lbl_child_name.Text = palList[i-1].Name;
                                return;
                            }
                        }
                        else if (differenceHigh < differenceLow)
                        {
                            pb_child.Image = CC_Converter.ByteArrayToImage(palList[i].Picture);
                            lbl_cr_child.Text = palList[i].Combi_Rank.ToString();
                            lbl_child_name.Text = palList[i].Name;
                            return;
                        }
                        else
                        {
                            pb_child.Image = CC_Converter.ByteArrayToImage(palList[i-1].Picture);
                            lbl_cr_child.Text = palList[i - 1].Combi_Rank.ToString();
                            lbl_child_name.Text = palList[i - 1].Name;
                            return;
                        }
                    }
                }
            }
        }
    }
}
