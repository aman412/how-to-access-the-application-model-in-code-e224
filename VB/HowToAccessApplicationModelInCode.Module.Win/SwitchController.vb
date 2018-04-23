Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base

Public Class SwitchController
	Inherits DevExpress.ExpressApp.ViewController

	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()
		RegisterActions(components) 

	End Sub

    Private Sub SwitchAction_Execute(ByVal sender As System.Object, ByVal e As DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs) Handles SwitchAction.Execute
        'Get the current value of the Views | CurrentObjectType_ ListView node's MasterDetailMode attribute 
        Dim mDm As MasterDetailMode = View.Info.GetAttributeEnumValue(Of MasterDetailMode)( _
           "MasterDetailMode", MasterDetailMode.ListViewOnly)
        'Change the MasterDetailMode attribute's value
        If mDm = DevExpress.ExpressApp.MasterDetailMode.ListViewAndDetailView Then
            View.Info.SetAttribute("MasterDetailMode", _
               CInt(DevExpress.ExpressApp.MasterDetailMode.ListViewOnly))
        Else
            View.Info.SetAttribute("MasterDetailMode", _
               CInt(DevExpress.ExpressApp.MasterDetailMode.ListViewAndDetailView))
        End If
        'Update the Views | CurrentObjectType_ ListView node in the Application Model
        View.SetInfo(View.Info)
    End Sub
End Class
