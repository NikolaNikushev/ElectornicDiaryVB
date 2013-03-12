Imports System.Net.Mail
Imports System.Math
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
                Dim lines() As String = reader.ReadToEnd.Split(vbCrLf)
                If condition = "grade" Then
                    For i = 0 To lines.Length - 1
                        If lines(i).Length > 5 Then
                            Dim linesTrimmed As String = lines(i).Substring(0, 2)
                            linesTrimmed = linesTrimmed.Trim()
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
                                If Not (keyword = "") Then
                                    locationToLoadAt.Items.Add(keyword)
                                End If
                                Exit For
                            End If
                        Next
                    Next
                End If
                If condition = "remark" Then
                    Dim linesCombine As String = ""
                    For index = 0 To lines.Length - 1
                        If lines(index).IndexOf(" _ ") > 0 Then
                            linesCombined += lines(index).Substring(0, lines(index).IndexOf(" _ ")) + vbCrLf
                        End If
                    Next
                    locationToLoadAt.Text = linesCombined
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
            Dim writingText As String = " "
            While Not (constants.grades.Contains(Val(writingText)) Or writingText = "")
                writingText = InputBox("Моля въведете оценка ( 2, 3, 4, 5, 6 )", "Въвеждане на Оценка")
            End While
            If Not (writingText = "") Then
                summary.summaryView.Items.Add("Добавенa оценка на Номер " & studentNumber & " по " & StudentGrades.labelCurrentSubject.Text & ":" & writingText)
                list.Items.Add(writingText)
            End If
        End If

        'Отсъствия
        If condition = "absence" Then
            Dim writingText As String = " "
            While Not (constants.absence.Contains(writingText))
                writingText = InputBox("Моля въведете вид на отсъствието ( 1/3 , 'пълно' )", "Въвеждане на Отсъствие")
                writingText = writingText.ToLower()
            End While
            If Not (writingText = "") Then

                list.Items.Add(writingText)
                summary.summaryView.Items.Add("Добавено отсъствие на Номер " & studentNumber & " по " & StudentGrades.labelCurrentSubject.Text & ":" & writingText)
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
            If Not (list.Text = "") Then
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
        End If
    End Sub

    'Сменя задният цвят на формата
    Public Shared Sub BackColor(ByVal form As Windows.Forms.Form, ByVal color As Object)
        form.BackColor = color
    End Sub
    'Изпраща мейл на съответните лица
    Public Shared Sub SendMail(ByVal messageInfo As String, ByVal YourMail As String, ByVal toWho As String, ByVal Subject As String, ByVal YourPassword As String)

        Dim messageInformation, smptHost, mailedInfo() As Object
        smptHost = "smtp.gmail.com"
        messageInformation = messageInfo
        mailedInfo = toWho.Split(",")
        Dim send As Boolean = False

        For Each item As String In mailedInfo
            If item = "" Or item = " " Then
                Exit For
            End If

            Try
                Dim yourMessage As New MailMessage()
                Dim smtp As New SmtpClient(smptHost)
                yourMessage = New MailMessage()


                yourMessage.From = New MailAddress(YourMail) 'От кого е писмото
                yourMessage.To.Add(item)  'До кого е писмото
                yourMessage.Subject = Subject 'Темата на писмото
                yourMessage.Body = messageInfo 'Съдържанието на писмото

                'Информация на протокола за това, къде да бъде изпратено съобщението по порт и да бъдат изпратени данните за потребителя на изпращача. 

                smtp.Port = 587 'Дефаутен порт за gmail, за съжаление при другите мейлове дава грешка и в момента има възможност само от gmail да се пращат писма.
                smtp.EnableSsl = True
                smtp.Credentials = New Net.NetworkCredential(YourMail, YourPassword) 'Проверка на потребител и парола за пощата.

                smtp.Send(yourMessage)
                send = True

            Catch ex As Exception
                'При грешка извежда следното съобщение
                MsgBox("Невалидна информация! Сверете и изпратете пак! До ( " + item + " )")
                Exit For
            End Try
        Next
        If send Then
            MsgBox("Съобщение изпратено!")
            functions.ShowFormHideCurrent(message, StudentSelection)
        End If

    End Sub

    'Пресмята средният успех по предмет
    Public Shared Sub AverageGrade(ByVal list As ListView, ByVal showDetailsAt As Label)
        Dim counter As Integer = 0
        Dim sumGrades As Double = 0
        For Each item As Object In list.Items
            counter += 1
            sumGrades += item.text

        Next
        If sumGrades < 2 Then
            sumGrades = 0
            showDetailsAt.Text = sumGrades
        Else
            showDetailsAt.Text = (Double.Parse(sumGrades / counter)).ToString("0.00")
        End If


    End Sub

    'Пресмята общият брой отсъствия

    Public Shared Sub AbsenceSum(ByVal list As ListView, ByVal showDetailsAt As Label)

        Dim sum As Integer = 0
        Dim counterThirds As Integer = 0
        For Each item As Object In list.Items
            If item.text = "пълно" Then
                sum += 1
            End If
            If item.text = "1/3" Then
                counterThirds += 1
            End If

        Next

        Dim fulls As Double = 0
        Dim thirds As Integer = 0
        fulls = counterThirds Mod 3

        fulls = (Truncate(counterThirds / 3))

        thirds = counterThirds Mod 3
        If fulls > 0 Then
            sum += fulls
        End If
        If thirds > 0 Then
            showDetailsAt.Text = sum & " " & thirds & "/" & "3"
        Else : showDetailsAt.Text = sum
        End If

    End Sub

    'Намира средният успех на ученикът по всички предмети
    Public Shared Sub GetAverage(ByVal studentNumber As Object, ByVal currentSubject As Object, ByVal gradeList As Object, ByVal subjectList As Object, ByVal averageScore As Object)
        Dim directory As String

        directory = studentNumber.Text & "_" & currentSubject.Text

        Dim sum As Double = 0
        For index = 1 To subjectList.Items.Count
            directory = studentNumber.Text & "_" & index.ToString()
            functions.ReadFile(directory, "studentGrades.txt", gradeList, "grade")
            functions.AverageGrade(gradeList, averageScore)
            sum += Val(averageScore.Text)

        Next

        sum /= subjectList.Items.Count
        averageScore.Text = sum.ToString("0.00")
    End Sub

End Class
