using Catalog.API.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            var existingProducts = productCollection.Find(p => true).Any();
            if (!existingProducts)
            {
                productCollection.InsertManyAsync(GetPreConfiguredProducts());
            }

        }
        private static IEnumerable<Product> GetPreConfiguredProducts()
        {
            return new List<Product> {
                new Product {
                    Name="Apple iPhone 12 (Black, 128 GB)",
                    Summary="Dual 12MP Camera System (Ultra Wide and Wide), Ultra Wide: f/2.4 Aperture, Wide: f/1.6 Aperture, Night Mode, Deep Fusion, Optical Image Stabilisation, 2x Optical Zoom Out, Digital Zoom Upto 5x, Portrait Mode with Advanced Bokeh and Depth Control, Portrait Lighting with Six Effects (Natural, Studio, Contour, Stage, Stage Mono, High‑Key Mono), Smart HDR 3 for Photos, Video: 4K Video Recording at 24 fps, 30 fps or 60 fps, 1080p HD Video Recording at 30 fps or 60 fps, HDR Video Recording with Dolby Vision Upto 30 fps, Extended Dynamic Range for Video Upto 60 fps, Optical Image Stabilisation for Video, 2x Optical Zoom Out, Digital Zoom Upto 3x, Audio Zoom, QuickTake Video, Slow-motion Video Support for 1080p at 120 fps or 240 fps, Night Mode Time-lapse, Time-lapse Video with Stabilisation, Stereo Recording",
                    Description="TrueDepth Camera, 12MP Photos, f/2.2 Aperture, Smart HDR 3 for Photos, Portrait Mode with Advanced Bokeh and Depth Control, Portrait Lighting with Six Effects (Natural, Studio, Contour, Stage, Stage Mono, High-Key Mono), Extended Dynamic Rnge for Video at 30 fps, Cinematic Video Stabilisation (4K, 1080p and 720p), 4K Video Recording at 24 fps, 30 fps or 60 fps, HDR Video Recording with Dolby Vision Upto 30 fps, 1080p HD Video Recording at 30 fps or 60 fps, Slow-motion Video Support for 1080p at 120 fps, Night Mode, Deep Fusion, QuickTake Video, Animoji and Memoji",
                    Price=84900,
                    ImageFile="apple-iphone-12.jpeg",
                    Category="Smart Phone"
                },
                new Product
                {
                    Name="Realme Narzo 20 Pro (Black Ninja, 64 GB)  (6 GB RAM)",
                    Summary="20:9 Screen Ratio, 90.50% Screen-to-body Ratio, Screen Contrast Ratio: 1200:1 (Min), 1500:1 (Avg), 90 Hz Screen Refresh Rate, NTSC Color Saturation: 81.5% (Typical) / 76% (Minimum), 480 nits (Typical) Maximum Brightness, 2.5D Gorilla Glass Touch Screen Glass, 120 Hz Touch Sampling Rate",
                    Description="48MP + 8MP + 2MP + 2MP Rear Camera Setup, Sensor Sizes/Pixel Data: 1/2, 0.8um (48M, Primary) + 1/4, 1.12um (Ultra Wide Angle, 8MP), 1/5, 1.75um (2M, B&W), 1/5, 1.75um (2M, Macro), CMOS Sensor, Focusing Method: PDAF, 10x Maximum Zoom, Aperture: f/1.8 (48MP) + f/2.3 (8MP) + f/2.4 (2MP) + f/2.4 (2MP), Focal Length: 26mm (48MP) + 16mm (8MP) + 22mm (2MP) + 22mm (2MP), 119 Degree Wide Angle of Rear Camera, Lens Number: 6P (48MP) + 5P (8MP) + 3P (2MP) + 3P (2MP), Macro Lens (at 4cm), Slow Motion: 1080P at 120 fps, 720P at 240 fps, EIS Support, Ways of Taking Photos: Touch, Volume Button, Timer, Characteristic Function for Photograph: Super Nightscape, Panorama, Portrait Mode, Time-lapse Photography, HDR, Ultra Wide, Ultra Macro, AI Scene Recognition, AI Beauty, Filter, Chroma Boost",
                    Price=14999,
                    ImageFile="realme-narzo-20-pro.jpeg",
                    Category="Smart Phone"
                },
                new Product
                {
                    Name="Thomson 189cm (75 inch) Ultra HD (4K) LED Smart Android TV",
                    Summary="The 4K UHD 3840 x 2160 resolution display of this Thomson TV, along with the Dolby Vision technology and HDR10, offers you an immersive visual experience with a billion shades of color. This home entertainment device recreates an enhanced texture, depth, and natural colors to present realistic visuals. Furthermore, it is compatible with different HDR formats, such as HDR10 and Hybrid Leg-Gamma, to offer an engaging home entertainment experience.",
                    Description="Update your living room or bedroom entertainment system by bringing home the high-end Thomson OATHPro Android TV that offers an immersive, exciting, and life-like audio-visual experience. This 189-cm (75) 4K UHD TV features an easy-to-use Android 9.0 Interface for seamless navigation, the Dolby Digital Plus technology, and DTS TruSurround sound to let you watch your favourite content with high-fidelity audio.",
                    Price=99999,
                    ImageFile="thomson-75.jpeg",
                    Category="Smart TV"
                },
                new Product
                {
                    Name="Kodak 164cm (65 inch) Ultra HD (4K) LED Smart Android TV",
                    Summary="Grab a bowl of popcorn and get ready to be in awe of the visuals on-screen, as this television boasts the 4K UHD resolution. With enhanced depth, natural colours, and textures in place, your viewing experience is set to be more immersive. This television is compatible with different HDR formats which include the HDR10 and Hybrid Log-Gamma.",
                    Description="Call your friends over, grab some food, and sit back for an enthralling visual treat on the Kodak 164 cm (65) Ultra HD (4K) LED Smart Android TV. It has been designed with features such as the Dolby Vision HDR, MEMC Technology, Dolby Digital Plus, and DTS TruSurround Sound to leave you spellbound with captivating visuals and pleasing audio.",
                    Price=49999,
                    ImageFile="kodak-65.jpeg",
                    Category="Smart TV"
                },
                new Product
                {
                    Name="HP Pavilion Core i5 9th Gen",
                    Summary="NVIDIA Geforce GTX 1050 for Desktop Level Performance,15.6 inch Full HD LED Backlit Anti-glare Display,Light Laptop without Optical Disk Drive",
                    Description="awesome products slim design powerful gpu with 3gbb nvedia processing ND multitasking content creatiing in best in ths laptop battery performance is 6 to 7 hour 4 cell battery is best in ths laptop amazing design ND latest processor with 9gen plz i recommended to buy ths laptop ths is best in range for gaming multitasking processing it has 2.6 clock speed ND boost up to 4.0 ND has a m.2 slot for ssd 8gb ram ND expnd to 16 gb ND has a backlit keyboard ND full HD antiglare screen",
                    Price=14999,
                    ImageFile="hp-na-gaming-laptop.jpeg",
                    Category="Laptop"
                },
                new Product
                {
                    Name="Asus ROG Strix G Core i5 9th Gen",
                    Summary="This gaming laptop comes with GeForce GTX 1650 graphics that enables stunning visuals and provides you with an immersive gaming experience. It also comes with the latest 9th gen Intel® Core i5-9300H processor and pairs with 8GB of DDR4-2666 RAM to slice through intensive games and apps.",
                    Description="This Asus gaming laptop is a must-buy if you are an avid gamer. It comes with an ergonomic design, accurately made for the gamers out there. It also comes with an Intelligent Cooling System that keeps your laptop cool even after hours of long gaming sessions. It has a keyboard that comes with RGB lighting for easy visual navigation as well.",
                    Price=69990,
                    ImageFile="asus-na-gaming-laptop.jpeg",
                    Category="Laptop"
                },
                new Product
                {
                    Name="IFB 6.5 kg 5 Star Fully Automatic Front Load",
                    Summary="This IFB washing machine comes with built-in Aqua Energie, the filter treatment of which helps in dissolving the detergent for a softer washing experience.",
                    Description="Here’s a washing machine that is sure to meet all your washing requirements. This washing machine's Aqua Energie feature ensures a proper filter treatment for a soft washing experience. This IFB washing machine comes with a 3D Wash System for an enhanced washing process. You can also save more water, thanks to this washing machine’s Ball Valve technology. It also makes sure to balance the laundry load for a stable washing process, thanks to its High-low Voltage feature.",
                    Price=28690,
                    ImageFile="elena-zxs-ifb.jpeg",
                    Category="Washing Machine"
                }
            };
        }
    }
}
