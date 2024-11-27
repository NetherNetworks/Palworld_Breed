using Palworld_Breed.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            /*if (((Pal)cb_parent1.SelectedItem).Combi_Rank == 50 && ((Pal)cb_parent2.SelectedItem).Combi_Rank == 150)
            {*/
                double childCombiRank = (((Pal)cb_parent1.SelectedItem).Combi_Rank + ((Pal)cb_parent2.SelectedItem).Combi_Rank) / 2;

                List<Pal> palList = CC_SQliteDatabase.listOfPals();

                bool exists = palList.Any(pal => (double)pal.Combi_Rank == childCombiRank);

                if (exists)
                {
                    for (int i = 0; i < palList.Count; i++)
                    {
                        if ((double)palList[i].Combi_Rank == childCombiRank)
                        {
                            pb_child.Image = CC_Converter.ByteArrayToImage(palList[i].Picture);
                            return;
                        }
                    }
                }
            
                
                
                //}

            //TODO need to get the index of that pal, which matched the palList.Any result

            /*
            // 1.       Add combi ranks of both parents together, then divide by two

            // 2.       Check, if any pal exists with the result of step 1. If so, the logic is done.

            // 3        If there is no match, we need to find the position within the entire pal list,
                        where one pal's combi rank is lower than the result and the next pal's combi rank within
                        the list is higher than the result. - Create a loop from smallest to largest combi rank,
                        as soon as the current combi rank is bigger than the result from step 1, we have found the position.

            // 3.1.1    We now need to find the difference between the smaller combi rank to the result + the difference
                        from the bigger combi rank to the result. The smaller difference wins. In this case the logic is done.


            // 3.1.2    If there is a tie, then the pal with the lower tie breaker value wins. At this point the logic is done.
            */
        }
    }
}
