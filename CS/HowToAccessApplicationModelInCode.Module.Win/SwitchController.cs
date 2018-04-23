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
            if (((IModelListView)View.Model).MasterDetailMode == 
                MasterDetailMode.ListViewAndDetailView)
                ((IModelListView)View.Model).MasterDetailMode = 
                    DevExpress.ExpressApp.MasterDetailMode.ListViewOnly;
            else
                ((IModelListView)View.Model).MasterDetailMode = 
                    DevExpress.ExpressApp.MasterDetailMode.ListViewAndDetailView;
            View.SetModel(View.Model);
        }
    }
}
