using Models;

namespace Services
{
    internal static class FoodsService
    {
        private static List<Food> foods = new()
        {
            new()
            {
                Name = "Männi-laimi ja karamelli jäätise parfe",
                HeroImage = "pinelime.jpg",
                Description = "Männi-laimi ja karamelli jäätise parfe on võrratu magustoit, milles on ühendatud männi- " +
                "laimi värskendav maitse ning karamelli magusus, kihiti koos kreemja jäätisega. " +
                "Need maitsvad kihid kihistatakse parfee klaasi, " +
                "luues visuaalselt ahvatleva magustoidu, mis rõhutab iga kihi elavaid värve ja tekstuure. " +
                "Kreemja jäätise, männi-laimi ja karamelli kombinatsioon moodustab tõeliselt vastupandamatu roa, " +
                "mis rahuldab kindlasti iga magusaisu.",
                Ingredients = "3/4 tassi (30 g) röstitud kookoshelbeid\n1L makadaamia karamellijäätist\n3 laimi peeneks riivitud koor\nLaimiviilud serveerimiseks (valikuline)\nMännilaim\n1 (1,8–2 kg) suur magus ananass, tükeldatud, kooritud ja silmad eemaldatud\n1/3 tassi (80 ml) puhast vahtrasiirupit\n3 laimi mahl",
                Recipe = "Männilaimi jaoks eelsoojenda puuküttega ahi või köögiahi 280°C/260°C ventilaatoriga. Kuumuta ahjus suur malmpann.\n\nVahepeal lõigake ananass pikisuunas pooleks, seejärel lõigake kumbki pool pikisuunas 4 pikaks viiluks. Lõika iga riba õhukeselt risti, et moodustada väikesed kolmnurgad, seejärel tõsta kaussi. Lisa vahtrasiirup ja viska kattele. Vala ettevaatlikult eelkuumutatud pannile ja rösti 10-12 minutit, kuni see on kuldne.\n\nVõta pann ettevaatlikult ahjust välja ja sega läbi laimimahla. Tõsta toatemperatuurini jahtuma.\n\nLusikaga pool männilaimi 6 serveerimisklaasi hulka ja puista peale pool kookospähklit. Vala peale suured kulbid jäätist, seejärel lusikaga peale ülejäänud männilaimi. Puista peale ülejäänud kookose- ja laimikoor. Serveeri koos laimiviiludega, soovi korral peale pigistamiseks.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
            {
                "https://img.delicious.com.au/fxc52y2X/w759-h506-cfill/del/2023/11/cheats-pine-lime-and-caramel-ice-cream-parfaits-201069-2.jpg"
        }
    },

            new()
            {
                Name = "Magus Filipiinide tofu (taho)",
                HeroImage = "taho.jpg",
                Description = "Taho on traditsiooniline magustoit Filipiinidelt, mis koosneb pehmest tofu-köögiviljast,  " +
                "mida serveeritakse sooja pruuni suhkru ja tapiokapärlikesegu, " +
                "sageli koos vaniljeekstrakti lisanditega. See annab talle rikkaliku ja magusa maitse ning unikaalse tekstuuri, mis sulab suus. " +
                "Taho on populaarne tänavatoit ja hommikusöök Filipiinidel ning seda " +
                "serveeritakse tavaliselt plastiktopsis või klaasist kaussides,  " +
                "pakkudes kohalikele ja turistidele meeldivat maitseelamust. " ,
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Ingredients = "1 tass (190 g) tapiokkpärleid\n1 tass (250 g) tihedalt pakitud pruuni suhkrut\n1 pandanileht (Aasia toidupoodidest), sõlmitud\n300 g siidist tofut, nõrutatud",
                Recipe = "Kuumuta 8 tassi (2L) vett suures kastrulis kõrgel kuumusel keema. Lisa tapiokkpärlid ja sega ettevaatlikult kleepumise vältimiseks. Keeda 12-15 minutit, aeg-ajalt segades, kuni see muutub läbipaistvaks. Eemaldage tulelt ja seista 15 minutit, aeg-ajalt segades.\n\nVahepeal asetage suhkur, pandanileht ja 1/2 tassi (125 ml) vett keskmisel kuumusel kastrulisse. Küpseta pidevalt segades, kuni suhkur lahustub. Kuumuta keemiseni ja hauta aeg-ajalt segades 5 minutit või kuni segu pakseneb siirupiks. Eemaldage kuumusest, visake pandanileht ära ja hoidke segu soojas.\n\nNõruta ja loputa tapiokk külma vee all. Tõsta keskmisesse kaussi ja lisa kleepumise vältimiseks 2–3 sl pruuni suhkrusiirupit. Viska õrnalt katteks.\n\nSiidise tofu saamiseks täitke sügav kastrul veega ja asetage see keskmisele või kõrgele kuumusele. Lase vesi keema. Kui vesi soojeneb, võtke siidine tofu pakendist välja ja asetage see õrnalt väikesesse kaussi. Asetage kauss bambuse aurutisse. Kui vesi pannil keeb, asetage bambuse auruti panni peale. Aurutage tofut 2–3 minutit, et saavutada õrn tekstuur.\n\nServeerimiseks pange kihtide moodustamiseks klaasidesse lusikatäie tapiokkpärlitega lusikatäie serveerimiseks. Nirista pealt ohtralt sooja pruuni suhkrusiirupit.",
                Images = new()
            {
                "https://flouredframe.com/wp-content/uploads/2020/01/GOG_4150-1.jpg"
        }
    },

            new()
            {
                Name = "Banoffee kreemipuding valge šokolaadiga",
                HeroImage = "pudding.jpg",
                Description = "Banoffee kreemipuding valge šokolaadi puruga on võrratu magustoit, mis hellitab maitsemeeli  " +
                "oma kreemise banaanipudingi, küpsete banaaniviilude ja luksusliku toffeesiirupiga kihtidega. " +
                "Pealispinnaks on helde kogus krõbedat valge šokolaadi puru, pakkudes igas suutäies  " +
                "harmoonilist maitse- ja tekstuurielamust. Kas siis nautida pärast eineid või maiustusena igal ajal " +
                "päeval, see magustoit lubab rahuldada ka kõige nõudlikuma maitsemeeli oma rikkaliku ja  " +
                "kreemise headusega. ",
                Ingredients = "300g küpseid banaane\n1/2 tassi (125ml) vahtrasiirupit\n8 muna (toatemperatuuril), kergelt lahtiklopitud\n2tl vaniljekaunapastat\n1/2 tassi (110g) tuhksuhkrut\n900ml puhast (õhukest) koort\n250g koort de leche (spetsialiseeritud toidupoodidest)\n180 g valget šokolaadi, peeneks hakitud\n100 g röstitud makadaamiat, jämedalt hakitud",
                Recipe = "Kuumuta ahi 140°C-ni. Pane banaanid ja vahtrasiirup blenderisse ning vahusta, kuni moodustub ühtlane püree. Kurna läbi sõela suurde kaussi, lisa muna, vanill ja suhkur ning vahusta ettevaatlikult ühtlaseks. Aseta koor suurde kastrulisse keskmisel kuumusel ja kuumuta veidi alla keemistemperatuuri. Vala munasegule järk-järgult kuum koor, pidevalt, kuid õrnalt vahustades, kuni segu on segunenud.\n\nMäärita dulce de leche 1,8-liitrise ahjuvormi põhjale ja kalla peale munasegu. Asetage roog suurde sügavale pannile ja lisage nii palju keevat vett, et see jõuaks poole nõude servade peale. Küpseta 1 tund 40 minutit või kuni servad on kergelt võnkunud keskel (keskosa võib tunduda üsna õõtsuv, kuid pudingi jahtudes hangub see edasi). Eemaldage ettevaatlikult veevannist ja seiske restil, kuni see on täielikult jahtunud. Hoia külmkapis 3 tundi või kuni jahtumiseni ja tardumiseni.\n\nVahepeal tõsta ahju temperatuuri 180°C-ni. Määri suur ahjuplaat rasvaga ja vooderda see küpsetuspaberiga.\n\nŠokolaadi murenemiseks puista šokolaad ettevalmistatud alusele ja küpseta pooleldi segades 10–12 minutit, kuni see on helekuldne. Laske 5 minutit jahtuda, seejärel purustage šokolaad väikesteks tükkideks ja segage makadaamiaga. Vahetult enne serveerimist puista pudingule.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.crazyforcrust.com/wp-content/uploads/2023/11/banoffee-pie-recipe-5.jpg"
                }
            },

