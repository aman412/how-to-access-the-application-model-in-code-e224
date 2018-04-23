Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Model

Namespace HowToAccessApplicationModelInCode.Module.Win
    Partial Public Class SwitchController
        Inherits ViewController
        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
        End Sub
        Private Sub SwitchAction_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles SwitchAction.Execute
            If (CType(View.Model, IModelListView)).MasterDetailMode = MasterDetailMode.ListViewAndDetailView Then
                CType(View.Model, IModelListView).MasterDetailMode = DevExpress.ExpressApp.MasterDetailMode.ListViewOnly
            Else
                CType(View.Model, IModelListView).MasterDetailMode = DevExpress.ExpressApp.MasterDetailMode.ListViewAndDetailView
            End If
            View.SetInfo(View.Model)
        End Sub
    End Class
End Namespace
