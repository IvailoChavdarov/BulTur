using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulTur.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedTownsSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Town",
                columns: new[] { "Id", "BannerImage", "Description", "Name", "RegionId" },
                values: new object[,]
                {
                    { 1, null, "Sofia is the capital and largest city of Bulgaria, known for its rich history and vibrant cultural scene.", "Sofia", (short)22 },
                    { 2, null, "Plovdiv is one of Europe’s oldest continuously inhabited cities, famous for its Roman theatre and eclectic cultural heritage.", "Plovdiv", (short)16 },
                    { 3, null, "Varna is a major port on the Black Sea known for its seaside resorts, maritime traditions, and lively festivals.", "Varna", (short)3 },
                    { 4, null, "Burgas is an important industrial and tourist hub on the Bulgarian Black Sea coast with a bustling port.", "Burgas", (short)2 },
                    { 5, null, "Often called 'Little Vienna', Ruse is renowned for its neo‐classical architecture along the banks of the Danube.", "Ruse", (short)18 },
                    { 6, null, "Stara Zagora is a historic city with roots dating back to antiquity and a modern cultural calendar.", "Stara Zagora", (short)24 },
                    { 7, null, "Pleven is an important administrative center in northern Bulgaria, rich in history and local traditions.", "Pleven", (short)15 },
                    { 8, null, "Sliven is known for its unique natural rock formations and its longstanding industrial heritage.", "Sliven", (short)20 },
                    { 9, null, "Dobrich is a key city in the agricultural heartland of northeastern Bulgaria.", "Dobrich", (short)8 },
                    { 10, null, "Shumen boasts important medieval fortresses and is a center for regional cultural heritage.", "Shumen", (short)27 },
                    { 11, null, "Pernik is noted for its mining heritage and has grown into a dynamic industrial center.", "Pernik", (short)14 },
                    { 12, null, "Haskovo is a city with ancient roots that has evolved into a modern center for industry and commerce.", "Haskovo", (short)26 },
                    { 13, null, "Blagoevgrad is a cultural and educational hub in southwestern Bulgaria, home to a major university.", "Blagoevgrad", (short)1 },
                    { 14, null, "Yambol is an ancient town in southeastern Bulgaria known for its traditional festivals and heritage.", "Yambol", (short)28 },
                    { 15, null, "Veliko Tarnovo, once the medieval capital of Bulgaria, is famous for its historic architecture and scenic hilltop setting.", "Veliko Tarnovo", (short)4 },
                    { 16, null, "Pazardzhik is recognized for its diverse economy and vibrant local traditions.", "Pazardzhik", (short)13 },
                    { 17, null, "Vidin is a historic city on the Danube celebrated for its well‐preserved medieval fortress and riverine charm.", "Vidin", (short)5 },
                    { 18, null, "Vratsa is noted for its dramatic natural scenery, including the Vratsa Mountains and unique karst formations.", "Vratsa", (short)6 },
                    { 19, null, "Asenovgrad is a pleasant town famous for its mild climate, cultural festivals, and thriving wine production.", "Asenovgrad", (short)16 },
                    { 20, null, "Gabrovo is celebrated as the center of Bulgarian humor and craftsmanship, with a long tradition of satire.", "Gabrovo", (short)7 },
                    { 21, null, "Kazanlak is renowned for its rose oil production and the nearby Thracian tombs, a symbol of Bulgaria’s ancient past.", "Kazanlak", (short)24 },
                    { 22, null, "Kardzhali is a culturally diverse city nestled in the Rhodope Mountains with a rich historical background.", "Kardzhali", (short)9 },
                    { 23, null, "Montana is a city in northwestern Bulgaria with significant Roman and medieval historical influences.", "Montana", (short)12 },
                    { 24, null, "Kyustendil is famous for its natural mineral springs and picturesque setting at the foothills of the mountains.", "Kyustendil", (short)10 },
                    { 25, null, "Lovech is steeped in history and is best known for its iconic covered bridge and well‐preserved old town.", "Lovech", (short)11 },
                    { 26, null, "Dupnitsa is an industrial town in western Bulgaria with a strong local cultural identity.", "Dupnitsa", (short)10 },
                    { 27, null, "Petrich lies near Bulgaria’s borders with Greece and North Macedonia and is known for its rich cross‐cultural heritage.", "Petrich", (short)1 },
                    { 28, null, "Sandanski is celebrated for its mild climate and extensive health and spa tourism.", "Sandanski", (short)1 },
                    { 29, null, "Named after a national hero, Gotse Delchev is an important cultural and administrative center in the region.", "Gotse Delchev", (short)1 },
                    { 30, null, "Aytos is a lively town in Burgas Province known for its dynamic local economy and cultural events.", "Aytos", (short)2 },
                    { 31, null, "Kameno is a coastal town in Burgas Province with a strong maritime tradition.", "Kameno", (short)2 },
                    { 32, null, "Malko Tarnovo is a picturesque town known for its scenic landscapes along the Black Sea coast.", "Malko Tarnovo", (short)2 },
                    { 33, null, "Nesebar is a UNESCO-listed town famed for its ancient ruins and charming old town on the Black Sea.", "Nesebar", (short)2 },
                    { 34, null, "Pomorie is known for its mineral-rich mud and as a popular spa and beach resort.", "Pomorie", (short)2 },
                    { 35, null, "Primorsko is a small seaside town celebrated for its pristine beaches and relaxed atmosphere.", "Primorsko", (short)2 },
                    { 36, null, "Ruen is a quiet town in Burgas Province with traditional Bulgarian charm.", "Ruen", (short)2 },
                    { 37, null, "Sozopol is a historic town known for its ancient ruins, art festivals, and seaside ambience.", "Sozopol", (short)2 },
                    { 38, null, "Sredets is a town with deep historical roots and a strategic location near the Black Sea.", "Sredets", (short)2 },
                    { 39, null, "Sungurlare is known for its traditional crafts and scenic surroundings in southeastern Bulgaria.", "Sungurlare", (short)2 },
                    { 40, null, "Tsarevo is a charming Black Sea town with a rich maritime history and relaxed pace of life.", "Tsarevo", (short)2 },
                    { 41, null, "Balchik is renowned for its beautiful botanical garden and seaside resort atmosphere.", "Balchik", (short)8 },
                    { 42, null, "Dobrichka is a small town in the fertile region of Dobrich, serving as a local administrative center.", "Dobrichka", (short)8 },
                    { 43, null, "General Toshevo is an agricultural town with a strong local economy in northeastern Bulgaria.", "General Toshevo", (short)8 },
                    { 44, null, "Krushari is a modest town known for its close-knit community and rural charm.", "Krushari", (short)8 },
                    { 45, null, "Shabla is famous for its long sandy beach and the nearby Shabla Lighthouse.", "Shabla", (short)8 },
                    { 46, null, "Tervel is a town steeped in history and known for its agricultural production.", "Tervel", (short)8 },
                    { 47, null, "Dryanovo is a historic town with close ties to Bulgarian literary and cultural traditions.", "Dryanovo", (short)7 },
                    { 48, null, "Sevlievo is an industrial town known for its vibrant local economy and cultural events.", "Sevlievo", (short)7 },
                    { 49, null, "Tryavna is famous for its woodcarving tradition and well-preserved National Revival architecture.", "Tryavna", (short)7 },
                    { 50, null, "Dimitrovgrad is an important industrial town with modern infrastructure in southern Bulgaria.", "Dimitrovgrad", (short)26 },
                    { 51, null, "Harmanli is a town with a long history and is known for its traditional craft and cuisine.", "Harmanli", (short)26 },
                    { 52, null, "Ivaylovgrad is a small town that serves as a gateway to the scenic Rhodope Mountains.", "Ivaylovgrad", (short)26 },
                    { 53, null, "Lyubimets is recognized for its agricultural surroundings and friendly local community.", "Lyubimets", (short)26 },
                    { 54, null, "Madzharovo is known for its picturesque setting and as a center of local traditions.", "Madzharovo", (short)26 },
                    { 55, null, "Mineralni Bani is famed for its therapeutic mineral springs and spa resorts.", "Mineralni Bani", (short)26 },
                    { 56, null, "Simeonovgrad is an industrial town with deep historical roots in the Haskovo region.", "Simeonovgrad", (short)26 },
                    { 57, null, "Stambolovo is a quiet town with a strong agricultural base and traditional culture.", "Stambolovo", (short)26 },
                    { 58, null, "Svilengrad is located near the Turkish border and is known for its cross‐cultural influences.", "Svilengrad", (short)26 },
                    { 59, null, "Topolovgrad is a town in the fertile plains of Haskovo, recognized for its agricultural production.", "Topolovgrad", (short)26 },
                    { 60, null, "Ardino is a small town set in the rugged terrain of the Rhodope Mountains.", "Ardino", (short)9 },
                    { 61, null, "Chernoochene is known for its traditional lifestyle and scenic mountain vistas.", "Chernoochene", (short)9 },
                    { 62, null, "Dzhebel is a town with a rich cultural heritage located amid rolling hills.", "Dzhebel", (short)9 },
                    { 63, null, "Kirkovo is a modest town that reflects the diverse cultural tapestry of the region.", "Kirkovo", (short)9 },
                    { 64, null, "Krumovgrad is a dynamic town known for its industrial development and cultural diversity.", "Krumovgrad", (short)9 },
                    { 65, null, "Momchilgrad is renowned for its traditional crafts and scenic mountain setting.", "Momchilgrad", (short)9 },
                    { 66, null, "Boboshevo is a quiet town in western Bulgaria with rich traditions and a peaceful pace of life.", "Boboshevo", (short)10 },
                    { 67, null, "Bobov Dol is known for its vibrant community and local historical landmarks.", "Bobov Dol", (short)10 },
                    { 68, null, "Kocherinovo is a small town celebrated for its cultural heritage and scenic surroundings.", "Kocherinovo", (short)10 },
                    { 69, null, "Nevestino is a town with a strong local identity and picturesque landscapes.", "Nevestino", (short)10 },
                    { 70, null, "Rila is a charming town sharing its Name with the famous mountain range nearby.", "Rila", (short)10 },
                    { 71, null, "Sapareva Banya is famed for its hot mineral waters and therapeutic spa facilities.", "Sapareva Banya", (short)10 },
                    { 72, null, "Treklyano is a small town known for its rural charm and scenic beauty.", "Treklyano", (short)10 },
                    { 73, null, "Apriltsi is a picturesque town in Lovech Province, rich in traditional architecture.", "Apriltsi", (short)11 },
                    { 74, null, "Letnitsa is a quiet town known for its agricultural surroundings and friendly community.", "Letnitsa", (short)11 },
                    { 75, null, "Lukovit is recognized for its rural character and longstanding local traditions.", "Lukovit", (short)11 },
                    { 76, null, "Teteven is a historic town surrounded by beautiful landscapes and cultural heritage.", "Teteven", (short)11 },
                    { 77, null, "Troyan is known for its crafts, folklore, and as a gateway to scenic mountain areas.", "Troyan", (short)11 },
                    { 78, null, "Ugarchin is a small town with a strong sense of community and rich history.", "Ugarchin", (short)11 },
                    { 79, null, "Yablanitsa is a charming town celebrated for its traditional celebrations and local crafts.", "Yablanitsa", (short)11 },
                    { 80, null, "Berkovitsa is a town with a deep historical legacy and beautiful natural surroundings.", "Berkovitsa", (short)12 },
                    { 81, null, "Boychinovtsi is known for its vibrant local culture and picturesque rural setting.", "Boychinovtsi", (short)12 },
                    { 82, null, "Brusartsi is a small town characterized by its peaceful atmosphere and traditional lifestyle.", "Brusartsi", (short)12 },
                    { 83, null, "Chiprovtsi is famous for its rich cultural traditions and historic stone architecture.", "Chiprovtsi", (short)12 },
                    { 84, null, "Georgi Damyanovo is a town noted for its rural charm and traditional craftsmanship.", "Georgi Damyanovo", (short)12 },
                    { 85, null, "Lom is a town situated along the Danube, known for its river port and scenic views.", "Lom", (short)12 },
                    { 86, null, "Medkovets is a quiet town with a rich agricultural tradition and friendly locals.", "Medkovets", (short)12 },
                    { 87, null, "Valchedram is a small town surrounded by beautiful natural landscapes in northwestern Bulgaria.", "Valchedram", (short)12 },
                    { 88, null, "Varshets is famous for its mineral springs and as a popular destination for health tourism.", "Varshets", (short)12 },
                    { 89, null, "Yakimovo is a town known for its peaceful rural setting and traditional local lifestyle.", "Yakimovo", (short)12 },
                    { 90, null, "Batak is steeped in history and known for its role in Bulgaria's struggle for independence.", "Batak", (short)13 },
                    { 91, null, "Belovo is a town known for its vibrant local traditions and scenic natural surroundings.", "Belovo", (short)13 },
                    { 92, null, "Bratsigovo is celebrated for its rich folklore and traditional crafts.", "Bratsigovo", (short)13 },
                    { 93, null, "Lesichovo is a quiet town known for its warm community and local agricultural production.", "Lesichovo", (short)13 },
                    { 94, null, "Panagyurishte is famous for the Panagyurishte Gold Treasure and its cultural festivals.", "Panagyurishte", (short)13 },
                    { 95, null, "Peshtera is an ancient town with a long history and a strong agricultural base.", "Peshtera", (short)13 },
                    { 96, null, "Rakitovo is known for its picturesque setting and as a center of local crafts.", "Rakitovo", (short)13 },
                    { 97, null, "Sarnitsa is a small town with a traditional lifestyle in the heart of the region.", "Sarnitsa", (short)13 },
                    { 98, null, "Septemvri is an industrial town with roots in Bulgaria’s modern economic development.", "Septemvri", (short)13 },
                    { 99, null, "Velingrad is celebrated as the spa capital of Bulgaria, famed for its mineral springs.", "Velingrad", (short)13 },
                    { 100, null, "Breznik is a historic town known for its traditional architecture and mining heritage.", "Breznik", (short)14 },
                    { 101, null, "Kovachevtsi is a town with deep industrial roots and a strong local community.", "Kovachevtsi", (short)14 },
                    { 102, null, "Radomir is known for its industrial development and rich cultural traditions.", "Radomir", (short)14 },
                    { 103, null, "Tran is a small town with a long history and an important local administrative role.", "Tran", (short)14 },
                    { 104, null, "Zemen is a town noted for its peaceful atmosphere and traditional Bulgarian culture.", "Zemen", (short)14 },
                    { 105, null, "Belene is a riverside town with historical significance and a strong local community.", "Belene", (short)15 },
                    { 106, null, "Cherven Bryag is known for its red–brick architecture and lively cultural traditions.", "Cherven Bryag", (short)15 },
                    { 107, null, "Dolna Mitropoliya is a town with ancient roots and a long history in the region.", "Dolna Mitropoliya", (short)15 },
                    { 108, null, "Dolni Dabnik is a modest town in northern Bulgaria, recognized for its local traditions.", "Dolni Dabnik", (short)15 },
                    { 109, null, "Gulyantsi is an agricultural town known for its rich black–earth soils and friendly locals.", "Gulyantsi", (short)15 },
                    { 110, null, "Iskar is a town set along the Iskar River, known for its natural beauty and heritage.", "Iskar", (short)15 },
                    { 111, null, "Knezha is a historic town with roots in the agricultural traditions of northern Bulgaria.", "Knezha", (short)15 },
                    { 112, null, "Levski is Named in honor of Bulgaria’s national hero and is known for its patriotic spirit.", "Levski", (short)15 },
                    { 113, null, "Nikopol is a town on the Danube with a rich history dating back to Roman times.", "Nikopol", (short)15 },
                    { 114, null, "Pordim is a small town known for its quiet atmosphere and traditional community life.", "Pordim", (short)15 },
                    { 115, null, "Brezovo is a quaint town in central Bulgaria with scenic surroundings and a relaxed pace of life.", "Brezovo", (short)16 },
                    { 116, null, "Hisarya is famous for its mineral springs and well–preserved Roman ruins.", "Hisarya", (short)16 },
                    { 117, null, "Kaloyanovo is a small town with a strong agricultural economy and rich local traditions.", "Kaloyanovo", (short)16 },
                    { 118, null, "Karlovo is renowned for its role in Bulgaria’s national revival and its production of fine textiles.", "Karlovo", (short)16 },
                    { 119, null, "Krichim is an industrial town with historical roots and a growing modern economy.", "Krichim", (short)16 },
                    { 120, null, "Kuklen is known for its peaceful surroundings and as a gateway to nearby historical sites.", "Kuklen", (short)16 },
                    { 121, null, "Laki is a small town with a rich agricultural tradition and scenic natural landscapes.", "Laki", (short)16 },
                    { 122, null, "Rakovski is Named after a revolutionary leader and is known for its historical monuments.", "Rakovski", (short)16 },
                    { 123, null, "Rodopi is a town set in the foothills of the Rhodope Mountains with a rich cultural heritage.", "Rodopi", (short)16 },
                    { 124, null, "Sadovo is an agricultural town known for its vibrant local markets and friendly community.", "Sadovo", (short)16 },
                    { 125, null, "Saedinenie is a town that played an important role in Bulgaria’s unification and modern history.", "Saedinenie", (short)16 },
                    { 126, null, "Sopot is known for its picturesque old town and rich tradition in the arts and crafts.", "Sopot", (short)16 },
                    { 127, null, "Stamboliyski is a town with deep agricultural roots and a thriving local economy.", "Stamboliyski", (short)16 },
                    { 128, null, "Parvomay is celebrated for its traditional crafts and its role as a local commercial center.", "Parvomay", (short)16 },
                    { 129, null, "Perushtitsa is a town with a long history and a strong agricultural and cultural presence.", "Perushtitsa", (short)16 },
                    { 130, null, "Borovo is a small town on the Danube known for its scenic river views and local traditions.", "Borovo", (short)18 },
                    { 131, null, "Byala is a quiet town in Ruse Province noted for its charming atmosphere and historic roots.", "Byala", (short)18 },
                    { 132, null, "Dve Mogili is an agricultural town with a strong community spirit in northern Bulgaria.", "Dve Mogili", (short)18 },
                    { 133, null, "Ivanovo is known for its cultural heritage and as a center for local artisanal crafts.", "Ivanovo", (short)18 },
                    { 134, null, "Slivo Pole is a town with a rich agricultural tradition and scenic natural surroundings.", "Slivo Pole", (short)18 },
                    { 135, null, "Tsenovo is a modest town in the Danubian plain with a history dating back to Roman times.", "Tsenovo", (short)18 },
                    { 136, null, "Vetovo is known for its rural character and traditional local customs.", "Vetovo", (short)18 },
                    { 137, null, "Hitrino is a small town with a quiet atmosphere and a rich cultural heritage.", "Hitrino", (short)27 },
                    { 138, null, "Kaolinovo is known for its clay deposits and traditional local crafts.", "Kaolinovo", (short)27 },
                    { 139, null, "Kaspichan is a town with a long history and is noted for its agricultural production.", "Kaspichan", (short)27 },
                    { 140, null, "Nikola Kozlevo is a small town recognized for its scenic surroundings and traditional lifestyle.", "Nikola Kozlevo", (short)27 },
                    { 141, null, "Smyadovo is an agricultural town with deep roots in the local culture.", "Smyadovo", (short)27 },
                    { 142, null, "Varbitsa is known for its natural beauty and as a center for regional trade.", "Varbitsa", (short)27 },
                    { 143, null, "Veliki Preslav is a historic town once a capital of the First Bulgarian Empire.", "Veliki Preslav", (short)27 },
                    { 144, null, "Venets is a quiet village–turned–town with a strong traditional character.", "Venets", (short)27 },
                    { 145, null, "Alfatar is a town known for its agricultural surroundings and traditional crafts.", "Alfatar", (short)19 },
                    { 146, null, "Dulovo is a town with deep historical roots and a prominent local community.", "Dulovo", (short)19 },
                    { 147, null, "Glavinitsa is known for its rural charm and longstanding agricultural traditions.", "Glavinitsa", (short)19 },
                    { 148, null, "Kaynardzha is a small town celebrated for its cultural heritage and scenic views.", "Kaynardzha", (short)19 },
                    { 149, null, "Sitovo is a modest town in Silistra Province with a peaceful rural character.", "Sitovo", (short)19 },
                    { 150, null, "Kotel is renowned for its cultural and literary traditions, as well as its historic architecture.", "Kotel", (short)20 },
                    { 151, null, "Nova Zagora is a thriving town known for its modern industry and pleasant climate.", "Nova Zagora", (short)20 },
                    { 152, null, "Banite is a small mountain town known for its traditional crafts and scenic landscapes.", "Banite", (short)21 },
                    { 153, null, "Borino is a quiet town in the heart of the Rhodope Mountains with a rich cultural heritage.", "Borino", (short)21 },
                    { 154, null, "Chepelare is famed for its winter sports facilities and breathtaking mountain scenery.", "Chepelare", (short)21 },
                    { 155, null, "Devin is celebrated for its healing mineral waters and as a popular spa destination.", "Devin", (short)21 },
                    { 156, null, "Dospat is a picturesque town surrounded by forests and mountainous landscapes.", "Dospat", (short)21 },
                    { 157, null, "Madan is known for its mining history and its charming local traditions.", "Madan", (short)21 },
                    { 158, null, "Nedelino is a small town with a close-knit community in the scenic Rhodope region.", "Nedelino", (short)21 },
                    { 159, null, "Smolyan is the administrative center of its province and a gateway to the Rhodope Mountains.", "Smolyan", (short)21 },
                    { 160, null, "Antonovo is a town in Targovishte Province known for its traditional markets and community spirit.", "Antonovo", (short)25 },
                    { 161, null, "Omurtag is Named after a medieval ruler and is an important local administrative center.", "Omurtag", (short)25 },
                    { 162, null, "Opaka is a modest town with deep agricultural roots and traditional Bulgarian culture.", "Opaka", (short)25 },
                    { 163, null, "Popovo is a town known for its rich history and its location in the fertile Targovishte plain.", "Popovo", (short)25 },
                    { 164, null, "Pavlikeni is a historic town with a proud cultural tradition in the heart of northern Bulgaria.", "Pavlikeni", (short)4 },
                    { 165, null, "Polski Trambesh is a town known for its rural character and historical significance.", "Polski Trambesh", (short)4 },
                    { 166, null, "Belogradchik is famed for its dramatic rock formations and well–preserved medieval fortress.", "Belogradchik", (short)5 },
                    { 167, null, "Boynitsa is a small town with a rich cultural heritage and scenic views near the Danube.", "Boynitsa", (short)5 },
                    { 168, null, "Bregovo is known for its traditional industries and its location along the Danube River.", "Bregovo", (short)5 },
                    { 169, null, "Chuprene is a picturesque town set amidst lush forests and steeped in local folklore.", "Chuprene", (short)5 },
                    { 170, null, "Dimovo is a small town with a longstanding agricultural tradition and a peaceful atmosphere.", "Dimovo", (short)5 },
                    { 171, null, "Gramada is recognized for its historic monuments and scenic rural landscape.", "Gramada", (short)5 },
                    { 172, null, "Kula is a town on the Danube noted for its fortress ruins and picturesque riverside views.", "Kula", (short)5 },
                    { 173, null, "Makresh is a quiet town with traditional charm and scenic surroundings in northwestern Bulgaria.", "Makresh", (short)5 },
                    { 174, null, "Novo Selo is a town known for its rich history and its proximity to the Danube’s scenic banks.", "Novo Selo", (short)5 },
                    { 175, null, "Ruzhintsi is a modest town with a traditional lifestyle and strong local customs.", "Ruzhintsi", (short)5 },
                    { 176, null, "Borovan is a small town known for its peaceful setting and scenic mountain views.", "Borovan", (short)6 },
                    { 177, null, "Hayredin is recognized for its rural character and its proximity to natural reserves.", "Hayredin", (short)6 },
                    { 178, null, "Kozloduy is a town famous for its nuclear power plant and its strategic location on the Danube.", "Kozloduy", (short)6 },
                    { 179, null, "Miziya is an industrial town with a strong local economy in northwestern Bulgaria.", "Miziya", (short)6 },
                    { 180, null, "Oryahovo is a historic town on the Danube, known for its charming riverside ambiance.", "Oryahovo", (short)6 },
                    { 181, null, "Roman is a town with rich history and important cultural landmarks in the region.", "Roman", (short)6 },
                    { 182, null, "Bolyarovo is a small town with deep agricultural traditions and a warm community spirit.", "Bolyarovo", (short)28 },
                    { 183, null, "Straldzha is known for its traditional festivals and its scenic rural surroundings.", "Straldzha", (short)28 },
                    { 184, null, "Tundzha is a town located along the Tundzha River, celebrated for its cultural heritage.", "Tundzha", (short)28 },
                    { 185, null, "Bratya Daskalovi is a town with historic significance and a strong local educational tradition.", "Bratya Daskalovi", (short)24 },
                    { 186, null, "Galabovo is known for its rich cultural events and historical landmarks.", "Galabovo", (short)24 },
                    { 187, null, "Gurkovo is a town steeped in history and noted for its traditional Bulgarian spirit.", "Gurkovo", (short)24 },
                    { 188, null, "Maglizh is recognized for its traditional crafts and its peaceful, rural environment.", "Maglizh", (short)24 },
                    { 189, null, "Nikolaevo is a small town with historical roots and a strong local identity.", "Nikolaevo", (short)24 },
                    { 190, null, "Opan is known for its quiet atmosphere and its close connection to Bulgaria’s past.", "Opan", (short)24 },
                    { 191, null, "Pavel Banya is celebrated for its mineral springs and spa resorts, attracting many visitors.", "Pavel Banya", (short)24 },
                    { 192, null, "Bankya is a suburban town near Sofia, famed for its therapeutic mineral waters and green surroundings.", "Bankya", (short)23 },
                    { 193, null, "Dragoman is a quaint town with a rich history and scenic countryside in western Bulgaria.", "Dragoman", (short)23 },
                    { 194, null, "Gorna Malina is known for its traditional architecture and as a quiet retreat from urban life.", "Gorna Malina", (short)23 },
                    { 195, null, "Botevgrad is a town with a strong industrial base and deep cultural traditions.", "Botevgrad", (short)23 },
                    { 196, null, "Bozhurishte is a small town in Sofia Province known for its scenic beauty and close-knit community.", "Bozhurishte", (short)23 },
                    { 197, null, "Chavdar is a town characterized by its traditional architecture and rural charm.", "Chavdar", (short)23 },
                    { 198, null, "Chelopech is known for its rich mining heritage and vibrant local culture.", "Chelopech", (short)23 },
                    { 199, null, "Dolna Banya is famous for its healing thermal waters and tranquil environment.", "Dolna Banya", (short)23 },
                    { 200, null, "Elin Pelin is renowned for its literary heritage and charming small‐town atmosphere.", "Elin Pelin", (short)23 },
                    { 201, null, "Godech is a town with a rich history and is known for its traditional crafts and local festivals.", "Godech", (short)23 },
                    { 202, null, "Koprivshtitsa is celebrated for its well-preserved National Revival architecture and historical significance.", "Koprivshtitsa", (short)23 },
                    { 203, null, "Kostenets is a town known for its pleasant climate and a strong tradition in agriculture.", "Kostenets", (short)23 },
                    { 204, null, "Kostinbrod is recognized for its industrial development and proximity to Sofia.", "Kostinbrod", (short)23 },
                    { 205, null, "Mirkovo is a small town with a peaceful atmosphere and deep-rooted local traditions.", "Mirkovo", (short)23 },
                    { 206, null, "Pirdop is known for its natural beauty and an important industrial sector.", "Pirdop", (short)23 },
                    { 207, null, "Pravets is famous as a center of computer manufacturing during the communist era and for its modern educational institutions.", "Pravets", (short)23 },
                    { 208, null, "Samokov is a gateway to winter sports, nestled between the Rila and Vitosha mountains.", "Samokov", (short)23 },
                    { 209, null, "Slivnitsa is an industrial town with a rich military history and modern development.", "Slivnitsa", (short)23 },
                    { 210, null, "Svoge is known for its beautiful landscapes and thriving local small–business community.", "Svoge", (short)23 },
                    { 211, null, "Zlatitsa is a town with historical significance and a vibrant local cultural scene.", "Zlatitsa", (short)23 },
                    { 212, null, "Novi Iskar is a suburban town with modern amenities and a growing population.", "Novi Iskar", (short)23 },
                    { 213, null, "Novi Pazar is known for its traditional crafts and as an emerging local trade center.", "Novi Pazar", (short)27 },
                    { 214, null, "Tutrakan is a historic town on the Danube, known for its cultural landmarks and port facilities.", "Tutrakan", (short)19 },
                    { 215, null, "Karnobat is a town with a rich history and vibrant local traditions in the heart of Burgas Province.", "Karnobat", (short)2 },
                    { 216, null, "Kavarna is a coastal town famed for its rock festivals and beautiful Black Sea beaches.", "Kavarna", (short)8 },
                    { 217, null, "Silistra is a historic port city on the Danube, known for its ancient ruins and strategic location.", "Silistra", (short)19 },
                    { 218, null, "Ihtiman is a town with a long history, nestled in the foothills and known for its traditional crafts.", "Ihtiman", (short)23 },
                    { 219, null, "Sinemorets is a small coastal town with a serene atmosphere and scenic beaches.", "Sinemorets", (short)2 },
                    { 220, null, "Etropole is a town known for its rich history, beautiful natural surroundings, and traditional crafts.", "Etropole", (short)23 },
                    { 221, null, "Simitli is a town famous for its cultural festivals and as a center for traditional Bulgarian crafts.", "Simitli", (short)1 },
                    { 222, null, "Satovcha is known for its authentic rural charm and its well-preserved traditional architecture.", "Satovcha", (short)1 },
                    { 223, null, "Strumyani is a small town with a quiet atmosphere and deep agricultural roots.", "Strumyani", (short)1 },
                    { 224, null, "Bansko is a famous ski resort town known for its winter sports and well-preserved historical center.", "Bansko", (short)1 },
                    { 225, null, "Ihtiman is a historic town with a blend of modern industry and traditional culture.", "Ihtiman", (short)23 },
                    { 226, null, "Chavdarovo is a charming town in Montana Province with a rich rural heritage.", "Chavdarovo", (short)12 },
                    { 227, null, "Dolno Varbovo is a small town in the fertile northern plains with a strong agricultural base.", "Dolno Varbovo", (short)15 },
                    { 228, null, "Golyamo Selo is a quaint town known for its traditional architecture and pastoral surroundings.", "Golyamo Selo", (short)15 },
                    { 229, null, "Kuklenovo is a town with deep cultural roots and a long tradition of local craftsmanship.", "Kuklenovo", (short)16 },
                    { 230, null, "Bistritsa is a picturesque town nestled in the foothills of the Balkan Mountains.", "Bistritsa", (short)23 },
                    { 231, null, "Cherno Pole is a town renowned for its fertile black–earth soils and agricultural production.", "Cherno Pole", (short)15 },
                    { 232, null, "Dobro Pole is a historic town with a rich cultural heritage and traditional Bulgarian spirit.", "Dobro Pole", (short)24 },
                    { 233, null, "Kriva Bara is a town located near the Danube, offering scenic river views and historical charm.", "Kriva Bara", (short)5 },
                    { 234, null, "Krumovitsa is a small town with traditional Bulgarian charm and picturesque rural landscapes.", "Krumovitsa", (short)12 },
                    { 235, null, "Levski Dol is a town Named in honor of national hero Vasil Levski, with deep local traditions.", "Levski Dol", (short)15 },
                    { 236, null, "Madzharovo is a modern town in Haskovo Province with rapid development and local heritage.", "Madzharovo", (short)26 },
                    { 237, null, "Novo Selo is a newly established town in the Danubian plain, known for its fresh start and community spirit.", "Novo Selo", (short)18 },
                    { 238, null, "Pavlovets is a quaint town on the outskirts of Sofia with traditional charm and scenic views.", "Pavlovets", (short)23 },
                    { 239, null, "Pchelina is a coastal town with a serene atmosphere and a rich maritime tradition.", "Pchelina", (short)3 },
                    { 240, null, "Ploski is a small town known for its expansive agricultural lands and friendly locals.", "Ploski", (short)8 },
                    { 241, null, "Polski Dol is a town with historical significance and traditional roots in northern Bulgaria.", "Polski Dol", (short)4 },
                    { 242, null, "Radostino is celebrated for its warm community spirit and vibrant local festivals.", "Radostino", (short)16 },
                    { 243, null, "Rakovski is a town Named after a revolutionary leader, reflecting Bulgaria’s proud heritage.", "Rakovski", (short)16 },
                    { 244, null, "Stoyanovo is known for its traditional crafts and local folklore, echoing Bulgaria’s rich past.", "Stoyanovo", (short)7 },
                    { 245, null, "Trayanovo is a town that reflects Bulgaria's long historical legacy and rural traditions.", "Trayanovo", (short)24 },
                    { 246, null, "Vedelina is a charming town in Lovech Province, known for its warm community and scenic beauty.", "Vedelina", (short)11 },
                    { 247, null, "Videnovo is a town with a rich history and modern developments along the Danube.", "Videnovo", (short)5 },
                    { 248, null, "Vitosha is Named for the nearby mountain and is popular with tourists and nature–lovers alike.", "Vitosha", (short)23 },
                    { 249, null, "Zabernovo is a small town with beautiful natural surroundings and traditional local character.", "Zabernovo", (short)12 },
                    { 250, null, "Zelen is known for its lush green landscapes and strong agricultural traditions.", "Zelen", (short)13 },
                    { 251, null, "Zlatna is a town famous for its golden–age historical monuments and cultural heritage.", "Zlatna", (short)4 },
                    { 252, null, "Zornitsa is a vibrant town with lively cultural events and a rich traditional heritage.", "Zornitsa", (short)27 },
                    { 253, null, "Zlatograd is a modern town in the mountainous Smolyan region with rapidly growing industry.", "Zlatograd", (short)21 },
                    { 254, null, "Bistritsa Dol is a town in the scenic Bistritsa valley known for its natural beauty and calm lifestyle.", "Bistritsa Dol", (short)23 },
                    { 255, null, "Dolno Golyamo is a traditional town with deep historical roots in the fertile plains of northern Bulgaria.", "Dolno Golyamo", (short)15 },
                    { 256, null, "Gorna Dobrina is a town that blends centuries-old heritage with modern living.", "Gorna Dobrina", (short)24 },
                    { 257, null, "Novo Cherno is a town known for its recent developments and scenic beauty near the Danube.", "Novo Cherno", (short)5 },
                    { 258, null, "Isperih is known for its agricultural economy and serves as an important local center in Razgrad Province.", "Isperih", (short)17 },
                    { 259, null, "Kubrat functions as a regional hub in Razgrad Province, with a rich blend of cultural traditions and modern commerce.", "Kubrat", (short)17 },
                    { 260, null, "Loznitsa is a town with deep agricultural roots and a long history, contributing to the province's cultural mosaic.", "Loznitsa", (short)17 },
                    { 261, null, "Razgrad, the provincial capital, is steeped in history and renowned for its traditional festivals and local heritage.", "Razgrad", (short)17 },
                    { 262, null, "Samuil is characterized by its rural charm and historical landmarks, representing the rich traditions of Razgrad Province.", "Samuil", (short)17 },
                    { 263, null, "Tsar Kaloyan is Named after a medieval ruler and is noted for its cultural legacy and local traditions in Razgrad Province.", "Tsar Kaloyan", (short)17 },
                    { 264, null, "Zavet is known for its peaceful atmosphere and strong local customs, adding to the diversity of Razgrad Province.", "Zavet", (short)17 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Town",
                keyColumn: "Id",
                keyValue: 264);
        }
    }
}
