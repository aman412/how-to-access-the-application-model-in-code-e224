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
    public partial class SelectViewController : ViewController {
        public SelectViewController() {
            InitializeComponent();
            RegisterActions(components);
        }
        private void SelectViewAction_Execute(object sender, SingleChoiceActionExecuteEventArgs e) {
            View.SetInfo((IModelObjectView)e.SelectedChoiceActionItem.Data);
        }
        protected override void OnActivated() {
            base.OnActivated();
            SelectViewAction.BeginUpdate();
            SelectViewAction.Items.Clear();
            foreach(IModelObjectView node in View.Model.Application.Views.GetNodes<IModelListView>()) {
                if(node.ModelClass == ((IModelObjectView)View.Model).ModelClass) {
                    ChoiceActionItem current = new ChoiceActionItem(node.Id, node);
                    SelectViewAction.Items.Add(current);
                    if (node == View.Model) SelectViewAction.SelectedItem = current;
                }
            }
            SelectViewAction.EndUpdate();
        }
    }
}
