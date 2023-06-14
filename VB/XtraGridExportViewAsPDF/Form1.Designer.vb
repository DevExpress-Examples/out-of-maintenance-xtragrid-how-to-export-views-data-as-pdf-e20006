Namespace XtraGridExportViewAsPDF

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.button1 = New System.Windows.Forms.Button()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New XtraGridExportViewAsPDF.nwindDataSet()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShippedDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ordersTableAdapter = New XtraGridExportViewAsPDF.nwindDataSetTableAdapters.OrdersTableAdapter()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ordersBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' button1
            ' 
            Me.button1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.button1.Location = New System.Drawing.Point(0, 313)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(595, 23)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Export As PDF"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.ordersBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(595, 313)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' ordersBindingSource
            ' 
            Me.ordersBindingSource.DataMember = "Orders"
            Me.ordersBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomerID, Me.colOrderDate, Me.colShippedDate, Me.colShipName, Me.colShipCountry})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' colCustomerID
            ' 
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.Visible = True
            Me.colCustomerID.VisibleIndex = 0
            ' 
            ' colOrderDate
            ' 
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 1
            ' 
            ' colShippedDate
            ' 
            Me.colShippedDate.FieldName = "ShippedDate"
            Me.colShippedDate.Name = "colShippedDate"
            Me.colShippedDate.Visible = True
            Me.colShippedDate.VisibleIndex = 2
            ' 
            ' colShipName
            ' 
            Me.colShipName.FieldName = "ShipName"
            Me.colShipName.Name = "colShipName"
            Me.colShipName.Visible = True
            Me.colShipName.VisibleIndex = 3
            ' 
            ' colShipCountry
            ' 
            Me.colShipCountry.FieldName = "ShipCountry"
            Me.colShipCountry.Name = "colShipCountry"
            Me.colShipCountry.Visible = True
            Me.colShipCountry.VisibleIndex = 4
            ' 
            ' ordersTableAdapter
            ' 
            Me.ordersTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(595, 336)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.button1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ordersBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private button1 As System.Windows.Forms.Button

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private nwindDataSet As XtraGridExportViewAsPDF.nwindDataSet

        Private ordersBindingSource As System.Windows.Forms.BindingSource

        Private ordersTableAdapter As XtraGridExportViewAsPDF.nwindDataSetTableAdapters.OrdersTableAdapter

        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colShippedDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipName As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipCountry As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
