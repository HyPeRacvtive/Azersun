using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DataAccess.Concrete.EFCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new DataContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(products);
                }
                if (context.Products.Count() == 0)
                {

                    context.Messages.AddRange(messages);
                }
                if (context.Abouts.Count() == 0)
                {
                    context.Abouts.AddRange(abouts);
                }
                if (context.Sliders.Count() == 0)
                {
                    context.Sliders.AddRange(sliders);
                }
                if (context.Settings.Count() == 0)
                {
                    context.Settings.AddRange(settings);
                }
                if (context.SocialMedia.Count() == 0)
                {
                    context.SocialMedia.AddRange(sm);
                }
                if (context.Videos.Count() == 0)
                {
                    context.Videos.AddRange(videos);
                }
                if (context.Admins.Count() == 0)
                {
                    context.Admins.AddRange(admin);
                }
            }
            context.SaveChanges();
        }

        private static Product[] products ={
             new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now ,Statu=true,ProductImage="mahsul-image1.png",Height=30,Width=30,Stock=100},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsul-image2.png",Height=60,Width=60,Stock=90},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image3.png",Height=50,Width=50,Stock=125},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsullar-image4.png",Height=70,Width=70,Stock=741},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsul-image1.png",Height=30,Width=30,Stock=803},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image2.png",Height=60,Width=60,Stock=33},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image3.png",Height=50,Width=50,Stock=42},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsullar-image4.png",Height=70,Width=70,Stock=487},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsul-image1.png",Height=30,Width=30,Stock=523},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image2.png",Height=60,Width=60,Stock=981},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image3.png",Height=50,Width=50,Stock=345},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsullar-image4.png",Height=70,Width=70,Stock=112},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image1.png",Height=30,Width=30,Stock=642},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsul-image2.png",Height=60,Width=60,Stock=490},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image3.png",Height=50,Width=50,Stock=500},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsullar-image4.png",Height=70,Width=70,Stock=100},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image1.png",Height=30,Width=30,Stock=100},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsul-image2.png",Height=60,Width=60,Stock=90},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image3.png",Height=50,Width=50,Stock=125},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsullar-image4.png",Height=70,Width=70,Stock=741},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsul-image1.png",Height=30,Width=30,Stock=803},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image2.png",Height=60,Width=60,Stock=33},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image3.png",Height=50,Width=50,Stock=42},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsullar-image4.png",Height=70,Width=70,Stock=487},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsul-image1.png",Height=30,Width=30,Stock=523},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image2.png",Height=60,Width=60,Stock=981},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image3.png",Height=50,Width=50,Stock=345},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsullar-image4.png",Height=70,Width=70,Stock=112},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image1.png",Height=30,Width=30,Stock=642},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=false,ProductImage="mahsul-image2.png",Height=60,Width=60,Stock=490},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsul-image3.png",Height=50,Width=50,Stock=500},
                new Product() {ProductName="Sun Salfet",CreateDate=DateTime.Now,Statu=true,ProductImage="mahsullar-image4.png",Height=70,Width=70,Stock=100},
        };
        private static Messages[] messages = {
             new Messages() {Mail="mehmetgon@hotmail.com",FirstName="Mehmet",LastName="Gön",Phone="01234567891",IsRead=false,Subject="Deneme",IpAdress="91.93.113.253",Message="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."},
                new Messages() {Mail="aliveli@hotmail.com",FirstName="Ali",LastName="Veli",Phone="03216987452",IsRead=false,Subject="Deneme1",IpAdress="151.174.39.142",Message="Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir." },
                new Messages() {Mail="omeromer@hotmail.com",FirstName="Ömer",LastName="Ömer",Phone="07896354123",IsRead=false,Subject="Denem2",IpAdress="88.326.153.96",Message="Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan de Finibus Bonorum et Malorum (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan Lorem ipsum dolor sit amet 1.10.32 sayılı bölümdeki bir satırdan gelmektedir."},
                new Messages() {Mail="mehmetgon@hotmail.com",FirstName="Mehmet",LastName="Gön",Phone="03694253674",IsRead=false,Subject="Deneme3",IpAdress="413.811.697.453",Message="Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?"},


        };
        private static About[] abouts = {
         new About(){Image="home-about.png",Text="SUN gigiyenik kağız markası 20 ildən artıq müddətdir ki, daxili bazarda lider məhsullardan birinə çevrilib. Bu marka tarixə ilk yerli gigiyenik kağız brendi kimi düşmüşdür. SUN markasının özəlliklərindən ən əsası onun hər bir ailə üzvü tərəfindən istifadə edilməsidir. Məhsulların müxtəlif ölçülərdə olması ev və iş yerləri üçün sərfəli salfetləri, kağız, qutu, cib dəsmalları illərdir ki, hər kəsin sağlamlığını qoruyur." }
        };
        private static Sliders[] sliders = {
          new Sliders(){Header="Gələcək sağlam olSUN!",Content="SUN gigiyenik kağız markası 20 ildən artıq müddətdir ki, daxili bazarda lider məhsullardan birinə çevrilib.",Image="home-slider-1.jpg" },
          new Sliders(){Header="Sun Paper",Content="SUN gigiyenik kağız markası 20 ildən artıq müddətdir ki, daxili bazarda lider məhsullardan birinə çevrilib.",Image="home-slider-2.jpg" },

        };
        private static Settings[] settings = {
             new Settings() {Logo="logo.svg",Phone="(+99412) 404 19 19",Mail="info@azersun.com",Adress="Heydər Əliyev pr., 92a Bakı, Azərbaycan, AZ1029",Map="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3037.95612412804!2d49.89241271563385!3d40.40982276398306!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x403062b9b75d7abf%3A0x1196186aad77cb20!2sAzersun%20Holding!5e0!3m2!1sen!2str!4v1637259086159!5m2!1sen!2str",ProjectText="SUN markası ənənəvi olaraq hər il bölgə əhalisini şəxsi gigiyena mövzusunda maarifləndirir. Qapıdan - qapıya gəzərək tualet kağızı istifadə edilmədikdə yayılan xəstəliklər və bunun fəsadları barədə həkim nümayəndə vasitəsiylə kənd əhalisini məlumatlandırır. Digər ənənəyə çevrilmiş layihəmiz Məktəbli layihəsidir. Uşaqlıqdan qazanılan bilik daşa həkk olunan yazıdır. - deyirlər. Biz də məhsul qrupu olaraq hədəfimizi böyük tutub, məktəblərdə maarifləndirmə layihəmizi həm əyləncəli, həm də interaktiv şəkildə həyata keçirməyi özümüzə məqsəd qoyduq."}
        };
        private static SocialMedia[] sm = {
          new SocialMedia(){Name="Facebook",Link="https://tr-tr.facebook.com/",Icon="bi bi-facebook"},
          new SocialMedia(){Name="Instagram",Link="https://www.instagram.com/",Icon="bi bi-instagram"},
           new SocialMedia(){Name="Youtube",Link="https://www.youtube.com/",Icon="bi bi-youtube"}

        };
        private static Videos[] videos = {
            new Videos(){Image="layihe-image1.png",Link="https://www.youtube.com/watch?v=CbasHrrBP9M" },
                new Videos(){Image="leyiha-image-2.png",Link="https://www.youtube.com/watch?v=CbasHrrBP9M" },
                new Videos(){Image="layihe-image1.png",Link="https://www.youtube.com/watch?v=CbasHrrBP9M" },
                new Videos(){Image="layihe-image1.png",Link="https://www.youtube.com/watch?v=CbasHrrBP9M" },
                new Videos(){Image="leyiha-image-2.png",Link="https://www.youtube.com/watch?v=CbasHrrBP9M" },
                 new Videos(){Image="layihe-image1.png",Link="https://www.youtube.com/watch?v=CbasHrrBP9M" },
                new Videos(){Image="leyiha-image-2.png",Link="https://www.youtube.com/watch?v=CbasHrrBP9M" },
                 new Videos(){Image="leyiha-image-2.png",Link="https://www.youtube.com/watch?v=CbasHrrBP9M" },
                new Videos(){Image="layihe-image1.png",Link="https://www.youtube.com/watch?v=CbasHrrBP9M" },
        };
        private static Admin[] admin = {
                            new Admin(){UserName="admin",Password="admin",Mail="mehmetgon@hotmail.com",NameSurname="Admin Admin",Address="Adana/Seyhan",Phone="05553331122",Image="Admin.jpg"},
                            new Admin(){UserName="mehmet",Password="664189++",Mail="mehmetgon@hotmail.com",NameSurname="Mehmet GÖN",Address="Adana/Seyhan",Phone="05327440418",Image="Admin.jpg"}

        };
    }
}
