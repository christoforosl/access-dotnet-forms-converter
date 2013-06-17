
Public Class AccessToDotNetCombo
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String

        'Dim cbpo As Access.ComboBox = CType(Me.accessControl, Access.ComboBox)

        Return MyBase.getControlLayoutCode() & _
            vbCrLf & "me." & dotNetInstanceName & ".RowSourceType = """ & Me.accessControl.RowSourceType & """" & _
            vbCrLf & "me." & dotNetInstanceName & ".RowSource = """ & _
                Replace(Me.accessControl.RowSource, """", "'") & _
                """" & vbCrLf

    End Function


End Class
Public Class AccessToDotNetListbox
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String

        ' Dim cbpo As Access.ListBox = CType(Me.accessControl, Access.ListBox)

        Return MyBase.getControlLayoutCode() & _
            vbCrLf & "me." & dotNetInstanceName & ".RowSourceType = """ & Me.accessControl.RowSourceType & """" & _
            vbCrLf & "me." & dotNetInstanceName & ".RowSource = """ & _
                Replace(Me.accessControl.RowSource, """", "'") & _
                """" & vbCrLf

    End Function


End Class