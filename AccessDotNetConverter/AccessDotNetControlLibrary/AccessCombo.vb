
Public Class AccessCombo

    ''' <summary>
    ''' Allow for an SQL string to be determined as the datasource
    ''' </summary>
    Private _RowSource As String

    ''' <summary>
    ''' Allow row source type specification
    ''' </summary>
    Public Property RowSourceType As String

    ''' <summary>
    ''' Allow for an SQL string to be determined as the datasource
    ''' </summary>
    Public Property RowSource() As String
        Get

            Return _RowSource
        End Get
        Set(value As String)

            _RowSource = value
            If Me.DesignMode = False Then
                If String.IsNullOrEmpty(_RowSource) = False Then
                    If Not _RowSource.ToLower.StartsWith("select") Then
                        'assume that the "rowsource" is a table name
                        _RowSource = "select * from " & _RowSource

                    End If

                    Dim d As DataTable = ModelContext.CurrentDBUtils.getDataTable(_RowSource)
                    Me.DataSource = d
                    Me.ValueMember = d.Columns(0).ColumnName

                    If Translator.current.isEnglish AndAlso d.Columns.Count > 2 Then
                        Me.DisplayMember = d.Columns(2).ColumnName
                    Else
                        Me.DisplayMember = d.Columns(1).ColumnName
                    End If

                End If
            End If

        End Set

    End Property

End Class
