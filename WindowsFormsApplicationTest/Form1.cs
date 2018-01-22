//Steven Green
//PA-3 POKEMON CONVERTER WINDOWS FORM
//NOW IN COMIC SANS FOR YOUR VIEWING PLEASURE

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationTest
{
    public partial class frmMain : Form
    {
        string pokeName = null;
        double pokeHeight = 0;
        double pokeWeight = 0;
        string pokeHeightClass = null;
        string pokeWeightClass = null;



        public frmMain()
        {

            InitializeComponent();
            btnConvert.Enabled = false;
            txtbxWeight.Enabled = false;
            txtbxHeight.Enabled = false;
            txtbxName.Focus();
        }
        public static String getWeightClass(double pokeWeight)
        {
            string pokeWeightClass = null;

            if (pokeWeight >= 9000)
            {
                pokeWeightClass = "Extra Large";
            }
            else if (pokeWeight >= 100 && pokeWeight <= 499)
            {
                pokeWeightClass = "Normal";
            }
            else if (pokeWeight < 100 && pokeWeight >= 0.01)
            {
                pokeWeightClass = "Extra Small";
            }
            else
            {
                pokeWeightClass = "Invalid data entry.";
            }
            return pokeWeightClass;
        }
        public static String getHeightClass(double pokeHeight)
        {
            string pokeHeightClass = null;

            if (pokeHeight >= 1000)
            {
                pokeHeightClass = "Tall";
            }
            else if (pokeHeight >= 30 && pokeHeight <= 49)
            {
                pokeHeightClass = "Normal";
            }

            else if (pokeHeight < 30 && pokeHeight >= 0.001)
            {
                pokeHeightClass = "Short";
            }
            else
            {
                pokeHeightClass = "Invalid data entry.";
            }
            return pokeHeightClass;
        }
        private void clearControls()
        {
            txtbxConvertedHeight.Clear();
            txtbxConvertedWeight.Clear();
            txtbxHeightClass.Clear();
            txtbxWeightClass.Clear();

        }
        private void clearControlsOrg()
        {
            txtbxHeight.Clear();
            txtbxWeight.Clear();
        }

        //buttons
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void btnConvert_Click(object sender, EventArgs e)
        {
            const double weightConst = 35.274, heightConst = 39.3701;
            pokeName = txtbxName.Text;
            if (txtbxName.Text == ""|| pokeName.Length < 3) // you dont need a method for this
            {
                MessageBox.Show("INVALID NAME");
                clearControls();
                txtbxName.Focus();
            }
            else
            {
                btnConvert.Enabled = true;
                try
                {
                    pokeHeight = double.Parse(txtbxHeight.Text);
                    while (pokeHeight < 0.001 || pokeHeight > 1000)
                    {
                        MessageBox.Show("Please enter a valid number for the height field. (Between 0.01 kg and 9000 kg)");
                        clearControls();
                        txtbxHeight.Focus();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number for the height and weight fields.");
                    return;
                }
                try
                {
                    pokeWeight = double.Parse(txtbxWeight.Text);
                    while (pokeWeight < 0.01 || pokeWeight > 9000)
                    {
                        MessageBox.Show("Please enter a valid number for the weight field. (Between 0.001 m and 1000 m)");
                        clearControls();
                        txtbxWeight.Focus();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number for the height and weight fields.");
                    return;
                } 

                    //Calculations and conversions
                    pokeWeight *= weightConst;
                    pokeWeight = Math.Round(pokeWeight, 1);
                    pokeHeight *= heightConst;
                    pokeHeight = Math.Round(pokeHeight, 2);

                    //Height Assignment
                    pokeHeightClass = getHeightClass(pokeHeight);
                    //Weight Assignment
                    pokeWeightClass = getWeightClass(pokeWeight);
                    //Conversions
                    txtbxConvertedHeight.Text = Convert.ToString(pokeHeight);
                    txtbxConvertedWeight.Text = Convert.ToString(pokeWeight);
                    txtbxHeightClass.Text = pokeHeightClass;
                    txtbxWeightClass.Text = pokeWeightClass;
                
            }


        }
        //buttons
        //Textboxes
        private void txtbxHeight_TextChanged(object sender, EventArgs e)
        {
            //height
            //clears the text when this is changed
            clearControls();
        }

        private void txtbxWeight_TextChanged(object sender, EventArgs e)
        {
            //weight
            //clears the text when this is changed
            clearControls();
        }
        private void txtbxName_TextChanged(object sender, EventArgs e)//name
        {
            if (txtbxName.Text != null)
            {
                btnConvert.Enabled = true;
                txtbxWeight.Enabled = true;
                txtbxHeight.Enabled = true;
            }
            if (txtbxName.Text == "")
            {
                btnConvert.Enabled = false;
                txtbxWeight.Enabled = false;
                txtbxHeight.Enabled = false;
            }
            //clears the text when this is changed
            clearControls();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //height in

            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //weight class
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //weight oz
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //height class
        }
        //textboxes
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblweight_Click(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void grpConverted_Enter(object sender, EventArgs e)
        {

        }



        private void close(object sender, MouseEventArgs e)
        {

        }
    }
}
