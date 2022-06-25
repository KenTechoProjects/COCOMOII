using COCOMO_II_MODEL_BY__OBILOR.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMO_II_MODEL_BY__OBILOR
{
    public partial class Form1 : Form
    {
        DBFrame context;
        public Form1()
        {
            InitializeComponent();
            context = new DBFrame();
        }

        private void btnCostDriver_Click(object sender, EventArgs e)
        {
            CostDriver CD = new CostDriver
            {
                Name= cmbCostDriver.Text
            };
            context.CostDirers.Add(CD);
            context.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var PT = context.SoftwareTypes.ToList();
           if (PT.Count>0)
            {
                
            foreach ( var o in PT)
            {
                cmbConstantProjetcType.DataSource = PT;
                cmbConstantProjetcType.DisplayMember = "Name";
                cmbConstantProjetcType.ValueMember = "SoftwareTypeID";
            }
            }
            var CD = context.CostDirers.ToList();
         if(CD.Count>0)
            {
 
            foreach(var op in CD)
            {   cmbIndividualCD.DataSource=CD;
  cmbIndividualCD.DisplayMember = "Name";
            cmbIndividualCD.ValueMember = "CostDriverID";
            }   }

         else
            {
                return;
            }
          
        }
        private int CostDriverIDs = 0;
        private void cmbIndividualCD_SelectedValueChanged(object sender, EventArgs e)
        {   
          var EM = cmbIndividualCD.SelectedValue.ToString() ;
            
        }

        private void btnCostDriverRating_Click(object sender, EventArgs e)
        {
            CostDriverRating CDRating = new CostDriverRating()
            {
                Rating = CDRatings.Text,
                EM = Convert.ToDouble(CDEM.Text.Trim()),
                CostDriverID = Convert.ToInt32(cmbIndividualCD.SelectedValue.ToString())
            };
            context.CostDriverRatings.Add(CDRating);
            context.SaveChanges();
        }

      

        private void btnProjecttypes_Click(object sender, EventArgs e)
        {
            SoftwareType sf = new SoftwareType
            {
                Name=cmbProjectType.Text
            };
            context.SoftwareTypes.Add(sf);
            context.SaveChanges();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }
       String ID = "";
        private void cmbConstantProjetcType_SelectedValueChanged(object sender, EventArgs e)
        {
            ID = cmbConstantProjetcType.SelectedValue.ToString();
        }

        private string GetText()
        {
            if(cmbRatingProjectType.SelectedItem.ToString()=="A")
            {
                return "A";
            } 
            else if (cmbRatingProjectType.SelectedItem.ToString() == "B")
            {
                return "B";
            }
            else if (cmbRatingProjectType.SelectedItem.ToString() == "C")
            {
                return "C";
            }
            else if (cmbRatingProjectType.SelectedItem.ToString() == "D")
            {
                return "D";
            }
            return "";
        }
        private void btnProjetcSize_Click(object sender, EventArgs e)
        {


            if(ID==null)
            {
                lblMessage.Text = "Please select Project Type";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                double constType = 0.0;
                if (cmbRatingProjectType.SelectedItem.ToString() == "A")
                {
                   constType=double.Parse(A.Text.Trim());
                }
                else if (cmbRatingProjectType.SelectedItem.ToString() == "B")
                {
                    constType = double.Parse(B.Text.Trim());
                }
                else if (cmbRatingProjectType.SelectedItem.ToString() == "C")
                {
                    constType = double.Parse(C.Text.Trim());
                }
                else if (cmbRatingProjectType.SelectedItem.ToString() == "D")
                {
                    constType = double.Parse(D.Text.Trim());
                }
                SoftwareTypeValue st = new SoftwareTypeValue
            {Name=cmbRatingProjectType.Text,
            ConstantValue=constType,
            SoftwareTypeID=Convert.ToInt32(ID)
             };
            context.SoftwareTypeValues.Add(st);
            context.SaveChanges();
            lblMessage.ForeColor = System.Drawing.Color.Gray;
                lblMessage.Text = "";
            }


        }
    }
}
