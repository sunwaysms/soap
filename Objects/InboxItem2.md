# آبجکت InboxItem2

- [آبجکت InboxItem2](#آبجکت-inboxitem2)
  - [خصوصیات](#خصوصیات)

در پاسخ به درخواست کاربر در خصوص دریافت پیامک های دریافتی ، آبجکت ResultInbox که شامل آرایه ای از آبجکت ها با نوع InboxItem2 ارسال می گردد که فرمت این آبجکت در ذیل بیان شده است :

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

- [ توضیحات آبجکت ResultInbox](https://github.com/sunwaysms/soap/blob/main/Objects/ResultInbox.md)