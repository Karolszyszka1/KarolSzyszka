using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra
{
    public partial class Form1 : Form
    {
        int i=0, l1 = 0, l2 = 0, l3= 0, l4 =0, l5=0, l6=0, l7 =0, l8=0,l9 = 0,l10=0, l11 = 0, l12 = 0, l13 = 0, l14 = 0, l15 = 0, l16 = 0, l17 = 0, l18 = 0, l19 = 0, l20 = 0,
            l21= 0, l22 = 0, l23 = 0, l24 = 0, l25 = 0, l26 = 0, l27 = 0, l28 = 0, l29 = 0, l30 = 0, l31 = 0, l32 = 0, l33 = 0, l34 = 0, l35 = 0, l36 = 0, l37 = 0, l38 = 0, l39 = 0, 
            l40 = 0, l41 = 0, l42 = 0, l43 = 0, l44 = 0, l45 = 0, l46 = 0, l47 = 0, l48 = 0, l49 = 0, l50 = 0,
            l51 = 0, l52 = 0, l53 = 0, l54 = 0, l55 = 0, l56 = 0, l57 = 0, l58 = 0, l59 = 0, l60 = 0, l61 = 0, l62 = 0, l63 = 0, l64 = 0;
        
private void label34_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l34 = 1;
                i++;
                label34.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = true;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = true;
                label50.Enabled = false;
                label51.Enabled = true;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;


            }
            else if (i > 0 && l34 == 0)
            {
                l34 = 1;
                i++;

                label34.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = true;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = true;
                label50.Enabled = false;
                label51.Enabled = true;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else label65.Text = "źle";
            if (l51 == 1 && l49 == 1 && l34 == 1 && l28 == 1 && l17 == 1 && l19 == 1)
            {
                l34 = 2;
                            label65.Text = "Koniec gry";
                            
            }
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l1 == 2)
            {
                label1.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label1.Enabled = true;
                l1 = 0;

            }
            else if (l2 == 2)
            {
                label2.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label2.Enabled = true;
                l2 = 0;
            }
            else if (l3 == 2)
            {
                label3.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label3.Enabled = true;
                l3 = 0;
            }
            else if (l4 == 2)
            {
                label4.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label4.Enabled = true;
                l4 = 0;
            }
            else if (l5 == 2)
            {
                label5.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label5.Enabled = true;
                l5 = 0;
            }
            else if (l6 == 2)
            {
                label6.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label6.Enabled = true;
                l6 = 0;
            }
            else if (l7 == 2)
            {
                label7.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label7.Enabled = true;
                l7 = 0;
            }
            else if (l8 == 2)
            {
                label8.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label8.Enabled = true;
                l8 = 0;
            }
            else if (l9 == 2)
            {
                label3.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label9.Enabled = true;
                l9 = 0;
            }
            else if (l10 == 2)
            {
                label10.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label10.Enabled = true;
                l10 = 0;
            }
            else if (l11 == 2)
            {
                label11.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label11.Enabled = true;
                l11 = 0;
            }
            else if (l12 == 2)
            {
                label12.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label12.Enabled = true;
                l12 = 0;
            }
            else if (l13 == 2)
            {
                label13.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label13.Enabled = true;
                l13 = 0;
            }
            else if (l14 == 2)
            {
                label14.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label14.Enabled = true;
                l14 = 0;
            }
            else if (l15 == 2)
            {
                label15.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label15.Enabled = true;
                l15 = 0;
            }
            else if (l16 == 2)
            {
                label16.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label16.Enabled = true;
                l16 = 0;
            }
            else if (l17 == 2)
            {
                label17.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label17.Enabled = true;
                l17 = 0;
            }
            else if (l18 == 2)
            {
                label18.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label18.Enabled = true;
                l18 = 0;
            }
            else if (l19 == 2)
            {
                label19.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label19.Enabled = true;
                l19 = 0;
            }
            else if (l20 == 2)
            {
                label20.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label20.Enabled = true;
                l20 = 0;
            }
            else if (l21 == 2)
            {
                label21.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label21.Enabled = true;
                l21 = 0;
            }
            else if (l22 == 2)
            {
                label22.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label22.Enabled = true;
                l22 = 0;
            }
            else if (l23 == 2)
            {
                label23.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label23.Enabled = true;
                l23 = 0;
            }
            else if (l24 == 2)
            {
                label24.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label24.Enabled = true;
                l24 = 0;
            }
            else if (l25 == 2)
            {
                label25.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label25.Enabled = true;
                l25 = 0;
            }
            else if (l26 == 2)
            {
                label26.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label26.Enabled = true;
                l26 = 0;
            }
            else if (l27 == 2)
            {
                label27.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label27.Enabled = true;
                l27 = 0;
            }
            else if (l28 == 2)
            {
                label28.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label28.Enabled = true;
                l28 = 0;
            }
            else if (l29 == 2)
            {
                label29.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label29.Enabled = true;
                l29 = 0;
            }
            else if (l30 == 2)
            {
                label30.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label30.Enabled = true;
                l30 = 0;
            }
            else if (l31 == 2)
            {
                label31.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label31.Enabled = true;
                l31 = 0;
            }
            else if (l32 == 2)
            {
                label32.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label32.Enabled = true;
                l32 = 0;
            }
            else if (l33 == 2)
            {
                label33.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label33.Enabled = true;
                l33 = 0;
            }
            else if (l34 == 2)
            {
                label34.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label34.Enabled = true;
                l34 = 0;
            }
            else if (l35 == 2)
            {
                label35.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label35.Enabled = true;
                l35 = 0;
            }
            else if (l36 == 2)
            {
                label36.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label36.Enabled = true;
                l36 = 0;
            }
            else if (l37 == 2)
            {
                label37.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label37.Enabled = true;
                l37 = 0;
            }
            else if (l38 == 2)
            {
                label38.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label38.Enabled = true;
                l38 = 0;
            }
            else if (l39 == 2)
            {
                label39.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label39.Enabled = true;
                l39 = 0;
            }
            else if (l40 == 2)
            {
                label40.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label40.Enabled = true;
                l40 = 0;
            }
            else if (l41 == 2)
            {
                label41.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label41.Enabled = true;
                l41 = 0;
            }
            else if (l42 == 2)
            {
                label42.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label42.Enabled = true;
                l42 = 0;
            }
            else if (l43 == 2)
            {
                label43.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label43.Enabled = true;
                l43 = 0;
            }
            else if (l44 == 2)
            {
                label44.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label44.Enabled = true;
                l44 = 0;
            }
            else if (l45 == 2)
            {
                label45.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label45.Enabled = true;
                l45 = 0;

            }
            else if (l46 == 2)
            {
                label46.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label46.Enabled = true;
                l46 = 0;
            }
            else if (l47 == 2)
            {
                label47.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label47.Enabled = true;
                l47 = 0;
            }
            else if (l48 == 2)
            {
                label48.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label48.Enabled = true;
                l48 = 0;
            }
            else if (l49 == 2)
            {
                label49.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label49.Enabled = true;
                l49 = 0;
            }
            else if (l50 == 2)
            {
                label50.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label50.Enabled = true;
                l50 = 0;
            }
            else if (l51 == 2)
            {
                label51.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label51.Enabled = true;
                l51 = 0;
            }
            else if (l52 == 2)
            {
                label52.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label52.Enabled = true;
                l52 = 0;
            }
            else if (l53 == 2)
            {
                label53.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label53.Enabled = true;
                l53 = 0;
            }
            else if (l54 == 2)
            {
                label54.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label54.Enabled = true;
                l54 = 0;
            }
            else if (l55 == 2)
            {
                label55.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label55.Enabled = true;
                l55 = 0;
            }
            else if (l56 == 2)
            {
                label56.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label56.Enabled = true;
                l56 = 0;
            }
            else if (l57 == 2)
            {
                label57.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label57.Enabled = true;
                l57 = 0;
            }
            else if (l58 == 2)
            {
                label58.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label58.Enabled = true;
                l58 = 0;
            }
            else if (l59 == 2)
            {
                label59.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label59.Enabled = true;
                l59 = 0;
            }
            else if (l60 == 2)
            {
                label60.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label60.Enabled = true;
                l60 = 0;
            }
            else if (l61 == 2)
            {
                label61.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label61.Enabled = true;
                l61 = 0;
            }
            else if (l62 == 2)
            {
                label62.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label62.Enabled = true;
                l62 = 0;
            }
            else if (l63 == 2)
            {
                label63.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label63.Enabled = true;
                l63 = 0;
            }
            else if (l64 == 2)
            {
                label64.ResetText();
                label65.ResetText();
                label64.Text = Convert.ToString(i--);
                cofnijToolStripMenuItem.Enabled = false;
                label64.Enabled = true;
                l64 = 0;
            }
        }

        private void koniecGryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ResetText(); cofnijToolStripMenuItem.Enabled = true;
            label2.ResetText();
            label3.ResetText();
            label4.ResetText();
            label5.ResetText();
            label6.ResetText();
            label7.ResetText();
            label8.ResetText();
            label9.ResetText();
            label10.ResetText();
            label11.ResetText();
            label12.ResetText();
            label13.ResetText();
            label14.ResetText();
            label15.ResetText();
            label16.ResetText();
            label17.ResetText();
            label18.ResetText();
            label19.ResetText();
            label20.ResetText();
            label21.ResetText();
            label22.ResetText();
            label23.ResetText();
            label24.ResetText();
            label25.ResetText();
            label26.ResetText();
            label27.ResetText();
            label28.ResetText();
            label29.ResetText();
            label30.ResetText();
            label31.ResetText();
            label32.ResetText();
            label33.ResetText();
            label34.ResetText();
            label35.ResetText();
            label36.ResetText();
            label37.ResetText();
            label38.ResetText();
            label39.ResetText();
            label40.ResetText();
            label41.ResetText();
            label42.ResetText();
            label43.ResetText();
            label44.ResetText();
            label45.ResetText();
            label46.ResetText();
            label47.ResetText();
            label48.ResetText();
            label49.ResetText();
            label50.ResetText();
            label51.ResetText();
            label51.ResetText();
            label52.ResetText();
            label53.ResetText();
            label54.ResetText();
            label55.ResetText();
            label56.ResetText();
            label57.ResetText();
            label58.ResetText();
            label59.ResetText();
            label60.ResetText();
            label61.ResetText();
            label62.ResetText();
            label63.ResetText();
            label64.ResetText();
            label65.ResetText();
            label66.ResetText();
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled =true;
            label9.Enabled = true;
            label10.Enabled = true;
            label11.Enabled = true;
            label12.Enabled = true;
            label13.Enabled =   true;
            label14.Enabled = true;
            label15.Enabled = true;
            label16.Enabled = true;
            label17.Enabled = true;
            label18.Enabled = true;
            label19.Enabled = true   ;
            label20.Enabled = true;
            label21.Enabled = true;
            label22.Enabled = true;
            label23.Enabled = true;
            label24.Enabled = true;
            label25.Enabled = true;
            label26.Enabled = true;
            label27.Enabled = true;
            label28.Enabled = true;
            label29.Enabled = true;
            label30.Enabled = true;
            label31.Enabled = true;
            label32.Enabled = true;
            label33.Enabled = true;
            label34.Enabled = true;
            label35.Enabled = true;
            label36.Enabled = true;
            label37.Enabled = true;
            label38.Enabled = true;
            label39.Enabled = true;
            label40.Enabled =   true;
            label41.Enabled = true;
            label42.Enabled = true;
            label43.Enabled = true;
            label44.Enabled = true;
            label45.Enabled = true;
            label46.Enabled = true;
            label47.Enabled = true;
            label48.Enabled =   true;
            label49.Enabled = true;
            label50.Enabled = true;
            label51.Enabled = true;
            label52.Enabled = true;
            label53.Enabled = true;
            label54.Enabled = true;
            label55.Enabled = true;
            label56.Enabled =   true;
            label57.Enabled = true;
            label58.Enabled = true;
            label59.Enabled = true;
            label60.Enabled = true;
            label61.Enabled =   true;
            label62.Enabled = true;
            label63.Enabled =true;
            label64.Enabled = true;
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label35_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l35 = 1;
                i++;
                label35.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = true;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = true;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = true;
                label51.Enabled = false;
                label52.Enabled = true;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;


            }
            else if (i > 0 && l35 == 0)
            {
                l35 = 1;
                i++;

                label35.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = true;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = true;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = true;
                label51.Enabled = false;
                label52.Enabled = true;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else label65.Text = "źle";
            if (l52 == 1 && l50 == 1 && l45 == 1 && l41 == 1 && l29 == 1 && l25 == 1 && l20 ==1 && l18==1)
            {
                l35 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label36_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l36 = 1;
                i++;
                label36.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = true;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l36 == 0)
            {
                l36 = 1;
                i++;

                label36.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = true;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l53 == 1 && l51 == 1 && l46 == 1 && l42 == 1 && l30 == 1 && l26 == 1 && l21 == 1 && l19 == 1)
            {
                l36 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label37_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l37 = 1;
                i++;
                label37.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = true;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l37 == 0)
            {
                l37 = 1;
                i++;

                label37.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = true;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l54 == 1 && l52 == 1 && l47== 1 && l43 == 1 && l31 == 1 && l27 == 1 && l22 == 1 && l20 == 1)
            {
                l37 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label38_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l38 = 1;
                i++;
                label38.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = true;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = true;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = true;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l38 == 0)
            {
                l38 = 1;
                i++;

                label38.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = true;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = true;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = true;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l55 == 1 && l53 == 1 && l48 == 1 && l44 == 1 && l32 == 1 && l28 == 1 && l23 == 1 && l21 == 1)
            {
                l38 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label39_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l39 = 1;
                i++;
                label39.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = true;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = true;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l39 == 0)
            {
                l39 = 1;
                i++;

                label39.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = true;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = true;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l56 == 1 && l54 == 1 && l45 == 1 && l29 == 1 && l24 == 1 && l22 == 1 )
            {
                l39 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label40_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l40 = 1;
                i++;
                label40.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = true;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l40 == 0)
            {
                l40 = 1;
                i++;

                label40.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = true;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l55 == 1 && l46 == 1 && l30== 1 && l23 == 1 )
            {
                l40 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label41_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l41 = 1;
                i++;
                label41.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = true;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = true;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l41 == 0)
            {
                l41 = 1;
                i++;

                label41.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = true;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = true;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l58 == 1 && l51 == 1 && l46 == 1 && l35 == 1 && l26== 1 )
            {
                l41 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label42_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l42 = 1;
                i++;
                label42.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = true;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = true;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = true;
                label58.Enabled = false;
                label59.Enabled = true;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l42 == 0)
            {
                l42 = 1;
                i++;

                label42.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = true;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = true;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = true;
                label58.Enabled = false;
                label59.Enabled = true;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l59 == 1 && l52 == 1 && l36 == 1 && l27== 1 && l25 == 1)
            {
                l42 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label43_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l43 = 1;
                i++;
                label43.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = true;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = true;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = true;
                label59.Enabled = false;
                label60.Enabled = true;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l43 == 0)
            {
                l43 = 1;
                i++;

                label43.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = true;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = true;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = true;
                label59.Enabled = false;
                label60.Enabled = true;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l58 == 1 && l60 == 1 && l53 == 1 && l49 == 1 && l37 == 1 && l33 == 1 && l28 == 1 && l26 == 1)
            {
                l43 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label44_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l44 = 1;
                i++;
                label44.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = true;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = true;
                label60.Enabled = false;
                label61.Enabled = true;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l44 == 0)
            {
                l44 = 1;
                i++;

                label44.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = true;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = true;
                label60.Enabled = false;
                label61.Enabled = true;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l61 == 1 && l59 == 1 && l54 == 1 && l50 == 1 && l38 == 1 && l34 == 1 && l29== 1 && l27== 1)
            {
                l44 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label45_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l45 = 1;
                i++;
                label45.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = true;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = true;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = true;
                label61.Enabled = false;
                label62.Enabled =true;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l45 == 0)
            {
                l45 = 1;
                i++;

                label45.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = true;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = true;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = true;
                label61.Enabled = false;
                label62.Enabled = true;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l62 == 1 && l60 == 1 && l55 == 1 && l51 == 1 && l39 == 1 && l35 == 1 && l30 == 1 && l28 == 1)
            {
                l45 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label46_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l46 = 1;
                i++;
                label46.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = true;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = true;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = true;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = true;
                label62.Enabled = false;
                label63.Enabled = true;
                label64.Enabled = false;

            }
            else if (i > 0 && l46 == 0)
            {
                l46 = 1;
                i++;

                label46.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = true;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = true;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = true;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = true;
                label62.Enabled = false;
                label63.Enabled = true;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l63 == 1 && l61 == 1 && l56 == 1 && l52 == 1 && l40 == 1 && l36 == 1 && l31 == 1 && l29 == 1)
            {
                l46 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label47_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l47 = 1;
                i++;
                label47.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = true;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = true;
                label63.Enabled = false;
                label64.Enabled = true;

            }
            else if (i > 0 && l47 == 0)
            {
                l47 = 1;
                i++;

                label47.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = true;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = true;
                label63.Enabled = false;
                label64.Enabled = true;
            }
            else label65.Text = "źle";
            if (l64 == 1 && l62 == 1 && l53 == 1 && l37 == 1 && l32 == 1 && l30 == 1)
            {
                l47 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label48_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l48 = 1;
                i++;
                label48.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = true;
                label64.Enabled = false;

            }
            else if (i > 0 && l48 == 0)
            {
                l48 = 1;
                i++;

                label48.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = true;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l63 == 1 && l54 == 1 && l38== 1 && l42 == 1 && l31 == 1)
            {
                l48 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label49_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l49 = 1;
                i++;
                label49.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = true;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l49 == 0)
            {
                l49 = 1;
                i++;

                label49.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = true;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l59 == 1 && l43 == 1 && l34 == 1 )
            {
                l49 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label50_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l50 = 1;
                i++;
                label50.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = true;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = true;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l50 == 0)
            {
                l50 = 1;
                i++;

                label50.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = true;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = true;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l60 == 1 && l44 == 1 && l35 == 1 && l33 == 1 )
            {
                l50 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label51_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l51 = 1;
                i++;
                label51.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled =true;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = true;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = true;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = true;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l51 == 0)
            {
                l51 = 1;
                i++;

                label51.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = true;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = true;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = true;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l61== 1 && l57 == 1 && l45 == 1 && l41 == 1 && l36 == 1 && l34 == 1)
            {
                l51 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label52_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l52 = 1;
                i++;
                label52.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled =true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = true;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = true;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l52 == 0)
            {
                l52 = 1;
                i++;

                label52.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = true;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = true;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l62 == 1 && l58 == 1 && l46 == 1 && l42 == 1 && l37 == 1 && l35 == 1)
            {
                l52 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label53_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l53 = 1;
                i++;
                label53.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = true;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = true;
                label64.Enabled = false;

            }
            else if (i > 0 && l53 == 0)
            {
                l53 = 1;
                i++;

                label50.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = true;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = true;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l63 == 1 && l59 == 1 && l47 == 1 && l43 == 1 && l38 == 1 && l36 == 1 )
            {
                l53 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label54_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l54 = 1;
                i++;
                label54.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = true;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = true;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = true;

            }
            else if (i > 0 && l50 == 0)
            {
                l54 = 1;
                i++;

                label54.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = true;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = true;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = true;
            }
            else label65.Text = "źle";
            if (l64 == 1 && l60 == 1 && l48 == 1 && l44 == 1 && l39 == 1 && l37 == 1 )
            {
                l54 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label55_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l55 = 1;
                i++;
                label55.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = true;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = true;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l55 == 0)
            {
                l55 = 1;
                i++;

                label55.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = true;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = true;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l61 == 1 && l45 == 1 && l40 == 1 && l38 == 1)
            {
                l55 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label56_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l56 = 1;
                i++;
                label56.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = true;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l56 == 0)
            {
                l56 = 1;
                i++;

                label56.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = true;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = true;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l62 == 1 && l46 == 1 && l39 == 1)
            {
                l56 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label57_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l57 = 1;
                i++;
                label57.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled =   true;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l57 == 0)
            {
                l57 = 1;
                i++;

                label57.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = true;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l51 == 1 && l42 == 1)
            {
                l57 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label58_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l58 = 1;
                i++;
                label58.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = true;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled =true;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l58 == 0)
            {
                l58 = 1;
                i++;

                label58.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = true;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = true;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l52 == 1 && l43 == 1 && l41 == 1 )
            {
                l58 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label59_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l59 = 1;
                i++;
                label59.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = true;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l59 == 0)
            {
                l59 = 1;
                i++;

                label59.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = true;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l53 == 1 && l49 == 1 && l44 == 1 && l42 == 1 )
            {
                l59 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label60_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l60 = 1;
                i++;
                label60.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = true;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l60 == 0)
            {
                l60 = 1;
                i++;

                label60.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = true;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l54 == 1 && l50 == 1 && l45== 1 && l43 == 1 )
            {
                l60 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label61_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l61 = 1;
                i++;
                label61.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled =   true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = true;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = true;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l61 == 0)
            {
                l61 = 1;
                i++;

                label61.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = true;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = true;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l55 == 1 && l51 == 1 && l46 == 1 && l44 == 1 )
            {
                l61 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label62_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l62 = 1;
                i++;
                label62.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = true;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = true;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l62 == 0)
            {
                l62 = 1;
                i++;

                label62.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = true;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = true;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l56 == 1 && l52 == 1 && l47 == 1 && l45 == 1 )
            {
                l62 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label63_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l63 = 1;
                i++;
                label63.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = true;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l63 == 0)
            {
                l63 = 1;
                i++;

                label63.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = true;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = true;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l53 == 1 && l48 == 1 && l46 == 1 )
            {
                l63 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label64_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l64 = 1;
                i++;
                label64.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l64 == 0)
            {
                l64 = 1;
                i++;

                label64.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = true;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l54 == 1 && l47 == 1 )
            {
                l64 = 2;
                label65.Text = "Koniec gry";

            }
        }

        
        private void label33_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l33 = 1;
                i++;
                label33.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = true;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l33 == 0)
            {
                l33 = 1;
                i++;

                label32.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = true;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l50 == 1 && l43 == 1 && l27 == 1 && l18 == 1 )
            {
                l33 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label32_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l32 = 1;
                i++;
                label32.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = true;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l32 == 0)
            {
                l32 = 1;
                i++;

                label32.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = true;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l47 == 1 && l38 == 1 && l22 == 1 && l15 == 1 )
            {
                l32 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l31 = 1;
                i++;
                label31.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = true;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled =true;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l31 == 0)
            {
                l31 = 1;
                i++;

                label31.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = true;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = true;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l48 == 1 && l46 == 1 && l37 == 1 && l21 == 1 && l16 == 1 )
            {
                l31 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label30_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l30 = 1;
                i++;
                label30.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled =true;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = true;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = true;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l30 == 0)
            {
                l30 = 1;
                i++;

                label30.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = true;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = true;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = true;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = true;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l47 == 1 && l45 == 1 && l40 == 1 && l36 == 1 && l24 == 1 && l20 == 1 && l15 == 1 && l13 == 1)
            {
                l30 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l29 = 1;
                i++;
                label29.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = true;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l29 == 0)
            {
                l29 = 1;
                i++;

                label29.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = true;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = true;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l46 == 1 && l44 == 1 && l39 == 1 && l35 == 1 && l23 == 1 && l19 == 1 && l12 == 1 && l14 == 1)
            {
                l29 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l28 = 1;
                i++;
                label28.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled =true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l28 == 0)
            {
                l28 = 1;
                i++;

                label28.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = true;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l45 == 1 && l43 == 1 && l38 == 1 && l34 == 1 && l22 == 1 && l18 == 1 && l13 == 1 && l11 == 1)
            {
                l28 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l27 = 1;
                i++;
                label27.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = true;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = true;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = true;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l27 == 0)
            {
                l27 = 1;
                i++;

                label27.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = true;
                label11.Enabled = false;
                label12.Enabled = true;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = true;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = true;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = true;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l44 == 1 && l42 == 1 && l37 == 1 && l33 == 1 && l21 == 1 && l17 == 1 && l10 == 1 && l12 == 1)
            {
                l27 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l26 = 1;
                i++;
                label26.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = true;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = true;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l26 == 0)
            {
                l26 = 1;
                i++;

                label26.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = true;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = true;
                label42.Enabled = false;
                label43.Enabled = true;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l43 == 1 && l41 == 1 && l36 == 1 && l20 == 1 && l11 == 1 && l9 == 1 )
            {
                l26 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l25 = 1;
                i++;
                label25.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = true;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l25 == 0)
            {
                l25 = 1;
                i++;

                label25.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = true;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = true;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l42 == 1 && l35 == 1 && l19 == 1 && l10 == 1 )
            {
                l25 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l24 = 1;
                i++;
                label24.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = true;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l24 == 0)
            {
                l24 = 1;
                i++;

                label24.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = true;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l39 == 1 && l30 == 1 && l14 == 1 && l7 == 1 )
            {
                l24 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l23 = 1;
                i++;
                label23.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = true;
                label7.Enabled = false;
                label8.Enabled = true;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = true;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l23 == 0)
            {
                l23 = 1;
                i++;

                label23.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = true;
                label7.Enabled = false;
                label8.Enabled = true;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = true;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l40 == 1 && l38 == 1 && l29 == 1 && l13 == 1 && l8 == 1 )
            {
                l23 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l22 = 1;
                i++;
                label22.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = true;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = true;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = true;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = true;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l22 == 0)
            {
                l22 = 1;
                i++;

                label22.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = true;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = true;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = true;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = true;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = true;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l39 == 1 && l37 == 1 && l32 == 1 && l28 == 1 && l16 == 1 && l12 == 1 && l5 == 1 && l7 == 1)
            {
                l22 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l21 = 1;
                i++;
                label21.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = true;
                label5.Enabled = false;
                label6.Enabled = true;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = true;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l21 == 0)
            {
                l21 = 1;
                i++;

                label21.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = true;
                label5.Enabled = false;
                label6.Enabled = true;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = true;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = true;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l38 == 1 && l36 == 1 && l31 == 1 && l27 == 1 && l15 == 1 && l11 == 1 && l4 == 1 && l6 == 1)
            {
                l21 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l20 = 1;
                i++;
                label20.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = true;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l20 == 0)
            {
                l20 = 1;
                i++;

                label20.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = true;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = true;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l37 == 1 && l35 == 1 && l30 == 1 && l26 == 1 && l14 == 1 && l10 == 1 && l3== 1 && l5 == 1)
            {
                l20 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l19 = 1;
                i++;
                label19.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = true;
                label3.Enabled = false;
                label4.Enabled = true;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = true;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled =true;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = true;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l19 == 0)
            {
                l19 = 1;
                i++;

                label19.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = true;
                label3.Enabled = false;
                label4.Enabled = true;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = true;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = true;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = true;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l36 == 1 && l34 == 1 && l29 == 1 && l25 == 1 && l13 == 1 && l9 == 1 && l2 == 1 && l4== 1)
            {
                l19 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l18 = 1;
                i++;
                label18.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = true;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled =true;
                label34.Enabled = false;
                label35.Enabled =true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l18 == 0)
            {
                l18 = 1;
                i++;

                label18.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = true;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = true;
                label34.Enabled = false;
                label35.Enabled = true;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l35 == 1 && l33 == 1 && l28 == 1 && l12 == 1 && l3 == 1 )
            {
                l18 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l17 = 1;
                i++;
                label17.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = true;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l17 == 0)
            {
                l17 = 1;
                i++;

                label17.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = true;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = true;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l34 == 1 && l27 == 1 && l11 == 1 && l2 == 1 )
            {
                l17 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l9 = 1;
                i++;
                label9.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l9 == 0)
            {
                l9 = 1;
                i++;

                label9.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l26 == 1 && l19 == 1 && l3 == 1 )
            {
                l9 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

            if (i == 0)
            {
                l10 = 1;
                i++;
                label10.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = true;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = true;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l10 == 0)
            {
                l10 = 1;
                i++;

                label10.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = true;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = true;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l27 == 1 && l25 == 1 && l20 == 1 && l4 == 1 )
            {
                l10 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l11 = 1;
                i++;
                label11.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = true;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = true;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l11 == 0)
            {
                l11 = 1;
                i++;

                label11.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = true;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = true;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = true;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l28 == 1 && l26 == 1 && l21 == 1 && l17 == 1 && l1 == 1 && l5 == 1 )
            {
                l11 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l12 = 1;
                i++;
                label12.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = true;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = true;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l12 == 0)
            {
                l12 = 1;
                i++;

                label12.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = true;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = true;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = true;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l29 == 1 && l27 == 1 && l22 == 1 && l18 == 1 && l6 == 1 && l2 == 1 )
            {
                l12 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l13 = 1;
                i++;
                label13.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = true;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l13 == 0)
            {
                l13 = 1;
                i++;

                label13.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = true;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = true;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = true;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l30 == 1 && l28 == 1 && l23 == 1 && l19 == 1 && l7 == 1 && l3 == 1 )
            {
                l13 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l14 = 1;
                i++;
                label14.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = true;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = true;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = true;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l14 == 0)
            {
                l14 = 1;
                i++;

                label14.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = true;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = true;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = true;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = true;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l31 == 1 && l29 == 1 && l24 == 1 && l20 == 1 && l4 == 1 && l8 == 1 )
            {
                l14 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l15 = 1;
                i++;
                label15.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = true;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l15 == 0)
            {
                l15 = 1;
                i++;

                label15.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = true;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = true;
                label31.Enabled = false;
                label32.Enabled = true;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l32 == 1 && l30 == 1 && l21== 1 && l5 == 1)
            {
                l15 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l16= 1;
                i++;
                label16.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = true;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l16 == 0)
            {
                l16 = 1;
                i++;

                label16.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = true;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = true;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l31 == 1 && l22 == 1 && l6== 1)
            {
                l16 = 2;
                label65.Text = "Koniec gry";

            }
        }

        public Form1()
        {
            InitializeComponent();
            oAutorzeToolStripMenuItem.Enabled = true;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l3 = 1;
                i++;
                label3.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = true;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l4 == 0)
            {
                l3 = 1;
                i++;

                label3.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = true;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l20 == 1 && l18 == 1 && l9 == 1 && l13 == 1 )
            {
                l3 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l4 = 1;
                i++;
                label4.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = true;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l4 == 0)
            {
                l4 = 1;
                i++;

                label4.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = true;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l21 == 1 && l19 == 1 && l10== 1 )
            {
                l4 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l5 = 1;
                i++;
                label5.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = true;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l5 == 0)
            {
                l5 = 1;
                i++;

                label5.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = true;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = true;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l22 == 1 && l20 == 1 && l15 == 1 && l11 == 1 )
            {
                l5 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l6 = 1;
                i++;
                label6.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = true;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = true;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l6 == 0)
            {
                l6 = 1;
                i++;

                label6.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = true;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = true;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = true;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else label65.Text = "źle";
            if (l23 == 1 && l21 == 1 && l16 == 1 && l12 == 1 )
            {
                l6 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l7 = 1;
                i++;
                label7.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = true;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l7 == 0)
            {
                l7 = 1;
                i++;

                label7.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = true;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = true;
                label23.Enabled = false;
                label24.Enabled = true;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l24 == 1 && l22 == 1 && l13== 1 )
            {
                l7 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                l8 = 1;
                i++;
                label66.Text = Convert.ToString(i);
                label8.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else if (i > 0 && l8 == 0)
            {
                l8 = 1;
                i++;

                label8.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = true;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = true;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l14 == 1 && l23 == 1 )
            {
                l8 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            if (i == 0)
            {
                l1 = 1;
                i++;
                label1.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l1 == 0)
            {
                l1 = 1;
                i++;

                label1.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = true;
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = true;
                label19.Enabled = false;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;


            }
            else label65.Text = "źle";
            if (l18 == 1 && l11 == 1 )
            {
                l1 = 2;
                label65.Text = "Koniec gry";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

            if (i == 0)
            {
                l2 = 1;
                i++;
                label2.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = true;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = true;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;

            }
            else if (i > 0 && l2 == 0)
            {
                l2 = 1;
                i++;
                label2.Text = Convert.ToString(i);
                label66.Text = Convert.ToString(i);
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = true;
                label13.Enabled = false;
                label14.Enabled = false;
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = true;
                label18.Enabled = false;
                label19.Enabled = true;
                label20.Enabled = false;
                label21.Enabled = false;
                label22.Enabled = false;
                label23.Enabled = false;
                label24.Enabled = false;
                label25.Enabled = false;
                label26.Enabled = false;
                label27.Enabled = false;
                label28.Enabled = false;
                label29.Enabled = false;
                label30.Enabled = false;
                label31.Enabled = false;
                label32.Enabled = false;
                label33.Enabled = false;
                label34.Enabled = false;
                label35.Enabled = false;
                label36.Enabled = false;
                label37.Enabled = false;
                label38.Enabled = false;
                label39.Enabled = false;
                label40.Enabled = false;
                label41.Enabled = false;
                label42.Enabled = false;
                label43.Enabled = false;
                label44.Enabled = false;
                label45.Enabled = false;
                label46.Enabled = false;
                label47.Enabled = false;
                label48.Enabled = false;
                label49.Enabled = false;
                label50.Enabled = false;
                label51.Enabled = false;
                label52.Enabled = false;
                label53.Enabled = false;
                label54.Enabled = false;
                label55.Enabled = false;
                label56.Enabled = false;
                label57.Enabled = false;
                label58.Enabled = false;
                label59.Enabled = false;
                label60.Enabled = false;
                label61.Enabled = false;
                label62.Enabled = false;
                label63.Enabled = false;
                label64.Enabled = false;
            }
            else label65.Text = "źle";
            if (l19 == 1 && l17 == 1 && l12 == 1 )
            {
                l2 = 2;
                label65.Text = "Koniec gry";

            }
        }
    }
}
