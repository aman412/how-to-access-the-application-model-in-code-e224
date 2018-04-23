using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Model;

namespace HowToAccessApplicationModelInCode.Module.Win {
    public partial class SwitchController : ViewController {
        public SwitchController() {
            InitializeComponent();
            RegisterActions(components);
        }
       private void SwitchAction_Execute(object sender, SimpleActionExecuteEventArgs e) {
            IModelListView model = ((ListView)View).Model;
            ViewShortcut shortcut = Frame.View.CreateShortcut();
            Frame.SetView(null);
            if (model.MasterDetailMode == MasterDetailMode.ListViewAndDetailView) {
                model.MasterDetailMode = MasterDetailMode.ListViewOnly;
            }
            else {
                model.MasterDetailMode = MasterDetailMode.ListViewAndDetailView;
            }
            Frame.SetView(Application.ProcessShortcut(shortcut), true, Frame);
        }
    }
}
