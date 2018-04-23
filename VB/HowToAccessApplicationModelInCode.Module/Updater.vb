Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace HowToAccessApplicationModelInCode.Module
   Public Class Updater
       Inherits ModuleUpdater
      Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
          MyBase.New(session, currentDBVersion)
      End Sub
      Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
         MyBase.UpdateDatabaseAfterUpdateSchema()
         If Session.FindObject(Of Contact)(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'")) Is Nothing Then
             Dim contact As New Contact(Session)
             contact.FirstName = "Mary"
             contact.LastName = "Tellitson"
             contact.Email = "tellitson@example.com"
             contact.Save()
         End If
         If Session.FindObject(Of Contact)(CriteriaOperator.Parse("FirstName == 'Andrew' && LastName == 'Fuller'")) Is Nothing Then
             Dim contact As New Contact(Session)
             contact.FirstName = "Andrew"
             contact.LastName = "Fuller"
             contact.Email = "fuller@example.com"
             contact.Save()
         End If
      End Sub
   End Class
End Namespace
