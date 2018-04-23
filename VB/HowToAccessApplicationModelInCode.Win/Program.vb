Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Windows.Forms

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports WinWebSolution.Module

Namespace HowToAccessApplicationModelInCode.Win
   Friend NotInheritable Class Program
	  ''' <summary>
	  ''' The main entry point for the application.
	  ''' </summary>
	  Private Sub New()
	  End Sub
	  <STAThread> _
	  Shared Sub Main()
		 EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
		 Dim myApplication As New HowToAccessApplicationModelInCodeWindowsFormsApplication()
		 myApplication.ConnectionString = CodeCentralExampleInMemoryDataStoreProvider.ConnectionString
		 Try
   DevExpress.ExpressApp.InMemoryDataStoreProvider.Register()
   			myApplication.ConnectionString = DevExpress.ExpressApp.InMemoryDataStoreProvider.ConnectionString
			myApplication.Setup()
			myApplication.Start()
		 Catch e As Exception
			myApplication.HandleException(e)
		 End Try
	  End Sub
   End Class
End Namespace
