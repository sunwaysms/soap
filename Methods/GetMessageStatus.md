# راهنمای متد GetMessageStatus

- [راهنمای متد GetMessageStatus](#راهنمای-متد-getmessagestatus)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد GetMessageStatus](#نکات-مهم-در-مورد-کار-با-متد-getmessagestatus)
  - [وضعیت پیامک های ارسال شده](#وضعیت-پیامک-های-ارسال-شده)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

برای اطلاع از وضعیت پیامک های ارسال شده از این متد استفاده کنید . با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید .

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
<tr><td>MessageID</td><td>String</td><td>اجباری</td><td>شناسه پیامک</td></tr>
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>نوع</th><th>توضیح</th></tr>
<tr><td>Array Of Long Integer</td><td>آرایه ای شامل وضعیت پیامک تا این لحظه و یا کد خطا</td></tr>
</table>

- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/soap/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)

## نکات مهم در مورد کار با متد GetMessageStatus

- شما با استفاده از شناسه پیامک ( MessageID که خروجی متد SendArray یا GetMessageID می باشد ) به عنوان پارامتر ورودی متد GetMessageStatus ، می توانید از وضعیت پیامک ارسال شده مطلع شوید .
- خروجی این متد وضعیت پیامک ارسالی می باشد ، دقت کنید که وضعیت پیامک یک عدد کوچکتر از 50 می باشد ، در غیر این صورت مقدار بازگشتی نشان دهنده یک کد خطا می باشد . کد و توضیحات مربوط به وضعیت پیامک در جدول ذیل ذکر شده است:

## وضعیت پیامک های ارسال شده

<table dir="rtl" align="center">
<tr><th>کد</th><th>توضیح</th></tr>
<tr><td>0</td><td>شناسه پیامک نامعتبر است ( یا ممکن است شناسه پیامک ارسال شده مربوط به پیامکی باشد که بیش از یک ماه از ارسال آن می گذرد )<br/>وضعیت این پیامک را مجددا بررسی نفرمایید زیرا تغییری در وضعیت آن حاصل نمی شود</td></tr>
<tr><td>1</td><td>هنوز وضعیتی دریافت نشده است ، سیستم در حال پیگیری وضعیت پیامک از مخابرات است<br/>می توانید وضعیت این پیامک را مجددا بررسی فرمایید زیرا تغییر خواهد کرد</td></tr>
<tr><td>2</td><td>پیامک به موبایل گیرنده رسیده است<br/>وضعیت این پیامک را مجددا بررسی نفرمایید زیرا تغییری در وضعیت آن حاصل نمی شود</td></tr>
<tr><td>3</td><td>پیامک به موبایل گیرنده نرسیده است ، به یکی از دلایل ذیل :<br/>۱. پر بودن Inbox موبایل گیرنده پیام<br/>۲. خاموش بودن موبایل گیرنده پیام<br/>۳. در دسترس نبودن موبایل گیرنده پیام<br/>۴. اختلال در شبکه BTS<br/>وضعیت این پیامک را مجددا بررسی نفرمایید زیرا تغییری در وضعیت آن حاصل نمی شود</td></tr>
<tr><td>4</td><td>پیامک به مرکز مخابراتی رسیده است ( در صف ارسال مخابرات قرار گرفته است و بزودی به موبایل گیرنده ارسال می گردد )<br/>می توانید وضعیت این پیامک را مجددا بررسی فرمایید زیرا تغییر خواهد کرد</td></tr>
<tr><td>5</td><td>پیامک به مرکز مخابراتی نرسیده است ( این وضعیت زمانی رخ می دهد که مرکز مخابراتی نتواند به اپراتور تلفن همراه شماره گیرنده ، پیامک ارسال کند )<br/>وضعیت این پیامک را مجددا بررسی نفرمایید زیرا تغییری در وضعیت آن حاصل نمی شود</td></tr>
<tr><td>6</td><td>شماره موبایل گیرنده پیامک به درخواست کاربر در لیست غیر فعال مخابرات قرار گرفته است<br/>هزینه این ارسال به کاربر برگردانده می شود<br/>وضعیت این پیامک را مجددا بررسی نفرمایید زیرا تغییری در وضعیت آن حاصل نمی شود</td></tr>
<tr><td>7</td><td>پیامک در صف ارسال قرار دارد ( سرور هنوز شروع به ارسال پیامک نکرده است )<br/>می توانید وضعیت این پیامک را مجددا بررسی فرمایید زیرا تغییر خواهد کرد</td></tr>
<tr><td>8</td><td>سرور در حال ارسال پیامک می باشد<br/>می توانید وضعیت این پیامک را مجددا بررسی فرمایید زیرا تغییر خواهد کرد</td></tr>
<tr><td>9</td><td>در زمان ارسال به علت کمبود اعتبار پیام کوتاه ، این پیامک ارسال نشده است<br/>وضعیت این پیامک را مجددا بررسی نفرمایید زیرا تغییری در وضعیت آن حاصل نمی شود</td></tr>
<tr><td>10</td><td>پیامک ارسال نشده است ( به دلیل اختلالات ارتباطی پیامک ارسال نشده است اما سرور به مدت 2 ساعت تلاش به ارسال مجدد این پیامک می کند و اگر طی این 2 ساعت نتواند پیامک را ارسال کند ، هزینه آن را به کاربر برمی گرداند<br/>می توانید وضعیت این پیامک را مجددا بررسی فرمایید زیرا تغییر خواهد کرد</td></tr>
<tr><td>11</td><td>پیامک هنوز توسط اپراتور تأیید نشده است<br/>می توانید وضعیت این پیامک را مجددا بررسی فرمایید زیرا تغییر خواهد کرد</td></tr>
<tr><td>12</td><td>پیامک در لیست کنسل شده یا فیلتر شده قرار دارد<br/>وضعیت این پیامک را مجددا بررسی نفرمایید زیرا تغییری در وضعیت آن حاصل نمی شود</td></tr>
</table>

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

    public Function GetMessageStatus($MessageIDArray){
        $option = array('UserName'=> $this->Username,'Password'=> $this->Password,'MessageID'=> $MessageIDArray);
        $client = $this->GetClient();
        return $client->GetMessageStatus($option)->GetMessageStatusResult;
    }
    
}
```

### Java

```Java
/** 
    Get Message Status
         
    @param UserName String
    @param Password String
    @param MessageID long[] MessageIDs
    @return 
*/
public final long[] GetMessageStatus(String UserName, String Password, long[] MessageID)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.GetMessageStatus(UserName, Password, MessageID);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {

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

}
```

### VB.net
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Web.Script.Serialization

public Class API


''' <summary>
''' Get Message Status
''' </summary>
''' <param name="UserName">String</param>
''' <param name="Password">String</param>
''' <param name="MessageID">long[] MessageIDs</param>
''' <returns></returns>
public Shared Function GetMessageStatus(UserName As String, Password As String, MessageID As Long()) As Long()
    Using SMSService As New SOAP.SMS()
        Return SMSService.GetMessageStatus(UserName, Password, MessageID)
    End Using
End Function

End Class
```