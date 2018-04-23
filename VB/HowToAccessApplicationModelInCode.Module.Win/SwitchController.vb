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
            Dim model As IModelListView = DirectCast(View, ListView).Model
            Dim shortcut As ViewShortcut = Frame.View.CreateShortcut()
            Frame.SetView(Nothing)
            If model.MasterDetailMode = MasterDetailMode.ListViewAndDetailView Then
                model.MasterDetailMode = MasterDetailMode.ListViewOnly
            Else
                model.MasterDetailMode = MasterDetailMode.ListViewAndDetailView
            End If
            Frame.SetView(Application.ProcessShortcut(shortcut), True, Frame)
       End Sub
    End Class
End Namespace
