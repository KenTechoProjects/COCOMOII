using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
 
 
using Microsoft.VisualBasic;
using System.Collections;
 
using System.Diagnostics;

namespace COCOMO_II_MODEL_BY__OBILOR.Classes
{

    public class DBFrame:DbContext
    {
        public DBFrame( ):base("name=DBFrame") { }

       public virtual DbSet<CostDriver> CostDirers { get; set; }
        public virtual DbSet<CostDriverRating> CostDriverRatings { get; set; }
        public virtual DbSet<ScaleDriver> ScaleDriver { get; set; }
        public virtual DbSet<ScaleDriverRating> ScaleDriverRatings { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<SoftwareType> SoftwareTypes { get; set; }
        public virtual DbSet<SoftwareTypeValue> SoftwareTypeValues { get; set; }
    }

 public   class FunctionPoint
    {
        public int FileTypeReferenced0_1;//1-5=low,6-19=low, 20+=Average
               public int FileTypeReferenced2_3_;//1-5=low,6-19=Av,20+=High
        public int FileTypeReferenced4_Above;//1-5=Av 6-19=High, 20+=High

        public int ExternalInput;//x3=low,x4=Av,x6=High
        public int ExtOutput;//x4=low,x5=Av,x7=High
        public int logicalInternalFile;//x7=low,x10=Av,x15=High
        public int ExtInterfaceFile;// x5=low,x7=Av,x10=High
        public int ExtInquiry;//x=low,x4=Av,x6=High

        public double CodeSize;
        public double AVC;
        public int NoOfFunctionPoint;

        // Draws a pie chart.
        public void DrawPieChart(int[] myPiePerecents, Color[] myPieColors, Graphics myPieGraphic, Point myPieLocation, Size myPieSize)
        {
            //Check if sections add up to 100.
            int sum = 0;
            foreach (int percent_loopVariable in myPiePerecents)
            {
                sum += percent_loopVariable;
            }

            if (sum != 100)
            {
                MessageBox.Show("Sum Do Not Add Up To 100.");
            }

            //Check Here Number Of Values & Colors Are Same Or Not.They Must Be Same.
            if (myPiePerecents.Length != myPieColors.Length)
            {
                MessageBox.Show("There Must Be The Same Number Of Percents And Colors.");
            }

            int PiePercentTotal = 0;
            for (int PiePercents = 0; PiePercents < myPiePerecents.Length; PiePercents++)
            {
                using (SolidBrush brush = new SolidBrush(myPieColors[PiePercents]))
                {

                    //Here it Will Convert Each Value Into 360, So Total Into 360 & Then It Will Draw A Full Pie Chart.
                    myPieGraphic.FillPie(brush, new Rectangle(new Point(10, 10), myPieSize), Convert.ToSingle(PiePercentTotal * 360 / 100), Convert.ToSingle(myPiePerecents[PiePercents] * 360 / 100));
                }

                PiePercentTotal += myPiePerecents[PiePercents];
            }
            return;
        }
        public void DrawPieChartOnForm()
        {
            //Take Total Five Values & Draw Chart Of These Values.
            int[] myPiePercent = { 10, 20, 25, 5, 40 };

            //Take Colors To Display Pie In That Colors Of Taken Five Values.
            Color[] myPieColors = { Color.Red, Color.Black, Color.Blue, Color.Green, Color.Maroon };

            using (Graphics myPieGraphic = this.CreateGraphics())
            {
                //Give Location Which Will Display Chart At That Location.
                Point myPieLocation = new Point(10, 10);

                //Set Here Size Of The ChartÃ¢â‚¬Â¦
                Size myPieSize = new Size(150, 150);

                //Call Function Which Will Draw Pie of Values.
                DrawPieChart(myPiePercent, myPieColors, myPieGraphic, myPieLocation, myPieSize);
            }
        }

        private Graphics CreateGraphics()
        {
            throw new NotImplementedException();
        }
    }

