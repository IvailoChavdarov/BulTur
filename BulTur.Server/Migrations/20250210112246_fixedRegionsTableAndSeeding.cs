using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulTur.Server.Migrations
{
    /// <inheritdoc />
    public partial class fixedRegionsTableAndSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "BannerImageUrl", "Description", "Name", "ShortTitle" },
                values: new object[,]
                {
                    { (short)1, "https://e-tourguide.eu/wp-content/uploads/2023/09/BL-d-scaled.jpeg", "Vibrant region in southwestern Bulgaria, known for its stunning natural landscapes and cultural richness. Home to the majestic Pirin Mountains, the region offers breathtaking hiking trails, crystal-clear glacial lakes, and the famous ski resort of Bansko. Beyond its natural beauty, Blagoevgrad boasts a rich historical and cultural heritage, with charming villages like Melnik, famous for its wine and unique sandstone formations. The region is a crossroads of traditions, with influences from Bulgarian, Macedonian, and Greek cultures. Blagoevgrad city itself is a youthful hub, home to two major universities and a thriving arts scene.", "Blagoevgrad", "Gateway to the Pirin Mountains and rich in cultural diversity." },
                    { (short)2, "https://images.musement.com/cover/0153/15/thumb_15214687_cover_header.jpg", "Situated along the Black Sea coast, Burgas is a region of captivating beauty and dynamic energy. Its pristine beaches and lively seaside resorts, such as Sunny Beach and Sozopol, attract visitors year-round. Burgas is also home to the enchanting Strandzha Mountains, a haven for nature lovers with ancient forests and mysterious Thracian sanctuaries. The city of Burgas, the region's heart, combines modern urban life with cultural treasures, like the Sea Garden park and vibrant music festivals. Nearby, the UNESCO-listed Nessebar showcases a rich history with its cobbled streets and ancient churches.", "Burgas", "Seaside charm with stunning beaches and vibrant festivals." },
                    { (short)3, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/15/4d/45/a5/varna.jpg?w=1400&h=1400&s=1", "Varna, known as the 'Sea Capital' of Bulgaria, is a dynamic region along the Black Sea coast. The city of Varna is famous for its golden beaches, vibrant nightlife, and cultural landmarks like the Roman Baths and the Archaeological Museum, home to the world's oldest gold treasure. The region also boasts natural wonders such as the Stone Forest and the picturesque Cape Kaliakra. Varna combines seaside relaxation with historical exploration.", "Varna", "Golden beaches and the world’s oldest gold treasure." },
                    { (short)4, "https://www.veliko-tarnovo.bg/uploads/slider/2024/a9698a837e44e0a3b421b85d8a05b948.jpg", "Veliko Tarnovo is a region steeped in history, located in north-central Bulgaria. The town of Veliko Tarnovo, once the medieval capital of Bulgaria, is renowned for the majestic Tsarevets Fortress and its cobblestone streets lined with traditional crafts. Nearby, the village of Arbanasi offers stunning architecture and ancient monasteries. The region’s rich history and picturesque landscapes make it one of Bulgaria’s most captivating destinations.", "Veliko Tarnovo", "Medieval glory and picturesque landscapes." },
                    { (short)5, "https://www.niebg.net/d2020/sites/default/files/Zaglavna%20baba%20vida_1.jpg", "Vidin, situated along the Danube River in northwestern Bulgaria, is a region of historical significance and natural beauty. The town of Vidin is home to the well-preserved Baba Vida Fortress, a symbol of Bulgaria’s medieval past. The region’s natural highlights include the picturesque Belogradchik Rocks and the Magura Cave, featuring prehistoric cave paintings. Vidin is a destination where history and nature come together in harmony.", "Vidin", "Danube beauty and the iconic Belogradchik Rocks." },
                    { (short)6, "https://www.vratza.bg/files/9a7d85be0e55c23aa8eda21bbd300a67.jpg", "Vratsa, located in northwestern Bulgaria, is a region of dramatic landscapes and heroic history. The town of Vratsa is nestled at the foot of the Balkan Mountains, offering access to the awe-inspiring Vratsata Gorge, a paradise for climbers. The Ledenika Cave, with its stunning formations, is another natural wonder. Vratsa also honors the legacy of Bulgarian revolutionary Hristo Botev, whose memory is celebrated with an annual festival.", "Vratsa", "Towering cliffs and revolutionary spirit." },
                    { (short)7, "https://static.tildacdn.com/tild6438-3932-4838-b866-343530623565/Index-1640.jpg", "Nestled in the heart of Bulgaria, Gabrovo is a land of humor, craftsmanship, and mountain beauty. The region is best known as Bulgaria's capital of humor, hosting the annual Carnival of Humor and Satire. Gabrovo city is home to the unique Museum of Humor and Satire, which reflects the region’s playful spirit. Surrounded by the Balkan Mountains, Gabrovo also offers nature lovers scenic hiking trails and access to the majestic Shipka Pass. Nearby, the architectural and ethnographic complex Etar presents a living museum of Bulgarian traditions and crafts.", "Gabrovo", "Bulgaria’s humor capital, nestled in the Balkan Mountains." },
                    { (short)8, "https://pronewsdobrich.bg//i/2024/02/21/374669.jpg", "Dobrich is the breadbasket of Bulgaria, famed for its vast wheat fields and agricultural bounty. Located in northeastern Bulgaria, the region offers a serene rural charm and proximity to the Black Sea. Dobrich city is known for its beautiful parks, historic monuments, and dedication to the arts. Visitors can explore the architectural and ethnographic complex \"The Old Dobrich,\" which showcases the region's traditional crafts. Dobrich is also home to Balchik, a picturesque seaside town featuring a stunning botanical garden and the historic Balchik Palace.", "Dobrich", "Fertile lands, golden wheat fields, and peaceful rural charm." },
                    { (short)9, "https://kardzhali.org/wp-content/uploads/2020/11/KARDZHALI-31.jpg", "Kardzhali, in the heart of the Rhodope Mountains, offers a mix of mysticism, history, and breathtaking nature. The region is famous for its ancient Thracian sanctuaries, such as the mysterious Tatul and the Stone Mushrooms rock formations. Kardzhali Reservoir provides stunning views and opportunities for water sports. The town of Kardzhali is a cultural hub, featuring the History Museum, which displays artifacts from the region’s rich past. The region’s traditions are deeply rooted, reflecting a harmonious blend of different cultures and religions.", "Kardzhali", "Mystical landscapes, ancient Thracian ruins, and unique traditions." },
                    { (short)10, "https://destinations.bg/wp-content/uploads/2020/11/%D0%9A%D1%8E%D1%81%D1%82%D0%B5%D0%BD%D0%B4%D0%B8%D0%BB-%D0%B8%D0%B7%D0%B3%D0%BB%D0%B5%D0%B4-2048x1365.jpg", "Kyustendil is a picturesque region in southwestern Bulgaria, celebrated for its mineral springs and lush orchards. Known as the 'Fruit Garden of Bulgaria,' it offers visitors scenic countryside and relaxing spa towns like Sapareva Banya. The town of Kyustendil is rich in history, featuring Roman ruins and the medieval Hisarlaka Fortress. The Osogovo Mountain nearby is perfect for hiking and skiing, making Kyustendil a haven for both relaxation and adventure.", "Kyustendil", "Land of orchards, mineral springs, and mountain getaways." },
                    { (short)11, "https://cdn.britannica.com/44/141144-050-45995E2A/bridge-Osum-River-Bulg-Lovech.jpg", "Lovech, located in central Bulgaria, is a region of historical significance and natural beauty. The town of Lovech is famous for its iconic covered bridge, designed by the master builder Kolyu Ficheto. Visitors can explore the medieval Lovech Fortress, which offers stunning views of the surrounding landscape. Nearby, the Devetaki Plateau is home to the magnificent Devetashka Cave and Krushuna Waterfalls, perfect for nature enthusiasts. Lovech is also a key site in Bulgaria’s struggle for independence, with landmarks dedicated to its revolutionary past.", "Lovech", "Rich history and natural wonders in central Bulgaria." },
                    { (short)12, "https://iseebg.com/wp-content/uploads/2020/08/Montana-City-01.jpg", "Montana, located in northwestern Bulgaria, is a region of serene beauty and historical intrigue. The region is dominated by the Balkan Mountains, offering excellent opportunities for hiking and exploration. The town of Montana boasts archaeological treasures from ancient Roman times and a vibrant cultural scene. Nearby, the Ogosta Reservoir provides a tranquil escape for fishing and water activities. The Chiprovtsi Monastery and the unique Chiprovtsi carpets, part of UNESCO’s cultural heritage, are highlights of the region’s traditions.", "Montana", "Mountainous landscapes and rich cultural heritage." },
                    { (short)13, "https://www.bhfieldschool.org/uploaded/b2279560996177ba1d9e84e74ff4d34aa6c0bc67.jpg", "Pazardzhik, in southern Bulgaria, is a region of vibrant cultural traditions and natural diversity. The town of Pazardzhik is known for its historical landmarks, such as the Church of the Assumption and the beautiful Pazardzhik Clock Tower. The region is home to the Rila Mountains, offering access to Bulgaria’s famous Seven Lakes and numerous hiking trails. Visitors can also enjoy the mineral springs and spa facilities in Velingrad, one of the country’s top wellness destinations.", "Pazardzhik", "A blend of natural beauty, history, and wellness retreats." },
                    { (short)14, "https://pernik.bg/wp-content/uploads/2020/10/dsc008493-scaled.jpg", "Pernik, a region in western Bulgaria, is best known for its vibrant Surva Festival, an annual celebration of traditional masked rituals. The town of Pernik, once a hub for mining, has transformed into a cultural and historical destination, featuring the medieval Krakra Fortress and the Regional History Museum. The region is also close to the picturesque Vitosha Mountain and the unique Zemen Monastery, offering visitors a mix of cultural experiences and natural wonders.", "Pernik", "Festive traditions and ancient landmarks near the capital." },
                    { (short)15, "https://www.pleven.bg/uploads/sliders/sp-0002.jpg", "Pleven is a region of rich history and breathtaking landscapes in northern Bulgaria. The town of Pleven is famous for the Pleven Panorama, a monument commemorating the Russo-Turkish War. The Kaylaka Park, with its caves and ancient ruins, offers a serene retreat for nature lovers. Pleven is also known for its fertile lands, producing some of Bulgaria’s finest wines. The region’s blend of historical significance and natural beauty makes it a must-visit destination.", "Pleven", "Historic monuments and lush vineyards in northern Bulgaria." },
                    { (short)16, "https://tripjive.com/wp-content/uploads/2024/06/What-are-the-must-see-places-in-Plovdiv.jpg", "Plovdiv, Bulgaria’s second-largest city and one of Europe’s oldest continuously inhabited settlements, is the heart of this dynamic region. Known for its Roman amphitheater, charming Old Town, and vibrant Kapana arts district, Plovdiv blends history with modernity. The surrounding region offers lush vineyards, picturesque villages, and access to the Rhodope Mountains. With its rich cultural calendar and timeless beauty, Plovdiv is a thriving hub of art, history, and innovation.", "Plovdiv", "Europe’s oldest city with a thriving cultural scene." },
                    { (short)17, "https://scontent.fsof11-1.fna.fbcdn.net/v/t1.6435-9/93409502_1387709224733958_1440812174615248896_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=2285d6&_nc_ohc=oAlUtEczipsQ7kNvgEBEVLa&_nc_zt=23&_nc_ht=scontent.fsof11-1.fna&_nc_gid=AdHw_VI8zHq-HKEHXKmwcS-&oh=00_AYBJ1sPGZdL7QZ7vfk4urZIPTzZ1o6L4ur0E3NRUj1oR7g&oe=67CFE343", "Razgrad is a tranquil region in northeastern Bulgaria, rich in history and surrounded by nature. The town of Razgrad is home to the ancient ruins of Abritus, an important Thracian and Roman settlement. Visitors can explore the Ottoman-era Ibrahim Pasha Mosque, a cultural gem in the heart of the city. The region’s rolling hills and lush forests provide a peaceful escape, making it a great destination for history enthusiasts and nature lovers.", "Razgrad", "Ancient ruins and serene landscapes in northeastern Bulgaria." },
                    { (short)18, "https://obshtinaruse.bg/cache/thumbnails/99072ffe8e36363d7c04c8b3f9664ea168c51cd5/99b6eb064bc30ddbcc3508e6c0e7e3291ef3df76-2f34c7479324895b9d3f46c2aade4ee4.jpg", "Ruse, located on the banks of the Danube River, is often called 'Little Vienna' for its elegant architecture and cultural charm. The town of Ruse boasts beautiful landmarks like the Freedom Monument and the Dohodno Zdanie theater. The surrounding region offers picturesque views of the Danube and natural wonders like the Rusenski Lom Nature Park, home to ancient rock-hewn churches and diverse wildlife. Ruse is a gateway to history, nature, and artistic inspiration.", "Ruse", "Elegant architecture and Danube riverfront charm." },
                    { (short)19, "https://kab.bg/core/wp-content/uploads/2020/01/rk_backgrounds__0009_Silistra.jpg", "Silistra is a peaceful region located along the Danube River in northeastern Bulgaria. The town of Silistra is home to an ancient Roman fortress and the beautiful Danube Park. The region’s Srebarna Nature Reserve, a UNESCO World Heritage Site, is a haven for birdwatchers, featuring diverse bird species and wetlands. With its tranquil riverside views and historical sites, Silistra is a hidden gem for nature lovers and history buffs alike.", "Silistra", "Danube serenity and unique natural reserves." },
                    { (short)20, "https://kab.bg/core/wp-content/uploads/2020/01/rk_backgrounds__0008_Sliven.jpg", "Sliven, located in southeastern Bulgaria, is a region of majestic mountains and rich traditions. The town of Sliven is known for its Blue Rocks Nature Park, which offers stunning landscapes and outdoor adventures. The region is also home to numerous wineries and historic sites, such as the Hadzhi Dimitar Museum House, dedicated to Bulgaria’s revolutionary past. Sliven’s blend of natural beauty, history, and wine culture makes it a captivating destination.", "Sliven", "Mountain adventures and rich revolutionary history." },
                    { (short)21, "https://scontent.fsof11-1.fna.fbcdn.net/v/t39.30808-6/438092947_907909981347683_6694488866353887147_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=cc71e4&_nc_ohc=jgFjS6eueXcQ7kNvgFYi4-8&_nc_zt=23&_nc_ht=scontent.fsof11-1.fna&_nc_gid=AOSIaXHOhUoKfl2nDTdaZNI&oh=00_AYCQL_Vwhinrha-Hh8XDzkyDv9rQOzyfJfdX0iKw1kPqnQ&oe=67AC4666", "Smolyan, in the heart of the Rhodope Mountains, is a region of breathtaking natural beauty and rich folklore. The town of Smolyan is known for its stunning lakes, charming architecture, and the impressive Smolyan Planetarium. Visitors can explore the nearby Pamporovo ski resort or visit the Yagodina Cave and Devil’s Throat Cave, which are steeped in myth and legend. Smolyan is a destination for nature enthusiasts and cultural explorers.", "Smolyan", "Mountain landscapes and timeless folklore traditions." },
                    { (short)22, "https://lp-cms-production.imgix.net/2024-08/500pxRF121116733.jpg", "Sofia City, Bulgaria’s capital, is a vibrant metropolis blending ancient history with modern life. The city is home to iconic landmarks like Alexander Nevsky Cathedral, Vitosha Boulevard, and the Boyana Church, a UNESCO World Heritage Site. Surrounded by Vitosha Mountain, Sofia offers both urban experiences and outdoor escapes. With its thriving arts scene, rich history, and lively nightlife, Sofia is a hub of culture, innovation, and exploration.", "Sofia", "The heart of Bulgaria’s history and modernity." },
                    { (short)23, "https://www.civitatis.com/f/bulgaria/sofia/sofia.jpg", "Sofia Province, surrounding the capital, offers its own unique charm with breathtaking natural landscapes and cultural treasures. The region is home to Borovets, Bulgaria’s oldest ski resort, and the serene Seven Rila Lakes, a natural wonder. Towns like Samokov and Sapareva Banya boast mineral springs and historical landmarks. From mountain adventures to wellness retreats, Sofia Province is a captivating destination for all types of travelers.", "Sofia Province", "Stunning mountains, mineral springs, and serene lakes." },
                    { (short)24, "https://www.informationbulgaria.com/wp-content/uploads/2019/10/Stara-Zagora-Bulgaria.jpg", "Stara Zagora is a region of ancient history and modern vitality in southern Bulgaria. The town of Stara Zagora is famous for its Roman forum, ancient mosaics, and beautiful Ayazmoto Park. The region’s Thracian heritage is showcased in nearby archaeological sites like the Valley of Thracian Kings. Known as the 'City of Linden Trees,' Stara Zagora offers a harmonious blend of historical exploration and natural beauty.", "Stara Zagora", "Ancient Thracian treasures and vibrant modern life." },
                    { (short)25, "https://www.eufunds.bg/sites/default/files/uploads/oic/doc-icons/2021-11/%D0%BE%D0%B1%D1%89%D0%B8%D0%BD%D0%B0%20%D1%82%D1%8A%D1%80%D0%B3%D0%BE%D0%B2%D0%B8%D1%89%D0%B5.jpg", "Targovishte is a serene region in northeastern Bulgaria, offering a mix of history, culture, and natural beauty. The town of Targovishte is known for its Revival-era architecture and rich traditions. Visitors can explore the Krumovo Kale Fortress and enjoy the picturesque beauty of the Preslav Forests. The region is also renowned for its winemaking heritage, producing high-quality wines that reflect the local terroir. Targovishte is a peaceful destination with a deep connection to its roots.", "Targovishte", "Historic charm and winemaking traditions." },
                    { (short)26, "https://scontent.fsof8-1.fna.fbcdn.net/v/t39.30808-6/308462846_197358342649338_6104546279624722250_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=cc71e4&_nc_ohc=36SU3nuuprAQ7kNvgF4Ub6d&_nc_zt=23&_nc_ht=scontent.fsof8-1.fna&_nc_gid=ASauLKOzOKd00ie_BDh6J9p&oh=00_AYDf2jZmbumdbgkMDNYL_E7p8YHY8oJVOfxcuB7PRuryTw&oe=67AAD046", "Haskovo, located in southern Bulgaria, is a region steeped in history and rich in natural beauty. It is home to ancient Thracian sites such as the rock-hewn Perperikon, a mystical archaeological complex. Haskovo city boasts the world’s tallest statue of the Virgin Mary, a symbol of peace and faith. The region is known for its lush vineyards, producing fine wines, and mineral springs, offering relaxation and rejuvenation. Visitors can also explore the nearby Uzundzhovo Church, a fascinating blend of Christian and Ottoman architecture.", "Haskovo", "Land of vineyards, rich history, and the tallest Virgin Mary statue." },
                    { (short)27, "https://scontent.fsof11-1.fna.fbcdn.net/v/t39.30808-6/391707720_710123534485955_3377674961047611069_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=cc71e4&_nc_ohc=9zKbD8IgRvgQ7kNvgFJzfas&_nc_zt=23&_nc_ht=scontent.fsof11-1.fna&_nc_gid=AU2B3fuCOkL95GW6oTxphCd&oh=00_AYAM7F9GpsDS9ZEQ2oVS5uaNZ4NV8Z8rRNZOznlOrH1z3A&oe=67AC471D", "Shumen is a region of historical significance and natural beauty in northeastern Bulgaria. The town of Shumen is famous for the Monument to 1300 Years of Bulgaria and the majestic Shumen Fortress. Nearby, the Madara Rider, a UNESCO World Heritage Site, showcases Bulgaria's early medieval heritage. The region also offers beautiful nature spots, such as the Shumen Plateau Nature Park, perfect for hiking and exploring. Shumen is a harmonious blend of history, culture, and nature.", "Shumen", "UNESCO heritage and rich medieval history." },
                    { (short)28, "https://preotkrii.bg/wp-content/uploads/2024/08/yambol-ot-visoko.jpg", "Yambol, in southeastern Bulgaria, is a region of rural charm and ancient history. The town of Yambol is known for the unique Bezisten, an Ottoman-era covered market, and the ancient Thracian city of Kabyle nearby. The region’s fertile lands and vineyards produce excellent wines, adding to its appeal. Yambol’s blend of historical landmarks, natural beauty, and cultural traditions makes it a delightful destination to explore.", "Yambol", "Thracian heritage and rich rural traditions." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)4);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)5);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)6);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)7);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)8);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)9);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)10);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)11);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)12);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)13);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)14);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)15);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)16);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)17);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)18);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)19);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)20);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)21);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)22);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)23);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)24);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)25);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)26);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)27);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: (short)28);
        }
    }
}
