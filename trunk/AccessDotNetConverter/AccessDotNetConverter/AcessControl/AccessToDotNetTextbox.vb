
Public Class AccessToDotNetTextbox
    Inherits AccessToDotNetControl

    Private Const STR_TEXTBOX As String = "Textbox"

    Public Overrides Function getControlLayoutCode() As String

        Dim thisCtrl As String = MyBase.getControlLayoutCode()

        If Me.accessControl.BackStyle = 0 Then
            thisCtrl = thisCtrl & vbCrLf & "me." & dotNetInstanceName & ".backcolor =me.backcolor"
        End If
        If Me.dotNetType = STR_TEXTBOX Then
            If Me.accessControl.Scrollbars = 2 Then
                thisCtrl = thisCtrl & vbCrLf & "me." & dotNetInstanceName & ".Multiline = True"
            End If

            If Me.accessControl.Locked Then
                thisCtrl = thisCtrl & vbCrLf & "me." & dotNetInstanceName & ".ReadOnly = True"
            End If

            If Me.accessControl.SpecialEffect = 0 Then
                thisCtrl = thisCtrl & vbCrLf & "me." & dotNetInstanceName & ".BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle"
            End If


            thisCtrl = thisCtrl & vbCrLf & "Me." & dotNetInstanceName & ".TextAlign="
            If Me.accessControl.textalign = 2 Then 'center
                thisCtrl = thisCtrl & "HorizontalAlignment.center"
            ElseIf Me.accessControl.textalign = 3 Then 'right
                thisCtrl = thisCtrl & "HorizontalAlignment.Right"
            Else
                thisCtrl = thisCtrl & "HorizontalAlignment.Left"
            End If
            thisCtrl = thisCtrl & vbCrLf

        End If

        Return thisCtrl & vbCrLf

    End Function

    Public Overrides ReadOnly Property dotNetType As String
        Get
            If Me.accessControl.format = "Short Date" OrElse Me.accessControl.format = "Long Date" Then
                Return "DateTimePicker"
            Else
                Return STR_TEXTBOX
            End If
        End Get
    End Property

End Class