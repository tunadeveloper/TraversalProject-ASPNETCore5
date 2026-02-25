# 🧭 Traversal – Tur & Rezervasyon Yönetim Sistemi

![.NET 5](https://img.shields.io/badge/.NET%205-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-5.0-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/EF%20Core-5.0-512BD4?style=flat-square&logo=nuget&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-316192?style=flat-square&logo=postgresql&logoColor=white)
![AutoMapper](https://img.shields.io/badge/AutoMapper-8A2BE2?style=flat-square&logo=nuget)
![FluentValidation](https://img.shields.io/badge/FluentValidation-42A5F5?style=flat-square)
![SignalR](https://img.shields.io/badge/SignalR-0082C9?style=flat-square&logo=signal&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=flat-square&logo=swagger&logoColor=black)
![Bootstrap](https://img.shields.io/badge/Bootstrap-563D7C?style=flat-square&logo=bootstrap&logoColor=white)
![MailKit](https://img.shields.io/badge/MailKit-D14836?style=flat-square&logo=gmail&logoColor=white)
![ClosedXML](https://img.shields.io/badge/ClosedXML-1572B6?style=flat-square)
![iTextSharp](https://img.shields.io/badge/iTextSharp-5C2D91?style=flat-square)
![Serilog](https://img.shields.io/badge/Serilog-4E9A06?style=flat-square&logo=serilog&logoColor=white)
![RapidAPI](https://img.shields.io/badge/RapidAPI-2E7DD7?style=flat-square&logo=rapidapi&logoColor=white)

## 📖 Proje Hakkında

Traversal, tur ve gezi rezervasyon süreçlerini yönetmek için geliştirdiğim **ASP.NET Core 5 tabanlı** bir web uygulamasıdır.  
Ziyaretçiler rotaları görüntüleyebilir, üyeler kendi panelinden rezervasyonlarını yönetebilir ve yöneticiler Admin paneli üzerinden içerikleri kontrol edebilir.

Bu projeyi geliştirerek **katmanlı mimari**, **Identity**, **CQRS**, **MediatR**, **SignalR**, **API entegrasyonları**, **Excel/PDF** gibi birçok kurumsal yapıyı gerçek bir senaryoda uyguladım.


## 🏗️ Mimari Yapı

| Katman | Açıklama |
|--------|----------|
| **Entity Layer** | Projedeki tüm domain modellerini oluşturdum. (Destination, Reservation, Guide, AppUser vb.) |
| **Data Access Layer** | EF Core, Generic Repository ve Unit of Work yapısını kullandım. |
| **Business Layer** | İş kurallarını, FluentValidation doğrulamalarını ve servis yapısını buraya yerleştirdim. |
| **DTO Layer** | Veri transferi için Create/Update/Result DTO’larını oluşturdum. |
| **Presentation Layer (MVC)** | Admin & Member panelleri, ViewComponents, Identity, Razor yapısı. |
| **WebAPI Layer** | Swagger destekli REST API geliştirdim. |
| **SignalR Projeleri** | Gerçek zamanlı ziyaretçi takibi için SignalR altyapısı oluşturdum. |

## 🧰 Kullandığım Teknolojiler

🔧 **Backend:** ASP.NET Core 5 (MVC & REST API), Entity Framework Core, Generic Repository, Unit of Work, AutoMapper, FluentValidation, ASP.NET Core Identity, CQRS, MediatR  
🗄️ **Veritabanı:** SQL Server, PostgreSQL (SignalR için)  
📡 **Gerçek Zamanlı:** SignalR ile anlık ziyaretçi takibi  
📑 **Raporlama:** ClosedXML (Excel), iTextSharp (PDF)  
📬 **İletişim:** MailKit ile mail gönderimi  
🌐 **API Tüketimi:** HttpClient + RapidAPI  
📝 **Loglama:** Serilog  

## ✨ Uygulama Özellikleri

👨‍💼 **Admin Paneli:** Rota, rehber, duyuru, yorum yönetimi; kullanıcı & rol yönetimi; dashboard istatistikleri; PDF/Excel raporları; döviz kuru ve film API entegrasyonları  
👤 **Üye Paneli:** Profil yönetimi, rezervasyon ekranı (güncel / bekleyen / geçmiş), yeni rezervasyon oluşturma  
🌍 **Genel Arayüz:** Rota listeleri, öne çıkan destinasyonlar, rehber profilleri, yorumlar, iletişim formu, bülten aboneliği  

## 🚀 Amacım

Traversal projesi, kurumsal düzeyde bir uygulamanın nasıl geliştirileceğini deneyimlemek için oluşturduğum en kapsamlı çalışmalardan biri. Uygulamanın bazı bölümlerinde gerçek senaryolarda birebir kullanılmayan teknolojilere ve özelliklere de yer verdim. Bunun nedeni, farklı yaklaşımları bizzat uygulama üzerinden öğrenmek ve kurumsal mimaride karşılaşılabilecek yapıları pratik ederek pekiştirmekti.

Hem mimari tasarım hem de uygulama geliştirme pratikleri açısından bana ciddi seviyede deneyim kazandıran bir proje oldu.

## 🎨 Genel Arayüz

<img width="2536" height="1297" alt="Image" src="https://github.com/user-attachments/assets/62d1ab1c-9e70-4700-bafb-573ae6f7ba92" />
<img width="1897" height="901" alt="Image" src="https://github.com/user-attachments/assets/8531f13c-01ce-4c54-b6c7-2b8473541b28" />
<img width="1900" height="922" alt="Image" src="https://github.com/user-attachments/assets/053bee77-f7fc-4c68-a5fc-c6e7843436a9" />
<img width="2531" height="1296" alt="Image" src="https://github.com/user-attachments/assets/8f654238-6179-4f10-915e-379f0e958413" />
<img width="1920" height="4609" alt="Image" src="https://github.com/user-attachments/assets/97ba3b29-f438-471c-9453-88cb48919e29" />
<img width="1920" height="3163" alt="Image" src="https://github.com/user-attachments/assets/fbfc8403-bb24-4f87-a370-6bf22aae5f97" />
<img width="1920" height="1981" alt="Image" src="https://github.com/user-attachments/assets/8a54f536-cff0-4766-9e8b-1f825df659d7" />
<img width="1920" height="2069" alt="Image" src="https://github.com/user-attachments/assets/c81807a3-cdcc-4182-b0db-9ff10c4f2ef8" />
<img width="1920" height="1545" alt="Image" src="https://github.com/user-attachments/assets/cce21397-496d-4988-ae2b-3e06baab8853" />
<img width="1920" height="1926" alt="Image" src="https://github.com/user-attachments/assets/d07b2785-17d4-4cb9-a25c-dac3919c575c" />

## 👤 Kullanıcı Paneli

<img width="1889" height="902" alt="Image" src="https://github.com/user-attachments/assets/d26fd885-96ac-42cd-965d-2c99122e1087" />
<img width="1890" height="932" alt="Image" src="https://github.com/user-attachments/assets/73c488de-4f1a-4ddd-81aa-9b93b1580286" />
<img width="1909" height="928" alt="Image" src="https://github.com/user-attachments/assets/5bdc50e7-c537-4a95-b0a8-0bfb1e8578eb" />
<img width="1903" height="934" alt="Image" src="https://github.com/user-attachments/assets/7e9fd554-a070-454a-9131-bc490fdba0e3" />
<img width="1914" height="935" alt="Image" src="https://github.com/user-attachments/assets/d575f973-a9eb-424d-989b-8a0c82adc9aa" />

## 🛠️ Admin Paneli

<img width="1903" height="933" alt="Image" src="https://github.com/user-attachments/assets/5d1840c2-3508-41b2-bd62-9bb906fa21d5" />
<img width="1898" height="926" alt="Image" src="https://github.com/user-attachments/assets/4df56416-39f4-47a5-9771-692ee359946d" />
<img width="1881" height="931" alt="Image" src="https://github.com/user-attachments/assets/1d73614a-5c40-4e33-b915-6f1a79f65fab" />
<img width="1885" height="932" alt="Image" src="https://github.com/user-attachments/assets/dfd78e33-e6ef-4a9d-93a3-6c3bd0365911" />
<img width="1907" height="931" alt="Image" src="https://github.com/user-attachments/assets/344e21f7-95ad-42b2-b716-92b3da511579" />
<img width="1880" height="913" alt="Image" src="https://github.com/user-attachments/assets/a026b5b4-4e43-4b74-871d-4182d3f3ca69" />
<img width="1900" height="934" alt="Image" src="https://github.com/user-attachments/assets/95463c79-1cba-4010-af63-f061ef9e0072" />
<img width="1901" height="930" alt="Image" src="https://github.com/user-attachments/assets/15cbf940-82ca-4be3-83d6-575390ec11b6" />
<img width="1902" height="933" alt="Image" src="https://github.com/user-attachments/assets/4fe826e3-1fbe-4b71-9cab-c33f4b4646dc" />
<img width="1915" height="934" alt="Image" src="https://github.com/user-attachments/assets/68bad8f8-9840-48c5-a673-147c8d9e4bfb" />
<img width="1894" height="916" alt="Image" src="https://github.com/user-attachments/assets/797a2d30-14e2-4ddc-bb49-7f600435eb32" />
<img width="1826" height="930" alt="Image" src="https://github.com/user-attachments/assets/3c427e73-4b51-4c63-906a-9b20b5a0118d" />
<img width="1911" height="923" alt="Image" src="https://github.com/user-attachments/assets/9109f672-7b24-404f-aed8-10d452f94da9" />
<img width="1851" height="921" alt="Image" src="https://github.com/user-attachments/assets/cc77c317-df0b-4e73-a4f2-3599f6b7e30e" />
<img width="1891" height="929" alt="Image" src="https://github.com/user-attachments/assets/b4f18a0e-36d1-4ff2-897a-df37a0c2eaad" />

## 📘 Swagger

<img width="1627" height="608" alt="Image" src="https://github.com/user-attachments/assets/ea582eba-b984-4dad-9e94-7b281ab73cc0" />

## 🔌 SignalR

<img width="1894" height="934" alt="Image" src="https://github.com/user-attachments/assets/9e4485ad-9c0d-42f8-aa66-5cad5e986a96" />
<img width="530" height="278" alt="Image" src="https://github.com/user-attachments/assets/fbff11b0-aadc-43d6-9e6e-e36042e9780f" />
<img width="530" height="273" alt="Image" src="https://github.com/user-attachments/assets/c7f26f78-8bbc-4303-9170-f69fcb24e9ea" />
