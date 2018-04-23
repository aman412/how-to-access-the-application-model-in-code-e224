namespace HowToAccessApplicationModelInCode.Module.Win {
    partial class SelectViewController {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.SelectViewAction = new DevExpress.ExpressApp.Actions.SingleChoiceAction(this.components);
            // 
            // SelectViewAction
            // 
            this.SelectViewAction.Caption = "Select View Action";
            this.SelectViewAction.Id = "SelectViewAction";
            this.SelectViewAction.Tag = null;
            this.SelectViewAction.Execute += new DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(this.SelectViewAction_Execute);
            // 
            // SelectViewController
            // 
            this.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
        }

        #endregion

        private DevExpress.ExpressApp.Actions.SingleChoiceAction SelectViewAction;
    }
}
