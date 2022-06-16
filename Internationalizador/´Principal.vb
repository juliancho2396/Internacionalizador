Public Class Form1
    Public ListaArchivos As New ArrayList
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Seleccionar_Click(sender As Object, e As EventArgs) Handles Seleccionar.Click
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
        If Not TextBox1.Text = "" Then
            Procesar.Enabled = True
        End If
    End Sub

    Private Sub Procesar_Click(sender As Object, e As EventArgs) Handles Procesar.Click
        ListaArchivos.Clear()
        RecorrerFolders(TextBox1.Text)

        MsgBox("YA")
    End Sub

    Public Sub RecorrerFolders(CarpetaRaiz As String)
        ProcesarArchivos(CarpetaRaiz)
        For Each Carpeta As String In My.Computer.FileSystem.GetDirectories(CarpetaRaiz)
            RecorrerFolders(Carpeta)
        Next
    End Sub


    Public Sub ProcesarArchivos(Carpeta As String)
        For Each Archivo In My.Computer.FileSystem.GetFiles(Carpeta)
            If Archivo.Contains(".csv") Then
                ListaArchivos.Add(Archivo)
                ProcesarArchivo(Archivo)
            End If
        Next
    End Sub

    Public Sub ProcesarArchivo(Ruta As String)
        Dim Original = New System.IO.StreamReader(Ruta)
        Dim Temporal = Original.ReadToEnd
        Dim LineasTemporal = Temporal.Split(vbCrLf)

        Original.Close()
        Dim Validado = New System.IO.StreamWriter(Ruta.Split(".csv")(0) & "_" & Date.Today.ToString("yyyyMMdd") & ".csv", False)
        For Each Linea As String In LineasTemporal
            Linea = Linea.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u").Replace("-5", "").Replace("ñ", "n")
            Linea = Linea.Replace("||", "|N/A|").Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "Ú")
            Linea = Linea.Replace(Chr(34), "").Replace(".", ",").Replace(";", "")
            Validado.WriteLine(Linea)
        Next
        Validado.Close()
    End Sub
End Class
