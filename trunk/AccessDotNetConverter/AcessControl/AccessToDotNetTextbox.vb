
Public Class AccessToDotNetTextbox
    Inherits AccessToDotNetControl

    Public Overrides Function getControlLayoutCode() As String

        Dim thisCtrl As String = MyBase.getControlLayoutCode()

        If Me.accessControl.Scrollbars = 2 Then
            thisCtrl = thisCtrl & vbCrLf & "me." & dotNetInstanceName & ".Multiline = True"
        End If

        If Me.accessControl.Locked Then
            thisCtrl = thisCtrl & vbCrLf & "me." & dotNetInstanceName & ".ReadOnly = True"
        End If

        If Me.accessControl.SpecialEffect = 0 Then
            thisCtrl = thisCtrl & vbCrLf & "me." & dotNetInstanceName & ".BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle"
        End If
        If Me.accessControl.BackStyle = 0 Then
            thisCtrl = thisCtrl & vbCrLf & "me." & dotNetInstanceName & ".backcolor =me.backcolor"
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


        Return thisCtrl & vbCrLf

    End Function

    Public Overrides Function getControlInstantiationCode() As String
        Dim controlDecl As String

        If Me.accessControl.format = "Short Date" Then
            controlDecl = "me." & dotNetInstanceName & " = New CGDateTextBox" & vbCrLf
        Else
            controlDecl = MyBase.getControlInstantiationCode
        End If

        Return controlDecl
    End Function

    Public Overrides Function getControlDeclarationCode() As String
        Dim controlDecl As String

        If Me.accessControl.format = "Short Date" Then
            controlDecl = "Friend WithEvents " & dotNetInstanceName & " As CGDateTextBox" & vbCrLf
        Else
            controlDecl = MyBase.getControlDeclarationCode
        End If

        Return controlDecl

    End Function

End Class