# راهنمای متد GetInboxMessageWithInboxID

- [راهنمای متد GetInboxMessageWithInboxID](#راهنمای-متد-getinboxmessagewithinboxid)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد GetInboxMessageWithInboxID](#نکات-مهم-در-مورد-کار-با-متد-getinboxmessagewithinboxid)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

با استفاده از این متد شما می توانید با ارسال شناسه یک پیامک،  لیستی از تمامی پیامک های دریافتی که شناسه آن ها بزرگتر از شناسه پیامک ارسالی باشد، را دریافت نمایید.  با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید .

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
<tr><td>NumberOfMessage</td><td>Integer</td><td>اجباری</td><td>تعداد پیامک های درخواستی</td></tr>
<tr><td>InboxID</td><td>Integer</td><td>اجباری</td><td>شناسه پیامک</td></tr>
<tr><td>IsReaded</td><td>Boolean</td><td>اجباری</td><td>آیا تمامی پیامک ها نمایش داده شود یا فقط خوانده نشده ها</td></tr>
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>کلید</th><th>توضیح</th></tr>
<tr><td>ResultInbox</td><td>آرایه ای از InboxItem2</td></tr>
</table>

- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/soap/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)

## نکات مهم در مورد کار با متد GetInboxMessageWithInboxID
- مقدار بازگشتی این متد، آبجکت ResultInbox که شامل آرایه ای از آبجکتی با نوع InboxItem2 می باشد . فرمت آبجکت مذکور در فایل WSDL موجود می باشد .

## نمونه کد

### PHP

```PHP
class SMS
{
    public $Username = '';
    public $Password = '';
    
    private $SoapAddress = 'https://sms.sunwaysms.com/SMSWS/SOAP.asmx?wsdl';
    private $client;

    function __construct()
    {
        $this->client = new SoapClient($this->SoapAddress);
    }

    public Function GetClient(){
        return $this->client;
    }
    public Function GetClientEx($option){
        return new SoapClient($this->SoapAddress, $option);
    }
    
    public Function GetMethods(){
        $arr = array();
        $client = GetClient();
        return $client->__getFunctions();
    }

    public  function GetInboxMessageWithInboxID($NumberOfMessage, $InboxID, $IsReaded) {
        $option = array('UserName'=> $this->Username,'Password'=> $this->Password,
                        'NumberOfMessage'=> $NumberOfMessage,'InboxID'=> $InboxID,'IsReaded'=> IsReaded);
        
        $client = $this->GetClient();
        return $client->GetInboxMessageWithInboxID($option)->GetInboxMessageWithInboxIDResult;
    }

}
```

### Java

```Java
/** 
    Get Inbox Message With Last InboxID
         
    @param UserName String
    @param Password String
    @param NumberOfMessage int
    @param InboxID int
    @param IsReaded True/False
    @return ResultInbox
*/
public final SOAP.ResultInbox GetInboxMessageWithInboxID(String UserName, String Password, int NumberOfMessage, int InboxID, boolean IsReaded)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.GetInboxMessageWithInboxID(UserName, Password, NumberOfMessage, InboxID, IsReaded);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {

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

}
```

### VB.net

```VB
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Web.Script.Serialization

public Class API

''' <summary>
''' Get Inbox Message With Last InboxID
''' </summary>
''' <param name="UserName">String</param>
''' <param name="Password">String</param>
''' <param name="NumberOfMessage">int</param>
''' <param name="InboxID">int</param>
''' <param name="IsReaded">True/False</param>
''' <returns>ResultInbox</returns>
public  Shared Function GetInboxMessageWithInboxID(UserName As String, Password As String, NumberOfMessage As Integer, InboxID As Integer, IsReaded As Boolean) As SOAP.ResultInbox
    Using SMSService As New SOAP.SMS()
        Return SMSService.GetInboxMessageWithInboxID(UserName, Password, NumberOfMessage, InboxID, IsReaded)
    End Using
End Function

End Class
```