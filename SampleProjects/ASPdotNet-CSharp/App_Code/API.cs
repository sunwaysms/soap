using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public static class API {

    /// <summary>
    /// Send Array 
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <param name="RecipientNumber">Send SMS to this numbers</param>
    /// <param name="Message">Text of your SMS</param>
    /// <param name="SpecialNumber">Your Special number ,send sms from this number</param>
    /// <param name="IsFlash">True/False</param>
    /// <param name="CheckingMessageID">Your local ID for message</param>
    /// <returns>MessageID for each SMS</returns>
    public static long[] SendArray(string UserName, string Password, string[] RecipientNumber, string Message, string SpecialNumber, bool IsFlash, long[] CheckingMessageID) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.SendArray(UserName, Password, RecipientNumber, Message, SpecialNumber, IsFlash, CheckingMessageID);
        }
    }

    /// <summary>
    /// Send Array Schedule
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <param name="RecipientNumber">Send SMS to this numbers</param>
    /// <param name="Message">Text of your SMS</param>
    /// <param name="SpecialNumber"></param>
    /// <param name="IsFlash">True/False</param>
    /// <param name="Year">int</param>
    /// <param name="Month">int</param>
    /// <param name="Day">int</param>
    /// <param name="Hour">int</param>
    /// <param name="Minute">int</param>
    /// <returns></returns>
    public static long SendArraySchedule(string UserName, string Password, string[] RecipientNumber, string Message, string SpecialNumber, bool IsFlash, int Year, int Month, int Day, int Hour, int Minute) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.SendArraySchedule(UserName, Password, RecipientNumber, Message, SpecialNumber, IsFlash, Year, Month, Day, Hour, Minute);
        }
    }

    /// <summary>
    /// Get Message ID
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <param name="CheckingMessageID">Your local ID for message</param>
    /// <returns>MessageIDs</returns>
    public static long[] GetMessageID(string UserName, string Password, long[] CheckingMessageID) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.GetMessageID(UserName, Password, CheckingMessageID);
        }
    }

    /// <summary>
    /// Get Message Status
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <param name="MessageID">long[] MessageIDs</param>
    /// <returns></returns>
    public static long[] GetMessageStatus(string UserName, string Password, long[] MessageID) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.GetMessageStatus(UserName, Password, MessageID);
        }
    }

    /// <summary>
    /// Get Number Group Data
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <returns>NumberGroupItem</returns>
    public static SOAP.NumberGroupItem[] GetNumberGroupData(string UserName, string Password) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.GetNumberGroupData(UserName, Password);
        }
    }

    /// <summary>
    /// Send To Group Number
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <param name="NumberGroupID">long[] GroupIDs</param>
    /// <param name="Message">Text of your SMS</param>
    /// <param name="SpecialNumber">Your Special number ,send sms from this number</param>
    /// <param name="IsFlash">True/False</param>
    /// <param name="DontSendToRepeatedNumber">True/False</param>
    /// <returns>SendID for Send To Group</returns>
    public static long SendNumberGroup(string UserName, string Password, long[] NumberGroupID, string Message, string SpecialNumber, bool IsFlash, bool DontSendToRepeatedNumber) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.SendNumberGroup(UserName, Password, NumberGroupID, Message, SpecialNumber, IsFlash, DontSendToRepeatedNumber);
        }
    }

    /// <summary>
    /// Send Number Group Schedule
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <param name="NumberGroupID">long[] GroupIDs</param>
    /// <param name="Message">Text of your SMS</param>
    /// <param name="SpecialNumber">Your Special number ,send sms from this number</param>
    /// <param name="IsFlash">True/False</param>
    /// <param name="DontSendToRepeatedNumber">True/False</param>
    /// <param name="Year">int</param>
    /// <param name="Month">int</param>
    /// <param name="Day">int</param>
    /// <param name="Hour">int</param>
    /// <param name="Minute">int</param>
    /// <returns>SendID for Send To Group</returns>
    public static long SendNumberGroupSchedule(string UserName, string Password, long[] NumberGroupID, string Message, string SpecialNumber, bool IsFlash, bool DontSendToRepeatedNumber, int Year, int Month, int Day, int Hour, int Minute) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.SendNumberGroupSchedule(UserName, Password, NumberGroupID, Message, SpecialNumber, IsFlash, DontSendToRepeatedNumber, Year, Month, Day, Hour, Minute);
        }
    }

    /// <summary>
    /// Insert Number To PhoneBook
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <param name="NumberGroupID">long GroupID</param>
    /// <param name="PersonNumber">Array of String </param>
    /// <param name="PersonName">Array of String </param>
    /// <returns>Array of long </returns>
    public static long[] InsertNumberInNumberGroup(string UserName, string Password, long NumberGroupID, string[] PersonNumber, string[] PersonName) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.InsertNumberInNumberGroup(UserName, Password, NumberGroupID, PersonNumber, PersonName);
        }
    }

    /// <summary>
    /// Get Inbox Message
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <param name="NumberOfMessage">Int Number of message</param>
    /// <returns>InboxItem</returns>
    public static SOAP.InboxItem[] GetInboxMessage(string UserName, string Password, int NumberOfMessage) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.GetInboxMessage(UserName, Password, NumberOfMessage);
        }
    }


    /// <summary>
    /// Get Inbox Message With SpecialNumber
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <param name="NumberOfMessage">Int Number of message</param>
    /// <param name="SpecialNumber">Your Special number ,send sms from this number</param>
    /// <returns>InboxItem</returns>
    public static SOAP.InboxItem[] GetInboxMessageWithNumber(string UserName, string Password, int NumberOfMessage, string SpecialNumber) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.GetInboxMessageWithNumber(UserName, Password, NumberOfMessage, SpecialNumber);
        }
    }

    /// <summary>
    /// Get Inbox Message With Last InboxID
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <param name="NumberOfMessage">int</param>
    /// <param name="InboxID">int</param>
    /// <param name="IsReaded">True/False</param>
    /// <returns>ResultInbox</returns>
    public static SOAP.ResultInbox GetInboxMessageWithInboxID(string UserName, string Password, int NumberOfMessage, int InboxID, bool IsReaded) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.GetInboxMessageWithInboxID(UserName, Password, NumberOfMessage, InboxID, IsReaded);
        }
    }

    /// <summary>
    /// Get Account Credit
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <returns>long Credit</returns>
    public static long GetCredit(string UserName, string Password) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.GetCredit(UserName, Password);
        }
    }

    /// <summary>
    /// Get User Info
    /// </summary>
    /// <param name="UserName">String</param>
    /// <param name="Password">String</param>
    /// <returns>ProfileInfo</returns>
    public static SOAP.ProfileInfo GetUserInfo(string UserName, string Password) {
        using (SOAP.SMS SMSService = new SOAP.SMS()) {
            return SMSService.GetUserInfo(UserName, Password);
        }
    }

}
