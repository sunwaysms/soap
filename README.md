# راهنمای استفاده از سرویس SOAP Web Service سان‌وی

- [راهنمای استفاده از سرویس SOAP Web Service سان‌وی](#راهنمای-استفاده-از-سرویس-soap-web-service-سانوی)
  * [۱. نگاه كلی](#۱-نگاه-كلی)
  * [۲. روش کار با وب سرویس](#۲-روش-کار-با-وب-سرویس)
  * [۳. توضیحات متدها](#۳-توضیحات-متدها)
  * [۴. نمونه کد و نمونه پروژه](#۴-نمونه-کد-و-نمونه-پروژه)
  * [تماس با ما](#تماس-با-ما)

## ۱. نگاه كلی

مستند حاضر برای آن دسته از برنامه‌نویسان طراحی شده که می‌خواهند از وب سرویس ارسال و دریافت پیامک SOAP استفاده نمایند.

این Web Service یکی از پیشرفته ترین API های ارسال و دریافت SMS می باشد و شما می توانید با به کارگیری متدهای متنوع و کاربردی آن اقدام به ارسال و دریافت پیامک های (طولانی) فارسی و انگلیسی نمایید .

## ۲. روش کار با وب سرویس

برای استفاده از وب سرویس SOAP در ابتدا شما می بایست صاحب یک حساب کاربری باشید ، در صورت نداشتن حساب کاربری ،شما می توانید با مراجعه به آدرس 

https://sms.sunwaysms.com/shop

سرویس مورد نظر خود را بصورت آنلاین خریداری نموده و یا باید با شرکت تماس حاصل نمایید و جهت خریداری و فعال سازی یک حساب کاربری اقدام نمایید . پس از فعال شدن حساب کاربری ، با داشتن نام کاربری ( UserName ) ، کلمه عبور ( Password ) ، یک یا چند شماره اختصاصی و اعتبار کافی پیام کوتاه شما میتوانید برای استفاده از وب سرویس به گام بعدی بروید .

برای استفاده از وب سرویس SOAP کافی است این سرویس را از آدرس زیر فراخوانی کنید و از یکی از متد های ذکر شده استفاده فرمایید:

https://sms.sunwaysms.com/smsws/soap.asmx

## ۳. توضیحات متدها
 برای مشاهده جزئیات هر متد روی عنوان آن کلیک کنید:
 
- **[متد SendArray برای ارسال پیامک](https://github.com/sunwaysms/soap/blob/main/Methods/SendArray.md)**
- **[متد SendArraySchedule برای ارسال پیامک در زمان خاص](https://github.com/sunwaysms/soap/blob/main/Methods/SendArraySchedule.md)**
- **[متد GetMessageID برای بدست آوردن MessageID با استفاده از CheckingMessageID](https://github.com/sunwaysms/soap/blob/main/Methods/GetMessageID.md)**
- **[متد GetMessageStatus برای دریافت وضعیت پیامک های ارسال شده](https://github.com/sunwaysms/soap/blob/main/Methods/GetMessageStatus.md)**
- **[متد SendNumberGroup برای ارسال به یک/چند گروه خاص از دفتر تلفن کاربر سامانه](https://github.com/sunwaysms/soap/blob/main/Methods/SendNumberGroup.md)**
- **[متد SendNumberGroupSchedule برای ارسال به یک یا چند گروه خاص از دفتر تلفن کاربر سامانه در زمان خاص](https://github.com/sunwaysms/soap/blob/main/Methods/SendNumberGroupSchedule.md)**
- **[متد GetNumberGroupData برای دریافت اطلاعات گروه های موجود در دفتر تلفن کاربر سامانه](https://github.com/sunwaysms/soap/blob/main/Methods/GetNumberGroupData.md)**
- **[متد InsertNumberInNumberGroup برای افزودن شماره تلفن همراه افراد به گروه خاص از دفتر تلفن کاربر سامانه](https://github.com/sunwaysms/soap/blob/main/Methods/InsertNumberInNumberGroup.md)**
- **[متد GetInboxMessage برای دریافت تعدادی از پیامک های ورودی در روز اخیر](https://github.com/sunwaysms/soap/blob/main/Methods/GetInboxMessage.md)**
- **[متد GetInboxMessageWithNumber برای دریافت تعدادی از پیامک های ورودی به شماره خاص در روز اخیر](https://github.com/sunwaysms/soap/blob/main/Methods/GetInboxMessageWithNumber.md)**
- **[متد GetInboxMessageWithInboxID برای دریافت لیستی از پیامک های ورودی با ارسال شناسه اولین پیامک بازه دریافتی](https://github.com/sunwaysms/soap/blob/main/Methods/GetInboxMessageWithInboxID.md)**
- **[متد GetCredit برای اطلاع از میزان اعتبار پیام کوتاه](https://github.com/sunwaysms/soap/blob/main/Methods/GetCredit.md)**
- **[متد GetUserInfo برای دریافت اطلاعات کاربر](https://github.com/sunwaysms/soap/blob/main/Methods/GetUserInfo.md)**

## ۴. نمونه کد و نمونه پروژه

برای آشنایی هرچه بهتر نحوه کار هریک از متدهای فوق شما می توانید از نمونه کدهای زبان‌های مختلف، نوشته شده توسط تیم فنی در انتهای هر متد و همچنین نمونه پروژه‌های آماده در پوشه SampleProjects استفاده نمایید.

## تماس با ما

در صورت نیاز به اطلاعات بیشتر ، می توانید با واحد پشتیبانی تماس حاصل فرمایید

تلفن های واحد پشتیبانی:

<a href="tel:90007197">90007197</a><br>
<a href="tel:02191007197">021-91007197</a><br>
<a href="tel:02634233032">026-34233032</a><br>
<a href="tel:02634233045">026-34233045</a><br>
<a href="tel:02634233049">026-34233049</a>

همچنین میتوانید موارد خود را از طریق بخش تیکت که در سامانه شما موجود می باشد برای کارشناسان ما ارسال کرده و یا از راه های ارتباطی زیر با ما در ارتباط باشید :

ایمیل: support@sunwaysms.com

ارسال فایل: 09334485858 ( در واتس اپ و تلگرام )
