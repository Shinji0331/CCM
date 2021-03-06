﻿Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ControlChars
Public Class ClsDBAccess
    Implements IDisposable

#Region "変数宣言"

    Private fileName As String
    Private dbCnc As OleDbConnection
    Private dbAdp As OleDbDataAdapter

#End Region


#Region "インスタンス化"

    Sub New(fileName_ As String)
        fileName = fileName_
    End Sub

#End Region

#Region "テーブルデータ取得処理"

    Private Function getTableData(ByVal strSQL As String) As DataTable

        Dim table As New DataTable

        Try
            '' 接続
            dbCnc = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " & "Data Source=" & fileName)
            dbAdp = New OleDbDataAdapter(strSQL, dbCnc)
            dbAdp.MissingSchemaAction = MissingSchemaAction.AddWithKey

            dbAdp.Fill(table)

            Return table

        Catch ex As Exception
            MessageBox.Show("DBからのテーブルデータ取得に失敗しました。" & vbLf &
                            ex.Message, toolName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            dbCnc.Close()
            dbAdp.Dispose()
        End Try
    End Function

#End Region

#Region "テーブルレコード取得処理"

    Public Function getTableRecord(ByVal strSQL As String) As String

        Dim rtn As Object
        Dim cmd As New OleDb.OleDbCommand

        Try
            dbCnc = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " & "Data Source=" & fileName)

            cmd.CommandText = strSQL
            cmd.CommandType = CommandType.Text
            cmd.Connection = dbCnc
            dbCnc.Open()

            rtn = cmd.ExecuteScalar

            If rtn Is DBNull.Value Then
                rtn = ""
            End If

            Return rtn
        Catch ex As Exception
            MessageBox.Show("DBからのテーブルレコード取得に失敗しました。" & vbLf &
                            ex.Message, toolName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            dbCnc.Close()
        End Try
    End Function
#End Region

#Region "テーブル情報変更処理"
    Public Function runSQL(strSQL As String) As Boolean

        '' テーブル情報の変更
        Dim checkFlg As Boolean

        Dim dbCnc As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " & "Data Source=" & fileName)
        Dim cmd As OleDbCommand = dbCnc.CreateCommand

        Try

            cmd.CommandText = strSQL

            dbCnc.Open()
            cmd.ExecuteNonQuery()
            checkFlg = True

        Catch ex As Exception
            MessageBox.Show("テーブル情報変更処理に失敗しました。" & vbLf &
                        ex.Message, toolName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            dbCnc.Close()
        End Try

        Return checkFlg
    End Function
#End Region

#Region "Dispose処理"

    Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
        Try
            If dbAdp Is Nothing Then
            Else
                dbAdp.Dispose()
                dbAdp = Nothing
            End If

            If dbCnc Is Nothing Then
            Else
                dbCnc.Dispose()
                dbCnc = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Dispose処理に失敗しました。" & vbLf &
                            ex.Message, toolName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class
