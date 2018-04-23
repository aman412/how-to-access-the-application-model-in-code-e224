namespace HowToAccessApplicationModelInCode.Module.Win {
   partial class SwitchController {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null))
         {
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
         this.SwitchAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
         // 
         // SwitchAction
         // 
         this.SwitchAction.Caption = "Switch";
         this.SwitchAction.Id = "SwitchAction";
         this.SwitchAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.SwitchAction_Execute);
         // 
         // SwitchController
         // 
         this.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;

      }

      #endregion

      private DevExpress.ExpressApp.Actions.SimpleAction SwitchAction;
   }
}
