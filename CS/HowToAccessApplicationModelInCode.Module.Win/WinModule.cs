using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace HowToAccessApplicationModelInCode.Module.Win {
   [ToolboxItemFilter("Xaf.Platform.Win")]
   public sealed partial class HowToAccessApplicationModelInCodeWindowsFormsModule : ModuleBase {
      public HowToAccessApplicationModelInCodeWindowsFormsModule() {
         InitializeComponent();
      }
   }
}
