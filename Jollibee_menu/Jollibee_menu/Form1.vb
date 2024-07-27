Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Label2.Text = "1-pc. Chickenjoy w/ Fries"
        Label3.Text = "1-pc. Chickenjoy w/Jolly Spagh."
        Label4.Text = "1-pc. Chickenjoy w/ Burger Steak"
        Label5.Text = "1-pc. Chickenjoy"
        Label6.Text = "2-pc. Chickenjoy "
        Label1.Text = "Beef Tapa"
        Label7.Text = "Corned Beef"
        Label8.Text = "Longganisa"
        Label9.Text = "Bacon, Egg, & Cheese Sandwich "
        Label10.Text = "Bacon, Egg, & Cheese Pancake Sandwich"
        Label11.Text = "8-pc. Burger Steak"
        Label12.Text = "6-pc. Burger Steak"
        Label13.Text = "1-pc. Chcknjy w/ Bur. Stk. & Half Spag."
        Label14.Text = "1-pc. Burger Steak w/ Fries"
        Label15.Text = "2-pc. Burger Steak"
        Label18.Text = "Aloha Champ"
        Label19.Text = "Double AAC jr. w/ Bacon"
        Label20.Text = "Champ JR."
        Label21.Text = "Bacon Cheese Yumburger"
        Label22.Text = "Cheesy Yumburger"
        Label23.Text = "Fries Bucket"
        Label24.Text = "Macaroni Soup"
        Label25.Text = "Jolly Fries"
        Label26.Text = "Extra Rice"
        Label27.Text = "Extra 2.5oz Gravy"
        Label28.Text = "1L Coca-Cola"
        Label29.Text = "Iced Tea"
        Label30.Text = "Coke Zero"
        Label31.Text = "Sprite"
        Label32.Text = "Coffee"

        Label33.Text = "Cost:"
        Label34.Text = "Change:"
        Label35.Text = ""



        Label17.Text = "Total: "

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Items.Add("2-pc. Chickenjoy w/Drink")
        ListBox2.Items.Add("Php 163.00")

        TextBox2.Text = Val(TextBox2.Text) + 163
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add("1-pc. Chickenjoy w/Fries & Drink")
        ListBox2.Items.Add("Php 123.00")

        TextBox2.Text = Val(TextBox2.Text) + 123
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Add("1-pc. Chickenjoy w/Jolly Spag.")
        ListBox2.Items.Add("Php 135.00")

        TextBox2.Text = Val(TextBox2.Text) + 135
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Add("1-pc. Chickenjoy w/Burger Steak & Drink")
        ListBox2.Items.Add("Php 140.00")

        TextBox2.Text = Val(TextBox2.Text) + 140
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Add("1-pc. Chickenjoy w/ Drink")
        ListBox2.Items.Add("Php 82.00")

        TextBox2.Text = Val(TextBox2.Text) + 82
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add("Beef Tapa")
        ListBox2.Items.Add("Php 158.00")

        TextBox2.Text = Val(TextBox2.Text) + 158
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox1.Items.Add("Corned Beef")
        ListBox2.Items.Add("Php 158.00")

        TextBox2.Text = Val(TextBox2.Text) + 158
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ListBox1.Items.Add("Longganisa")
        ListBox2.Items.Add("Php 158.00")

        TextBox2.Text = Val(TextBox2.Text) + 158
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ListBox1.Items.Add("Bacon, Egg, Cheese Sandwich")
        ListBox2.Items.Add("Php 91.00")

        TextBox2.Text = Val(TextBox2.Text) + 91
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListBox1.Items.Add("Bacon, Egg, Cheese Pancake Sandwich")
        ListBox2.Items.Add("Php 96.00")

        TextBox2.Text = Val(TextBox2.Text) + 96
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ListBox1.Items.Add("8-pc. Burger Steak")
        ListBox2.Items.Add("Php 450.00")

        TextBox2.Text = Val(TextBox2.Text) + 450
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ListBox1.Items.Add("6-pc. Burger Steak")
        ListBox2.Items.Add("Php 348.00")

        TextBox2.Text = Val(TextBox2.Text) + 348
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ListBox1.Items.Add("1-pc. Chickenjoy Bur. Stk. & Half Spag. w/Drink")
        ListBox2.Items.Add("Php 211.00")

        TextBox2.Text = Val(TextBox2.Text) + 211
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ListBox1.Items.Add("1-pc. Burger Steak w/Fries")
        ListBox2.Items.Add("Php 122.00")

        TextBox2.Text = Val(TextBox2.Text) + 122
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ListBox1.Items.Add("2-pc. Burger Steak")
        ListBox2.Items.Add("Php 117.00")

        TextBox2.Text = Val(TextBox2.Text) + 117
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ListBox1.Items.Add("Aloha Champ")
        ListBox2.Items.Add("Php 239.00")

        TextBox2.Text = Val(TextBox2.Text) + 239
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        ListBox1.Items.Add("Double AAC jr. w/Bacon")
        ListBox2.Items.Add("Php 112.00")

        TextBox2.Text = Val(TextBox2.Text) + 112
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        ListBox1.Items.Add("Champ jr.")
        ListBox2.Items.Add("Php 96.00")

        TextBox2.Text = Val(TextBox2.Text) + 96
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ListBox1.Items.Add("Bacon Cheese Yumburger")
        ListBox2.Items.Add("Php 91.00")

        TextBox2.Text = Val(TextBox2.Text) + 91
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        ListBox1.Items.Add("Cheesy Yumbuger")
        ListBox2.Items.Add("Php 66.00")

        TextBox2.Text = Val(TextBox2.Text) + 66
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        ListBox1.Items.Add("Fries Bucket")
        ListBox2.Items.Add("Php 158.00")

        TextBox2.Text = Val(TextBox2.Text) + 158
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        ListBox1.Items.Add("Macaroni Soup")
        ListBox2.Items.Add("Php 69.00")

        TextBox2.Text = Val(TextBox2.Text) + 69
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        ListBox1.Items.Add("Jolly Fries")
        ListBox2.Items.Add("Php 48.00")

        TextBox2.Text = Val(TextBox2.Text) + 48
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        ListBox1.Items.Add("Extra Rice")
        ListBox2.Items.Add("Php 32.00")

        TextBox2.Text = Val(TextBox2.Text) + 32
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        ListBox1.Items.Add("Extra 2.5oz Gravy")
        ListBox2.Items.Add("Php 27.00")

        TextBox2.Text = Val(TextBox2.Text) + 27
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        ListBox1.Items.Add("1L Coca-Cola")
        ListBox2.Items.Add("Php 91.00")

        TextBox2.Text = Val(TextBox2.Text) + 91
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        ListBox1.Items.Add("Iced Tea")
        ListBox2.Items.Add("Php 64.00")

        TextBox2.Text = Val(TextBox2.Text) + 64
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        ListBox1.Items.Add("Coke Zero")
        ListBox2.Items.Add("Php 53.00")

        TextBox2.Text = Val(TextBox2.Text) + 53
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        ListBox1.Items.Add("Sprite")
        ListBox2.Items.Add("Php 53.00")

        TextBox2.Text = Val(TextBox2.Text) + 53
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        ListBox1.Items.Add("Coffee")
        ListBox2.Items.Add("Php 44.00")

        TextBox2.Text = Val(TextBox2.Text) + 44.0
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim Cost As Integer = (TextBox1.Text)
        Dim Total As Integer = (TextBox2.Text)


        Label35.Text = Cost - Total
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Label35.Text = ""
    End Sub
End Class
