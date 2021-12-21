Public Class Form1

    Dim pro As String
    Dim qty As Integer
    Dim price As Double
    Dim netamt As Double = 0
    Const order As String = "{0,-20}{1,-20}{2,-20}{3,-20}"
    Const orderinfo As String = "{0,-30}{1,-30}{2,-30}{3,-30}"
    Dim total As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ComboBox2.SelectedItem = "TEA"
        ComboBox1.SelectedItem = "1"


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pro = ComboBox2.Text
        qty = Conversion.Val(ComboBox1.Text)


        Select Case pro
            Case "TEA"
                price = 10
            Case "COFFEE"
                price = 15
            Case "BOOST"
                price = 12
            Case "BADAM MILK"
                price = 12
            Case Else
                price = 0
        End Select


        total = qty * price
        netamt += total
        ListBox1.Items.Add(String.Format(orderinfo, pro, qty, price, total))
        Label4.Text = netamt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ListBox1.Items.Remove(ListBox1.SelectedItem.ToString)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub
End Class
