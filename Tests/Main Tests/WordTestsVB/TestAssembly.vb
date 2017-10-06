﻿Imports Tests.Core
Imports Microsoft.Win32

Public Class TestAssembly
    Implements ITestAssembly

    Private _listPackages As List(Of ITestPackage)

    Public ReadOnly Property Language As String Implements Tests.Core.ITestAssembly.Language
        Get
            Return "VB"
        End Get
    End Property

    Public Function LoadTestPackages() As Tests.Core.ITestPackage() Implements Tests.Core.ITestAssembly.LoadTestPackages

        If IsNothing(_listPackages) Then

            _listPackages = New List(Of ITestPackage)
            _listPackages.Add(New Test01())
            _listPackages.Add(New Test02())
            _listPackages.Add(New Test03())
            _listPackages.Add(New Test04())
            _listPackages.Add(New Test05())
            _listPackages.Add(New Test06())
            _listPackages.Add(New Test07())
            _listPackages.Add(New Test08())
            _listPackages.Add(New Test09())

        End If

        Return _listPackages.ToArray()

    End Function

    Public ReadOnly Property OfficeProduct As String Implements Tests.Core.ITestAssembly.OfficeProduct
        Get
            Return "Word"
        End Get
    End Property

End Class