            new()
            {
                Name = " Karamelliseeritud banaan ja jäätisega",
                HeroImage = "butterscotch.jpg",
                Description = "Võikreemikaste koos karamelliseeritud võiga banaanide ja jäätisega on nauditav magustoit, mis " +
                            "ühendab rikkaliku võikreemikastme karamelliseeritud banaanide ja kreemja jäätisega. " +
                            "Kaste pakub luksuslikku segu võist, pruunist suhkrust ja koorest, luues sametise magususe, mis katavad " +
                            "iga lusikatäie. Koos karamelliseeritud võiga banaanidega pakub see magustoit võrratut maitsete " +
                            "ja tekstuuride kontrasti, samal ajal kui jahe, siidine jäätis pakub igale ampsule värskendavat " +
                            "lõpetust. Ideaalne võimalus rahuldada magusa isu, pakkudes samal ajal soojade, kleepuvate " +
                            "kastme ja jahe, kreemja jäätise indulgentset kombinatsiooni." ,
                Ingredients = "1/2 tassi tihedalt pakitud (125 g) pruuni suhkrut\n150 g soolamata võid, tükeldatud\n1/2 tassi (125 ml) puhast (õhukest) koort\n4 tugevat, küpset banaani\n1/2 sidruni mahl\n8 väikest kulbitäit vaniljejäätist \n1/2 tassi (75 g) soolatud maapähkleid, jämedalt hakitud",
                Recipe = "Asetage 4 magustoidukaussi sügavkülma jahtuma.\n\nPane suhkur ja 100 g võid kastrulisse keskmisel kuumusel ning küpseta segades 2–3 minutit, kuni suhkur lahustub. Pidevalt vahustades lisage aeglaselt koor (segu võib pritsida), seejärel küpseta veel 1 minut või kuni segu on ühtlane ja segunenud. Tõsta tulelt, lisa 1 tl soolahelbeid ja sega lahustumiseni. Tõsta kõrvale ja hoia soojas.\n\nSulata pannil keskmisel kuumusel veel 25g võid vahule. Koori 2 banaani ja viiluta pikisuunas. Lisa pannile poole sidruni mahl ja banaaniviilud. Küpseta mõlemalt poolt 1-2 minutit, kuni banaanid on pehmed ja helekuldsed, kuid säilitavad siiski oma kuju. Tõsta kõrvale ja hoia soojas. Korrake ülejäänud 25 g või, sidrunimahla ja banaanidega.\n\nEemaldage kausid sügavkülmast ja asetage igasse kaussi 2 jäätist. Lisa igasse kaussi 2 banaaniviilu, seejärel vala serveerimiseks peale soe butterscotch kaste ja hakitud maapähkleid.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://bojongourmet.com/wp-content/uploads/2013/08/boozy-banana-butterscotch-ice-cream-231.jpg"
                }
            },

