Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics
Imports DevExpress.XtraGrid.Views.Grid

Namespace XtraGridExportViewAsPDF

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            ordersTableAdapter.Fill(nwindDataSet.Orders)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim View As GridView = TryCast(gridControl1.MainView, GridView)
            If View IsNot Nothing Then
                View.ExportToPdf("MainViewData.pdf")
                ' The following requires Adobe Reader to be installed on the system
                Dim pdfExport As Process = New Process()
                pdfExport.StartInfo.FileName = "AcroRd32.exe"
                pdfExport.StartInfo.Arguments = "MainViewData.pdf"
                pdfExport.Start()
            End If
        End Sub
    End Class
End Namespace
