using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
 using LineCount;
using DevExpress.XtraBars;
using COCOMO_II_MODEL_BY__OBILOR.Classes;
using System.Windows.Forms.DataVisualization.Charting;
 using LineCount.CodeContainers;
//using UnityEngine;
using System.Collections;

namespace COCOMO_II_MODEL_BY__OBILOR
{
    public partial class MainFace : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string ty = "";
        private DBFrame context;
        public MainFace()
        {
 
            InitializeComponent();
            lblKnobValueChangeDisplay.Text = knobControl1.Value.ToString();
            context = new DBFrame();
        }
   double GetSum =0.0;
       
        private void PopuatePieChat(MainForm mainForm)
        {
            var x = context.CostDriverRatings.Where(p => p.Rating =="Norminal").Select(p=>p.Rating).OrderByDescending(p=>p).ToList().ToArray<string>();
            var y = context.CostDriverRatings.Where(p => p.Rating =="Norminal").Select(p => p.EM).OrderByDescending(p=>p).ToList().ToArray<double>();
    Dictionary<int[], double> YZ = new Dictionary<int[], double>();
    Dictionary<string[], string>XLine = new Dictionary<string[], string>();
            List<string> xxx = new List<string>();
            List<int> yyy = new List<int>();
            GetFunctionsFromLineCount ko = new GetFunctionsFromLineCount();
            ko.GetAllIndividualLInes();
            string LC = "";
            var XY = GetFunctionsFromLineCount .GetXYZ(mainForm);
            foreach(var op in XY)
            {
                foreach(var o in op.Key)
                {
                    XLine.Add(o.Key,o.Value);
                }
                foreach( var p in op.Value)
                {
                    YZ.Add(p.Key,p.Value);
                }
               
            }
            foreach(var o in XLine)
            {
              foreach(var p in o.Key)
                {
                    xxx.Add(p);
                }
                LC = o.Value;
            }
           // lblLineOC.Text = LC;
            txtShowLOCResult.Caption = LC;
            
           // lblLineOC.AutoSize = true;

            foreach (var o in YZ)
                {

                foreach( var p in o.Key)
                {
  yyy.Add(p);
                }
                GetSum = o.Value;

                }
         
            var tx = xxx.ToArray();
            var ty = yyy.ToArray();
            chart1.Series[0].ChartType = SeriesChartType.Funnel;
            chart1.Series[0].Points.DataBindXY(tx, ty);
            chart1.Legends[0].Enabled = true;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            txtKSLOCs.Caption ="SLOC: "+ GetSum.ToString()+ "  KSLOC: "+(GetSum/1000).ToString();
       var lIneName=     GetFunctionsFromLineCount.MyLIne_Name;
            var CodeLines =new List<double>();
            var CodeName = new List<string>();
            foreach(var pp in lIneName)
            {
                 chart2.Series["Result"].ChartType = SeriesChartType.Doughnut;
            chart2.Series["Result"].Points.DataBindXY(pp.Key.ToArray(), pp.Value.ToArray());
            chart2.Legends[0].Enabled = true;
            chart2.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
 
        }
        private void knobControl1_ValueChanged(object Sender)
        {

           lblKnobValueChangeDisplay.Text = knobControl1.Value.ToString();
        }

        private void MainFace_Load(object sender, EventArgs e)
        {
           
            // txtKSLOCs.Caption = ty;
            FeedCharts();
            LoadCostDriverRatings();
            LoadProjectType();
            Execute();
          

        }
        public void Execute()
        { var KSLOC = 0.0d;
            var EAF = 0.0d;
            var EFFORT = 0.0d;
            var DURATION = 0.0D;
           
            var AvERAGE_STAFFING = 0.0D;
        
         KSLOC=Math.Round(GetSum / 1000,5,MidpointRounding.AwayFromZero);
        EFFORT =Math.Round((2.94 *GetEAFValue()* Math.Pow(KSLOC,1.0997)),5,MidpointRounding.AwayFromZero); // GetE()
            DURATION =Math.Round(3.67 * Math.Pow((KSLOC), 1.0997),5,MidpointRounding.AwayFromZero);//GetE()
            AvERAGE_STAFFING =Math.Round(EFFORT / DURATION,5,MidpointRounding.AwayFromZero);
          TextPM.Caption= EFFORT.ToString();
            textEAF.Caption = GetEAFValue().ToString();
            TextAverageStaff.Caption = AvERAGE_STAFFING.ToString();
 //this.chart2.Series["Result"].Points.AddXY("EAF", GetEAFValue());
 //           this.chart2.Series["Result"].Points.AddXY("KSLOC", KSLOC);
 //           this.chart2.Series["Result"].Points.AddXY("PM", EFFORT);
 //           this.chart2.Series["Result"].Points.AddXY("Duration", GetEAFValue());
        }


        //Effort = 2.94 * EAF* (KSLOC) E: Duration = 3.67 * (Effort)SE:Average staffing=Effort/Duration
        /*SCED:To show that a project developed on accelerated schedule will cost more effort than a project developed on
        its optimuim schedule Duration = 75% * 12.1 Months = 9.1 Months*/
        public void LoadProjectType()
        {
            int A1, B1, C1, D1;
            A1 = context.SoftwareTypes.Where(p => p.Name == "Organic").Select(p => p.SoftwareTypeID).FirstOrDefault();
            B1 = context.SoftwareTypes.Where(p => p.Name == "Semi-Detatched").Select(p => p.SoftwareTypeID).FirstOrDefault();
            C1 = context.SoftwareTypes.Where(p => p.Name == "Embedded").Select(p => p.SoftwareTypeID).FirstOrDefault();
             
            var a = context.SoftwareTypeValues.Where(p => p.SoftwareTypeID == A1).ToList();
            var b = context.SoftwareTypeValues.Where(p => p.SoftwareTypeID == B1).ToList();
            var c = context.SoftwareTypeValues.Where(p => p.SoftwareTypeID == C1).ToList();
  

            foreach (var op in a)
            {
                A.DataSource = a;
                A.DisplayMember = "Name";
                A.ValueMember = "ConstantValue";
                

            }

            foreach (var op in b)
            {
               B.DataSource = b;
                B.DisplayMember = "Name";
               B.ValueMember = "ConstantValue";
                

            }
            foreach (var op in c)
            {
                C.DataSource = c;
                C.DisplayMember = "Name";
                C.ValueMember = "ConstantValue";


            }
         
        }

        private void LoadCostDriverRatings()
        {

            // Dictionary<string,double> cost = new Dictionary<string,double>();
            int RELLY1, DATA1, RUSE1, DOCU1, TIME1, STOR1, PVOL1, ACAP1, PCAP1, PCON1, APEX1, PLEX1, LTEX1, TOOL1, SITE1, SCED1, CPLX1;


            var ProjectSize = context.SoftwareTypeValues.Where(p => p.SoftwareTypeID == 1).ToList();

            RELLY1 = context.CostDirers.Where(p => p.Name == "RELLY").Select(p => p.CostDriverID).FirstOrDefault();
            DATA1 = context.CostDirers.Where(p => p.Name == "DATA").Select(p => p.CostDriverID).FirstOrDefault();
            RUSE1 = context.CostDirers.Where(p => p.Name == "RUSE").Select(p => p.CostDriverID).FirstOrDefault();
            DOCU1 = context.CostDirers.Where(p => p.Name == "DOCU").Select(p => p.CostDriverID).FirstOrDefault();
            TIME1 = context.CostDirers.Where(p => p.Name == "TIME").Select(p => p.CostDriverID).FirstOrDefault();
            STOR1 = context.CostDirers.Where(p => p.Name == "STOR").Select(p => p.CostDriverID).FirstOrDefault();
            APEX1 = context.CostDirers.Where(p => p.Name == "APEX").Select(p => p.CostDriverID).FirstOrDefault();
            PVOL1 = context.CostDirers.Where(p => p.Name == "PVOL").Select(p => p.CostDriverID).FirstOrDefault();
            ACAP1 = context.CostDirers.Where(p => p.Name == "ACAP").Select(p => p.CostDriverID).FirstOrDefault();
            PCAP1 = context.CostDirers.Where(p => p.Name == "PCAP").Select(p => p.CostDriverID).FirstOrDefault();
            PCON1 = context.CostDirers.Where(p => p.Name == "APEX").Select(p => p.CostDriverID).FirstOrDefault();
            PLEX1 = context.CostDirers.Where(p => p.Name == "PLEX").Select(p => p.CostDriverID).FirstOrDefault();
            LTEX1 = context.CostDirers.Where(p => p.Name == "LTEX").Select(p => p.CostDriverID).FirstOrDefault();
            TOOL1 = context.CostDirers.Where(p => p.Name == "TOOL").Select(p => p.CostDriverID).FirstOrDefault();
            SITE1 = context.CostDirers.Where(p => p.Name == "SITE").Select(p => p.CostDriverID).FirstOrDefault();
            SCED1 = context.CostDirers.Where(p => p.Name == "SCED").Select(p => p.CostDriverID).FirstOrDefault();
            CPLX1 = context.CostDirers.Where(p => p.Name == "CPLX").Select(p => p.CostDriverID).FirstOrDefault();

            var re = context.CostDriverRatings.Where(p => p.CostDriverID == RELLY1).ToList();
            foreach (var h in re)
            {
                RELLY.DataSource = re;
                RELLY.DisplayMember = "Rating";
                RELLY.ValueMember = "EM";
            }

            var dat = context.CostDriverRatings.Where(p => p.CostDriverID == DATA1).ToList();


            foreach (var op in dat)
            {
                DATA.DataSource = dat;
                DATA.DisplayMember = "Rating";
                DATA.ValueMember = "EM";
            }
            var ru = context.CostDriverRatings.Where(p => p.CostDriverID == RUSE1).ToList();
            foreach (var op in ru)
            {
                RUSE.DataSource = ru;

                RUSE.DisplayMember = "Rating";
                RUSE.ValueMember = "EM";

            }
            var du = context.CostDriverRatings.Where(p => p.CostDriverID == DOCU1).ToList();
            foreach (var op in du)
            {
                DOCU.DataSource = du;

                DOCU.DisplayMember = "Rating";
                DOCU.ValueMember = "EM";

            }
            var TI = context.CostDriverRatings.Where(p => p.CostDriverID == TIME1).ToList();
            foreach (var op in TI)
            {
                TIME.DataSource = TI;

                TIME.DisplayMember = "Rating";
                TIME.ValueMember = "EM";

            }
            var ST = context.CostDriverRatings.Where(p => p.CostDriverID == STOR1).ToList();
            foreach (var op in ST)
            {
                STOR.DataSource = ST;

                STOR.DisplayMember = "Rating";
                STOR.ValueMember = "EM";

            }

            var PV = context.CostDriverRatings.Where(p => p.CostDriverID == PVOL1).ToList();
            foreach (var op in PV)
            {
                PVOL.DataSource = PV;

                PVOL.DisplayMember = "Rating";
                PVOL.ValueMember = "EM";

            }
            var AC = context.CostDriverRatings.Where(p => p.CostDriverID == ACAP1).ToList();
            foreach (var op in AC)
            {
                ACAP.DataSource = AC;

                ACAP.DisplayMember = "Rating";
                ACAP.ValueMember = "EM";

            }
            var PC = context.CostDriverRatings.Where(p => p.CostDriverID == PCAP1).ToList();
            foreach (var op in PC)
            {
                PCAP.DataSource = PC;

                PCAP.DisplayMember = "Rating";
                PCAP.ValueMember = "EM";

            }
            var PN = context.CostDriverRatings.Where(p => p.CostDriverID == PCON1).ToList();
            foreach (var op in PN)
            {
                PCON.DataSource = PN;

                PCON.DisplayMember = "Rating";
                PCON.ValueMember = "EM";

            }
            var AP = context.CostDriverRatings.Where(p => p.CostDriverID == APEX1).ToList();
            foreach (var op in AP)
            {
                APEX.DataSource = AP;

                APEX.DisplayMember = "Rating";
                APEX.ValueMember = "EM";

            }
            var PL = context.CostDriverRatings.Where(p => p.CostDriverID == PLEX1).ToList();
            foreach (var op in PL)
            {
                PLEX.DataSource = PL;

                PLEX.DisplayMember = "Rating";
                PLEX.ValueMember = "EM";

            }
            var LT = context.CostDriverRatings.Where(p => p.CostDriverID == LTEX1).ToList();
            foreach (var op in LT)
            {
                LTEX.DataSource = LT;

                LTEX.DisplayMember = "Rating";
                LTEX.ValueMember = "EM";

            }
            var TO = context.CostDriverRatings.Where(p => p.CostDriverID == TOOL1).ToList();
            foreach (var op in TO)
            {
                TOOL.DataSource = TO;

                TOOL.DisplayMember = "Rating";
                TOOL.ValueMember = "EM";

            }
            var EI = context.CostDriverRatings.Where(p => p.CostDriverID == SITE1).ToList();
            foreach (var op in EI)
            {
                SITE.DataSource = EI;

                SITE.DisplayMember = "Rating";
                SITE.ValueMember = "EM";

            }
            var SC = context.CostDriverRatings.Where(p => p.CostDriverID == SCED1).ToList();
            foreach (var op in SC)
            {
                SCED.DataSource = SC;

                SCED.DisplayMember = "Rating";
                SCED.ValueMember = "EM";

            }
            var CP = context.CostDriverRatings.Where(p => p.CostDriverID == CPLX1).ToList();
            foreach (var op in CP)
            {
                CPLX.DataSource = CP;

                CPLX.DisplayMember = "Rating";
                CPLX.ValueMember = "EM";

            }
        }

        private void RELLY_SelectedValueChanged(object sender, EventArgs e)
        {
            //lblKnobValueChangeDisplay.Text = RELLY.SelectedValue.ToString();
        }

        private void barStaticItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            barStaticItem14.Caption = "Platform Volatility";
        }
        private void PopuatePieChats(  MainForm mainForm)
        {
            var x = context.CostDriverRatings.Where(p => p.Rating == "Norminal").Select(p => p.Rating).OrderByDescending(p => p).ToList().ToArray<string>();
            var y = context.CostDriverRatings.Where(p => p.Rating == "Norminal").Select(p => p.EM).OrderByDescending(p => p).ToList().ToArray<double>();
            Dictionary<int[], double> YZ = new Dictionary<int[], double>();
            Dictionary<string[], string> XLine = new Dictionary<string[], string>();
            List<string> xxx = new List<string>();
            List<int> yyy = new List<int>();
            GetFunctionsFromLineCount ko = new GetFunctionsFromLineCount();
            ko.GetAllIndividualLInes();
            string LC = "";
            var XY = GetFunctionsFromLineCount.GetXYZ(mainForm);
            foreach (var op in XY)
            {
                foreach (var o in op.Key)
                {
                    XLine.Add(o.Key, o.Value);
                }
                foreach (var p in op.Value)
                {
                    YZ.Add(p.Key, p.Value);
                }

            }
            foreach (var o in XLine)
            {
                foreach (var p in o.Key)
                {
                    xxx.Add(p);
                }
                LC = o.Value;
            }
           // lblLineOC.Text = LC;
            txtShowLOCResult.Caption = LC;

           // lblLineOC.AutoSize = true;

            foreach (var o in YZ)
            {

                foreach (var p in o.Key)
                {
                    yyy.Add(p);
                }
                GetSum = o.Value;

            }

            var tx = xxx.ToArray();
            var ty = yyy.ToArray();
            chart1.Series[0].ChartType = SeriesChartType.Funnel;
            chart1.Series[0].Points.DataBindXY(tx, ty);
            chart1.Legends[0].Enabled = true;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            txtKSLOCs.Caption = "SLOC: " + GetSum.ToString() + "  KSLOC: " + (GetSum / 1000).ToString();
            var lIneName = GetFunctionsFromLineCount.MyLIne_Name;
            var CodeLines = new List<double>();
            var CodeName = new List<string>();
            foreach (var pp in lIneName)
            {
                chart2.Series["Result"].ChartType = SeriesChartType.Doughnut;
                chart2.Series["Result"].Points.DataBindXY(pp.Key.ToArray(), pp.Value.ToArray());
                chart2.Legends[0].Enabled = true;
                chart2.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            mainForm.Dispose();
        }
        private void btnLOC_ItemClick(object sender, ItemClickEventArgs e)
        {
            FeedChart();

        }

        private void FeedCharts()
        {
            MainForm gh = new MainForm();

            
            Dictionary<int[], double> ySum = new Dictionary<int[], double>();
            Dictionary<string[], string> XLine = new Dictionary<string[], string>();
          //  Dictionary<Dictionary<string[], string>, Dictionary<int[], double>> XYZ = new Dictionary<Dictionary<string[], string>, Dictionary<int[], double>>();


           
            List<string> xxx = new List<string>();
            List<int> yyy = new List<int>();
             
          //  ySum.Add(gh.Gety(), gh.GetSum());
            XLine.Add(gh.Getx(), gh.GetLIneC());
            //XYZ.Add(XLine, ySum);
            string LC = "";
            //foreach (var op in XYZ)
            //{
            //    foreach (var o in op.Key)
            //    {
            //        XLine.Add(o.Key, o.Value);
            //    }
            //    foreach (var p in op.Value)
            //    {
            //        YZ.Add(p.Key, p.Value);
            //    }

            //}
            foreach (var o in XLine)
            {
                foreach (var p in o.Key)
                {
                    xxx.Add(p);
                }
                LC = o.Value;

                foreach (var p in gh.Gety())
                {
                    yyy.Add(p);
                }

            }
          //  lblLineOC.Text = LC;
            txtShowLOCResult.Caption = LC;

           // lblLineOC.AutoSize = true;


            GetSum = gh.GetSum();



            var tx = xxx.ToArray();
            var ty = yyy.ToArray();
            chart1.Series[0].ChartType = SeriesChartType.Funnel;
            chart1.Series[0].Points.DataBindXY(tx, ty);
            chart1.Legends[0].Enabled = true;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            txtKSLOCs.Caption = "SLOC: " + GetSum.ToString() + "  KSLOC: " + (GetSum / 1000).ToString();
          //  gh.GetAllIndividualLInes();
            
            var CodeLines = new List<double>();
            var CodeName = new List<string>();
         var lIneName =  gh.GetAllIndividualLInes();
            foreach (var pp in lIneName)
            {
                chart2.Series["Result"].ChartType = SeriesChartType.Doughnut;
                chart2.Series["Result"].Points.DataBindXY(pp.Key.ToArray(), pp.Value.ToArray());
                chart2.Legends[0].Enabled = true;
                chart2.ChartAreas[0].Area3DStyle.Enable3D = true;
            }

      
        }
        private void FeedChart()
        {
            MainForm gh = new MainForm();

            Dictionary<List<string>, List<double>> MyLIne_Name = new Dictionary<List<string>, List<double>>();
            Dictionary<int[], double> ySum = new Dictionary<int[], double>();
            Dictionary<string[], string> XLine = new Dictionary<string[], string>();
            Dictionary<Dictionary<string[], string>, Dictionary<int[], double>> XYZ = new Dictionary<Dictionary<string[], string>, Dictionary<int[], double>>();


            Dictionary<int[], double> YZ = new Dictionary<int[], double>();
            List<string> xxx = new List<string>();
            List<int> yyy = new List<int>();
            List<int[]> m = new List<int[]>();
            ySum.Add(gh.Gety(), gh.GetSum());
            XLine.Add(gh.Getx(), gh.GetLIneC());
            XYZ.Add(XLine, ySum);
            string LC = "";
            //foreach (var op in XYZ)
            //{
            //    foreach (var o in op.Key)
            //    {
            //        XLine.Add(o.Key, o.Value);
            //    }
            //    foreach (var p in op.Value)
            //    {
            //        YZ.Add(p.Key, p.Value);
            //    }

            //}
            foreach (var o in XLine)
            {
                foreach (var p in o.Key)
                {
                    xxx.Add(p);
                }
                LC = o.Value;

                foreach( var p in gh.Gety())
                {
          yyy.Add(p);
                }
                 
            }
           // lblLineOC.Text = LC;
            txtShowLOCResult.Caption = LC;

          //  lblLineOC.AutoSize = true;

            
                GetSum = gh.GetSum();

           

            var tx = xxx.ToArray();
            var ty = yyy.ToArray();
            chart1.Series[0].ChartType = SeriesChartType.Funnel;
            chart1.Series[0].Points.DataBindXY(tx, ty);
            chart1.Legends[0].Enabled = true;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            txtKSLOCs.Caption = "SLOC: " + GetSum.ToString() + "  KSLOC: " + (GetSum / 1000).ToString();


            var lIneName = gh.GetAllIndividualLInes();
       
            var CodeLines = new List<double>();
            var CodeName = new List<string>();
            foreach (var pp in lIneName)
            {
                chart2.Series["Result"].ChartType = SeriesChartType.Doughnut;
                chart2.Series["Result"].Points.DataBindXY(pp.Key.ToArray(), pp.Value.ToArray());
                chart2.Legends[0].Enabled = true;
                chart2.ChartAreas[0].Area3DStyle.Enable3D = true;
            }

            gh.Show();
        }

        private void createEquationFactorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();

            fm.Show();
        }

