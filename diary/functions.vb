Imports System.Net.Mail
Public Class functions

    'Скрива сегашната форма и показва следващата
    Public Shared Sub ShowFormHideCurrent(ByVal hideObject As Windows.Forms.Form, ByVal showObject As Windows.Forms.Form)
        hideObject.Hide()
        showObject.Show()
    End Sub

    'Добавя информацията към крайният отчет.
    Public Shared Sub AddToSummary(ByVal text As String, ByVal summary As Object)
        summary.Items.Add(text)
    End Sub

    'Дава стойност от променливата toWho на лабела labelToWho във формата massage.
    Public Shared Sub MassageToWho(ByVal toWho As String)
        message.labelToWho.Text = toWho

    End Sub
    'Проверява дали е избрано нещо от списъкът
    Public Shared Function CheckSelectedEntry(ByVal listSelection As Object)
        If Not (listSelection.SelectedItems.Count > 0) Then
            Return False
        End If
        If listSelection.SelectedItems(0) IsNot Nothing AndAlso listSelection.SelectedItems(0).ToString() <> "" Then
            Return True
        End If
        Return False
    End Function
    ' Подтвърждава действието на потребителя
    Public Shared Function ConfirmAction()
        Dim confirm As String
        confirm = InputBox("Моля потвърдете, като напишете 'да'", "Потвърдете действието си")
        If confirm = "да" Then
            Return True
        End If
        Return False
    End Function
    'Зарежда данни в Дневника
    Public Shared Sub ReadFile(ByVal directory As String, ByVal file As String, ByVal locationToLoadAt As Object, ByVal condition As String)
        locationToLoadAt.Clear()
        If Not (My.Computer.FileSystem.DirectoryExists(directory)) Then
            My.Computer.FileSystem.CreateDirectory(directory)
        End If
        Dim location As String
        location = directory & "\" & file

        If My.Computer.FileSystem.FileExists(location) Then
            Using reader As System.IO.TextReader = System.IO.File.OpenText(location)
                Dim lines() As String = reader.ReadToEnd.Split(vbNewLine)
                If condition = "grade" Then
                    For i = 0 To lines.Length - 1
                        If lines(i).Length > 5 Then
                            Dim linesTrimmed As String = lines(i).Substring(0, 1)
                            For Each keyword As String In constants.grades
                                If linesTrimmed = keyword Then
                                    locationToLoadAt.Items.Add(keyword)
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End If
                If condition = "absence" Then
                    For i = 0 To lines.Length - 1
                        For Each keyword As String In constants.absence
                            If lines(i).Contains(keyword) Then
                                locationToLoadAt.Items.Add(keyword)
                                Exit For
                            End If
                        Next
                    Next
                End If
                If condition = "remark" Then
                    locationToLoadAt.Text = reader.ReadToEnd
                End If
            End Using
        Else
            My.Computer.FileSystem.WriteAllText(location, "", True)
        End If
    End Sub
    ' Пише в дневника оценки или отсъствия, забележки в зависимост от бутона
    'Оценки
    Public Shared Sub WriteToDiary(ByVal condition As String, ByVal list As Object, ByVal studentNumber As Integer)
        If condition = "grade" Then
            Dim writingText As String = ""
            While Not (constants.grades.Contains(Val(writingText)))
                writingText = InputBox("Моля въведете оценка ( 2, 3, 4, 5, 6 )", "Въвеждане на Оценка")
            End While
            summary.summaryView.Items.Add("Добавенa оценка на Номер " & studentNumber & "по " & StudentGrades.labelCurrentSubject.Text & ":" & writingText)
            list.Items.Add(writingText)
        End If

        'Отсъствия
        If condition = "absence" Then
            Dim writingText As String = ""
            While Not (constants.absence.Contains(writingText))
                writingText = InputBox("Моля въведете вид на отсъствието ( 1/3 , 'пълно' )", "Въвеждане на Отсъствие")
            End While
            If Not (writingText = "") Then

                list.Items.Add(writingText)
                summary.summaryView.Items.Add("Добавено отсъствие на Номер " & studentNumber & "по " & StudentGrades.labelCurrentSubject.Text & ":" & writingText)
            End If
        End If
    End Sub
    Public Shared Sub WriteToDiarySave(ByVal condition As String, ByVal list As Object, ByVal studentLocationSubject As String)
        'Запазва всичко
        Dim saveLocation As String
        If condition = "offline-Absence" Then
            If Not (My.Computer.FileSystem.DirectoryExists(studentLocationSubject)) Then
                My.Computer.FileSystem.CreateDirectory(studentLocationSubject)
            End If
            saveLocation = studentLocationSubject & "\studentAbsence.txt"
            If My.Computer.FileSystem.FileExists(saveLocation) Then
                My.Computer.FileSystem.DeleteFile(saveLocation)
            Else
                My.Computer.FileSystem.WriteAllText(saveLocation, "", True)
            End If
            For Each itemToWrite In list.Items
                Dim text As String = itemToWrite.Text & " _ " & Date.Now & vbCrLf
                My.Computer.FileSystem.WriteAllText(saveLocation, text, True)
            Next
        End If

        If condition = "offline-Grade" Then
            If Not (My.Computer.FileSystem.DirectoryExists(studentLocationSubject)) Then
                My.Computer.FileSystem.CreateDirectory(studentLocationSubject)
            End If
            saveLocation = studentLocationSubject & "\studentGrades.txt"
            If My.Computer.FileSystem.FileExists(saveLocation) Then
                My.Computer.FileSystem.DeleteFile(saveLocation)
            Else
                My.Computer.FileSystem.WriteAllText(saveLocation, "", True)
            End If
            For Each itemToWrite In list.Items
                Dim text As String = itemToWrite.Text & " _ " & Date.Now & vbCrLf
                My.Computer.FileSystem.WriteAllText(saveLocation, text, True)
            Next
        End If

        If condition = "offline-Remark" Then
            If Not (My.Computer.FileSystem.DirectoryExists(studentLocationSubject)) Then
                My.Computer.FileSystem.CreateDirectory(studentLocationSubject)
            End If
            saveLocation = studentLocationSubject & "\studentRemark.txt"
            If My.Computer.FileSystem.FileExists(saveLocation) Then
                My.Computer.FileSystem.DeleteFile(saveLocation)
            Else
                My.Computer.FileSystem.WriteAllText(saveLocation, "", True)
            End If
            summary.summaryView.Items.Add("Забележка на Номер " & StudentGrades.labelStudentNumber.Text & " по " & StudentGrades.labelCurrentSubject.Text & ":" & list.Text)
            Dim text As String = list.Text & " _ " & Date.Now & vbCrLf
            My.Computer.FileSystem.WriteAllText(saveLocation, text, True)
        End If
    End Sub

    Public Shared Sub BackColor(ByVal form As Windows.Forms.Form, ByVal color As Object)
        form.BackColor = color
    End Sub
    'Изпраща мейл на съответните лица
    Public Shared Sub SendMail(ByVal messageInfo As Object, ByVal YourMail As String, ByVal labelToWho As String, ByVal Subject As Object, ByVal YourPassword As String)

        Dim messageInformation, smptHost, mailedInfo() As Object
        smptHost = "smtp.gmail.com"
        messageInformation = messageInfo.Text
        mailedInfo = labelToWho.Split(",")
        Dim send As Boolean = False

        For Each item As String In mailedInfo

            Try
                Dim yourMessage As New MailMessage()
                Dim smtp As New SmtpClient()
                yourMessage = New MailMessage()


                yourMessage.From = New MailAddress(YourMail) 'От кого е писмото
                yourMessage.To.Add(item)  'До кого е писмото
                yourMessage.Subject = Subject.Text 'Темата на писмото
                yourMessage.Body = messageInfo.Text 'Съдържанието на писмото

                'Информация на протокола за това, къде да бъде изпратено съобщението по порт и да бъдат изпратени данните за потребителя на изпращача. 
                smtp.Host = smptHost

                smtp.Port = 25 'Дефаутен порт за gmail, за съжаление при другите мейлове дава грешка и в момента има възможност само до gmail да се пращат писма.
                smtp.EnableSsl = True
                smtp.Credentials = New Net.NetworkCredential(YourMail, YourPassword) 'Проверка на потребител и парола за пощата.

                smtp.Send(yourMessage)
                send = True

            Catch ex As Exception
                'При грешка извежда следното съобщение
                MsgBox("Невалидна информация! Сверете и изпратете пак!")
            End Try
        Next
        If send Then
            MsgBox("Съобщение изпратено!")
        End If

    End Sub
End Class
