<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NwindDataSet = New Q562431.nwindDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHireDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHomePhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtension = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReportsTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmployeesTableAdapter = New Q562431.nwindDataSetTableAdapters.EmployeesTableAdapter()
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EmployeesBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NwindDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EmployeesBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1037, 441)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.NwindDataSet
        '
        'NwindDataSet
        '
        Me.NwindDataSet.DataSetName = "nwindDataSet"
        Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmployeeID, Me.colLastName, Me.colFirstName, Me.colTitle, Me.colTitleOfCourtesy, Me.colBirthDate, Me.colHireDate, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colHomePhone, Me.colExtension, Me.colPhoto, Me.colNotes, Me.colReportsTo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colEmployeeID
        '
        Me.colEmployeeID.FieldName = "EmployeeID"
        Me.colEmployeeID.Name = "colEmployeeID"
        Me.colEmployeeID.Visible = true
        Me.colEmployeeID.VisibleIndex = 0
        '
        'colLastName
        '
        Me.colLastName.FieldName = "LastName"
        Me.colLastName.Name = "colLastName"
        Me.colLastName.Visible = true
        Me.colLastName.VisibleIndex = 1
        '
        'colFirstName
        '
        Me.colFirstName.FieldName = "FirstName"
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.Visible = true
        Me.colFirstName.VisibleIndex = 2
        '
        'colTitle
        '
        Me.colTitle.FieldName = "Title"
        Me.colTitle.Name = "colTitle"
        Me.colTitle.Visible = true
        Me.colTitle.VisibleIndex = 3
        '
        'colTitleOfCourtesy
        '
        Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
        Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
        Me.colTitleOfCourtesy.Visible = true
        Me.colTitleOfCourtesy.VisibleIndex = 4
        '
        'colBirthDate
        '
        Me.colBirthDate.FieldName = "BirthDate"
        Me.colBirthDate.Name = "colBirthDate"
        Me.colBirthDate.Visible = true
        Me.colBirthDate.VisibleIndex = 5
        '
        'colHireDate
        '
        Me.colHireDate.FieldName = "HireDate"
        Me.colHireDate.Name = "colHireDate"
        Me.colHireDate.Visible = true
        Me.colHireDate.VisibleIndex = 6
        '
        'colAddress
        '
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Visible = true
        Me.colAddress.VisibleIndex = 7
        '
        'colCity
        '
        Me.colCity.FieldName = "City"
        Me.colCity.Name = "colCity"
        Me.colCity.Visible = true
        Me.colCity.VisibleIndex = 8
        '
        'colRegion
        '
        Me.colRegion.FieldName = "Region"
        Me.colRegion.Name = "colRegion"
        Me.colRegion.Visible = true
        Me.colRegion.VisibleIndex = 9
        '
        'colPostalCode
        '
        Me.colPostalCode.FieldName = "PostalCode"
        Me.colPostalCode.Name = "colPostalCode"
        Me.colPostalCode.Visible = true
        Me.colPostalCode.VisibleIndex = 10
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        Me.colCountry.Visible = true
        Me.colCountry.VisibleIndex = 11
        '
        'colHomePhone
        '
        Me.colHomePhone.FieldName = "HomePhone"
        Me.colHomePhone.Name = "colHomePhone"
        Me.colHomePhone.Visible = true
        Me.colHomePhone.VisibleIndex = 12
        '
        'colExtension
        '
        Me.colExtension.FieldName = "Extension"
        Me.colExtension.Name = "colExtension"
        Me.colExtension.Visible = true
        Me.colExtension.VisibleIndex = 13
        '
        'colPhoto
        '
        Me.colPhoto.FieldName = "Photo"
        Me.colPhoto.Name = "colPhoto"
        Me.colPhoto.Visible = true
        Me.colPhoto.VisibleIndex = 14
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = true
        Me.colNotes.VisibleIndex = 15
        '
        'colReportsTo
        '
        Me.colReportsTo.FieldName = "ReportsTo"
        Me.colReportsTo.Name = "colReportsTo"
        Me.colReportsTo.Visible = true
        Me.colReportsTo.VisibleIndex = 16
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 441)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EmployeesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NwindDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NwindDataSet As Q562431.nwindDataSet
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesTableAdapter As Q562431.nwindDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFirstName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTitleOfCourtesy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBirthDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHireDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRegion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostalCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHomePhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtension As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhoto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReportsTo As DevExpress.XtraGrid.Columns.GridColumn

End Class
