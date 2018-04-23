using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

namespace HowToAccessApplicationModelInCode.Module.Win {
   public partial class SwitchController : ViewController {
      public SwitchController() {
         InitializeComponent();
         RegisterActions(components);
      }

      private void SwitchAction_Execute(object sender, SimpleActionExecuteEventArgs e) {
         //Get the current value of the Views | CurrentObjectType_ ListView node's MasterDetailMode attribute 
         MasterDetailMode mDm = View.Info.GetAttributeEnumValue<MasterDetailMode>(
            "MasterDetailMode", MasterDetailMode.ListViewOnly);
         //Change the MasterDetailMode attribute's value
         if (mDm == DevExpress.ExpressApp.MasterDetailMode.ListViewAndDetailView)
            View.Info.SetAttribute("MasterDetailMode",
               (int)DevExpress.ExpressApp.MasterDetailMode.ListViewOnly);
         else
            View.Info.SetAttribute("MasterDetailMode",
               (int)DevExpress.ExpressApp.MasterDetailMode.ListViewAndDetailView);
         //Update the Views | CurrentObjectType_ ListView node in the Application Model
        View.SynchronizeWithInfo();
      }
   }
}
