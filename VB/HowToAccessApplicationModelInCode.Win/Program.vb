Imports System
Imports System.Configuration
Imports System.Windows.Forms

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace HowToAccessApplicationModelInCode.Win
   Friend NotInheritable Class Program

       Private Sub New()
       End Sub

      ''' <summary>
      ''' The main entry point for the application.
      ''' </summary>
      <STAThread> _
      Shared Sub Main()
         EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
         Dim application As New HowToAccessApplicationModelInCodeWindowsFormsApplication()
         Try
            DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.Register()
            application.ConnectionString = DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.ConnectionString
            application.Setup()
            application.Start()
         Catch e As Exception
            application.HandleException(e)
         End Try
      End Sub
   End Class
End Namespace
