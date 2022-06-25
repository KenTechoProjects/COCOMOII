using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineCount;
namespace COCOMO_II_MODEL_BY__OBILOR.Classes
{
    public class GetFunctionsFromLineCount : MainForm
    {  


        public static double GetAll(MainForm gh)
        {

            var t = gh.GetSum();
            return t;
        }
        public static Dictionary<List<string>, List<double>> MyLIne_Name = new Dictionary<List<string>, List<double>>();
        public static Dictionary<string[], int[]> GetXY(MainForm gh)
        {// MainForm gh = new MainForm();
            Dictionary<string[], int[]> XY = new Dictionary<string[], int[]>();
            XY.Add(gh.Getx(), gh.Gety());
            GetAll(gh);
            return XY;

        }

        public static Dictionary<Dictionary<string[],string>, Dictionary<int[], double>>GetXYZ(MainForm gh)
            {
             // MainForm gh = new MainForm();
              Dictionary<int[], double> ySum = new Dictionary<int[], double>();
              Dictionary<Dictionary<string[], string>, Dictionary<int[],double>> XYZ = new Dictionary<Dictionary<string[], string>, Dictionary<int[],double>>();
              Dictionary<string[], string> XLine = new Dictionary<string[],string>();
              ySum.Add(gh.Gety(), gh.GetSum());
              XLine.Add(gh.Getx(),gh. GetLIneC());
              XYZ.Add(XLine, ySum);
              MyLIne_Name.Add(GetMeNames,GetMeLine );
            return XYZ;
    }
        //public int[] GetY()
        //{ MainForm gh = new MainForm();
        //return    GetY();
        //}
    }
}
