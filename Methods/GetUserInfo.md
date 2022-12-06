# راهنمای متد GetUserInfo

- [راهنمای متد GetUserInfo](#راهنمای-متد-getuserinfo)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد GetUserInfo](#نکات-مهم-در-مورد-کار-با-متد-getuserinfo)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

با استفاده از این متد شما می توانید به اطلاعات کاربر دسترسی پیدا کنید. با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید .

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>کلید</th><th>توضیح</th></tr>
<tr><td>ProfileInfo</td><td>آبجکت شامل اطلاعات کاربری است</td></tr>
</table>

- [ توضیحات آبجکت ProfileInfo](https://github.com/sunwaysms/soap/blob/main/Objects/ProfileInfo.md)
- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/soap/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)

## نکات مهم در مورد کار با متد GetUserInfo
- مقدار بازگشتی این متد، آبجکت ProfileInfo که شامل شامل اطلاعات کاربری می باشد . فرمت آبجکت مذکور در فایل WSDL موجود می باشد .

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

}
```

### Java

```Java
/** 
    Get User Info
         
    @param UserName String
    @param Password String
    @return ProfileInfo
*/
public final SOAP.ProfileInfo GetUserInfo(String UserName, String Password)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.GetUserInfo(UserName, Password);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {

/// <summary>
/// Get User Info
/// </summary>
/// <param name="UserName">String</param>
/// <param name="Password">String</param>
/// <returns>ProfileInfo</returns>
public static SOAP.ProfileInfo GetUserInfo(string UserName, string Password) {
    using (SOAP.SMS SMSService = new SOAP.SMS()) {
        return SMSService.GetUserInfo(UserName, Password);
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
''' Get User Info
''' </summary>
''' <param name="UserName">String</param>
''' <param name="Password">String</param>
''' <returns>ProfileInfo</returns>
public  Shared Function GetUserInfo(UserName As String, Password As String) As SOAP.ProfileInfo
    Using SMSService As New SOAP.SMS()
        Return SMSService.GetUserInfo(UserName, Password)
    End Using
End Function

End Class
```