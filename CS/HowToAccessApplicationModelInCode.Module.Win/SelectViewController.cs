using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

namespace HowToAccessApplicationModelInCode.Module.Win {
    public partial class SelectViewController : ViewController {
        public SelectViewController() {
            InitializeComponent();
            RegisterActions(components);
        }

        private void SelectViewAction_Execute(object sender, SingleChoiceActionExecuteEventArgs e) {
            View.SetInfo((DictionaryNode)e.SelectedChoiceActionItem.Data);
        }
        protected override void OnActivated() {
            base.OnActivated();
            SelectViewAction.BeginUpdate();
            SelectViewAction.Items.Clear();
            DictionaryNode node = Application.Model.RootNode.GetChildNode("Views");
            foreach(DictionaryNode dnode in node.GetChildNodes("ListView", "ClassName",
                  View.ObjectTypeInfo.Type.FullName, false)) {
                ChoiceActionItem current = new ChoiceActionItem(dnode.GetAttributeValue("ID"), dnode);
                SelectViewAction.Items.Add(current);
                if(dnode == View.Info) {
                    SelectViewAction.SelectedItem = current;
                }
            }
            SelectViewAction.EndUpdate();
        }

    }
}
