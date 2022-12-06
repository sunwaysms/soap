# راهنمای متد GetNumberGroupData

- [راهنمای متد GetNumberGroupData](#راهنمای-متد-getnumbergroupdata)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد GetNumberGroupData](#نکات-مهم-در-مورد-کار-با-متد-getnumbergroupdata)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

برای دریافت اطلاعات گروه های موجود در دفتر تلفن سامانه مدیریت ارسال و دریافت پیام کوتاه خود از این متد استفاده بفرمایید . با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید .

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>نوع</th><th>توضیح</th></tr>
<tr><td>Array Of NumberGroupItem</td><td>آرایه ای از آبجکت NumberGroupItem</td></tr>
</table>

- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/url/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/url/blob/main/Errors.md)

## نکات مهم در مورد کار با متد GetNumberGroupData

- فقط کاربرانی می توانند از این متد استفاده کنند که هم کاربر وب سرویس و هم کاربر سامانه مدیریت پیام کوتاه باشند.
- دقت کنید که خروجی این متد آرایه ای از آبجکت NumberGroupItem می باشد و اطلاعات گروه دفتر تلفن شما در این آبجکت قرار دارد ، که با استفاده از این اطلاعات و متد SendNumberGroup یا SendNumberGroupSchedule می توانید پیام گروهی ارسال کنید . فرمت آبجکت مذکور در فایل WSDL موجود می باشد .

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

    public Function GetNumberGroupData(){
        $option = array('UserName'=> $this->Username,'Password'=> $this->Password);
        $client = $this->GetClient();
        return $client->GetNumberGroupData($option)->GetNumberGroupDataResult;
    }

}
```

### Java

```Java
/** 
    Get Number Group Data
         
    @param UserName String
    @param Password String
    @return NumberGroupItem
*/
public final SOAP.NumberGroupItem[] GetNumberGroupData(String UserName, String Password)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.GetNumberGroupData(UserName, Password);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {

/// <summary>
/// Get Number Group Data
/// </summary>
/// <param name="UserName">String</param>
/// <param name="Password">String</param>
/// <returns>NumberGroupItem</returns>
public static SOAP.NumberGroupItem[] GetNumberGroupData(string UserName, string Password) {
    using (SOAP.SMS SMSService = new SOAP.SMS()) {
        return SMSService.GetNumberGroupData(UserName, Password);
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
''' Get Number Group Data
''' </summary>
''' <param name="UserName">String</param>
''' <param name="Password">String</param>
''' <returns>NumberGroupItem</returns>
public Shared Function GetNumberGroupData(UserName As String, Password As String) As SOAP.NumberGroupItem()
    Using SMSService As New SOAP.SMS()
        Return SMSService.GetNumberGroupData(UserName, Password)
    End Using
End Function

End Class
```