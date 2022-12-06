# تعاریف کلمات کلیدی متدها (اندیس ها)

<table dir="rtl">
<tr>
    <th>نام کاربری (UserName )</th>
    <td>در زمان ایجاد حساب کاربری ، نام کاربری به شما داده می شود . ( اگر شما کاربر سامانه ارسال و دریافت پیام کوتاه نیز می باشید ، لازم به ذکر است که نام کاربری وب سرویس و سامانه شما مشترک می باشد )</td>
</tr>
<tr>
    <th>کلمه عبور ( Password )</th>
    <td>در زمان ایجاد حساب کاربری ، کلمه عبور به شما داده می شود . ( اگر شما کاربر سامانه ارسال و دریافت پیام کوتاه نیز می باشید ، لازم به ذکر است که کلمه عبور وب سرویس و سامانه شما مشترک می باشد )</td>
</tr>
<tr>
    <th>شماره گیرنده ( RecipientNumber )</th>
    <td>آرایه ای از شماره موبایل های افراد گیرنده پیامک . شما می توانید در این آرایه حداقل 1 و حداکثر 1000 عدد شماره موبایل گیرنده را جهت ارسال پیامک قرار دهید . توجه داشته باشید که فرمت شماره می بایست به یکی از شکل های زیر تعریف شود : ( در حال حاضر این سیستم توانایی ارسال پیامک به تمام اپراتورهای معتبر پیام کوتاه را دارد )<br>0912???????		( پیشنهاد می شود از این حالت استفاده کنید )  یازده کاراکتر<br>98912???????		دوازده کاراکتر<br>912???????		ده کاراکتر
    </td>
</tr>
<tr>
    <th>متن پیامک ( MessageBody )</th>
    <td>متن پیامک می تواند به سه صورت فارسی ، انگلیسی یا باینری باشد .</td>
</tr>
<tr>
    <th>شماره اختصاصی (SpecialNumber )</th>
    <td>شماره خط 3000 یا 2000 یا 1000 یا 5000 و ... می باشد که شما جهت ارسال و دریافت پیام کوتاه خریداری کرده اید . دقت بفرمایید که این شماره را فقط به صورت ???????3000 به متد ها ارسال کنید و از قرار دادن 98+ یا 98 در ابتدای آن خوداری کنید .</td>
</tr>
<tr>
    <th><s>ارسال به صورت فلش (IsFlashMessage )</s></th>
    <td><s>پیامک Flash به پیامکی گفته می شود که بدون اینکه در حافظه موبایل گیرینده ذخیره شود ( البته در بعضی از مدل های گوشی اینگونه نیست ) ، بدون تایید کاربر در صفحه نمایش موبایل وی نمایش داده می شود . اگر مقدار این پارامتر را برابر False قرار دهید پیامک ها به صورت معمولی ارسال می گردد ولی اگر مقدار آن را برابر True قرار دهید پیامک ها به صورت Flash ارسال می شوند .</s></td>
</tr>
<tr>
    <th>عدم ارسال به شماره های تکراری (DontSendToRepeatedNumber )</th>
    <td>در متد های ارسال به گروه شماره های دفتر تلفن ، برای جلوگیری از ارسال مکرر به شماره های که در گروه/گروه ها تکرار شده اند شما می توانید با استفاده از این پارامتر از ارسال تکراری جلوگیری کنید . اگر مقدار این پارامتر را برابر False قرار دهید پیامک ها به شماره های تکراری نیز ارسال می گردد ولی اگر مقدار آن را برابر True قرار دهید پیامک ها به شماره های تکرار ارسال نمی گردد.</td>
</tr>
<tr>
    <th>نمایش تمامی پیامک های دریافتی یا فقط پیامک های دریافتی خوانده نشده (IsReaded)</th>
    <td>در متد دریافت پیامک های ورودی جهت دسترسی به تمامی پیامک های دریافتی یا فقط پیامک های دریافتی خوانده نشده به کار می رود . اگر مقدار این پارامتر را برابر False قرار دهید تنها پیامک های دریافتی که خوانده نشده اند نمایش داده می شود ولی اگر مقدار آن را برابر با True قرار دهید تمامی پیامک ها شامل پیامک های خوانده شده و خوانده نشده نمایش داده می شود .</td>
</tr>
</table>