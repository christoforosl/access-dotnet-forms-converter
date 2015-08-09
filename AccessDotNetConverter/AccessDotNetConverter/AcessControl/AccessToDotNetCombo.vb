
Public Class AccessToDotNetCombo
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String

        'Dim cbpo As Access.ComboBox = CType(Me.accessControl, Access.ComboBox)

        Return MyBase.getControlLayoutCode() & _
            AccessConversionContext.current.LineEnding & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".RowSourceType = """ & Me.accessControl.RowSourceType & """" & _
            AccessConversionContext.current.LineEnding & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".RowSource = """ & _
                Replace(Me.accessControl.RowSource, """", "'") & _
                """" & AccessConversionContext.current.LineEnding

    End Function


End Class
Public Class AccessToDotNetListbox
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String

        ' Dim cbpo As Access.ListBox = CType(Me.accessControl, Access.ListBox)

        Return MyBase.getControlLayoutCode() & _
            AccessConversionContext.current.LineEnding & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".RowSourceType = """ & Me.accessControl.RowSourceType & """" & _
            AccessConversionContext.current.LineEnding & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".RowSource = """ & _
                Replace(Me.accessControl.RowSource, """", "'") & _
                """" & AccessConversionContext.current.LineEnding

    End Function


End Class