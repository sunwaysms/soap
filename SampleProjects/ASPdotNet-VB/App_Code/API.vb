Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Web.Script.Serialization

Public Class API

    ''' <summary>
    ''' Send Array 
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <param name="RecipientNumber">Send SMS to this numbers</param>
    ''' <param name="Message">Text of your SMS</param>
    ''' <param name="SpecialNumber">Your Special number ,send sms from this number</param>
    ''' <param name="IsFlash">True/False</param>
    ''' <param name="CheckingMessageID">Your local ID for message</param>
    ''' <returns>MessageID for each SMS</returns>
    Public Shared Function SendArray(UserName As String, Password As String, RecipientNumber As String(), Message As String, SpecialNumber As String, IsFlash As Boolean, _
        CheckingMessageID As Long()) As Long()
        Using SMSService As New SOAP.SMS()
            Return SMSService.SendArray(UserName, Password, RecipientNumber, Message, SpecialNumber, IsFlash, _
                CheckingMessageID)
        End Using
    End Function

    ''' <summary>
    ''' Send Array Schedule
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <param name="RecipientNumber">Send SMS to this numbers</param>
    ''' <param name="Message">Text of your SMS</param>
    ''' <param name="SpecialNumber"></param>
    ''' <param name="IsFlash">True/False</param>
    ''' <param name="Year">int</param>
    ''' <param name="Month">int</param>
    ''' <param name="Day">int</param>
    ''' <param name="Hour">int</param>
    ''' <param name="Minute">int</param>
    ''' <returns>MessageID</returns>
    Public Shared Function SendArraySchedule(UserName As String, Password As String, RecipientNumber As String(), Message As String, SpecialNumber As String, IsFlash As Boolean, _
        Year As Integer, Month As Integer, Day As Integer, Hour As Integer, Minute As Integer) As Long
        Using SMSService As New SOAP.SMS()
            Return SMSService.SendArraySchedule(UserName, Password, RecipientNumber, Message, SpecialNumber, IsFlash, _
                Year, Month, Day, Hour, Minute)
        End Using
    End Function

    ''' <summary>
    ''' Get Message ID
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <param name="CheckingMessageID">Your local ID for message</param>
    ''' <returns>MessageIDs</returns>
    Public Shared Function GetMessageID(UserName As String, Password As String, CheckingMessageID As Long()) As Long()
        Using SMSService As New SOAP.SMS()
            Return SMSService.GetMessageID(UserName, Password, CheckingMessageID)
        End Using
    End Function


    ''' <summary>
    ''' Get Message Status
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <param name="MessageID">long[] MessageIDs</param>
    ''' <returns></returns>
    Public Shared Function GetMessageStatus(UserName As String, Password As String, MessageID As Long()) As Long()
        Using SMSService As New SOAP.SMS()
            Return SMSService.GetMessageStatus(UserName, Password, MessageID)
        End Using
    End Function

    ''' <summary>
    ''' Get Number Group Data
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <returns>NumberGroupItem</returns>
    Public Shared Function GetNumberGroupData(UserName As String, Password As String) As SOAP.NumberGroupItem()
        Using SMSService As New SOAP.SMS()
            Return SMSService.GetNumberGroupData(UserName, Password)
        End Using
    End Function

    ''' <summary>
    ''' Send To Group Number
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <param name="NumberGroupID">long[] GroupIDs</param>
    ''' <param name="Message">Text of your SMS</param>
    ''' <param name="SpecialNumber">Your Special number ,send sms from this number</param>
    ''' <param name="IsFlash">True/False</param>
    ''' <param name="DontSendToRepeatedNumber">True/False</param>
    ''' <returns>SendID for Send To Group</returns>
    Public Shared Function SendNumberGroup(UserName As String, Password As String, NumberGroupID As Long(), Message As String, SpecialNumber As String, IsFlash As Boolean, _
        DontSendToRepeatedNumber As Boolean) As Long
        Using SMSService As New SOAP.SMS()
            Return SMSService.SendNumberGroup(UserName, Password, NumberGroupID, Message, SpecialNumber, IsFlash, _
                DontSendToRepeatedNumber)
        End Using
    End Function

    ''' <summary>
    ''' Send Number Group Schedule
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <param name="NumberGroupID">long[] GroupIDs</param>
    ''' <param name="Message">Text of your SMS</param>
    ''' <param name="SpecialNumber">Your Special number ,send sms from this number</param>
    ''' <param name="IsFlash">True/False</param>
    ''' <param name="DontSendToRepeatedNumber">True/False</param>
    ''' <param name="Year">int</param>
    ''' <param name="Month">int</param>
    ''' <param name="Day">int</param>
    ''' <param name="Hour">int</param>
    ''' <param name="Minute">int</param>
    ''' <returns>SendID for Send To Group</returns>
    Public Shared Function SendNumberGroupSchedule(UserName As String, Password As String, NumberGroupID As Long(), Message As String, SpecialNumber As String, IsFlash As Boolean, _
        DontSendToRepeatedNumber As Boolean, Year As Integer, Month As Integer, Day As Integer, Hour As Integer, Minute As Integer) As Long
        Using SMSService As New SOAP.SMS()
            Return SMSService.SendNumberGroupSchedule(UserName, Password, NumberGroupID, Message, SpecialNumber, IsFlash, _
                DontSendToRepeatedNumber, Year, Month, Day, Hour, Minute)
        End Using
    End Function

    ''' <summary>
    ''' Insert Number To PhoneBook
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <param name="NumberGroupID">long GroupID</param>
    ''' <param name="PersonNumber">Array of String </param>
    ''' <param name="PersonName">Array of String </param>
    ''' <returns>Array of long </returns>
    Public Shared Function InsertNumberInNumberGroup(UserName As String, Password As String, NumberGroupID As Long, PersonNumber As String(), PersonName As String()) As Long()
        Using SMSService As New SOAP.SMS()
            Return SMSService.InsertNumberInNumberGroup(UserName, Password, NumberGroupID, PersonNumber, PersonName)
        End Using
    End Function

    ''' <summary>
    ''' Get Inbox Message
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <param name="NumberOfMessage">Int Number of message</param>
    ''' <returns>InboxItem</returns>
    Public Shared Function GetInboxMessage(UserName As String, Password As String, NumberOfMessage As Integer) As SOAP.InboxItem()
        Using SMSService As New SOAP.SMS()
            Return SMSService.GetInboxMessage(UserName, Password, NumberOfMessage)
        End Using
    End Function

    ''' <summary>
    ''' Get Inbox Message With SpecialNumber
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <param name="NumberOfMessage">Int Number of message</param>
    ''' <param name="SpecialNumber">Your Special number ,send sms from this number</param>
    ''' <returns>InboxItem</returns>
    Public Shared Function GetInboxMessageWithNumber(UserName As String, Password As String, NumberOfMessage As Integer, SpecialNumber As String) As SOAP.InboxItem()
        Using SMSService As New SOAP.SMS()
            Return SMSService.GetInboxMessageWithNumber(UserName, Password, NumberOfMessage, SpecialNumber)
        End Using
    End Function

    ''' <summary>
    ''' Get Inbox Message With Last InboxID
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <param name="NumberOfMessage">int</param>
    ''' <param name="InboxID">int</param>
    ''' <param name="IsReaded">True/False</param>
    ''' <returns>ResultInbox</returns>
    Public Shared Function GetInboxMessageWithInboxID(UserName As String, Password As String, NumberOfMessage As Integer, InboxID As Integer, IsReaded As Boolean) As SOAP.ResultInbox
        Using SMSService As New SOAP.SMS()
            Return SMSService.GetInboxMessageWithInboxID(UserName, Password, NumberOfMessage, InboxID, IsReaded)
        End Using
    End Function

    ''' <summary>
    ''' Get Account Credit
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <returns>long Credit</returns>
    Public Shared Function GetCredit(UserName As String, Password As String) As Long
        Using SMSService As New SOAP.SMS()
            Return SMSService.GetCredit(UserName, Password)
        End Using
    End Function

    ''' <summary>
    ''' Get User Info
    ''' </summary>
    ''' <param name="UserName">String</param>
    ''' <param name="Password">String</param>
    ''' <returns>ProfileInfo</returns>
    Public Shared Function GetUserInfo(UserName As String, Password As String) As SOAP.ProfileInfo
        Using SMSService As New SOAP.SMS()
            Return SMSService.GetUserInfo(UserName, Password)
        End Using
    End Function

End Class