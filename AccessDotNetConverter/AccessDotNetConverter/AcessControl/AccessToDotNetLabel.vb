
Public Class AccessToDotNetLabel
    Inherits AccessToDotNetControl

    Public Overrides ReadOnly Property dotNetType() As String
        Get
            Return IIf(String.IsNullOrEmpty(MyBase.dotNetType), "Label", MyBase.dotNetType)
        End Get

    End Property

    Public Overrides Function getControlLayoutCode() As String

        Dim thisCtrl = MyBase.getControlLayoutCode()
        thisCtrl = thisCtrl & vbCrLf & "Me." & dotNetInstanceName & ".TextAlign="

        If Me.accessControl.textalign = 2 Then 'center
            thisCtrl = thisCtrl & "System.Drawing.ContentAlignment.Middlecenter"
        ElseIf Me.accessControl.textalign = 3 Then 'right
            thisCtrl = thisCtrl & "System.Drawing.ContentAlignment.MiddleRight"
        Else
            thisCtrl = thisCtrl & "System.Drawing.ContentAlignment.MiddleLeft"
        End If

        thisCtrl = thisCtrl & vbCrLf & "Me." & dotNetInstanceName & ".Text = " & exNetText(Me.accessControl.Caption) & vbCrLf
        If Me.accessControl.ForeColor <> 0 Then
            thisCtrl = thisCtrl & vbCrLf & "Me." & dotNetInstanceName & _
                    ".forecolor = System.Drawing.ColorTranslator.FromOle(" & Me.accessControl.ForeColor & ")"
        End If


        If Me.accessControl.BackStyle <> 0 Then
            thisCtrl = thisCtrl & vbCrLf & "Me." & dotNetInstanceName & _
                ".backcolor = System.Drawing.ColorTranslator.FromOle(" & Me.accessControl.BackColor & ")"
        End If

        thisCtrl = thisCtrl & vbCrLf
        Return thisCtrl

    End Function

End Class