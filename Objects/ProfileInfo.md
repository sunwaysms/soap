# آبجکت ProfileInfo

- [آبجکت ProfileInfo](#آبجکت-profileinfo)
  - [خصوصیات](#خصوصیات)

در پاسخ به درخواست کاربر در خصوص دریافت اطلاعات کاربری ، آبجکت با نوع ProfileInfo ارسال می گردد که فرمت این آبجکت در ذیل بیان شده است :

## خصوصیات

<table dir="rtl" align="center">
<tr><th>نام خصوصیت</th><th>نوع خصوصیت</th><th>توضیح</th></tr>
<tr><td>SMSCredit</td><td>Integer</td><td>میزان اعتبار کاربر به ریال</td></tr>
<tr><td>TotalSendSMS</td><td>Integer</td><td>تعداد پیامک های ارسالی کاربر</td></tr>
<tr><td>TotalReciveSMS</td><td>Integer</td><td>تعداد پیامک های دریافتی کاربر (شامل خوانده شده و خوانده نشده)</td></tr>
<tr><td>totalIncomeSMSField</td><td>Integer</td><td>تعداد پیامک های دریافتی کاربر (شامل خوانده نشده ها)</td></tr>
<tr><td>Notifications</td><td>String</td><td>عنوان اعلانات کاربر(به صورت اختصاصی برای کاربر ارسال شده است)</td></tr>
<tr><td>NotificationsDisc</td><td>String</td><td>متن اعلانات کاربر (به صورت اختصاصی برای کاربر ارسال شده است)</td></tr>
<tr><td>NotificationsDate</td><td>DateTime</td><td>تاریخ ارسال اعلانات (به صورت اختصاصی برای کاربر ارسال شده است)</td></tr>
<tr><td>PublicNotifications</td><td>String</td><td>عنوان اعلانات کاربر (به صورت سراسری برای تمامی کاربران ارسال شده است)</td></tr>
<tr><td>PublicNotificationsDisc</td><td>String</td><td>متن اعلانات کاربر(به صورت سراسری برای تمامی کاربران ارسال شده است)</td></tr>
<tr><td>PublicNotificationsDate</td><td>DateTime</td><td>تاریخ ارسال اعلانات(به صورت سراسری برای تمامی کاربران ارسال شده است)</td></tr>
<tr><td>Status</td><td>Long Integer</td><td>وضعیت کاربر (در بخش 6 با ذکر شماره و توضیحات مربوطه آورده شده است)</td></tr>
</table>

[مشاهده لیست کدهای خطا و توضیحات مربوط به هر کدام](https://github.com/sunwaysms/soap/blob/main/Errors.md)