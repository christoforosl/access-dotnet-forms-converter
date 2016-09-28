
Public Class AccessToDotNetTextbox
    Inherits AccessToDotNetControl

    Private Const STR_TEXTBOX As String = "Textbox"

    Public Overrides Function getControlLayoutCode() As String

        Dim thisCtrl As String = MyBase.getControlLayoutCode()

        If Me.accessControl.BackStyle = 0 Then
			thisCtrl = thisCtrl & vbCrLf & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".BackColor =" & AccessConversionContext.current.thisOrMe & ".BackColor" & AccessConversionContext.current.LineEnding
        End If
        If Me.dotNetType = STR_TEXTBOX Then
            If Me.accessControl.Scrollbars = 2 Then
                thisCtrl = thisCtrl & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".Multiline = true" & AccessConversionContext.current.LineEnding
            End If

            If Me.accessControl.Locked Then
                thisCtrl = thisCtrl & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".ReadOnly = true" & AccessConversionContext.current.LineEnding
            End If

            If Me.accessControl.SpecialEffect = 0 Then
                thisCtrl = thisCtrl & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle" & AccessConversionContext.current.LineEnding
            End If


            thisCtrl = thisCtrl & vbCrLf & AccessConversionContext.current.thisOrMe & "." & dotNetInstanceName & ".TextAlign="
            If Me.accessControl.textalign = 2 Then 'center
                thisCtrl = thisCtrl & "HorizontalAlignment.center"
            ElseIf Me.accessControl.textalign = 3 Then 'right
                thisCtrl = thisCtrl & "HorizontalAlignment.Right"
            Else
                thisCtrl = thisCtrl & "HorizontalAlignment.Left"
            End If
            thisCtrl = thisCtrl & AccessConversionContext.current.LineEnding

        End If

        Return thisCtrl & vbCrLf

    End Function

    Public Overrides ReadOnly Property dotNetType As String
        Get
            If Me.accessControl.format = "Short Date" OrElse Me.accessControl.format = "Long Date" Then
                Return "DateTimePicker"
            Else
                Return IIf(String.IsNullOrEmpty(MyBase.dotNetType), "Textbox", MyBase.dotNetType)
            End If
        End Get
    End Property

End Class