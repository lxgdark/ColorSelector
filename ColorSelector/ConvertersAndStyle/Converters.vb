﻿''' <summary>
''' Конвертер для преобразования цвета в кисть
''' </summary>
Public Class ColorToBrushConverter
    Implements IValueConverter
    Public Function Convert(value As Object, targetType As Type, parameter As Object, language As String) As Object Implements IValueConverter.Convert
        Return New SolidColorBrush(value)
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, language As String) As Object Implements IValueConverter.ConvertBack
        Return CType(value, SolidColorBrush).Color
    End Function
End Class
