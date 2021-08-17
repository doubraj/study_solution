using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Data
{
    public class Seed
    {
        public static async Task SeedDataIfEmpty(DataContext context)
        {
            if (context.Products.Any()) return;
            var products = getProductSeedData();
            await context.Products.AddRangeAsync(products);
            await context.SaveChangesAsync();
        }

        private static List<Product> getProductSeedData()
        {
            return new List<Product>
            {
                new Product
                {
                    Name = "Samsung Galaxy A32",
                    ImgUri = "U2Ftc3VuZyBHYWxheHkgQTMy",
                    Price = 6999,
                    Description = "Mobilní telefon - 6,4\" AMOLED 2400 × 1080, procesor MediaTek MT6769T 8jádrový, RAM 4 GB, interní paměť 128 GB, Micro SD až 1024 GB"
                },
                new Product
                {
                    Name = "Samsung Galaxy S20",
                    ImgUri = "U2Ftc3VuZyBHYWxheHkgUzIw",
                    Price = 15990,
                    Description = "Mobilní telefon - 6,7\" AMOLED 3200 × 1440, 120Hz, procesor Samsung Exynos 990 8jádrový"
                },
                new Product
                {
                    Name = "iPhone 11 64GB",
                    ImgUri = "aVBob25lIDExIDY0R0I=",
                    Price = 15490,
                    Description = "Mobilní telefon - 6,1\" IPS 1792 × 828, procesor Apple A13 Bionic 6jádrový, RAM 4 GB, interní paměť 64 GB"
                },
                new Product
                {
                    Name = "iPhone 11 128GB",
                    ImgUri = "aVBob25lIDExIDEyOEdC",
                    Price = 17990,
                    Description = "Mobilní telefon - 6,1\" IPS 1792 × 828, procesor Apple A13 Bionic 6jádrový, RAM 4 GB"
                },
                new Product
                {
                    Name = "Samsung Galaxy S21 Ultra 5G 256GB",
                    ImgUri = "U2Ftc3VuZyBHYWxheHkgUzIxIFVsdHJhIDVHIDI1NkdC",
                    Price = 34990,
                    Description = "Mobilní telefon - 6,8\" AMOLED 3200 × 1440, 120Hz, procesor Samsung Exynos 2100 8jádrový"
                },
                new Product
                {
                    Name = "Acer Nitro 5 Obsidian Black",
                    ImgUri = "QWNlciBOaXRybyA1IE9ic2lkaWFuIEJsYWNr",
                    Price = 18990,
                    Description = "Herní notebook - Intel Core i5 9300H Coffee Lake, 15.6\" IPS matný 1920 × 1080 120Hz"
                },
                new Product
                {
                    Name = "Dell G5 15 Gaming (5500) Black",
                    ImgUri = "RGVsbCBHNSAxNSBHYW1pbmcgKDU1MDApIEJsYWNr",
                    Price = 34990,
                    Description = "Herní notebook - Intel Core i7 10750H Comet Lake, 15.6\" IPS matný 1920 × 1080 300Hz, RAM 16GB DDR4"
                },
                new Product
                {
                    Name = "Macbook Air 13in M1 CZ",
                    ImgUri = "TWFjYm9vayBBaXIgMTNpbiBNMSBDWg==",
                    Price = 35490,
                    Description = "MacBook - Apple M1, 13.3\" IPS lesklý 2560 × 1600 , RAM 16GB, Apple M1 7jádrová GPU, SSD 256GB"
                },
                new Product
                {
                    Name = "Lenovo Legion 5 Pro 16ACH6H",
                    ImgUri = "TGVub3ZvIExlZ2lvbiA1IFBybyAxNkFDSDZI",
                    Price = 46989,
                    Description = "Herní notebook - AMD Ryzen 7 5800H, 16\" IPS antireflexní 2560 × 1600 165Hz, RAM 32GB DDR4, NVIDIA GeForce RTX 3070"
                },
                new Product
                {
                    Name = "HP ProBook 430 G7",
                    ImgUri = "SFAgUHJvQm9vayA0MzAgRzc=",
                    Price = 14990,
                    Description = "Notebook - Intel Core i5 10210U Comet Lake, 13.3\" IPS antireflexní 1920 × 1080, RAM 8GB DDR4, Intel UHD Graphics, SSD 512GB"//10
                },
                new Product
                {
                    Name = "Lenovo IdeaPad 5 14ALC05",
                    ImgUri = "TGVub3ZvIElkZWFQYWQgNSAxNEFMQzA1",
                    Price = 13489,
                    Description = "Notebook - AMD Ryzen 5 5500U, 14\" IPS antireflexní 1920 × 1080, RAM 8GB DDR4, AMD Radeon Graphics, SSD 256GB"
                },
                new Product
                {
                    Name = "Asus X515JA-BQ675T",
                    ImgUri = "QXN1cyBYNTE1SkEtQlE2NzVU",
                    Price = 15990,
                    Description = "Notebook - Intel Core i5 1035G1 Ice Lake, 15.6\" IPS antireflexní 1920 × 1080, RAM 8GB DDR4, Intel UHD Graphics, SSD 512GB"
                },
                new Product
                {
                    Name = "MSI GF75 Thin 10UE-065CZ",
                    ImgUri = "TVNJIEdGNzUgVGhpbiAxMFVFLTA2NUNa",
                    Price = 35990,
                    Description = "Herní notebook - Intel Core i7 10750H Comet Lake, 17.3\" IPS matný 1920 × 1080 144Hz, RAM 16GB DDR4, NVIDIA GeForce RTX 3060 6GB, SSD 1000GB"
                },
                new Product
                {
                    Name = "HP 15s-fq1901nc",
                    ImgUri = "SFAgMTVzLWZxMTkwMW5j",
                    Price = 13490,
                    Description = "Notebook - procesor Intel® Core™ i3-1005G1 Ice Lake, 15.6\" VA matný 1920 × 1080, RAM 8GB DDR4, Intel UHD Graphics, SSD 512GB"
                },
                new Product
                {
                    Name = "Lenovo ThinkPad E15 Gen 3 (AMD)",
                    ImgUri = "TGVub3ZvIFRoaW5rUGFkIEUxNSBHZW4gMyAoQU1EKQ==",
                    Price = 24990,
                    Description = "Notebook - AMD Ryzen 7 5700U, 15.6\" IPS antireflexní 1920 × 1080, RAM 16GB DDR4, AMD Radeon Graphics, SSD 512GB"//15
                },
                new Product
                {
                    Name = "PlayStation 5 DualSense Wireless Controller",
                    ImgUri = "UGxheVN0YXRpb24gNSBEdWFsU2Vuc2UgV2lyZWxlc3MgQ29udHJvbGxlcg==",
                    Price = 1899,
                    Description = "Gamepad pro PS5, bezdrátové připojení, 3,5mm Jack (na ovladači), USB-C"
                },
                new Product
                {
                    Name = "Logitech G29 Driving Force",
                    ImgUri = "TG9naXRlY2ggRzI5IERyaXZpbmcgRm9yY2U=",
                    Price = 5990,
                    Description = "Volant s pedály, zpětná vazba, úhel otáčení 900 °, 14 tlačítek, 3 pedály, D-Pad, kompatibilní s PS5, PS4, PS3 a PC, USB-A"
                },
                new Product
                {
                    Name = "HyperX Cloud II Headset",
                    ImgUri = "SHlwZXJYIENsb3VkIElJIEhlYWRzZXQ=",
                    Price = 1889,
                    Description = "Herní sluchátka drátová, s mikrofonem, přes hlavu, okolo uší, uzavřená konstrukce, 3,5 mm Jack, USB-A"
                },
                new Product
                {
                    Name = "SteelSeries Arctis 9",
                    ImgUri = "U3RlZWxTZXJpZXMgQXJjdGlzIDk=",
                    Price = 5489,
                    Description = "Herní sluchátka bezdrátová, s mikrofonem, přes hlavu, okolo uší, uzavřená konstrukce, 3,5 mm Jack, Bluetooth"
                },
                new Product
                {
                    Name = "Demons Souls Remake - PS5",
                    ImgUri = "RGVtb25zIFNvdWxzIFJlbWFrZSAtIFBTNQ==",
                    Price = 1999,
                    Description = "Hra na konzoli - PS5 (s mechanikou), krabicová verze, žánr: akční a hororová"//20
                },
                new Product
                {
                    Name = "Ratchet and Clank: Rift Apart - PS5",
                    ImgUri = "UmF0Y2hldCBhbmQgQ2xhbms6IFJpZnQgQXBhcnQgLSBQUzU=",
                    Price = 1999,
                    Description = "Hra na konzoli - PS5 (s mechanikou), krabicová verze, české titulky, žánr: akční a adventura"
                },
                new Product
                {
                    Name = "HyperX Cloud Core 7.1",
                    ImgUri = "SHlwZXJYIENsb3VkIENvcmUgNy4x",
                    Price = 1569,
                    Description = "Herní sluchátka drátová, s mikrofonem, přes hlavu, okolo uší, uzavřená konstrukce, 3,5 mm Jack"
                },
                new Product
                {
                    Name = "HyperX Cloud Flight",
                    ImgUri = "SHlwZXJYIENsb3VkIEZsaWdodA==",
                    Price = 3089,
                    Description = "Herní sluchátka bezdrátová, s mikrofonem, přes hlavu, okolo uší, uzavřená konstrukce, radiofrekvenční připojení"
                },
                new Product
                {
                    Name = "Cyberpunk 2077 - PS4",
                    ImgUri = "Q3liZXJwdW5rIDIwNzcgLSBQUzQ=",
                    Price = 1389,
                    Description = "Hra na konzoli - PS4 / PS4 Pro, PS5 (s mechanikou), krabicová verze, české titulky, žánr: akční a RPG"
                },
                new Product
                {
                    Name = "Grand Theft Auto V (GTA 5): Premium Edition - PS4",
                    ImgUri = "R3JhbmQgVGhlZnQgQXV0byBWIChHVEEgNSk6IFByZW1pdW0gRWRpdGlvbiAtIFBTNA==",
                    Price = 599,
                    Description = "Hra na konzoli - PS4 / PS4 Pro, PS5 (s mechanikou), krabicová verze, žánr: akční"//25
                },
                new Product
                {
                    Name = "PlayStation 5 HD Camera",
                    ImgUri = "UGxheVN0YXRpb24gNSBIRCBDYW1lcmE=",
                    Price = 1279,
                    Description = "Kamera - kvalita záběrů ve Full HD, integrovaný podstavec, funkce pro odstranění/oříznutí pozadí, 120 × 189 × 68 mm"
                },
                new Product
                {
                    Name = "PlayStation 5 Media Remote",
                    ImgUri = "UGxheVN0YXRpb24gNSBNZWRpYSBSZW1vdGU=",
                    Price = 790,
                    Description = "Dálkový ovladač pro PlayStation 5, snadné ovládání streamovacích služeb, bílý"
                },
                new Product
                {
                    Name = "Jabra Speak 510 MS",
                    ImgUri = "SmFicmEgU3BlYWsgNTEwIE1T",
                    Price = 2549,
                    Description = ""
                },
                new Product
                {
                    Name = "Rollei cestovní stativ",
                    ImgUri = "Um9sbGVpIGNlc3Rvdm7DrSBzdGF0aXY=",
                    Price = 799,
                    Description = "Stativ pro digitální fotoaparát a mobilní telefon,, dvoucestná (2d / videohlava) hlava, transportní výška 38.5cm, max. výška 120 cm"
                },
                new Product
                {
                    Name = "Fujifilm Instax mini film 20ks",
                    ImgUri = "RnVqaWZpbG0gSW5zdGF4IG1pbmkgZmlsbSAyMGtz",
                    Price = 431,
                    Description = ""//30
                },
                new Product
                {
                    Name = "SanDisk SDXC 64GB Extreme Pro",
                    ImgUri = "U2FuRGlzayBTRFhDIDY0R0IgRXh0cmVtZSBQcm8=",
                    Price = 759,
                    Description = "Paměťová karta SDXC, čtení až 170 MB/s, zápis až 90 MB/s, Class 10, UHS-I, V30"
                },
                new Product
                {
                    Name = "HyperX QuadCast",
                    ImgUri = "SHlwZXJYIFF1YWRDYXN0",
                    Price = 3489,
                    Description = "Mikrofon stolní, připojení USB, délka kabelu 3 m, kondenzátorový, směrové snímání, frekvence od 20 Hz do 20000 Hz, impedance 32 Ohm, citlivost -36 dB"
                },
                new Product
                {
                    Name = "SPC Gear SM950",
                    ImgUri = "U1BDIEdlYXIgU005NTA=",
                    Price = 2499,
                    Description = ""
                },
                new Product
                {
                    Name = "GOPRO Shorty",
                    ImgUri = "R09QUk8gU2hvcnR5",
                    Price = 879,
                    Description = "Ministativ druh stativu ministativ, druh stativové hlavy bez hlavy (pouze šroub), maximální výška 22,7 cm"
                },
                new Product
                {
                    Name = "RODE NT-USB Mini",
                    ImgUri = "Uk9ERSBOVC1VU0IgTWluaQ==",
                    Price = 2589,
                    Description = "Mikrofon stolní, připojení USB, kondenzátorový, směrové snímání, frekvence od 20 Hz do 20000 Hz, pop filtr"//35
                }
            };
        }
    }
}