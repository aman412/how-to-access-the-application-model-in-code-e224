Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base

Public Class SelectViewController
	Inherits DevExpress.ExpressApp.ViewController

	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()
		RegisterActions(components) 

   End Sub
   Protected Overrides Sub OnActivated()
      MyBase.OnActivated()
      SelectViewAction.BeginUpdate()
      SelectViewAction.Items.Clear()
      Dim node As DictionaryNode = Application.Model.RootNode.GetChildNode("Views")
      For Each dnode As DictionaryNode In node.GetChildNodes("ListView", "ClassName", _
            View.ObjectTypeInfo.Type.FullName, False)
         Dim current As ChoiceActionItem = _
            New ChoiceActionItem(dnode.GetAttributeValue("ID"), dnode)
         SelectViewAction.Items.Add(current)
         If dnode Is View.Info Then
            SelectViewAction.SelectedItem = current
         End If
      Next dnode
      SelectViewAction.EndUpdate()
   End Sub

   Private Sub SelectViewAction_Execute(ByVal sender As System.Object, ByVal e As DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventArgs) Handles SelectViewAction.Execute
      View.SetInfo(CType(e.SelectedChoiceActionItem.Data, DictionaryNode))
   End Sub
End Class
