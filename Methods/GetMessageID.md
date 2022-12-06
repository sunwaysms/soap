# راهنمای متد GetMessageID

- [راهنمای متد GetMessageID](#راهنمای-متد-getmessageid)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد GetMessageID](#نکات-مهم-در-مورد-کار-با-متد-getmessageid)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

در مواقع خاص ( قطع شدن ارتباط با سرور ، از کار افتادن سیستم کاربر ، بروز خطا و ... ) ، می توانید با استفاده از این متد و فرستادن شناسه های منحصر بفرد پیامک در سمت Application خودتان ( CheckingMessageID ) از شناسه پیام کوتاه سمت سرور ( MessageID ) مطلع شوید و با فرستادن آن به متد GetMessageStatus از وضعیت پیامک خود اطمینان حاصل کنید . با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید .

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
<tr><td>CheckingMessageID</td><td>String</td><td>اجباری</td><td>شناسه پیامک کاربر</td></tr>
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>نوع</th><th>توضیح</th></tr>
<tr><td>Array Of Long Integer</td><td>آرایه ای شامل شناسه پیامک یا کد خطا</td></tr>
</table>

- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/soap/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)

## نکات مهم در مورد کار با متد GetMessageID

- در هنگام ارسال CheckingMessageID به متد SendArray از منحصر به فرد بودن آن در سمت Application خودتان اطمینان حاصل کنید ، زیرا در غیر این صورت در هنگام استفاده از متد GetMessageID اطلاعات اشتباه بدست می آورید .
- در خروجی این متد اگر یک عدد بزرگتر از 1000 به شما بازگشت داده شد به معنی شناسه پیامک ( MessageID ) می باشد و در غیر این صورت نشان دهنده یک کد خطا می باشد ، که معمولا کد خطای "شناسه کاربری شما ( CheckingMessageID ) نامعتبر است" به شما بازگشت داده می شود که ، به این معنی که این پیام ارسال نگشته است یا شناسه پیامک ارسال شده مربوط به پیامکی می باشد که بیش از یک ماه از ارسال آن می گذرد  .

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
    
    public Function GetMessageID($CheckingMessageIDArray){
        $option = array('UserName'=> $this->Username,'Password'=> $this->Password,'CheckingMessageID'=> $CheckingMessageIDArray);
        $client = $this->GetClient();
        return $client->GetMessageID($option)->GetMessageIDResult;
    }

}
```

### Java

```Java
/** 
    Get Message ID
         
    @param UserName String
    @param Password String
    @param CheckingMessageID Your local ID for message
    @return MessageIDs
*/
public final long[] GetMessageID(String UserName, String Password, long[] CheckingMessageID)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.GetMessageID(UserName, Password, CheckingMessageID);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {

/// <summary>
/// Get Message ID
/// </summary>
/// <param name="UserName">String</param>
/// <param name="Password">String</param>
/// <param name="CheckingMessageID">Your local ID for message</param>
/// <returns>MessageIDs</returns>
public static long[] GetMessageID(string UserName, string Password,long[] CheckingMessageID) {
    using (SOAP.SMS SMSService = new SOAP.SMS()) {
        return SMSService.GetMessageID(UserName, Password, CheckingMessageID);
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
''' Get Message ID
''' </summary>
''' <param name="UserName">String</param>
''' <param name="Password">String</param>
''' <param name="CheckingMessageID">Your local ID for message</param>
''' <returns>MessageIDs</returns>
public Shared Function GetMessageID(UserName As String, Password As String, CheckingMessageID As Long()) As Long()
    Using SMSService As New SOAP.SMS()
        Return SMSService.GetMessageID(UserName, Password, CheckingMessageID)
    End Using
End Function

End Class
```