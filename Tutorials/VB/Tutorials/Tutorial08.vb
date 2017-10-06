﻿Imports NetOffice
Imports Excel = NetOffice.ExcelApi

''' <summary>
''' Ouer custom Excel.Workbook
''' </summary>
Public Class MyWorkbook
    Inherits Excel.Workbook

    Public Sub New(parentObject As ICOMObject, comProxy As Object)
        MyBase.New(parentObject, comProxy)

    End Sub

    Public Sub New(parentObject As ICOMObject, comProxy As Object, comProxyType As Type)
        MyBase.New(parentObject, comProxy)

    End Sub

    ' Sample property
    Public ReadOnly Property Has3Sheets As Boolean
        Get
            Return Sheets.Count = 3
        End Get
    End Property

End Class

Public Class Tutorial08
    Implements ITutorial

    Dim _hostApplication As IHost

    Public Sub Run() Implements TutorialsBase.ITutorial.Run

        'Replace Excel.Workbook with MyWorkbook
        Dim createHandler As Core.OnCreateInstanceEventHandler = AddressOf Me.OnCreate
        AddHandler NetOffice.Core.Default.CreateInstance, createHandler

        ' start application
        Dim application As New Excel.Application()
        application.DisplayAlerts = False

        'add and cast book to MyWorkbook
        Dim book As MyWorkbook = application.Workbooks.Add()
        If book.Has3Sheets Then
            Console.WriteLine("Book has 3 sheets.")
        End If

        application.Quit()
        application.Dispose()

        _hostApplication.ShowFinishDialog()

    End Sub

    Public Sub OnCreate(sender As Core, args As Core.OnCreateInstanceEventArgs)

        If args.Instance.InstanceType = GetType(Excel.Workbook) Then
            args.Replace = GetType(MyWorkbook)
        End If

    End Sub

    Public ReadOnly Property Caption As String Implements TutorialsBase.ITutorial.Caption
        Get
            Return "Tutorial08"
        End Get
    End Property

    Public ReadOnly Property Description As String Implements TutorialsBase.ITutorial.Description
        Get
            Return "Custom Instances"
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
            Return FormMain.DocumentationBase & "Tutorial08_EN_VB.html"
        End Get
    End Property

End Class
