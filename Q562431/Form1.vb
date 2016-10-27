Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors

Public Class Form1
    ' https://www.devexpress.com/Support/Center/Question/Details/Q562431
    ' testing changes 1 test git 2 
    ' test changes 2
    Private column As DevExpress.XtraGrid.Columns.GridColumn

    ' testing 1 2 3


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NwindDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.NwindDataSet.Employees)
        For Each Column As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            Column.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Next

    End Sub

    Private Sub GridView1_ShowFilterPopupCheckedListBox(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.FilterPopupCheckedListBoxEventArgs) Handles GridView1.ShowFilterPopupCheckedListBox
        column = e.Column
        Dim item As CheckedListBoxItem = New CheckedListBoxItem()
        item.Description = "(Custom)"
        AddHandler e.CheckedComboBox.Popup, AddressOf OnPopup
        e.CheckedComboBox.Items.Insert(0, item)
    End Sub
    Private Sub OnPopup(ByVal sender As Object, ByVal e As EventArgs)
        Dim popupControl As IPopupControl = TryCast(sender, IPopupControl)
        Dim container As PopupContainerControl = popupControl.PopupWindow.Controls.OfType(Of PopupContainerControl)().FirstOrDefault()
        If container IsNot Nothing Then
            RemoveHandler container.Controls(0).MouseDown, AddressOf listBoxControl_MouseDown
            AddHandler container.Controls(0).MouseDown, AddressOf listBoxControl_MouseDown
        End If
    End Sub
    Private Sub listBoxControl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim control As CheckedListBoxControl = TryCast(sender, CheckedListBoxControl)
        If control.GetItemRectangle(1).Contains(e.Location) Then
            column.View.ShowCustomFilterDialog(column)
        End If
    End Sub

End Class
