# آبجکت NumberGroupItem

- [آبجکت NumberGroupItem](#آبجکت-numbergroupitem)
  - [خصوصیات](#خصوصیات)

در پاسخ به درخواست کاربر در خصوص دریافت اطلاعات گروه های موجود در دفتر تلفن سامانه مدیریت پیام کوتاه ، آرایه ای از آبجکت ها با نوع NumberGroupItem ارسال می گردد که فرمت این آبجکت در ذیل بیان شده است :

## خصوصیات

<table dir="rtl" align="center">
<tr><th>نام خصوصیت</th><th>نوع خصوصیت</th><th>توضیح</th></tr>
<tr><td>NumberGroupID</td><td>Long Integer</td><td>شناسه گروه شماره ها دفتر تلفن</td></tr>
<tr><td>NumberCount</td><td>Integer</td><td>تعداد شماره های موجود در گروه</td></tr>
<tr><td>FarsiName</td><td>String</td><td>نام فارسی گروه</td></tr>
<tr><td>EnglishName</td><td>String</td><td>نام انگلیسی گروه</td></tr>
<tr><td>Priority</td><td>Integer</td><td>الویت تعیین شده برای گروه توسط کاربر</td></tr>
</table>