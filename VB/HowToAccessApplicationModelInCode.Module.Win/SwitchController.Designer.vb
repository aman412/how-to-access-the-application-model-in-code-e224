Imports Microsoft.VisualBasic
Imports System
Namespace HowToAccessApplicationModelInCode.Module.Win
   Partial Public Class SwitchController
	  ''' <summary>
	  ''' Required designer variable.
	  ''' </summary>
	  Private components As System.ComponentModel.IContainer = Nothing

	  ''' <summary> 
	  ''' Clean up any resources being used.
	  ''' </summary>
	  ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		 If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		 End If
		 MyBase.Dispose(disposing)
	  End Sub

	  #Region "Component Designer generated code"

	  ''' <summary>
	  ''' Required method for Designer support - do not modify
	  ''' the contents of this method with the code editor.
	  ''' </summary>
	  Private Sub InitializeComponent()
		  Me.components = New System.ComponentModel.Container()
		  Me.SwitchAction = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
		  ' 
		  ' SwitchAction
		  ' 
		  Me.SwitchAction.Caption = "Switch"
		  Me.SwitchAction.ConfirmationMessage = Nothing
		  Me.SwitchAction.Id = "SwitchAction"
		  Me.SwitchAction.ImageName = Nothing
		  Me.SwitchAction.Shortcut = Nothing
		  Me.SwitchAction.Tag = Nothing
		  Me.SwitchAction.TargetObjectsCriteria = Nothing
		  Me.SwitchAction.TargetViewId = Nothing
		  Me.SwitchAction.ToolTip = "Switch Master-Detail Mode"
		  Me.SwitchAction.TypeOfView = Nothing
'		  Me.SwitchAction.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.SwitchAction_Execute);
		  ' 
		  ' SwitchController
		  ' 
		  Me.TargetViewType = DevExpress.ExpressApp.ViewType.ListView
		  Me.TypeOfView = GetType(DevExpress.ExpressApp.ListView)

	  End Sub

	  #End Region

	  Private WithEvents SwitchAction As DevExpress.ExpressApp.Actions.SimpleAction
   End Class
End Namespace
