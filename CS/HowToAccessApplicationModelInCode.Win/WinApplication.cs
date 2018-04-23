using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;

namespace HowToAccessApplicationModelInCode.Win {
   public partial class HowToAccessApplicationModelInCodeWindowsFormsApplication : WinApplication {
      public HowToAccessApplicationModelInCodeWindowsFormsApplication() {
         InitializeComponent();
      }

      private void HowToAccessApplicationModelInCodeWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
          e.Updater.Update();
          e.Handled = true;
      }
   }
}
