Class MainWindow
    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        image1.Visibility = Visibility.Visible
        image2.Visibility = Visibility.Hidden
        image3.Visibility = Visibility.Hidden
        chargerlabel.Visibility = Visibility.Visible
        gt40label.Visibility = Visibility.Hidden
        cobralabel.Visibility = Visibility.Hidden
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        image1.Visibility = Visibility.Hidden
        image2.Visibility = Visibility.Visible
        image3.Visibility = Visibility.Hidden
        chargerlabel.Visibility = Visibility.Hidden
        gt40label.Visibility = Visibility.Hidden
        cobralabel.Visibility = Visibility.Visible
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        image1.Visibility = Visibility.Hidden
        image2.Visibility = Visibility.Hidden
        image3.Visibility = Visibility.Visible
        chargerlabel.Visibility = Visibility.Hidden
        gt40label.Visibility = Visibility.Visible
        cobralabel.Visibility = Visibility.Hidden
    End Sub
End Class
