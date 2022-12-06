# راهنمای متد SendNumberGroupSchedule

- [راهنمای متد SendNumberGroupSchedule](#راهنمای-متد-sendnumbergroupschedule)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد SendNumberGroupSchedule](#نکات-مهم-در-مورد-کار-با-متد-sendnumbergroupschedule)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

برای ارسال پیامک به یک یا چند گروه خاص از دفتر تلفن موجود در سامانه مدیریت پیام کوتاه خود در یک زمان معین از این متد استفاده کنید . با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید .

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
<tr><td>NumberGroupID</td><td>String</td><td>اجباری</td><td>شناسه گروه دفتر تلفن</td></tr>
<tr><td>MessageBody</td><td>String</td><td>اجباری</td><td>متن پیامک</td></tr>
<tr><td>SpecialNumber</td><td>String</td><td>اجباری</td><td>شماره اختصاصی</td></tr>
<tr><td><s>IsFlashMessage</s></td><td><s>Boolean</s></td><td><s>اجباری</s></td><td><s>آیا ارسال به صورت Flash انجام شود</s></td></tr>
<tr><td>DontSendToRepeatedNumber</td><td>Boolean</td><td>اجباری</td><td>به شماره های تکراری ارسال نشود؟</td></tr>
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

## نکات مهم در مورد کار با متد SendNumberGroupSchedule

- فقط کاربرانی می توانند از این متد استفاده کنند که هم کاربر وب سرویس و هم کاربر سامانه مدیریت پیام کوتاه باشند.
- حتما تاریخ و زمان آینده را انتخاب کنید ، اگر قصد ارسال در زمان جاری را دارید ، به جای این متد از متد SendNumberGroup استفاده کنید .
- توجه کنید برخلاف متد SendNumberGroup ، خروجی این متد شناسه ارسال زمانبندی شده شماست ، به این معنی که ارسال شما هنوز در صف ارسال سیستم قرار نگرفته است و می توانید با مراجعه به سامانه مدیریت پیام کوتاه خود ، از وضعیت ارسال زمانبندی شده ( که شناسه آن را از خروجی متد SendNumberGroupSchedule دریافت کرده اید ) مطلع شوید و در صورت نیاز این ارسال را لغو کنید .

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

    public Function GetUserInfo() {
            $option = array('UserName'=> $this->Username,'Password'=> $this->Password);
        
        $client = $this->GetClient();
        return $client->GetUserInfo($option)->GetUserInfoResult;
    }    
     
    public Function SendNumberGroupSchedule($NumberGroupIDArray, $MessageBody, $SpecialNumber, $IsFlashMessage, $DontSendToRepeatedNumber, $Year, $Month, $Day, $Hour, $Minute){
        $option = array('UserName'=> $this->Username,'Password'=> $this->Password,
                        'NumberGroupID'=> $NumberGroupIDArray, 
                        'MessageBody'=> $MessageBody,
                        'SpecialNumber'=> $SpecialNumber,
                        'IsFlashMessage'=> $IsFlashMessage,
                        'DontSendToRepeatedNumber'=> $DontSendToRepeatedNumber,
                        'Year'=> $Year, 'Month'=> $Month, 'Day'=> $Day, 'Hour'=> $Hour, 'Minute'=> $Minute);
        
        $client = $this->GetClient();
        return $client->SendNumberGroupSchedule($option)->SendNumberGroupScheduleResult;
    }

}
```

### Java

```Java
/** 
    Send Number Group Schedule
         
    @param UserName String
    @param Password String
    @param NumberGroupID long[] GroupIDs
    @param Message Text of your SMS
    @param SpecialNumber Your Special number ,send sms from this number
    @param IsFlash True/False
    @param DontSendToRepeatedNumber True/False
    @param Year int
    @param Month int
    @param Day int
    @param Hour int
    @param Minute int
    @return SendID for Send To Group
*/
public final long SendNumberGroupSchedule(String UserName, String Password, long[] NumberGroupID, String Message, String SpecialNumber, boolean IsFlash, boolean DontSendToRepeatedNumber, int Year, int Month, int Day, int Hour, int Minute)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.SendNumberGroupSchedule(UserName, Password, NumberGroupID, Message, SpecialNumber, IsFlash, DontSendToRepeatedNumber, Year, Month, Day, Hour, Minute);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {

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
public Shared Function SendNumberGroupSchedule(UserName As String, Password As String, NumberGroupID As Long(), Message As String, SpecialNumber As String, IsFlash As Boolean, _
    DontSendToRepeatedNumber As Boolean, Year As Integer, Month As Integer, Day As Integer, Hour As Integer, Minute As Integer) As Long
    Using SMSService As New SOAP.SMS()
        Return SMSService.SendNumberGroupSchedule(UserName, Password, NumberGroupID, Message, SpecialNumber, IsFlash, _
            DontSendToRepeatedNumber, Year, Month, Day, Hour, Minute)
    End Using
End Function

End Class
```