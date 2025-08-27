Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Inicio

    Dim containerPanel As Panel
    Public Sub New()
        InitializeComponent()

        containerPanel = Panel1
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        containerPanel.Region = New Region(CreateRoundRectangle(containerPanel.ClientRectangle, 20))
        Me.Controls.Add(containerPanel)

    End Sub

    Private Function CreateRoundRectangle(rect As Rectangle, radius As Integer) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Sub ResizePanel()
        containerPanel.Left = (Me.ClientSize.Width - containerPanel.Width) / 2
        containerPanel.Top = (Me.ClientSize.Height - containerPanel.Height) / 2
    End Sub
End Class
