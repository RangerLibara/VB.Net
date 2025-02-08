Imports System.Data.Odbc
Public Class Class1
    Private conn As New OdbcConnection("DSN=storage")

    Private DataTable As New DataSet1

    Public Sub retrieveData(dgv As DataGridView)
        Try
            conn.Open()
            Dim query As String = "select ti.item_id , ti.item_code , ti.item_name , ti.price , tit.item_type_name , ts.supplier_name , tc.currency
                                    from tbl_items ti , tbl_item_types tit , tbl_suppliers ts ,tbl_currencies tc 
                                    where ti.item_type_id = tit.item_type_id 
                                    and ti.supplier_id = ts.supplier_id 
                                    and ti.currency_id = tc.currency_id 
                                    order by ti.item_id"

            Dim adp As New OdbcDataAdapter(query, conn)
            'clear the dataset first to avoid dupicate rows
            DataTable.Tables("tbl_items").Clear()
            'fill up the data set
            adp.Fill(DataTable.Tables("tbl_items"))
            conn.Close()
            'update the datagridview
            dgv.DataSource = DataTable.Tables("tbl_items")
            dgv.Refresh()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try
    End Sub


    'ComboBox retrieve
    Public Sub getcmbdata(cmb As ComboBox)
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM tbl_item_types"

            Dim adp As New OdbcDataAdapter(query, conn)
            'clear the dataset first to avoid dupicate rows
            DataTable.Tables("tbl_item_types").Clear()
            'fill up the data set
            adp.Fill(DataTable.Tables("tbl_item_types"))
            conn.Close()
            'update the datagridview
            cmb.DataSource = DataTable.Tables("tbl_item_types")
            cmb.Refresh()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub GetProductTypes1(cmb As ComboBox)
        Try
            conn.Open()
            Dim queryStr As String = "Select * from tbl_item_types "

            Dim adp As New OdbcDataAdapter(queryStr, conn)
            DataTable.Tables("tbl_item_types").Clear()
            adp.Fill(DataTable.Tables("tbl_item_types"))

            conn.Close()
            cmb.DataSource = DataTable.Tables("tbl_item_types")

            cmb.Refresh()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try

    End Sub
    'insert combobox suppliers
    Public Sub GetProductTypes2(cmb As ComboBox)
        Try
            conn.Open()
            Dim queryStr As String = "Select * from tbl_suppliers "

            Dim adp As New OdbcDataAdapter(queryStr, conn)
            DataTable.Tables("tbl_suppliers").Clear()
            adp.Fill(DataTable.Tables("tbl_suppliers"))

            conn.Close()
            cmb.DataSource = DataTable.Tables("tbl_suppliers")

            cmb.Refresh()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try

    End Sub

    'insert combobox currency
    Public Sub GetProductTypes3(cmb As ComboBox)
        Try
            conn.Open()
            Dim queryStr As String = "Select * from tbl_currencies "

            Dim adp As New OdbcDataAdapter(queryStr, conn)
            DataTable.Tables("tbl_currencies").Clear()
            adp.Fill(DataTable.Tables("tbl_currencies"))

            conn.Close()
            cmb.DataSource = DataTable.Tables("tbl_currencies")

            cmb.Refresh()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try

    End Sub



    Public Sub insert_user(itemCode As String, itemName As String, price As Double, itemType As Integer, Supplier As Integer, Currency As Integer)
        Try
            conn.Open()
            Dim sqlQuery As String = "INSERT INTO tbl_items(item_code, item_name, price, item_type_id, supplier_id, currency_id) VALUES(?, ?, ?, ?, ?, ?)"

            Dim cmd As New OdbcCommand(sqlQuery, conn)
            'field
            cmd.Parameters.Add("@field1", OdbcType.VarChar, 3000).Value = itemCode
            cmd.Parameters.Add("@field2", OdbcType.VarChar, 3000).Value = itemName
            cmd.Parameters.Add("@field3", OdbcType.Double).Value = price
            cmd.Parameters.Add("@field4", OdbcType.Int, 11).Value = itemType
            cmd.Parameters.Add("@field5", OdbcType.Int, 11).Value = Supplier
            cmd.Parameters.Add("@field6", OdbcType.Int, 11).Value = Currency
            'execute insert command
            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try

    End Sub

    Public Sub edit_item(item_code As String, item_name As String, price As Integer,
                           type_id As Integer, supplier_id As Integer, currency_id As Integer, id As String)
        Try
            conn.Open()

            Dim sqlQuery As String = "UPDATE tbl_items set item_code=?,item_name=?,price=?,
                                     item_type_id=?,supplier_id=?,currency_id=? where item_id = ?"

            Dim cmd As New OdbcCommand(sqlQuery, conn)


            cmd.Parameters.Add("@field1", OdbcType.VarChar, 3000).Value = item_code
            cmd.Parameters.Add("@field2", OdbcType.VarChar, 3000).Value = item_name
            cmd.Parameters.Add("@field3", OdbcType.Double).Value = price
            cmd.Parameters.Add("@field4", OdbcType.Int, 11).Value = type_id
            cmd.Parameters.Add("@field5", OdbcType.Int, 11).Value = supplier_id
            cmd.Parameters.Add("@field6", OdbcType.Int, 11).Value = currency_id
            cmd.Parameters.Add("@field7", OdbcType.Int, 11).Value = id

            'execute the INSERT command
            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub delete_user(id As String)
        Try
            conn.Open()
            Dim sqlQuery As String = "DELETE From tbl_items WHERE item_id = ? "

            Dim cmd As New OdbcCommand(sqlQuery, conn)
            'field

            cmd.Parameters.Add("@field1", OdbcType.Int).Value = id
            'execute DELETE command
            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try
    End Sub

End Class