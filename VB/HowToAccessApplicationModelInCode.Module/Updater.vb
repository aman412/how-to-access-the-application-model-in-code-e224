Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.BaseImpl

Namespace HowToAccessApplicationModelInCode.Module
   Public Class Updater
	   Inherits ModuleUpdater
        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
	  Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
		 MyBase.UpdateDatabaseAfterUpdateSchema()
		 If ObjectSpace.FindObject(Of Contact)(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'")) Is Nothing Then
			 Dim contact As Contact = ObjectSpace.CreateObject(Of Contact)()
			 contact.FirstName = "Mary"
			 contact.LastName = "Tellitson"
			 contact.Email = "tellitson@example.com"
			 contact.Save()
		 End If
		 If ObjectSpace.FindObject(Of Contact)(CriteriaOperator.Parse("FirstName == 'Andrew' && LastName == 'Fuller'")) Is Nothing Then
			 Dim contact As Contact = ObjectSpace.CreateObject(Of Contact)()
			 contact.FirstName = "Andrew"
			 contact.LastName = "Fuller"
			 contact.Email = "fuller@example.com"
			 contact.Save()
		 End If
	  End Sub
   End Class
End Namespace
