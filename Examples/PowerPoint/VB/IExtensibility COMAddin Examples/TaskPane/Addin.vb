﻿Imports Microsoft.Win32
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports Extensibility
Imports NetOffice
Imports PowerPoint = NetOffice.PowerPointApi
Imports NetOffice.PowerPointApi.Enums
Imports Office = NetOffice.OfficeApi
Imports NetOffice.OfficeApi.Enums

<Guid("AD5FBAB7-D362-4492-8FBC-6DDEE1E76237"), ProgId("PPointAddinVB4.TaskPaneAddin"), ComVisible(True)>
Public Class Addin
    Implements IDTExtensibility2, Office.Native.ICustomTaskPaneConsumer

    Private Shared ReadOnly _addinOfficeRegistryKey As String = "Software\\Microsoft\\Office\\PowerPoint\\AddIns\\"
    Private Shared ReadOnly _progId As String = "PPointAddinVB4.TaskPaneAddin"
    Private Shared ReadOnly _addinFriendlyName As String = "NetOffice Sample Addin in VB"
    Private Shared ReadOnly _addinDescription As String = "NetOffice Sample Addin with custom Task Pane"

    Private Shared _sampleControl As SampleControl
    Private Shared _powerApplication As PowerPoint.Application

    Public Shared ReadOnly Property Application() As PowerPoint.Application
        Get
            Return _powerApplication
        End Get
    End Property

#Region "ICustomTaskPaneConsumer Member"

    Public Sub CTPFactoryAvailable(ByVal CTPFactoryInst As Object) Implements NetOffice.OfficeApi.Native.ICustomTaskPaneConsumer.CTPFactoryAvailable

        Try

            Dim ctpFactory As Office.ICTPFactory = New Office.ICTPFactory(_powerApplication, CTPFactoryInst)
            Dim taskPane As Office._CustomTaskPane = ctpFactory.CreateCTP(GetType(Addin).Assembly.GetName().Name + ".SampleControl", "NetOffice Sample Pane(VB4)", Type.Missing)
            taskPane.DockPosition = MsoCTPDockPosition.msoCTPDockPositionLeft
            taskPane.Width = 300
            taskPane.Visible = True
            _sampleControl = taskPane.ContentControl
            ctpFactory.Dispose()

        Catch ex As Exception

            Dim message As String = String.Format("An error occured.{0}{0}{1}", Environment.NewLine, ex.Message)
            MessageBox.Show(message, _progId, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

#End Region

#Region "IDTExtensibility2 Member"

    Public Sub OnConnection(ByVal Application As Object, ByVal ConnectMode As Extensibility.ext_ConnectMode, ByVal AddInInst As Object, ByRef custom As System.Array) Implements Extensibility.IDTExtensibility2.OnConnection

        Try

            _powerApplication = New PowerPoint.Application(Nothing, Application)

        Catch ex As Exception

            Dim message As String = String.Format("An error occured.{0}{0}{1}", Environment.NewLine, ex.Message)
            MessageBox.Show(message, _progId, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Sub OnDisconnection(ByVal RemoveMode As Extensibility.ext_DisconnectMode, ByRef custom As System.Array) Implements Extensibility.IDTExtensibility2.OnDisconnection

        Try

            If (Not IsNothing(_powerApplication)) Then
                _powerApplication.Dispose()
            End If

        Catch ex As Exception

            Dim message As String = String.Format("An error occured.{0}{0}{1}", Environment.NewLine, ex.Message)
            MessageBox.Show(message, _progId, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Sub OnStartupComplete(ByRef custom As System.Array) Implements Extensibility.IDTExtensibility2.OnStartupComplete

    End Sub

    Public Sub OnAddInsUpdate(ByRef custom As System.Array) Implements Extensibility.IDTExtensibility2.OnAddInsUpdate

    End Sub

    Public Sub OnBeginShutdown(ByRef custom As System.Array) Implements Extensibility.IDTExtensibility2.OnBeginShutdown

    End Sub

#End Region

#Region "COM Register Functions"

    <ComRegisterFunctionAttribute()> _
    Public Shared Sub RegisterFunction(ByVal type As Type)
        Try
            ' add codebase value
            Dim thisAssembly As Assembly = Assembly.GetAssembly(GetType(Addin))
            Dim key As RegistryKey = Registry.ClassesRoot.CreateSubKey("CLSID\\{" + type.GUID.ToString().ToUpper() + "}\\InprocServer32\\1.0.0.0")
            key.SetValue("CodeBase", thisAssembly.CodeBase)
            key.Close()

            Registry.ClassesRoot.CreateSubKey("CLSID\{" + type.GUID.ToString().ToUpper() + "}\Programmable")

            ' add bypass key
            ' http://support.microsoft.com/kb/948461
            key = Registry.ClassesRoot.CreateSubKey("Interface\\{000C0601-0000-0000-C000-000000000046}")
            Dim defaultValue As String = key.GetValue("")
            If (IsNothing(defaultValue)) Then
                key.SetValue("", "Office .NET Framework Lockback Bypass Key")
            End If
            key.Close()

            ' add powerpoint addin key
            Registry.CurrentUser.CreateSubKey(_addinOfficeRegistryKey + _progId)
            Dim rk As RegistryKey = Registry.CurrentUser.OpenSubKey(_addinOfficeRegistryKey + _progId, True)
            rk.SetValue("LoadBehavior", CInt(3))
            rk.SetValue("FriendlyName", _addinFriendlyName)
            rk.SetValue("Description", _addinDescription)
            rk.Close()

        Catch ex As Exception

            Dim details As String = String.Format("{1}{1}Details:{1}{1}{0}", ex.Message, Environment.NewLine)
            MessageBox.Show("An error occured." + details, "Register " + _progId, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    <ComUnregisterFunctionAttribute()> _
    Public Shared Sub UnregisterFunction(ByVal type As Type)
        Try

            Registry.ClassesRoot.DeleteSubKey("CLSID\\{" + type.GUID.ToString().ToUpper() + "}\\Programmable", False)
            Registry.CurrentUser.DeleteSubKey(_addinOfficeRegistryKey + _progId, False)

        Catch throwedException As Exception

            Dim details As String = String.Format("{1}{1}Details:{1}{1}{0}", throwedException.Message, Environment.NewLine)
            MessageBox.Show("An error occured." + details, "Unregister " + _progId, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

#End Region

End Class
