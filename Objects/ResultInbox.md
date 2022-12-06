# آبجکت ResultInbox

- [آبجکت ResultInbox](#آبجکت-resultinbox)
  - [خصوصیات](#خصوصیات)

در پاسخ به درخواست کاربر در خصوص دریافت پیامک های دریافتی ، آبجکت ResultInbox ارسال می گردد که فرمت این آبجکت در ذیل بیان شده است :

## خصوصیات

<table dir="rtl" align="center">
<tr><th>نام خصوصیت</th><th>نوع خصوصیت</th><th>توضیح</th></tr>
<tr><td>Messages</td><td>Array Of InboxItem2</td><td>شامل اطلاعات پیامک های دریافتی</td></tr>
<tr><td>Status</td><td>Integer</td><td>کد خطا</td></tr>
<tr><td>SenderNumber</td><td>String</td><td>شماره فرستنده ( شماره موبایل فرستنده پیامک )</td></tr>
<tr><td>MessageBody</td><td>String</td><td>متن پیامک</td></tr>
<tr><td>ReceiveDate</td><td>String</td><td>تاریخ و ساعت دریافت پیامک</td></tr>
<tr><td>UDH</td><td>String</td><td>سرآیند پیامک دریافتی</td></tr>
</table>

- [ توضیحات آرایه InboxItem2](https://github.com/sunwaysms/soap/blob/main/Objects/InboxItem2.md)
- [مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)