    public class CostDriver
    {
        public int CostDriverID { get; set; }
        public string Name { get; set; }
        public List<CostDriverRating> CostDriverRatings { get; set; }

        //       private string _ratingLevel;
        //       private double _em;
        //       public CostDriver(string ratingLevel,double em)
        //       {
        //           _ratingLevel = ratingLevel;
        //           _em = em;
        //       }
        //       public string RatingLeve { get { return _ratingLevel; }
        //           set { _ratingLevel = value; }
        //       }

        //public double EM { get { return _em; }
        //           set { _em = value; }
        //       }
        //public override string ToString()
        //{
        //    return _ratingLevel;
        //}
    }
 public class CostDriverRating
    {
public int CostDriverRatingID { get; set; }
       
        public  string Rating { get; set; }
        public   double EM { get; set; }
        public int CostDriverID { get; set; }
         public CostDriver  CostDriver { get; set; }
    }
    public class ScaleDriver
    {
public int ScaleDriverID { get; set; }
        public string Name { get; set; }
         public List<ScaleDriverRating> ScaleDriverRatings { get; set; }
    }
    public class ScaleDriverRating
    {
public int  ScaleDriverRatingID { get; set; }
       
        public double Value { get; set; }
        public string Rating { get; set; }
        public int ScaleDriverID { get; set; }
        public ScaleDriver  ScaleDriver { get; set; }
         
    }
    public class Project
    {
        public string ProjectID { get; set; }
        public string ProjectName { get; set; }
        public long LOC { get; set; }
        public double E { get; set; }
        public double Effort { get; set; }
        public double EAF { get; set; }
        public double PM { get; set; }
        public double Duration { get; set; }
        public double AverageStaffing { get; set; }
        public double Cost { get; set; }
    }
    public class ProjectListView
    {
        List<Project> Projects { get; set; }
    }

    public class Constants
    {
        public static double B = 0.92;
        public static double A = 2.94;
        public static double D = 3.67;

    }

    public class SoftwareType
    {
        public int SoftwareTypeID { get; set; }
        public string Name { get; set; }
    }
    public class SoftwareTypeValue
    {
        public int SoftwareTypeValueID { get; set; }
        public string Name { get; set; }
        public double ConstantValue { get; set; }
        public int SoftwareTypeID { get; set; }
        public SoftwareType SoftwareType { get; set; }
    }

    public class GetLOC
    {
        public int CountNumberOfLinesInCSFilesOfDirectory(string dirPath)
        {
            FileInfo[] csFiles = new DirectoryInfo(dirPath.Trim())
                                        .GetFiles("*.cs", SearchOption.AllDirectories);

            int totalNumberOfLines = 0;
            Parallel.ForEach(csFiles, fo =>
            {
                Interlocked.Add(ref totalNumberOfLines, CountNumberOfLine(fo));
            });
            return totalNumberOfLines;
        }

      public  int CountNumberOfLine(Object tc)
        {
            FileInfo fo = (FileInfo)tc;
            int count = 0;
            int inComment = 0;
            using (StreamReader sr = fo.OpenText())
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (IsRealCode(line.Trim(), ref inComment))
                        count++;
                }
            }
            return count;
        }

        private bool IsRealCode(string trimmed, ref int inComment)
        {
            if (trimmed.StartsWith("/*") && trimmed.EndsWith("*/"))
                return false;
            else if (trimmed.StartsWith("/*"))
            {
                inComment++;
                return false;
            }
            else if (trimmed.EndsWith("*/"))
            {
                inComment--;
                return false;
            }

            return
                   inComment == 0
                && !trimmed.StartsWith("//")
                && (trimmed.StartsWith("if")
                    || trimmed.StartsWith("else if")
                    || trimmed.StartsWith("using (")
                    || trimmed.StartsWith("else  if")
                    || trimmed.Contains(";")
                    || trimmed.StartsWith("public") //method signature
                    || trimmed.StartsWith("private") //method signature
                    || trimmed.StartsWith("protected") //method signature
                    );
        }
    }
}
