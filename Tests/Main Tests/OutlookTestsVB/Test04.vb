﻿Imports NetOffice
Imports Outlook = NetOffice.OutlookApi
Imports NetOffice.OutlookApi.Enums
Imports Tests.Core

Public Class Test04
    Implements ITestPackage

    Public ReadOnly Property Description As String Implements Tests.Core.ITestPackage.Description
        Get
            Return "Perform send and recieve."
        End Get
    End Property

    Public ReadOnly Property Language As String Implements Tests.Core.ITestPackage.Language
        Get
            Return "VB"
        End Get
    End Property

    Public ReadOnly Property Name As String Implements Tests.Core.ITestPackage.Name
        Get
            Return "Test04"
        End Get
    End Property

    Public ReadOnly Property OfficeProduct As String Implements Tests.Core.ITestPackage.OfficeProduct
        Get
            Return "Outlook"
        End Get
    End Property

    Public Function DoTest() As Tests.Core.TestResult Implements Tests.Core.ITestPackage.DoTest

        Dim application As Outlook.Application = Nothing
        Dim startTime As DateTime = DateTime.Now
        Try
            application = New NetOffice.OutlookApi.Application(True)
            NetOffice.OutlookSecurity.Suppress.Enabled = True

            If application.Session.EntityIsAvailable("SendAndReceive") Then

                application.Session.SendAndReceive(False)
                ' give few seconds to outlook or may its failed to quit because its busy - depending on how many mails comes in
                System.Threading.Thread.Sleep(3000)

            Else
                Return New TestResult(False, DateTime.Now.Subtract(startTime), "SendAndReceive is not supported from this Outlook Version.", Nothing, "")
            End If

            Return New TestResult(True, DateTime.Now.Subtract(startTime), "", Nothing, "")

        Catch ex As Exception

            Return New TestResult(False, DateTime.Now.Subtract(startTime), ex.Message, ex, "")

        Finally

            If Not IsNothing(application) Then

                If False = application.FromProxyService Then
                    application.Quit()
                End If

                application.Dispose()

            End If

        End Try

    End Function

End Class
