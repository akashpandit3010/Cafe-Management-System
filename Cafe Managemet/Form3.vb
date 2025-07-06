Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Beverages")
        ComboBox1.Items.Add("Fast Food")
        '------------------------------------------------------------------
        ComboBox2.Items.Add("----Beverages----")
        ComboBox2.Items.Add("Coffee")
        ComboBox2.Items.Add("Cold Coffee")
        ComboBox2.Items.Add("Tea")
        ComboBox2.Items.Add("Lemon Tea")
        ComboBox2.Items.Add("Lemonade")
        ComboBox2.Items.Add("Milkshake")
        ComboBox2.Items.Add("Juice")
        ComboBox4.Items.Add("-----Fast Food----")
        ComboBox4.Items.Add("Veg Burger")
        ComboBox4.Items.Add("Veg Cheese Burger")
        ComboBox4.Items.Add("Veg Sandwich")
        ComboBox4.Items.Add("Veg Grilled Sandwich")
        ComboBox4.Items.Add("Veg Pizza")
        ComboBox4.Items.Add("Veg Cheese Pizza")
        ComboBox3.Items.Add("1")
        ComboBox3.Items.Add("2")
        ComboBox3.Items.Add("3")
        ComboBox3.Items.Add("4")
        ComboBox3.Items.Add("5")
        ComboBox3.Items.Add("6")
        ComboBox3.Items.Add("7")
        ComboBox3.Items.Add("8")
        ComboBox3.Items.Add("9")
        ComboBox3.Items.Add("10")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       

        Dim obj = New Form1
        obj.Show()
        Me.Hide()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If tb1.Text = "" Then
            sr1.Text = 1
            tb1.Text = ComboBox1.SelectedItem()
        ElseIf tb2.Text = "" Then
            sr2.Text = 2
            tb2.Text = ComboBox1.SelectedItem()
        ElseIf tb3.Text = "" Then
            sr3.Text = 3
            tb3.Text = ComboBox1.SelectedItem()
        ElseIf tb4.Text = "" Then
            sr4.Text = 4
            tb4.Text = ComboBox1.SelectedItem()
        ElseIf tb5.Text = "" Then
            sr5.Text = 5
            tb5.Text = ComboBox1.SelectedItem()
        ElseIf tb6.Text = "" Then
            sr6.Text = 6
            tb6.Text = ComboBox1.SelectedItem()
        End If
        If ComboBox1.SelectedItem = "Beverages" Then
            If tb11.Text = "" Then
                tb11.Text = ComboBox2.SelectedItem()
            ElseIf tb12.Text = "" Then
                tb12.Text = ComboBox2.SelectedItem()
            ElseIf tb13.Text = "" Then
                tb13.Text = ComboBox2.SelectedItem()
            ElseIf tb14.Text = "" Then
                tb14.Text = ComboBox2.SelectedItem()
            ElseIf tb15.Text = "" Then
                tb15.Text = ComboBox2.SelectedItem()
            ElseIf tb16.Text = "" Then
                tb16.Text = ComboBox2.SelectedItem()
            End If
        ElseIf ComboBox1.SelectedItem = "Fast Food" Then
        If tb11.Text = "" Then
            tb11.Text = ComboBox4.SelectedItem()
        ElseIf tb12.Text = "" Then
            tb12.Text = ComboBox4.SelectedItem()
        ElseIf tb13.Text = "" Then
            tb13.Text = ComboBox4.SelectedItem()
        ElseIf tb14.Text = "" Then
            tb14.Text = ComboBox4.SelectedItem()
        ElseIf tb15.Text = "" Then
            tb15.Text = ComboBox4.SelectedItem()
        ElseIf tb16.Text = "" Then
            tb16.Text = ComboBox4.SelectedItem()
            End If
        End If
        '--------------------------------

        If tb31.Text = "" Then
            tb31.Text = ComboBox3.SelectedItem()
        ElseIf tb32.Text = "" Then
            tb32.Text = ComboBox3.SelectedItem()
        ElseIf tb33.Text = "" Then
            tb33.Text = ComboBox3.SelectedItem()
        ElseIf tb34.Text = "" Then
            tb34.Text = ComboBox3.SelectedItem()
        ElseIf tb35.Text = "" Then
            tb35.Text = ComboBox3.SelectedItem()
        ElseIf tb36.Text = "" Then
            tb36.Text = ComboBox3.SelectedItem()
        End If
        '-------------------------------------------------------1st
        If tb11.Text = "Coffee" Or tb11.Text = "Lemon Tea" Then
            tb21.Text = 20
        ElseIf tb11.Text = "Tea" Or tb11.Text = "Lemonade" Then
            tb21.Text = 15
        ElseIf tb11.Text = "Milkshake" Or tb11.Text = "Cold Coffee" Or tb11.Text = "Juice" Then
            tb21.Text = 35
        ElseIf tb11.Text = "Veg Burger" Or tb11.Text = "Veg Sandwich" Then
            tb21.Text = 80
        ElseIf tb11.Text = "Veg Cheese Burger" Or tb11.Text = "Veg Grilled Sandwich" Or tb11.Text = "Veg Pizza" Then
            tb21.Text = 90
        ElseIf tb11.Text = "Veg Cheese Pizza" Then
            tb21.Text = 100
        End If
        '----------------------------------------------------2nd
        If tb12.Text = "Coffee" Or tb12.Text = "Lemon Tea" Then
            tb22.Text = 20
        ElseIf tb12.Text = "Tea" Or tb12.Text = "Lemonade" Then
            tb22.Text = 15
        ElseIf tb12.Text = "Milkshake" Or tb12.Text = "Cold Coffee" Or tb12.Text = "Juice" Then
            tb22.Text = 35
        ElseIf tb12.Text = "Veg Burger" Or tb12.Text = "Veg Sandwich" Then
            tb22.Text = 80
        ElseIf tb12.Text = "Veg Cheese Burger" Or tb12.Text = "Veg Grilled Sandwich" Or tb12.Text = "Veg Pizza" Then
            tb22.Text = 90
        ElseIf tb12.Text = "Veg Cheese Pizza" Then
            tb22.Text = 100
        End If
        '----------------------------------------------------3rd
        If tb13.Text = "Coffee" Or tb13.Text = "Lemon Tea" Then
            tb23.Text = 20
        ElseIf tb13.Text = "Tea" Or tb13.Text = "Lemonade" Then
            tb23.Text = 15
        ElseIf tb13.Text = "Milkshake" Or tb13.Text = "Cold Coffee" Or tb13.Text = "Juice" Then
            tb23.Text = 35
        ElseIf tb13.Text = "Veg Burger" Or tb13.Text = "Veg Sandwich" Then
            tb23.Text = 80
        ElseIf tb13.Text = "Veg Cheese Burger" Or tb13.Text = "Veg Grilled Sandwich" Or tb13.Text = "Veg Pizza" Then
            tb23.Text = 90
        ElseIf tb13.Text = "Veg Cheese Pizza" Then
            tb23.Text = 100
        End If
        '----------------------------------------------------4th
        If tb14.Text = "Coffee" Or tb14.Text = "Lemon Tea" Then
            tb24.Text = 20
        ElseIf tb14.Text = "Tea" Or tb14.Text = "Lemonade" Then
            tb24.Text = 15
        ElseIf tb14.Text = "Milkshake" Or tb14.Text = "Cold Coffee" Or tb14.Text = "Juice" Then
            tb24.Text = 35
        ElseIf tb14.Text = "Veg Burger" Or tb14.Text = "Veg Sandwich" Then
            tb24.Text = 80
        ElseIf tb14.Text = "Veg Cheese Burger" Or tb14.Text = "Veg Grilled Sandwich" Or tb14.Text = "Veg Pizza" Then
            tb24.Text = 90
        ElseIf tb14.Text = "Veg Cheese Pizza" Then
            tb24.Text = 100
        End If
        '----------------------------------------------------5th
        If tb15.Text = "Coffee" Or tb15.Text = "Lemon Tea" Then
            tb25.Text = 20
        ElseIf tb15.Text = "Tea" Or tb15.Text = "Lemonade" Then
            tb25.Text = 15
        ElseIf tb15.Text = "Milkshake" Or tb15.Text = "Cold Coffee" Or tb15.Text = "Juice" Then
            tb25.Text = 35
        ElseIf tb15.Text = "Veg Burger" Or tb15.Text = "Veg Sandwich" Then
            tb25.Text = 80
        ElseIf tb15.Text = "Veg Cheese Burger" Or tb15.Text = "Veg Grilled Sandwich" Or tb15.Text = "Veg Pizza" Then
            tb25.Text = 90
        ElseIf tb15.Text = "Veg Cheese Pizza" Then
            tb25.Text = 100
        End If
        '----------------------------------------------------6th
        If tb16.Text = "Coffee" Or tb16.Text = "Lemon Tea" Then
            tb26.Text = 20
        ElseIf tb16.Text = "Tea" Or tb16.Text = "Lemonade" Then
            tb26.Text = 15
        ElseIf tb16.Text = "Milkshake" Or tb16.Text = "Cold Coffee" Or tb16.Text = "Juice" Then
            tb26.Text = 35
        ElseIf tb16.Text = "Veg Burger" Or tb16.Text = "Veg Sandwich" Then
            tb26.Text = 80
        ElseIf tb16.Text = "Veg Cheese Burger" Or tb16.Text = "Veg Grilled Sandwich" Or tb16.Text = "Veg Pizza" Then
            tb26.Text = 90
        ElseIf tb16.Text = "Veg Cheese Pizza" Then
            tb26.Text = 100
        End If
        tb41.Text = Val(tb31.Text) * Val(tb21.Text)
        tb42.Text = Val(tb32.Text) * Val(tb22.Text)
        tb43.Text = Val(tb33.Text) * Val(tb23.Text)
        tb44.Text = Val(tb34.Text) * Val(tb24.Text)
        tb45.Text = Val(tb35.Text) * Val(tb25.Text)
        tb46.Text = Val(tb36.Text) * Val(tb26.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox1.SelectedItem = "Beverages" Then
            ComboBox2.Visible = True
            ComboBox4.Visible = False
        ElseIf ComboBox1.SelectedItem = "Fast Food" Then
            ComboBox2.Visible = False
            ComboBox4.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        total.Text = Val(tb41.Text) + Val(tb42.Text) + Val(tb43.Text) + Val(tb44.Text) + Val(tb45.Text) + Val(tb46.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If namet.Text = "" Or phnot.Text = "" Or billnot.Text = "" Then
            MsgBox("Enter Customer Deatils Properly!!")
        Else : MsgBox("Date:" & DateTimePicker1.Value + vbCrLf + "Bill No.:" & billnot.Text + vbCrLf +
            "Customer Details" + vbCrLf + "Customer Name:" & namet.Text + vbCrLf +
            "Customer Phone No.:" & phnot.Text + vbCrLf + "Please the Bill Amount:" & total.Text)
        End If
    End Sub

End Class