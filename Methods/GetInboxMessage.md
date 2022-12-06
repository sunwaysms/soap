# راهنمای متد GetInboxMessage

- [راهنمای متد GetInboxMessage](#راهنمای-متد-getinboxmessage)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد GetInboxMessage](#نکات-مهم-در-مورد-کار-با-متد-getinboxmessage)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

با استفاده از این متد شما می توانید تعداد مشخصی از پیامک های دریافتی خود را در روز اخیر دریافت نمایید . با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید .

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
<tr><td>NumberOfMessage</td><td>Integer</td><td>اجباری</td><td>تعداد پیامک های درخواستی</td></tr>
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>کلید</th><th>توضیح</th></tr>
<tr><td>Array Of InboxItem</td><td>آرایه ای از آبجکت InboxItem</td></tr>
</table>

- [ توضیحات آرایه InboxItem](https://github.com/sunwaysms/soap/blob/main/Objects/InboxItem.md)
- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/soap/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)

## نکات مهم در مورد کار با متد GetInboxMessage

- مقدار بازگشتی این متد آرایه ای از آبجکتی با نوع InboxItem می باشد . فرمت آبجکت مذکور در فایل WSDL موجود می باشد .

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
    
    public Function GetInboxMessage($NumberOfMessage){
        $option = array('UserName'=> $this->Username,'Password'=> $this->Password,
                        'NumberOfMessage'=> $NumberOfMessage);
        
        $client = $this->GetClient();
        return $client->GetInboxMessage($option)->GetInboxMessageResult;
    }

}
```

### Java

```Java
/** 
    Get Inbox Message
         
    @param UserName String
    @param Password String
    @param NumberOfMessage Int Number of message
    @return InboxItem
*/
public final SOAP.InboxItem[] GetInboxMessage(String UserName, String Password, int NumberOfMessage)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.GetInboxMessage(UserName, Password, NumberOfMessage);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {

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
''' Get Inbox Message
''' </summary>
''' <param name="UserName">String</param>
''' <param name="Password">String</param>
''' <param name="NumberOfMessage">Int Number of message</param>
''' <returns>InboxItem</returns>
public  Shared Function GetInboxMessage(UserName As String, Password As String, NumberOfMessage As Integer) As SOAP.InboxItem()
    Using SMSService As New SOAP.SMS()
        Return SMSService.GetInboxMessage(UserName, Password, NumberOfMessage)
    End Using
End Function

End Class
```