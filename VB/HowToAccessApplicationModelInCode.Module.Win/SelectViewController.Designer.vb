Imports Microsoft.VisualBasic
Imports System
Namespace HowToAccessApplicationModelInCode.Module.Win
    Partial Public Class SelectViewController
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
            Me.SelectViewAction = New DevExpress.ExpressApp.Actions.SingleChoiceAction(Me.components)
            ' 
            ' SelectViewAction
            ' 
            Me.SelectViewAction.Caption = "Select View"
            Me.SelectViewAction.ConfirmationMessage = Nothing
            Me.SelectViewAction.Id = "SelectViewAction"
            Me.SelectViewAction.ImageName = Nothing
            Me.SelectViewAction.Shortcut = Nothing
            Me.SelectViewAction.Tag = Nothing
            Me.SelectViewAction.PaintStyle = DevExpress.ExpressApp.Templates.ActionItemPaintStyle.Caption
            Me.SelectViewAction.TargetObjectsCriteria = Nothing
            Me.SelectViewAction.TargetViewId = Nothing
            Me.SelectViewAction.TargetViewType = DevExpress.ExpressApp.ViewType.ListView
            Me.SelectViewAction.ToolTip = Nothing
            Me.SelectViewAction.TypeOfView = GetType(DevExpress.ExpressApp.ListView)
'            Me.SelectViewAction.Execute += New DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(Me.SelectViewAction_Execute);
            ' 
            ' SelectViewController
            ' 
            Me.TargetViewType = DevExpress.ExpressApp.ViewType.ListView
            Me.TypeOfView = GetType(DevExpress.ExpressApp.ListView)

        End Sub

        #End Region

        Private WithEvents SelectViewAction As DevExpress.ExpressApp.Actions.SingleChoiceAction
    End Class
End Namespace
