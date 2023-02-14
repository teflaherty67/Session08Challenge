using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session08Challenge
{
    internal static class Utils
    {
        internal static int Method01(int number)
        {
			try
			{
                int result = number / 0;
                return 1;
			}
			catch (Exception ex)
			{
				return 0;
			}
        }

        internal static int Method02()
        {
            try
            {
                string num = "10a";
                int num2 = int.Parse(num);

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        internal static int Method03()
        {
            try
            {
                string[] array = new string[3];
                array[0] = "item 1";
                array[1] = "item 2";
                array[2] = "item 3";
                array[3] = "item 4"; 
                
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        internal static int Method04(Document doc)
        {
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            collector.OfCategory(BuiltInCategory.OST_Walls);

            try
            {
                foreach(Wall curWall in collector)
                    Debug.Print(curWall.Name);

                return collector.Count();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        internal static int Method05()
        {
            string test = "this is some sample text";

            try
            {
                string[] splitArray = test.Split(':');
                Debug.Print(splitArray[1]);

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        internal static int Method06()
        {
            int num1 = 10;
            int num2 = 0;
            int answer;

            try
            {
                answer = num1 / num2;
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}
