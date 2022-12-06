# راهنمای متد GetInboxMessageWithNumber

- [راهنمای متد GetInboxMessageWithNumber](#راهنمای-متد-getinboxmessagewithnumber)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد GetInboxMessageWithNumber](#نکات-مهم-در-مورد-کار-با-متد-getinboxmessagewithnumber)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

این متد همانند متد GetInboxMessage می باشد با این تفاوت که در این متد شما می توانید تعداد مشخصی از پیامک های دریافتی در روز اخیر که به یک شماره اختصاصی خاص ارسال شده اند را دریافت کنید . با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید.

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
<tr><td>NumberOfMessage</td><td>Integer</td><td>اجباری</td><td>تعداد پیامک های درخواستی</td></tr>
<tr><td>SpecialNumber</td><td>String</td><td>اجباری</td><td>شماره اختصاصی ( شماره دریافت کننده پیامک )</td></tr>
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>کلید</th><th>توضیح</th></tr>
<tr><td>Array Of InboxItem</td><td>آرایه ای از آبجکت InboxItem</td></tr>
</table>

- [ توضیحات آرایه InboxItem](https://github.com/sunwaysms/soap/blob/main/Objects/InboxItem.md)
- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/soap/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)

## نکات مهم در مورد کار با متد GetInboxMessageWithNumber

- مقدار بازگشتی این متد نیز همانند متد  GetInboxMessage  ، آرایه ای از آبجکتی با نوع InboxItem می باشد . فرمت آبجکت مذکور در فایل WSDL موجود می باشد .

## نمونه کد

### PHP

```PHP
<?php
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
    
    public Function GetInboxMessageWithNumber($NumberOfMessage, $SpecialNumber){
        $option = array('UserName'=> $this->Username,'Password'=> $this->Password,
                        'NumberOfMessage'=> $NumberOfMessage,
                        'SpecialNumber'=> $SpecialNumber);
        
        $client = $this->GetClient();
        return $client->GetInboxMessageWithNumber($option)->GetInboxMessageWithNumberResult;
    }

}
```

### Java

```Java
/** 
    Get Inbox Message With SpecialNumber
         
    @param UserName String
    @param Password String
    @param NumberOfMessage Int Number of message
    @param SpecialNumber Your Special number ,send sms from this number
    @return InboxItem
*/
public final SOAP.InboxItem[] GetInboxMessageWithNumber(String UserName, String Password, int NumberOfMessage, String SpecialNumber)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.GetInboxMessageWithNumber(UserName, Password, NumberOfMessage, SpecialNumber);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {


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
''' Get Inbox Message With SpecialNumber
''' </summary>
''' <param name="UserName">String</param>
''' <param name="Password">String</param>
''' <param name="NumberOfMessage">Int Number of message</param>
''' <param name="SpecialNumber">Your Special number ,send sms from this number</param>
''' <returns>InboxItem</returns>
public  Shared Function GetInboxMessageWithNumber(UserName As String, Password As String, NumberOfMessage As Integer, SpecialNumber As String) As SOAP.InboxItem()
    Using SMSService As New SOAP.SMS()
        Return SMSService.GetInboxMessageWithNumber(UserName, Password, NumberOfMessage, SpecialNumber)
    End Using
End Function

End Class
```