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
       
        Pal[] pals = CC_SQliteDatabase.PalArray();
        
        Pal selectedPal1 = new Pal();
        Pal selectedPal2 = new Pal();


        public page_AZV_parents()
        {
            InitializeComponent();
            CC_SQliteDatabase.LoadCB<Pal>(cb_parent1);
            CC_SQliteDatabase.LoadCB<Pal>(cb_parent2);
            ChildCalculation(pals);
            
        }        

        private void Cb_Parent1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            selectedPal1 = (Pal)cb_parent1.SelectedItem;

            Image palImage1 = CC_Converter.ByteArrayToImage(selectedPal1.Picture);
            pb_parent1.Image = palImage1;

            lbl_crvalue1.Text = selectedPal1.Combi_Rank.ToString();

            ChildCalculation(pals);
        }
        private void Cb_Parent2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPal2 = (Pal)cb_parent2.SelectedItem;

            Image palImage2 = CC_Converter.ByteArrayToImage(selectedPal2.Picture);
            pb_parent2.Image = palImage2;

            lbl_crvalue2.Text = selectedPal2.Combi_Rank.ToString();

            ChildCalculation(pals);
        }



        private void ChildCalculation(Pal[] pals)
        {
            int childCR = (selectedPal1.Combi_Rank+selectedPal2.Combi_Rank)/2;

            for (int i = 0; i < pals.Length; i++)
            {
                if (childCR == pals[i].Combi_Rank)
                {
                    Image child = CC_Converter.ByteArrayToImage(pals[i].Picture);
                    pb_child.Image= child;
                    lbl_child.Text = pals[i].Name;
                    break;
                }
            }

        }
    }
}
