using Microsoft.EntityFrameworkCore;
using TravelGuide.Models;

namespace TravelGuide.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<City> Cities { get; set; }
        public DbSet<Attraction> Attractions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Москва", Region = "Центральный федеральный округ", Population = "13 010 112",
                    ShortDescription = "Столица России, крупнейший город страны.",
                    History = "Москва основана в 1147 году князем Юрием Долгоруким. Веками служила столицей Великого Московского княжества, Российского царства и Российской Федерации. В 1812 году была захвачена Наполеоном, но восстановлена. В советское время появились знаменитые сталинские высотки. Сегодня — крупнейший финансовый и культурный центр России.",
                    PhotoUrl = "/images/cities/moscow.jpg", CoatOfArmsUrl = "/images/coats/moscow.png" },

                new City { Id = 2, Name = "Санкт-Петербург", Region = "Северо-Западный федеральный округ", Population = "5 600 044",
                    ShortDescription = "Северная столица России, город каналов и белых ночей.",
                    History = "Основан Петром I в 1703 году. Служил столицей Российской империи до 1918 года. Во Второй мировой войне выдержал 872-дневную блокаду. Один из красивейших городов мира с уникальной барочной архитектурой.",
                    PhotoUrl = "/images/cities/spb.jpg", CoatOfArmsUrl = "/images/coats/spb.png" },

                new City { Id = 3, Name = "Казань", Region = "Приволжский федеральный округ", Population = "1 316 162",
                    ShortDescription = "Столица Татарстана, место встречи двух культур.",
                    History = "Основана в XIII веке, стала столицей Казанского ханства. В 1552 году взята Иваном Грозным. Уникальное место, где переплетаются татарская и русская культуры. Принимала Универсиаду 2013 и ЧМ по футболу 2018.",
                    PhotoUrl = "/images/cities/kazan.jpg", CoatOfArmsUrl = "/images/coats/kazan.png" },

                new City { Id = 4, Name = "Сочи", Region = "Краснодарский край", Population = "502 537",
                    ShortDescription = "Главный курорт России на черноморском побережье.",
                    History = "Самый длинный город России — 145 км вдоль Черного моря. В советское время стал главной всесоюзной здравницей. Принял Зимние Олимпийские игры 2014 года. Уникальный климат позволяет совмещать море с горнолыжным отдыхом.",
                    PhotoUrl = "/images/cities/sochi.jpg", CoatOfArmsUrl = "/images/coats/sochi.png" },

                new City { Id = 5, Name = "Екатеринбург", Region = "Уральский федеральный округ", Population = "1 537 590",
                    ShortDescription = "Столица Урала, четвёртый по величине город России.",
                    History = "Основан в 1723 году Петром I. Сыграл ключевую роль в индустриализации страны. В 1918 году здесь была расстреляна семья Романовых. В советское время как Свердловск стал крупнейшим промышленным центром. Сегодня — динамично развивающийся мегаполис.",
                    PhotoUrl = "/images/cities/ekb.jpg", CoatOfArmsUrl = "/images/coats/ekb.png" },

                new City { Id = 6, Name = "Новосибирск", Region = "Сибирский федеральный округ", Population = "1 633 595",
                    ShortDescription = "Крупнейший город Сибири, научный и культурный центр.",
                    History = "Основан в 1893 году как поселение при строительстве Транссибирской магистрали. Быстро вырос и получил статус города в 1903 году. В советское время стал крупнейшим промышленным центром Сибири. Здесь расположен знаменитый Академгородок — центр науки России.",
                    PhotoUrl = "/images/cities/novosibirsk.jpg", CoatOfArmsUrl = "/images/coats/novosibirsk.png" },

                new City { Id = 7, Name = "Нижний Новгород", Region = "Приволжский федеральный округ", Population = "1 228 199",
                    ShortDescription = "Пятый город России, слияние Оки и Волги.",
                    History = "Основан в 1221 году как форпост на слиянии Оки и Волги. В XVII веке стал крупнейшим торговым центром — здесь проходила знаменитая Нижегородская ярмарка. В советское время как Горький был закрытым промышленным городом. Сегодня — один из культурных центров Поволжья.",
                    PhotoUrl = "/images/cities/nnov.jpg", CoatOfArmsUrl = "/images/coats/nnov.png" },

                new City { Id = 8, Name = "Владивосток", Region = "Дальневосточный федеральный округ", Population = "603 519",
                    ShortDescription = "Ворота России в Азиатско-Тихоокеанский регион.",
                    History = "Основан в 1860 году как военный пост. Название «Владей Востоком» отражает его стратегическое значение. Конечная точка Транссибирской магистрали. Долгое время был закрытым городом. Сегодня — крупнейший порт Дальнего Востока.",
                    PhotoUrl = "/images/cities/vladivostok.jpg", CoatOfArmsUrl = "/images/coats/vladivostok.png" },

                new City { Id = 9, Name = "Калининград", Region = "Калининградская область", Population = "489 359",
                    ShortDescription = "Самый западный город России, бывший Кёнигсберг.",
                    History = "Основан Тевтонским орденом в 1255 году как Кёнигсберг. Веками был центром Пруссии, родиной философа Иммануила Канта. После Второй мировой войны отошёл к СССР и переименован в Калининград. Уникальный российский эксклав на Балтийском море с богатым европейским наследием.",
                    PhotoUrl = "/images/cities/kaliningrad.jpg", CoatOfArmsUrl = "/images/coats/kaliningrad.png" },

                new City { Id = 10, Name = "Уфа", Region = "Республика Башкортостан", Population = "1 144 809",
                    ShortDescription = "Столица Башкортостана, город на слиянии рек.",
                    History = "Основана в 1574 году как русская крепость на башкирских землях. Расположена на высоком берегу при слиянии рек Белой и Уфы. В XIX–XX веках стала крупным нефтеперерабатывающим центром. Сегодня Уфа — многонациональный город с богатым культурным наследием башкирского, татарского и русского народов.",
                    PhotoUrl = "/images/cities/ufa.jpg", CoatOfArmsUrl = "/images/coats/ufa.png" }
            );

            modelBuilder.Entity<Attraction>().HasData(
                // Москва
                new Attraction { Id = 1, CityId = 1, Name = "Московский Кремль и Красная площадь", History = "Кремль — сердце российской государственности, крепость XII века. Красная площадь рядом с ним веками была местом народных собраний. Ансамбль включён в список Всемирного наследия ЮНЕСКО.", PhotoUrl = "/images/attractions/kremlin.jpg", WorkingHours = "09:00–18:00, кроме четверга", TicketPrice = "от 500 руб." },
                new Attraction { Id = 2, CityId = 1, Name = "Третьяковская галерея", History = "Крупнейшее в мире собрание русского искусства. Основана купцом Павлом Третьяковым в 1856 году. Коллекция — более 180 000 произведений.", PhotoUrl = "/images/attractions/tretyakov.jpg", WorkingHours = "10:00–18:00, пт–сб до 21:00, пн — выходной", TicketPrice = "от 600 руб." },
                new Attraction { Id = 3, CityId = 1, Name = "Большой театр", History = "Один из крупнейших оперных и балетных театров мира. История с 1776 года. Нынешнее здание в стиле ампир открылось в 1856 году.", PhotoUrl = "/images/attractions/bolshoi.jpg", WorkingHours = "По расписанию спектаклей", TicketPrice = "от 1000 руб." },
                // Санкт-Петербург
                new Attraction { Id = 4, CityId = 2, Name = "Государственный Эрмитаж", History = "Один из крупнейших художественных музеев мира. Основан в 1764 году Екатериной II. Коллекция — более 3 миллионов экспонатов.", PhotoUrl = "/images/attractions/hermitage.jpg", WorkingHours = "10:30–18:00, вт и чт до 21:00, пн — выходной", TicketPrice = "от 500 руб." },
                new Attraction { Id = 5, CityId = 2, Name = "Петергоф", History = "Дворцово-парковый ансамбль на берегу Финского залива, основан Петром I. Более 150 фонтанов и 4 каскада. Включён в список Всемирного наследия ЮНЕСКО.", PhotoUrl = "/images/attractions/peterhof.jpg", WorkingHours = "Парки: 09:00–21:00, пн — выходной", TicketPrice = "от 450 руб." },
                new Attraction { Id = 6, CityId = 2, Name = "Исаакиевский собор", History = "Крупнейший православный храм Санкт-Петербурга. Строился 40 лет (1818–1858). Высота купола — 101,5 м. С колоннады открывается панорама города.", PhotoUrl = "/images/attractions/isaac.jpg", WorkingHours = "10:30–18:00, чт — выходной", TicketPrice = "от 350 руб." },
                // Казань
                new Attraction { Id = 7, CityId = 3, Name = "Казанский Кремль", History = "Единственный в мире сохранившийся татарский кремль, история с X–XI веков. Внесён в список Всемирного наследия ЮНЕСКО.", PhotoUrl = "/images/attractions/kazan_kremlin.jpg", WorkingHours = "08:00–20:00 ежедневно", TicketPrice = "Территория бесплатно; музеи от 150 руб." },
                new Attraction { Id = 8, CityId = 3, Name = "Мечеть Кул-Шариф", History = "Главная мечеть Татарстана, возведена в 1996–2005 годах. Вмещает 6000 верующих. Четыре 57-метровых минарета стали символом Казани.", PhotoUrl = "/images/attractions/kul_sharif.jpg", WorkingHours = "Ежедневно", TicketPrice = "Бесплатно" },
                // Сочи
                new Attraction { Id = 9, CityId = 4, Name = "Олимпийский парк", History = "Построен к Зимним Олимпийским играм 2014 года. Здесь расположены главные олимпийские арены. Принял матчи ЧМ по футболу 2018 года.", PhotoUrl = "/images/attractions/olympic.jpg", WorkingHours = "09:00–21:00 ежедневно", TicketPrice = "Вход на территорию бесплатно" },
                new Attraction { Id = 10, CityId = 4, Name = "Горнолыжный курорт Роза Хутор", History = "Горнолыжный курорт мирового уровня в Красной Поляне, высота 560–2320 м. Здесь проходили соревнования Зимней Олимпиады 2014 года. Открыт круглогодично.", PhotoUrl = "/images/attractions/rosa.jpg", WorkingHours = "09:00–17:00", TicketPrice = "Подъёмники от 800 руб./день" },
                // Екатеринбург
                new Attraction { Id = 11, CityId = 5, Name = "Храм-на-Крови", History = "Построен в 2000–2003 годах на месте дома, где в 1918 году была расстреляна семья Николая II. Крупнейший православный собор Екатеринбурга.", PhotoUrl = "/images/attractions/khram.jpg", WorkingHours = "07:00–21:00 ежедневно", TicketPrice = "Бесплатно" },
                new Attraction { Id = 12, CityId = 5, Name = "Ельцин-центр", History = "Президентский центр первого президента России, открылся в 2015 году. Рассказывает об эпохе 1990-х. Включает арт-галерею, медиатеку и кинотеатр.", PhotoUrl = "/images/attractions/yeltsin.jpg", WorkingHours = "10:00–21:00, пн — выходной", TicketPrice = "от 200 руб." },
                // Новосибирск
                new Attraction { Id = 13, CityId = 6, Name = "Новосибирский Академгородок", History = "Научный центр России, основан в 1957 году. Здесь расположены десятки институтов Сибирского отделения РАН и НГУ. Один из крупнейших научных центров мира.", PhotoUrl = "/images/attractions/akadem.jpg", WorkingHours = "Открытая территория", TicketPrice = "Бесплатно" },
                new Attraction { Id = 14, CityId = 6, Name = "Новосибирский оперный театр", History = "Крупнейший оперный театр России и Азии. Построен в 1945 году. Диаметр купола — 60 м. В репертуаре — шедевры мировой оперы и балета.", PhotoUrl = "/images/attractions/nsk_opera.jpg", WorkingHours = "По расписанию спектаклей", TicketPrice = "от 300 руб." },
                // Нижний Новгород
                new Attraction { Id = 15, CityId = 7, Name = "Нижегородский Кремль", History = "Каменная крепость XVI века на высоком берегу Волги. Никогда не был взят врагами. Внутри — административный центр города и Архангельский собор.", PhotoUrl = "/images/attractions/nn_kremlin.jpg", WorkingHours = "08:00–20:00 ежедневно", TicketPrice = "Территория бесплатно; музеи от 200 руб." },
                new Attraction { Id = 16, CityId = 7, Name = "Чкаловская лестница", History = "Знаменитая лестница, построенная в 1949 году в честь лётчика Чкалова. Соединяет Верхневолжскую и Нижневолжскую набережные. Насчитывает 560 ступеней.", PhotoUrl = "/images/attractions/chkalov.jpg", WorkingHours = "Круглосуточно", TicketPrice = "Бесплатно" },
                // Владивосток
                new Attraction { Id = 17, CityId = 8, Name = "Русский мост", History = "Один из крупнейших вантовых мостов в мире, открыт в 2012 году к саммиту АТЭС. Соединяет Владивосток с островом Русский. Длина центрального пролёта — 1104 м.", PhotoUrl = "/images/attractions/russkiy.jpg", WorkingHours = "Круглосуточно", TicketPrice = "Бесплатно" },
                new Attraction { Id = 18, CityId = 8, Name = "Набережная Цесаревича", History = "Центральная набережная Владивостока с видом на Амурский залив. Место прогулок горожан и туристов. Рядом расположены Приморский океанариум и причалы.", PhotoUrl = "/images/attractions/vlad_nab.jpg", WorkingHours = "Круглосуточно", TicketPrice = "Бесплатно" },
                // Калининград
                new Attraction { Id = 19, CityId = 9, Name = "Кафедральный собор на острове Канта", History = "Готический собор XIV века, памятник средневековой прусской архитектуры. Здесь похоронен философ Иммануил Кант. Включён в список объектов ЮНЕСКО.", PhotoUrl = "/images/attractions/cathedral_kant.jpg", WorkingHours = "10:00–18:00", TicketPrice = "от 200 руб." },
                new Attraction { Id = 20, CityId = 9, Name = "Музей Янтаря", History = "Единственный в мире музей янтаря. Коллекция насчитывает более 14 000 экспонатов. Расположен в Башне «Дона» — памятнике прусской военной архитектуры.", PhotoUrl = "/images/attractions/amber.jpg", WorkingHours = "10:00–18:00, пн — выходной", TicketPrice = "от 300 руб." },
                // Уфа
                new Attraction { Id = 21, CityId = 10, Name = "Памятник Салавату Юлаеву", History = "Крупнейшая конная статуя в России (высота 9,8 м). Установлена в 1967 году на высоком берегу реки Белой. Посвящена национальному герою башкирского народа.", PhotoUrl = "/images/attractions/salavat.jpg", WorkingHours = "Круглосуточно", TicketPrice = "Бесплатно" },
                new Attraction { Id = 22, CityId = 10, Name = "Национальный музей Башкортостана", History = "Один из старейших музеев региона, основан в 1864 году. Хранит более 240 000 экспонатов по истории, природе и культуре Башкортостана.", PhotoUrl = "/images/attractions/ufa_museum.jpg", WorkingHours = "10:00–18:00, пн — выходной", TicketPrice = "от 150 руб." }
            );
        }
    }
}
