Module modMain

	Public Sub main()

		'Dim jsonDate = convertJsonDate("/Date(1441766131277+0800)/").ToString("dd/MM/yyyy")
		'Dim jsonDate2 = "/Date(1441766131277-0100)/"
		'Dim jsonDate3 = "/Date(1441766131277)/"

		

	End Sub

	Public Function convertJsonDate(jsonDate As String) As DateTime
		Dim x As Long, hours As Long

		If jsonDate.Contains("+") Then

			Dim inxPlus As Integer = jsonDate.IndexOf("+")
			Dim lJsonDateSubstring As String = jsonDate.Substring(6, inxPlus - 6)
			Dim hoursStr As String = jsonDate.Substring(inxPlus + 1, 4)

			x = Long.Parse(lJsonDateSubstring)
			hours = Long.Parse(hoursStr)

		ElseIf jsonDate.Contains("-") Then
			Dim inxMinus As Integer = jsonDate.IndexOf("-")
			x = Long.Parse((jsonDate.Substring(6, inxMinus - 1)))
			hours = -1 * Date.Parse(jsonDate.Substring(inxMinus)).Millisecond
		Else
			x = Long.Parse(jsonDate)
		End If

		Dim d As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0).AddMilliseconds(x).AddMilliseconds(hours)
		Return d

	End Function

End Module
