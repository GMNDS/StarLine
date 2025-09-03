Module conexao
    Public db As New ADODB.Connection 'Variável do Banco'
    Public rs As New ADODB.Recordset 'Variável da Tabela'
    Public sql, diretorio As String
    Public count As Int64
    Public audio As Object
    Public nomeVozOpcional As String

    Sub Conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=192.168.5.93;Initial Catalog=Starline;trusted_connection=yes;")
            MsgBox("Conexão realizada com excitação", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Starline")
        Catch ex As Exception
            MsgBox("Erro na conexão" & Environment.NewLine & ex.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "SQL SERVER")

        End Try

    End Sub

    Sub Create_pass()

    End Sub

    Sub Criar_chamada(tipo As String)
        If tipo Is Nothing Then
            Throw New ArgumentNullException(NameOf(tipo))
        End If

        Try
            Dim lastId = 0
            Dim lastIdQuery = "SELECT TOP 1 ID FROM CHAMADAS WHERE TIPO = '" & tipo & "' ORDER BY ID DESC"

            rs = db.Execute(lastIdQuery)

            If Not rs.EOF Then
                lastId = CInt(rs.Fields("ID").Value)
            Else
                lastId = 0
            End If

            rs.Close()

            Dim prefix = If(tipo = "P", "PREF", "PAD")
            Dim newNumber As Integer = lastId + 1
            Dim formatNumber = prefix & newNumber.toString("D3")

            MsgBox(formatNumber, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

            Dim guiche = 2


            Dim sqlInsert = $"INSERT INTO CHAMADAS (NUMERO,GUICHE_ID,TIPO) VALUES ('{formatNumber}', '{guiche}', '{tipo}')"
            Dim rowsAffected As Integer
            db.Execute(sqlInsert, rowsAffected)


            If rowsAffected > 0 Then
                MsgBox("Inserção realizada com sucesso!" & rowsAffected)
            Else
                MsgBox("Nenhum registro inserido.")
            End If


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try



    End Sub

End Module
