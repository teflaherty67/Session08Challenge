#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

#endregion

namespace Session08Challenge
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            int counter = 0;

            counter += Utils.Method01(0);

            counter += Utils.Method02();

            counter += Utils.Method03();

            counter += Utils.Method04(doc);

            counter += Utils.Method05();

            counter += Utils.Method06();

            if (counter == 6)
                TaskDialog.Show("Complete", "Congratulations! You solved the challenge!");
            else
                TaskDialog.Show("Error", "Hmmm. . . there's an error in the code. Can you find it?");
            
            return Result.Succeeded;
        }
    }
}
