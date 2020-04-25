Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D

Public Class PictureBoxService

    Private Function ResizeImage(ByVal oldImage As Image) As Image
        Dim newSize As Size = New Size(oldImage.Size.Width, oldImage.Size.Height)

        Using newImage As Bitmap = New Bitmap(newSize.Width, newSize.Height, PixelFormat.Format24bppRgb)

            Using canvas As Graphics = Graphics.FromImage(newImage)
                canvas.SmoothingMode = SmoothingMode.AntiAlias
                canvas.InterpolationMode = InterpolationMode.HighQualityBicubic
                canvas.PixelOffsetMode = PixelOffsetMode.HighQuality
                canvas.DrawImage(oldImage, New Rectangle(New Point(0, 0), newSize))

                Using m As MemoryStream = New MemoryStream()
                    newImage.Save(m, ImageFormat.Jpeg)
                    Return CType(newImage.Clone(), Image)
                End Using
            End Using
        End Using
    End Function

    Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen


        If Not Imagen Is Nothing Then
            ResizeImage(Imagen)
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Png)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

End Class
