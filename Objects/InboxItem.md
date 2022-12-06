# آبجکت InboxItem

- [آبجکت InboxItem](#آبجکت-inboxitem)
  - [خصوصیات](#خصوصیات)

در پاسخ به درخواست کاربر در خصوص دریافت پیامک های دریافتی ، آرایه ای از آبجکت ها با نوع InboxItem ارسال می گردد که فرمت این آبجکت در ذیل بیان شده است :

## خصوصیات

<table dir="rtl" align="center">
<tr><th>نام خصوصیت</th><th>نوع خصوصیت</th><th>توضیح</th></tr>
<tr><td>InboxID</td><td>Long Integer</td><td>شناسه پیامک دریافتی</td></tr>
<tr><td>SpecialNumber</td><td>String</td><td>شماره اختصاصی ( شماره ای پیامک را دریافت کرده است )</td></tr>
<tr><td>SenderNumber</td><td>String</td><td>شماره فرستنده ( شماره موبایل فرستنده پیامک )</td></tr>
<tr><td>MessageBody</td><td>String</td><td>متن پیامک</td></tr>
<tr><td>ReceiveDate</td><td>String</td><td>تاریخ و ساعت دریافت پیامک</td></tr>
<tr><td>UDH</td><td>String</td><td>سرآیند پیامک دریافتی</td></tr>
</table>