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
    Partial Public Class SelectViewController
        Inherits ViewController
        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
        End Sub
        Private Sub SelectViewAction_Execute(ByVal sender As Object, ByVal e As SingleChoiceActionExecuteEventArgs) Handles SelectViewAction.Execute
            View.SetInfo(CType(e.SelectedChoiceActionItem.Data, IModelView))
        End Sub
        Protected Overrides Overloads Sub OnActivated()
            MyBase.OnActivated()
            SelectViewAction.BeginUpdate()
            SelectViewAction.Items.Clear()
            For Each node As IModelView In View.Model.Application.Views.GetNodes(Of IModelListView)()
                If node.ModelClass Is View.Model.ModelClass Then
                    Dim current As New ChoiceActionItem(node.Id, node)
                    SelectViewAction.Items.Add(current)
                    If node Is View.Model Then
                        SelectViewAction.SelectedItem = current
                    End If
                End If
            Next node
            SelectViewAction.EndUpdate()
        End Sub
    End Class
End Namespace
