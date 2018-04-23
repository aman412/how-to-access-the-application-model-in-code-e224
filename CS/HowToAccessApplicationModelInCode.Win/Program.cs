using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using WinWebSolution.Module;

namespace HowToAccessApplicationModelInCode.Win {
   static class Program {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() {
         EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
         HowToAccessApplicationModelInCodeWindowsFormsApplication application = new HowToAccessApplicationModelInCodeWindowsFormsApplication();
         application.ConnectionString = CodeCentralExampleInMemoryDataStoreProvider.ConnectionString;
         try
         {
            DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.Register();
                        application.ConnectionString = DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.ConnectionString;
            application.Setup();
            application.Start();
         }
         catch (Exception e)
         {
            application.HandleException(e);
         }
      }
   }
}