            new()
            {
                Name = "Suve marjageel",
                HeroImage = "kook.jpg",
                Description = "Suve marjageel on värskendav magustoit, mille maitse on täis värskete marjade elavat maitset.  " +
                "Valmistatud marjapüree ja želatiini seguga, pakub see geel magusat ja hapukat maitsekooslust. " +
                "Selle ehet meenutav välimus ja kerge tekstuur teevad sellest ideaalse maiuse kuumadel " +
                "suvepäevadel, olgu siis nautides seda omaette või koos kuhjaga vahukoorega lisandiks " +
                "indulgentsusele.",
                Ingredients = "14 plaatina kangust želatiinilehte\n3 tassi (750 ml) õuna- ja vaarika südamlikku kontsentraati\n250 g kooritud, neljaks lõigatud maasikaid, lisaks veel serveerimiseks\n50 g vaarikaid, mustikaid, murakaid ja kivideta kirsse, lisaks veel serveerimiseks\nVanillijäätis, serveerima",
                Recipe = "Leotage želatiinilehti keskmises kausis külmas vees 5 minutit, et need pehmeneksid.\n\nSuurde kannu ühendage südamlik ja 4 tassi (1L) vett. Valage 1 1/2 tassi (375 ml) väikesesse kastrulisse. Asetage kõrgele kuumusele, kuni see on kuum. Pigista želatiinist liigne vesi välja, lisa kastrulisse ja sega kuni sulamiseni. Lisage želatiinisegu kannu ja segage segu.\n\nValage kõik peale 300 ml želatiinisegu 23 cm läbimõõduga pannile. Tõsta ülejäänud 300 ml želatiinisegu kõrvale, kaetuna. Asetage pannile 2 1/2 tundi külmikusse, kuni tarretis on peaaegu tardunud, kuid siiski vedel (testige, surudes puuviljatüki õrnalt tarretisse; kui see ujub peal, pole tarretis piisavalt hangunud).\n\nKui tarretis on peaaegu tahenenud. seadke, lisage pannile puuviljad, surudes õrnalt tarretisse. Lameda põhja tagamiseks valage želatiinisegu peale. Hoidke 6 tundi või üleöö külmkapis.\n\nServeerimiseks täitke suur kauss kuuma (mitte keeva) veega ja kastke panni põhi 30 sekundiks vette. Asetage serveerimistaldrik panni põhjale ja keerake pann ettevaatlikult taldrikule ümber, lastes tarretisel välja libiseda. Hoidke serveerimiseks jahedas.\n\nServeerige koos lisamarjade ja jäätisega.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://images.squarespace-cdn.com/content/6057bede2adaca3d2461a22d/1629544997851-QNNF19CJXCGHN0S09SUH/summer+berry+jelly.jpg?format=1500w&content-type=image%2Fjpeg"
                }
            },

            new()
            {
                Name = " Kõrvitsa Alfredo",
                HeroImage = "pasta1.jpg",
                Description = "Kõrvitsa Alfredo on kreemine pastaroog, millel on hooajaline keerdkäik. See sisaldab sametist " +
                            "Alfredo kastet, mis on rikastatud kõrvitsapüreega, luues rikkaliku ja maitseküllase kastme koos " +
                            "sügisesete vürtside aroomidega. See lohutav roog sobib suurepäraselt pasta juurde ning pakub " +
                            "nauditavat kombinatsiooni kreemjast tekstuurist ja soolakast kõrvitsa maitselisest aroomist. " +
                            "Täiuslik hubaste sügisõhtute jaoks, see on maitsvaim viis hooaja maitsete tähistamiseks.",
                Ingredients = "1 nael fettuccini nuudleid, keedetud pakendijuhiste järgi\n8 supilusikatäit võid\n5–6 küüslauguküünt, peeneks hakitud või pressitud\n1 tass koort\n1 tass kõrvitsapüreed\n1,5–2 tassi värsket riivitud parmesani juustu\nkoššersoola maitse järgi",
                Recipe = "Pasta keetmise ajal sulata suurel pannil või. Lisa tükeldatud salvei ja küpseta kergelt segades 3-4 minutit, kuni või on helekuldpruun ja salvei mullitav. Kasutage lõhikuga lusikat ja laske võil pannile tilkuda ning seejärel asetage salvei paberrätikutele nõrguma. Tõsta kõrvale.\n\nLisage pannile küüslauk ja segage madalal kuumusel umbes 30 sekundit. Lisa kõrvits ja koor ning lase keema tõusta. Vahusta juust ja sega sulama. Kaste peaks paar minutit mullitama. Kui kaste tundub liiga paks, võid alati lisada rohkem koort (või veidi pastavett) ja kui kaste jääb mingil hetkel liiga lahjaks, siis lisa veidi rohkem kõrvitsat! See on väga paindlik. Maitse kastet ja lisa maitse järgi soola.\n\nNõruta nuudlid ja lisa koos kastmega pannile. Viska. Lisa soovi korral veel parmesani ja puista peale salvei.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://pinchofyum.com/wp-content/uploads/Edited-Pumpkin-Alfredo-Recipe.jpg"
                }
            },

            new()
            {
                Name = " Smash-burgerid",
                HeroImage = "smashburgers.jpg",
                Description = "Smash-burgerid on suussulav nauding, tuntud oma lihtsuse ja maitserikka löögiga. Need burgerid " +
                "valmistatakse, purustades hakklihakuuli kuumale grillpannile, mis annab krõbeda, " +
                "karamelliseeritud välispinna, samas säilitades seest mahlase ja õrna struktuuri. Õhuke pihv tagab " +
                "maksimaalse kokkupuute küpsetuspinnaga, luues maitsva koore, mis rõhutab hakkliha maitset. " +
                "Serveerituna pehmel kuklil koos klassikaliste lisanditega nagu lehtsalat, tomat, sibulad ja juust, " +
                "pakuvad smash-burgerid täiuslikku tasakaalu tekstuuride ja maitsete vahel, muutes nad " +
                "lemmikuks burgerisõprade seas kõikjal.",
                Ingredients = "1 nael 80/20 hakkliha\nsteigimaitseaine (või lihtsalt koššersool ja must pipar)\n4 viilu Ameerika juustu (nagu kraft-juustu)\n4 hamburgeri kuklit\nPraekaste/burgerimääre",
                Recipe = "Jagage veiseliha 4, 4 untsi pallideks. Ärge rullige ülimalt siledaks, vaid vormige jämedalt ümarad vormid.\n\nLõika või rebi 4 pärgamendi- või fooliumilehte umbes 5-tollisteks ruutudeks.\n\nValmista kõik burgerilisandid ja kuklid ning tõsta valmis kõrvale.\n\nKuumuta suur lameda ülaosaga grillpann või suur malmpann keskmisele kuumusele. Kui see on kuum, pintselda kergelt neutraalse õliga. Asetage pannile üks portsjon veiseliha korraga, asetage pärgamendiruut peale, asetage sellele tugev suur spaatliga ja vajutage kohe alla, surudes käega puhast spaatlit, purustades veiseliha õhukeseks, umbes 1/3 tolli paksuseks pätsiks.\n\nEemalda pärgament/foolium ja puista peale maitseaineid. Korrake ülejäänud burgeritega. Lase küpseda, kuni põhi ja servad on kuldpruunid, umbes 2-3 minutit. Pöörake burgerid, maitsestage ülejäänud pool ja lisage kohe juustuga. Küpseta veel umbes 1 minut.\n\nMääri kuklitele kaste, aseta valmis kuklitele keedetud burgerid ja serveeri.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://images.squarespace-cdn.com/content/v1/5e80e64f9327941b94517c20/1620874432492-S8B297TIPAUD9HL80NG7/Smash+Burger.jpg"
                }
            },

            new()
            {
                Name = " Apelsiniga Tai veiseliha vardad",
                HeroImage = "thaibeef.jpg",
                Description = "Apelsiniga Tai veiseliha vardad on ahvatlev maitsekombinatsioon, kus kohtuvad apelsini värskus " +
                "ja Tai köögi aromaatne vürtsikus. Õhukeselt viilutatud veiseliha marineeritakse elava segu sees, " +
                "mis koosneb apelsinimahlast, sojakastmest, küüslaugust, ingverist ja Tai tšillist, andes lihale " +
                "sügava maitsekihi. Need vardad keeratakse grillimiseks ja küpsetatakse täiuslikkuseni, kus liha " +
                "karamelliseerub ja omandab suitsuse maitse, jäädes siiski seespool mahlane ja õrn. Need vardad " +
                "pakuvad täiuslikku tasakaalu magusa, soolase ja vürtsika maitse vahel, muutes need " +
                "suurepäraseks eelroaks või pearoaks igasugusel üritusel.",
                Ingredients = "1 apelsin\n1/4 tassi sojakastet\n1/4 tassi maitsestatud riisiveini äädikat\n1 spl mett\n1 spl seesamiõli\n1 tl jahvatatud ingverit\n1 tl koriandrit\n4 küüslauguküünt\n2–4 tl Sriracha tšillikastet*\n1 1/2 naela küljepraad\nvardad (kui kasutate puitu/bambust, leotage neid enne kasutamist vähemalt 30 minutit vees)",
                Recipe = "Haara marinaadi jaoks kauss. Koorige apelsin ja lisage kogu koor kaussi. Seejärel lõika apelsin pooleks ja lisa ka kogu mahl. Teil peaks olema vähemalt 1/4 tassi apelsinimahla ja midagi enamat on lihtsalt hea.\nApelsinisegule lisa sojakaste, äädikas, mesi, seesamiõli, ingver, koriander ja küüslauk. Seejärel lisage oma maitse järgi Sriracha. Kui teile meeldib kuumus, alustaksin 3–4 teelusikatäie Srirachaga ja lisan soovi korral rohkem. Vahusta marinaad nii, et kõik seguneks.\nVõtke küljepraad ja lõigake see üle tera umbes 1/4-tollisteks viiludeks. Aitab praadida steik enne käsi umbes 20 minutiks sügavkülma. Asetage praad tõmblukuga kotti ja valage marinaad sisse. Loputage seda ümberringi ja asetage kott külmikusse. Parim on see, kui see suudab istuda vähemalt 4 tundi.\nKui olete valmis küpsetama, soojendage grill. Seejärel võtke vardad (kui kasutate puidust/bambusest neid eelnevalt leotatud) ja keerake liharibadele niidid, nagu õmblete. Sa ei taha, et nad oleksid seal liiga libedad. Et need ühtlaselt küpseksid, venita liha veidi välja.\nAsetage need grillile. Need küpsevad väga kiiresti. Mõlemal küljel peaks kuluma ainult umbes 3-4 minutit. Pöörake poolel teel.\nServeeri kohe – need jahtuvad kiiresti. Valmistage ülejäänud söök kindlasti valmis, enne kui need lauale jõuavad!",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://ourbestbites.com/wp-content/uploads/2009/05/OrangeThaiBeefSkewers.jpeg"
                }
            },

            new()
            {
                Name = " Lasanje rullid",
                HeroImage = "lasagnarollup.jpg",
                Description = "Lasanje rullid on lõbus keerdkäik klassikalisele Itaalia roale, pakkudes kõiki traditsioonilise lasanje " +
                            "maitseid individuaalsetes portsjonites. Selle asemel, et koostisosi kihtidena küpsetusnõusse " +
                            "laduda, keedetakse lasanje nuudlid, seejärel määritakse need ricotta juustuseguga, keeratakse " +
                            "rulli ning paigutatakse küpsetusnõusse. Seejärel ülevalatakse need rikkaliku marinara kastme ja " +
                            "mozzarella juustuga enne küpsetamist kuldpruuniks. Need rullid on mitte ainult visuaalselt " +
                            "atraktiivsed, vaid ka uskumatult maitsvad, pakkudes igas ampsus täiuslikku tasakaalu kreemja " +
                            "juustu, sügava kastme ja õrna pasta vahel. Ideaalne serveerimiseks üritustel või hubase " +
                            "pereõhtusöögi jaoks.",
                Ingredients = "Lasanje nuudlid\nRicotta\nMozzarella\nParmesan\nMuna\nMarinara kaste\nVeisehakkliha või vorst\nKüüslauk\nBasiilik",
                Recipe = "Alustuseks soojendage ahi temperatuurini 375 ° F. Aja suur pott vett keema ja küpseta lasanjenuudlid vastavalt pakendil olevatele juhistele. Soovite neid küpsetada, kuni need on al dente, nii et vähendage küpsetamisaega minut või paar.\nAsetage puhas köögirätik. Nõruta lasanjenuudlid ja laota need rätikule, et need ei kleepuks. Tõsta need kõrvale ja alusta täidisega.\nVõtke suur segamiskauss ja lisage ricotta juust, 1 tass mozzarella juustu, parmesan, muna, hakitud küüslauk, basiilik, kuivatatud pune, sool ja pipar. Kui otsustate liha lisada, küpseta, murenda ja nõruta jahvatatud liha enne selle täidisele lisamist. Sega kõik ühtlaseks massiks. Pange see kõrvale.\nHaara 9×13 ahjuvormi. Valage ahjuvormi 1 tass marinara kastet ja määrige see ühtlaselt põhjale.\nHaara lasanjenuudlid ja määri nuudli peale ühtlaselt umbes 2-3 supilusikatäit juustu segu. Rulli lasanjenuudlid ühest otsast teise alustades tihedalt kokku. Aseta kokkurullitud nuudliõmbluspool allapoole ahjuvormi. Korrake seda ülejäänud nuudlitega, kuni teie küpsetusnõu on täis.\nVala ülejäänud marinara kaste lasanjerullide peale ja aja ühtlaselt laiali. Puista peale ülejäänud ½ tassi mozzarellat, seejärel kata küpsetusvorm alumiiniumfooliumiga. Küpseta ahjus 25 minutit. Võtke anum välja ja eemaldage foolium. Tõsta see veel 5 minutiks ahju tagasi, kuni juust muutub kuldpruuniks ja hakkab mullitama. Lase roal enne värske basiilikuga kaunistamist mõni minut jahtuda ja serveeri!",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://thecozycook.com/wp-content/uploads/2022/03/Lasagna-Roll-Ups-f.jpg"
                }
            },

            new()
            {
                Name = "Orzo carbonara",
                HeroImage = "orzo.jpg",
                Description = "Orzo carbonara on võluv keerdkäik klassikalisele Itaalia pastaroale, carbonarale. Selle asemel, et " +
                            "kasutada traditsioonilist spagetti või fettuccinet, sisaldab see retsept orzo-pastat, mis on väike, " +
                            "riisitera-kujuline pasta. Orzo keedetakse al dente'ks ja seejärel segatakse kreemja kastmega, mis " +
                            "on valmistatud munadest, Parmesani juustust, krõbedast pancetast või peekonist ning mustast " +
                            "piprast. Tulemuseks on lohutav ja kreemine pastaroog rikkaliku suitsuse maitsega, mis kindlasti " +
                            "rahuldab igasuguse isu. Ideaalne kiireks ja maitsekaks õhtusöögiks nädala keskel.",
                Ingredients = "150 g orzo\n150 g kuubikuteks lõigatud pancettat\n1 keskmine vabapidamisel muna pluss üks munakollane\n60 g peeneks riivitud parmesani, lisaks veel serveerimiseks\nServeerimiseks värskelt jahvatatud musta pipart",
                Recipe = "Kuumuta pann tugevalt soolaga maitsestatud veega keema. Lisage orzo ja küpseta 10 minutit või kuni al dente (keedetud, kuid siiski veidi hammustada).\nVahepeal pane väike pann keskmisele kuumusele ja lisa pancetta. Küpseta umbes 5 minutit, aeg-ajalt segades, kuni see on krõbe ja kuldne. Kõrvale panema.\nLisa muna ja munakollane suurde kuumakindlasse kaussi, seejärel klopi hulka riivitud parmesan. Kui orzo on keedetud, jätke kruusitäis keeduvett ja nõrutage.\nKuumuta väike pann vett keema, seejärel pane munaseguga kauss peale (ära lase veel kaussi puutuda). Lisa kaussi pancetta ja kogu sulatatud rasv, seejärel orzo ja tilk pastavett. Alguses tundub segu märg, kuid segage pidevalt ja vedelik pakseneb läikivaks kastmeks, kattes orzo. Jaga kausside vahel, seejärel maitsesta rohke musta pipra ja viimase riiviga juustuga.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.halfbakedharvest.com/wp-content/uploads/2020/04/20-Minute-Orzo-Carbonara-with-Crispy-Prosciutto-and-Burrata-1.jpg"
                }
            },

            new()
            {
                Name = " Kreeka orzosalat (orzo-fetasalat)",
                HeroImage = "orzosalad.jpeg",
                Description = "Kreeka orzosalat, tuntud ka kui orzo-fetasalat, on värske ja maitsev roog, mis ühendab orzo pastat " +
                            "erinevate Vahemere-inspireeritud koostisosadega. Keedetud orzo segatakse tükeldatud kurkide, " +
                            "kirsstomatite, punaste sibulate, Kalamata oliivide ja murdunud feta juustuga, kõik maitsestatud" +
                            "värskendava vinegretiga, mis on valmistatud oliiviõlist, sidrunimahlast, küüslaugust ja " +
                            "maitsetaimedest nagu oregano ja petersell. Tulemuseks on särav ja värviline salat täiusliku " +
                            "tasakaaluga happeliste, soolaste ja värske maitse vahel. See on ideaalne lisand grillitud lihadele " +
                            "või kerge ja rahuldava pearoana omaette.",
                Ingredients = "3 spl oliiviõli\nveekeetja keeva veega\n300 g orzo (1 3/4 tassi)\n400 g kirsstomateid (14 untsi)\n1 väike punane sibul\n1 inglise kurk\n2 peotäit Kalamata oliive\n30 g värskeid basiiliku lehti (1 unts)\n15 g värsket tilli (1/2 untsi)\n3 spl ekstra neitsioliiviõli\n4 tl punase veini äädikat\n1 1/2 tl kuivatatud pune\n1 sidruni koor\nsoola maitse järgi\nmust pipar maitse järgi\n180 g kuubikuteks lõigatud fetat (6 untsi)",
                Recipe = "Selle maitsva kreeka orzo salati retsepti valmistamiseks alustage orzo pasta keetmisest. Keeda veekeetjas vesi. Samal ajal kuumuta suures potis keskmisel kõrgel kuumusel oliiviõli. Kui õli hakkab läikima, lisage orzo ja küpseta, segades sageli, kuni orzo hakkab värvuma. Täida pann keeva veega, sega juurde teelusikatäis soola ja küpseta orzo 10-12 minutit, kuni see on pehme ja al-dente.\nNõruta orzo ja loputa külma kraani all, kuni pastast välja voolav vesi on selge. Tõsta üleliigse vee ärajuhtimiseks kõrvale, aeg-ajalt segades, et pasta ei jääks üksteise külge.\nVahepeal veerandi kirsstomatid, koori ja haki peeneks sibul ja kurk ning veeranditeks oliivid.\nTõsta keedetud orzo suurde kaussi ja sega hulka salatiköögiviljad. Haki jämedalt värsked ürdid ja lisa ka need.\nKastme valmistamiseks sega väikeses kausis ekstra neitsioliiviõli, punase veini äädikas, kuivatatud pune, sidrunikoor ning ohtralt soola ja pipart. Sega see orzo segusse.\nLisage kuubikuteks lõigatud feta ja segage hoolikalt, et juustutükid liiga palju ei laguneks. Maitsesta vajadusel veel soola ja pipraga ning lase enne serveerimist umbes tund aega külmkapis seista, et orzo kaste imaks. Nautige!",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.cookingclassy.com/wp-content/uploads/2022/03/orzo-salad-33-500x375.jpg"
                }
            },

            new()
            {
                Name = " Kanatiivad mee ja küüslauguga",
                HeroImage = "wings.jpg",
                Description = "Kanatiivad mee ja küüslauguga on ahvatlev kombinatsioon magusatest ja soolastest maitsetest, mis " +
                            "rõõmustavad teie maitsemeeli. Need krõbedad kanatiivad on kaetud kleepuva mee-" +
                            "küüslaugukastmega, mis koosneb meest, sojakastmest, küüslaugust ja teistest vürtsidest. " +
                            "Tulemuseks on sõrmedele limpsimiseks roog, mis on täiuslik eelroaks, mängupäevadeks või igaks " +
                            "sündmuseks, kus soovite pakkuda maitsvaid ja sõltuvusttekitavaid maitseid. Kas serveeritud " +
                            "suupistena või pearoana, on need tiivad kindlasti rahva lemmikud.",
                Ingredients = "1,5–2 naela kanatiivad, mis on lõigatud trumliteks ja tiibadeks, mille ots on eemaldatud\n5 spl mee küüslaugu maitseainesegu\n1 spl hakitud küüslauku\n1/2 tassi mett\n2 tl sojakastet\nroheline sibul valikuline garneering\nseesamiseemned valikuline garneering",
                Recipe = "Eelsoojendage õhufritüür temperatuurini 400 ° F. Kuni see kuumeneb, patsutage tiibu paberrätikuga, kuni need kuivavad. Pintselda tiibu 1 sl sulavõiga, seejärel puista neile meeküüslaugumaitseainet. Hõõru maitseaine võimalikult hästi tiibadesse. Asetage need fritüüri, kuid ärge pange korvi kokku. Prae tiibu õhus 7-9 minutit mõlemalt poolt.\nKüpsemise ajal alustage glasuuriga. Lisa ülejäänud või kastrulisse ja sulata. Lisa võile hakitud küüslauk ja lase paar minutit podiseda, kuni küüslauk muutub lõhnavaks. Järgmisena lisage mesi ja sojakaste ning segage, kuni need on ühendatud. Laske sellel tasasel tulel paksenemiseks keeda, mis võtab aega 5–7 minutit. Sega aeg-ajalt.\nKui fritüür on valmis, võtke tiivad välja ja kontrollige, kas sisetemperatuur on jõudnud 165 °F-ni. Asetage valmis tiivad kastrulisse ja segage, kuni tiivad on ühtlaselt glasuuriga kaetud.\nAsetage kaetud tiivad minutiks või paariks õhufritüüri tagasi, kuni tiivad muutuvad kergelt krõbedaks ja külgedelt söestunud. Võtke need fritüürist välja ja kaunistage rohelise sibula ja seesamiseemnetega. Serveeri kuumalt ja naudi!",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://thesaltymarshmallow.com/wp-content/uploads/2021/01/honey-garlic-wings1.jpg"
                }
            },

            new()
            {
                Name = " Jõhvikakanaliha",
                HeroImage = "chicken.jpg",
                Description = "Jõhvikakanaliha on võluv roog, mis ühendab jõhvikate hapuka magususe soolase kanalihaga. " +
                            "Õrnad kanafileed või -reied valmistatakse maitsvas jõhvikakastmes, mis on valmistatud " +
                            "jõhvikamahlast, apelsinikoorest, meest ja aromaatsetest maitseainetest nagu kaneel ja nelk. " +
                            "Tulemuseks on suurepärane roog, millel on täiuslik tasakaal magusate ja soolaste maitsete vahel. " +
                            "See roog sobib suurepäraselt hubaseks õhtusöögiks kodus või eriliseks puhuks, pakkudes " +
                            "klassikaliste kanaroogade unikaalset pööret.",
                Ingredients = "8 untsi Catalina salatikastet\n1 pakk kuiva sibulasupi segu\n15 untsi purki terve marja jõhvikakaste\n3 naela kondita nahata kanareied",
                Recipe = "Sega suures kausis 1 tass Catalina kastet, 1 pakk kuiva sibulasupisegu, 1 purk jõhvikakastet. Reserveerige 1 tass segu hilisemaks kasutamiseks.\n\nLisa kanakintsud kastmega kaussi ja kata ühtlaselt.\n\nAsetage kanakintsud õhufritüüri korvi ühtlase kihina, ilma kattumiseta. Kui te ei soovi õhufritüüri korvi hiljem puhastada, võite kasutada pärgament- või silikoonvooderdust.\n\nKüpseta 400 kraadi juures 10 minutit, seejärel keera iga reied ümber. Määri igaüks veel kastmega ja küpseta veel 10 minutit või kuni sisetemperatuur jõuab 165 kraadini.\n\nKuni need toiduvalmistamise lõpetavad, saate reserveeritud kastme mikrolaineahjus või pliidiplaadil soojendada ja serveerida koos reiega lisakastmena.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.wellplated.com/wp-content/uploads/2015/11/Sticky-Cranberry-Chicken-Thighs.-The-whole-meal-cooks-in-one-pan-and-is-healthy-AND-delicious.-Winner-dinner.jpg"
                }
            },

            new()
            {
                Name = " Makaroni- ja juustupallid",
                HeroImage = "bites.jpg",
                Description = "Makaroni- ja juustupallid on lõbus ning maitsev pööre." +
                            "Need ampsusuurused hõrgutised sisaldavad kreemjat makaroni ja juustu, " +
                            "mis on kaetud leivaga ning küpsetatud või praetud kuldseks täiuslikkuseks. Iga amps on täidetud " +
                            "sulava juustu ja õrna pasta maitsetega, pakkudes rahuldavalt krõbedat välispinda ning kreemjat ja " +
                            "indulgentset sisemust. Ideaalne pidudeks, näksimiseks või isegi lisandina.",
                Ingredients = "4 tassi makaronid ja juust külmkapis mac ja juust on täiuslik\n2 muna\n2 spl piima\n1 kl panko leivapuru\n1/2 tassi hakitud parmesani juustu\n1 tl soola\n1/2 tl pipart\n1/2 tl küüslaugupulbrit\n1/2 tl sibulapulbrit",
                Recipe = "Kasutage ½-tollist küpsiselussi, võttes 4 tassi jahutatud maci ja juustu seest välja üksikud portsjonid. Rullige igaüks palliks. Asetage need suupisted küpsetuspaberi või silikoonmatiga kaetud alusele ja asetage need 30 minutiks sügavkülma.\n\nKlopi kausis lahti 2 muna ja 2 supilusikatäit piima. Pange see kõrvale.\n\nSegage eraldi kausis kokku 1 tass pankot, ½ tassi hakitud parmesani juustu, 1 tl soola, ½ tl pipart, ½ tl sibulapulbrit ja ½ tl küüslaugupulbrit.\n\nJärgmisena looge süvendusjaam. Aseta panko purusegu õhkfritüüri kõrvale. Aseta munasegu purusegu kõrvale. Kui suupisted on külmunud, asetage mac- ja juustuhammustuste kandik munasegu kõrvale.\n\nVõtke iga pallitaoline makaroniküngas, kastke see munasegusse, seejärel veeretage pankosegus ja asetage õhufritüüri ilma tunglemiseta. Olenevalt õhufritüüri suurusest peate võib-olla seda tegema partiidena. Sel juhul võiksid ülejäänud mac- ja juustuhammustused lihtsalt pärgamentpaberiga kaetud alusele jääda, kuni saate neid küpsetada.\n\nKüpseta 350 kraadi juures 10-15 minutit või kuni kuldpruun.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.southernliving.com/thmb/s7cN-ETQ2rHd4U_WUU53kfQMcSw=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/FriedMacandCheeseBites-30_preview_scale_100_ppi_150_quality_100-3f5853dcac754be1abcd36884ea887cc.jpg"
                }
            },

            new()
            {
                Name = " Fettuccine mereandidega",
                HeroImage = "mereannid.jpg",
                Description = "Kõrvitsa Alfredo on kreemine pastaroog, millel on hooajaline keerdkäik. See sisaldab sametist " +
                            "Alfredo kastet, mis on rikastatud kõrvitsapüreega, luues rikkaliku ja maitseküllase kastme koos " +
                            "sügisesete vürtside aroomidega. See lohutav roog sobib suurepäraselt pasta juurde ning pakub " +
                            "nauditavat kombinatsiooni kreemjast tekstuurist ja soolakast kõrvitsa maitselisest aroomist. " +
                            "Täiuslik hubaste sügisõhtute jaoks, see on maitsvaim viis hooaja maitsete tähistamiseks.",
                Ingredients = "1 (16 untsi) pakend kuivi fettuccine nuudleid\n1 ½ supilusikatäit võid või margariini\n1 tass hakitud rohelist sibulat\n4 küüslauguküünt, hakitud\n1 nael keskmised krevetid - kooritud ja tükeldatud\n1 nael merikammkarpe\n2 tassi poolteist koort\nsoola ja pipart maitse järgi\n1 tass värskelt riivitud parmesani juustu\n2 supilusikatäit maisitärklist (valikuline)",
                Recipe = "Täida suur pott kergelt soolaga maitsestatud veega ja kuumuta keemiseni. Keeda fettuccine'i keemiseni, kuni see on pehme, kuid hammustuse suhtes kõva, umbes 8 minutit.\n\nVahepeal sulatage või suurel mittenakkuval pannil keskmisel-kõrgel kuumusel. Segage roheline sibul ja küüslauk; küpseta 1 minut. Sega hulka krevetid ja kammkarbid; küpseta 3 minutit, seejärel alanda kuumust keskmiselt madalale.\n\nValage pooleks ja maitsestage soola ja pipraga; segage pidevalt ja laske keema tõusta, jälgides, et see ei keeks. Segage järk-järgult 1/2 tassi parmesani; küpseta ja sega veel 1 minut, seejärel eemalda tulelt.\n\nKurna pasta. Lisage pannile ja segage kastmega, kuni see on põhjalikult kaetud. Puista peale ülejäänud parmesan ja serveeri kohe.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://reluctantentertainer.com/wp-content/uploads/2022/08/best-Seafood-Fettuccine-Alfredo.jpeg"
                }
            },

            new()
            {
                Name = " Kanatekiila fettuccini ",
                HeroImage = "tekiila.jpg",
                Description = "Kanatekiila fettuccini on särav ja maitserikas pastaroog, mis ühendab pehme fettuccine " +
                            "pastavormi mahlaste kanatükkidega ning vürtsika tekiila-laimikastmega. Kana pruunistatakse " +
                            "kuldpruuniks ja seejärel hautatakse kastmes, mis on valmistatud tekiilast, laimimahlast, " +
                            "küüslaugust ja koorest, luues kreemja ja värskendava maitseprofiili. See roog on sageli " +
                            "kaunistatud värskete koriandrilehtede ja riivitud Parmesani juustuga, mis lisab sügavust maitsele. " +
                            "Iga amps on maitsvate kanatükkide, värskendava tsitruselise maitse ja kreemja kastme nauditav " +
                            "kombinatsioon, muutes selle ideaalseks valikuks meeldejääva eine jaoks.",
                Ingredients = "1 (16 untsi) pakend fettuccine pasta\n⅓ tassi hakitud värsket koriandrit\n2 spl hakitud küüslauku\n2 spl hakitud jalapeno paprikat\n3 supilusikatäit võid\n½ tassi kanapuljongit\n3 supilusikatäit tequilat\n2 spl värsket laimimahla\n3 spl sojakastet\n1 ¼ naela nahata kondita kana rinnapoolikud - kuubikuteks\n¼ punast sibulat, viilutatud\n1 punane paprika, õhukeselt viilutatud\n½ kollast paprikat, õhukeselt viilutatud\n½ rohelist paprikat, viilutatud\n1 ½ tassi rasket vahukoort",
                Recipe = "Prae keskmisel kuumusel koriandrit, küüslauku ja jalapeno pipart 2 sl võis või margariinis keskmisel kuumusel 4–5 minutit. Lisa puljong, tequila ja laimimahl. Kuumuta segu keemiseni ja keeda, kuni see on muutunud pastalaadseks. Kõrvale panema.\n\nVala kanale sojakaste ja jäta 5 minutiks kõrvale. Samal ajal prae keskmise suurusega pannil sibul ja punane, roheline ja kollane paprika ülejäänud supilusikatäis võis või margariinis, aeg-ajalt segades.\n\nSamal ajal küpseta fettuccini vastavalt pakendi juhistele.\n\nKui paprika on närbunud, lisa kana ja sojakaste. Viska ja lisa reserveeritud tequila/laimipasta ja koor. Kuumuta keemiseni. Hauta vaikselt, kuni kana on küps ja kaste on paks. Viska peale hästi nõrutatud fettuccini ja kaunista koriandriga. Serveeri.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://www.alilyloveaffair.com/wp-content/uploads/2020/02/Chicken-Tequila-Fettuccine-1-1-of-1.jpg"
                }
            },

            new()
            {
                Name = " Kodune lasanje",
                HeroImage = "homemadelasagne.jpg",
                Description = "Isetehtud lasanje on klassikaline Itaalia lohutustoit, mis koosneb pastakihtidest, rikkalikust " +
                            "tomatikastmest, maitserohkest lihast (näiteks hakklihast või vorstist), kreemjast ricotta juustust ja " +
                            "sulavast mozzarellast. Iga kiht pannakse hoolikalt kokku ja küpsetatakse kuldseks ja mullitavaks, " +
                            "tulemuseks on rammus ja rahuldustpakkuv eine, mis sobib suurepäraselt jagamiseks pere ja " +
                            "sõpradega. Oma lohutavate maitsete ja rikkaliku tekstuuri tõttu saab isetehtud lasanjest kindlasti " +
                            "igas kodus lemmikroog.",
                Ingredients = "Liha: see lasanje retsept algab kilo jahvatatud lihast (½ naela jahvatatud sealiha, ½ naela lahja veiseliha).\nSibul: kuubikuteks lõigatud sibulat küpsetatakse, kuni see muutub jahvatatud lihaga läbipaistvaks.\nKonserveeritud tomatid: vajate purki tomatikastet ja purki purustatud tomateid.\nVärsked ürdid: Värske maitse saamiseks haki kaks supilusikatäit peterselli ja purusta üks küüslauguküüs.\nSuhkur: tilk suhkrut tasakaalustab kogu tomatite happesuse.\nVürtsid ja maitseained: see omatehtud lasanje on maitsestatud kuivatatud basiiliku, kuivatatud pune, soola ja musta pipraga.\nNuudlid: Muidugi on sul vaja lasanje nuudleid! See retsept nõuab kuumtöötlemata nuudleid, kuid aja säästmiseks võite kasutada ahjuvalmis sorti.\nJuust: juustukiht koosneb kodujuustust ja parmesanist. Vaja läheb ka hakitud mozzarellat.\nMunad: munad muudavad juustukihi eriti kreemjaks. Lisaks toimivad need sideainena (mis tähendab, et nad hoiavad kihti koos).",
                Recipe = "Liha küpsetamine: Küpseta jahvatatud liha pannil, kuni see on pruunistunud ja murene. Lisage sibul ja jätkake küpsetamist, kuni see on läbipaistev. Sega hulka tomatikonservtooted, pool petersellist, küüslauk, basiilik, 1,5 tl soola, pune ja suhkur.\n\nKeeda nuudlid: Keeda lasanjenuudleid kergelt soolaga maitsestatud vees, kuni need on al dente.\n\nValmista juustukiht: Sega kausis kodujuust, parmesani juust, munad, ülejäänud petersell, ülejäänud sool ja pipar.\n\nPane lasanje kokku: Laota koostisained retsepti järgi kihiti (alustades kastmest ja lõpetades mozzarellaga), kuni lasanje on kokku pandud.\n\nLasanje küpsetamine: Kata fooliumiga ja küpseta eelkuumutatud ahjus umbes pool tundi. Eemalda foolium ja jätka küpsetamist, kuni pealt on kuldpruun.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://pinchofyum.com/wp-content/uploads/Edited-Pumpkin-Alfredo-Recipe.jpg"
                }
            },

            new()
            {
                Name = " Ameerika lasanje",
                HeroImage = "ameerikalasanja.jpg",
                Description = "Ameerika lasanje on rammus ja lohutav roog, mis koosneb lasanje pastakihtidest, maitsestatud " +
                            "hakklihast või vorstist, happelisest tomatikastmest, kreemjast ricotta juustust ja sulavast " +
                            "mozzarellast. Sageli sisaldab see ka täiendavaid koostisosi nagu sibulad, küüslauk ja ürdid, lisades " +
                            "maitset sügavust. Küpsetatakse kuni mullitavaks ja kuldseks, see roog on paljude Ameerika " +
                            "kodude lemmik lohutustoit, pakkudes igas ampsus rahuldustpakkuvat maitsete ja tekstuuride " +
                            "segu.",
                Ingredients = "1 ½ naela lahja veiseliha\n1 sibul, hakitud\n2 küüslauguküünt, hakitud\n1 (29 untsi) purk kuubikuteks lõigatud tomateid\n2 (6 untsi) purki tomatipastat\n2 spl pruuni suhkrut\n1 spl hakitud värsket basiilikut\n2 ½ tl soola, jagatud\n1 tl kuivatatud pune\n12 kuiva lasanje nuudlit\n1 pint rasvatu ricotta juustu\n½ tassi riivitud parmesani juustu\n2 suurt muna, lahtiklopitud\n2 spl kuivatatud peterselli\n1 nael mozzarella juustu, hakitud\n2 spl riivitud parmesani juustu",
                Recipe = "Koguge kõik koostisosad kokku.\nkõik koostisosad on kogutud Ameerika lasanje valmistamiseks.\n\nKüpseta ja sega jahvatatud veiseliha, sibulat ja küüslauku suurel pannil keskmisel kuumusel 5 minutit; tühjendage rasv.\nhakkliha, sibul ja küüslauk pannil küpsetamiseks.\n\nSegage kuubikuteks lõigatud tomatid, tomatipasta, pruun suhkur, basiilik, 1 1/2 teelusikatäit soola ja pune. Hauta lihakastet aeg-ajalt segades 30–45 minutit.\nkuubikuteks lõigatud tomatid, tomatipasta, pruun suhkur, basiilik, sool ja pune lisatakse pannile ja hautatakse.\n\nKuumuta ahi temperatuurini 375 kraadi F (190 kraadi C).\n\nSamal ajal lase keema suur pott kergelt soolaga maitsestatud vett. Keeda lasanjenuudleid keevas vees aeg-ajalt segades, kuni need on pehmed, kuid hammustada tugevad, umbes 8 minutit; äravool. Asetage nuudlid rätikutele tasaseks; kuivatada.\nnuudlid keedetakse pehmeks, kuid tugevaks, seejärel asetatakse rätikule kuivama.\n\n\nSega keskmises kausis kokku ricotta, 1/2 tassi parmesani juustu, munad, petersell ja ülejäänud 1 tl soola.\nricotta, parmesan, munad, petersell ja sool segada kausis kokku.\n\n\nLaota 1/3 nuudlitest 9x13-tollise ahjuvormi põhja. Kata 1/2 ricotta seguga.\n1/3 küpsetusnõusse asetatud nodidest, peale 1/2 ricotta segust.\n\n\nKata ricotta segu 1/2 mozzarella juustu ja 1/3 lihakastmega.\n1/2 mozzarella juustu ja 1/3 lihakastet kihiti ricotta segule.\n\nKorda. Tõsta peale ülejäänud nuudlid ja lihakaste. Puista peale 2 spl parmesani juustu.\npeale asetatud ülejäänud nuudlid ja lihakaste ning peale parmesani juust.\n\nKüpseta eelkuumutatud ahjus 30 minutit. Enne serveerimist lase 10 minutit seista.\nlasanje küpsetamine ahjus valmis.\n\nNautige!",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://recipes.net/wp-content/uploads/2023/07/american-lasagna_def3a9431f11c8d03abee0b6d9662a64.jpeg"
                }
            },

            new()
            {
                Name = " Rigatoni salajase kastmega on pastaroog",
                HeroImage = "rigatoni.jpg",
                Description = "Rigatoni al Segreto ehk Rigatoni salajase kastmega on pastaroog, mis pakub varjatud üllatusi.  " +
                            "Sellel on rikkalik ja maitsva kastme retsept, mille koostisosad on hästi hoitud saladus. Rigatoni " +
                            "pasta segatakse selle salapärase kastmega, luues maitseelamuse, mis paneb teid naasma roogi " +
                            "avastama. See on salapärane ja maitserohke roog, mis rõõmustab igat gurmaani.",
                Ingredients = "4 supilusikatäit oliiviõli\n1 tass tükeldatud sibulat\n1 tl soola, pluss rohkem maitse järgi\n2 küüslauguküünt, purustatud (või rohkem maitse järgi)\n1 näputäis punase pipra helbeid\n1 (28 untsi) purk San Marzano (Itaalia) tomatid, segatud ühtlaseks\n½ tassi vett (tomatipurgi loputamiseks)\n1 (8 untsi) pakend kuumtöötlemata rigatoni pasta\n½ tassi värskeid basiiliku lehti, õhukeselt viilutatud\n4 spl külma võid, kuubikuteks\n1 tass riivitud Parmigiano-Reggiano juustu, lisaks veel serveerimiseks",
                Recipe = "Kuumuta oliiviõli kastrulis keskmisel-kõrgel kuumusel. Lisa sibul ja sool. Küpseta, kuni see ei ole enam valge ja hakkab muutuma läbipaistvaks, umbes 5 minutit. Sega küüslauk; küpseta umbes 1 minut. Lisa punase pipra helbed, seejärel veega segatud tomatid. Lase keema tõusta; reguleerige kuumust keskmisele või keskmisele madalale. Hauta vaikselt aeg-ajalt segades 45–60 minutit. Vähendage kuumust madalaks.\n\nAja suur pott kergelt soolaga maitsestatud vett keema. Keeda rigatoni keevas vees, aeg-ajalt segades, kuni need on pehmed, kuid hammustada tugevad, umbes 8 minutit (5 minutit pärast valmimist).\n\nLisa kastmele umbes 2/3 basiilikut. Sega juurde või. Kui või sulab, lisa juustu 3 kaupa.\n\nKurna pasta; üle kastmesse. Sega, kuni rigatoni on ühtlaselt kastmega kaetud. Serveeri ülejäänud basiilikuga ja riivjuustuga üle puistatuna.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://img.freepik.com/premium-photo/rigatoni-al-segreto-rigatoni-with-secret-sauce-italian-recipe_198067-166364.jpg"
                }
            },

            new()
            {
                Name = " Fettuccine Carbonara",
                HeroImage = "pasta2.jpg",
                Description = "Fettuccine Carbonara on klassikaline Itaalia pastaroog, mis on tuntud oma lihtsuse ja rikkalike " +
                            "maitsete poolest. See koosneb õrnadest fettuccine nuudlitest, mis on kaetud kreemja kastmega, " +
                            "valmistatud munadest, riivitud Parmesani juustust, krõbedast pancetast või peekonist ning " +
                            "värskest mustast piprast. Pasta soojus küpsetab munad, luues siidise kastme, mis kleepub iga " +
                            "nuudlikeere külge. Tulemuseks on dekadentne ja rahuldustpakkuv roog, mis tasakaalustab " +
                            "täiuslikult kastme kreemja rikkuse krõbeda panceta soolase krõmpsuga. Fettuccine Carbonara on " +
                            "ajatu lemmik, mis alati vaimustab.",
                Ingredients = "5 tl oliiviõli\n4 šalottsibulat, tükeldatud\n1 kilo peekonit, lõigatud ribadeks\n1 suur sibul, lõigatud õhukesteks ribadeks\n1 küüslauguküüs, hakitud\n1 (16 untsi) pakend kuiva fettuccine pasta\n¾ tassi hakitud parmesani juustu\n½ tassi rasket koort\n3 munakollast\nsoola ja pipart maitse järgi",
                Recipe = "Kuumuta suures paksus potis keskmisel kuumusel oliiviõli. Prae šalottsibulat pehmeks. Sega peekon ja sibul; küpseta ja sega, kuni peekon on ühtlaselt pruunistunud. Sega sisse küüslauk, kui peekon on umbes pooleldi valmis. Eemaldage kuumusest.\n\nAja suur pott kergelt soolaga maitsestatud vett keema. Lisa pasta ja küpseta 8–10 minutit või kuni al dente. Nõruta pasta, seejärel pane potti tagasi.\n\nVahusta parmesan, koor ja munakollased keskmises kausis. Vala peekonisegu pastale; sega hulka kooresegu. Maitsesta soola ja pipraga.",
                AccentColorStart = Color.FromArgb("Black"),
                AccentColorEnd = Color.FromArgb("Black"),
                Images = new()
                {
                    "https://myfoodbook.com.au/sites/default/files/styles/schema_img/public/recipe_photo/Kitc20153598_0.jpg"
                }
            },
    };

        public static List<Food> GetSaltyFood()
        {
            var random = new Random();
            var randomFoods = foods.OrderBy(item => random.Next());

            return randomFoods.Take(2).ToList();
        }

        public static List<Food> GetDesserts()
            => foods;
    }
}
