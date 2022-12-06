# راهنمای متد SendArray

- [راهنمای متد SendArray](#راهنمای-متد-sendarray)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد SendArray](#نکات-مهم-در-مورد-کار-با-متد-sendarray)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

برای ارسال پیامک ، به یک/چند شماره از این متد استفاده کنید . با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید . خروجی این متد شناسه پیامک های ارسال شده است که مقدار آن به صورت یک آرایه از اعداد بزرگتر از 1000 می باشد ، اگر مقدار عدد بازگشتی کمتر از 1000 باشد به معنی بروز خطا در ارسال است.

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
<tr><td>RecipientNumber</td><td>String</td><td>اجباری</td><td>شماره گیرنده ویا گیرندگان ( شماره تلفن همراه مقصد )</td></tr>
<tr><td>MessageBody</td><td>String</td><td>اجباری</td><td>متن پیامک</td></tr>
<tr><td>SpecialNumber</td><td>String</td><td>اجباری</td><td>شماره اختصاصی ( شماره فرستنده پیامک )</td></tr>
<tr><td><s>IsFlashMessage</s></td><td><s>Boolean</s></td><td><s>اجباری</s></td><td><s>آیا ارسال به صورت Flash انجام شود</s></td></tr>
<tr><td>CheckingMessageID</td><td>Array Of Long Integer</td><td>اجباری</td><td>شناسه پیامک کاربر</tr>
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>نوع</th><th>توضیح</th></tr>
<tr><td>Array Of Long Integer</td><td>شامل شناسه پیامک یا کد خطا</td></tr>
</table>

- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/soap/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)

## نکات مهم در مورد کار با متد SendArray

- شما می توانید با استفاده از این متد به یک یا چند شماره پیامک ارسال کنید ، به این صورت که اگر قصد ارسال تکی را دارید در آرایه RecipientNumber فقط یک شماره قرار دهید و اگر قصد ارسال به بیش از یک شماره را دارید در آرایه RecipientNumber می توانید تا 1000 شماره را وارد کنید .
- حتما قبل از ارسال از تکراری نبودن شماره های گیرندگان در آرایه ارسالی مطمئن شوید .
- شما می توانید برای اطمینان از ارسال شدن پیامک های خود ، از پارامتر CheckingMessageID استفاده کنید . نحوه کار با پارامتر CheckingMessageID به این صورت می باشد که درهنگام استفاده از متد SendArray ، به همراه آرایه RecipientNumber و به همان تعداد ، شناسه های منحصر بفرد پیامک در سمت Application خودتان را در آرایه CheckingMessageID قرار دهید و در هنگام بروز خطا ، قطع شدن ارتباط با سرور و ... ، مقادیر CheckingMessageID که قبلا در متد ارسال قرار داده اید را به GetMessageID بفرستید و مقدار MessageID متناظر در سرور را بدست آورید ، و در نهایت با استفاده از متد GetMessageStatus از وضعیت آن پیام ها مطلع گردید.

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
    
    public Function SendArray($MobileNumbersArray, $Message, $SpecialNumber, $IsFlashMessage, $CheckingMessageID){
        $option = array('UserName'=> $this->Username,'Password'=> $this->Password,'RecipientNumber'=> $MobileNumbersArray,'MessageBody'=> $Message,'SpecialNumber'=> $SpecialNumber,'IsFlashMessage'=> $IsFlashMessage,'CheckingMessageID'=> $CheckingMessageID);
        $client = $this->GetClient();
        return $client->SendArray($option)->SendArrayResult;
    }

}
```

### Java

```Java
/** 
    Send Array 
         
    @param UserName String
    @param Password String
    @param RecipientNumber Send SMS to this numbers
    @param Message Text of your SMS
    @param SpecialNumber Your Special number ,send sms from this number
    @param IsFlash True/False
    @param CheckingMessageID Your local ID for message
    @return MessageID for each SMS
*/
public final long[] SendArray(String UserName, String Password, String[] RecipientNumber, String Message, String SpecialNumber, boolean IsFlash, long[] CheckingMessageID)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.SendArray(UserName, Password, RecipientNumber, Message, SpecialNumber, IsFlash, CheckingMessageID);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
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
public Shared Function SendArray(UserName As String, Password As String, RecipientNumber As String(), Message As String, SpecialNumber As String, IsFlash As Boolean, _
    CheckingMessageID As Long()) As Long()
    Using SMSService As New SOAP.SMS()
        Return SMSService.SendArray(UserName, Password, RecipientNumber, Message, SpecialNumber, IsFlash, _
            CheckingMessageID)
    End Using
End Function

End Class
```
