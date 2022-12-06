# راهنمای متد SendArraySchedule

- [راهنمای متد SendArraySchedule](#راهنمای-متد-sendarrayschedule)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد SendArraySchedule](#نکات-مهم-در-مورد-کار-با-متد-sendarrayschedule)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

برای ارسال پیامک به صورت زمانبندی شده ، به یک/چند شماره از این متد استفاده کنید . با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید .

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
<tr><td>RecipientNumber</td><td>String</td><td>اجباری</td><td>شماره گیرنده ویا گیرندگان ( شماره تلفن همراه مقصد )</td></tr>
<tr><td>MessageBody</td><td>String</td><td>اجباری</td><td>متن پیامک</td></tr>
<tr><td>SpecialNumber</td><td>String</td><td>اجباری</td><td>شماره اختصاصی ( شماره فرستنده پیامک )</td></tr>
<tr><td><s>IsFlashMessage</s></td><td><s>Boolean</s></td><td><s>اجباری</s></td><td><s>آیا ارسال به صورت Flash انجام شود</s></td></tr>
<tr><td>Year</td><td>Integer</td><td>اجباری</td><td>سال مورد نظر برای ارسال زمانبندی شده پیامک</td></tr>
<tr><td>Month</td><td>Integer</td><td>اجباری</td><td>ماه مورد نظر برای ارسال زمانبندی شده پیامک</td></tr>
<tr><td>Day</td><td>Integer</td><td>اجباری</td><td>روز مورد نظر برای ارسال زمانبندی شده پیامک</td></tr>
<tr><td>Hour</td><td>Integer</td><td>اجباری</td><td>ساعت مورد نظر برای ارسال زمانبندی شده پیامک</td></tr>
<tr><td>Minute</td><td>Integer</td><td>اجباری</td><td>دقیقه مورد نظر برای ارسال زمانبندی شده پیامک</td></tr>
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>نوع</th><th>توضیح</th></tr>
<tr><td>Long Integer</td><td>شناسه ارسال زمانبندی شده یا کد خطا</td></tr>
</table>


- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/soap/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)

## نکات مهم در مورد کار با متد SendArraySchedule

- شما می توانید با استفاده از این متد به یک یا چند شماره به صورت زمانبندی شده پیامک ارسال کنید ، به این صورت که اگر قصد ارسال تکی را دارید در آرایه RecipientNumber فقط یک شماره قرار دهید و اگر قصد ارسال به بیش از یک شماره را دارید در آرایه RecipientNumber می توانید تا 1000 شماره را وارد کنید .
- حتما قبل از ارسال از تکراری نبودن شماره های گیرندگان در آرایه ارسالی مطمئن شوید .
- حتما تاریخ و زمان آینده را انتخاب کنید ، اگر قصد ارسال در زمان جاری را دارید ، به جای این متد از متد SendArray استفاده کنید .
- توجه کنید برخلاف متد SendArray ، خروجی این متد شناسه ارسال زمانبندی شده شماست ، به این معنی که ارسال شما هنوز در صف ارسال سیستم قرار نگرفته است و می توانید با مراجعه به سامانه مدیریت پیام کوتاه خود ، از وضعیت ارسال زمانبندی شده ( که شناسه آن را از خروجی متد SendArraySchedule دریافت کرده اید ) مطلع شوید و در صورت نیاز این ارسال را لغو کنید .

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

public Function SendArraySchedule($MobileNumbersArray, $Message, $SpecialNumber, $IsFlashMessage, $CheckingMessageID, $Year, $Month, $Day, $Hour, $Minute){
$option = array('UserName'=> $this->Username,'Password'=> $this->Password,'RecipientNumber'=> $MobileNumbersArray,'MessageBody'=> $Message,'SpecialNumber'=> $SpecialNumber,'IsFlashMessage'=> $IsFlashMessage,'CheckingMessageID'=> $CheckingMessageID, 'Year'=> $Year, 'Month'=> $Month, 'Day'=> $Day, 'Hour'=> $Hour, 'Minute'=> $Minute);
$client = $this->GetClient();
return $client->SendArraySchedule($option)->SendArrayScheduleResult;
}

}
```

### Java

```Java
/** 
    Send Array Schedule
         
    @param UserName String
    @param Password String
    @param RecipientNumber Send SMS to this numbers
    @param Message Text of your SMS
    @param SpecialNumber
    @param IsFlash True/False
    @param Year int
    @param Month int
    @param Day int
    @param Hour int
    @param Minute int
    @return MessageID
*/
public final long SendArraySchedule(String UserName, String Password, String[] RecipientNumber, String Message, String SpecialNumber, boolean IsFlash, int Year, int Month, int Day, int Hour, int Minute)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.SendArraySchedule(UserName, Password, RecipientNumber, Message, SpecialNumber, IsFlash, Year, Month, Day, Hour, Minute);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {

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
public static long SendArraySchedule(string UserName, string Password, string[] RecipientNumber, string Message, string SpecialNumber, bool IsFlash,int Year,int Month,int Day,int Hour,int Minute) {
    using (SOAP.SMS SMSService = new SOAP.SMS()) {
        return SMSService.SendArraySchedule(UserName, Password, RecipientNumber, Message, SpecialNumber, IsFlash,Year,Month,Day,Hour,Minute);
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
public Shared Function SendArraySchedule(UserName As String, Password As String, RecipientNumber As String(), Message As String, SpecialNumber As String, IsFlash As Boolean, _
    Year As Integer, Month As Integer, Day As Integer, Hour As Integer, Minute As Integer) As Long
    Using SMSService As New SOAP.SMS()
        Return SMSService.SendArraySchedule(UserName, Password, RecipientNumber, Message, SpecialNumber, IsFlash, _
            Year, Month, Day, Hour, Minute)
    End Using
End Function

End Class
```