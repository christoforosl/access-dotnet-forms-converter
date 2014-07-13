Public Class AccessToDotDatagridConverter
    Inherits AccessToDotNetControl

    Public Overrides ReadOnly Property dotNetType As String
        Get
            Return "System.Windows.Forms.DataGridView"
        End Get
    End Property
End Class
