Module Module1
    Public db As New ADODB.Connection 'Variável do banco'
    Public rs As New ADODB.Recordset 'Variável da tabela'
    Public sql, diretorio As String
    Public audio As Object

    Public Sub Database_connect()
        db = CreateObject("ADODB.Connection")
        db.Open("Provider=SQLOLEDB;Data Source=192.168.5.92;Initial Catalog=cad_cliente;trusted_connection=yes;")
        MsgBox("Conectou com o banco de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "Sim")


    End Sub



End Module
