# راهنمای متد InsertNumberInNumberGroup

- [راهنمای متد InsertNumberInNumberGroup](#راهنمای-متد-insertnumberinnumbergroup)
  - [پارامترهای ورودی](#پارامترهای-ورودی)
  - [خروجی متد](#خروجی-متد)
  - [نکات مهم در مورد کار با متد InsertNumberInNumberGroup](#نکات-مهم-در-مورد-کار-با-متد-insertnumberinnumbergroup)
  - [نمونه کد](#نمونه-کد)
    - [PHP](#php)
    - [Java](#java)
    - [C#](#c)
    - [VB.net](#vbnet)

برای افزودن یک یا چند شماره تلفن همراه به یک گروه خاص از دفتر تلفن سامانه مدیریت پیام کوتاه خود از این متد استفاده کنید . با توجه به جدول ذیل پارامتر های این متد را مقدار دهی کنید .

## پارامترهای ورودی

<table dir="rtl" align="center">
<tr><th>نام</th><th>نوع</th><th>اجباری / اختیاری</th><th>توضیح</th></tr>
<tr><td>UserName</td><td>String</td><td>اجباری</td><td>نام کاربری</td></tr>
<tr><td>Password</td><td>String</td><td>اجباری</td><td>کلمه عبور</td></tr>
<tr><td>NumberGroupID</td><td>String</td><td>اجباری</td><td>شناسه گروه دفتر تلفن</td></tr>
<tr><td>PersonNumber</td><td>String</td><td>اجباری</td><td>شماره افراد مورد نظر</td></tr>
<tr><td>PersonName</td><td>String</td><td>اختیاری</td><td>نام افراد مورد نظر</td></tr>
</table>

## خروجی متد

<table dir="rtl" align="center">
<tr><th>نوع</th><th>توضیح</th></tr>
<tr><td>Array Of Long Integer</td><td>آرایه ای که نشان دهنده موفقیت آمیز بودن ثبت و یا کدهای خطا می باشد</td></tr>
</table>

- [ توضیح کامل هر یک از کلمات کلیدی](https://github.com/sunwaysms/soap/blob/main/Parameters.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)

## نکات مهم در مورد کار با متد InsertNumberInNumberGroup

- فقط کاربرانی می توانند از این متد استفاده کنند که هم کاربر وب سرویس و هم کاربر سامانه مدیریت پیام کوتاه باشند.
- پارامتر PersonName اختیاری می باشد ، به این معنی که اگر قصد ارسال آن را ندارید ، یا مقدار null و یا آرایه ای با طول صفر را به متد ارسال کنید .
- اگر پارامتر PersonName را به متد ارسال می نمایید دقت کنید که طول آرایه آن با طول آرایه PersonNumber برابر باشد و همچنین نام هر فرد متناظر با شماره قرار گرفته در آرایه PersonNumber ارسال گردد .
- خروجی این متد یا عدد 50 می باشد که نشان دهنده موفقیت آمیز بودن روند ثبت اطلاعات هر فرد است و یا کدهای خطا می باشد که با توجه به جدول کد خطاها از نوع خطاها اطلاع حاصل نمایید .

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
   
    public Function InsertNumberInNumberGroup($NumberGroupID, $PersonNumberArray, $PersonNameArray){
        $option = array('UserName'=> $this->Username,'Password'=> $this->Password,
                        'NumberGroupID'=> $NumberGroupID, 
                        'PersonNumber'=> $PersonNumberArray,
                        'PersonName'=> $PersonNameArray);
        
        $client = $this->GetClient();
        return $client->InsertNumberInNumberGroup($option)->InsertNumberInNumberGroupResult;
    }

}
```

### Java

```Java
/** 
    Insert Number To PhoneBook
         
    @param UserName String
    @param Password String
    @param NumberGroupID long GroupID
    @param PersonNumber Array of String 
    @param PersonName Array of String 
    @return Array of long 
*/
public final long[] InsertNumberInNumberGroup(String UserName, String Password, long NumberGroupID, String[] PersonNumber, String[] PersonName)
{
    try (SOAP.SMS SMSService = new SOAP.SMS())
    {
        return SMSService.InsertNumberInNumberGroup(UserName, Password, NumberGroupID, PersonNumber, PersonName);
    }
    catch (RuntimeException ex){}
}
```

### C#

```C#
public static class API {

/// <summary>
/// Insert Number To PhoneBook
/// </summary>
/// <param name="UserName">String</param>
/// <param name="Password">String</param>
/// <param name="NumberGroupID">long GroupID</param>
/// <param name="PersonNumber">Array of String </param>
/// <param name="PersonName">Array of String </param>
/// <returns>Array of long </returns>
public static long[] InsertNumberInNumberGroup(string UserName, string Password, long NumberGroupID, string[] PersonNumber, string[] PersonName) {
    using (SOAP.SMS SMSService = new SOAP.SMS()) {
        return SMSService.InsertNumberInNumberGroup(UserName, Password, NumberGroupID, PersonNumber, PersonName);
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
''' Insert Number To PhoneBook
''' </summary>
''' <param name="UserName">String</param>
''' <param name="Password">String</param>
''' <param name="NumberGroupID">long GroupID</param>
''' <param name="PersonNumber">Array of String </param>
''' <param name="PersonName">Array of String </param>
''' <returns>Array of long </returns>
public  Shared Function InsertNumberInNumberGroup(UserName As String, Password As String, NumberGroupID As Long, PersonNumber As String(), PersonName As String()) As Long()
    Using SMSService As New SOAP.SMS()
        Return SMSService.InsertNumberInNumberGroup(UserName, Password, NumberGroupID, PersonNumber, PersonName)
    End Using
End Function

End Class
```