        private void RELLY__SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void RELLY__ValueMemberChanged(object sender, EventArgs e)
        {
            // lblKnobValueChangeDisplay.Text = RELLY.SelectedValue.ToString();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCostDriverRatings();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //foreach (Control gb in this.Controls)
            //{
            //    if (gb is GroupBox)
            //    {
            //        foreach (ComboBox combobox in gb.Controls)
            //        {
            //            if (combobox is ComboBox)
            //            {
            //                //here is where you access all the textboxs.

            //                if (Convert.ToDouble(combobox.SelectedValue.ToString()) != 0.0 || Convert.ToDouble(combobox.SelectedValue.ToString()) != 0)
            //                {
            //                    EAF += Convert.ToDouble(combobox.SelectedValue.ToString());
            //                }
            //            }
            //        }
            //    }
            //}
            //foreach (var groupBox in Controls.OfType<GroupBox>())
            //{
            //    foreach (var textBox in groupBox.Controls.OfType<TextBox>())
            //    {
            //        // Do Something
            //    }
            //}

            //           foreach (var combobox in Controls.OfType<GroupBox>().SelectMany(groupBox => groupBox.Controls.OfType<ComboBox>()))
            //           {

            //             

            //           }
            //foreach (Control c in ctrl.Controls)
            //{
            //    // This foreach loop will enable all the controls within groupbox
            //    c.Enabled = true;
            //}
            GetEAFValue();
        }
        public  double GetE()
        {
            
            double i = 1;

            i += Convert.ToDouble(PREC.SelectedValue.ToString())
            + Convert.ToDouble(FLEX.SelectedValue.ToString())
        + Convert.ToDouble(RESL.SelectedValue.ToString())
        + +Convert.ToDouble(TEAM.SelectedValue.ToString())
        + +Convert.ToDouble(PMAT.SelectedValue.ToString());
            return i;

        }
        private double GetEAFValue()
        {
            var EAF = 0.0d;
            double i = 1;
            if (Convert.ToDouble(RELLY.SelectedValue.ToString()) != 0.0)
            {
                i = i * Convert.ToDouble(RELLY.SelectedValue.ToString());
            }
            if (Convert.ToDouble(DATA.SelectedValue.ToString()) != 0.0)
            {
                i *= Convert.ToDouble(DATA.SelectedValue.ToString());
            }
            if (Convert.ToDouble(RUSE.SelectedValue.ToString()) != 0.0)
            {
                i *= Convert.ToDouble(RUSE.SelectedValue.ToString());
            }
            if (Convert.ToDouble(DOCU.SelectedValue.ToString()) != 0.0)
            {
                i *= Convert.ToDouble(DOCU.SelectedValue.ToString());
            }
            if (Convert.ToDouble(TIME.SelectedValue.ToString()) != 0.0)
            {
                i *= Convert.ToDouble(TIME.SelectedValue.ToString());
            }
            if (Convert.ToDouble(STOR.SelectedValue.ToString()) != 0.0)
            {
                i *= Convert.ToDouble(STOR.SelectedValue.ToString());
            }
            if (Convert.ToDouble(PVOL.SelectedValue.ToString()) != 0.0)
            {
                i *= Convert.ToDouble(PVOL.SelectedValue.ToString());
            }
            if (Convert.ToDouble(ACAP.SelectedValue.ToString()) != 0.0)
            {
                i *= Convert.ToDouble(ACAP.SelectedValue.ToString());
            }
            if (Convert.ToDouble(DATA.SelectedValue.ToString()) != 0.0)
            {
                i *= Convert.ToDouble(DATA.SelectedValue.ToString());
            }
            if (Convert.ToDouble(PCON.SelectedValue.ToString()) != 0.0)
            { i *= Convert.ToDouble(PCON.SelectedValue.ToString()); }
            if (Convert.ToDouble(APEX.SelectedValue.ToString()) != 0.0)
            {
                i *= Convert.ToDouble(APEX.SelectedValue.ToString());
            }
            if (Convert.ToDouble(LTEX.SelectedValue.ToString()) != 0.0)
            {
                i *= Convert.ToDouble(LTEX.SelectedValue.ToString());
            }
            if (Convert.ToDouble(TOOL.SelectedValue.ToString()) != 0.0)
            { i *= Convert.ToDouble(TOOL.SelectedValue.ToString()); }
            if (Convert.ToDouble(SITE.SelectedValue.ToString()) != 0.0)
            { i *= Convert.ToDouble(SITE.SelectedValue.ToString()); }
            if (Convert.ToDouble(SCED.SelectedValue.ToString()) != 0.0)
            { i *= Convert.ToDouble(SCED.SelectedValue.ToString()); }
            if (Convert.ToDouble(CPLX.SelectedValue.ToString()) != 0.0)
            { i *= Convert.ToDouble(CPLX.SelectedValue.ToString()); }

            EAF = Math.Round(i, 5, MidpointRounding.AwayFromZero);
            TextDuration.Caption = EAF.ToString();
            return EAF;
        }

        private void knobControl1_Load(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}