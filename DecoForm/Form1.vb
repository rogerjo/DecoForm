﻿Imports pfcls
Public Class Form1

    Dim asyncConnection As IpfcAsyncConnection = Nothing
    Dim model As IpfcModel
    Dim activeserver As IpfcServer
    Dim paramown As IpfcParameterOwner
    Dim ipparam As IpfcParameter
    Dim ipbaseparam As IpfcBaseParameter
    Dim paramval As IpfcParamValue

    Dim session As IpfcBaseSession
    Dim Moditem As CMpfcModelItem


    Public Sub setParameter()

        Dim Paraname As String = "SURFACE_FINISH"
        Try
            asyncConnection = (New CCpfcAsyncConnection).Connect(Nothing, Nothing, Nothing, Nothing)
            session = asyncConnection.Session
            activeserver = session.GetActiveServer
            model = session.CurrentModel

            If model Is Nothing Then
                MsgBox("Model is not present",, "Script message")
                Environment.Exit(0)
            End If

            If (Not model.Type = EpfcModelType.EpfcMDL_PART) And (Not model.Type = EpfcModelType.EpfcMDL_ASSEMBLY) Then
                MsgBox("Model is not a solid",, "Script message")
                Environment.Exit(0)
            End If

            If Not activeserver.IsObjectCheckedOut(activeserver.ActiveWorkspace, model.FileName) Then
                MsgBox("Please check out model first...",, "Script Message")
                Environment.Exit(0)
            End If

            paramown = model
            ipparam = paramown.GetParam(Paraname)
            ipbaseparam = ipparam
            Moditem = New CMpfcModelItem

            paramval = Moditem.CreateStringParamValue(CStr("SEE DECORATION SPECIFICATION"))
            ipbaseparam.Value = paramval

            MsgBox("Surface finish has been set to 'SEE DECORATION SPECIFICATION'",, "Script Message")
            asyncConnection.Disconnect(1)

        Catch ex As Exception
        End Try
    End Sub

    Public Sub clearParameter()
        Dim Paraname As String = "SURFACE_FINISH"

        Try
            asyncConnection = (New CCpfcAsyncConnection).Connect(Nothing, Nothing, Nothing, Nothing)
            session = asyncConnection.Session
            activeserver = session.GetActiveServer
            model = session.CurrentModel


            If model Is Nothing Then
                MsgBox("Model is not present",, "Script message")
                Environment.Exit(0)
            End If

            If (Not model.Type = EpfcModelType.EpfcMDL_PART) And (Not model.Type = EpfcModelType.EpfcMDL_ASSEMBLY) Then
                MsgBox("Model is not a solid",, "Script message")
                Environment.Exit(0)
            End If

            If Not activeserver.IsObjectCheckedOut(activeserver.ActiveWorkspace, model.FileName) Then
                MsgBox("Please check out model first...",, "Script Message")
                Environment.Exit(0)
            End If

            paramown = model
            ipparam = paramown.GetParam(Paraname)
            ipbaseparam = ipparam

            Moditem = New CMpfcModelItem

            paramval = Moditem.CreateStringParamValue(CStr("-"))
            ipbaseparam.Value = paramval

            MsgBox("Surface finish has been set to '-'",, "Script Message")
            asyncConnection.Disconnect(1)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub clearDecoParamButton_Click(sender As Object, e As EventArgs) Handles clearDecoParamButton.Click
        Call clearParameter()
    End Sub

    Private Sub setDecoParamButton_Click(sender As Object, e As EventArgs) Handles setDecoParamButton.Click
        Call setParameter()
    End Sub

    Private Sub setGreenColor_Click(sender As Object, e As EventArgs) Handles setGreenColor.Click
        Call setGreenColorMacro()
    End Sub

    Private Sub setYellowColor_Click(sender As Object, e As EventArgs) Handles setYellowColor.Click
        Call setYellowColorMacro()
    End Sub

    Private Sub setRedColor_Click(sender As Object, e As EventArgs) Handles setRedColor.Click
        Call setRedColorMacro()
    End Sub
    Private Sub setWhiteBack_Click(sender As Object, e As EventArgs) Handles setWhiteBack.Click
        Call setWhiteBackMacro()
    End Sub

    Private Sub clearAppearance_Click(sender As Object, e As EventArgs) Handles clearAppearance.Click
        Call clearAppearanceMacro()
    End Sub


    Private Sub setGreenColorMacro()
        asyncConnection = (New CCpfcAsyncConnection).Connect(Nothing, Nothing, Nothing, Nothing)
        session = asyncConnection.Session
        activeserver = session.GetActiveServer
        model = session.CurrentModel

        Try
            Dim macrostring As String
            macrostring = "~ Select `main_dlg_cur` `user_custom_page_315894752:ProCmdViewGallery`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Select `main_dlg_cur` \"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "`ProCmdViewGallery_layoutph.palette_holder.myAppPalette.NamesList` 1 \"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "`deco_green`;~ Timer `UI Desktop` `UI Desktop` `Gallery_UI_Timer`;"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Close `main_dlg_cur` `user_custom_page_315894752:ProCmdViewGallery`;"

            session.RunMacro(macrostring)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub setYellowColorMacro()
        asyncConnection = (New CCpfcAsyncConnection).Connect(Nothing, Nothing, Nothing, Nothing)
        session = asyncConnection.Session
        activeserver = session.GetActiveServer
        model = session.CurrentModel

        Try
            Dim macrostring As String
            macrostring = "~ Select `main_dlg_cur` `user_custom_page_315894752:ProCmdViewGallery`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Select `main_dlg_cur` \"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "`ProCmdViewGallery_layoutph.palette_holder.myAppPalette.NamesList` 1 \"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "`deco_yellow`;~ Timer `UI Desktop` `UI Desktop` `Gallery_UI_Timer`;"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Close `main_dlg_cur` `user_custom_page_315894752:ProCmdViewGallery`;"

            session.RunMacro(macrostring)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub setRedColorMacro()
        asyncConnection = (New CCpfcAsyncConnection).Connect(Nothing, Nothing, Nothing, Nothing)
        session = asyncConnection.Session
        activeserver = session.GetActiveServer
        model = session.CurrentModel

        Try
            Dim macrostring As String
            macrostring = "~ Select `main_dlg_cur` `user_custom_page_315894752:ProCmdViewGallery`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Select `main_dlg_cur` \"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "`ProCmdViewGallery_layoutph.palette_holder.myAppPalette.NamesList` 1 \"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "`deco_red`;~ Timer `UI Desktop` `UI Desktop` `Gallery_UI_Timer`;"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Close `main_dlg_cur` `user_custom_page_315894752:ProCmdViewGallery`;"

            session.RunMacro(macrostring)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub setWhiteBackMacro()
        asyncConnection = (New CCpfcAsyncConnection).Connect(Nothing, Nothing, Nothing, Nothing)
        session = asyncConnection.Session
        activeserver = session.GetActiveServer
        model = session.CurrentModel

        Try
            Dim macrostring As String
            macrostring = "~ Trail `UI Desktop` `UI Desktop` `PREVIEW_POPUP_TIMER` \"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "`main_dlg_w1:PHTLeft.AssyTree:<NULL>`;~ Select `main_dlg_cur` `appl_casc`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Close `main_dlg_cur` `appl_casc`;~ Command `ProCmdRibbonOptionsDlg` ;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Select `ribbon_options_dialog` `PageSwitcherPageList` 1 `colors_layouts`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Open `ribbon_options_dialog` `colors_layouts.Color_scheme_optMenu`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Close `ribbon_options_dialog` `colors_layouts.Color_scheme_optMenu`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Select `ribbon_options_dialog` `colors_layouts.Color_scheme_optMenu` 1 `2`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Activate `ribbon_options_dialog` `OkPshBtn`;"
            'macrostring = macrostring & vbCrLf
            'macrostring = macrostring & "~ FocusIn `UI Message Dialog` `yes`;~ Activate `UI Message Dialog` `yes`;"

            'MsgBox(macrostring)

            session.RunMacro(macrostring)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub clearAppearanceMacro()
        asyncConnection = (New CCpfcAsyncConnection).Connect(Nothing, Nothing, Nothing, Nothing)
        session = asyncConnection.Session
        activeserver = session.GetActiveServer
        model = session.CurrentModel

        Try
            Dim macrostring As String
            macrostring = "~ Select `main_dlg_cur` `appl_casc`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Close `main_dlg_cur` `appl_casc`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Select `main_dlg_cur` `Model:ProCmdViewGallery`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Select `main_dlg_cur` \"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "`ProCmdViewGallery_layoutph.palette_holder.clearAppearance`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Close `main_dlg_cur` \"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "`ProCmdViewGallery_layoutph.palette_holder.clearAppearance`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ Activate `main_dlg_cur` `clearAllAppearance`;\"
            macrostring = macrostring & vbCrLf
            macrostring = macrostring & "~ FocusIn `UI Message Dialog` `yes`;~ Activate `UI Message Dialog` `yes`;"

            session.RunMacro(macrostring)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
