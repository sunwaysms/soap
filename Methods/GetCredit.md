# راهنمای متد GetCredit

- [راهنمای متد GetCredit](#راهنمای-متد-getcredit)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد GetCredit](#نکات-مهم-در-مورد-کار-با-متد-getcredit)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

با استفاده از این متد شما می توانید از باقیمانده اعتبار پیام کوتاه خود مطلع شوید . 

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>کلید</th><th>توضیح</td></tr>
<tr><td>Long Integer</td><td>باقیمانده اعتبار پیام کوتاه کاربر یا کد خطا</td></tr>
</table>

- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/soap/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)

## نکات مهم در مورد کار با متد GetCredit

- مقدار بازگشتی این متد یک مقدار صحیح است که نشان دهنده باقیمانده اعتبار پیام کوتاه شما می باشد .
- شما می توانید قبل از هر ارسال با استفاده از این متد از باقیمانده اعتبار پیام کوتاه خود مطلع شوید و در صورت کمبود اعتبار ، از ارسال پیامک ها و بروز خطا جلوگیری کنید .

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
    
    public Function GetCredit(){
        $option = array('UserName'=> $this->Username,'Password'=> $this->Password);
        $client = $this->GetClient();
        return $client->GetCredit($option)->GetCreditResult;
    }

}
```

### Java

```Java
/** 
    Get Account Credit
         
    @param UserName String
    @param Password String
    @return long Credit
*/
public final long GetCredit(String UserName, String Password)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.GetCredit(UserName, Password);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {

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
''' Get Account Credit
''' </summary>
''' <param name="UserName">String</param>
''' <param name="Password">String</param>
''' <returns>long Credit</returns>
public  Shared Function GetCredit(UserName As String, Password As String) As Long
    Using SMSService As New SOAP.SMS()
        Return SMSService.GetCredit(UserName, Password)
    End Using
End Function

End Class
```