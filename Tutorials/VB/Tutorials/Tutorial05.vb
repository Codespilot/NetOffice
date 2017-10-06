﻿Imports NetOffice
Imports Excel = NetOffice.ExcelApi
Imports Office = NetOffice.OfficeApi

Public Class Tutorial05
    Implements ITutorial

    Dim _hostApplication As IHost

    Public Sub Run() Implements TutorialsBase.ITutorial.Run

        ' this is a simple demonstration how i can convert unkown types at runtime

        ' start application
        Dim application As New Excel.Application()
        application.Visible = False
        application.DisplayAlerts = False

        For Each item As Office.COMAddIn In application.COMAddIns

            ' the application property is an unkown COM object
            ' we need a cast at runtime 
            Dim hostApp As Excel.Application = item.Application

            ' do some sample stuff
            Dim hostAppName As String = hostApp.Name
            Dim hostAppVisible As Boolean = hostApp.Visible

            'another way to use is visual basic late binding 
            hostAppName = item.Application.Name
            hostAppVisible = item.Application.Visible

        Next

        ' quit and dispose excel
        application.Quit()
        application.Dispose()

        _hostApplication.ShowFinishDialog()

    End Sub

    Public ReadOnly Property Caption As String Implements TutorialsBase.ITutorial.Caption
        Get
            Return "Tutorial05"
        End Get
    End Property

    Public ReadOnly Property Description As String Implements TutorialsBase.ITutorial.Description
        Get
            Return "Understanding unkown Types"
        End Get
    End Property

    Public Sub Connect(ByVal hostApplication As TutorialsBase.IHost) Implements TutorialsBase.ITutorial.Connect

        _hostApplication = hostApplication

    End Sub

    Public Sub Disconnect() Implements TutorialsBase.ITutorial.Disconnect

    End Sub

    Public ReadOnly Property Panel As System.Windows.Forms.UserControl Implements TutorialsBase.ITutorial.Panel
        Get
            Return Nothing
        End Get
    End Property


    Public ReadOnly Property Uri As String Implements TutorialsBase.ITutorial.Uri
        Get
            Return FormMain.DocumentationBase & "Tutorial05_EN_VB.html"
        End Get
    End Property

End Class