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

Traversal’ı güçlü ve genişletilebilir olması için katmanlı mimaride geliştirdim:

| Katman | Açıklama |
|--------|----------|
| **Entity Layer** | Projedeki tüm domain modellerini oluşturdum. (Destination, Reservation, Guide, AppUser vb.) |
| **Data Access Layer** | EF Core, Generic Repository ve Unit of Work yapısını kullandım. |
| **Business Layer** | İş kurallarını, FluentValidation doğrulamalarını ve servis yapısını buraya yerleştirdim. |
| **DTO Layer** | Veri transferi için Create/Update/Result DTO’larını oluşturdum. |
| **Presentation Layer (MVC)** | Admin & Member panelleri, ViewComponents, Identity, Razor yapısı. |
| **WebAPI** | Swagger destekli REST API geliştirdim. |
| **SignalR Projeleri** | Gerçek zamanlı ziyaretçi takibi için SignalR altyapısı oluşturdum. |


## 🧰 Kullandığım Teknolojiler

### 🔧 Backend
- ASP.NET Core 5 MVC & REST API  
- Entity Framework Core  
- Generic Repository & Unit of Work  
- AutoMapper  
- FluentValidation  
- ASP.NET Core Identity  
- CQRS + MediatR  

### 🗄️ Veritabanı
- SQL Server  
- PostgreSQL (SignalR için)  

### ⚙️ Ek Özellikler
- SignalR ile anlık ziyaretçi takibi  
- Excel (ClosedXML) & PDF (iTextSharp) raporlama  
- MailKit ile mail gönderimi  
- HttpClient ile dış API tüketimi  
- Serilog loglama  

---

## ✨ Uygulama Özellikleri

### 👨‍💼 Admin Paneli
- Rotalar, rehberler, duyurular ve yorum yönetimi  
- Kullanıcı ve rol yönetimi  
- Dashboard istatistikleri  
- PDF / Excel raporları  
- Döviz kuru & film API entegrasyonları  

### 👤 Üye Paneli
- Profil bilgileri  
- Rezervasyon yönetimi (güncel, bekleyen, geçmiş)  
- Yeni rezervasyon oluşturma  

### 🌍 Genel Kullanıcı Arayüzü
- Rotalar listesi  
- Öne çıkan rotalar  
- Rehberler  
- Yorumlar  
- İletişim & bülten aboneliği  


## 🚀 Amacım

Traversal projesi, kurumsal düzeyde bir uygulamanın nasıl geliştirileceğini deneyimlemek için oluşturduğum en kapsamlı projelerden biri.  
Hem mimari hem de pratik anlamda çok şey öğrendiğim bir çalışma oldu.

