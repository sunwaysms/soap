# راهنمای متد SendNumberGroup

- [راهنمای متد SendNumberGroup](#راهنمای-متد-sendnumbergroup)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد SendNumberGroup](#نکات-مهم-در-مورد-کار-با-متد-sendnumbergroup)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

برای ارسال پیامک به یک یا چند گروه خاص از دفتر تلفن موجود در سامانه مدیریت پیام کوتاه خود از این متد استفاده کنید . با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید .

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
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>نوع</th><th>توضیح</th></tr>
<tr><td>Long Integer</td><td>کد رهگیری ارسال یا کد خطا</td></tr>
</table>

- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/url/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/url/blob/main/Errors.md)

## نکات مهم در مورد کار با متد SendNumberGroup

- فقط کاربرانی می توانند از این متد استفاده کنند که هم کاربر وب سرویس و هم کاربر سامانه مدیریت پیام کوتاه باشند.
- مقدار خروجی این متد کد رهگیری ارسال می باشد ، که با مراجعه به سامانه مدیریت پیام کوتاه خود می توانید در لیست پیام های ارسال شده از وضعیت ارسال پیامک های خود مطلع شوید .
- شما می توانید در شناسه گروه دفتر تلفن ( NumberGroupID ) ، به یک یا چند گروه ( حداکثر 1000 گروه ) پیامک ارسال کنید .
- قبل از ارسال حتما باید با استفاده از متد GetNumberGroupData از شناسه گروه دفتر تلفن (NumberGroupID) آگاه شوید ، و مطمئن شوید گروه یا گروه های مورد نظر شما حذف نشده باشند و شناسه آن ها معتبر باشد .

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
    
    public Function SendNumberGroup($NumberGroupIDArray, $MessageBody, $SpecialNumber, $IsFlashMessage, $DontSendToRepeatedNumber){
        $option = array('UserName'=> $this->Username,'Password'=> $this->Password,
                        'NumberGroupID'=> $NumberGroupIDArray, 
                        'MessageBody'=> $MessageBody,
                        'SpecialNumber'=> $SpecialNumber,
                        'IsFlashMessage'=> $IsFlashMessage,
                        'DontSendToRepeatedNumber'=> $DontSendToRepeatedNumber);
                        
        $client = $this->GetClient();
        return $client->SendNumberGroup($option)->SendNumberGroupResult;
    }

}
```

### Java

```Java
/** 
    Send To Group Number
         
    @param UserName String
    @param Password String
    @param NumberGroupID long[] GroupIDs
    @param Message Text of your SMS
    @param SpecialNumber Your Special number ,send sms from this number
    @param IsFlash True/False
    @param DontSendToRepeatedNumber True/False
    @return SendID for Send To Group
*/
public final long SendNumberGroup(String UserName, String Password, long[] NumberGroupID, String Message, String SpecialNumber, boolean IsFlash, boolean DontSendToRepeatedNumber)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.SendNumberGroup(UserName, Password, NumberGroupID, Message, SpecialNumber, IsFlash, DontSendToRepeatedNumber);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {

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
        return SMSService.SendNumberGroup(UserName, Password,NumberGroupID,Message,SpecialNumber,IsFlash,DontSendToRepeatedNumber);
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
public Shared Function SendNumberGroup(UserName As String, Password As String, NumberGroupID As Long(), Message As String, SpecialNumber As String, IsFlash As Boolean, _
    DontSendToRepeatedNumber As Boolean) As Long
    Using SMSService As New SOAP.SMS()
        Return SMSService.SendNumberGroup(UserName, Password, NumberGroupID, Message, SpecialNumber, IsFlash, _
            DontSendToRepeatedNumber)
    End Using
End Function

End Class
```