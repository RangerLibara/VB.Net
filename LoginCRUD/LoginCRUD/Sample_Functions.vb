Imports System.Data.Odbc
Public Class Sample_Functions
    Private conn As New OdbcConnection("DSN=storage")

    Private dta As New sample_dataset
    Public Sub retrieveData(dgv As DataGridView)

        Try
            conn.Open()
            Dim sqlTxt As String = "SELECT ti.item_id, ti.item_code, ti.item_name, ti.price, tit.item_type_name, ts.supplier_name, tc.currency
                                    FROM tbl_items ti, tbl_item_types tit, tbl_suppliers ts, tbl_currencies tc
                                    WHERE ti.item_type_id = tit.item_type_id AND 
                                    ti.supplier_id = ts.supplier_id  AND ti.currency_id = tc.currency_id 
                                    ORDER BY item_id"
            Dim adp As New OdbcDataAdapter(sqlTxt, conn)
            dta.Tables("tbl_data").Clear()
            adp.Fill(dta.Tables("tbl_data"))
            conn.Close()
            dgv.DataSource = dta.Tables("tbl_data")
            dgv.Refresh()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try
    End Sub
    'insert combobox item types
    Public Sub GetProductTypes1(cmb As ComboBox)
        Try
            conn.Open()
            Dim queryStr As String = "Select * from tbl_item_types "

            Dim adp As New OdbcDataAdapter(queryStr, conn)
            dta.Tables("tbl_item_types").Clear()
            adp.Fill(dta.Tables("tbl_item_types"))

            conn.Close()
            cmb.DataSource = dta.Tables("tbl_item_types")

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
            dta.Tables("tbl_suppliers").Clear()
            adp.Fill(dta.Tables("tbl_suppliers"))

            conn.Close()
            cmb.DataSource = dta.Tables("tbl_suppliers")

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
            dta.Tables("tbl_currencies").Clear()
            adp.Fill(dta.Tables("tbl_currencies"))

            conn.Close()
            cmb.DataSource = dta.Tables("tbl_currencies")

            cmb.Refresh()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try

    End Sub



    'Insert row in a table
    Public Sub insert_item(itemCode As String, itemName As String, price As Double, itemType As Integer, Supplier As Integer, Currency As Integer)
        Try
            conn.Open()
            Dim sqlQuery As String = "INSERT INTO tbl_items (item_code, item_name, price, item_type_id, supplier_id, currency_id) VALUES(?, ?, ?, ?, ?, ?)"

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
    'update/ edit function

    Public Sub update_item(itemCode As String, itemName As String, price As Double, itemType As Integer, Supplier As Integer, Currency As Integer, id As String)
        Try
            conn.Open()
            Dim sqlQuery As String = "UPDATE tbl_items SET item_code = ?, item_name = ?, 
                           price = ?, item_type_id = ?, supplier_id = ?, currency_id = ? WHERE item_id = ? "

            Dim cmd As New OdbcCommand(sqlQuery, conn)
            'field
            cmd.Parameters.Add("@field1", OdbcType.VarChar, 3000).Value = itemCode
            cmd.Parameters.Add("@field2", OdbcType.VarChar, 3000).Value = itemName
            cmd.Parameters.Add("@field3", OdbcType.Double).Value = price
            cmd.Parameters.Add("@field4", OdbcType.Int, 11).Value = itemType
            cmd.Parameters.Add("@field5", OdbcType.Int, 11).Value = Supplier
            cmd.Parameters.Add("@field6", OdbcType.Int, 11).Value = Currency
            cmd.Parameters.Add("@field7", OdbcType.Int).Value = id
            'execute UPDATE command
            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try

    End Sub

    'delete function
    Public Sub delete_item(id As String)
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
    'login function
    Public Function LoginUser(uname As String, pass As String)

        Dim dtasrc = Nothing
        Try
            conn.Open()
            Dim query = "SELECT u.user_id, u.username, u.password, ut.usertype_name, u.usertype_id FROM tbl_users u, 
                         tbl_usertypes ut WHERE u.usertype_id = ut.usertype_id AND u.username = ? AND u.password = ?"

            Dim cmd As New OdbcCommand(query, conn)

            cmd.Parameters.Add("@field1", OdbcType.VarChar, 3000).Value = uname
            cmd.Parameters.Add("@field2", OdbcType.VarChar, 3000).Value = pass

            Dim adp As New OdbcDataAdapter
            adp.SelectCommand = cmd
            dta.Tables("userslogin").Clear()

            adp.Fill(dta.Tables("userslogin"))
            conn.Close()

            dtasrc = dta.Tables("userslogin")
        Catch ex As Exception
            conn.Close()
            Console.WriteLine(ex.Message)
        End Try
        Return dtasrc
    End Function

    'Add User row in a table for registration
    Public Sub Add_User(username As String, password As String, ut_id As Integer)
        Try
            conn.Open()
            Dim sqlQuery As String = "INSERT INTO tbl_users (username, password, usertype_id) VALUES(?, ?, 3)"

            Dim cmd As New OdbcCommand(sqlQuery, conn)
            'field
            cmd.Parameters.Add("@field1", OdbcType.VarChar, 3000).Value = username
            cmd.Parameters.Add("@field2", OdbcType.VarChar, 3000).Value = password

            'execute insert command
            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try

    End Sub
    'retrieve data users
    Public Sub retrieveDataUsers(dgv As DataGridView)

        Try
            conn.Open()
            Dim sqlTxt As String = "SELECT u.user_id, u.username, u.password, ut.usertype_name FROM tbl_users u, tbl_usertypes ut
                                    WHERE u.usertype_id = ut.usertype_id"
            Dim adp As New OdbcDataAdapter(sqlTxt, conn)
            dta.Tables("tbl_data").Clear()
            adp.Fill(dta.Tables("tbl_data"))
            conn.Close()
            dgv.DataSource = dta.Tables("tbl_data")
            dgv.Refresh()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try
    End Sub

    'Insert new users in a table through Admin
    Public Sub insert_User(username As String, password As String, usertype_id As Integer)
        Try
            conn.Open()
            Dim sqlQuery As String = "INSERT INTO tbl_users (username, password, usertype_id) VALUES(?, ?, ?)"

            Dim cmd As New OdbcCommand(sqlQuery, conn)
            'field
            cmd.Parameters.Add("@field1", OdbcType.VarChar, 3000).Value = username
            cmd.Parameters.Add("@field2", OdbcType.VarChar, 3000).Value = password
            cmd.Parameters.Add("@field3", OdbcType.Int, 11).Value = usertype_id

            'execute insert command
            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try

    End Sub

    'insert user type combobox
    Public Sub getusertypes(cmb As ComboBox)
        Try
            conn.Open()
            Dim queryStr As String = "Select * from tbl_usertypes "

            Dim adp As New OdbcDataAdapter(queryStr, conn)
            dta.Tables("tbl_usertypes").Clear()
            adp.Fill(dta.Tables("tbl_usertypes"))

            conn.Close()
            cmb.DataSource = dta.Tables("tbl_usertypes")

            cmb.Refresh()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try

    End Sub

    'update/ edit function for users

    Public Sub update_user(username As String, password As String, usertype_id As Integer, user_id As Integer)
        Try
            conn.Open()
            Dim sqlQuery As String = "UPDATE tbl_users SET username = ?, password = ?, 
                           usertype_id = ? WHERE user_id = ? "

            Dim cmd As New OdbcCommand(sqlQuery, conn)
            'field
            cmd.Parameters.Add("@field1", OdbcType.VarChar, 3000).Value = username
            cmd.Parameters.Add("@field2", OdbcType.VarChar, 3000).Value = password
            cmd.Parameters.Add("@field3", OdbcType.Int, 11).Value = usertype_id
            cmd.Parameters.Add("@field7", OdbcType.Int).Value = user_id
            'execute UPDATE command
            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            conn.Close()
        End Try

    End Sub

    'delete function for user
    Public Sub delete_user(id As String)
        Try
            conn.Open()
            Dim sqlQuery As String = "DELETE From tbl_users WHERE user_id = ? "

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
