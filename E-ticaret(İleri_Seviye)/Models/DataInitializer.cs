using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_ticaret_İleri_Seviye_.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            List<Course> courses = new List<Course>()
            {
                new Course
                {
                    CourseName="C# Eğitim Videosu",
                    Description ="C# diline temel seviyeden başlayarak, birlikte ileri seviyeye kadar geliyor olacağız Object-Oriented programlama mantığını adınız gibi öğreneceksiniz Programlamanın temel yapı taşlarını öğrenerek bilinçli kod yazabilir hale geleceksiniz Ezbere değil, bilinçli ve anlaşılır kod yazmayı öğreneceksiniz ",
                    Price = "51.99",
                    WhatWillYouLearn ="C# dilini en doğru şekilde öğrenin. ",
                    CourseImage = "/theme/img/alper.jpg",
                    CourseLanguage ="Türkçe",
                    CourseLectures  = 80,
                    CourseLenght = "15.09",
                    CourseReyting = "4.7",
                    PersonAdded = 10328,
                    CategoryId = 1,
                    Instructors = new List<Instructor>(){  context.Instructors.Where(i=>i.Name == "Alper").FirstOrDefault() }
        },
                new Course
                {
                    CourseName="Asp.NET MVC Yönetim Panelli Kurumsal Web Sitesi Eğitimi",
                    Description ="AspNET MVC ile Sıfırdan Web Sitesi ve Yönetim Paneli Kodlaması, Entity Framework DatabaseFirst-CodeFirst Yaklaşımları Veritabanı CRUD İşlemleri, HTML+CSS Template Tasarımın MVC Projesi ile Entegrasyonu, Entity Frtamework Veritabanı CRUD İşlemleri, Dosya Resim Yükleme-Silme Veritabanı Kayıt İşlemleri, CKEditör Entegrasyonu ve Zengin Metin İçeriklerinin Veritabanına Eklenmesi, MVC Layouts Sayfaları Kullanımı, MSSQL Studio ile Veritabanı Oluşturma, MVC Kullanıcı Giriş ve Şifre Yenileme Uygulamaları, Bootstrap Kütüphanesi Kullanımı, Temel HTML+CSS Kullanım Örnekleri, Entity Framework Scaffolding Yapısı SEO Ayarları Projenin Web Hosting Üzerinde Yayınlanması Veritabanı CRUD İşlemleri Üye Giriş Yetki ve Sayfalara Erişimin Kısıtlanması Bildirim Yönetimi Yorum Ekleme ve Yorum Onay Mekanizması Nuget Paket Yöneticisi Kullanımı JQuery ile Veri Ekleme İşlemleri JSON Veri ekleme Slider Yapımı IPagedList ile Blog Kayıtlarını Sayfalama JQuery Datatables ile Otomatik Sayfalama Sıralama Filtreleme Gmail Üzerinden Mail Gönderme Şifremi Unuttum ve Şifre Yenilenmesi Şifrelerin Veritabanına MD5 Olarak Kayıt Edilmesi Crypto Helpers ile Veri Şifreleme ",
                    Price = "47.99",
                    WhatWillYouLearn ="Web Uygulamaları Geliştirme: Asp.NET MVC, Entity Framework, Codefirst, SQL, HTML+CSS+JS, Bootstrap ve Proje Uygulama ",
                    CourseImage = "/theme/img/mustafa.jpg",
                    CourseLanguage = "Türkçe",
                    CourseLectures = 98,
                    CourseLenght = "17:22",
                    CourseReyting = "4.7",
                    PersonAdded = 3668,
                    CategoryId = 2
                },
                new Course
                {
                    CourseName="(110+ Saat) Komple Uygulamalı Web Geliştirme Eğitimi | 2020 ",
                    Description =" Web geliştirici olmak için gereken tüm konuları öğrenip kariyerinize iyi bir başlangıç yapabileceksiniz. Web Tasarımınızı sıfırdan kendiniz adım adım yapabileceksiniz. Bir blog sitesi yada bir şirketin tanıtım sitesini kolaylıkla yapabileceksiniz., Web sitelerinize bir yönetim paneli ekleyip dinamik içeriklerinizi bir yerden yönetebileceksiniz., Kurs sonunda donanımlı bir web geliştirici olup bu alanda para kazanıyor olabileceksiniz.",
                    WhatWillYouLearn ="Sıfırdan ileri seviyeye 'Web Geliştirme': Html,Css,Sass,Flexbox,Angular,Javascript,Bootstrap,JQuery,Asp.Net Mvc&Core Mvc ",
                    CourseImage = "/theme/img/kompleweb.jpg",
                    Price = "47.99",
                    CourseLanguage = "Türkçe",
                    CourseLectures = 680,
                    CourseLenght = "113:20",
                    CourseReyting = "4.6",
                    PersonAdded = 29467,
                    CategoryId = 2
                },
                new Course
                {
                    CourseName="Modern Web Geliştirme Kursu | Sıfırdan Sektörün Yükseklerine ",
                    Description ="Kursu tamamladığınız zaman aranan web geliştirici olabilecek modern teknikleri ve prensipleri öğrenmiş olacaksınız.Kursta farklı frontend teknolojilerinde bolca kullanacağımız HTML5, CSS3, Flexbox, BootStrap detaylıca ve modern tekniklerle öğreneceksiniz.React, Vue ve Angular gibi frameworklerde neyi nerede yaptığınızı anlayabilmeniz için Modern JavaScript (ES6+) ve TypeScripti detaylı öğreneceksiniz.Node nedir, NPM nasıl kullanılır , MongoDb sorguları ve modelleme ipuçları , ExpressJS ile StackOverFlow benzeri (toplamda 10 saat ) Modern Rest Api gibi konuları öğreneceksiniz.React'ın tüm inceliklerini , Redux’ın mantığını ve yeni özelliklerden Hooks kullanmanın avantajlarını öğreneceksiniz.TypeScript öğrendikten sonra Angular’ın tüm inceliklerini öğreneceksiniz.Angular içinde Dependency Injection gibi önemli Yazılım Geliştirme Prensiplerini uygulayarak öğreneceksiniz.VueJS ile frontend geliştirmeyi öğreneceksiniz.Güçlü Backend bizi her zaman korur. Bu sebeple, sektörde kullanılan güçlü backend geliştirme tekniklerini ve prensiplerini sağlam bir şekilde öğreneceksiniz.ExpressJS Temellerini Öğreneceksiniz.MongoDb Veritabanı Modellemeyi Öğreneceksiniz.JWT, Authentication Konularını Öğreneceksiniz. ExpressJS ile Gelişmiş Bir Back End Kodlamayı Öğreneceksiniz. ",
                    Price = "47.99",
                    WhatWillYouLearn ="Modern tekniklerle Web Geliştirme ( Web Development ) Öğrenin. HTML,CSS, Node , JavaScript, React, Angular, Asp.Net Core ",
                    CourseImage = "/theme/img/enginmustafa.jpg",
                    CourseLectures = 696,
                    CourseLanguage = "Türkçe",
                    CourseLenght = "98:7",
                    CourseReyting = "4.7",
                    PersonAdded = 2218,
                    CategoryId = 2
                },
                new Course
                {
                    CourseName="(40+ Saat) Python | Sıfırdan İleri Seviye Programlama (2020) ",
                    Description ="Python'ın ve Programlamanın Temellerini iyi bir şekilde öğrenmiş olacaksınız."+
                        "Python ile Nesne Tabanlı Programlama felsefesini öğrenerek , daha sonra Java ve C++ gibi dilleri öğrenmeye çalıştığınızda oldukça rahat edeceksiniz."+
                       " Python ile Örümcek Türü yazılımlar geliştirebilecek hale geleceksiniz."+
                       " PyQt5 ile Pythonda arayüz geliştirme temellerini alarak, ileri düzey arayüzler ve uygulamalar geliştirebileceksiniz."+
                       " Sqlite Veritabanı ile temel veritabanı işlemlerini öğrenerek, programlarınızı veritabanıyla entegre bir biçimde yazabileceksiniz."+
                       " Pythonda modül kullanımını ve ileri düzey modülleri öğrenerek , işletim sistemi, internet sayfalarından veri alma, fotoğraf işlemleri gibi alanlarda programlar yazabileceksiniz."+
                       "Kurs boyunca oldukça fazla program yazacağımız için, kurstan sonra algoritma yeteneğinizin bir hayli geliştiğini farkedeceksiniz."+
                        "En önemlisi ise, artık CV'nize Python'ı ileri seviyede biliyorum yazabileceksiniz. ",
                    Price = "47.99",
                    WhatWillYouLearn ="(40+ Saat) - Python ve Programlama Öğrenin. Django , Web Geliştirme , Veri Analizi (Pandas , Numpy), Selenium ",
                    CourseImage = "/theme/img/mustafamurat.jpg",
                    CourseLanguage = "Türkçe",
                    CourseLectures = 334,
                    CourseLenght = "41:48",
                    CourseReyting = "4.6",
                    PersonAdded = 62418,
                    CategoryId = 1
                },
                new Course
                {
                    CourseName="Komple React & Redux ve Hooks Kursu | 2019 ",
                    Description ="React nedir? Nasıl çalışır? En doğru tekniklerle öğreneceksiniz.React-Redux nedir? Hangi şartlarda kullanırsınız? Sorularına cevap bulacaksınız.Sadece konu anlatımı değil, üç farklı projede uygularken öğreneceksiniz.Yeni nesil JavaScript tekniklerini öğreneceksiniz.React Hooks gibi yepyeni konuları projeyle beraber öğreneceksiniz.JavaScript ve Bootstrap eksiğiniz varsa, bonus bölümlerinden yararlanabileceksiniz.  ",
                    Price = "47.99",
                    WhatWillYouLearn ="En popüler JavaScript kütüphanesi React ile sektörün yükseklerine çıkın. Redux ve Hooks ile farkınızı ortaya koyun. ",
                    CourseImage = "/theme/img/engin.jpg",
                     CourseLanguage = "Türkçe",
                    CourseLectures = 102,
                    CourseLenght = "15:36",
                    CourseReyting = "4.6",
                    PersonAdded = 1419,
                    CategoryId = 4
                },
                new Course
                {
                    CourseName="Etik Hacker Olma Kursu ",
                    Description ="Kali Linux ile çalışmak, Genel Linux komutlarına hakim olmak, Bir çok temel hacking saldırısına ve önlemlerine hakim olmak, Metasploit kütüphanesine hakim olmak, XSS açıklarını öğrenmek, Websitelerini hackleme yöntemlerine ve önlemlerine hakim olmak, SQL aşılama saldırılarını öğrenmek, SQL kodlarına hakim olmak, Ortadaki Adam saldırılarını öğrenmek, Sosyal mühendislik konusuna hakim olmak, Nmap gibi popüler hacking araçlarını kullanmak, Network Temellerini öğrenmek  ",
                    Price ="47.99",
                    WhatWillYouLearn ="En güncel yazılımların ve araçların kullanımını öğrenerek, canlı örnekler yaparak Etik Hacker olmayı öğrenin! ",
                    CourseImage = "/theme/img/etikhack.jpg",
                    CourseLectures = 187,
                    CourseLenght = "18:41",
                    CourseReyting = "4.7",
                    PersonAdded = 37299,
                    CategoryId = 3
                },
            };
            context.Courses.AddRange(courses);

            List<Instructor> instructors = new List<Instructor>()
            {
                new Instructor
                {
                    Name ="Mustafa",
                    Surname = "Sağlam",
                },
                new Instructor
                {
                    Name ="Alper",
                    Surname = "Çelik",
                },
                new Instructor
                {
                    Name ="Sadık",
                    Surname = "Turan",
                },
                new Instructor
                {
                    Name ="Mustafa Murat",
                    Surname = "Coşkun",
                },
                new Instructor
                {
                    Name ="Engin",
                    Surname = "Demiroğ",
                },
                new Instructor
                {
                    Name ="Atil",
                    Surname = "Samancıoğlu",
                }
            };
            context.Instructors.AddRange(instructors);

            List<Category> categories = new List<Category>()
            {
                new Category{CategoryName ="Programlama Dilleri" },
                new Category{CategoryName ="Web Programlama" },
                new Category{CategoryName ="Siber Güvenlik" },
                new Category{CategoryName ="Framework" }
            };
            context.Categories.AddRange(categories);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}