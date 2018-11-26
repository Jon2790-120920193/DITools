Public Class DLTEdit
    Dim DataPath As String = "C:\Users\Joe\Desktop\Work\Inovatech Engineering Corp\GitHub\Project\IE-DlTools\IE-DlTools\EI-DLTool\Resources\MachineConfig.xml"
    Dim ConfigDoc As New System.Xml.XmlDocument()
    Dim CheckConfig As String
    Dim ArgConfig As String
    Dim ArgURL As String
    Dim Build As Integer

    Private Sub DLTEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigDoc.Load(DataPath)
        MachineModelTextBox.Text = DLTool_Form.SPMachineList.SelectedItem.ToString()
        HyperthermTypeTextBox.Text = DLTool_Form.HypModelList.SelectedItem.ToString()

        Dim SelectedConfig As String = MachineModelTextBox.Text & HyperthermTypeTextBox.Text

        For Each machine As System.Xml.XmlElement In ConfigDoc.DocumentElement.ChildNodes
            For Each field As System.Xml.XmlElement In machine.ChildNodes
                If field.InnerText = SelectedConfig Then
                    CheckConfig = field.InnerText
                    TkNameTextBox.Text = field.NextSibling.InnerText
                    URLTextBox.Text = field.NextSibling.NextSibling.InnerText
                    BuildTextBox.Text = Conversion.Int(field.NextSibling.NextSibling.NextSibling.InnerText)
                End If
            Next
        Next
    End Sub

    Private Sub MachineModelTextBox_TextChanged(sender As Object, e As EventArgs) Handles MachineModelTextBox.TextChanged

        Dim NewSelectedConfig As String = MachineModelTextBox.Text & HyperthermTypeTextBox.Text
        Dim CheckCount As Integer = 0

        For Each machine As System.Xml.XmlElement In ConfigDoc.DocumentElement.ChildNodes
            For Each field As System.Xml.XmlElement In machine.ChildNodes
                If field.InnerText = NewSelectedConfig Then
                    CheckCount = CheckCount + 1
                    CheckConfig = field.InnerText
                    TkNameTextBox.Text = field.NextSibling.InnerText
                    URLTextBox.Text = field.NextSibling.NextSibling.InnerText
                    BuildTextBox.Text = Conversion.Int(field.NextSibling.NextSibling.NextSibling.InnerText)
                    Exit For
                    Exit For
                End If
            Next
        Next

        If CheckCount = 0 Then
            CheckConfig = ""
            TkNameTextBox.Text = ""
            URLTextBox.Text = ""
        End If
    End Sub
End Class