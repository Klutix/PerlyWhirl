Imports System

Public Class Form1
    Dim cmdoutput As String
    Dim batproc As Process
    Dim sb As New System.Text.StringBuilder
    Dim FileName As String
    Dim SavePath As String
    Dim nl As String = Environment.NewLine
    Dim GeneralBatchinfo As String
    Dim strcmndsfrmtxt As String
    Dim FileNameAndPath As String
    Dim BatchPath As String
    Dim goodSave As Boolean = False
    Dim defglbvalue As String
    Dim Defaultperlpath As String
    'Dim Defaultperlpath As String = "cd C:\strawberry\perl\bin "
    Dim lastSaveDate As String
    Dim tmpPath As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set default path
        PathTextbox.Text = "C:\Users\" & Environment.UserName & "\Desktop\"
        FileNameTextBox.Text = "PerlScript1.pl"
        If (System.IO.File.Exists(CurDir() & "\" & "Settings.txt")) Then
            Defaultperlpath = My.Computer.FileSystem.ReadAllText(CurDir() & "\" & "Settings.txt")
        Else
            ' Defaultperlpath = "cd C:\strawberry\perl\bin "
        End If

    End Sub




    Private Sub Run_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Run_Button.Click
        If (goodSave) Then
            Try
                batproc = System.Diagnostics.Process.Start(BatchPath)
            Catch
                MsgBox("File Not Found")
            End Try
            'MsgBox("save p" & SavePath)
            'MsgBox(" gen info: " & GeneralBatchinfo)
        End If
        
        If (goodSave = False) Then
            If (System.IO.File.Exists(BatchPath)) Then
                System.IO.File.Delete(BatchPath)
            End If
            Temprun()
            ' MsgBox("save p" & SavePath)
            'MsgBox(" gen info: " & Defaultperlpath)
            MsgBox(" bat p " & BatchPath)
            MsgBox("save stat: " & goodSave.ToString)

            batproc = System.Diagnostics.Process.Start(BatchPath)
        End If
        
        MsgBox(CurDir().ToString)

    End Sub




    Private Sub Save()
        If (System.IO.Directory.Exists(PathTextbox.Text)) Then
            If (FileNameTextBox.Text.Contains(".pl")) Then
                SavePath = ""
                BatchPath = ""
                FileName = ""
                sb.Clear()
                ISSavedTextBox.BackColor = Color.DarkBlue

                SavePath = PathTextbox.Text
                'GeneralBatchinfo = "@echo off" & nl & "Dir C:\strawberry\perl\bin Perl "
                BatchPath = CurDir() & "LaunchPW.bat"
                FileName = ""
                sb.AppendLine("@echo off")

                FileName = FileNameTextBox.Text
                strcmndsfrmtxt = RichTextBox1.Text

                'append file name to path
                SavePath += FileName

                'append SavePath with general batch info and PAUSE to prevent from autoclose
                ''GeneralBatchinfo += SavePath & nl & "PAUSE"
                sb.AppendLine("cls")
                sb.AppendLine(Defaultperlpath)
                sb.AppendLine("perl " & SavePath)
                sb.AppendLine("PAUSE")
                IO.File.WriteAllText(BatchPath, sb.ToString)
                
                'create perl file 
                If (IO.File.Exists(SavePath)) Then
                    System.IO.File.Delete(SavePath)
                End If

                My.Computer.FileSystem.WriteAllText(SavePath, strcmndsfrmtxt, False)
                'create batch file
                '   My.Computer.FileSystem.WriteAllText(BatchPath, GeneralBatchinfo, True)
                goodSave = True
                Date_Label.Text = "Last Save: " & Date.UtcNow
            End If
        Else
            MsgBox("Invalid Name or Directory", MsgBoxStyle.Exclamation, vbOK)
        End If

    End Sub


    Private Sub RichTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        ISSavedTextBox.BackColor = Color.White
        goodSave = False
        Try
            batproc.Kill()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Save_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Button.Click
        Save()
    End Sub
    'temporarily create files and assign variables
    Private Sub Temprun()
        'reset variables
        BatchPath = ""
        SavePath = ""
        FileName = ""
        sb.Clear()

        SavePath = "C:\Users\" & Environment.UserName & "\Desktop\"
        'GeneralBatchinfo = "@echo off" & nl & "Dir C:\strawberry\perl\bin Perl "
        BatchPath = CurDir() & "LaunchPW.bat"
        FileName = ""
        sb.AppendLine("@echo off")

        FileName = "temp.pl"
        strcmndsfrmtxt = RichTextBox1.Text

        'append file name to path
        SavePath += FileName

        'append SavePath with general batch info and PAUSE to prevent from autoclose
        ''GeneralBatchinfo += SavePath & nl & "PAUSE"
        sb.AppendLine("cls")
        sb.AppendLine(Defaultperlpath)
        sb.AppendLine("perl " & SavePath)
        sb.AppendLine("PAUSE")
        IO.File.WriteAllText(BatchPath, sb.ToString)

        'delete old file and create new one 
        If (IO.File.Exists(SavePath)) Then
            System.IO.File.Delete(SavePath)
        End If

        My.Computer.FileSystem.WriteAllText(SavePath, strcmndsfrmtxt, False)
        'create batch file
        '   My.Computer.FileSystem.WriteAllText(BatchPath, GeneralBatchinfo, True)
    End Sub

    'set default perl path
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

        tmpPath = InputBox("Enter Perl Global path")
        If (System.IO.Directory.Exists(tmpPath)) Then
            Defaultperlpath = "cd " & tmpPath
            'write new path to textfile
            My.Computer.FileSystem.WriteAllText(CurDir() & "\" & "Settings.txt", Defaultperlpath, False)
        Else
            If (tmpPath <> "") Then
                MsgBox("Invalid Path")
                tmpPath = ""
            End If

        End If

    End Sub


End Class
