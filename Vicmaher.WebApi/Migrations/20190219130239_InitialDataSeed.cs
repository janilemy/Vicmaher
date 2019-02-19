using Microsoft.EntityFrameworkCore.Migrations;

namespace Vicmaher.WebApi.Migrations
{
    public partial class InitialDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "Title" },
                values: new object[,]
                {
                    { 1, true, "Albanci" },
                    { 23, true, "Politiki" },
                    { 24, true, "Prekmurci" },
                    { 25, true, "Primorci" },
                    { 26, true, "Računalniški" },
                    { 27, true, "Seks" },
                    { 28, true, "Slovenci" },
                    { 29, true, "Službeni" },
                    { 30, true, "SMS" },
                    { 31, true, "Svet" },
                    { 32, true, "Šolski" },
                    { 33, true, "Štajerci" },
                    { 34, true, "Tašča" },
                    { 36, true, "Vojaški" },
                    { 37, true, "Zakonski" },
                    { 39, true, "Zdravniki" },
                    { 40, true, "Ženske" },
                    { 41, true, "Živali" },
                    { 42, true, "Župnik" },
                    { 43, true, "Ostalo" },
                    { 22, true, "Policijski" },
                    { 47, true, "Sosedi" },
                    { 21, true, "Pijančki" },
                    { 19, true, "Murphyevi Zakoni" },
                    { 2, true, "Avtomobili" },
                    { 3, true, "Balkanski" },
                    { 4, true, "Blondinke" },
                    { 5, true, "Cerkveni" },
                    { 6, true, "Chuck Norris" },
                    { 7, true, "Cigani" },
                    { 8, true, "Črnci" },
                    { 9, true, "Črni Humor" },
                    { 38, true, "Črnogorski" },
                    { 10, true, "Dolenjci" },
                    { 11, true, "Družinski" },
                    { 12, true, "Gorenjci" },
                    { 13, true, "Gostinski" },
                    { 14, true, "Hrvati" },
                    { 15, true, "Janezek" },
                    { 16, true, "Korošci" },
                    { 35, true, "Lovski" },
                    { 17, true, "Moški" },
                    { 18, true, "Mujo in Haso" },
                    { 20, true, "Notranjci" },
                    { 48, true, "Odvetniki" }
                });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "Id", "Active", "CategoryId", "Description", "Title" },
                values: new object[,]
                {
                    { 275, true, 1, "Albanski veleposlanik pride k slovenskemu in reče: \"Prijatelj, daj nekaj ukreni, da nas ne bodo Srbi v Kosovu čisto potolkli.\"    Slovenec: \"Nimam zdaj časa. Imam druge skrbi.\"      Albanec: \"Če ne boš nič ukrenil, bom vse naše strokovnjake potegnil iz Slovenije nazaj v Albanijo!\"    Slovenec: \"Pa boli mene, jaz takaltak nimam rad sladoleda!\" ", "Albanski in slovenski veleposlanik" },
                    { 1896, true, 39, "\"Ni vam treba tako na široko odpirati ust,\" reče zobozdravnik pacientu.    \"Ali ne boste vrtali?\"    \"Bom, a jaz bom ostal zunaj!\"", "Pri zobozdravniku" },
                    { 1869, true, 39, "Pacientka potarna zdravnici: \"Gospa zdravnica, moj mož želi ves dan intenzivno seksati. Kaj mu naj dam?\"    Zdravnica: \"Mojo telefonsko številko.\"", "Nenehno bi seksal" },
                    { 1809, true, 39, "Sestra v ambulanti kliče bolnike: \"Medved, Čuk, Volk, Jazbec…\"    Eden od pacientov se oglasi: \"Sestra, kdaj bomo pa ljudje prišli na vrsto?\" ", "V čakalnici" },
                    { 1798, true, 39, "Bjim se, pravi kirurg, da bo  potrebna operacija srcne zaklopke.  Pacientka se nervozno presede   na stolu.  Zelela bi se drugo mnenje.  Seveda, gospa.  Tudi predebeli ste gospa.", "Drugo mnenje" },
                    { 1792, true, 39, "Zakonski par je obiskal zdravnika.    Žena je bila noseča in želela sta se pozanimati, v katerem položaju lahko seksata.    \"V prvi tretjini nosečnosti lahko seksata čisto normalno!\" je rekel doktor.    V drugi tretjini nosečnosti seksajta v pasjem položaju, v zadnji tretjini pa naj mož zavzame volčji položaj.\"    \"Volčji položaj?\" sta se začudila.    \"Ja, mož naj se uleže pred luknjo in tuli!\" ", "Seks pri nosečnici" },
                    { 1791, true, 39, "\"Doktor, ali se da ozdraviti mojo nespečnost?\" je vprašal pacient.    \"Ni problem! Samo tisto zlobo, ki vas ne pusti spati, morava odstraniti!\"    \"Ne, to pa ne! Moja žena je preveč navezana na najinega novorojenčka!\"", "Ne more spati" },
                    { 1782, true, 39, "\"Gospod doktor, kaj naj storim? Kar naprej me boli glava.\"    \"Gospa, spremembo potrebujete!\"    \"Sem že poskušala, a je mož preveč ljubosumen.\" ", "Nenehni glavoboli" },
                    { 1768, true, 39, "Zdravnik pregleda pacienta in reče: \"Vaš srčni utrip je zelo počasen.\" \"Saj se mi nikamor ne mudi,\" odvrne pacient.", "Pulz" },
                    { 1758, true, 39, "V ordenacijo prizvizga pacient  in rece psihiatru:  Doktor, mislim, da sem ptic!  Kar odletite nazaj v cakalnico,   jaz pa bom poklical v bolnisnico,   da vam pripravijo gnezdo.", "Gnezdo" },
                    { 1754, true, 39, "\"Doktor, zakaj ste pa danes tako žalosten?\" vpraša sestra.    \"Ah, Sonja, umrl je gospod Koren, ki sem ga zdravil.\"    \"Ne jemljite si tega tako k srcu. Morda bi umrl tudi brez vašega zdravljenja.\" ", "Žalosten dan" },
                    { 1740, true, 39, "Mladi par se odloči imeti otroka. Poizkušata mesec, dva, pol leta....nič. Ni uspelo. Se odločita, da gresta do zdravnika po strokovno pomoč. Vse razložita, opišeta trud, na dolgo in široko. Doktor ponižno posluša, potem pa le spregovori: ''Fanta, a je to kakšna zajebancija?????'", "Mlad par" },
                    { 1738, true, 39, "Starejši pacient potrka na vrata okulistove ordinacije. Odpre mu medicinska sestra in zavpije nanj: \"Kaj ne vidite napisa, da je trkanje prepovedano!?\"    \"Ne, ne vidim. Zato sem pa tukaj.\" ", "Pri okulistu" },
                    { 1718, true, 39, "\"Gospod doktor, muči me zelo težko dihanje.\"    Zdravnik: \"Dobro, bomo poskušali tudi to zaustaviti.\"", "Težko dihanje" },
                    { 1687, true, 39, "Zdravnik po telefonu: \"Dragi pacient, za vas imam slabo novico in še eno hujšo!\"    Pacient začudeno: \"No, kaj je potem slaba novica?\"    Zdravnik: \"Ostal vam je samo še en dan življenja!\"    Pacient: \"Slabše res ne more biti. Kaj naj bi bila potem še hujša novica?\"    Doktor: \"Že od včeraj sem vas poskušal doklicati.\"", "Slabo in še slabše" },
                    { 1680, true, 39, "Ženska v poznih srednjih letih je vstopila v ordinacijo svojega ginekologa in kar takoj rekla: \"Prosim, da mi napišete recept za kontracepcijske tablete proti glavobolu!\"    \"Kako?\" se je zmedel doktor. \"Kontracepcijske tablete proti glavobolu? Sem prav slišal?\"    \"Ja, veste, moja hčerka vsak večer hodi ven in se vrača zjutraj domov. Če ji dam pred odhodom v sok kontracepcijsko tabletko, potem me ponoči ne boli glava.\"", "Kontracepcijska proti glavobolu" },
                    { 1605, true, 39, "Zelo debela ženska je vstopila v ordinacijo in doktorju potožila: \"Mislim, da me mučijo hemoroidi!\"    \"Prosim, spustite en kratek prdec!\"    \"Kaj? Ali to sodi k diagnozi?\"    \"Ne, sodi k orientaciji!\"", "Debeluška ima težave" },
                    { 1575, true, 39, "Predebela gospa je pri zdravniku in ta ji daje napotke za hujšanje.    Ona ga vpraša: \"Sem pa slišala, da pri hujšanju dosti pomaga olivno olje. Kako je s tem?\"    Zdravnik: \"Pomaga o ja, pomaga...\"    Ona: \"In kako se uporablja?\"    Zdravnik: \"Najbolj pomaga, če z njim na debelo namažete tla okoli hladilnika!\"", "Nasvet za hujšanje" },
                    { 1549, true, 39, "K zdravniku prideta mlada, postavna, gospodična in njena debela mama.    Zdravnik: \"Gospodična slecite se, prosim.\"    Mama: \"Gospod doktor, to je pomota. Prišli smo zaradi mene.\"    Zdravnik: \"Dobro. Odprite usta in pokažite grlo.\"", "Obiskale sta zdravnika" },
                    { 1548, true, 39, "Po operaciji povečanja prsi se pogovarjata zdravnik in pacientka.    Zdravnik: \"Ali so vam všeč vaše nove prsi?\"    Pacientka: \"Da, zelo! Ampak, rada bi še en poseg.\"    Zdravnik: \"Kakšen poseg?\"    Pacientka: \"Rada bi imela večje oči.\"    Zdravnik: \"To lahko takoj uredimo. Sestra, prinesite naši pacientki račun.\"", "Povečala si je prsi" },
                    { 1511, true, 39, "Moški je vstopil v doktorjevo ordinacijo in v zadregi dejal: \"Doktor, kožice mojega spolnega uda ne dobim nazaj!\"    \"Kožice se pa vendar ne posoja!\" ", "Ima težavo" },
                    { 1491, true, 39, "Bliža se večer in nekega moškega zabodejo z nožem v hrbet.    Pride k zdravniku in ta mu reče: \"Mi delamo samo do sedmih,\" vzame nož, mu ga zapiči v oko in doda še: \"Okulist dela do osmih.\"", "Nima sreče" },
                    { 1427, true, 39, "\"In kaj ste danes, gospod Lojze?\" je psihiater vprašal pacienta v psihiatrični bolnišnici.    \"Kardinal!\"    \"In kdo vas je imenoval na ta položaj?\"    \"Papež osebno!\" je ponosno dejal.    V ozadju je stal drugi pacient, ki se je oglasil: \"Laže! Tega moškega sploh ne poznam!\" ", "V psihiatrični bolnišnici" },
                    { 1419, true, 39, "Gospod doktor, kasljam in  tezko diham...  Kadite?  Kadim, pa ne pomaga!", "Nesporazum" },
                    { 1250, true, 39, "Kmet: \"S postelje sem padel pri divjem seksu z deklo in sl zlomil roko.\"    Zdravnik: \"No no, tole pa povejte malo bolj lepo. Bo v kartoteki.\"     Kmet: \"V redu! Pri polaganju semena v brazdo sem padel z delovnega stroja!\"", "Kmet pri zdravniku" },
                    { 1245, true, 39, "Zdravnik: \"Ali se držite mojih navodil nove tabletki zjutraj, pri kosilu pa kozarček rdečega?\"    Pacient: \"še kar! S tabletami sem v zaostanku, pri rdečem pa prehitevam za dva tedna, pa se zgliha!\" ", "Pri zdravniku" },
                    { 1241, true, 39, "Pogovarjata se dva kirurga.    Prvi: \"Teoretično pacient Mihec sploh ne bi smel preživeti operacije.\"    Drugi: \"Vidite, kolega. Proti močni volji do življenja je še moderna medicina nemočna.\"", "Pogovor dveh kirurgov" },
                    { 1195, true, 39, "Na zdravniskem pregledu zdravnik  ocita Korelu:  Kar naravnost vam bom povedal.  Navadni pijanec ste. Ali se   zavedate, da zaradi pijace vsako  leto umre 5000 Slovencev?  Korel: Briga me! Jaz sem itak  Stajerc.", "Jaz sem Stajerc" },
                    { 1166, true, 39, "Oce zdravnik rece hcerki:  Si povedala svojemu fantu, da  se mi zdi, da ni pravi zate?  Sem, ocka.  In kaj je rekel?  Da to ni tvoja prva napacna  diagnoza...", "Napacna diagnoza" },
                    { 1165, true, 39, "Dedek pride v bolnisnico in  zdravnik ga vprasa:  Ata, kako naj vas zdravimo?  Ce lahko izbiram, potem me dajte  tako, da bo pogreb v nedeljo...", "V nedeljo" },
                    { 1912, true, 39, "Zdravnik: \"Za vas imam slabo novico.\"    Jože: \"Kaj je, gospod zdravnik?\"    Zdravnik: \"Morali boste prenehati mastrubirati.\"    Jože: \"O Bog, zakaj?\"    Zdravnik: \"Zato, ker se pogovarjam z vami!\" ", "Hudiča no, Jože" },
                    { 1162, true, 39, "Po uspesno opravljeni lepotni  operaciji vprasa kirurg Mojco:  No, kako ste zadovoljni s svojimi  novimi prsmi?  So dovolj velike?  Mojca: Super je. A rada bi imela  tudi vecje oci.   Zdravnik: Ni problema, takoj uredimo.  Sestra, prinesite racun.", "Vecje oci" },
                    { 1928, true, 39, "\"Gospod doktor, potreboval bi potrdilo, da ne morem delati!\"    \"In kaj vam manjka?\"    \"To potrdilo.\"", "Potrdilo" },
                    { 1945, true, 39, "\"Imate v vaši družini kakšen primer duševne bolezni?\" vpraša zdravnik.    \"Da, imamo,\" reče pacientka. \"Mož si domišlja, da je gospodar v hiši!\"", "Duševne motnje" },
                    { 285, true, 40, "Prijateljici se pogovarjata:\"Na morju sem se imela čudovito!\"    \"Res?\"    \"Res! Kar tridesetim moškim sem morala reči ne.\"    \"Kaj so ti pa prodajali?\"", "Pogovor o dopustu" },
                    { 278, true, 40, "\"Slišim, da imaš novo dekle. Kako se kaj obnese?\"    \"Zelo samozavestna je. Na prvi zmenek je prišla kar v poročni obleki.\"", "Novo dekle" },
                    { 269, true, 40, "Zakaj gre vedno več žensk skupaj na WC?    Da se ne ve, katera je srala.", "WC" },
                    { 241, true, 40, "Kaj pomeni, če ženska pride iz kuhinje v dnevno sobo?    Da ima predolgo verigo.", "Ženska v dnevni sobi" },
                    { 240, true, 40, "Avto, na prehodu za pešče povozi žensko.    Kdo je kriv?    Ženska je kriva, zakaj je pa šla stran od štedilnika!", "Žensko povozi avto" },
                    { 239, true, 40, "Zakaj si morajo ženske redno striči nohte na nogah?    Zato, da lahko stojijo čim bližje štedilniku.", "Ženske in striženje nohtov" },
                    { 238, true, 40, "Zakaj se nobena ženska nad tridesetim letom noče igrati skrivalnic?    Ker jih nihče ne bi iskal!", "Ženske nad 30" },
                    { 214, true, 40, "Zvečer se v postelji mož strastno privije k ženi: \"Brez hlačk sem...\"    Ona, napol v spanju: \"Pusti me spat. Zjutraj ti bom ene oprala.\" ", "Zaspana žena v postelji" },
                    { 213, true, 40, "Zakonca, oba pri štiridesetih, se pogovarjata v spalnici. Ona si ogleduje svoje prsi.  Mož: \"Kaj se pa tako ogleduješ?\"  Žena: \"Včeraj sem bila pri zdravniku in je rekel, da imam joške kot 25-letnica.\"  Mož: \"Kaj pa je rekel za tvojo 40-letno rit?\"  Žena: \"Nič! Tebe sploh ni omenjal!\"", "Mož in žena, pogovor" },
                    { 212, true, 40, "Kakšnaj e podobnost med žensko in orkanom?    Ko pridejo, so divje in vlažne, ko gredo, ti pa odnesejo hišo in avto.", "Podobnost med žensko in orkanom?" },
                    { 203, true, 40, "Lepotica je v restavraciji pristopila k bradatemu natakarju in mu rekla, da mu želi nekaj šepniti v uho.    Natakar je privolil, lepotica pa mu je s prstom začela ovijati brado in se igrati z njo ter rekla:  \"Ste vi tukaj šef?\" in še naprej z prsti šarila po bradi.    \"Ne, jaz nisem šef!\" je rekel natakar.    \"Ali ga lahko pokličete?\" je vprašala lepotica in mu prste, enega za drugim vtikala v usta.    \"Ne, ne morem ga poklicati, ker ga danes sploh ni tu!\"    \"Toda, jaz ga potrebujem, ker mu moram nekaj sporočiti!\" je rekla lepotica in spet s prsti ovijala natakarjevo brado.    \"Saj lahko meni pustite sporočilo!\" je rekel natakar.    \"No, prav, pa mu povejte, da v stranišču ni WC papirja, voda pa tudi ne teče!\"", "Lepotica v restavraciji flirta" },
                    { 169, true, 40, "Pri 8 -- Neseš jo v posteljico in ji poveš zgodbico.    Pri 18 -- Poveš ji zgodbico, da jo spraviš v posteljo    Pri 28 -- Ne rabiš ji več povedati zgodbice, da jo spraviš v posteljo    Pri 38 -- Ona tebi pove zgodbico, da te spravi v posteljo    Pri 48 -- Ona ti pove zgodbico, da ji ni treba s tabo v posteljo    Pri 58 -- Ostaneš v postelji, da se izogneš njenim zgodbicam     Pri 68 -- Če jo spraviš v posteljo - to bi bila zgodbica!!!    Pri 78 -- Kakšna zgodbica? Kakšna postelja? Kdo si ti???", "Razlika med ženskami" },
                    { 153, true, 40, "Zbudila sem se.  Se hitro umila, pomolzla krave, nahranila kure in zajce, koze spustila na pašo. Zbudila otroke, pripravila zajtrk, jih odpeljala v šolo in pokosila travo.  Šla v službo, se sprla s šefom in ga vrgla iz pisarne. Obračunala potne naloge, služila podjetju, dobila plačo. Doma nasekala drv, pripravila kosilo, šla po otroke in jih nahranila, okopala vrt, tekla k frizerki.  Potem vkup zgnala živino, pokidala in nastlala, dala krmo, podaljšala avto zavarovanje. Otroke dala spat, oprala stroj cunj, prek neta plačala račune, obesila cunje, vrgla vase kruh z maslom.  Ko sem se pripravljala k spanju, sem se spomnila- GROZA!!!    Mož leži že cel dan na kavču, BREZ SEKSA!", "Dnevnik idealne ženske" },
                    { 116, true, 40, "V hribovski vasici, bogu za hrbtom, je živela mlada punca Francka.  Nekega jutra se zbudi in med nogami začuti močno ščemenje, ki ni in ni  nehalo.  Po parih dnevih se odpravi vprašat župnika za nasvet, kako naj se reši  tega ščemenja.  \"Veš, to ti je muha noter zlezla in zdaj ne more ven, zato te tako srbi.  Vem kakšna je rešitev, a ti žal ne smem pomagat, ker sem župnik?\"  Francka žalostna zapusti cerkev.  Na polju vidi soseda Poldeta, kako v potu svojega znoja, okopava krompir.  Pove mu vse glede muhe in ga zaprosi za pomoč,  Polde pa: \"Jaz bi ti že rade volje pomagal, a sem žal prestar za kaj  takega..\"  Nato pride do pašnika, kjer je pasel krave mlad postaven pastir.  Ko mu zaupa svoj problem in ga zaprosi za pomoč, se pastir veselo nasmehne  in ji reče, naj sleče obleko.  Francka jo sleče.  Modrček je kar pokal od napetih prsi, gate pa so bolj odkrivale kot  skrivale, njeno mednožje.  Potem ji pastir reče naj sleče še to dvoje, se uleže predenj in da noge  narazen.  Francka ga brez obotavljanja uboga.  Nato tudi pastir sleče svoje hlače pa gate, počepne pred Francko in se  poserje:  \"Če to ne bo zvabilo muhe ven, potem pa res ne vem kako še pomagat?.", "V hribovski vasici" },
                    { 114, true, 40, "Kaj pravijo različne ženske v postelji:    Astmatičarka: \"Uhh... uhhh...uhhh...\"  Matematičarka: \"Ponovi... ponovi...\"  Veterinarka: \"Daj me, bikec moj, daj me...\"  Učiteljica: \"Da...tako...zelo dobro...pravilno...odlicno!\"  Morilka: \"Če zdaj nehaš, te ubijem!\"  Navijacica: \"Vzdrzi...dajmo...se...\"  Neobveščena: \"Kaj je to?...zakaj?...kaj počnes?\"  Optimistka: \"Da...da...da...\"  Pesimistka: \"Ne...ne...ne...\"  Prometni tehnik: \"Bolj na desno...ne, ne...malo navzgor...naprej...\"  Versko blazna : \"O moj bog...o moj bog...\"  Samomorilska: \"Joj, umiram...joj, umiram...\"  Skrbnica racunalnikov: \"OK...OK...OK...\"  Uciteljica angleščine: \"Ohhh, yes...ohhh, God...\"  Vedeževalka: \"čutim da prihaja...blizu je...tu je...umpfgrrr!!!\"  Merkatorjevka: \"Ti si moj najboljsi sosed!\"", "Ženske v postelji" },
                    { 113, true, 40, "Zelo luštna študentka na izpitu:  \"Gospod profesor, jaz bi naredila VSE, da bi naredila ta izpit.\".    Profesor: \"Čisto vse?\".    Študentka: \"Da, res čisto vse.\"    Profesor: \"Ste prepričana?\"    Študentka: \"Da, prepričana, res, res vse.\"    Profesor: \"Kaj počnete v petek zvečer?\".    Študentka: \"Nič.\".    Profesor: \"Kaj, če bi se malo učili...\"", "Vse bi dala ..." },
                    { 42, true, 40, "Kakšna je razlika med pralnim strojem in devico?    Pralni stroj ne lazi za tabo še 14 dni potem ko ga nafilaš.", "Razlika med pralnim strojem in devico" },
                    { 2111, true, 39, "Doktor reče pacientu: \"Vas pa že dolgo nisem videl!\"  Pacient: \"Nekaj sem bil bolan.\"", "Obisk pri zdravniku" },
                    { 2106, true, 39, "Zdravniku sem rekel, da sem si roko zlomil na dveh mestih.    Rekel mi je, naj neham hoditi na ti dve mesti.", "Dober nasvet" },
                    { 2105, true, 39, "Jože je med obiranjem češenj padel z drevesa.    Ko pride k zdravniku, ga ta vpraša: \"Ste takrat, ko ste padli z drevesa, padli v nezavest?\"    \"Ne. V koprive!\"", "Ob padcu iz drevesa" },
                    { 2066, true, 39, "\"So ribe zdrave?\" vpraša pacient zdravnika.    Zdravnik: \"Mislim, da so, saj še nobene nisem zdravil.\"", "Ali so ribe zdrave" },
                    { 2061, true, 39, "Zdravnik pove pacientu: \"Takoj morate nehati zapeljevati žene drugih moških, sicer ne boste več dolgo živeli.\"    \"Ampak kako, moje zdravje je odlično, ženske pa so nore na mene.\"    \"Ravno v tem je problem! Ena od njih je tudi moja!\"", "Pameten nasvet" },
                    { 2054, true, 39, "Pacient pride k psihiatru in mu reče: \"Prosim vas, rešite me.\"    \"Kaj pa vam je?\"    \"Daje me grozen občutek.    \"Kakšen pa je ta občutek?\"    \"Grozen. Vedno in povsod se mi zdi, da me preganjajo.\"    \"Od kdaj pa se vam zdi tako?\"    \"Odkar sem pred tednom dni pobegnil iz zapora!\"", "Preganjavica" },
                    { 2042, true, 39, "Pride hipohonder k zdravniku in ta mu reče: \"Pozdravljen Mirko, vas pa že dolgo ni bilo. Kaj pa se je zgodilo?\"    Mirko: \"Ah, nič posebnega, gospod doktor, nekaj sem bil bolan!\"", "Hipohonder pride k zdravniku" },
                    { 2033, true, 39, "Medicinska sestra je dala pacientu lonček za vzorec urina, ga poslala v kopalnico in mu naročila, naj ga napolni.    Po nekaj minutah se pacient vrne in ji izroči prazen lonček.    Medicinska sestra ga čudno pogleda, pacient pa reče: \"Hvala za lonček, ampak ga nisem potreboval, je bilo v prostoru stranišče!\"", "Vzorec urina" },
                    { 2030, true, 39, "Zaskrbljen oče po telefonu: \"Gospod doktor, moj sin ima škrlatinko!\"    Doktor: \"Vem, včeraj sem ga pregledal. Poskrbite, da ne pride v stik z drugimi!\"    Oče: \"Ne razumete! On ... Moj sin ... Je poljubil našo pomočnico.\"    Doktor: \"Potem moramo dekle izolirati!\"    Oče: \"Da ... In jaz sem tudi poljubil to dekle!\"    Doktor: \"No, zdaj pa postaja zapleteno. Verjetno ste se tudi vi okužili, če še niste imeli škrlatinke.\"    Oče: \"In moja žena ... Njo sem tudi poljubil!\"    Doktor: \"Prekleto, potem bom pa verjetno tudi jaz zbolel!\"", "Okužba s škrlatinko" },
                    { 1983, true, 39, "Peter je v nočnem lokalu srečal svojega osebnega zdravnika.    Ta mu je jezno dejal: \"Razložite mi naslednje: pred kratkim sem vam napisal recept za uspavalne tablete, vas pa sem v zadnjih dneh že trikrat videl v nočnem lokalu!\"    \"To pa ja ni nič posebnega!\" mu je odgovoril Peter. \"Tablete so za mojo ženo!\"", "Big brother" },
                    { 1972, true, 39, "\"Kolega, slišal sem, da na pacientih izvajate novo šok terapijo.\"    \"Res je, vnaprej jim pošljem račun!\"", "Šok terapija" },
                    { 1950, true, 39, "\"Ne morem natanko ugotoviti, kaj vam je,\" pravi zdravnik pacientu.    \"Mislim, da je kriv alkohol!\"    \"Nič ne de,\" pravi bolnik, \"bom prišel, ko boste trezni.\"", "Postavljanje diagnoze" },
                    { 1934, true, 39, "Sredi noči zazvoni telefon pri kirurgu: \"Tukaj Mlinarjev Tone. Gospod doktor, pridite hitro k nam! Mislim, da ima moja žena vnetje slepiča.\"    \"Pomirite se,\" reče zdravnik, \"vaši ženi sem izrezal slepič pred tremi leti! Še nikoli pa nisem slišal, da bi imel človek dva slepiča!\"    \"Ali tudi tega še niste slišali, da se je nekdo dvakrat oženil?\"", "Problem s slepičem" },
                    { 1160, true, 39, "V cakalnici pri zdravniku je  gneca. Medicinska sestra Maja  nenadoma pritece v ambulanto:  Doktor, doktor, v cakalnici je   pacient, ki mu je kosilnica   odrezala obe nogi.  Kaj naj z njim?   Zdravnik: Brez panike, sestra.  Recite mu, naj vstopi.", "Brez panike" },
                    { 1153, true, 39, "Moski pride k zdravniku in mu ves obupan potozi:\"Gospod doktor, zapustila me je zena.\"  Doktor:\"In zakaj ste prisli k meni? Morali bi k odvetniku.\"  \"Ampak, gospod doktor, mene to zelo boli.\"", "Zapustila ga je zena" },
                    { 1152, true, 39, "Koncno sem mojega moza odvadila gristi nohte?  Kako ti je pa to uspelo?  Skrila sem mu zobe!", "Grizenje nohtov" },
                    { 147, true, 39, "Pride stara naglušna babica k doktorju in reče:  \"Doktor, če bi vi znali kako mene boli tu, pa tam, pa ovo pa ono...\"    Ugotovi doktor, da babici v bistvu nič ni , samo EMŠO je visok pa ji priporoča:  \"Oma, vam manjka kura C-VITAMINA.\"    Pride babica domov, pa jo deda vpraša:  \"Kaj pravi dohtar, žena?\"  Oma pa: \"Kaj pravi? To kaj že sama dobro vem! Fali mi kurac in liter vina.\" ", "Naglušna babica pri zdravniku" },
                    { 146, true, 39, "85 letnega dedka je zelo zanimala kvaliteta njegove sperme in je šel k svojemu zdravniku.    Doktor mu je dal stekleničko rekoč: \"Jutri zjutraj mi prinesite vzorec vaše sperme.\"    Naslednje jutro je dedek v ordinaciji in zdravniku moli prazno stekleničko.    Zdravnik ga vpraša, kaj se mu je zgodilo.    Moški: \"Doktor! To pa je bilo tako: najprej sem poskušal z desno roko, pa mi ni uspelo, nato z levo, pa spet nič. Potem sem poklical ženo, naj mi pomaga. Matrala se je z desno roko, nato je poskušala še z levico... pa nič. Poskusila je z usti, z zobmi, brez zob ... pa nič ni pomagalo, nič se ni zgodilo.  Poklical sem celo sosedo Ano, ker je mlada.  Poskusila je z obema rokama, s stisnjenima kolenoma in absolutno nič ni  pomagalo.    Doktor je zgrožen: \"Kaj, klicali ste še sosedo?\"    Starček odgovori: \"Ja zares, karkoli smo poskusili, pokrovčka nismo mogli odviti!\"", "Testiranje sperme" },
                    { 145, true, 39, "Pacientka potoži ginekologu: \"Nekaj je narobe z mano. Imam 35 let in še nobene sramne dlake.\"    \"Hm. Kolikokrat na teden pa imate spolne odnose?\"    \"Od petindvajsetkrat do trideset-krat.\"    \"No, poglejte: na avtocesti tudi ne raste trava\"", "Pregled pri ginekologu" },
                    { 124, true, 39, "Zdravnik je pregledal pacienta in mu zadovoljno rekel:  \"Zdravi ste in v odlični kondiciji. Kako pa vaše sek-sualno življenje?\"  \"No ja, gre. Trikrat na teden že gre\"!  \"Kaj, a samo trikrat na teden? Pri vaši konstituciji in zdravju bi morali radost življenja okušati vsak dan trikrat, ne pa trikrat na teden\".  \"Saj bi, ampak ne gre zaradi službe\".  \"Saj sem vedel. Preveč ste obremenjeni. Kaj pa ste po poklicu?\", ga vpraša zdravnik.  \"Duhovnik sem ...\"!", "Moški pri zdravniku" },
                    { 35, true, 39, "Pri anatomiji človeka profesor vpraša študentko:  \"Koliko sperme se izbrizga pri ejakulaciji odraslega moškega?\"    Študentka:\" ......eeee, ...eee, ....e, ... požirek. Mogoče požirek in pol!\"", "Količina brizga sperme" },
                    { 25, true, 39, "Moški gre k zdravniku.     Zdravnik:”Kaj vas muči?”     Moški:”Eno jajce imam plavo.”     ZRAVNIK:”To zna biti,nevarno bo treba odrezat.”     Dobro ,odrežejo mu jajce,pa pride ponovno čez mesec dni.     Zdravnik:”Kaj je spet?”     Moški:”Luleka imam plavega.”     Zdravnik:”Odrezat!”     In možkar ostane tudi brez luleka.     Čez dva meseca zopet pride k zdravniku.Stari zdravnik je na dopustu,zamenjuje ga mlajši zdravnik.     Zdravnik:”Kaj vas muči gospod?”     Moški:”Rit imam čisto plavo.Isti znaki so kot prej!”     Zdravnik:”POKAŽITE!”     Sleče se in pokaže.     Zdravnik:”Nič hudega ni,gospod. Vaše kavbojke puščajo barvo!!!”", "Težave s plavimi udi" },
                    { 2120, true, 37, "Rekel sem ji, da bi želel poskusiti nekaj novega v postelji.    Pa mi je pokazala kako se preobleče kovter ...", "Nekaj novega v postelji" },
                    { 2115, true, 37, "Ženska se zbudi z zehanjem.    Moški pa z erekcijo.    Naklučje?", "Naklučje" },
                    { 2114, true, 37, "Ivan ni bil prav pameten in njegovi prijatelji so se pogosto norčevali iz njega. Nekoč je prišel urejen kot že dolgo ne. Povsem nova obleka, kravata, čudovita srajca.  - Madona Ivan, kako pa si se danes uredil, so se čudili sodelavci.  - Ženino darilo.  - Ali je bilo presenečenje?  - Pa še kakšno. Včeraj, ko sem prišel domov malo prej kot  navadno, me je obleka že čakala na postelji.", "Ženino darilo" },
                    { 2072, true, 37, "Vpraša Micka svojega moža: \"Si povedal svojemu šefu v službi, da midva ne moreva živeti od tvoje bedne plače?\"    Mož: \"Sem.\"    Micka: \"In? Kaj je rekel?\"    Mož: \"Predlagal mi je, da se ločim!\"", "Premajhna plača za dva" },
                    { 1997, true, 37, "Mlad zakonski par sedi pri večerji.    Mož se pritoži: \"Spet hrana iz konzerve?\"    \"Ja, dragi moj, toda tokrat je bil na konzervi narisan lep kužek in spodaj je pisalo: Za mojega ljubega.\"", "Enolična hrana" },
                    { 1961, true, 37, "Mlad par prebije prvo poročno noč v hotelu.    Zjutraj se ženin poreže pri britju in kri obriše v rjuho.    Sobarica vidi kri na rjuhi, misli, da je bila nevesta nedolžna in pove to šefu hotela.    Šef pravi mladoporočencema: \"To je velika redkost in za naš hotel velika čast. Za nagrado bosta lahko noč po zlati poroki, čez 50 let, brezplačno preživela pri nas.\"    Čez 50 let dedek in babica res prideta in prespita v isti sobi.    Zjutraj babica, precej prehlajena, izpiha nos v rjuho.    \"Ja kaj pa delaš?\" pravi dedek, babica pa odgovori: \"Pred 50 leti si ti meni dvignil ugled, zdaj ga bom pa jaz tebi.\"", "Poročna noč in posledice" },
                    { 1847, true, 37, "Mi lahko kdo pove, katera hrana povzroča največ gorja in trpljenja še leta po zaužitju? Po nekaj trenutkih tišine se nekdo oglasi: »Poročna torta.«", "Torta" },
                    { 1800, true, 37, "Janez se zvecer vrne iz druge  izmene, se sede na stol v  kuhinji in vprasa:  Kaj bo za vecerjo?  Zena se postavi v zapeljivo  pozo in rece:  Mogoce jaz?  Saj ves, da ne smem nic mastnega.", "Mastno" },
                    { 1736, true, 37, "\"Si slišal, da je Bogdana zapustila žena?\"    \"Res? In kako je prenesel?\"    \"Zdaj je že precej bolje! Prvi teden pa se mu je pa skoraj zmešalo od veselja in veseljačenja.\" ", "Zapustila ga je" },
                    { 1697, true, 37, "S Tonetom sva se tako mocno   sprla, da sem nanj zavpila,   da ga nocem vec videti.  In? Te je zapustil?  Ne, ugasnil je luc.", "Luc" },
                    { 1661, true, 37, "Kako žena prepriča moža, da ostane doma?    Izprazni mu denarnico in jajca.", "Preprosta rešitev" },
                    { 1581, true, 37, "Daljši kot je zakon bolj kratki so izrečeni stavki.", "Ravno nasprotno" },
                    { 1364, true, 37, "Marta vprasa svojega dragega:  Dragi, ali nisem lepa?  Kosir ljubeznivo:  Draga, se vec si kot lepa!  Ona raznezno:  Povej, zaupaj mi, za koliko vec.  On: Za 3o kilogramov", "Ljubeznivost" },
                    { 1085, true, 37, "Moz in zena se kregata:    Druga zenska je vedno boljsa  kot domaca.  Samo tebi sem domaca, vsem  ostalim sem druga.", "Domaca" },
                    { 986, true, 37, "Franci vpraša Janeza: ''Kaj bi naredil, če medved v gozdu napade tvojo ženo?  Janez: ''Kaj bi naredil? Nič! Ne bi se vmešaval, kaj me briga ... Sam jo je napadel, sam naj se brani!''", "Napad na ženo" },
                    { 984, true, 37, "Žena, moram ti povedati, nič ne bo z morjem, ker sem včeraj pri pokru izgubil ves denar.\"  \"Oh, ne... Kako je to mogoče?\"  \"Jbg, jaz sem bil pijan, on pa je imel srečo.\"  \"Dobro, potem pa ti lahko povem, da sem prejšnji teden na sindikalnem seksala s Petrom.\"  \"Kaaaaj? Kako to?\"  \"Jbg, jaz sem bila pijana, on pa je imel srečo.\"", "Poker in sodelavec" },
                    { 983, true, 37, "Pogovor med sosedama: Prva: \"Gospa, pa menda niste kaj bolni, že 14 dni vsako opoldne vidim zdravnika, ki odhaja iz vaše hiše.\" Druga: \"Veste kaj, draga soseda, ko je k vam cel mesec hodil oficir, tudi nisem spraševala, ali je vojna!\"", "Poročene sosede" },
                    { 979, true, 37, "Žena razočarano vpraša moža: \"Dragi, ali res ne znaš govoriti o ničemer drugem, kakor o nogometu?\"  Mož: \"O čem pa naj bi govoril?\"  Žena: \"Recimo o ljubezni.\"  Mož: \"No, prav. Ali se še vedno sestajaš z našim sosedom, ko grem jaz na nogometno tekmo?!?\"", "Nogomet in ljubezen" },
                    { 976, true, 37, "Ženska na sodišču.  Sodnik:\" Priznate,da ste ustrelili moža med gledanjem nogometne tekme?\"  Ženska:\" Priznam.\"  Sodnik:\" Katere so bile njegove zadnje besede?\"  Ženska:\" Streljaj,streljaj!\"", "Moški in nogomet" },
                    { 736, true, 37, "Žena vpraša moža: “Kakšne ženske so ti všeč lepe ali pametne?”  Mož:” Nobene izmed teh, samo tebe ljubim.”", "Kakšne so ti všeč?" },
                    { 735, true, 37, "Pri zdravniku  Gospod doktor,imam problem pri seksu. Moj lulček je kot pes.  Kako to mislite?  Moji ženi noče nič, a sosedo bi pa kr rastrgal! ", "Problemi" },
                    { 555, true, 37, "Mož in žena v trgovini skupaj nakupujeta hrano, pijačo ipd.  Naenkrat mož zagleda napis “AKCIJA: Laško pivo (24 kom) samo 20 EURO” in takoj vzame en paket in ga položi v voziček.  Ko žena to zagleda ga vpraša zakaj je vzel pivo.  Njegov odgovor: “Draga, 24 pločevink je samo 20 EURO”    Ona: “Vrni ga nazaj, je treba šparati.”  Mož raje kot se prepirat ubogljivo vrne kišto piva nazaj.  Hodita naprej po trgovini in žena zagleda kremo za 40 EURO in jo brez premisleka položi v nakupovalni voziček.  Mož: “Draga, zakaj pa si ti lahko vzela kremo?”    Žena: “Dragi, to je zato, da se lahko namažem in da sem zvečer, ko se ljubiva vsa lepa samo zate.”  Mož: “To si tudi po 24 pločevinkah Laškega! In to za samo 20 EURO!”", "Nakupovanje" },
                    { 543, true, 37, "Pride žena možu na obisk v zapor in ga vpraša:  - Kako se kaj počutiš, dragi?  - Glih tak, ko doma, pravi  - No, sem vesela, samo, kak to misliš, tak, ko doma?  - No, saj veš, hrana je neokusna, perilo ni glih speglano, seksa tudi ni, pa še vun me ne pustijo zvečer!", "Mož in zapor" },
                    { 154, true, 39, "Nosečnica, ki pričakuje prvega otroka, je prišla na pregled h ginekologu.  Po pregledu je plašno pričela:\"Veste, moj mož je želel, da vas nekaj vprašam...\"    \"Vem, vem\", jo ginekolog pomirjujoče potreplja po ramenu. \"To me vedno vprašajo.  Spolno ste lahko dejavni do visoke nosečnosti.\"    \"Ne, ni to\", odgovori pacientka.  \"Moža zanima, če lahko še vedno kosim travo?\"", "Nosečnica pri ginekologu" },
                    { 162, true, 39, "Ljubko dekle s čudovitim telesom je tik pred tem, da jo operirajo. Leži na gibljivi postelji, povsem gola, na njej je le rjuha.  Medicinska sestra jo pripelje do vrat operacijske sobe in vstopi, da bi preverila, ali je že vse pripravljeno.    Po hodniku k punci pristopi mož v belem, privzdigne rjuho, si ogleduje njeno telo in nato stopi se po enega tipa v belem.  Tudi ta privzdigne rjuhico, pozorno analizira. Pride še tretji, ki je že bolj drobnogleden kot prejšnja dva.    Dekle naposled izgubi potrpljenje:    \"Super, da me tako natančno pregledujete, toda zanima me, kdaj me boste že enkrat operirali??\"    Eden izmed trojice skomigne:\"Ne vem, mi samo hodnik malamo.\"", "Dekle pred operacijo" },
                    { 176, true, 39, "\"Za vas imam dobro in slabo novico\" reče doktor pacientu.  \"Najprej mi povejte slabo novico\" reče pacient.  \"Imate zelo redko, težko neozdravljivo bolezen!\"  \"Kaj pa dobra novica?\"  \"Poimenovali jo bomo po vas.\"", "Neozdravljiva bolezen" },
                    { 177, true, 39, "Doktor izpolnjuje kartotečni list in vpraša:  \"Kadite?\"  \"Ne.\"    \"Pijete?\"  \"Tudi ne.\"    Doktor nekaj časa zre v pacienta, nato pa mu reče:  \"Nekaj bom že našel, da vam bom prepovedal.\"", "Prepoved" },
                    { 1151, true, 39, "Mojca pri zdravniku.  Dober dan , gospod doktor!  Zdravnik: Dober dan.  Kar slecite se.  Mojca: Kam pa lahko odlozim obleko?  Doktor: Kar tu poleg moje jo dajte.", "Mojca" },
                    { 1136, true, 39, "Ferdo pride ves bled k zdravniku.  Potozi, da ga boli trebuh, da je   bruhal in driskal.  Zdravnik ga nekaj casa poslusa,   nakar ga pretipa in pregleda.  Nobenega dvoma ni, bili ste   zastrupljeni.   Ferdo: Kako? S cim?  Doktor: To pa bo pokazala sele  obdukcija.", "Zastrupitev" },
                    { 1126, true, 39, "Po pregledu rece zdravnik  pacientu:  Dobro kondicijo imate.  Osemdeset jih boste docakali.  Ampak jaz jih ze imam osemdeset!  Kaj sem vam rekel?", "Kondicija" },
                    { 1125, true, 39, "Medicinske sestre z tezavo ujamejo  pacjenta, ki gol teka po hodniku.  Kaj pa vam je? Zakaj ste pobegnili  z oparaciske mize?  Vasa kolegica je rekla: Ne bojte se,  operacija slepica je rutinska in   preprosta stvar.  Saj to je res!  Ze, ze. Vendar tega  ni rekel meni, ampak kirurgu.", "Rotinsko" },
                    { 1121, true, 39, "Kolega zdravnika diskutirata o  posebnih primerih.  Imam pacjentko, dvajset let,   idealne mere, obraz kot angel,  prsi kot nalasc za bozanje,  ritka elegantno zaobljena...  In kaj jo tezi?  Vsakic ko kihne, zacuti nezadrzno  potrebu po seksu.  Kaksna zdravila si ji predpisal?  Poper...", "Poper" },
                    { 1120, true, 39, "Zdravnik pride k novopecenima  starsema in jima rece:  Vajin otrok se je rodil brez  penisa! O, joj...Strasno...  Niti ne! Jih bo imela pa cez  dvajset let toliko vec...", "Brez lulcka" },
                    { 1118, true, 39, "Pepca pride h ginekologi.  Gospod doktor, z mozem si zeliva  otroka, a doslej nama se ni   uspelo.  Zdravnik: Potem se pa slecite.  Pepca zgrozeno:Ampak, doktor, jaz  si vendar zelim otroka s svojim   mozem, ne z vami!", "Doktor" },
                    { 1078, true, 39, "Košir se odpravi k zdravniku. V čakalnici sedi uro, dve, tri, ura kaže že pozno popoldne.    Naenkrat se na vratih pojavi zdravnik: \"To bi bilo vse za danes, moram na sestanek, tisti, ki niste prišli na vrsto, se oglasite jutri.\"    Takrat se oglasi Košir: \"Kaj pa naj jaz z mojim pečenjem?\"     Doktor se zdrzne in mu namigne: \"Dobro, vas še vzamem, vsi ostali pa domov.\"    Kmalu ostaneta sama, zdravnik ne izgublja časa: \"Kje je pečenje?\"  Košir: \"Ko lulam, me strašno peče ...\"", "V čakalnici" },
                    { 1060, true, 39, "Doktor v psihiatrični bolnici je vstopil v bolniško sobo in zagledal pacienta, ki je sedel na stolu in zamišljeno vrtel volan ter govoril: \"Brrrrr...brrrrr...\"    \"Kaj pa delaš?\" ga je vprašal doktor.    \"S tovornjakom se peljem v Pariz!\" je dejal pacient.    V sosednji postelji je pod odejo ležal popolnoma gol pacient, ki je skakal po postelji.    \"Kaj pa ti delaš?\" ga je vprašal psihiater.    \"Medtem, ko je on na službenem potovanju jaz seksam z njegovo ženo!\" ", "V psihiatrični bolnici" },
                    { 1038, true, 39, "Polde se v bolnisnici zbudi iz kome.  Pristopi zdravnik in mu pojasni:  Sreco ste imeli,zastrupili ste se  z alkoholum.  Polde:Pa so ze ugotovili,kdo mi je  dal strup v zganje?", "Zastrupitev" },
                    { 1002, true, 39, "Gospa Angelca je zaradi prehlada  obiskala zdravnika.  Ta jo pregleda in ji rece:  No,gospa,tukaj sem vam napisal  recept.O,gospod doktor,kaj vi  tudi tako radi kuhate kot jaz?", "Recept" },
                    { 966, true, 39, "Pride pacient k čedni sestri na odvzem krvi. Dogovorita se, da bo kri dal iz prsta...  Sestra piči v prvi prst... nič  Piči v drugega.... nič  Piči v tretjega, spet nobene krvi....  Sestra vzame prst v usta in močno potegne vase in kri priteče iz prsta.  Pacient vse to gleda in reče: \"Sestra ravnokar sem se spomnil, da mi je zdravnik rekel naj dam tudi vodo.\"", "Pacient" },
                    { 770, true, 39, "Lepa,mlada ženska, leto dni poročena ne more zanositi in pride k zdravniku: \"Prosim,doktor,rada bi imela otroka,pa ne gre.Kaj mi je storiti?\",ga sprašuje.    \"To bomo uredili takoj\", pravi on ,\"slecite se prosim!\"    Mlada žena zardi in pravi: \"Lepo prosim ne... doktor,prvega otroka bo rada imela z možem!\" ", "Ne more zanositi" },
                    { 683, true, 39, "Med obiskom v psihiatrični bolnici v Begunjah raziskovalni novinar vpraša direktorja, na osnovi česa se odločijo, koga bodo sprejeli na zdravljenje.    \"Zelo enostavno je,\" pravi direktor. \"Postavimo ga pred kad, polno vode, in mu damo čajno žličko, skodelico in vedro ter naročimo, naj kar najhitreje izprazni kad.\"    \"Če prav razumem\", pravi obiskovalec, \"tisti, ki je normalen, začne vodo zajemati z vedrom...\"    \"Ne,\" pravi direktor. \"Tisti, ki je normalen, izvleče zamašek z dna kadi. Želite sobo z balkonom ali brez???\"", "V psihitrični bolnišnici" },
                    { 289, true, 40, "Za svoje dekle sem porabil cel milijon evrov!  Vse je šlo za lepotne operacije!    Zdaj mi je pa ušla.    Rad bi denar nazaj, toda ne vem kako baba zdaj izgleda!", "Plastične operacije" },
                    { 643, true, 39, "Doktor svojemu kolegu doktorju: \"Doktor, simulant iz sobe 50 je umrl.\"    tadrugi: \"No, sedaj je pa resnično pretiraval.\"", "Pretirava" },
                    { 575, true, 39, "\"Meni je doktor svetoval, da si bom revmatizem pozdravil, če se bom izogibal vode.\"    \"In?\"    \"Ja, prav bedasto se počutim, ko sedim v prazni banji in se drgnem po telesu!\"", "Zdravnikov nasvet" },
                    { 467, true, 39, "Zobozdravnik je opazil, da je njegov naslednji pacient, stara gospa, zelo živčna. Zato se je odločil, da ji bo povedal en vic , medtem ko je natikal rokavice.    \"Ali veste kako delajo latex rokavice?\" je vprašal.    \"Ne, ne vem.\" je odgovorila stara gospa.    \"Torej, na Kitajskem imajo tovarno, z velikim bazenom lateksa in delavci z različno velikimi rokami potopijo svoje roke v latex, počakajo da se posuši, jih zrolajo z rok in jih vržejo v škatlo.\"    Gospa se ni niti nasmehnila.    \"No, vsaj poskusil sem jo razvedriti\" si je rekel zobozdravnik.    Toda 5 minut kasneje, ravno sredi vrtanja, je gospa prasnila v neobvladljiv smeh.    \"Kaj je tako smešno?\" je vprašal zobozdravnik.    \"Ravno si hočem predstavljati, kako delajo kondome!\"", "Izdelava rokavic" },
                    { 452, true, 39, "Pri pregledu ženske pacientke, doktor pravi: \"Vaše srce, pljuča, utrip srca in pritisk so v redu. No, sedaj pa še poglejmo tisto fletno majhno stvar, ki vas ženske spravi v vse vrste problemov.\"    Ženska se nemudoma začne slačiti.    Doktor to prepreči rekoč: \"NE! NE! Kar oblecite se nazaj. Samo pokažite mi jezik.\"", "Zdravniški pregled" },
                    { 188, true, 39, "\"Doktor, trenutno nimam denarja, da bi vam plačal zdravljenje. Vam bom pa v oporoki zapisal del premoženja. Ste za to?\"  \"Seveda sem! No, sedaj mi pa vrnite recept, ki sem vam ga napisal, da vam bom predpisal nekaj drugega.\"", "Plačilo zdravljenja" },
                    { 187, true, 39, "\"Gospod doktor, ali imam samo jaz to bolezen?\"    \"Kje pa, na pokopališču je polno takih.\" ", "Bolezen" },
                    { 186, true, 39, "Doktor: \"Te tablete, ki sem vam jih predpisal, so tako močne, da jih lahko jemljejo le pacienti, ki so odličnega zdravja.\" ", "Močne teablete" },
                    { 185, true, 39, "\"Doktor, prišla sem vam izreči iskreno zahvalo!\"   je rekla pacientka, ko je vstopila v doktorjevo ordinacijo in mu na mizo postavila steklenico konjaka in modro kuverto.    \"Oprostite..... \"je nekoliko zmedeno deloval doktor,  \"ne spominjam se vas več. Ste vdova ali pacientka?\" ", "Hvaležna gospa" },
                    { 184, true, 39, "\"Kaj pravite?\" zaskrbljeno vpraša pacient kardiologa, ki mu je pregledal delovanje srca.    \"Hm. Nekoliko je res slabotno, vendar ste lahko mirni. Do konca bo že vzdržalo.\" ", "Pregled pri kardiologu" },
                    { 183, true, 39, "\"Gospod doktor, kaj pa če operacija ne bo uspela?\" je prestrašeni pacient vprašala doktorja tik preden so mu dali anestezijo.    \"Tega pa ne boste doživeli!\" ga je potolažil kirurg. ", "Pred operacijo" },
                    { 182, true, 39, "\"Gospod doktor, bo moja operacija zelo draga?\"    \"Nič ne skrbite, to skrb lahko prepustite vašim dedičem!\" ", "Cena operacije" },
                    { 181, true, 39, "Razgovor dveh kirurgov:  \"Teoretično pacient Mihec sploh ne bi smel preživeti operacije!\" je rekel prvi.    \"No, vidite kolega, kaj napravi močna volja do življenja. Proti njej je tudi moderna medicina nemočna.\" ", "Uspela operacija" },
                    { 180, true, 39, "Pacient: \"Ne morem se odločiti med tem da grem na operacijo ali da umrem!\" reče pacient doktorju.    \"Z malo sreče imate lahko oboje\" reče doktor. ", "Odločitev o operaciji" },
                    { 179, true, 39, "\"Zob ste mi izpulili v petih minutah pa za to hočete 50 Evrov!\"    \"Če bi želeli, bi vam ga lahko pulil tudi dve uri!\" ", "Puljenje zoba" },
                    { 178, true, 39, "Pacient je vstopil v ordinacijo in rekel zdravniku:  \"Moj prijatelj je imel spolno razmerje z neznano žensko in zdaj se boji, da seje okužil s kakšno spolno boleznijo.\"    Zdravnik: \"Hmmmm, najbolje bo, da slečete hlače in mi pokažete vašega prijatelja.\" ", "Prijatelj se je okužil" },
                    { 590, true, 39, "Pacient, ki je imel zapičen nož v trebuh pride do zdravnika in reče: “Pomagajte mi. Umiram.”  Doktor pravi: “Ura je pet minut do treh, mi pa delamo samo do treh. Ne morem vas sprejeti. Pridite jutri.”  “Prosim pomagajte mi, ne bom zdržal do jutri”.  “Prav.” reče doktor, mu izpuli nož iz trebuha in mu ga zapiči v oko: “Pojdite k okulistu. On dela do štirih.”", "Nož zapičen v trebuh" },
                    { 68, true, 37, "Vpraša žena moža: “Kaj ti je na meni bolj všeč, moj čedni obraz ali seksi telo?”  Mož jo pogleda in odgovori: ”Rad imam tvoj smisel za humor.”    Zakonca, oba pri štiridesetih, se pogovarjata v spalnici. Ona si ogleduje svoje prsi.  Mož pa: \"Kaj se pa tko ogleduješ?\"  Žena: \"Včeraj sem bila pri zdravniku in je rekel, da imam joške kot 25-letnica.\"  Mož: \"Kaj pa je rekel za tvojo 40-letno rit?\"  Žena: \"Nič! Tebe sploh ni omenjal!\"", "Samozavest" },
                    { 290, true, 40, "Sonja je srečala Veroniko, ki jo je bilo kar precej skupaj in ji rekla: \"Ti si se pa zelo zredila, odkar se nisva videli!\"    \"Nisem se zredila, noseča sem!\" je pojasnila Veronika.    \"Da te ni sram! Zdaj bodo pa vsi vedeli, kaj si delala!\"", "Sonja sreča Veroniko" },
                    { 295, true, 40, "Kako rečemo \"ženska\" po dolenjsko s 3 črkami?    QQŠ", "Ženska po dolenjsko" },
                    { 1466, true, 40, "Soseda vprasa sosedo:\" Od kod ta modrica okoli ocesa?\"  \"Od moza.\"  \"Sem mislila, da je na potovanju.\"  \"Jaz tudi!\"", "Na poti" },
                    { 1433, true, 40, "Zenska pacientka pri zdravniku. Po koncanem pregledu zdravnik pravi: vasa pljuca, srce in utrip so vredu. Zdaj pa poglejmo se tisto majhno fletno stvar, ki vas zenske veliko krat spravi v probleme.  Zenska se nemudoma zacne slaciti.  Doktor jo zaustavi: Ne, ne. Pokazite mi jezik!", "Zenska pacientka pri zdravniku" },
                    { 1431, true, 40, "Zenska pri ginekologu.  Gospa, noseci ste. Zdaj tri mesece ne smete seksati z mozem.  Ni problema, saj imam ljubimca.", "Varanje" },
                    { 1421, true, 40, "Lepa soseda pozvoni pri sosedu  in mu rece:  Danes bi se tako rada zabavala,   napila in ljubila vso noc,   imate za zvecer kaksne nacrte?  Ne!  Mi boste potem lahko popazili  psa?", "Pomoc" },
                    { 1412, true, 40, "\"Lidija, priznaj, da sedaj veliko prihraniš, ko sama kuhaš!\"    \"Prav imaš, mama. Mož se sedaj skorajda ne dotakne hrane.\" ", "Prihrani pri hrani" },
                    { 1401, true, 40, "\"Katere ženske imaš raje: tiste ki veliko govorijo, ali one druge?\"    \"Katere druge?\"", "Kateri tip ženske" },
                    { 1400, true, 40, "Ženske so nervozne samo, ko:  - dobijo,  - ne dobijo,  - bi morale dobiti.    V drugih primerih so vredu.", "Nervoza" },
                    { 1399, true, 40, "\"Koliko črncev je potrebnih za čiščenje tisoč sanitarnih prostorov?\"    \"Nič, ker je to žensko delo!\" ", "Čiščenje" },
                    { 1398, true, 40, "\"Zakaj je na svetu več žensk kot moških?\"    \"Ker je po svetu več za čistiti kot za misliti!\" ", "Svetovna populacija" },
                    { 1397, true, 40, "Vprašaj žensko naslednje: \"Če dobiš otroka in se potem ločiš od moža, kdo naj bi po tvojem mnenju dobil otroka?\"    \"Seveda jaz!\" bi se oglasila ženska.    No, zdaj pa je čas za drug primer: \"V avtomat s pločevinkami vržeš pet evrov. Avtomat ti da pločevinko. Komu pripada pločevinka pijače: tebi ali avtomatu?\" ", "Ločitev in skrbništvo" },
                    { 1396, true, 40, "\"Zakaj ženskam ni potrebno nositi ročnih ur?\"    \"Ker je ponavadi v vsaki kuhinji obešena stenska ura!\" ", "Ženske in ura" },
                    { 1395, true, 40, "\"Zakaj ženske ne smučajo?\"    \"Ker v kuhinji ne sneži!\"", "Ženske in smučanje" },
                    { 1394, true, 40, "Z avtom in žensko je popolnoma enako.    Neguješ ju in skrbiš zanju, kupiš ima razne luksuzne dodatke.    In ko sta popolno opremljena ti ju nekdo rukne od zadaj!\" ", "Opremljanje" },
                    { 1393, true, 40, "Ženska je res čudna bitja!    Kar naprej gleda v ogledalo, samo takrat ne, ko z avtom vozi vzvratno! ", "Vzvratna vožnja" },
                    { 1392, true, 40, "Kakšna je razlika med žensko in avtomobilom?\"    \"Razlike ni. Bolje kot izgledata, dražje je vzdrževanje!\" ", "Ženska in avtomobil" },
                    { 1391, true, 40, "\"Kaj dela ženska, ko bulji v prazen list papirja?\"    \"Bere svoje pravice!\" ", "Ženska in prazen papir" },
                    { 1389, true, 40, "Kako veš, kdaj bo ženska povedala kaj pametnega?    Ko začne stavek z: \"Mož mi je povedal...\" ", "Povedala bo nekaj pametnega" },
                    { 1388, true, 40, "\"Ti čevlji so mi preozki.\"    \"Letošnja moda so ozki čevlji.\"    \"Že mogoče. Toda jaz imam lanske noge.\"", "Nova moda" },
                    { 1387, true, 40, "\"Vsi moški so enaki!\"     \"Vsi bi od mene radi isto stvar.\"    \"Še sreča, da jo imam.\" ", "Vsi moški so enaki" },
                    { 1386, true, 40, "Fant se poslavlja od svojega dekleta in med slovesom reče: \"Draga, a ni prava ljubezen čudovita?\"    \"Ja, lepa je! Toda tudi s tabo mi je lepo.\" ", "Prava ljubezen" },
                    { 1385, true, 40, "V trgovino z opremo za domače živali vstopi fina dama in reče: \"Rada bi oblekico za mojega pudel'čka?\"    \"Kakšne velikosti pa?\"    \"Joj, pozabila sem ga izmeriti.\"    \"Pa pojdite ponj.\"    \"Ne, to pa ne! Rada bi ga presenetila za rojstni dan!\"", "NAkup obleke za pudla" },
                    { 1384, true, 40, "Potem ko je mož izvedel, da ga je žena prevarala z beračem, jo vpraša: \"Le kako si me lahko prevarala z beračem?\"    \"Prišel je pred vrata in me prosil, če mu lahko dam tisto, česar moj mož več ne rabi.\"", "Prevarala ga je" },
                    { 1383, true, 40, "\"Koliko let imate, gospa?\"    \"28 jih štejem!\"    \"Pred koliko leti pa ste jih nazadnje prešteli?\" ", "Starost" },
                    { 1382, true, 40, "\"Kaj pa kuha tvoja nova punca?\"    \"Do zdaj samo mulo.\" ", "Kuharica" },
                    { 1380, true, 40, "Mlado dekle zaupa svojemu zdravniku: \"Ne vem, kaj je z mano, ampak že tri mesece imam težave. Ne počutim se najbolje, ne morem jesti, večkrat bruham. Skratka same težave!\"    \"Po izvidih sodeč se boste morali kmalu poročiti.\"    \"Poročiti? Zakaj pa?\"    \"Da bodo vaše težave dobile tudi očeta!\"", "Ne počuti se dobro" },
                    { 1379, true, 40, "Na železniški postaji: \"A moram za otroke tudi plačat'?\" zanima žensko.    \"Pod sedem ni treba,\" odvrne blagajničarka.    \"Dobro. Jaz imam samo tri!\" ", "Nakup kart" },
                    { 1357, true, 40, "Zakaj moski ne zaupajo zenskam?  Kdo pa bi zaupal nekomu, ki po enotedenski krvavitvi se vedno ni mrtev?", "Krvavitev" },
                    { 1355, true, 40, "Na nudisticni plazi lepotica naroci sladoled.   \"Enega cokoladnega, prosim!\"  Ker opazi, da jo mladi prodajalec opazuje, ga vprasa:\"Se nikoli niste videli golega zenskega telesa?\"  Mladi fant odgovori:\"Ne, ni to. Zanima me od kje boste potegnili denarnico.\"", "Denarnica" },
                    { 1334, true, 40, "Kako žensko pripraviš do orgazma?    Pa koga to briga?", "Ženska in orgazem" },
                    { 1503, true, 40, "Žena mesarja Toneta zahrope v zakonski postelji: \"Ravnaj z menoj tako, kot s svojimi strankami v mesnici!\"    On začudeno: \"In kako je to?\"    Ona: \"Vprašaj me, če je lahko malo več.\"  ", "V postelji" },
                    { 1322, true, 40, "Kaj pokaže moški ženski, ki je 10 let vozila brez nesreče?    Kako se prestavi v 2. prestavo! ", "Varna voznica" },
                    { 1510, true, 40, "Moški in ženska na cesti trčita drug v drugega. Oba avta sta povsem razbita, ampak čudežno nobenemu od njih ni bilo nič!     Ko jima uspe splezati ven iz razbitih avomobilov ženska takoj reče:\"Uau, poglej najina avta - od njih ni ostalo prav nič! Hvala bogu, da sva midva v redu! To mora biti njegov znak, da nama usojeno živeti kot prijatelja.\"    Moški si jo na hitro ogleda in ker je bila res postavna, on pa samski ji hitro potrdi, čeprav se je zavedal, da je ona pripeljala po njegovi strani: \"Seveda gospodična, če bog tako želi je prav tudi meni...\"    Potem pa se spet oglasi ženska:\"Uau, poglej, steklenica viskija iz mojega avtomobila je poleg naju še edina stvar, ki je ostala cela. Tudi to mora biti sporočilo boga, da naj ga skupaj spijeva in se ob pijači pobližje spoznava.\"    Moški je zdaj že dojel, da sta si z dekletom res všeč in, da bi lahko to peljalo kam naprej in tako je vzel steklenico, ki mu jo je podala in spil kar tretjino viskija , potem pa jo podal nazaj ženski.    Na njegovo presenečenje pa je ženska na steklenico nazaj nadela zamašek in mu jo vrnila v roke, zato je je začudeno vprašal:\"Ti pa ne boš nič spila?\"    Ženska mu odgovori: \"Ne hvala, bom kar počakala policijo, pa da oni razjasnijo kdo je bil kriv, da imava razbite avtomobile.\"", "Prometna nesreča" },
                    { 1567, true, 40, "Kakšna je razlika med upokojenko in devico?    Ni je!  Obe čakata prvega.", "Upokojenka in devica" },
                    { 326, true, 41, "zakaj gre boberček v trgovino tuš z brisačko?zato ker misli da je tam tuš", "Bober gre v Tuš" },
                    { 284, true, 41, "Grozno žalosten izgledaš! Kaj pa se ti je zgodilo?\"    nesrečni lastnik: \"Psa sem, tako kot ponavadi, spustil z vrvice, da bi se zdivjal, pa mi je ušel in se izgubil.\"    \"Daj oglas v časopis!\"    Žalostni lastnik: \"Saj je pameten, samo brati pa ne zna!\"", "Žalosten lastnik psa" },
                    { 2122, true, 40, "Soseda vpraša sosedo:  - Zakaj ima modrico okrog oči?  - Od moža – odgovori  - Sem mislila da je na potovanju?  - Jaz tudi.", "Modrica" },
                    { 2116, true, 40, "Kaj je razlika med mlado žensko in staro smreko?    Nobene!    Obe sta za podret", "Razlika" },
                    { 2097, true, 40, "Katerega meseca ženske najmanj govorijo?    Februarja, ker ima najmanj dni.", "Govorjenje" },
                    { 2083, true, 40, "V raj je prispela nova skupina žensk.    Sveti Peter jih postroji in reče: \"Vse, ki ste vsaj enkrat prevarale moža, stopite korak naprej!\"    Vse izstopijo iz vrste, razen ene.    Ko Bog to vidi, reče sv. Petru: \"Pojdi in preveri, če ni mogoče gluha!\"", "Ženske v raju" },
                    { 2081, true, 40, "\"Ženska je res čudno bitje. Kar naprej gleda v ogledalo, samo takrat ne, ko z avtom vozi nazaj!\"", "Ženske in ogledalo" },
                    { 2058, true, 40, "Zdravnik pregleduje poškodovanko in jo vpraša: \"Gospa, kako pa ste se opekli po ušesih?\"    Gospa: \"Veste, likala sem, nakar je zazvonil telefon in sem namesto slušalke dvignila likalnik.\"    Zdravnik: \"Ampak, opekline imate na obeh ušesih?\"    Gospa: \"Seveda. Ko sem se opekla, sem hotela poklicati rešilca!\"", "Neljuba nesreča" },
                    { 1993, true, 40, "Posloven človek pride v bar.    Za točilno mizo prisede k njemu dekle in predlaga: \"Kaj mislite o tem, da bi skupaj spila kozarec šampanjca?\"    \"Nisem Onassis,\" reče poslovni človek, \"za steklenico šampanjca pa že dam.\"    Medtem, ko pijeta šampanjec in poslušata nežno glasbo, dekle predlaga: \"Kaj mislite o tem, da bi malo zaplesala?\"    \"Nisem Fred Astaire, a malo plesa mi že ne bo škodilo.\"    Med plesom se dekle nekoliko privije k njemu in zašepeta: \"Kaj mislite o tem, da bi šla za hipec gor, v vašo hotelsko sobo?\"    \"Nisem Casanova, reče poslovni človek, \"toda to utegne biti prav prijetno.\"    Ko je zadeva v sobi opravljena, ga dekle vpraša: \"Kaj menite o sto dolarjih plačila?\"    \"Nisem žigolo, pa bom vseeno vzel.\"", "Ena stvar je vodila do druge" },
                    { 1965, true, 40, "Zakaj so ženske kot oblaki?    Ko enkrat gredo stran dan postane zelo lep.", "Ženske in oblaki" },
                    { 1887, true, 40, "Ženske trdijo, da so vsi moški isti.    Le od kod jim toliko izkušenj?", "Od kje jim izkušnje?" },
                    { 1846, true, 40, "Ženska je kot motor.    Igra se s tvojimi živci, zahteva denar, a navsezadnje ti nudi užitek.", "Ženske in motor" },
                    { 1836, true, 40, "Žene se delijo na vdove in na tiste, ki delajo na tem.", "Delitev žensk" },
                    { 1835, true, 40, "Kako ženske kličejo debeluhe brez denarja?    Svinja.    A debeluha, ki ima veliko pod palcem?    Moj mali medo!  ", "Ženske, kot ženske" },
                    { 1826, true, 40, "Dan žena bi moral biti 6. marca.    Ampak je trajalo predolgo, da so se uredile. Zato zdaj praznujemo 8. marca.", "Dan žena" },
                    { 1819, true, 40, "Ivan opazuje ženo pri šivanju.    \"Tega pa res ne razumem!\"    \"Česa ne razumeš?\"    \"Tega, da s tako lahkoto vdeneš nit v šivankino uho, avta v garažo pa ne.\" ", "A ni to fenomen" },
                    { 1805, true, 40, "Kandidatka za vozniški izpit je vprašala inštruktorja: \"Koliko še potrebujem, da bom šla lahko na izpit iz praktične vožnje?\"    \"Pet.\"    \"Pet ur?\"    \"Ne. Pet avtomobilov!\"", "Ženska v avtošoli" },
                    { 1797, true, 40, "Mlada dama je na sodiscu tozila  vec moskih hkrati za ocetovstvo.  Sodnik jo vprasa:  Kako ne veste, s kom ste zanosili?  Gospod sodnik, ce pojes kroznik  fizola, prav tako ne ves, zaradi  katerega zrna si spustil vetrove.", "Ocetovstvo in vetrovi" },
                    { 1788, true, 40, "Zakaj imajo ženske raje gripo, kot pa moške?    Ker jih gripa, četudi so grde, vseeno položi.", "Gripa ali moški" },
                    { 1750, true, 40, "Kar se žensk tiče, one imajo tri stopnje odraščanja:  1. Jezijo očeta  2. Živcirajo moža  3. Sitnarijo zetu  ", "Žensko odraščanje" },
                    { 1732, true, 40, "\"Zdaj moram pa zelo paziti, da ne dobim otroka!\" je Sonja rekla prijateljici.    \"Kako? Ali se tvoj mož ni steriliziral?\"    \"Seveda se je! In ravno zato moram paziti!\" ", "Vse so iste" },
                    { 1731, true, 40, "\"No, Jože, si se že poročil z Barbaro?\"    \"Ne, ne bom se poročil z njo!\"    \"Zakaj pa ne? Saj si jo že predstavil svojemu bogatemu stricu!\"    \"Saj ravno zato! Zdaj je Barbara moja teta!\" ", "Hitro si je premislila" },
                    { 1730, true, 40, "Se pogovarjata dve dami: \"Včeraj sem imela rojstni dan.\"    \"Čestitam. Kaj ti je mož kupil?\"    \"Vidiš audija na spodnjem parkirišču?\"    \"Jaaaa ....\"    \"No, takšne barve predpasnik.\"", "Darilo za rojstni dan" },
                    { 1669, true, 40, "S katerimi ženskami se ni dobro vezati?    Blagajničarka – vedno zahteva denar v naprej.  Sprevodnica – vedno vpije: \"Porini v sredini, da prideta noter še dva, ki sta zunaj.\"  Profesorica – vedno pravi: \"Bilo je dobro, ponoviva še enkrat.\"  Zdravnica – govori: \"Naslednji prosim.\"  Šefinja v rudniku – ukazuje: \"Pripravite se, da greste v jamo.\"  Lekarnarka – pravi: \"Dvakrat pred jedjo in dvakrat po jedi.\"  Telefonistka – pravi: \"Končajte gospod, drugače bom prekinila.\"  Kuharica – pravi: \"Mešaj hitreje, da se ne prime.\"", "Ven iz hudiča ženske" },
                    { 1655, true, 40, "Kakšna je razlika med lačno in potrebno žensko?    Razlika je samo v tem, v katero luknjo bo potisnila kumaro.", "Lakota in potreba" },
                    { 1637, true, 40, "Obilna Zofija se postavi pred čarobno ogledalo: \"Ogledalce, ogledalce na steni povej, katera nejlepša na svetu je tem!\"    Ogledalo: \"Ja, umakni se malo, nič ne vidim!\"", "Hotela je vedeti" },
                    { 1615, true, 40, "Štiri stare gospe so sedele za mizo v domu starejših, ko pride mimo njihov sovrstnik, starejši gospod.    Ena od njih mu zakliče: \"Stavimo, da točno uganemo, koliko si star!\"    Stari gospod odgovori: \"Tega pa ne boste uganile, vi stare bebaste koklje!\"    \"Ena od kokelj mu odvrne: \"Natančno ti lahko povemo. Spusti svoje hlače in gate, pa ti bomo povedale, koliko si star!\"    Malo presenečen, vendar trdno odločen, da jim dokaže svoj prav, stari gospod spusti svoje hlače in gate.    Stare gospe si ga z vseh strani dobro ogledajo, potem pa v zboru zakričijo: \"Star si točno 87 let!\"    Gospod s spuščenimi hlačami začudeno vpraša: \"Kako za vraga ste pa to uganile?\"    Z od smeha solznimi očmi mu stare gospe zakličejo: \"Včeraj smo bile na tvojem rojstnem dnevu!\"", "Pestro dogajanje v domu za ostarele" },
                    { 1569, true, 40, "Kako spravi Trobec 9 debelih bab v hrošča?    2 odspredaj, 2 odzadaj in 5 v pepelnik!", "Trobec in ženske v avtu" },
                    { 1568, true, 40, "Kako veste, katera punca nosi hlačke in katera ne?    Preprosto! Tista, ki jih ne nosi ima prhljaj na čevljih.", "Z ali brez hlačk" },
                    { 1538, true, 40, "Eva: \"Adam, ali me ljubiš?\"    Adam: \"Kdo drugi pa naj bi te?\"", "Zanima jo, ali jo ljubi" },
                    { 1316, true, 40, "Zakonca sta odšla na počitnice v ribiški rezervat na severu.    Mož je užival v ribarjenju v zgodnjih jutranjih urah.  Žena je uživala v branju.[o:p][/o:p]    Nekega jutra si je mož po večurnem ribarjenju privoščil kratek dremež. Čeprav še nikdar ni bila na jezeru, se je žena odločila in vzela njegov čoln. Nekaj časa je veslala, nato pa iz torbe potegnila knjigo in začela brati.    Mimo je priveslal šerif. Ko je videl žensko v čolnu, je zaveslal tik k njenemu čolnu in jo pozdravil: \"Dobro jutro, gospa! Kaj pa delate?\"    \"Knjigo berem!\" mu je odgovorila ... in si mislila: \"Halo - a ni očitno?\"    \"Ste na območju, kjer je prepovedano ribariti,\" jo je seznanil šerif.    \"Toda, mar ne vidite, da ne lovim rib?\"    \"To že, ampak imate pa vso opremo. Moral vas bom prijaviti.\"    \"Če boste to storili, vas bom tudi jaz prijavila - zaradi posilstva!\" se je razhudila ženska.    \"Toda, saj se vas še dotaknil nisem!\" se je uprl šerif.    \"Ja, to je že res,\" mu je odvrnila, \"vendar pa imate vso opremo.\"     NAUK: Nikdar se ne prepiraj z žensko, ki zna brati. Po vsej verjetnosti zna tudi razmišljati. ", "Oddih na jezeru" },
                    { 1283, true, 40, "Ko mine polnoč, pozvoni soseda pri vratih svoje znanke: \"Marija, a mi boš, prosim, posodila nudel' valjar?\"    \"Žal ne morem. Tudi mojega moža še ni od nikoder!!!\"", "Čaka moža" },
                    { 1255, true, 40, "Punca si daje kapljice v oči.    V levo oko dve kapljici, v desno oko dve kapljici.    Potem pa še na tamalo tri kapljice, rekoč: \"Aaaaa, ti tudi že dolgo nisi nič videla.\"", "Kapljice za oči" },
                    { 633, true, 40, "Marija je mami povedala,da ima   novega fanta.  Lepo,lepo.Iz kje pa je,kako mu je ime?  Izudin.  Kako?Iz udine je.Italijan?Cudovito,  Italijani so bili vedno premozeni  in uglajeni.  Ne.Tako mu je ime.", "italijan" },
                    { 585, true, 40, "Poglej tole pomlajevalno kremo! je Sonja rekla prijateljici. \"Kupila sem jo prejšnji teden. Resnično deluje.\"    Prijateljica: \"Kako veš?\"    Sonja: \"Vrnili so se mozolji, ki sem jih imela v puberteti.\"", "Pomlajevanla krema" },
                    { 566, true, 40, "\"Grozno! Povsod bo širil laži o meni!\"    \"Bodi vesela! Huje bi bilo ko bi naokoli trosil resnico!\"", "Trosijo laži" },
                    { 564, true, 40, "Čemu bi se lažje odrekel: ženski ali vinu?  Odvisno od letnika", "Ženska ali vino?" },
                    { 551, true, 40, "\"Zakaj imaš poviti obe ušesi?\"    \"Likal sem in je zazvonil telefon, pa sem dvignil likalnik namesto slušalke, pa sem ga prislonil na uho...\"    \"Kaj pa drugo uho?\"    \"Ja... no... hotela sem poklicati reševalce.\"", "Obvezana" },
                    { 538, true, 40, "\"Je bil tvoj zmenek z novim fantom uspešen?\"    \"Tako ... nooo .... bolj polovičarsko!\"    \"Kako to misliš?\"    \"Jaz sem prišla, njega pa ni bilo!\"", "Zmenek z novim fantom" },
                    { 524, true, 40, "\"Poročila se bom le, če najdem popolnega moškega mojih sanj.\"    \"Kakšen pa bi moral biti po tvojem mnenju popoln moški?\"    \"Biti mora zabaven, govoriti bi smel le takrat, ko bi meni to odgovarjalo, zvečer ne bo smel hoditi ven...\"    \"Rešitev zate je, da se poročiš s  televizorjem!\"", "Idealni moški" },
                    { 510, true, 40, "Zelo neaktraktivna ženska, grobih obraznih gub, povrhu pa še neprijazna, pride v nakupovalni center z svojima sinovoma, na katera neprestano šraja in ju komandira.     Portir na vratih jo pozdravi: \"Dobro jutro gospa, imate čudovita otroka.   Ali sta dvojčka?\"     Takrat ženska neha šrajat na otroka, dvigne nos in odgovori.   \"Seveda nista, starejši ima 9 in mlajši 7 let.   Zakaj misliš da sta dvojčka? Ali sta videti ista, bedak?\"     \"Ne nikakor.\" odgovori portir.   \"Samo ne morem verjeti, da Vas je nekdo nategnil dvakrat.\" ", "Neaktraktivna ženska" },
                    { 507, true, 40, "\"Zakaj sta se razšla z Bogdanom?\"   \"Ali bi hotela hoditi z nekom, ki ima spolne odnose še s petimi drugimi?\"   \"To pa ne!\"   \"No, vidiš, Bogdan tudi ne!\"", "Ločitev" },
                    { 487, true, 40, "Pepca zavistno prijateljici Štefki: \"Ohoho, kako si lepo shujšala. Kakšna nova dieta?\"    Štefka: \"Kje pa? Le krompir, korenje in fižol.\"    \"A res? Pa si vse to kuhala ali pekla?\"    \"Okopavala.\"", "Dieta" },
                    { 482, true, 40, "Kakšna je podobnost med žensko in motorko?    Ženska tudi če nima zob, ropota.", "Podobnost med žensko in motorko" },
                    { 481, true, 40, "Ko se ženske zmer hvaljo, da lahko delajo več stvari naenkat.    Zakaj potem ne morejo imeti seksa in glavobola hkrati?", "Glavobol" },
                    { 480, true, 40, "Kaj je to napotnica?    Toj tista baba, ki je u napoto!", "Napotnica" },
                    { 479, true, 40, "Sem babo domov prpelu, da bi kuhala kot mama, pa je pila kot ata.", "Domov jo je pripeljal" },
                    { 478, true, 40, "Če ti pes laja pri zadnjih vratih, baba pa se ti dere pri glavnih vratih, komu prej odpreš?    Logično, da psu!    Ko bo prišel noter, bo nehal lajat.", "Lajanje" },
                    { 477, true, 40, "Največji fenomen je babje oko, ko z desetih metrou vidi en blond las na tvoji srajci.    Samo zahudiča s pol metra ne vidi okvir garažnh vrat!", "Žensko oko" },
                    { 474, true, 40, " Baba je kot žoga: ko je enkrat preluknjana, jo je treba kar naprej pumpat!", "Ženske, kot žoga" },
                    { 472, true, 40, "Zakaj so ženske, kot alkohol?    Najprej te opije, nato pa ti gre pa na jetra.", "Ženske in alkohol" },
                    { 471, true, 40, "Zakaj so ženske, kot sadje?    Komaj postanejo zrele, je že črv v njih.", "Ženska kot sadje" },
                    { 446, true, 40, "Ženske so kot sadje - vsaka ima svoj vonj, okus, barvo in izgled.      Problem so moški - oni imajo radi sadno solato.", "Ženske so kot sadje" },
                    { 441, true, 40, "Bog je dal ženskam dar govora.    Vendar je moškim pozabil dati dar potrpežljivega poslušanja.", "Dar govora" },
                    { 436, true, 40, "Nuna: edina ženska na svetu, ki ve kaj bo jutri oblekla.", "Večno žensko vprašanje" },
                    { 394, true, 40, "\"Silva, ali misliš da ženska lahko ljubi dva moška?\"    \"Ljubi ne, vara ju pa lahko!\"  ", "Ljubezen do več moških" },
                    { 333, true, 40, "Zakaj imajo ženske prednost?    Da jih lahko fantje gledajo v ta zadnje.", "Prednost" },
                    { 323, true, 40, "Kaj ženska dobi prej, AIDS ali raka?    Odvisno kaj puši.", "Bolezni" },
                    { 322, true, 40, "Zakaj ženske živijo dlje od moških?    Ker jim je bog povrnil tisti čas, ko vzratno parkirajo.", "Ženske živijo dlje" },
                    { 313, true, 40, "Mož pridrvi iz službe domov in vpraša ženo: \"Ali se je že začela nogometna tekma?\"    Žena: \"Ja, pred nekaj minutami.\"    mož: \"Pa je že padel kak gol?\"    Žena: \"Ne, oba še stojita.\"", "Ženske in nogomet" },
                    { 308, true, 40, "\"Janja, ali si res rodila četverčke?\"    \"Da, sem. Doktor je rekel, da se to zgodi enkrat na petstotisoč primerov!\"    \"Kaj sta potem sploh še kaj drugega opčela poleg seksa?\"", "Rodila je četvorčke" },
                    { 299, true, 40, "Ženska 1: \"Zakaj si tako prepričana, da Jožef misli resno s teboj?\"    Ženska 2: \"Preprosto! Hodiva že pol leta pa se še niti enkrat ni nasmehnil!\"", "Resna zveza" },
                    { 671, true, 40, "Voditeljica aerobike se zasopihano dere: \"Dejmo punce, mejhne ritke, raven trebuh, to hočmo!\"    Se oglasi ena prešvicanih punc: \"Ne, to tipi hočjo, jst hočem čokolado!\"", "Pri aerobiki" },
                    { 690, true, 40, "Suzana je prvič videla novo prijateljico v kopalkah. Takoj prične kričati: \"Joj, kakšne grde noge imaš! In kako na \"O\" so oblikovane! Med njimi bi se lahko sprehajale svinje!\"    Prijateljica: \"No, kar sprehodi se!\"", "Prijateljica v kopalkah" },
                    { 748, true, 40, "Žensko srce je tako, kot avtobus: vedno je prostor še za enega.", "Žensko srce" },
                    { 808, true, 40, "Zakaj zenske zivijo v povprecju 7 let dalje od moskih?   Zato ker toliko casa porabijo za parkiranje.", "Zivljenjska doba" },
                    { 1246, true, 40, "1) Gre na živce očetu.    2) Gre na živce možu.    3) Gre na živce zetu.", "Tri faze v ženskem življenju" },
                    { 1240, true, 40, "DOBRO  To je beseda, ki jo ženske uporabijo, ko želijo končati prepir, v katerem imajo one prav in hočejo, da utihnete.    PET MINUT  Če se oblačijo, to pomeni pol ure. Pet minut pomeni pet minut samo takrat, ko gledate tekmo in prav toliko prostega časa vam še odmeri, preden ji morate začeti pomagati pri hišnih opravilih.    NIČ, NIČ...  To je zatišje pred viharjem. To običajno pomeni \"nekaj\" in morali bi biti previdni. Prepiri, ki se pričnejo s to frazo, se običajno končajo z \"Dobro\".    SAMO POIZKUSI  To je izziv, a ne dovoljenje. Ne poizkušajte!    GLASEN VZDIH  To ni beseda, temveč neverbalna izjava, ki jo moški pogosto narobe razumejo. \"Glasen vzdih\" običajno pomeni, da ona misli, kako ste neumni in kako se sprašuje, zakaj sploh zapravlja čas z vami. Razpravlja se tudi okoli \"Nič, nič…\".    V REDU JE...  To je ena najnevarnejših ženskih izjav. \"V redu je\" pomeni, da že razmišlja o tem, kako bi vas kaznovala za vašo napako.    HVALA  Žena se vam zahvaljuje. Ne sprašujte se zakaj , ampak samo recite \"Ni za kaj\".    VSEENO  Ženski način, da vam reče \"Jebi se\"!", "Ženski slovar" },
                    { 1233, true, 40, "Vsaka ženska ima nekaj seksi.    Nekatere oči, nekatere telo, nekatere noge in nekatere prijateljico.", "Vsaka ima nekaj seksi" },
                    { 1232, true, 40, "Kako veš, da si srečal pravo ljubezen?    Ko ti ženska izprazni jajca in ne denarnice.", "Prava ljubezen" },
                    { 1199, true, 40, "Zakaj so zenske neumne?  Ker zaradi ene klobasice vzamejo celega prasica.", "Neumne zenske" },
                    { 1188, true, 40, "Zakaj je na svetu vec zensk kot moskih?  Ker je na svetu bistveno vec za cistiti kot za misliti!", "Vec zensk" },
                    { 1187, true, 40, "Zakaj zenske ne nosijo rocne ure?  Ker je v vsaki kuhinji ponavadi stenska ura.", "Rocna ura" },
                    { 1183, true, 40, "Bog je ustvaril moskega in zensko.  Pogleda moskega in rec:  Super si izpadel!  Pogleda zensko in rece:  Hm. Sminkat se bos morala...", "Sminka" },
                    { 1177, true, 40, "Kaksen je najlepsi SMS, ki ga lahko prejmes od  zene?  Dragi, popila sem zadnje pivo. Po sluzbi se ustavi v gostilni.", "Zenin SMS" },
                    { 1172, true, 40, "Tri blondinke ujamejo zlato ribico.  Ta jih prosi, naj jo vrnejo v reko  in vsaki bo izpolnila eno zeljo.  Receno, storjeno.  Prva si je zazelela rokavcke, da bi  z njimi preplavala reko.  Dobila jih je, a se vseeno utopila  sredi reke. Druga je hotela plavalni  obroc, a tudi njej ni pomagal. Na   tricetrt poti je izginila pod   recno gladino.  Tretja si je zazelela rjave lase in  jih tudi dobila.Sedaj, ko ni bila vec   blond, se je odlocila, da bo reko  preckala cez most.", "Blondinke" },
                    { 1155, true, 40, "Zakaj imajo zenske menstruacijo?    V raju je Eva Adamu ponudila jabolko. Bog se je zelo razjezil:\"To bos krvavo placala!\"  Eva:\"Lahko v vec vojnah?\"", "Menstruacija" },
                    { 1150, true, 40, "Pepca zavistno prijateljici Stefki:  Madona, kako si lepo shujsala.  Kaksna nova dieta?  Stefka: Kje pa?   Le krompir, korenje, fizol.  A res? Pa si vse to kuhala ali pekla?  Okopavala.", "Dieta" },
                    { 1142, true, 40, "Obstaja ženska, ki ve, kaj bo jutri oblekla.    Res!    Reče se ji: nuna.", "Nemogoče je mogoče" },
                    { 1108, true, 40, "Katere zenske so najbolj zveste: blondinke, rdecelaske ali brinetke?  Sivolaske!", "Zvestoba" },
                    { 292, true, 40, "Prijateljici sta se peljali v nabito polnem avtobusu mestnega prometa.    Prva: \"Joj, kakšna gneča!\"    Druga: \"Si pa res spremenljivega mnenja. Včeraj v disku, ko je tudi bila gneča si pa rekla: Kakšna atmosfera!\"", "Poln avtobus" },
                    { 1107, true, 40, "Mlada zenska potozi zdravniku: \" Ne vem, kaj mi je. Ze tri mesece se ne pocutim najbolje, ne morem jesti in veckrat bruham.\"  Zdravnik: \" Po izvidih sodec se boste morali v kratkem porociti.\"  \" Zakaj pa se moram porociti?\"  \" Da bodo vase tezave dobile oceta!\"", "Tezave" },
                    { 1053, true, 40, "Za vsakim uspešnim moškim je ženska.    Za vsakim neuspešnim moškim sta dve ženski.", "Moški uspeh" },
                    { 1049, true, 40, "Kako vemo, da so ženske zelo nepotrpežljive?    Lepo ji poveš, da prideš čez 5 minut, potem te pa vsakih 15 minut vseeno kliče.", "Ženska nepotrpežljivost" },
                    { 1017, true, 40, "Po dolgih letih intenzivnih raziskav so znanstveniki ugotovili, kaj ženska hoče.    Potem si je pa premislila...", "Ženske želje" },
                    { 1005, true, 40, "Kaksna je razlika med zensko in kukavico?  Kukavica nosi svoja v tuje gnezdo, zenska pa nosi svoje gnezdo pod tuja jajca.", "Zenska in kukavica" },
                    { 1001, true, 40, "Sabina vsa v joku pride k prijateljici  in ji rece:  Roman je navadna baraba.  Kako?Kaj ti je naredil?  Sinoci je ostal pri meni in  sva se ljubila celo noc.  Ko je zjutraj odhajal,mi je  dal vrtnico in rekel:  Ko se ta vrtnica posusi,se  vrnem v tvoj objem.  Ja in?  Vrtnica je plasticna.", "Vrtnica" },
                    { 991, true, 40, "Doktor zeli pomiriti pacientko: Po lepotni operaciji boste tako lepi, da vas nihce vec ne bo prepoznal.  Pacientka: Joj, gospod doktor samo tega ne. Naj ljudje vidijo, kdo je tako lep. ", "Po operaciji" },
                    { 962, true, 40, "Pepca na stopnicah sreca sosedo.  Nekaj casa jo gleda,potem pa  le vprasa:  Maja,zakaj imas modrico okrog  oci?  Moz me je...  Pepca:Sem mislila,da je na  potovanju.  Soseda Maja:Jaz tudi.", "Modrica" },
                    { 941, true, 40, "Zakaj imajo moški raje pištolo, kot pa žensko?    Na pištolo lahko daš dušilec.", "Ženska proti pištoli" },
                    { 932, true, 40, "Bog je ustvaril zensko in za mnenje vprasal kiparja, slikarja in arhitekta.  Kipar: Lepa je, vendar bi lahko bila nekoliko bolj zaobljena v bokih in prsih.  Slikar: Ja, res je lepa, vendar bi lahko bila nekoliko bolj rumena v obraz.  Arhitekt: Kaj, to sploh ni po predpisih! Prostor za igro je tik ob sanitarnih dovodih.", "Bog je ustvaril zensko..." },
                    { 929, true, 40, "Kaksna je razlika med telefonom in zensko?  V telefon vrzes kovanec in lahko govoris, zenski das celo placo pa moras bit se vedno tiho.", "Telefon in zenska" },
                    { 909, true, 40, "Štiri prijateljice so se pogovarjale o svojih soprogih.    \"Jaz sem pri svojem možu našla ženske spodnje hlačke!\" je rekla prva.    \"Jaz pa sem v njegovem suknjiču odkrila fotografijo, na kateri je v družbi s pomanjkljivo oblečeno žensko\" je rekla druga.    \"Jaz sem pa svojemu preluknjala kondom!\" se je oglasila še tretja.    Ob zadnjih besedah je četrta padla v nezavest.", "Žene debatirajo o svojih moških" },
                    { 893, true, 40, "Če bi ženske vedle, koliko stanejo traktorji, ne bi več palile na šminkerske BMW-je in Mercedese.", "Nevednost" },
                    { 869, true, 40, "Zenska je res cudno bitje.  Neprestano gleda v ogledalo, samo takrat ne,  ko z avtom vozi vzratno. ", "Ogledalo" },
                    { 867, true, 40, "Zenska je res cudno bitje.  Kar naprej gleda v  ogledalo,samo takrat ne,ko  z avotom vozi nazaj.", "Ogledalo" },
                    { 1083, true, 40, "Kaksna je razlika med  Bosanko in Slovenko?  Bosanka ti opere noge,  Slovenka pa mozgane.", "Razlika" },
                    { 330, true, 41, "Kaj je rdeče in zeleno pa gre 100 na uro? Žaba v mikserju", "Hitrost" },
                    { 30, true, 37, "Mož in žena gresta v opero, ona mu pravi: \"Šlic imaš odprt.\"     On: \"Veš, kaj to pomeni?\"     \"Ne.\"     \"To je uvertura v Čarobno piščal.\"", "Odprt šlic na poti v opero" },
                    { 1918, true, 36, "Vojak z daljnogledom ogleduje okolico in zavpije: \"Komandant! Približujejo se nam vojaki s tanki!\"    \"So sovražniki ali prijatelji?\"    \"Verjetno so prijatelji, ker vozijo tako skupaj!\" ", "Na fronti" },
                    { 661, true, 28, "\"Zakaj si tega človeka pozdravil z dober večer, ko pa je šele jutro?\"    \"Zato, ker se mi stemni, ko ga vidim.\"", "Pozdrav" },
                    { 544, true, 28, "Američan, Rus in Slovenec pred bogom.  Američan: \"Kdaj bomo mi prišli iz krize?\"  Bog: \"Čez 50 let!\"  Američan pade v jok: \"Tega jaz ne bom dočakal!\"  Rus: \"Kaj pa mi? Kdaj mi zlezemo iz krize?\"  Bog: \"Čez 70 let!\"  Rus obupano, v joku: \"Ajej, tega na bom dočakal!\"  Slovenec: \"Pa mi? Kako kaže Slovencem?\"  Bog pade v jok, solze lijejo, Slovenec ga začudeno gleda in vpraša: \"Ja zakaj pa ti jokaš???\"  Bog ihteče: \"Zato, ker tega pa niti jaz ne bom dočakal!!\"", "Slovenija v krizi" },
                    { 542, true, 28, "Pride Konec sveta v Slovenijo.  Se malo razgleda naokoli in reče: \"Zgleda da sem tukaj že bil...\"  In gre naprej.", "Konec sveta" },
                    { 495, true, 28, "Prvi dan šole nekje v Ljubljani, Slovenija, leta 2020.    Učitelj preverja prisotnost učencev:  \"Mustafa al Eih Zeri?\" - \"Ovdje.\"  \"Achmed El Kabul?\" - \" Ovdje.\"  \"Fatima Bin Pardin? \" - \" Ovdje.\"  \"Ali Abdul Olmi?\" - \" Ovdje.\"  \"Mohammed Bin Kadir?\" - \" Ovdje.\"  \"Al Jabla Zic?\" - Tišina v razredu.    \"Al Jabla Zic?\" - Tišina se nadaljuje,vsi gledajo okoli sebe po razredu.    Učitelj ponovi vprašanje:\"Al Jabla Zic?\"    Deklica v drugi vrsti se javi: \"Oprostite, učitelj, mislim da sem to jaz, ampak prebere se Alja Blažič\"", "Prisotnost pri pouku" },
                    { 437, true, 28, "Slovenci smo kot tamponi.    V prelepem kraju vendar v slabem obdobju!", "Slovenci" },
                    { 398, true, 28, "V New Yorku so aretirali ljubljančana, ker je na letališču pri prtljagi vpil: \"A LAH SAM MAL?\"", "Ljubljančan na letališču" },
                    { 387, true, 28, "Gospod doktor! Včeraj ko sem se peljal domov sem nenadoma začutil bolečino.”  “Kje pa?”  “Mislim da je bilo to med Vranskim in Trojanami.”", "Bolečina" },
                    { 360, true, 28, "Gre delegacija poslovnežev iz firme na kitajsko.    Med sestankom gredo na kosilo. Med pogovorom kitajec vpraša slovenca o številčnosti delegacije: \"Koliko pa vas je?\"    Slovenec misli, da ga sprašuje o številu vseh slovencev: \"Dva milijona.\"    Kitajec: \"A res? V katerem hotelu ste pa nastanjeni?\"", "Slovenska delegacija na kitajskem" },
                    { 356, true, 28, "Zakaj je za Slovence vsaka nogometna tekma mednarodna?    Ker kote izvajajo v sosednjih državah!", "Mednarodna tekma" },
                    { 353, true, 28, "Dolenjec, Štajerec in Gorenjec so sedeli na vrtu gostilne in naročili pivo. Natakar je pred goste postavil vrčke piva, v vsakem pa je plavala muha.  Dolenjec je opazil muho, segel s prsti v vrček, prijel muho in jo odvrgel stran. Štajerec prav tako. Gorenjec pa je muho previdno prijel, jo držal nad vrčkom in zavpil:  “No, izpljuni že – toda vse!” Jasno?", "Muha v pivu" },
                    { 339, true, 28, "Ropar je oropal banko. pa vpraša prvega:    ”si videl kaj sem naredil?” tip mu odvrne:”ja” in ropar ga ustreli.     isto vpraša drugega, tip reče ja in ropar ga ustreli.     isto se zgodi s tretjim.     četrti pa reče:”jas nisem nič videu. moja žena pa je!!", "Ropar" },
                    { 336, true, 28, "Jožko: Zdravo Miha sem slišal da ti je umrla tašča. Kaj pa je imela?  Miha:  hišo,delnice,ferarijaa..  Jožko: mislim, kaj je bilo narobe?  Miha:  ja lahko bi imela še kakšno stanovanje ob morju...  Jožko: ne,človek zakaj je umrla?  Miha:  sem jo poslal v klet po krompir za kosilo pa je padla po stopnicah in si zlomila vrat.  Jožko: joj strašno.kaj pa ste potem naredili?  Miha:  MAKARONE", "Tašča" },
                    { 282, true, 28, "Človek teče za avtobusom in vpije: \"Počakajte prosim, zamudil bom v službo!\"  Potniki začnejo vpiti vozniku:   \"Počakaj ga, zaustavi!\"  Voznik: \"Ne smem na cesti...\"  Potniki: \"Ne bodi kreten, ustavi vendar!!!\"  Voznik res zaustavi in človek vstopi. Ko avtobus odpelje, se človek oddahne, potegene izkaznico in pravi:   \"Karte na pregled!\"", "Karte na pregled" },
                    { 277, true, 28, "Sosed se je napotil k sosedu Milanu, ki je imel na vrtu novega psa.    Pozvonil je pri vrtni ograji, Milan pa je rekel: \"Kar pridite in vstopite!\"    Sosed: \"Ne upam si! Ne vem, če me bo vas pes napadel!\"    Milan: \"Tega tudi jaz ne vem, sem pa res radoveden, kako se bo to končalo!\"", "Nima rad soseda" },
                    { 118, true, 28, "Kaj pravi pohorc v lekarni?    Dajte mi en lekadol, pa vi si še nekaj vzamite.", "Pohorc v lekarni" },
                    { 2074, true, 27, "Prijateljici se pripravljata na zabavo v planinski koči.    Planinska koča je polna fantov.    Ko se približata koči, ena izmed njiju reče: \"Joj, saj ti nimaš pod plaščem sploh ničesar oblečenega!\"    Pa jo vpraša prva prijateljica: \"Seveda ne. A si ti kdaj vstaviš vato v ušesa, ko greš na koncert?\"", "Pripravljena na vse" },
                    { 2071, true, 27, "Kakšna je razlika med ljubico in ženo?    30 kilogramov.    Kakšna pa med ljubimcem in možem?    30 minut.", "Razlika" },
                    { 2045, true, 27, "Kaj rece kurac kondomu?    \"Pokrij me, jaz grem noter!\"", "Prošnja" },
                    { 2017, true, 27, "Zjutraj se v kopalnici mladi par pripravlja za službo.    Moški se brije brado rekoč: \"Danes se bom, v službi, dogovoril za povišico.\".    Žena si pod tušem brije tamalo in odgovori: \"Jaz tudi.\".", "Povišica" },
                    { 2014, true, 27, "Prijateljici na kavi se pogovarjata: \"Ali ti vedno poveš svojemu možu, ko doživiš orgazem?\"    \"Kje pa! On ne mara, da ga pokličem, kadar je v službi!\"", "Komunikacija" },
                    { 2013, true, 27, "Blažen, s cigareto v roki, v tišini zatemnjene sobe Janez reče Marjani: \"Sodeč po temle, kar sem doživel in videl nocoj, nisem tvoj prvi.\"    Marjana mu odgovori: \"Eh, kje pa! In sodeč po tem, kar sem doživela in videla jaz nocoj, tudi ne boš zadnji.\"", "Po opravljenih posteljnih užitkih" },
                    { 2009, true, 27, "Po napadu malih zelenih Marsovcev se srečata parčka.    Zemljan se želi postaviti pred malim Marsovcem, ki mu je komaj do kolen, in predlaga: \"Kako bi bilo, če bi zamenjala ženi?\"    Marsovec se strinja.    Zemljanka pride v sobo in reče: \"Pa kaj boš ti mali, poglej se kakšnega imaš.\"    Marsovec pravi: \"To pa res ni problem. Ti samo povej, kakšnega si želiš.\"    Potem se začne tolči po čelu in one raste.    Zemljanka reče: \"Dobro. A kaj, ko je tako tanek.\"    Marsovec se začne vleči za ušesa in one se debeli...    Ko prideta Zemljana spet skupaj, mož vpraša ženo, kako je bilo?    Ona odgovori: \"Presenetljivo dobro!\"    Mož pa razočaran odvrne: \"Pri meni pa slabo. Ne vem, zakaj me je Marsovka kar naprej tepla po čelu in vlekla za ušesa?!\"", "Izmenjava" },
                    { 1956, true, 27, "Mož se v spalnici ogleduje pred ogledalom: \"Če bi imel samo dva centimetra daljšega, bi pa lahko rekel, da sem kralj,\" reče ženi.    Žena mu odgovori: \"Ja, če bi imel pa dva centimetra krajšega, bi bil pa kraljica!\"", "Dolžina penisa" },
                    { 1953, true, 27, "\"Včeraj sem seksal s policistko,\" se Polde pohvali Lojzetu.    \"Ali si ti že kdaj?\"    \"Ne, bojim se,\" pravi Lojze.    \"Česa se bojiš?\"    \"Da bi me kaznovala zaradi hitrosti!\"", "Seks s policistko" },
                    { 1940, true, 27, "Polde razlaga Stanetu: \"Moja žena je zaradi hujšanja začela jahati.\"    \"Pa se že kaj pozna?\"    \"Ja, konj je že shujšal za 10 kilogramov.\"", "Hujšanje" },
                    { 1919, true, 27, "\"Žena, zakaj mi nikoli ne poveš, ko doživiš orgazem?\"    \"Ker te takrat nikoli ni doma!\"", "Doživljanje orgazma" },
                    { 1840, true, 27, "Reče deklica fantu: \"Sem slišala veliko tebi, kakšen si v postelji.\"    \"Daj no, nsaj ni nič posebnoega.\"    \"Ja, prav to sem slišala.\"", "Kakšen je v postelji" },
                    { 1712, true, 27, "Marija sedi v baru in k njej pristopi   moski, ki jo ogovori:  Ali vam lahko placam pivo?  Ne, hvala. Pivo ni dobro za moje noge.  Ali vam otecejo?  Ne. Ne razmaknejo se dovolj...", "Pivo" },
                    { 1692, true, 27, "Po divjem seksu mož ženi jezno zabrusi: \"Kje si se naučila tako divje seksati, in vseh teh vragolij?\"    Žena: \"Ne vem, malo sem gledala porno filme.\"    Mož: \"Ne laži! Jaz tudi gledam nogometne tekme, pa ne igram, kot Ronaldo.\"", "Prava profesionalka" },
                    { 682, true, 28, "V sosednjih hišah sta stanovala Štajerc in Ljubljančan.    Štajerc je imel kokoš, ki je na dvorišču vsako jutro znesla jajce, ki jo je Štajerc pobral in si pripravil zajtrk.    Neko jutro pa je kokoš znesla jajce na dvorišču Ljubljančana.    Ko je Štajerc krenil ponjo, jo je pobral Ljubljančan.    Štajerc: \"Daj mi jajčko!\"    Ljubljančan: \"Kako, saj je moja, kokoš jo je znesla na mojem dvorišču.\"    \"Ampak, kokoš je moja!\"    \"Dvorišče pa moje!\"    \"Vidim, da takole ne boma prišla nikamor ... pri nas na Štajerskem rešimo takšnele primere na zelo enostaven način ...\"    \"Kako reče Ljubljančan?\"    \"Najprej bom jaz tebe brcnil v jajca pa štopal, koliko boš rabil, da se pobereš, nato boš ti mene in štopal.    Kdo se bo prej pobral, njegova je jajčka!\"    \"Velja!\"    Gre Štajerc po najtežje delovne čevlje s kovinsko kapico, vzame zalet in v stilu Oliverja Birschoffa brcne Ljubljančana v moda, z vso močjo.    Ljubljančan pade in se v agoniji zvija 32 minut in 18 sekund.    Nato se Ljubljančan opremi, vzame zalet, nakar mu Štajerc pravi:    \"Ah, naj ti bo, obdrži jajčko, bom marmelado pa kruh jedel!\"", "Ljubljančan in štajerc" },
                    { 1664, true, 27, "Topla poletna noč, on in ona ležita na travniku ob jezeru: \"Peter, po dopustu moraš takoj k okulistu.\"    \"Zakaj pa?\"    Že pet minut ližeš travo!!!", "Vroča poletna noč" },
                    { 688, true, 28, "Srečata se Ljubljančan in Mariborčan.    Ljubljančan začne nagajati in dražiti Mariborčana. Ta se razhudi ...    Mariborčan: \"Čuj, imaš ti kaj proti Štajercem?\"    Ljubljančan: \"Ah, nekoč sem imel neke tablete pa, žal, niso nič pomagale ...\"", "Ljubljančan in štajerc" },
                    { 1087, true, 28, "Korel prijatelju Poldetu:  Slisal sem, da je zavest nasih  drzavljanov o koristnosti  cepljenja proti gripi zadnje tedne  skokovito narasla.  Polde: Bo drzalo.  Sinoci sem videl enega, ko se je  za garazo kar sam cepil.", "Gripa" },
                    { 1462, true, 29, "Moj oci je mizar! Kaj pa tvoj dela?  Vse, kar mu rece mamica.", "Kaj dela oce" },
                    { 1443, true, 29, "Kateri je najtezji dan v letu uradnika?  Prvi spomladanski dan, ko mora preklopiti iz zimskega spanja v pomladansko utrujenost.", "Najtezji dan" },
                    { 1418, true, 29, "Se pogovarjata dva direktorja.  A svojim delavcem se izplacujes  placo?  Ne, ze dolgo ne, ampak oni kar  delajo.  Tudi jaz mojih ne placujem, pa  vseeno redno prihajajo na delo.  Imam odlicno poslovno idejo.  Kaj ce bi jim zacel pri vratih  zaracunavati vstopnino?  Se ne obnese. Sem ze poskusil.  V sluzbo so prisli v ponedeljek  in delali vse do petka.", "Placa" },
                    { 1370, true, 29, "Spomladi je konec zimskega spanja za javno upravo!    Takrat je na vrsti spomladanska utrujenost.", "Javna uprava" },
                    { 1360, true, 29, "Tajnici iz Maribora se pogovarjata.  Vceraj me je sef peljal v Ljubljano.  Potem pa ti je prav gotovo pokazal zmaja.  Ja, ze v Celju.", "Zmaj" },
                    { 1274, true, 29, "Korel se oglasi pri svojem sefu:  Sef, ze dvajset let delam pri vas  in ves cas delam za tri.  Ali mi res ne bi mogli povisati  place?  On: Ne, ni sans! Povejte mi raje   imena tiste dvojice, namesto katerih  delate, da ju bom postavil na cesto!", "Delam za tri" },
                    { 1260, true, 29, "Direktor stoji pred uničevalcem dokumentov s šopom papirjev v rokah.    Mimo pride ena uslužbenka in vpraša: \"Lahko pomagam?\"    Direktor: \"Moja tajnica je na bolniški, pa ne vem, kako to deluje?\"    \"Preprosto,\" pravi uslužbenka, vtakne papirje v režo in požene stroj.    Ko stroj konča, direktor pravi: \"Pa je res preprosto. In kje so zdaj kopije?\"", "Direktor in mašinerija" },
                    { 1259, true, 29, "Direktor delavca odpusti z besedami: \"Res mi je žal, bili ste mi, kot sin.\"    Delavec: \"Ne razumem, kako to mislite?\"    Direktor: \"Predrzen, zadirčen, nehvaležen, nesposoben in len.\"", "S težavo so ga odpustili" },
                    { 1184, true, 29, "Postni upravnik pravi svojemu  postarju: Danes ne bos nosil poste,   ker prevec pada dez. Cez dve uri pride  postar, premocen do kosti, in upravnik  ga vprasa:  Kje si pa bil,da si tako moker?  Okrog po hisah sem sel povedat,   da danes ne bo poste...", "Dez" },
                    { 998, true, 29, "Polde isce sluzbo.  Torej je vse urejeno,mu rece sef  kadrovske sluzbe,jutri lahko  zacnete.  Placani boste po ucinku.  Polde v trenutku pograbi svoje  papirje z mize.  Zal mi je,z drobizem nebom  mogel ziveti.", "Polde" },
                    { 942, true, 29, "Zdravnik medicine dela pregleduje  delavca na posti in ga sprasuje:  Ali ste zadovoljni s svojim  delom?Zelo.  Kaj pa delate?  Znamke zigosam.  To je pa dolgocasno?  Nikakor ne.  Vsak dan je drugi datum.", "Zadovoljstvo" },
                    { 923, true, 29, "Janez pride s plačilnim listom v šefovo pisarno: \"Šef, pri seštevanju ste se zmotili in mi nakazali 200 evrov premalo.\"      \"Vem,\" pravi šef, \"prejšnji mesec sem se tudi zmotil in ti nakazal 200 evrov preveč. Takrat se pa nisi pritožil.\"      Janez: \"Poglejte, ena napaka se še oprosti, ampak dve so pa že preveč!\"", "Napaka pri plači" },
                    { 840, true, 29, "Mojca direktorju po prvem tednu sluzbe:  Veste,ce sem iskrena,sem si vas  pred prihodom cisto drugace  predstavljala.  Direktor:Ja,najbrz grdega,debelega,  s podbradkom in se starega povrhu.  Ona:Ne,obratno!  Vitkega,lepega in mladega.   ", "Direktor" },
                    { 779, true, 29, "70-letna  babica okara 25-letno vnukinjo: \"Da boš vedela, jaz sem pri TVOJIH   letih že hodila v službo!\"Vnukinja ji odvrne: \"So what, jaz bom pa pri   TVOJIH", "Služba " },
                    { 768, true, 29, "V zavodu za zaposlovanje se je oglasil brezposelni, tam pa so ga usmerili v podjetje, kjer so potrebovali novo delovno moč njegovega profila.    Med razgovorom z vodjo kadrovske službe je kadrovik povedal: \"Pri nas vsak dan delamo od 7. do 16. ure, delo ni težko, delamo 35 ur na teden in vsi delavci pri nas imajo najmanj 35 dni letnega dopusta. Ste bili v prejšnjih službah kaj odsotni zaradi bolniškega staleža?\"    \"Ja, toda samo enkrat, ko so bi operativno odstranili jajca.\"    \"Kaj? Jajc nimate? Potem pa lahko hodite v službo šele ob 9. uri zjutraj. Pri nas si namreč do devetih praskamo jajca.\"", "Nova služba" },
                    { 676, true, 29, "Mornar pride v hotel in naroči: \"Enoposteljno sobo brez pogleda na morje, prosim. Sem na dopustu!\"", "Razgled" },
                    { 650, true, 29, "Delavec: \"Šefe, tako slabo plačo imam, da se še poročiti ne morem!\"    Šef: \"Ne sekirajte se. Čez nekaj let mi boste zaradi tega hvaležni.\" ", "Nizka plača" },
                    { 647, true, 29, "\"Izgubil sem delo nočnega čuvaja.\"    \"So te zalotili, ko si spal?\"    \"Ne.\"    \"Kaj pa je potem bilo narobe?\"    \"Šef me je vprašal, kaj sem sanjal - in jaz, bedak, sem mu povedal.\" ", "Odpustili so ga" },
                    { 615, true, 29, "Ravnatelj in ravnateljica sta šla skupaj na poslovno kosilo, na katerem so bili glavna specialiteta polži.    Drugi dan je tajnica razlagala blagajničarki: \"Naš ravnatelj pa res nič ne zna. Ali veš,da je jedel polže kar s hišicami vred!\"    Ravnatelj pa razlaga hišniku: \"Naša tajnica je nemogoče pohotna. Ves večer me je gledala globoko v oči, me brcala pod mizo in mi šepetala: ven ga daj!\"", "Poslovno kosilo" },
                    { 565, true, 29, "\"Včeraj so me odpustili iz službe, in to samo zato ker sem občasno izginil za kakšno urico v skladišče materiala.\"    \"In samo zato so te odpustili?\"    \"No... z menoj je bila vedno šefova žena!\"", "Odpustili so ga" },
                    { 549, true, 29, "\"Kako je kaj s tvojo nespečnostjo?\"    \"Vedno slabše! Zdaj še v službi ne morem več spati!\"", "Nespečnost" },
                    { 470, true, 29, "Šef je delal plan letnih dopustov, kar je zelo zahtevno in zoprno delo.    Pa vpraša Lojzeta: \"Ti, a maš rad 'topu pir?\"    Lojze: \"Ne, to pa ne!\"    Šef: \"Kaj pa prešvicane babe?\"    Lojze: \"Uf, groza, to pa sploh ne!\"    Šef: \"No, ti greš januarja na dopust!\"", "Razporeditev dopusta" },
                    { 222, true, 29, "Delavec je na zid podjetja napisal: \"Naš šef je nor!\"    Na sodišču so ga obsodili na 1 dan, 1 mesec in 1 leto zapora.      1 dan,ker je popackal zid.  1 mesec, ker je pribor za pisanje in barve ukradel v podjetju.  in 1 leto pa zato, ker je razkril poslovno skrivnost!", "Jezen delavec" },
                    { 189, true, 29, "Direktor je, potem, ko je bil operiran, predsedniku sindikalne podružnice poslal e-mail:  \"Kako v podjetju poteka delo in poslovanje brez mene? Kdo opravlja moje delo? Pazite, da sedaj, ko me ni, ne bo kakšnega štrajka. Vrnem se hitro!\"    Predsednik sindikalne podružnice mu je odgovoril:  \"Vaše delo smo si razdelili takole:  - na poslovna kosila hodi Peter,   - golf igra Rajko,   - vašo tajnico pa položim kar sam.  Bodite brez skrbi: Stavkali ne bomo, dokler se ne vrnete. Zato nič ne hitite!\"", "Direktor v boilnišnici" },
                    { 2113, true, 28, "Zakaj Slovenci ne smemo v vesolje ?  Ja ker bomo najprej ukradli celo  osončje, kasneje pa celo galaksijo.  Potem pa pošten policaj reče:   Ne narobe !?  Naši bodo ukradli raketo še   preden bomo sploh šli gor !  Potem pa vsi v SLO iščejo raketo  a vsi vejo kdo jo je sunil !", "Slovenci in vesolje" },
                    { 2112, true, 28, "Zakaj Slovenci na položajih  ne nosijo spodnjega perila ?  Da se lahko kvalitetno  kjerkoli, kadarkoli in   kakorkoli kvalitetno  userjejo !", "Elita na položaju" },
                    { 2077, true, 28, "Trije Slovenci se zmenijo, da bodo imeli piknik.    Primorec obljubi, da bo prinesel pršut.    Dolenjec obljubi, da bo prinesel cviček.    Gorenjec pa obljubi, da bo pripeljal nekaj svojih prijateljev.", "Piknik" },
                    { 1353, true, 28, "Malomeščanski sosedi opravljata: \"A ste videli Labodje jezero?\"    \"Sem. Ampak morje je pa le morje!\"", "Sama hvala jih je" },
                    { 1270, true, 28, "Gorenjec  in  Štajerc  se  odpravita  v  gore.    Bila je zima in zgodilo se je, da ju je zasul snežni plaz.    Po dolgem razkopavanju snega, se nekako prebijeta na površje in tam ju je čakal  velik  bernardinec  z  sodčkom ruma okoli vratu.    Gorenjec ves vesel vzklikne: \"Oh, poglej, človekov najboljši prijatelj!\"    Štajerc pa takoj za njim: \"Pa kako lepi pes ga je prinesel!\"", "Plaz v gorah ju je zasul" },
                    { 1073, true, 28, "Nadzornik pride k hudiču, ki upravlja kotle, v katerih se cvrejo nesrečniki. Pri vseh kotlih so stražarji, ki budno pazijo, da kdo iz kotla ne uide. Le pri enem ni niti enega stražarja.    Nadzornik takoj: \"Aha, kaj pa je s tem kotlom? Zakaj tukaj ni stražarjev?\"    Upravljavec mirno: \"V tistem so Slovenci, ko eden malce zleze ven, ga drugi hitro potegnejo nazaj notri.\"", "V peklu" },
                    { 1624, true, 27, "Silvestrovo, v pričakovanju novega leta, v upravni stavbi podjetja.    V zatemnjeni pisarni ležita dva, moški in ženska, v udobnem naslonjaču. Sliši se nežno in strastno sopenje.    \"Joj, Tone, Tone, še nikdar me nisi tako ljubil! Ali je danes tako dobro zaradi novoletnega razpoloženja?\"    \"Ne, to je najbrž zato, ker jaz nisem Tone!\"", "Dobro se je odrezal" },
                    { 1620, true, 27, "Mož: \"Si za seks, tako na hitro?\"    Žena: \"Kako pa praviš temu, kar ponavadi delava?\"", "Mož bi na hitro" },
                    { 1610, true, 27, "Sinoči sem spal s postavno gospodično.    Izgleda, da ji je bilo zelo všeč, saj je podala vsem: staršem, prijateljem, policiji, ...", "Zelo sem zadovoljen" },
                    { 824, true, 27, "Mujo se pozno zvecer vrne domov  in rahlo opit skoci k zeni v posteljo.  Ta pa nic in je hladna kot spricer.  Zato ji on besno rece:  Pa kateri kurac ti je danes?  Ona nazaj:  Tretji.", "Hladn zena" },
                    { 800, true, 27, "Se pogovarjajo Anglez, Francoz in Bosanec kateri polozaj imajo najraje pri seksu.  Anglez: Meni je najbolj vsec, da sem jaz na vrhu, da gledam njen angelski obraz.  Francoz: Meni je najbolj vsec, da je ona na vrhu, da lahko obcudujem njene bozanske prsi.  Bosanec: Meni je najbolj vsec od zadaj, da lahko zraven gledam nogometno tekmo.", "Polozaji" },
                    { 781, true, 27, "Tone se pelje s traktorjem  na njivo in dohiti  sosedo Reziko.  Sedi k meni na traktor,  bos hitreje na cilju.  Seveda,da me bos potem  nadlegoval.  Ne bom te,castna beseda.  Zakaj me pa potem vabis k sebi  na traktor.", "Nadlegovanje" },
                    { 769, true, 27, "Po končani ljubezenski igri na samotni plaži,vpraša mladi Dalmatinec v polomljeni angleščini svojo ljubico:\"Ju finiš?\"    Tudi dekle ni obvladalo angleščine in pravi:\"No, dojč\" ", "Na plaži" },
                    { 752, true, 27, "Zakaj je glavica od penisa roza barve?    Zato, ker se punčke igrajo z njo.", "Barva glavice" },
                    { 747, true, 27, "Zakaj vedno moški zaprosi žensko?  Ker če bi ženska padla na kolena pred moškega, bi si ta začel odpenjat zadrgo.", "Kdo bo koga?" },
                    { 704, true, 27, "\"Kje je najlepše?\" je vprašal učitelj učence.   \"V postelji z lepo žensko!\" se je oglasil Mihec.   \"Da te ni sram!\" je vzrojil učitelj. \"O tem bom obvestil tvojega očeta! \"je dejal in mu v beležko napisal, kaj se je zgodilo.   Ko je Mihec naslednji dan prišel v šolo, ga je učitelj vprašal: \"In kaj je rekel tvoj oče na tvoje včerajšnje obnašanje?\"  \"Moj oče se strinja z menoj. Rekel pa mi je tudi, da, če ste vi drugačnega mnenja, naj se vas pazim!!!!\"", "Kje je najlepše?" },
                    { 686, true, 27, "Mlad par je bil v strastnem objemu, ko se je na vhodnih vratih zaslišalo škrtanje ključa.    Mladenka je prestrašeno odskočila in zakričala: \"O Bog, moj mož! Hitro, skoči skozi okno!\"    Mladi fant, tudi pošteno prestrašen, je planil proti oknu, nato pa se je ustavil. \"Ne morem\" je rekel, \"sva v trinajstem nadstropju!\"    \"Za božjo voljo,\" je obupano zakričala ženska, \"Ali misliš, da je sedaj čas za jebeno vraževernost?\"", "Zalotili so ju" },
                    { 678, true, 27, "V hotelsko sobo vdre ženska srednjih let in na postelji zagleda par, kako si izkazuje ljubezen.    \"Kako si pa dovolita kaj takega? Je soba morda vaša?\" se brani mladenka.    \"Soba že ne, moški, ki je z vami, pa je!\"", "V hotelski sobi" },
                    { 635, true, 27, "Žena predlaga možu, da bi v spalnici, pri posteljnih užitkih, preizkusila kaj novega.    Mož predlaga, da bi on splezal na omaro, ona bi ležala na postelji na hrbtu in on bi skočil na njo.    Žena se takoj strinja.    Mož spleza na omaro in skoči na ženo.    Ona: \"Uuuuuuuuhhh, tole je bilo pa dobro, popolnoma nekaj novega! Daj še enkrat!\"    On: \"Počakaj, moram prvo nogo ven dobit.\"", "Nekaj novega" },
                    { 621, true, 27, "Znanstvenik, ki z anketami raziskuje spolno življenje, pokliče eno od anketirank.    Veste , tu je pa nesporazum. Pod vprašanjem, kako pogosto seksata, je mož napisal dvakrat tedensko, vi pa večkrat dnevno, pretežno ponoči.    \"Ne, gospod! To je samo začasna situacija, dokler ne odplačava stanovanja\", mu odgovori žena .", "Raziskava o seksu" },
                    { 620, true, 27, "Mladi, neizkušen v ljubezni, fant se poroči.    Po poročni noči se zbudi in zagleda zraven sebe nevesto, ki si češe lase.    Ko dvigne roke, pod pazduho mož zagleda dlake.    Pri sebi reče: \"Kako sem jaz srečen, kar tri pičke ima.\"", "Neizkušen mož" },
                    { 619, true, 27, "Gresta župnik in nuna s kamelo po puščavi, pa kamela crkne.    Nuna: \"No zdej k sva sredi puščave, bi pa vsaj enkat rada vidla nagega moškega!\" Pa se župnik sleče.    Župnik: \"No prov. Se bom sleku.\"    Nuna: \" Ja kaj maš pa tist tam dol?\"    Župnik: \"lej. Če ti to zapičm u rit ti podarim življenje!\"    Nuna: \"Ja zakaj pa to nis že prej povedal! Dej ga zapič kameli u rit da greva lahko naprej!\"", "Nuna in župnik v puščavi" },
                    { 616, true, 27, "Mlado dekle si kupi vibrator.    Odločila se je, da ga takoj preizkusi.    Ko ga vključim se vibrator začne trest.    Punca: \"Kaj se treseš, saj zame bo tudi prvič!\"", "Nakup vibratorja" },
                    { 613, true, 27, "Marija je ob potoku prala perilo. Ko je bila tako sklonjena je mimo prišel Janez, se ji potihem približal, nato pa ji hitro dvignil krilo in jo napadel od zadaj.    \"Kaj pa je zdaj to?\" je jezno vprašala Marija.    \"Ali hočeš, da ga dam ven?\" je vprašal Janez.    \"To ne, toda drugič me prej vprašaj!\" ", "Pri pranju perila" },
                    { 611, true, 27, "Slovenski raziskovalci in izumitelji so iznašli lepilni trak, ki pripomore, da moški bolj uživajo v seksu.    Lepilni trak se čvrsto nalepi preko ženskih ust! ", "Iznajdba" },
                    { 610, true, 27, "Kaj mislijo ženske pri seksu?    Mlada dekleta mislijo: \"Upam, da ne bom dobila otroka!\"    Ljubice mislijo: \"Morda mi bo pa kupil krznen plašč!\"    Zakonske žene pa mislijo: \"Odejo bo potrebno zašiti!\" ", "Ženske misli" },
                    { 582, true, 27, "V resnih, dolgoročnih in trajnih zvezah obstajajo tri vrste seksa:    1. faza: Stanovanjski seks traja prvo in drugo leto zveze. Seksa se povsod in vedno. Seksa se v postelji, na kavču, na stolu, mizi, pod mizo, na tleh, na pralnem stroju (ob centrifugi...), ob vseh mogočih urah, v vseh pozah in po celem stanovanju...    2. faza: Prostorski seks nastopi v tretjem in traja nekako do sedmega leta zveze. Seks je sedaj omejen samo na en prostor, vedno v postelji, vedno v spalnici vedno ena in ista rutina, vedno zvečer...    3. faza: Dnevnosobni seks traja od sedmega leta naprej (v določenih primerih lahko ta faza nastopi tudi prej!!!). To je zadnja stopnja v razvoju spolnega življenja med partnerjema, izgleda pa približno takole: slučajno gresta eden mimo drugega, ko se srečata na sredini sobe, se pogledata v oči in si mirno rečeta: \"Jebi se!!!\"", "Tri vrsta sexa" },
                    { 562, true, 27, "Fant in dekle se peljeta z vlakom, ki zapelje v zelo dolg predor. Ko so spet prišli na svetlo, fant zašepeta dekletu:  \"Če bi vedel, da je tako dolg predor, bi seksal s tabo!\"  Dekle se zdrzne, pogleda potnike okoli sebe in prepadeno reče:  \"Kaj nisi bil ti?\"", "Dolg predor" },
                    { 494, true, 27, "Mlad moški z žensko v avtu ustavi vozilo na neki gozdni cesti, daleč ven iz mesta.    Preden začneta seksati, dekle reče: \"Pozabila sem ti povedati ... Sem prostitutka in računam 20 EUR.\"    Moški ji, obotavljaje, izroči denar, nakar opravita svoje.    Moški skadi cigaret in očitno se mu nikamor ne mudi.    \"Zakaj se ne odpeljeva?\" ga vpraša punca.    \"Pozabil sem ti povedati, a jaz sem taksist. Vožnja nazaj do mesta stane 25 EUR.\"", "Pozabila je povedati" },
                    { 453, true, 27, "Mož: \"In ljubica, kakšen ljubimec sem bil tokrat? Trajalo je več kot eno uro!\"    Žena: \"Da, dragi. Pozabil si le, da smo danes premaknili uro nazaj.\"", "Kako se je izkazal" },
                    { 451, true, 27, "Ženska svoji prijateljici: Sedim v stanovanju... sama. Nekdo pozvoni na vrata.    Odprem in pred vrati stoji simpatičen mladec.    Vpraša me: \"Je vaš mož doma?\"    Odgovorim mu, da ga ni doma.    Mladenič vstopi, se sleče, me vrže na posteljo, me pošteno kresne, se obleče in odide.    Še do dandanes mi ni jasno zakaj je potreboval mojega moža?!", "Neznanec na vratih" },
                    { 450, true, 27, "Kolega je razlagal lepotici, da ima samo še tri dni življenja.    Vprašal jo je, če bi spala z njim.    In glej, zlomka, od takrat so pretekla že tri leta pa je še vedno živ.    Zgleda, da ga je ozdravila!", "Samo tri dni življenja še ima" },
                    { 449, true, 27, "Grem po mestu in srečam postavno dolgolasko.    Vprašala sem jo, če bi spala z mano za 200EUR.    Ogorčena je rekla ne in odvihrala.    Bil sem žalosten, nujno sem rabil denar.", "Nagovoril sem lepotico" },
                    { 415, true, 27, "Ženo je močno bolel zob.    Odšla je k zobozdravniku, ta ji je izdrl zob in naslednji dan se je prebudila brez bolečin.    Po zajtrku je še mož začel stokati, da ga boli zob. Žena ga je napotila k zobozdravniku, ki ga je pregledal, mu slikal zobe in mu povedal, da ne najde vzroka bolečine.    Menil je, da gre za psihološko bolečino in mu svetoval naj se usede v čakalnico in pol ure ponavlja: \"Mene ne boli zob! Mene ne boli zob!\"    Po polurnem ponavljanju navedenih besed zobobola res ni več čutil. Mož se je odpravil domov in takoj po prihodu ženo nagovoril k posteljnim užitkom.     Po seksu se je odpravil v kopalnico, se vrnil čez pol ure in zopet seksal. Po seksu zopet v kopalnico in čez pol ure ponovno seks. Po tretjem seksu se je zopet odpravil v kopalnico, žena pa se je čudila, od kod mu moč, da je v tako kratkem času kar trikrat seksal, saj mu doslej to še ni nikoli uspelo.    Pokukala je v kopalnico in ga zaslišala, kako ponavlja besede: \"To ni moja žena! To ni moja žena!\"", "Samo prepričati se moraš" },
                    { 396, true, 27, "Stanodajalka se je resnično razjezila na podnajemnika: \"V ponedeljek ste imeli ženski obisk, v torek in sredo prav tako, danes je četrtek pa je bila pri vas spet ženska. In to vedno druga! Ali se zavedate da imam jaz dve nedolžni hčerki, ki vse to opazujeta?\"    Podnajemnik: \"Hehe, ne bodite tako prepričani, da so nedolžni.\"", "Razuzdan podnajemnik" },
                    { 305, true, 27, "\"Včeraj ponoči me je v moji spalnici napadel neznanec in me trikrat posilil!\"    \"Saj imaš vendar pod blazino pištolo!\"    \"Hvala Bogu, da je ni našel, mogoče bi zbežal!\"", "Posilil jo je" },
                    { 263, true, 27, "Mlad par pride na recepcijo in naroči sobo.    Receptorka: \"Kakšno sobo želite? Z razgledom na morje, s tušem, telefonom in televizorjem?\"    Par hladno: \"Vseeno je! Glejte le, da postelja ne bo škripala!\"", "Mlad par v recepciji" },
                    { 251, true, 27, "Policaj ustavi voznika: \"Gospod, spregledali ste STOP znak!\"    Voznik: \"Oprostite, danes sem prvič v tem mestu.\"    Policaj: \"Kaj pa, če bi podrli kakšno žensko?\"    Voznik samozavestno: \"To pa ne bi bilo prvič, he, he...\"", "Prevožen stop znak" },
                    { 825, true, 27, "Moj penis je tako vljuden, da se, za damo, vstane.    Tako se ima ona kam vsest.", "Vljudnost" },
                    { 829, true, 27, "Babica po seksu pravi dedeku: Si kot mobitel.  Dedek: Zakaj, ali mogoce zraven se vibriram?  Babica: Ne, ko prides v tunel, vedno izgubis signal!", "Mobitel" },
                    { 862, true, 27, "Stara prijatelja se pogovarjata:  Ti,ali si ze probal Viagro?  Ne se.  Sicer pa nima smisla.  Z drugimi zenskami ne hodim  vec okoli,za zeno mi je pa  skoda stroskov...", "Dobri nasveti" },
                    { 878, true, 27, "Se dve najstnici tusirata in prva pravi drugi: Tvoji opicji glavi pa so ze pognali laseki.  Druga odgovarja: To ni se nic, tudi banane ze je!", "Pod tusem" },
                    { 1570, true, 27, "Japonci so izumili robota za seks.    Za prvo testiranje so se prijavile: Ljubljančanka, Štajerka in Dolenjka.    Po eni uri preizkusa Ljubljančanka pride ven in reče: \"Kva je pa to dobr, mega kul!\"    Po dveh urah pride ven Mariborčanka in reče: \"Čuj, kaj toti mali dela! Takoj si ga bom nabavla.\"    Pa vstopi še Dolenjka in je ni in ni...po 3 urah pridirja ven robot, za njim pa dolenjka in kriči: \"Kurba, prid' nazaj! A za bejžat pa še maš baterije, a!?\"", "Seks robot na preizkušnji" },
                    { 1537, true, 27, "Podjetnik se je predčasno vrnil s službenega potovanja in z ženo v postelji odkril svojega namestnika.    \"Milan, kaj pa ti delaš v postelji z mojo ženo?\" je presenečeno vzkliknil.    \"Isto kot v podjetju!\" se je oglasila žena. \"Popravlja tvoje napake!\" ", "Zasačil ju je" },
                    { 1513, true, 27, "Zakaj se poje samo pol viagre?    1) Da ne lulaš po čevljih.    2) Če želiš samo malo podjebavati.", "Pol viagre" },
                    { 1373, true, 27, "Ginekolog po pregledu: \"Gospa, stvar je kar resna, tri mesece z možem ne smete imeti spolnih  odnosov. Bo šlo?\"    \"Ni problema, saj imam ljubimca.\" ", "Tri mesece suše" },
                    { 1362, true, 27, "Majo vprasa prijateljica  Mojca: Kaj se ti zdi  najpomebneje za varen seks?  Maja: Natancno vedeti, kdaj  se domov vrne moz.", "Varen seks" },
                    { 1312, true, 27, "Zena hoce narediti moza ljubosumnega:  Kaj bi rekel, ce bi ti priznala,   da sem spala z clovekom, ki ga  imas najraje?  Da si lezbijka.", "Lezbijka" },
                    { 1299, true, 27, "\"Joža, ne grem s tabo v posteljo, preden mi ne obljubiš, da se boš poročil z menoj!\" se upira Micka.    \"Toda, Micka, saj veš, da te ljubim!\"    \"Micka gor, Micka dol. Obljubi! Doslej sem to zahtevala še od vsakega, ki je hotel spati pri meni, pa bom še od tebe!\"", "Ne da se kar tako" },
                    { 1264, true, 27, "Spermiji veselo plavajo proti jajčnikom.    Ker je eden že utrujen, vpraša: \"Jaz sem že čisto izmučen! Kako daleč je še do jajčnikov?\"    Eden izmed množice mu odgovori: \"Uuuu, še dolgo! Šli smo komajda mimo mandljev.\"", "Pogovor med spermiji " },
                    { 1257, true, 27, "Dokazano je, da moški, pri seksu, porabi 3100 kalorij.    100 pri samem dejanju. 3000 pa pri tem, ko se hvali naokoli.", "Poraba kalorij pri seksu" },
                    { 1231, true, 27, "Jože v pubu naleti na lepotico.    Ker je preteklo že kar nekaj alkohola se po kratkem flirtanju odpravita k njej.    Ker sta oba okajena, hitro zaspita.    Drugi dan se Jože, ko je bilo sonce že visoko, prebudi. Na nočni omarici zagleda sliko bradatega moškega.    Jože: \"Kaj?!? Pa ti si poročena! Kako si lahko to storila?\"    Lepotica: \"Sprosti se, nisem poročena.\"    Jože: \"Kdo pa je potem to?\"    Lepotica: \"Jaz, pred operacijo.\"", "Hitra aferica" },
                    { 1141, true, 27, "Pred seksom slečemo eden drugega.    Po seksu se moramo obleči sami.    Nauk: nihče ti noče pomagati po tem, ko si zjeban!", "Modra misel" },
                    { 1111, true, 27, "Vprasanje: Kaksni je  dan brez seksa?    Odgovor: Kot noc, samo  da je bolj svetlo...", "Dan in noc" },
                    { 1105, true, 27, "Marta Kosiru: Dragi moj,   se ti ne zdi, da tebi zadnje   case nekam nenavadno hitro  pride.  Kosir izstreli nazaj:  Ves kaj, draga moja, imela si  popolnoma enako casa kot jaz.", "Marta in Kosir" },
                    { 1096, true, 27, "\"Sosed, zakaj si spal pri moji zeni, ko sem bil tri na sluzbenem potovanju?\"  \"Zanimalo me je, ce je kaksna razlika med mojo in tvojo zeno!\"  \"No, to bi lahko tudi mene vprasal...\"", "Sosedova zena" },
                    { 1470, true, 29, "Se prepirajo zdravnik, arhitekt in politik cigav poklic je najstarejsi.  Zdravnik: Bog je Evo ustvaril iz Adamovega rebra. To je kirurski poseg.  Arhitek: Ja, toda pred tem je Zemljo ustvaril iz kaosa.   Politik: No, vidita vidva, kdo pa mislita, da je ustvaril kaos?", "Poklici" },
                    { 1065, true, 27, "Polde in Ferdo tolceta runde  za sankom.  Kar naenkrat Polde: Ti, Ferdo, se  kaj tusiras po seksu?  Ferdo izstreli:  Seveda, logicno!  Polde:  Potem pa pogosteje seksaj", "Tusiranje po seksu" },
                    { 1057, true, 27, "Pelje mamica hčerkico po parku. Pa opazita, da dva seksata na klopci.  Punčka vpraša: \" Mami, kaj delata?\"    Mami (najprej premišljuje): \"Ja, tortice delata, veš.\"  Potem gresta v živalski vrt in vidita dve opici, ki seksata v  kletki.    Punčka:\"Mami, a ta dva tudi tortice delata?\"  Mami: \"Ja, miškica moja, tud tadva delata tortice.\"    Naslednji dan punčka vpraša mamico: \"Mami, a sta vidva z očijem tudi včeraj delala tortice v dnevni sobi?\"  Mami (zardi in zgroženo vpraša): \"Ja, kako pa to veš?\"    Sledi malo tišine, nato pa punčka pravi: \"Vem, ker sem smetanco polizala s kavča.\" ", "Mama razlaga hčerki" },
                    { 987, true, 27, "Profesor pri biologiji razlaga: \"Pri poštenem iztrebljanju človek občuti podobno zadovoljstvo kot pri seksu.\" Eden od študentov dvigne roko: \"Gospod profesor, če pravite tako, potem ali vi ne znate seksati ali jaz ne znam srati.\"", "Seks in potreba" },
                    { 970, true, 27, "Ženska pravi sestri: \"Bi kupila kavč? Poceni ga dam.\"  Sestra: \"Zakaj pa? Ni še leto dni, kar si ga kupila.\"  \"Prejšnji mesec sem na njem prevarala Janeza in zdaj ga ne morem gledati.\"  \"Draga sestrica, če bi jaz zato prodajala pohištvo, bi mi ostal samo luster.\"", "Varanje" },
                    { 969, true, 27, "Nepričakovani seks je najboljša stvar, ki se ti lahko zgodi...  Razen če si v zaporu.", "Nepričakovan seks" },
                    { 959, true, 27, "Otroci na zadnjih sedežih lahko povzročijo nesrečo.    Nesreče na zadnjih sedežih lahko povzročijo ... otroke.", "Zadnji sedež" },
                    { 957, true, 27, "Kaj imata skupnega nemško pivo in seks v čolnu?    Oba sta blizu vode.", "Pivo in seks v čolnu" },
                    { 956, true, 27, "Kaj sledi po 69?    Pranje zob.", "Po 69" },
                    { 952, true, 27, "Vnukec vpraša staro mamo: \"Oma, ali ste, v seksu, kdaj poskusili 69?\"    Oma: \"Ne, poskusila sem pa 53.\"    Vnukec: \"Kako 53?\"    Oma: \"Več, kot 53 partizanov nisem mogla nategniti v eni noči.\"", "Nagajivi vnukec draži omo" },
                    { 948, true, 27, "Kako lahko svojo partnerko najlažje pripraviš, da med tem, ko seksaš, začne vreščati?    Pokličeš jo in ji poveš, kako je fino.", "Vreščanje med seksom" },
                    { 939, true, 27, "Pepca na stopniscu sreca sosedo  Stefko.  Nemudoma ji potozi:  Ves,moj Ferdo je ze 300 odstotno  impotenten.  Soseda:Kako 300,se vceraj si mi  zaupala,da je 100 odstotno?  Pepca:Ze,ampak sinoci je padel  po stopnicah in si zlomil  sredinec ter pregriznil jezik.", "3oo % impotenten" },
                    { 928, true, 27, "Kaj ti mislis, ali ima polna luna vpliv na seks?  Seveda! Kadar je polna luna z daljnogledom bolje vidim k sosedom!", "Polna luna" },
                    { 902, true, 27, "Mož se je predčasno vrnil domov in pri ženi v spalnici odkril črnca.    \"Zdaj imam pa črno na belem, da me varaš!\" je vzkliknil mož.", "Mož zasači ženo v postelji s črncem" },
                    { 901, true, 27, "Žena in njen ljubimec se predajata strastem v spalnici, ko mimo nje pride ženin 9-letni sin Janezek.  Brez da ga parček opazi, se Janezek skrije v omaro in ju gleda.    Nenadoma pride domov mož. Moški skoči iz postelje in se skrije v omaro, kjer naleti na Janezka.  Janezek začne: ”Mater je temno tuki.”  Ljubimec: ”Ja pa je res.”  Janezek:”Imam fuzbal žogo..kupiš?”  Ljubimec: ”Ne, hvala.”  Janezek: ”Moj oče je zuni..”  Ljubimec: ”Kolk hočeš za njo?!”  Janezek: ”250 evrov.”  Ljubimec kupi žogo in sin je tiho do odhoda očeta, ko lahko ljubimec pobegne.    Čez par tednov znova nastane ista situacija, znova naletita drug na drugega v omari.  Janezek:”Mater je temno tuki..”  Ljubimec odvrne ”Ja, pa je res.”  Janezek: ”Kupiš kopačke?”  Ljubimec, vedeč kaj se zgodi, če jih ne: ”Koliko hočeš za njih?”  Janezek: ”500 evrov.”  Ljubimec jih kupi in sin je znova tiho.    Naslednji dan oče povabi Janezka igrat nogomet. Pove mu, da nima kopačk in žoge. Na očetovo vprašanje, kam jih je dal odvrne, da jih je prodal. ”Za koliko?” vpraša oče. ”750 evrov” odvrne. Oče ga karajoče pogleda. ”To ni vredu, sine. to je preveč. Nekoga si grdo nategnil. Greva v cerkev, to je greh.”    In tako gresta v cerkev. Janezek vstopi v spovednico in zamrmra:  ”Mater je temno tuki.”  Župnik: ”Pa ne me jebat, a spet ti!?!”", "Janezek in mamin ljubimec v omari" },
                    { 892, true, 27, "V dnevni sobi se dva geja sabljata z lulčki.  Po dvajsetih minutah se en od niju ves zmatran skloni in reče:  \"Ne morem več, ubij me!\"", "Sabljanje" },
                    { 1063, true, 27, "V parku sredi ljubljane klosar  prisede k Mojci:  Kaj je bejba, bova seksala?  Mojca zgrozeno: Kaj si pa domisljate,   seveda ne!  Klosar: Ah, sem mislil, ko ze   sedis na moji postelji...", "Klosar" },
                    { 1999, true, 36, "Zjutraj je častnik sklical zbor vojakov in jim rekel: \"Danes je dan za lenobe. Najbolj len vojak bo prejel teden dni dopusta. Torej, tisti, ki je najbolj len med vam, naj stopi korak naprej!\"    Vsi vojaki so stopili korak naprej, le Janez je obstal na mestu.    \"Kaj je pa s teboj?\" ga je vprašal častnik.    \"Jaz sem pa prelen, da bi stopil naprej.\"", "Lenoba" },
                    { 1630, true, 29, "Direktor podjetja pokliče tajnico in ji reče: \"Prosim, pripravite se, greva za en teden na službeno pot v tujino.\"  Tajnica po vrnitvi domov reče možu: \"Dragi, s šefom grem za en teden na službeno pot, moral boš poskrbeti zase ta čas.\"  Mož telefonira svoji ljubici: \"Moja žena bo odpotovala za en teden, ki ga lahko preživiva skupaj.\"  Ljubica pošlje e-pošto dijaku, ki ga uči matematike: \"Ta teden bom zelo na tesnem s časom, zato ti dam prosto.\"  Dijak ves srečen obvesti svojega deda: \"Dedek, en teden nimam ur iz matematike, ker moja inštruktorica nima časa. Daj, prosim, greva ribe lovit!\"  Ded (direktor podjetja) ponovno pokliče tajnico: \"Sprememba plana. Vnuk me prosi, da bi preživela prosti čas skupaj. Potovanje bova prestavila na kak drug čas.\"  Tajnica pokliče svojega moža: \"Dragi, šef je spremenil načrt in službena pot je odložena.\"  Mož telefonira ljubici: \"Ne bo šlo ta teden. Ženina službena pot je preložena.\"  Ljubica pošlje SMS dijaku: \"Vseeno bova imela ure tako kot doslej.\"  Dijak obvesti dedka: \"Dedek, žal, učiteljica je rekla, da bova imela inštrukcije tudi ta teden.\"  Ded stopi k tajnici: \"Ne sekirajte se, vseeno bova odpotovala.\"    Tajnica...!!!", "Verižna reakcija" },
                    { 1799, true, 29, "Podjetnik Janez doma pravi zeni:  Zaposliti moram tajnico.  V redu, ampak glej, da bo vsaj   abrahamovka, biti mora debela  in grda, skratka taksna, da ob njej  ne bos niti pomislil na seks.  Prav. Kdaj bos lahko zacela?", "Tajnica" },
                    { 557, true, 34, "Srečata se Edo in Jože.  Edo: Slišal sem, da ti je umrla tašča. Kaj pa je imela?  Jože: Eh, skromno hranilno knjižico, pa nič drugega.  Edo: Ne, mislim, kaj ji je manjkalo?  Jože: Aja, solidna penzija in lastno stanovanje.  Edo: Ma ne, človek, mislim, zakaj je umrla?  Jože: Ah, to... Rekel sem ji, naj gre v klet po krompir, da ga bomo imeli za kosilo, pa je padla po stopnicah in si zlomila vrat.  Edo: O, groza! Strašno! In kaj ste potem naredili?  Jože: Makarone.", "Smrt tašče" },
                    { 509, true, 34, "\"Zakaj si tako žalosten? Kaj se je zgodilo?\" vpraša Lojze prijatelja Marka.   \"Oh, moja tašča je umrla!\"   \"Moje iskreno sožalje,\" reče Lojze.   \"Hvala. Veš, mene je govor župnika tako pretresel. Rekel je, da bomo v nebesih spet skupaj.\" ", "Pogreb" },
                    { 483, true, 34, "Kaj je to: ponoči plava, podnevi laja?    Taščina proteza.", "Uganka" },
                    { 340, true, 34, "Avtobus tašč se odpelje na izlet zgodi se nesreča vse umrejo. Zeti naredijo veselico.Le eden tam v kotu žalosten sedi in joče.Pa ostalim prekipi in ga vprašajo zakaj joče in če ni vesel? Ne jim odvrne,moja je odpovedala izlet", "Tašče grejo na izlet" },
                    { 1, true, 34, "Zakaj nobena tašča ne more priti v nebesa?  Ker noben zmaj nemore leteti tako visoko.", "Tašča v nebesih" },
                    { 1700, true, 33, "Stajerc pride v Ljubljano in  vprasa mimoidocega:  Kako se najhitreje pride do  klinicnega centra?  Zaprite oci, preckajte cesto  in tam boste v desetih minutah.", "Pot do UKC" },
                    { 1037, true, 33, "Nekjer na stajerskem podezelju.  Telicek prijoka k mamici:  Mami,mami,pujsek mi je rekel,da  je moja mama navadna krava!  Krava mirno:  Sine,ti pa mu povej,da je njegova  mati navadno prase,enako njegov  oce,tvoj foter pa je diplomirani  veterinar,in se z fordum se je   pripeljal!", "Telicek" },
                    { 937, true, 33, "Stajerc Pepi na obisku pri  Gorenjcu.  Ta mu raskaze hlev in zivali.  Pepi zagleda svinjo z leseno   zadnjo nogo.  Zacudeno vprasa:  Zakaj pa ima ta svinja leseno nogo?  Gorenjec:Ves,kaj,zaradi enega samega  stegna se mi je ne splaca zaklati!  ", "Pri Gorenjcu" },
                    { 815, true, 33, "Kaj je to neucakanost?  Ko Stajerc sredi vinograda je grozdje!", "Neucakanost" },
                    { 352, true, 33, "Kakšna je razlika med Štajercem in Dolenjcem?  Štajerec ne more videti praznega kozarca, Dolenjec pa ne more videti polnega…", "Kozarec" },
                    { 216, true, 33, "Enga še spijemu pa gremu.", "Največja štajerska laž" },
                    { 2062, true, 32, "Sin lastnika kina je šel prvič v šolo.    Ko se vrne, ga oče vpraša: \"Kako je bilo v šoli, sinko?\"    \"Popoln uspeh, očka. Razprodano do zadnjega sedeža!\"", "Dobra ocena" },
                    { 2052, true, 32, "Vzporednice imajo toliko skupnega.    A kaj, ko se nikoli ne bosta srečali.", "Vzporednice" },
                    { 2038, true, 32, "Otroci morajo v šoli napisati prosti spis z naslovom 'Jaz sem direktor.'    Vsi pišejo, le Janezek gleda okoli sebe.    Učiteljica ga vpraša: \"Janezek, kaj pa je narobe, zakaj ne pišeš?\"    Janezek: \"Čakam na tajnico!\"", "Napisati morajo spis" },
                    { 2024, true, 32, "Mama pravi Janezku: \"Sinko, kdaj boš popravil tisto enko iz matematike?\"    Janezek: \"Saj bi jo mama, pa učitelj redovalnice sploh ne da iz rok!\"", "Popravljanje ocene" },
                    { 2006, true, 32, "Učiteljica da otrokom domačo nalogo, da napišejo tri stavke.    Janezek pride domov k očetu in mu reče, naj pove en stavek.    Oče ves jezen odgovori: \"Pusti me pri miru, a ne vidiš, da berem časopis.\"    Janezek to zapiše in se odpravi v park, kjer sreča dva zaljubljenca in ju prosi, da mu povesta en stavek.    Fant pogleda svojo punco in ji reče: \"No, pa pojdiva ljubica.\"    Janezek zabeleži tudi to in se odpravi naprej.    V peskovniku zagleda majhnega dečka, ki se igra.    Reče mu, naj pove en stavek in fantek odgovori: \"Jaz sem King Kong v kratkih hlačah.\"    Naslednji dan mu v šoli tovarišica reče, naj jih prebere.    Janezek reče: \"Pusti me pri miru, a ne vidiš, da berem časopis.\"    Učiteljica ga debelo pogleda in reče: \"Janezek, a greva k ravnatelju?\"    Janezek nadaljuje: \"No, pa pojdiva ljubica.\"    Prideta k ravnatelju, tovarišica mu razloži, zakaj sta prišla in ravnatelj reče Janezku: \"Ja, kdo pa misliš, da si ti?\"    Janezek odgovori: \"Jaz sem King Kong v kratkih hlačah.\"", "Zbiranje snovi za domačo nalogo" },
                    { 2004, true, 32, "Otroci so v šoli dobili domačo nalogo: “Opiši v stotih besedah, kako ste preživeli vikend”.    Mali Franček je napisal: \"Ta vikend smo se nameravali odpeljati z družino k teti. Naložili smo se v avto in ta nikakor ni hotel vžgati. Žalostni smo šli iz avta, razen očeta, ki je ostal pri avtomobilu in izrekel ostalih 60 besed, ki pa niso primerne za mojo domačo nalogo.\"", "Spis za domačo nalogo" },
                    { 1981, true, 32, "Janez ima občutek, da je premalo izobražen, zato se vpiše na pravno fakulteto.    Prej ali slej pride na vrsto izpit, in sicer ustni.    Janez sedi v kabinetu, profesor si ga ostro ogleduje, potem pa zastavi vprašanje: \"Ali ima mož pravico odpreti pismo, ki je naslovljeno na ženino ime?\"    Janez nekaj časa premišljuje in odgovori: \"Pravico ima, poguma pa ne.\"", "Janez na fakulteti" },
                    { 1971, true, 32, "Oče na roditeljskem sestanku vpraša učiteljico: \"Se vam ne zdi, da je moj sin resnično izviren v nekaterih stvareh?\"    \"Da, res je. Še posebno pri pravopisu!\"", "Oče na roditeljskem  sestanku izvedavo" }
                });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "Id", "Active", "CategoryId", "Description", "Title" },
                values: new object[,]
                {
                    { 1946, true, 32, "\"Očka, kajne, da so tebe po krivici vrgli iz šole?\"    \"Seveda! Zakaj sprašuješ?\"    \"Ker se je zgodovina ponovila.\"", "Hotel se je prepričati" },
                    { 1910, true, 32, "Profesor je vprašal Jureta: \"Imaš 54 evrov in mamo prosiš, da ti da še 78 evrov. Koliko evrov imaš potem?\"    \"54!\"    \"Še vedno ne znaš računati?\" se je začudil profesor.    \"Računati znam, toda vi ne poznate moje mame.\" ", "Računstvo" },
                    { 1909, true, 32, "Učitelj se v šoli razjezi na učence in reče: \"Vsak, ki je neumen, naj vstane!\"    Pa najprej nobeden ne vstane, pol se pa počasi Janezek dvigne s stola.    Učitelj ga vpraša: \"A ti misliš, da si neumen?\"    Janezek pa reče: \"Ne, ampak nerodno mi je, ker samo vi stojite!\"", "Sočutje" },
                    { 1899, true, 32, "V razredu se je med poukom vnel prepir med sošolcema: \"Ti si neumen kot osel!\" je zavpil Mare na Milana.    \"Ti si pravi idiot!\" mu je vrnil Milan.    Pa se je vmešal profesor: \"Vidva sta verjetno pozabila, da sem tudi jaz v razredu!\" ", "Zmerjata se kar sredi pouka" },
                    { 1857, true, 32, "Učiteljica je želela učencem pojasniti, kaj je žepar.    \"Če dam moškemu roko v žep, zato da bi mu ven vzela denar, kaj sem potem jaz?\" je vprašala.    \"Njegova žena!?\" se je oglasil Mitja.", "Nazorna razlaga" },
                    { 1842, true, 32, "Vpraša učiteljica Petrčka: \"A ti tvoj oči še pomaga pri domačih nalogah?\"    \"Ne več. Tista enka zadnjič ga je dokončno zlomila!\"", "Pomoč pri domači nalogi" },
                    { 1834, true, 32, "Kako je bilo v šoli?    \"Slabo. Pri geografiji sem dobil nezadostno.\"    \"Zakaj pa?\"    \"Nisem našel ekvatorja.\"    \"Saj ni čudno, ko pa imaš v torbi takšen nered!\" ", "Dobil je slabo oceno" },
                    { 1828, true, 32, "Učiteljica je pri uri slovenščine na tablo napisala stavek: \"Reven moški je umrl zaradi lakote.\"    \"Peter, kje je subjekt?\" je vprašala.    Peter, previdno: \"Verjetno na pokopališču!?\" ", "Pri uri slovenščine" },
                    { 1827, true, 32, "Učitelj fizike sprašuje učence o učinkih vročine in mraza.    \"Vročina razteza, mraz pa krči,\" reče Mojca.    \"Točno! Mi lahko kdo to ponazori s primerom?\"    \"Poleti so dnevi dolgi, pozimi pa krajši.\" ", "Vročina in mraz" },
                    { 1816, true, 32, "Vzgojiteljica opazuje malčka v mali šoli, kako si natika škornje, pa mu nikakor ne uspe.    Malček jo poprosi: \"Tovarišica, pomagajte mi!\"    In sta tlačila, vlekla, potiskala, škornji pa niso hoteli na noge.    Ko se je to končno posrečilo, sta oba prepotena in zapihana sedla na klop, fantek pa pogleda na škornje in reče: \"Tovarišica, ravno narobe sva jih obuta.\"    Vzgojiteljica pogleda in res. Ohranila je mirno kri, malčku škornje z muko sezula in jih začela znova tlačiti fantku na noge, tokrat vsakega na pravo nogo.    Fantek pogleda in reče: \"To sploh niso moji škornji.\"    Vzgojiteljica se ugrizne v jezik, da ne bi zakričala: \"Pa tega nisi že prej opazil?\"     S težavo malčku sezuje škornje, fantek pa ji razloži: \"To niso moji škornji, bratovi so, ampak mama jih je zdaj dala meni, ker so bratu postati premajhni!\"    Vzgojiteljica ne ve več, naj se smeji ali joka, ampak fantku znova pomaga zlesti v škornje.    Ko mu po tem hudem naporu pomaga obleči še plašček, ga vpraša: \"Kje imaš pa rokavice?\"    Fantek ji pove: \"Zjutraj sem jih natlačil v škornje\".", "Z dovolj muje se vsak škorenj obuje" },
                    { 579, true, 34, "Hiša gori. Hrabri mož steče v hišo in privleče sina ven. Nato gre spet noter in prinese ženo. Potem gre še enkrat in privleče psa. Potem gre še enkrat in pride prazen ven, pa še enkrat tako. Gasilec ga čudno gleda in vpraša kaj zaboga počne. On pa: “Taščo obračam!”", "Požar v hiši" },
                    { 1806, true, 32, "Dijak četrtega letnika srednje šole reče učiteljici: \"Učiteljica, prosim, posodite mi cigareto.\"    \"Ali bi rad, da ostanem brez službe?\"    \"Morda, toda še raje bi cigareto.\" ", "Sposodil bi si cigareto" },
                    { 583, true, 34, "Snaha obišče taščo v bolnici. Tašča ves čas pogovora stoka in joka:  “Umrla bom!”  Snahi je naenkrat dovolj in reče:  “Če je bilo doslej vse po vaše, pa naj bo še to!”", "Tašča v bolnišnici" },
                    { 648, true, 34, "Hči: \"Mama, spet sem se skregala z možem, tega ne zdržim več!! Prišla bom živet k tebi!\"    Mama: \"Ne, draga, nikakor; on mora plačat za svoje napake! Jaz bom prišla živet k vama!\"", "Hčerka se je skregala z možem" },
                    { 1879, true, 36, "V bazo Tujske legije v puščavi je na dolžnost prišel nov general.    Že prvi dan je šel na obhod baze in med obhodom opazil sumljivo zvezano mulo za steber.    Vprašal je najbližjega vojaka, čemu služi ta žival tukaj.    \"Gospod general, mula je za zabavo vojakov. Veste kako je, dolgo smo tukaj, brez žena in ...\"    \"Dobro, potem ji pa malo uredite prostor in naredite streho!\" ukaže general.    Čez mesec dni tudi general ni mogel več prenašati samote, zato se je odločil, da se bo tudi on malo zabaval z mulo.    Ukaže stražarju, da mulo drži, da se nebi nevarno premikala, medtem ko bi on opravljal zadevo.    Ko je opravil in se oblačil je olajšan in zadovoljen vprašal stražarja: \"Povej mi junak, ali običajni vojaki delajo to tudi tako, kot mi generali?\"    \"Pa obstaja ena razlika, gospod general. Običajni vojaki praviloma mulo zajahajo in odjahajo do najbližjega naselja, kjer se nahaja javna hiša!\"", "Nov general v Tujski legiji" },
                    { 1618, true, 36, "Strašna nevihta na morju. Kapitan vpije na krovu: \"Zna kdo moliti?\"    Javi se en mornar: \"Jaz znam moliti!\"    \"Čudovito!\" je rekel kapitan.    \"Vi boste ostali na krovu in molili. Imamo namreč en reševalni pas premalo.\" ", "Zajela jih je nevihta" },
                    { 973, true, 36, "Čakajo partizani nemce v zasedi.  Mine 1 ura nič.  Minejo 2 ure, še vedno nič.  Minejo 3 ure pa še vedno nič.  Pa se oglasi en partizan: \"Menda se jim ja ni kaj zgodilo\".", "Partizani v zasedi" },
                    { 782, true, 36, "Ostostrelec prihiti  k polkovniku v kasarno:  Pulkovnik,ustrelil sem  poveljujocega oficirja pri enotah,  ki nas oblegajo s severa.  Kako to mislis?  Sovraznike imamo na jugo,  nasi prijatelji pa so na  severu.  Tam vendar nimamo sovraznikov.  Zdaj jih imamo.", "Sovrazniki" },
                    { 695, true, 36, "General Glanckopf  je po pregledu svoje vojske   izjavil:    Ne vem sicer,ali bodo prestrasili  sovraznika,ampak mene je groza,  ko jih pogledam", "Strasna vojska++" },
                    { 674, true, 36, "Janez je odšel na fronto in po nekaj tednih poklical ženo: \"Ljubica, veselo novico ti moram povedati.\"    Žena: \"Kakšno pa?\"    Janez: \"Prvega bom že doma.\"    Žena veselo: \"Lepo, kako pa to veš?\"    Janez: \"Poveljnik je rekel, da se bomo borili do zadnjega!\"", "Dobre novice iz fronte" },
                    { 2055, true, 34, "Notar sestavlja oporoko ob postelji umirajočega in ga vpraša: \"Vse je popolnoma jasno, toda ne razumem, zakaj želite, da se vaš pepel raztrese po morju?\"    \"Zato, ker se je moja tašča zaklela, da bo plesala na mojem grobu!\"", "Zadnja želja umirajočega" },
                    { 2035, true, 34, "Mama je na obisku pri hčerki in se jezi: \"Hčera, poslušaj! Če bo še enkrat, ko pridem k tebi na obisk, tvoj mož pijan kot čep, se bom pri priči obrnila in me ne bo nikoli več k vam.\"    Hčerka: \"Mama, ne govori tako glasno! Če te bo moj mož slišal, ne bo nikoli več trezen!\"", "Pijan zet" },
                    { 1944, true, 34, "Marjan: \"Vinko, ti sekaš drva, pravkar pa ti je umrla tašča. Ali moraš prav zdaj sekati?\"    Vinko: \"Glej Marjan, najprej delo, potem zabava!\"", "Umrla je tašča" },
                    { 1880, true, 34, "Po prvi poročni noči tašča vpraša zeta: \"No, moj dragi zet, ali si zadovoljen s svojo mlado nedolžno ženo?\"    \"Niti ne!\"    \"Da te ni sram! Cela vas je bila z njo zadovoljna, ti pa ne?\"", "Po poročni noči ga že zaslišuje" },
                    { 1688, true, 34, "Ropar v banki, po končanem ropu vpraša enega izmed talcev: \"Ali si me videl?\"    Talec: \"Da.\"    Ropar ga pri priči ustreli.    Nato vpraša drugega: \"Ali si me videl?\"    Talec: \"Jaz vas nisem videl, moja tašča vas pa je.\"", "Ponudi se dobra priložnost" },
                    { 1685, true, 34, "Ati, ati, zakaj stara mama teče cik-cak?    Sine, tiho bodi in mi daj še par metkov.", "Tašča teče cik-cak" },
                    { 1493, true, 34, "Mešani občutki so, če izveš, da se ti je tašča smrtno ponesrečila.    S tvojim novim avtomobilom.", "Mešani občutki" },
                    { 1480, true, 34, "Francelj svoji tašči: \"In če že želiš vedeti, nameravam se ločiti od tvoje hčerke samo zaradi tebe!\"    Tašča je šokirana, zardi in reče: \"Ampak, Franceljček moj ...\"", "Ločitev samo zaradi tašče" },
                    { 1430, true, 34, "Moja tasca kuha tako kot vsi veliki kuharski sefi.  Super, torej vsaj nekdo pri vas odlicno kuha.  Ne, saj nic ne skuha.  Ce pa si rekel,...  Ja, stoji sredi kuhinje, ukazuje in se dere na nas.", "Tasca in kuhanje" },
                    { 1359, true, 34, "Kako se po novem rece tasci.  Vegeta.  Ker se mesa vsepovsod.", "Vegeta" },
                    { 1182, true, 34, "Moja tasca je kot vegeta.  Kako to mislis?  V vse se vmesa!", "Vegeta" },
                    { 1101, true, 34, "Franci, kako si lahko dovolil, da se je tvoja hcerka porocila s Slavkom, saj ga vendar ne maras?  Tako sem se mu lahko masceval.  Kako neki?  Mojo zeno je dobil za tasco!", "Poroka" },
                    { 1079, true, 34, "V prometni nesreči se Pepca hudo poškoduje po obrazu.    Potrebna je plastična operacija, kožo zanjo s svoje zadnjice daruje kar njen Polde.    Po nekajtedenskem okrevanju je vse okej, koža se je lepo presadila, na obrazu ni brazgotin.    \"Oh, dragi moj,\" je hvaležna Pepca, \"zelo si mi pomagal, sploh ne vem, kako se ti naj oddolžim.\"    \"Ni vredno besed, draga, dovolj bo, da bom videl, ko te bo tvoja mama poljubila na lice.\" ", "Plastična operacija" },
                    { 1061, true, 34, "Snaha pravi tasci: Vi tako dobro izgledate, da bi bili odlicni za portret kaksnemu kitajskemu slikarju.   Tasca: Hvala! Ampak zakaj ravno kitajskemu?  Snaha: Veste, on tako rad slika zmaje!", "Tasca za portret" },
                    { 845, true, 34, "Kako testirajo mostove, pod katerimi tecejo deroce reke.   Na njih dajo 1000 tasc. Ce most zdrzi je dobro. Ce ne zdrzi pa je se boljse!", "Testiranje" },
                    { 796, true, 34, "Se srecata dva prijatelja. In prvi vprasa drugega:\"Je kaj novega?\"  Drugi:\"Ja, tasca mi je umrla.\"  Prvi:\" Kaj ji je bilo?\"  Drugi:\" Nic, ko je sla v klet po krompir je  padla po stopnicah.\"  Prvi: \"In kaj ste naredili?\"  Drugi:\" Jedli smo riz.\"", "Tasca gre v klet" },
                    { 791, true, 34, "Koliko je idealna teza tasce?  1,5 kg z zaro vred!", "Tasca" },
                    { 727, true, 34, "Avtobus tašč se pelje na izlet, zgodi se nesreča in vse umrejo.  Zeti nato naredijo veselico. Le en tam v kotu celi večer žalosten sedi in joče.  Le kaj te muči, ga vprašajo, ko jim je vsega dovolj. A ti nisi vesel?  Ne, jim odvrne, moja je odpovedala izlet. ", "Nesreča" },
                    { 726, true, 34, "Milan vstopi v pisarno in presenečeno pogleda kolega Emila, ki sedi za pisalno mizo.  “Kaj pa ti delaš v službi?” ga vpraša.  “Kaj ni danes pogreb tvoje tašče?”  “Je, ampak moje načelo je: najprej delo, nato zabava!” ", "Načela" },
                    { 725, true, 34, "Mladoporočenca živita v isti hiši kot tašča. Nevesta je bila vajena malce dlje spati, počasi popiti kavo…    Nekega jutra začne tašča: “A veš da vse punce tvojih let vstajajo zgodaj. Ob tej uri imajo že kosilo skuhano in vse pospravljeno. Ne vem, kaj je s tabo.”  Pa reče nevesta vsa zaspana: “Ja draga tašča, tudi gospe vaših let so že vse pod zemljo, pa vam tega nikoli ne očitam.” ", "Gospa vaših let" },
                    { 724, true, 34, "Tašča gospoda Novaka je na počitnicah v Španiji utonila.  Čez dve leti je obalna straža našla truplo in poslala gospodu Novaku naslednji telegram: Našli mamo vaše žene, pokrito s školjkami, biseri so vredni 500.000,00 EUR.  Gospod Novak telegrafira nazaj:  Prodajte bisere, pošljite denar in znova nastavite vabo!", "Biseri" },
                    { 723, true, 34, "Par je šel zvečer na zabavo. Pokličeta taxi, peljeta psičko ven in  čakata na taxi. Psička medtem spizdi nazaj v hišo. Mož jo gre iskat,  ker ni hotel da ostane zaprta v hiši cel večer. Žena gre do  taksista, ki je že nestrpno čakal, da ju odpelje, ter zanj najde  izgovor. “Veste, samo k moji materi se je šel še poslovit!”, je  rekla. Mož čez nekaj časa pride, se vsede v taksi in pravi:  “Oprostite, ker je trajalo tako dolgo. Blesava kuzla se je skrila pod  posteljo, pa sem jo moral dvakrat mahnt z metlo, da je prilezla ven,  pol sem jo moral zavit v plašč, da me ni spraskala, ker se je upirala  ko sem jo vlekel po štengah in jo privezal na dvorišču. Tako da mi ne  bo spet srala po vrtu kot včeraj!”", "psic" },
                    { 697, true, 34, "Korel svojemu sefu:  >>Jutri bi sel rad na    tascin pogreb.<<  Sef:>>Jaz tudi.<<", "Tascin pogreb" },
                    { 592, true, 34, "Dva črva se pogovarjata. Eden vpraša: \"Zakaj si pa ti danes tako rsečen?\"  Pa odvrne drugi: \"Tašča je odšla na ribolov!\"", "Črv in tašča" },
                    { 1770, true, 32, "Učiteljica je rekla Mihcu: \"Spregaj besedo hodim!\"    Mihec, opotekajoče: \"Hodim ... hodiš ... hodi …\"    \"Hitreje!\" mu je rekla učiteljica.    \"Tečem, tečeš, teče.\" ", "Preganje" },
                    { 1757, true, 32, "Pred solo je bil na cesti napis  z opozorilom:  Pazite, da ne povozite otrok!  Z otrosko pisavo je bilo pod  napisom pripisano:  Pocakajte raje na ucitelje!", "Opozorilo" },
                    { 1746, true, 32, "\"Kakšna je današnja mladina!\" se pritožuje profesor v zbornici. \"Sploh nimajo interesa poslušati predavanja! Najbolj me jezi, ko kdo pogleda na uro!\"    \"Mene pa najbolj razjezi, če kdo prisloni uro k ušesu, da preveri, ali se mu ni ustavila!\" mu odgovori kolega. ", "Dolgočasna predavanja" },
                    { 858, true, 32, "Študent Pišta se ob koncu  meseca iz Ljubljane vrne  domov na Goričko.  Pa ga med vrati sreča oče  in prijazno vpraša:  Sine, kaj ti med študijem povzroča  največ težav?  Mladec kot iz topa:  Odpiranje piva s kovancem!", "Študent" },
                    { 833, true, 32, "V soli.  Ucitelj: Bucek,kateri mesec   ima osemindvajset  dni?  Bucek: Vsak. gospod ucitelj,  nekateri pa jih imajo   tudi vec.", "Bucek" },
                    { 828, true, 32, "V soli se ucijo o prednikih in uciteljica razlozi da smo se ljudje razvili iz Adama in Eve.  Janezek: Moj ata pa pravi, da smo nastaliniz opic.  Uviteljica: Janezek, vasa druzinska zgodovina me ne zanima!", "Predniki" },
                    { 802, true, 32, "Vprasa uciteljica ucence, naj povedo primer katastrofe.  Janezek: Katastrofa je, ce bi zajec na vrtu pojedel zelje!  Uciteljica: Ne, Janezek, to bi bila skoda. Katastrofa bi na primer bila, ce bi strmoglavilo vladno letalo in bi bili vsi mrtvi.  Naslednji dan je pri pouku prisoten ravnatelj.  Uciteljica ponovno nagovori ucence naj povedo primer katastrofe.  Janezek: Katastrofa bi bila, ce bi strmoglavilo vladno letalo in bi bili vsi clani posadke mrtvi.  Uciteljica: Odlicno, Janezek!  Janezek: Ne bi pa bila to skoda. Skoda bi bila, ce bi zajec na vrtu pojedel zelje.", "Katastrofa in skoda" },
                    { 792, true, 32, "V soli pozvoni telefon.  Glas na oni strani zice:  Danes pa nasega Bucka ne bo v solo.  Ucitelica:Kdo pa klice?  Moj oce,se zaslisi iz slusalke.", "Bucek" },
                    { 783, true, 32, "Maja si je pred pisanjem  kontrolne naloge nalepila listice  po nogah in si je ceznje potegnila  krilo.Med pisanjem naloge je   ucitelj opazil,da si nenavadno  dviguje krilo, in je zato stopil   k njej in rekel;  Kot moski tega nebi smel,  kot profesor pa lahko.  Ter ji dvignil krilo.  Maja ga pogleda in mirno rece;  Kot dijakinja tega nebi smela  kot zenska pa lahko.  In mu primaze klofuto.", "Demokracija" },
                    { 763, true, 32, "Profesor: \"Midva se pa že poznava, kajne?\"  Študent: \"Da, lani sem bil na izpitu. Takrat mi je spodletelo.\"  Profesor: \"No, ja, bo šlo pa danes bolj gladko. Se spomnite, kakšno je bilo lani moje prvo vprašanje?\"  Študent: \" Midva se pa že poznava, kajne?\"", "Poznanstvo" },
                    { 762, true, 32, "Ustni izpit na faksu. Po izpitu je profesor pojasnil študentki, ki je na izpit prišla v mini krilu, ki je komaj kaj pokrivalo:   \"Vidiva se zopet čez dva meseca. Danes ste me sicer vznemirili, toda zadovoljili me niste!\"", "Samo vznemirjen" },
                    { 761, true, 32, "Na testnih izpitnih polah je bilo tudi napisano:  \"Če je to tudi vprašanje, odgovorite nanj!\"    Eden od odgovorov se je glasil:  \"Če je to tudi odgovor, ga ocenite!\"", "Izpitno vprašanje" },
                    { 760, true, 32, "Pisni izpit.  Profesor je opazil da mlada lepotička prepisuje iz manjšega plonkiča.    Ko je videla, da jo profesor opazuje je listek hitro vtaknila v svoj dekolte.    Profesor je pristopil k njej in rekel: \"Kot profesor tega ne smem, kot moški pa smem!\" ji vtaknil roko med prsi in ven potegnil plonkič.    Nato se je oglasila študentka:\"Kot študentka tega ne smem, kot ženska pa smem!\" in mu prisolila zaušnico.", "Kot moški in ženska" },
                    { 757, true, 32, "Ucitelj verouka sprasuje otroke,  ali vedo,kje zivi bog.  Vsi so dajali obicajne odgovore,  razen malega Jozeta,ki je rekel:  Bog zivi v nasi kopalnici.  Kako pa ti je to padlo na pamet?  Zto,ker moj ati vsako jutro,  ko vstane,potrka na vrata  kopalnice in rece:  Ljubi bog,se vedno si notri.", "Kopalnica" },
                    { 698, true, 32, "Bucek pride iz sole domov  in se ze na vratih  pohvali mami:  >>Danes sem popravil dve enki in  eno dvojko.<<  Mama:>>Odlicno,sine,cestitam!  Pri katerih predmetih?<<  Bucek izstreli:>>Pri zobozdravniku.<<", "Bucek iz sole" },
                    { 675, true, 32, "Jan se vrne domov iz šole in oče ga vpraša: \"No kaj ste imeli danes na urniku?\"    \"Kemijo.\"    \"In kaj ste se novega naučili?\"    \"Kako lahko izdelamo dinamit.\"    \"Kaj se boste pa jutri učili v šoli?\"    \"Kakšni šoli?\"", "Lekcija pri kemiji" },
                    { 660, true, 32, "\"Očka mi je obljubil 50 evrov za vsako petico,\" je povedal Jure učitelju.    \"Saj nobene nimaš!\" je odvrnil učitelj.    \"Imam predlog: zapišite mi jih nekaj, denar si bova pa delila.\"", "Poslovna ponudba" },
                    { 985, true, 31, "Hvalijo se Američan, Rus in Slovenec. Američan pravi: \"Naša zastava je tako lepa, da se druge lahko le skrijejo!\", nakar odvrne Rus: \"Naše vojaške čelade so tako trdne, da jih noben metek ni zmožen prestreliti!!\", seveda se je oglasil tudi Slovenec, ki je dejal: \"Naš kočevski medved je tako velik, da se poserje v rusko čelado, rit pa si obriše z ameriško zastavo.\"", "Kočevski medved" },
                    { 501, true, 31, "V novo naselje pride trgovski potnik, ki prodaja specialne sesalnike. Pozvoni pri prvi hiši in vrata mu odpre mlada, čedna ženska. - Dober dan, gospa. Prodajam najnovejše modele sesalnikov za mokro in suho sesanje. Povem vam, čudežni stroji, verjemite. Ženska sploh ni prišla do besede, ko je možak v predsobi že potresel kečap, polil sok, iz vrečke stresel pasji kakec, na vse skupaj zlil jogurt, potem pa vse potresel s kilogramom moke. Ženska se je zgrozila. Trgovski potnik pa jo je pomiril: - Gospa moja, ne razburjajte se. Če sesalnik ne bo te svinjarije popolnoma očistil, jo bom pojedel. - Ali naj vam prinesem žlico? - Zakaj? - Naselje še gradijo in še vedno nam niso priključili elektrike.", "Super duper sesalec" },
                    { 2075, true, 29, "Direktor pride v pisarno k tajnici jo vpraša: \"Gospodična, a vi kaj delate v nedeljo?\"    \"Nič ne delam.\"    \"Potem pa poglejte na koledar in naj vas spomnim, da danes ni nedelja!\"", "Delo v nedeljo" },
                    { 2073, true, 29, "Direktor kandidatki za tajnico: \"Upam, da niste klepetulja in poslovnih skrivnosti ne trosite okoli.\"    \"Bodite brez skrbi. Lahko vam povem, da imam na banki več kot 10.000 €in to samo zato, ker sem znala molčati.' ", "Zelo zanesljiva" },
                    { 2032, true, 29, "Direktor hotela sliši, kako šef recepcije reče nekemu gostu: \"Ne, tega pa pri nas nimamo!\"    \"Kako, nimamo? Seveda imamo!\", se vmeša direktor.    Gost se zahvali in odide.    \"Kaj pa je vprašal?\", vpraša direktor šefa recepcije.    \"Vprašal je, ali imamo pri nas veliko dežja.\"", "Vskočil mu je v besedo" },
                    { 2022, true, 29, "Pokliče direktor tajnico in vpraša: \"Ali bova danes kaj tipkala?\"    Tajnica: \"Gospod direktor, danes ne morem, imam rdeč trak v mašini.\"    Minilo je nekaj dni, ko je tajnica potrkala na direktorjeva vrata: \"Gospod direktor, ali bova danes kaj tipkala?\"    Direktor: \"Ne bo potrebno, sem že na roko napisal!\"", "Tipkanje" },
                    { 2018, true, 29, "Pride delavec k šefu: \"Šef, ali me lahko danes spustite dve uri prej iz službe? Z ženo bi moral po nakupih.\"    Šef: \"Sploh ne pride v poštev!\"    Delavec: \"Najlepša hvala. Vedel sem, da me ne boste pustili na cedilu.\"", "Predčasni izhod" },
                    { 1973, true, 29, "\"Pokažite mi svoja priporočila.\", reče šef kadrovske službe kandidatki za tajnico.    Kandidatka ga zaskrbljeno vpraša: \"Kaj pa, če kdo pride?\"", "Priporočila" },
                    { 1970, true, 29, "Čedna mladenka se poteguje za službo tajnice.    Obleče se posebej izzivalno, v oprijeto krilo, globoko izrezano bluzo, se skrbno našminka in obuje čevlje z zelo visoko peto.    Ko čaka na razgovor z direktorjem, pride mimo starejša uslužbenka, jo pogleda in reče: \"Kar se tiče našega direktorja, bi bilo bolje, če bi na razgovor poslali svojega brata!\"", "Priprave na razgovor" },
                    { 1963, true, 29, "\"Kaj znate?\"    \"Znam govoriti iz trebuha.\"    \"Se da od tega živeti?\"    \"Seveda. V trgovini z živalmi prodajam govoreče papige.\"", "Vsako znanje lahko pomaga" },
                    { 1959, true, 29, "Tri ženske so skupaj delale v isti pisarni in so imele žensko za šefico.    Vsak dan je šefica odšla iz službe že precej pred iztekom delovnega časa.    Punce so sklenile, da bodo tudi one začele odhajati prej. Konec koncev, šefica ni nikoli poklicala nazaj v službo in le kako naj bi vedela, da jih ni tam?    Črnolaska je odšla prva. Napotila se je naravnost domov in se lotila vrtnarjenja. Presadila je nekaj zelenjave in obrezala vrtnice, potem pa je prišla njena hčerka iz šole in ji je pomagala napraviti domačo nalogo.    Rdečelaska je bila srečna, da je lahko odšla prej, kajti fant jo je povabil na večerjo in je imela tako dovolj časa, da se je lepo uredila in pripravila zanj.    Blondinka je bila zelo vesela, da bo lahko prišla domov prej in presenetila brezposelnega moža. Ampak ko je prišla domov, ga ni bilo nikjer.    Potem je iz spalnice zaslišala čudne glasove. Potiho se je prikradla do vrat spalnice in potihoma odškrknila vrata. Imela je kaj videti. Njen mož je bil v postelji z njeno šefico. Ona je jahala na njem in iz grla so ji prihajali nerazločni zvoki.    Prav potihoma je zaprla vrata in se kradoma izmuznila iz hiše.    Naslednji dan, ob opoldanski kavi, sta črnolaska in rdečelaska objavili, da bosta spet odšli prej iz službe.    Vprašali sta blondinko, če bo prej odšla tudi ona. \"Ni govora,\" je rekla blondinka: \"včeraj bi me šefica skoraj dobila!\"", "Predčasni odhod" },
                    { 1955, true, 29, "Pred zaposlitvijo novega uslužbenca telefonira direktor njegovemu prejšnjemu delodajalcu: \"Koliko časa je delal pri vas?\"    \"Okoli tri dni.\"    \"Kako? Rekel je, da je bil dolgo časa v vašem podjetju.\"    \"To je pa res. Pri nas je bil deset let!\"", "Delovni staž" },
                    { 1929, true, 29, "\"Vi ste bili pa gotovo čudežni otrok!\"    \"Ali res tako mislite, šef?\"    \"Da, verjetno ste pri šestih letih vedeli toliko kot zdaj.\"", "Čudežni otrok" },
                    { 1927, true, 29, "\"Kako dolgo delate v našem podjetju?\" vpraša šef Janeza.    \"Osem let, šef.\"    \"In kaj vam je tu najbolj všeč?\"    \"Vaša tajnica.\"", "Delovna doba" },
                    { 1844, true, 29, "\"Gospod direktor, v vaši odsotnosti vas je iskal gospod, ki je dejal, da vam bo polomil vse kosti.\"    \"In kaj ste mu odgovorili?\"    \"Da mi je žal, ker vas ni!\" ", "Iskali so direktorja" },
                    { 860, true, 32, "Bucek razlaga sosolcem:  Vceraj ni bil moj dan,kar  dvakrat sem bil tepen.  Prvic,ko sem ta staremu pokazal  spricevalo,drugic pa  ko je spoznal,da sem mu   pokazal njegovo.", "Spricevalo" },
                    { 861, true, 32, "Na faksu je cas izpitov.  Med tistimi,ki se potijo,  je tudi student Grega.  Nisem ravno zadovoljen z vasim  znanjem,zato izpita niste  opravili,mu naposled rece  profesor.Grega pa:  Gospod profesor,naj vas   opozorim,da ste pred tem,  da zagresite kaznivo dejanje  prevare.  Profesor zacudeno in ogorceno:  Kako?  Studend:Po kazenskem zakoniku  zagresi prevaro tisti,ki  izrabi neznanje drugega z namenom,  da mu skoduje.", "Kaznivo dejanje" },
                    { 883, true, 32, "Učiteljica: \"Peter, tvoj spis o vašem psu Rolfiju je popolnoma enak, kot od tvojega brata. Ali si ga prepisal?\"    Peter: \"Ne, nisem ga prepisal, samo pes je isti.\"", "Spis" },
                    { 884, true, 32, "Učitelj: \"Marija, na zemljevidu poišči Severno Ameriko.\"    Marija: \"Tukaj je.\"    Učitelj: \"Zelo dobro. Razred, kdo je odkril Ameriko?\"    Razred v en glas: \"Marija.\"", "Odkrivanje Amerike" },
                    { 1745, true, 32, "Profesorica je vstopila v razred in na tabli zagledala narisanega golega moškega.    \"Po končani uri naj se mi javi tisti, ki je narisal tole!\" je dejala.    Javil se ni nihče.    Naslednji dan, ko je vstopila v razred, je na tabli zagledala napis: \"Še vi narišite, kaj mi nudite, pa se bom mogoče javil!\" ", "Gol moški narisan na tabli" },
                    { 1729, true, 32, "Učitelja matematike, ki je vprašal učence tole: \"Avtobus se pelje 60 km na uro v nasprotno smer pa teče potok 3 km na uro jaz pa hodim po avtobusu 2 km nauro v smeri potoka , no koliko sem star?\" Janezek odgovori, kot iz topa: \"24 let gospod učitelj\".    \"Točno!\", pravi učitelj, \"Kako si pa to pogruntal?\".    \"Ni bilo težav\", pravi Janezek Pri sosedu imajo mulca za katerega vsi pravijo da je na pol idiot in star je 12 let.", "Matematična uganka" },
                    { 1671, true, 32, "V šoli se je Barbara pohvalila: \"Mamica je rodila dojenčka!\"    Zgrožena učiteljica, ki je bila že precej za časom, jo je okarala: \"Barbara! Ne reče se tako! Morala bi reči, da je očka kupil dojenčka!\"    \"A, to pa ne. Veste, moj očka nič ne kupi kar lahko sam naredi.\" ", "Barbara se pohvali" },
                    { 1652, true, 32, "Student Tine ob dveh zjutraj  poklice profesorja:  Profesor, ali spite?  Seveda, zakaj sprasujete?  Tine: Zato ker se jaz ucim,   prokleti osel stari", "Sudent" },
                    { 1614, true, 32, "Tilka piše prosti spis o tem, kaj dela čez dan.    Zjutraj vstanem, obrišem pizdo in si umijem zobe. Grem v šolo, se vrnem domov, obrišem pizdo, pojem, napišem domačo nalogo in obrišem pizdo. Potem se malo igram, gledam TV, povečerjam, obrišem pizdo in grem spat. Naslednje jutro pa spet vse od začetka.    Učiteljica je zgrožena in pokliče mamo na pogovor.    Mama pove: \"Tilka je vse prav napisala. Potem, ko se je mož včlanil v stranko SMC, nam stalno na garažna vrata pišejo PIZDA!\"", "Vseskozi briše pizdo" },
                    { 1540, true, 32, "Sin: \"Ata, so končane govorilne ure?\"    Oče: \"Srečo imaš, da si pozitiven vsaj pri verouku! Ker zdaj ti lahko samo še Bog pomaga!\"", "Po govorilnih urah" },
                    { 1499, true, 32, "Učiteljica je nemočna, vsa znervirana reče Bučku: \"Vsaj en teden bi si želela biti tvoja mama.\"    Buček mirno: \"Bom vprašal očeta, mogoče se bo pa dalo urediti.\"", "V razredu obupuje" },
                    { 1474, true, 32, "Uciteljica zgodovine je vprasala Mihca:\"Kaj se je dogajalo po Titovi smrti?\"  \"Po Titovi smrti je bil pogreb.\"", "Pri zgodovini" },
                    { 1344, true, 32, "Bucek zamudil v solo:  Oprostite, ker sem zamudil.  Veste, na avtobuso je negdo  zgubil 500 evrov.  Uciteljica: Priden, in ti si   pomagal iskati, kajne?  Bucek: Ne, ne, jaz sem drzal   nogo na bankovcu. ", "Zamudil v solo" },
                    { 1275, true, 32, "Ucitelica pri naravoslovju:  No, Bucek, povej, koliko kosti  imas v telesu?  On: Najmanj dva tisoc petsto.  Uciteljica: Zakaj pa me nisi vceraj  poslusal, ko sem razlozila, da je v  cloveskem telesu dvesto kosti.  Bucek: Saj sem! Ampak danes zjutraj   sem jedel sardine.", "Naravoslovje" },
                    { 1226, true, 32, "Ucitelj v soli ucencem:  Ce kdo misli, da je neumen, naj  vstane.  Nic. Cez nekaj minut pa le vstane   Bucek.  Ucitelj ga vprasa:   A ti toraj mislis, da si nor?  Bucek: Ne, me pa srce boli, ko  vidim, da samo vi stojite.", "Srce me boli" },
                    { 1221, true, 32, "Sredi studentskega naselja dregne  student prijatelja:  A vidis tisto v mini krilu na oni  strani ceste?  Vidim, dobra macka. Kaj je z njo?  Z njo sem ze veckrat spal...  Res? Kje pa?  Na predavanjih.", "Student" },
                    { 1220, true, 32, "Uciteljica naravoslovja je ucencem  narocila, naj vsak nasteje vsaj   eno cvetico.  Tulipan se je oglasil Peter.  Cudovito!  Metka je nadaljevala: Nagelj.  Uciteljica: Cudovito!  Oglasi se Janezek: Narcisa.  Cudovito! pripomni uciteljica.  Roko dvigne Bucek: Marihuana!  Kaksna roza pa je to? ga strogo  opomni uciteljica.  Bucek: Vem, to ni cvetica,je  pa cudovito!", "Cvetica" },
                    { 1218, true, 32, "V soli se otroci pogovarjajo o krivicah.  Pa uciteljica vprasa:  Kdo mi zna povedati kak primer krivice?  Jasno, prvi se oglasi Bucek:  Velika krivica je, ce mi oce napise domaco  nalogo, zanjo dobim cvek, oce me pa potem  doma se natepe.", "Krivica" },
                    { 1634, true, 29, "Na gradbišču je delal tudi steklar, ki je zamenjal 34 okenskih šip, preden je opazil, da ima počeno steklo na očalih!", "Ni čudno, da so ga odpustili" },
                    { 1217, true, 32, "Medicinska fakulteta.  Profesor vprasa studentko Majo,  koliko sperme se izlije pri enem  orgazmu.  Bodoca zdravnica butne:  Pozirek, mogoce pozirek in pol.", "Pozirek" },
                    { 1202, true, 32, "Miha, ti si reditelj, zakaj je globus prasen?  Verjetno ste s prstom sli preko Sahare.  ", "Prasen globus" },
                    { 1190, true, 32, "Med poukom glazbene vzgoje vprasa  ucitelj Bucka:  Zakaj so nekatere tipke na klavirju  crne, druge pa bele?  Bucek: Bele so za poroko, crne  pa za pogreb.", "Glazbena vzgoja" },
                    { 1175, true, 32, "Ucitelica prinese v razred dve steklenici  in glisto. V eni steklenici ima  vodo, v drugi pa alkohol.  Glisto vrze v steklenico z vodo in ta   v njej veselo zaplava.  Nato jo vrze v steklenico z zganjem,   glista dvakrat zamiga in crkne.  Ucitelica:No, otroci, kaj se lahko iz  tega naucimo?  Prva je v zraku Buckina roka: Pijemo  alkohol, da ne bomo imeli glist.", "Glista" },
                    { 1103, true, 32, "Profesor med predavanjem na  faksu. Njegove oci ves cas pocivajo  na micni plavolaski Maji.  Tej je spogledovanja pocasi dovolj,   zato dvigne roko in vprasa:  Gospod profesor, zakaj ves cas tako  buljite vame?  On: Veste draga studentka, med predavanji   vedno gledam najbolj neumnega studenta,  in ce vidim, da je on razumel snov, ki jo   predavam, potem vem, da so razumeli  tudi drugi!", "Studentka" },
                    { 1099, true, 32, "Med uro matematike se ucitelj zgrozi nad odgovori ucenca. V besu:\"Eden od naju je popolni bedak!\"  Ucenec se mirno vrne v klop. Naslednji dan ucenec ucitelju izroci modro kuverto. Ucitelj: \"Kaj je to?\"  \" Potrdilo solskega psihologa in pedagoga, da sem jaz cisto normalen!\"", "Matematika" },
                    { 1067, true, 32, "Janek v soli opazi, da uciteljica nima sposnjih hlack in jo vprasa kaj ima med nogami. Uciteljica mu odgovori, da pralni stroj. Janezek zgodbo doma pove ocetu, ki mu pravi, da naj vprasa uciteljico, ce lahko pride oprat kaj perila. Janezek naslednji dan vprasa uciteljico kaj mu je narocil oce.   Uciteljica: Ja, lahko, ce ga ima veliko. Ce ga ima malo, pa ga naj kar na roke opere!", "Pralni stroj" },
                    { 1041, true, 32, "V soli.Ucitelj za uvod vprasa  ucence,kje je najlepse.  Pa se oglasi Bucek:  V postelji z lepo zensko!  Ucitelj:Da te ni sram!  O tem bom obvestil tvojega oceta,  prinesi mi belesko!  Naslednji dan vprasa razrednik Bucka:  No,kaj je rekel oce na tvoje  vcerajsne obnasanje?  Bucek:Moj oce se strinja z menoj.  Rekel pa mi je tudi,da ce vi menite  drugace,naj se vas pazim.", "Kje je  najlepse" },
                    { 1035, true, 32, "V soli pri naravoslovju.  Ucitelj vprasa:  No,Bucek,nastej mi tri zivali  Iz Afrike!Bucek:  Lev in dva krokodila.", "Bucek " },
                    { 1004, true, 32, "Pri uri slovenscine ucenci  pisejo solsko nalogo.  Tema spisa je[Ce bi bil direktor]  Vsi se potijo,razmisljajo,pisejo,  le Bucek sedi s prekrizanimi  rokami.Na kaj pa ti cakas?ga po   nekaj minutah vprasa uciteljica.  Bucek:Na tajnico!", "Ce bi bil direktor" },
                    { 964, true, 32, "Uciteljica vprasa v soli malega  Mujo:  Kje si rojen,Mujo?  On: v Kopru.  Glas izza katedra:  Toraj si Slovenec?  Mujo ponosno:Seveda sem Slovenec.  Pa vstane Bucek in vprasa uciteljico:  Trsica,ce se osel rodi v Lipici,  ali je potem lipicanec?  ", "Lipicanec" },
                    { 946, true, 32, "V soli.Ucitelica pise z levo roko   po tabli,ko Bucek vsklikne:  Ucitelica,nimate dlak pod  levo pazduho!  Ona:Bucek,pospravi stvari in pojdi  domov za danes.  Naslednji dan ucitelica med razlaganjem  snovi dvigne desno roko in Bucek  kajpak opazi,da pod pazduho nekaj manjka.  Njej prekipi:Bucek,pospravi stvari  in ostani doma do konca tedna.  Naslednji teden je Bucek znova  v soli,ko uciteljici pade iz rok kreda.  Nagne se,da bi jo pobrala.  Nagne se tudi Bucek,a hip zatem vstane  in zacne pospravljati stvari  Uciteljica ga zacudeno vprasa:  Kam pa ti?  Bucek:Zame je solsko leto koncano.", "Dlake" },
                    { 898, true, 32, "V srednji šoli profesorica napoveduje zadnji preizkus znanja v šolskem letu: \"Nihče ne sme manjkati! Ni opravičila, razen za težje bolezni ali smrt v ožji družini.\"    Seveda se vedno najde kakšen pameten provokator v zadnji klopi: \"Kaj pa v primeru seksualne izčrpanosti?\".    Smeh v razredu.    Profesorica mrtvo hladno: \"Boš pa z drugo roko pisal.", "Zadnji preizkus" },
                    { 886, true, 32, "Kako pravimo osebi, ki govori tudi po tem, ko nismo več zainteresirani?    Učitelj!", "Govorjenje" },
                    { 885, true, 32, "Učitelj: \"Janezek, kako črkuješ besedo petdeset?\"    Janezek: \"P-E-D-E-S-E-T\"    Učitelj: \"Napačno!\"    Janezek: \"Ampak, vprašali ste me kako jo JAZ črkujem.\"", "Črkovanje" },
                    { 1211, true, 32, "Profesor studentu: Za tukajsnjo fakulteto  vasi rezultati ne zadostujejo, zato  bi na vasem mestu poskusil raje z lotom.  Kako to mislite?  No, od 39 izpitnih vprasanj ste na sedem  odgovorili pravilno.", "Loto" },
                    { 215, true, 27, "Zbudi žena moža ob treh zjutraj: \"Dragi, jaz bi seksala!\"  Mož, ves dremoten: \"Pa kje naj zdaj koga najdem ob tem času?\"", "Seks sredi noči" },
                    { 334, true, 41, "Medved naredi zabavo,povabil je vse živali tudi stonogo!Na zabavi so čakali,da pride stonoga.Ko je postala noč so se zabavali,ampak bilo je kmali jutro in odšle so vse živali domov.Na vratih pozvoni stonoga.Medved ji odpre in jo vpraša “zakaj te ni bilo ?” .Stonoga pa vpraša “zakaj si pa na vrata napisal “obriši si čevlje ?", "Stonoga" },
                    { 406, true, 41, "Zajček se napije in zaspi pod drevesom. Mimo pridejo medved, lisica in vovk. Ker se ne morejo odločiti, kdo bo pojedel zajčka, se stepejo in vsi trije nezavestni obležijo. Čez čas se zajček zbudi, pogleda okoli sebe in pravi: \"Kurba, nehat moram pit. Ko se napijem, vedno vse razbijem.\"", "Pijani zajček" },
                    { 1426, true, 43, "\"Daj, Marko, svetuj mi. Ali naj vzamem bogato vdovo, ki je ne ljubim, ali revno študentko, s katero se ljubiva?\"    \"Vzemi študentko, saj denar tudi ni vse.\"    \"Tako bom tudi storil! Hvala za nasvet.\"    \"Malenkost. Kje pa stanuje tista vdova?\" ", "Rabil je nasvet" },
                    { 1424, true, 43, "Mlada gospodična vstopi v modni salon, gre k blagajni in reče prodajalki: \"Danes zjutraj, ko sem pri vas kupovala bluzo ste se zmotili za dvajset evrov.\"    \"To bi mi morali takoj povedati! Sedaj je prepozno za reklamacijo!\"    \"Dobro, potem bom pa obdržala teh dvajset evrov.\" ", "Reklamacija" },
                    { 1422, true, 43, "\"Ste bili že kdaj kaznovani?\"    \"Da, enkrat že.\"    \"Zakaj pa?\"    \"Z glavo sem butal ob zid.\"    \"Zaradi tega pa že niste bili kaznovani!\"    \"Seveda sem bil! Veste, glava ni bila moja!\"", "Na sodišču" },
                    { 1414, true, 43, "Ferdo v lekarni:  Kondome, prosim!  Farmacevtka: Vam dam vrecko  zraven?  Ferdo: Ne, ni treba, ni tako  grda.", "Kondom" },
                    { 1411, true, 43, "Mesar na vratih mesnice pusti listek: \"Jutri bom klal - pravočasno se postavite v vrsto!\" ", "V mesnici" },
                    { 1410, true, 43, "Štefan pride na Brnik in vpraša: \"Koliko časa potrebuje letalo za let od Ljubljane do Frankfurta?\"    \"Samo trenutek.\"    \"Hvala,\" odvrne Štefan in odide domov. ", "Potrebuje informacijo" },
                    { 1409, true, 43, "Predsednik komisije kandidatu: \"Kaj je zavorna pot?\"    \"To je razdalja, ki jo prevoziš od trenutka, ko si se prestrašil, pa do mesta, kjer si se zaletel! ", "Na šoferskem izpitu" },
                    { 1408, true, 43, "Mož vremenoslovec reče ženi: \"Za tri mesece bom šel v Nemčijo.\"    \"Sem si kar mislila, da bo kaj takega. Saj se tu tvoja napoved in vreme redkokdaj ujameta.\" ", "Odpotoval bo" },
                    { 1407, true, 43, "Na vremensko postajo telefonira moški in kara vremenarja: \"Le kako ste lahko napovedali danes dež, ko pa na vremenski sliki in na nebu ni niti enega oblačka?\"    \"Veste, moja hčerka se s kolesom odpravlja na izlet, pa sem ji hotel preprečiti pot!\" ", "Vremenarji lažejo" },
                    { 1406, true, 43, "Vodič razlaga: \"Tu je okostje dinozavra, ki je staro tri milijone in petindvajset let.\"    \"Ste pa strokovnjak! Kako pa veste tako natančno?\"    \"Enostavno. Ko sem prišel sem delat, so mi rekli, da je staro tri milijone let, jaz pa tu delam že petindvajset let.\" ", "V muzeju" },
                    { 1405, true, 43, "Na avtobusu reče sprevodnik potniku: \"Se ne boste usedli?\"    \"Ne. Ker se mi zelo mudi.\"", "Na avtobusu" },
                    { 1404, true, 43, "Frizer: \"Ste naša stalna stranka?\"    \"Ne. Brazgotine po obrazu imam od prometne nesreče.\" ", "Pri frizerju" },
                    { 1402, true, 43, "Kaj je to: \"Ima sto zob in ena usta?\"    Krokodil.    Kaj je to: \"Ima sto ust in en zob?\"    Društvo upokojencev. ", "Uganka" },
                    { 1378, true, 43, "Detektiv v manjši trgovini že petič zapored zaloti isto žensko pri tatvini: \"Povejte mi, zakaj vedno kradete v tej  trgovini?\"    \"Ker je tu najceneje.\"", "Zaloti jo pri kraji" },
                    { 1377, true, 43, "\"Kaj??? Osemdeset let si star pa se boš poročil? Koliko jih ima pa tvoja zaročenka?\"    \"Šestnajst jih bo prihodnji mesec.\"    \"In kdaj bo poroka?\"    \"Ne vem še, ker njeni stari nekaj brez veze komplicirajo.\"", "Poročil se bo" },
                    { 1369, true, 43, "Kaj pomeni \"vegetarijanec\"?    To je stara indijanska beseda za \"slab lovec\"!", "Vegeterjanec" },
                    { 1366, true, 43, "Leta 1984 se v centru mesta zaletita dva Trabanta.    Nesreča je terjala 2 smrtni žrtvi in 53 poškodovanih.    Smrtni žrtvi sta bila voznika, tistih 53 se je pa steplo za rezervne dele.", "Kolateralna škoda" },
                    { 1365, true, 43, "Premalo moškega, da bi bil gradbenik.    Premalo pedra, da bi bil modni oblikovalec!", "Definicija arhitekta" },
                    { 1348, true, 43, "Francelj je imel prometno nesrečo. Zaradi poškodb so mu morali odstraniti moda. Nekaj časa je še šlo, nato pa je imel zaradi izgube moškosti vse več težav.    Po pomoč se je zatekel k psihiatrom, a prepričevanje, da zadeva ni tako huda, kot se mu zdi, ni zaleglo. Rešitev je videl samo še v samomoru.    Odpravi se na most, da se bo vrgel v reko. Kmalu se okoli njega nabere gruča ljudi in celo najboljši psihiatri ga ne morejo odvrniti od namere. Policist, ki patruljira v bližini, se približa množici in ko mu povejo, da hoče Francelj narediti samomor in zakaj, stopi k njemu, pogleda v globino in mu nekaj reče.    Francelj se enkrat pogleda v reko, stopi z roba mostu in se odpravi domov.    \"Kako vam ga je uspelo prepričati, kaj ste mu rekli?\" je radoveden psihiater. \"Nič posebnega. Samo doli sem pogledal in mu rekel:\" Za to, da se vržeš tu dol, moraš pa res imeti jajca.\" ", "Obupal je" },
                    { 1345, true, 43, "Starejša gospa je sedela na klopci v parku in s kruhom krmila golobe.    Drobne koščke belega kruha je metala okoli sebe in klicala ptice.    Mimo je prišel mladenič, jo nekaj časa opazoval, nato pa pristopil k njej in ji očital: \"Vi mečete hrano stran, v Afriki pa otroci stradajo!\"    \"O, mladenič, jaz sem pa že prestara, da bi kruh lahko vrgla tako daleč!\"", "V parku krmi golobe" },
                    { 1343, true, 43, "Ocitno sem hudo seksi,     zivljenje me nonstop  jebe!  ", "Seksi" },
                    { 1339, true, 43, "Jezus visi na križu in v urah, ko čaka na smrt, pogleda v nebo in reče: \"Oče, priporočam se ti! Če si lahko v teh mučnih urah dovolj milosten, da umakneš te žeblje iz mojih dlani!\"    Poof! In žeblji izginejo!    Jezus se počasi začne spuščati iz križa, vmes pa vpije: \"Še noge! Noge!\"", "Jezus na križu" },
                    { 1331, true, 43, "Kako se pozdravi AIDS?    Zdravo, AIDS!", "Pozdraviti AIDS" },
                    { 1330, true, 43, "Kako se jamarji orientirajo v jami, kadar vse drugo odpove?    Z glavo močno trešči v zid in potem se lahko orientira po zvezdah. ", "Jamar in orientacija" },
                    { 1329, true, 43, "Zakaj je zemlja ženskega spola?    Ker nihče ne ve, koliko je stara. ", "Zemlja" },
                    { 1318, true, 43, "Kdo je največji angleški pizdun? Johny Šemedej    Najbolj potrebna Romunka? Scuro Popesku    Štajerc po kitajsko? ČujTi KjeJešankčuj    Kitajski minister za šport? Do Ping ", "Miks jezikov" },
                    { 1314, true, 43, " Prijatelja sedita preed   lokalom in eden rece:  Ej, ali vidis tista dva plesca?  Ja. In kaj je z njima?  Na las sta si podobna.", "Podobnost" },
                    { 1311, true, 43, "V letalu neki moški stopi k stevardesi in jo prosi: \"Gospa, a bi lahko dobil tamajhno stekleničko kakršnega koli alkohola?\"    \"Seveda. Kaj se je pa zgodilo?\"    \"Neki ženski je postalo slabo!\"    Stevardesa odhiti v prostor s pijačo in ko se vrne, ji moški dobesedno strga steklenico iz rok in začne piti.    Stevardesa: \"Kaj pa zdaj to pomeni?\"    \"Šele zdaj mi je odleglo! Veste, ne prenesem, če vidim koga, ki mu je slabo!!!!\"", "Na letalu ne nekomu slabo" },
                    { 1301, true, 43, "Ko se Joža znajde v skupini lepih deklet, zavzdihne in komentira: \"Moral bi biti ginekolog.\"    \"Zakaj pa?\" ga vpraša Anže.    \"Vsa dekleta bi se slačila pred menoj pa še plačevala bi mi za to!\"", "Želja" },
                    { 1429, true, 43, "Vsakdo zna plesati.    Res, vsakdo.    Razlika je samo v tem, kolikšno količino vodke mora popit.", "Znanje plesa" },
                    { 1300, true, 43, "\"Nočem skopuha! Vračam ti prstan, baraba!\"    \"Kje je pa škatlica????\"", "Skopuh" },
                    { 1438, true, 43, "Ne morem na internet.  Ali ste prepricani, da ste  vtipkali pravo geslo?  Seveda, saj sem videl, kako  ga je vtipkal prijatelj.  Kaj pa je vtipkal?  Pet zvezdic.  ", "Pet zvezdic" },
                    { 1459, true, 43, "Gresta moz in zena na balet.  Zena: Ti spis?  Moz: Ne.  Zena: Ti res ne spis?  Moz: Ne bodi tecna, ce ti pravim, da ne spim.  Zena: Zakaj pa potem hodijo po prstih?", "Balet" },
                    { 1566, true, 43, "Kako se italijansko reče ginekolog?    Remonti de pičoza.", "Ginekolog po italijansko" },
                    { 1565, true, 43, "Kako se po italijansko reče mini krilo?    Panorama de pičoza.", "Mini krilo po italijansko" },
                    { 1563, true, 43, "Zakaj je modrček dražji od moških spodnjic?    Ker je mleko dražje od jajc.", "Razlika v ceni" },
                    { 1562, true, 43, "Suzana kupuje lutko iz čokolade.    \"Naj ti dam deklico ali dečka?\" vpraša prodajalka.    Suzana: \"dečka, ima več čokolade.\"", "Nakup čokolade" },
                    { 1560, true, 43, "Trije dečki so se na igrišču pogovarjali o tem, kako je pri njih doma: \"Pri nas smo trije otroci in vsak ima svoj pribor za hrano!\" se je pohvalil prvi.    \"Pri nas je šest otrok in vsak ima svojo sobo!\" je rekel drugi.    \"Pri nas je sedem otrok in vsak ima svojega očeta!\" se je oglasil še tretji.", "Pogovor med tremi dečki" },
                    { 1559, true, 43, "Fant: \"Vse geje in bi bilo potrebno obesit, in ženske nebi smele imet isti pravic kot moški.\"    Dekle: \"Kakšen primitivec, sigurno si desničar.\"    Fant: \"Pravzaprav sem musliman in to so moja verska prepričanja.\"    Dekle: \"Joj! Se opravičujem, upam da me nimaš za islamofobno.\"", "Hitro si je premislila" },
                    { 1558, true, 43, "Pride musliman, ves sestradan, v Slovenijo.    To opazi prijazen možakar in mu ponudi svinjski golaž.    Musliman: \"Opa, tole mi pa vera ne dovoljuje.\"    Možakar mu takoj zažuga nazaj: \"Aha! Še prišel nisi dobro, pa imaš že Slovenko za dekle.\" ", "Prihod muslimana v Slovenijo" },
                    { 1547, true, 43, "Pride moški v apoteko: \"A imate kaj proti kašlju?\"    Lekarnar: \"Ne, nič nimam proti. Vi kar kašljajte.\"", "Kašelj" },
                    { 1545, true, 43, "Sodnik obravnava obtoženca, ki je ukradel mobilni telefon: \"A vas ni sram, da pri vaših letih ukradete tak mobilni telefon?\"    \"Nič me ni sram. Le zakaj bi me bilo? V mojih mladih letih takega telefona sploh še ni bilo!\" ", "Sodijo mu zaradi kraje" },
                    { 1541, true, 43, "Ko sem videl, kakšne so cene v apoteki sem prišel na idejo, da je bolj poceni odditi in kar umreti.", "Groza, kakšne cene" },
                    { 1539, true, 43, "Stara mama se pelje s taksijem.    Ko prispe na cilj ga mamica vpraša: \"Sine, koliko stane ta vožnja?\"    Taksist: \"10EUR, gospa.\"    Ženica mu izroči petaka in hoče izstopiti.    Taksist: \"Gospa, vožnja ni 5EUR, ampak 10!\"    Ženica: \"Saj pa si se ti tudi peljal.\"", "Plačilo za taksi vožnjo" },
                    { 1536, true, 43, "Moški se sprehaja po potki mimo umobolnice.    Naenkrat zasliši: \"Štirinajst, štirinajst, štirinajst, ...\"    Ne ozira se in gre dalje.    Glas postaja vse glasnejši in moški opazi luknjico v zidu. Ker ga je zanimalo, kaj se dogaja na drugi strani je pokukal skozi luknjico.    V tistem trenutku ga nekdo močno, s prstom, piči v oko.    Glas na drugi strani: \"Petnajst, petnajst, petnajst, ...\"", "Sprehod mimo umobolnice" },
                    { 1532, true, 43, "Gresta dva pedofila po ulici in srečata sedemletno deklico.    Ko jo vidita, reče eden: \"A veš, kako je bila tale mala dobra pred par leti.\"", "Pedifila na ulici" },
                    { 1530, true, 43, "Kako se po japonsko reče gej?    Na kitu mi najaši.", "Po japonsko" },
                    { 1529, true, 43, "Kaj dela narkoman pod božično jelko?    Paket čaka.", "Optimizem" },
                    { 1508, true, 43, "Visoko nad Atlantikom leti letalo, polno slovenskih potnikov.    Miren let prekine močna turbulenca, iz stropa padejo kisikove maske, po zvočniku pa se zasliši obvestilo, da letalo strmoglavlja.    Marta, ženska srednjih let, panično skoči iz svojega sedeža in zakriči: \"Bogpomagaj, če bom umrla, si pred tem želim še enkrat počutiti se kot prava ženska!\"    Po izrečenih besedah odvrže svoje obleke in vpraša sopotnike: \"Je na letalu kakšen moški, ki mi lahko pomaga, in mi da občutek, da sm ženska?!\"    Vstane še Štefan, si odpne srajco in jo vrže v njeno smer: \"Evo, speglaj mi tole!\"", "Letalo bo strmoglavilo" },
                    { 1502, true, 43, "Na meji, tovornjak pelje iz Hrvaške v Slovenijo, carinik vpraša šoferja: \"Kaj prevažate?\"    Šofer: \"Nič, v tovarno grem po novo pošiljko kondomov.\"    Carinik: \"Odprite cerado.\"    Šofer odpre, carinik pokuka notri in ga skoraj kap; kamion je poln nosečih žensk.    Takrat se voznik udari po čelu: \"Oh, seveda, oprostite, pozabil sem, danes je petek in v firmo vračamo reklamacije.\"", "Tovornjak na meji" },
                    { 1501, true, 43, "V veleblagovnici sredi Kranja: \"Potrebujete prodajalke?\"    \"Ne, dovolj jih imamo.\"    \"Potem mi pa pošljite kakšno, že pol ure čakam na postrežbo.\"", "V veleblagovnici" },
                    { 1494, true, 43, "On: Na radio Velenje med oddajo \"v živo\" nekdo pokliče:    \"Dobar dan, tukaj Safet iz Veleja.\"    \"Pozdravljeni, Safet, kaj bo dobrega?\"    \"Danas zjutra sam u Velejaparku našu denarnico z dost denara i dokumenti.\"    \"Koliko pa je denarja?\"    \"Malo više čez tri tisuč evrov, i kartice.\"    \"A se da iz dokumentov razbrati, kdo je lastnik?\"    \"Da, to je neki Karl Benko, iz Veleja.\"    \"In kako lahko gospod pride do vas?\"    \"Jok, ne zovem radi toga. Zavrtite čoveku jedan dobar komad!\"", "Najditelj pokliče na radio" },
                    { 1492, true, 43, "Kaj so to mešani občutki?    Punca ti pošlje SMS, da sta končala.    Čez čas ti pošlje še enega, da SMS ni bil poslan na pravo številko.", "Mešani občutki" },
                    { 1490, true, 43, "Kaj je podobnost med WCjem in smrtjo?    Ko moraš it, moraš it.", "Podobnost" },
                    { 1488, true, 43, "En tip je tako neroden, da je zadnjič padel, pa je še tla zgrešil.", "Nerodnost" },
                    { 1485, true, 43, "Zadnjič sem videl eno punco. Tako zelo je škilila, da so ji, ko je jokala, solze po hrbtu tekle.", "Hudo škili" },
                    { 1477, true, 43, "\"V zadnjem času prejemam grozilna pisma,\" se potoži Milan prijatelju.    \"Povej policiji, pa ti bodo pomagali!\"    \"Ne verjamem. Pisma so namreč iz davčne uprave.\"", "Grožnje" },
                    { 1476, true, 43, "\"Odkar te poznam ne morem več ne piti in ne jesti!\" je zavzdihnil mladenič svojemu dekletu.    \"Kaj? Tako zelo me ljubiš?\"    \"Ne, bankrotiral sem!\" ", "Sveža ljubezen" },
                    { 1475, true, 43, "\"Slišala sem, da si se poročila z boksarjem. Si srečna?\"    \"Seveda, čudovit je. Nikoli ni dolgočasen.\"    \"Kako to misliš?\"    \"Vsak večer, ko se vrne domov, izgleda drugače.\"", "Poročena z boksarjem" },
                    { 1468, true, 43, "Zakaj se Bozicek vozi s sanmi z jelencki?  Ker je bencin predrag.", "Bozicek in sani" },
                    { 1465, true, 43, "\"Zakaj imajo lahko lovci in ribiči svoje družine, jaz pa ne?\"    Je rekel gej.", "Ni fer" },
                    { 1461, true, 43, "V vrtcu je deklica rekla fantku: \"Zdaj pa vem zakaj ste fantje pri teku hitrejsi od nas deklet. Zato ker imate med nogami prestavno rocico in kroglicne lezaje.", "Hitrejsi" },
                    { 1440, true, 43, "V mestu sta se srečali prijateljici in ena je ogovorila drugo:  \"Slišala sem, da si se poročila. Si srečna v zakonu?\"    \"Kje pa! Moj mož je impotenten. Ne more ne seksati ne imeti otrok.\"    \"Pa tega nisi vedela že prej?\"    \"Pred poroko je sicer večkrat govoril o nepremičnini, toda jaz sem mislila, da ima hišo ali pa vikend.\"", "Na novo omožena" },
                    { 1284, true, 43, "Joža pelje svojo izbranko v Ljubljano.    Ko se nekaj časa sprehajata, jo vpraša: \"Draga, bi se hotela peljati po Ljubljani z velikim Mercedesom in šoferjem?\"    \"Seveda, zelo rada.\"    \"Prav. Pa pejva na avtobus!!!\"", "Sprehod po Ljubljani" },
                    { 1269, true, 43, "Poklicali ste 113, klic v sili,   prosim.  Dve punci se tepeta zame!  In kje je tu problem?  Grda punca zmaguje!", "Klic v sili" },
                    { 1261, true, 43, "Kaj pocne crnogorski   virus v racunalniku?  Ne vem.  Nic.", "Crnogorski virus" },
                    { 1076, true, 43, "Lojze stopi v vaško gostilno, sede na stol zraven neke gostje in naroči šampanjec.  Ko se ona naenkrat obrne proti njemu: \"Zanimivo, tudi jaz sem naročila šampanjec.\"  On: \"Kakšno ujemanje! Zame je danes poseben dan, proslavljam pomemben dosežek.\"  Ona: \"Tudi jaz imam danes razlog za slavje.\"  Lojze: \"Kakšno sovpadanje! Kaj pa proslavljate?\"  Ženska: \"Z možem sva se dolgo neuspešno trudila, danes pa mi je ginekolog povedal, da sem naposled noseča.\"  On znova: \"Neverjetno ujemanje. Moje kokoši na farmi so bile dolgo neplodne, danes pa se vse znesle oplojena jajca.\"  Ona: \"Sijajno. Kako pa je to uspelo?\"  Lojze: \"Zamenjal sem petelina.\"  Gostja: \"Kakšno ujemanje!\"", "Razlog za slavje" },
                    { 1075, true, 43, "Možakar pride s prelepo žensko k zlatarju, nabereta za več kot 50.000 evrov draguljev in nakita.    Kupec mirno vzame ček in nanj zapiše zahtevani znesek. A zlatar je nezaupljiv.    Takrat neznanec: \"Vem, skrbi vas, če je ček pokrit. Takole bova napravila: ker je danes petek in so banke že zaprte, obdržite ček in dragulje. V ponedeljek, ko boste ček unovčili, pa nakit pošljite h gospodični. Velja?\"    Zlatar je vidno olajšan.    Pride ponedeljek, zlatar hoče unovčiti ček, a ta nima kritja. Nemudoma pokliče kupca, ta pa: \"Ček kar vrzite, tri noči z gospodično so mi bile povsem dovolj.\"", "Nakup zlata" },
                    { 1072, true, 43, "Med slovensko mirovniško vojaško odpravo v Bosni se, bolj ali manj naključno, znajde tudi Korel.    Gleda, kako vojak Nata dela sklece.    Nekaj časa opazuje, nakar reče: \"Naj me vrag, če ti ona ni pobegnila\"", "Na mirovni misiji" },
                    { 1068, true, 43, "Maja stopi v lekarno:  Imate kondome XXL?   Lekarnar: Imamo. Jih   boste vzeli?  Maja: Ne, bom pa pocakala, da  vidim, kdo jih bo kupil.", "Lekarna" },
                    { 1058, true, 43, "Ko je princ spustil hlače, je Sneguljčica zagledala osmega palčka.  Zakonska zveza je grob poseg v moško zasebnost!  Zakaj hudiča je beseda \"moškost\" ženskega spola?  Liter vina žensko zelo polepša, še posebej, če ga spije moški!  Zaradi lepih nog je postala slavna. Njena slava se širi!  Zvesta žena spi samo z možem! Z ostalimi je budna!  Pri sodobnih Julijah ima največ uspeha Alfa Romeo!  Žeja me je napadla, pil sem v samoobrambi!  Če se hočete poročiti, vzemite lepotico. Lažje se je boste potem znebili!  Če želite videti prijazni nasmeh svoje žene, jo peljite k fotografu.  Nekatere ženske imajo hladne trajne, druge pa so trajno hladne.  Nevesta v belem, vdova v črnem, vse je to isto. Spet je eden moški nehal živeti.", "Pregovori in resnice" },
                    { 1056, true, 43, "Kaj narediš, če ne moreš bruhati?  - Vtakneš si desni kazalec v usta!    Kaj pa, če še ne gre?  - Vtakneš še levi kazalec v rit!    Kaj pa, če res ne gre in ne gre?  - Zamenjaš kazalca", "Kako bruhati" },
                    { 1054, true, 43, "Ljubi tudi svojo sosedo.    Ampak pazi, da te ne dobijo!", "Nauk" },
                    { 1052, true, 43, "Moški, varčujte z vodo!    Tuširajte se skupaj s svojo prijateljico.", "Moški in varčevanje" },
                    { 1051, true, 43, "Zelo rad imam živali.    Če so pa tako okusne!", "Ljubezen do živali" },
                    { 1050, true, 43, "Denar ni vse.    Tu je še Mastercard in Visa.", "Denar" },
                    { 1048, true, 43, "Janez pelje sina v šolo. Preden gre Miha v šolo, ga oče povabi na en sok v gostilno čez cesto.    Ko sedita na terasi se mimo pripelje zjahan Clio star 15 let.    Miha vpraša očeta: \"Oči, kdo je ta stric?\"    Oče odgovori: \"To je Franc, garač in poštenjak ki že celo živjenje gara in ni nikdar prekršil nobenega pravila.\"    Nakar se mimo pripelje velik svetleč mercedes.    Miha vpraša očeta: \"Oči kdo je pa ta stric?\"    Oče odgovori: \"To je sin od Zokija, nikoli v življenju ni nič kaj pametnega delal. Ogoljufal je veliko ljudi in krši vsa pravila.\"    Miha se zamisli in reče: \"Oči, ko bom velik bom sin od Zokija.\" ", "Sina pelje v šolo" },
                    { 1047, true, 43, "Kaj je to uravnovešena dieta?    Kos torte v levi in desni roki. ", "Dieta" },
                    { 1026, true, 43, "Sosed, danes si pa videti zelo utrujen.  Res je. Celo noc me je tlacila nocna mora.  In kaj si sanjal?  Da sem porocen s tvojo zeno!", "Porocen" },
                    { 1024, true, 43, "Kdaj je Bog prvič preklinjal?    Takrat, ko je naredil črnca.    Ko ga je videl, je rekel: \"Jebemomater, ta se mi je pa zažgal.\"", "Bog preklinja" },
                    { 1021, true, 43, "Bedak je ulovil zlato ribico, ki mu je v zameno, da jo izpusti, izpolni tri zelje.  1. Zelim si, da bi se vsi Americani preselili v Rusijo.  2. Zelim si, da bi se vsi Rusi preselili v Ameriko.  3. Zelim si, da bi se vsi vrnili od koder so prisli in srecno ziveli naprej.  Zlata ribica: Kaj, to vendar nima smisla, ti si nor. Zakaj bi si to kdo sploh zelel?  Bedak: Povzrocil sem kaos!", "Tri zelje" },
                    { 1018, true, 43, "Maja pri zdravniku.  Gospod doktor,koliko bi morala  biti visoka za svojo  tezo?  Zdravnik jo premeri s pogledom:  Kake stiri metre,gospa.  Nakar Maja olajsano:  Sem si mislila.Tudi jaz vsem  govorim,da sem majhna,premajhna,  oni pa vsi trdijo,da sem  debela kot svinja.  ", "Maja olajsana" },
                    { 1016, true, 43, "Se pogovarjata dva malčka v otroškem vrcu.    Uroš: \"Lok, Lok! Ves, vceraj sem pa videl olagumi gol na ladjatolju.\"    Rok: \"Kaj je to ladjatol?\"", "Dva malčka v vrtcu" },
                    { 1000, true, 43, "Sreče si z denarjem ne moreš kupiti.    Lahko pa si kupiš motor, kar je dokaj blizu.", "Denar in sreča" },
                    { 961, true, 43, "Mož in žena se peljeta po avtocesti in pogovor nanese na varanje.    Mož: \"Že šest let te varam s svojo tajnico. Ne morem več biti tiho, moral sem ti povedati.\"    Žena zgrabi lovski nož možu, kar med vožnjo, odpne hlače in mu odreže tiča. Brez pomislekov ga vrže skozi strešno okno (šibedah).    Za tem avtom se peljeta oče in 7 letna hčerka. In ud prileti ravno gor na njuno vetrobransko steklo.    Hčerka: \"Ati, kaj je to? Mene je strah!\"    Oče: \"Ne skrbi, to je samo žužek.\"     Hčerka: \"Ampak tale žužek je imel pa res ogromnega kurca.\"", "Priznal, da jo vara" },
                    { 949, true, 43, "Kaj je podobnost med push-up modrčkom in čipsom?    Takoj, ko ju odpreš vidiš, da sta na pol prazna.", "Push-up in čips" },
                    { 947, true, 43, "Polde,Korel in Pepca sedijo v kinu.  Vrtijo vojni film s polno streljanja,  ko Pepca zasepeta svojemu dragemu:  Polde,mislim,da bom prdnila.  On:Daj,pocakaj malo,da priletijo   letala in zacno metati bombe.  Prdni takrat,nihce te ne bo slisal.  In res,Pepca se nekaj zadrzuje,  nakar se na platnu le pojavi  letalska eskadrilja.  Odleze ji in seveda spusti,kar  je mukoma zadrzavala.  Takrat Polde:  U,jebemti,budale so bombadirale  mestno kanalizacijo.", "Kino" },
                    { 938, true, 43, "Zakaj Einstein ni mogel zgraditi hiše?    Ker je imel samo en kamen.", "Einstein in hiša" },
                    { 936, true, 43, "Berto se znajde pred sodnikom.  Ta ga vprasa:  Lahko razlozis,zakaj si kradel?  Berto:Saj nisem,gospod sodnik,nisem!  Sodnik:Kako nisi?  Saj sta te vidli kar dve prici.  On:Res nisem,jaz imam kar sto pric,  ki me niso videle krasti.  Prisezem!  ", "Prisezem" },
                    { 935, true, 43, "Korel primerno opogumljen z maligani  vstopi na mestni avtobus,ki vozi  pod Pohorje.  Naenkrat zacne kricat:  Tisti zadaj ste navadni usraneti,  vi v sredini budale,vi spredaj  pa veliki drekaci!  Soferju prekipi,naglo pritisne  na zavoro:  Pijanec nesramni,ponovi,kaj si rekel!  Korel:Saj bi,pa nevem vec.  Tako blesavo in sunkovito si zavrl,  da so se vsi pomesali!    ", "Pijanec" },
                    { 917, true, 43, "Človek pride v salon Mercedes, na mizo položi torbico z denarjem, da bi kupil avto znamke Mercedes.      Blagajničarka prešteje denar, vendar mu manjka 1 cent.      Jezen gre iz salona, stopi do berača in mu pravi: \"Daj mi prosim en cent, da kupim mercedesa.\"      Berač mu pomoli dva centa: \"Evo ti dva, pa kupi še meni enega.\"", "Zmanjkalo mu je en cent" },
                    { 906, true, 43, "Dva prijatelja se pogovarjata.    Prvi: \"Danes sem eno luštno punco rešil pred posilstvom!\"    Drugi: \"Kako?\"    Prvi: \"Samokontrola, prijatelj, samokontrola.\"", "Rešitelj" },
                    { 903, true, 43, "Zakaj je pračlovek svojo žensko vlekel za lase?    Če bi jo vlekel za noge, bi imela pizdo polno prahu in zemlje.", "Pračlovek" },
                    { 896, true, 43, "AVTOBUS - vozilo, ki gre dvakrat hitreje kadar tečete za njim, kot če se v njem peljete  PULOVER - oblačilo, ki ga mora nositi otrok, kadar mamo zebe  PLES - vertikalna projekcija horizontalne želje  EKONOMIST - ekspert, ki bo jutri vedel, zakaj se tisto, kar je včeraj predvidel, ni zgodilo danes  GINEKOLOG - oseba ki dela tam kjer se drugi zabavajo  INTELEKTUALEC - oseba, ki je dve uri v stanju misliti še na kaj drugega razen na seks  MIGRENA - največkrat uporabljena kontracepcija pri ženskah  ZAKON - skupnost v kateri dva rešujeta probleme, ki jih ne bi imela, če bi ostala samska  ZOBOZDRAVNIK - čarovnik, ki vam v usta vstavlja tisto, kar vam je pobral iz žepa  PESIMIST - optimist, ki ima izkušnje  PROGRAMER - oseba, ki na nepojasnjen način reši probleme, za katere nisi vedel, da si jih imel  PSIHOLOG - oseba, ki gleda ostale, ko v prostor stopi lepa ženska  BUDILKA - inštrument, ki je bil narejen za bujenje tistih, ki nimajo majhnih otrok  ZVEZDA - oseba, ki celo življenje težko dela, da bi bila slavna, ko pa to doseže, nosi velika črna očala, da bi je nihče ne prepoznal", "Definicije" },
                    { 887, true, 43, "Ne morem razumeti ljudi, ki pravijo, da se pripravljajo za v posteljo.    Jaz sem vedno pripravljen za v posteljo.", "Priprava za posteljo" },
                    { 1077, true, 43, "Novinarka hodi po tržnici, pripravlja reportažo o sobotnem utripu.    Sprašuje ljudi in stopi tudi do branjevke: \"Mi lahko poveste, zakaj je vaša roba tako draga?\"    Ženica: \"Ni draga, dete moje, ni, le ti si se slabo omožila.\"", "Na tržnici" },
                    { 1080, true, 43, "Korel in Polde se po opravljenem tečaju zaposlita kot pilota bojnih pilatusov Slovenske vojske.    Čaka ju prvi polet.    Vzlet uspe, tudi polet od Brnika do Cerkelj opravita brez težav, potem pa gorje! Pristajalna steza je nenadoma velika krajša od tiste na simulatorju, kjer sta vežbala.    Napneta vse moči, posrkata vse znanje in še več, aktivirata vse zavore in se spustita na asfalt. Od gum na kolesih se kadi, a sreča jima je mila, nepoškodovana se ustavita na bližnji njivi med koruzo.    \"Idioti neumni, kako se naredili to stezo,\" benti Korel in snema čelado. \"Saj nima več kot sto metrov!\"     \"Točno,\" ves preznojen doda Polde, \"glavno jim je, da je široka skoraj kilometer ...\"", "Pilota pilatusov" },
                    { 1081, true, 43, "Korel gre s prijateljem v hribe pa nabašeta na skupino, ki se je šla bungee jumping.    \"A poskusiva še midva?\" vpraša Korel.    \"Ni šans!\" je odločen kamerad. \"Na ta svet sem prišel zaradi ene strgane gume. Ne bom tudi šel z njega zaradi istega razloga.\"", "Bunee jumping" },
                    { 1084, true, 43, "Razvojne faze neke ljubezni:    1.romanticna,    2.eroticna,    3.nevroticna,    4.skleroticna.", "Faze ljubezni" },
                    { 1251, true, 43, "Zenska je vlazna, pa ne gnije.  Penis je trd, pa nima kosti.  Svet je okrogel, seksajo pa  na vsakem vogalu.", "Tri cuda sveta" },
                    { 1249, true, 43, "Mujo vstopi v avtobus poln  crncev.  Pogleda naokoli in rece:  Ali je tukaj morda gorelo?", "Ogenj" },
                    { 1248, true, 43, "Razlika med Švico in Slovenijo:  - Švicarji imajo luknje v siru  - Slovenci pa na cestah", "Švica in Slovenija" },
                    { 1243, true, 43, "Kdaj se bolj lažemo?    1. aprila ali 14. februarja?", "Laži" },
                    { 1242, true, 43, "Starejša ženska se sprehaja po parku. Srečala je mlad par, ki se je muckal na klopci.    Ne more si kaj, da ju nebi ogovorila: \"Joj, kako lep par sta! Kako dolgo sta že poročena?\"    Fant: \"Pet let.\"    Punca: \"Jaz pa tri.\"", "Muckanje v parku na klopci" },
                    { 1237, true, 43, "Striptizete se, pri nas, imenujejo \"eksotične plesalke\".    Tako bi se lahko dilerji imenovali \"eksotični farmacevti\".", "Poimenovanje" },
                    { 1236, true, 43, "Pri mladih parih dekleta jemljejo tableto.    Pri starih parih pa moški.", "Časi se spreminjajo" },
                    { 1234, true, 43, "Pet črnih, ožganih, vžigalic sreča eno neuporabljeno, z rdečo glavo.    Na glas se začnejo krohotati.    Rdeča vžigalica: \"Kaj je narobe?\"    Črne: \"A tebe pa še nobeden ni kresnil?\"", "Srečanje vžigalic" },
                    { 1229, true, 43, "Ali ste vedeli, da je več letal v morju, kot podmornic v zraku?", "Neverjetno" },
                    { 1228, true, 43, "Tri lenobe so lezale v sadovnjaku.  Z drevesa je padel sadez in   prvi rece: Z drevesa je padlo jabolko!  Nato sledi enourna tisina, nakar se  oglasi drugi:   Ne, ni bilo jabolko, bila je sliva!  Zopet ura tisine, nato pa tretji  vstane in rece: Jaz grem!  Ne morem vaju poslusat, kako se  stalno prepirata.", "Lenobe" },
                    { 1227, true, 43, "Polde pusti avto na parkiriscu.  Ker so mu vanj ze veckrat   vlomili, na vetrobransko steklo  nalepi listek z napisom:  Ne vlamaj nimam avtoradia!  Cez poldrugo uro se vrne, avta pa  nikjer. Na tleh opazi listek, na njem  pa napisano: Ne sekiraj se, ga bomo ze   sami zmontirali!", "Ne sekiraj se" },
                    { 1224, true, 43, "Kje je pa vas moz, gospa  Cilka? Doma s svojim stirinoznim   prijateljem.  O, nisem vedla, da ste kupli psa.   Saj ga nismo, mislila sem kavc  pred televizorjem.", " Kavc" },
                    { 1209, true, 43, "Mali vragec prileti v New York in reče: \"Jaz sem mali vragec, imam mali kuferček in prišel sem krast.\"    Takoj na letališču ga pristojni obrnejo in rečejo: \"Tu ne moreš krasti, pojdi v Anglijo.\"    Poleti tja in spet ista zgodba: \"Jaz sem mali vragec, imam mali kuferček in prišel sem krast.\"    Organi ga takoj obrnejo in pošljejo v Nemčijo: \"Pojdi tja pa tam kradi, tam se krade.\"    In poleti v Nemčijo ... Prileti na letališče in reče: \"Jaz sem mali vragec, imam mali kuferček in prišel sem krast.\"    Tamkajšnji ga takoj dajo v rikverc in rečejo: \"Obstaja ena država tam doli nižje, Slovenija, tam se krade na veliko, nihče ne odgovarja za nič in ne gre v zapor. Tja pojdi.\"    Vragec res takoj poleti v Slovenijo, pristane na aerodromu na Brniku in reče: \"Jaz sem mali vragec, imam ... mali ... mali ...,,kje je moj kuferček, mater vam lopovsko ... !!!\"", "Mali vragec" },
                    { 1185, true, 43, "Janez stopi iz trgovine, v eni roki  ima dve pasteti, v drugi cokolado...  Ustavi ga gospod:  Dober dan, sem davcni inspektor.   Imate racun?  Nimam.  A veste, da je kazen 40€, ker za robo,   ki ste jo kupili, nimate racuna?  Saj nisem kupil... Ukradel sem...  Ah, potem pa je v redu.", "Racun" },
                    { 1571, true, 43, "Nekoč je v deželi za devetimi gorami živela prelepa princesa.    Za njo se je govorilo da ima najlepše prsi pod soncem in tako je beseda o njih prišla tudi na uho Marjana, vaščana.  Ko je nekega dne videl princeso, je spoznal da so govorice resnične in da so njene prsi res popolne.  Njegov življenjski cilj je postal da jih nekoč boža in poljublja.  Za pomoč je prosil grajskega zdravnika, s katerim sta bila v dobrih odnosih.  Zdravilec: \"Poglej Marjan...lahko ti pomagam. Vendar to te bo stalo 1000 zlatnikov.\"  Marjan ni mislil na to kako bo dobil denar, želel je le prsi, zato je privolil.  Tako se je zdravilec na skrivaj splazil v sobo ko se je princesa kopala.  Potresel je nekaj prahu ki povzroča srbenje na njen modrček. Nato je šel iz sobe.  Pričakovano je naslednji dan princesa imela srbečico po celotnih prsih.  Zdravilec je stopil do kralja in mu rekel: \"Poznam vaščana, ki zna to ozdraviti. Marjan mu je ime.\"    In tako je kralj poslal po Marjana.  Ko je prišel na grad mu je zdravilec kot da se prvič vidita povedal:  \"Marjan. Princesa ima srbečico po prsih. Edini način da se ozdravi je, da jo ti po njih božaš in jih poljubljaš  s svojimi magičnimi usti.\"  Tako je naslednje 4 ure Marjan prebil v princesini sobi kjer se je igral z dojkama.  Zdravilec mu je povedal, da bo srbenje samo izginilo po 3 dneh.  Tako je naslednje 3 dni Marjan vsak dan prihajal na grad izpolnjevat svojo željo.  Po 3 dneh je srbenje izginilo in kralj je pohvalil Marjana: \"Dober človek si. Tvoja usta so magična!\"  Marjan je ves zadovoljen želel oditi vendar ga je zdravilec potegnil v svojo sobo.  \"Dolžan si mi 1000 cekinov!\"  Marjan: \"Ne, ne dobiš jih. Kar povej kralju, če si upaš!\"    Tako je Marjan pretental zdravilca.    A le na prvi pogled. Saj je, še isti večer, zdravilec šel v kraljevo spalnico in potresel prah po kraljevih gatah.    In kralj se je znova spomnil na Marjana...", "Grajska zgodba" },
                    { 1171, true, 43, "Mojca stoji na balkonu, Ferdo ji  iz dnevne sobe zaklice:  Draga, dezuje, pridi ze noter!  Ona: Saj zunaj tudi.", "Dezuje" },
                    { 1164, true, 43, "Korel je z druscino za sankom. Padajo  runde, ko vprasa prijatelje: Ali veste,   kaj je najvecji naravni fenomen?  Tisina.  Korel: Zensko oko. Z razdalje desetih  metrov zagleda las blondinke na vasi  svetli srajci, z razdalje pol metra  pa ne vidi okvirja garaznih vrat.", "Zensko oko" },
                    { 1159, true, 43, "Kosir: Marta, a ti ves, da bik ze  po vonju ve, kdaj je krava pripravljena  za tiste reci?  Marta: Ja, Kosir moj, a kaj ko tvoj   nahot noce in noce izginiti.", "Nahod" },
                    { 1149, true, 43, "Sredi noci zazvoni telefon.  Kosir se v postelji obrne k Marti.  Ce je zame, reci, da me ni doma.  Marta vstane, dvigne slusalko in   po dveh sekundah izusti:   Doma je.  Kosir slisi in glasno zagodrnja:  A ti nisem rekel, da pove, kako  me ni doma.   Marta: Saj ni bilo zate.", "Telefon" },
                    { 1144, true, 43, "Pri nas imajo lahko moški samo eno ženo.    To se imenuje: monotonija.", "Ena žena" },
                    { 1143, true, 43, "Žalostno!    Dnevi, ko so ljudje znali pravilno uporabljati slovenščino, ni nič več.", "Pravilna uporaba sloveščine" },
                    { 1139, true, 43, "Zdravnik operira pacienta, ki je odvisnež od interneta.    Pred operacijo mu ponudi tablico rekoč: \"Ali želite svoj status spremeniti v NEZAVESTNO?\"", "Nor na internet" },
                    { 1138, true, 43, "Bratec in sestrica drug drugega prepričujeta, naj stopi na tehtnico.    Nakar se starejša sestrica opogumi in stopo nanjo. Takoj za tem reče: \"Pa saj nič ne boli!\"    Bratec: \"Zakaj pa potem mamica joče vsakokrat, ko stopi nanjo?\"", "Otroka in tehtnica" },
                    { 1132, true, 43, "Na letalu se peljejo American, Rus in Afganistanec. Stevardesa vprasa Americana kaj bo pil in on odvrne da viski. Nato vprasa Rusa in on odgovori da vodko. Na koncu ponudi pijaco se Afganistancu. Afganistanec odgovori:\"Nic, hvala, jaz se bom vozil.\"", "Na letalu" },
                    { 1131, true, 43, "Po ulici pelje fico za njim pa tank. Tank se posmehuje ficotu:\"Poglej se kaksen si, ko imas motor na riti!\"  Fico mu ne ostane dolzen:\" Bolje motor na riti kot penis na celu!\"", "Fico in tank" },
                    { 1124, true, 43, "Kaksna je razlika med modrckom in zakljucnim racunom?  Nobena.  Oba zakrivata dejansko stanje!", "Modrcek" },
                    { 1122, true, 43, "V ljubljanskem kinu Sloga vrtijo  pornic. Med publiko se sverca tudi  Bucko. Ostro kontrolorjevo oko ga  uzre: Poba, kako si se pa ti  pretihotapil v dvorano?  Od kod ti karta za film saj si   se otrok?   Bucek:Saj ni moja, oce jo je kupil.  Ja, kje pa je oce?  Bucek: Doma isce vstopnico.", "Kino" },
                    { 1112, true, 43, "Kaj je huje od moza, ki vsak  vecer prihaja prepozno  domov?  Moz, ki pride enkrat ob   nepravem casu prezgodaj   domov...", "Prezgodaj je huje od prepozno" },
                    { 1102, true, 43, "\"Aha, dobili smo vas. Garazo ste zgradili brez gradbenega dovoljenja.\"  Joze se izmotava:\" To pa ni res. Saj imamo gradbeno dovoljenje za hiso, ampak je zaradi vseh podrazitev res nastala garaza.\"", "Garaza" },
                    { 1089, true, 43, "Dva mulca se pogovarjata.  \"Ves, skoda, da nisem pritljikavec. Imel bi zelo lepo zivljenje!\"  \"Aja, zakaj pa?\"  \"Poglej naokoli. Skoraj vse nosijo minice. Zdaj pa si zamisli, da si manjsi od enega metra!\"", "Velikost" },
                    { 1170, true, 43, "Bucek zjutraj pride iz svoje sobe  in mamica ga vprasa:  Sine, a ti jajcka specem?  Bucek prestraseno nazaj:  Mami, a te jaz v joske boksnem?", "Bucek" },
                    { 874, true, 43, "Se pogovarjata Tina Maze in Janez Jansa.  Tina: Janez, ti bo mogo zacet smucat.  Janez: Zakaj pa to?  Tina: Ti nikoli ne odstopis.", "Pogovor med Tino Maze in Janezom Janso" },
                    { 1572, true, 43, "Starejši gospod je čakal leta in leta, da mu na Upravni enoti izdajo gradbeno dovoljenje.    Končno je dovoljenje dočakal in uradnik mu reče: \"Vse je gotovo, gradbeno dovoljenje je izdano, pojdite samo še v  tajništvo, da vam dajo pečat.\"    Ves srečen gre gospod v tajništvo po pečat, ko mu na drugi strani uradnik pove, da je ura pravkar odbila 12 in naj se vrne po kosilu.    Gospod ves žalosten pove: \"Oprostite, šest let čakam na to dovoljenje, potrebujem samo še vaš pečat. Prosim, udarite ta pečat, pa vam povem zgodbico o ženski in psu.    Uradnik zelo nejevoljen le pristane ter mu požigosa vse dokumente in nestrpno čaka na zgodbico.    Gospod vzame dokumente in reče: \"Jebo ti pas mater!\"", "Težko je pridobiti gradbeno dovoljenje" },
                    { 1591, true, 43, "Mož brez žene je kot pes brez  bolh.Živi, ampak dolgocasno.  Žena brez moža je kot bolha  brez psa. Živi, ampak nima koga  žreti.", "Bolhe" },
                    { 1987, true, 43, "Študent agronomije je obiskal vrtnarja z namenom, da zbere dovolj informacij za sestavo diplomske naloge.    Ko si je ogledoval vrtnarijo, mu je očital: \"Vi pa vrtnarite še precej po starem! Ta način je zelo zastarel. Dvomim, da vam bo tole drevo obrodilo kaj sliv!\"    \"Seveda jih ne bo!\" se je zasmejal vrtnar, \"tole je namreč češnja!\"", "Študent agronomije in vrtnar" },
                    { 1978, true, 43, "Fant punci: \"Zelo lepo postavo imaš!\"    Punca: \"Hvala. Veš, to je od plavanja.\"    Fant: \"Če je pa tako bi bilo pa vredu, če bi tudi obraz kdaj pa kdaj namočila.\"", "Kompliment" },
                    { 1975, true, 43, "\"Si že kdaj govoril pred množico?\"    \"Že.\"    \"O čem pa?\"    \"O pravnih vprašanjih.\"    \"Kaj pa si rekel?\"    \"Nisem kriv!\"", "Govor pred množico" },
                    { 1974, true, 43, "\"Halo, je tam društvo za zaščito živali?\"    \"Ja, želite?\"    \"Takoj pošljite nekoga k meni. Na našem drevesu sedi poštar in zmerja mojega psa!\"", "Klic na društvo za zaščito živali" },
                    { 1958, true, 43, "Bine sedi v restavraciji s hitro prehrano in gleda starejši par za sosednjo mizo, ki je naročil le eno porcijo.    Mož hamburger prereže na polovico in ga pol da ženi.    Nato razdeli krompirček po sistemu enega meni, enega tebi.    Na koncu pol pijače prelije v dodaten kozarec.    Ko razdeli porcijo, začne mož jesti, žena pa sedi na stolu in ga opazuje.    Mladenič jima reče: \"Naj vama kupim še eno porcijo, da si vama ne bo treba deliti ene same.\"    Mož odvrne: \"Ne, ne, hvala. Poročena sva 40 let in vse v življenju si deliva na pol.\"    Mladenič se obrne k ženi in vpraša: \"Vi ne boste jedli?\"    \"Ne še. Zdaj je mož na vrsti za zobno protezo!\"", "Penzionista v restavraciji" },
                    { 1952, true, 43, "\"Mamica, ali v Švici res živijo ljudožerci?\"    \"Mihec, kako ti pride kaj takšnega na misel?\"    \"Zakaj pa je potem stric Polde rekel, da Švicarji živijo od turistov?\"", "Švicarji" },
                    { 1947, true, 43, "Na policijski postaji sredi noči zazvoni telefon: \"Policija, pomagajte! V moj avto so vdrli in pokradli – volan, zavore, menjalnik, pedala, radio, armaturno ploščo, vse!\"    \"Kje ste?\" vpraša dežurni policaj, zapiše naslov in obljubi, da bo takoj poslal patruljo.    Čez nekaj minut spet zazvoni telefon na postaji: \"Policija! Ni treba hoditi, zmotil sem se in se usedel na zadnji sedež!\"", "Vdrli so mu v avto" },
                    { 1942, true, 43, "Kupec v trgovini: \"Te žemlje so včerajšnje, jaz pa želim današnje.\"    Prodajalka: \"Potem pridite jutri!\"", "Žemlje" },
                    { 1941, true, 43, "Na dvorišču norišnice raste drevo.    Norci imajo navado, da plezajo po njem.    Nekega dne ima paznik težave, kako jih spraviti dol.    \"Gremo dol, kosilo čaka!\" vpije nanje.    Oni pa nazaj: \"Kako naj gremo dol, ko smo pa listi?\"    Paznik malo pomisli in reče: \"Kaj pa še počnete gor, ne vidite, da je jesen?\"    Norci pogledajo po vejah in vidijo, da listje res odpada. In splezajo z drevesa vsi, razen enega.    Paznik ga vpraša, zakaj ne spleza dol, norec pa odgovori: \"Butec, a ne vidiš, da sem zimzelen?!\"", "Norci in drevo" },
                    { 1937, true, 43, "\"Če hočeš uspeti, moraš biti iskren in obziren,\" reče oče sinu.    \"In kaj pomeni iskren?\" vpraša sin.    \"Da vedno storiš, kar si obljubil.\"    \"Kaj pa obziren?\"    \"Da nikoli ničesar ne obljubiš.\"", "Iskren in obziren" },
                    { 1932, true, 43, "\"Ali vidiš tisto brhko plavolasko? Nocoj je tolkla po mojih vratih!\"    \"Srečnež! Pa si jo spustil noter?\"    \"Ah, ne! Nisem je pustil ven.\"", "Brhka plavolaska" },
                    { 1931, true, 43, "\"Ti, kaj predstavlja ta slika? Sončni vzhod ali zahod?\"    \"Prepričan sem, da sončni zahod!\"    \"Po čem pa to sklepaš?\"    \"Poznam slikarja, ki je narisal to sliko. On nikoli ne vstane tako zgodaj, da bi lahko videl sončni vzhod!\"", "Dilema" },
                    { 1930, true, 43, "Starejši gospod in dama srednjih let v kupeju vlaka.    Starec nenadoma spusti prdec in dama se prekriža: \"Nezaslišano! Kaj takega se mi še ni zgodilo!\"    \"Kaj?\" se začudi starec. \"Jaz sem pa mislil da je meni ušlo.\"", "Ne najbolj prijetna družba" },
                    { 1926, true, 43, "Učiteljica vpraša Janezka: \"Janezek, katerega spola je veter?\"    Janezek odgovori: \"Moškega.\"    Tovarišica ga pohvali, nato pa vpraša:\"In kako to vemo?\"    \"Ker ženskam dviguje krila.\"", "Spol vetra" },
                    { 1921, true, 43, "Pride stranka v frizerski salon in se usede na stol.    Frizer ga vpraša, kako ga naj ostriže?    On pravi: \"Spredaj poševno iz leve proti desni, nad levim ušesom na nulo, nad desnim stopničasto, na vrhu glave za pest veliko plešo, zadaj pa resice!\"    Frizer ga začudeno pogleda in pravi: \"Ja to pa ne vem, če bo šlo!\"    Stranka pa pravi: \"A prejšnjič ti pa je uspelo?\"", "Nova frizura" },
                    { 1914, true, 43, "Starec se je pripeljal na mejni prehod in carinik ga je vprašal: \"Kava, alkohol, cigareti …?\"    \"Ne hvala, v prtljažniku imam vsega dovolj!\" je odgovoril starec.", "Kontrola na meji" },
                    { 1908, true, 43, "Rad bi dobil punco, ki ima rada dolge romantične sprehode.    Ker nimam avtomobila. ", "Iskanje" },
                    { 1907, true, 43, "Janez gre k prijatelju na obisk.    Ta je bil ravno v delavnici in Janez ga vpraša: \"Kaj pa delaš?\"    Prijatelj mu dogovori: \"Stol za ženo\".    Janez: \"Pa gre?\"    Prijatelj: \"Gre, gre, samo elektrika še manjka.\" ", "Izdeluje stol za ženo" },
                    { 1906, true, 43, "Mihec, kaj pa pomenijo cigareti v tvojem žepu?    \"Ah, nič, našel sem jih na cesti in jih spravil.\"    \"Zakaj pa?\"    \"Da jih bom pokadil, ko bom velik.\" ", "Cigareti v mladeničevem žepu" },
                    { 1905, true, 43, "Čarovnik je bil zaposlen na luksuzni čezoceanski ladji.    Njegov poklic je bil zabavati potnike na dolgih križarjenjih s svojimi magičnimi triki. Ker so se potniki zamenjali vsak teden, ni bilo nobene potrebe po tem, da bi se naučil nekaj več kot 20 trikov.    Problem pa je nastal, ko si je nekoč kapitan ladje kupil papagaja in ta je zelo rad opazoval čarovnika pri delu.    Čez čas je bistri papagaj spregledal čarovnikove trike in mu je začel med predstavami uničevati čarovniške trike z medklici, kot so: \"Karto je dal v rokav!\", \"To ni isti klobuk!\" ali \"Pod mizo ga je skril!\".    Čarovnika je to močno frustriralo, kajti njegove točke občinstva niso več navduševale, nič pa ni mogel zoper papagaja, ker je bil kapitanova last.    Potem pa je neke noči ladjo zajelo hudo neurje in potopila se je. Naslednje jutro sta se na istemu kosu lesa znašla čarovnik in papagaj.    Povsem sama sta bila sredi oceana in gledala sta se brez besed.    Tudi drugi dan sta se opazovala v tišini.    Isto tretji dan.    In nato je četrtega dne papagaj rekel: \"Stari, vdam se... Kam si skril ladjo?\"", "Čarovnik in papagaj" },
                    { 1903, true, 43, "Voznik je na cesti pobral nuno, ki je štopala, in jo peljal v želeni smeri.    Ker mu je bila nuna všeč, ji je med vožnjo položil dlan na kolena, nuna pa je rekla: \"Psalm 90, verz 5.\"    Voznik je zmedeno odmaknil roko z njenega kolena in nadaljeval pot.    Ko je prišel domov, je pogledal v Biblijo in v psalmu 90, verzu 5 prebral: \"Ti si na pravi poti!\"", "Nuna in avtoštop" },
                    { 1901, true, 43, "Srečata se na nudistični plaži.    Med njima se zaiskri in on reče: \"Veseli me, da sva se spoznala.\"    \"Mene tudi. Prideš zvečer k meni v bungalov?\"    \"Rad!\"    \"No zdaj pojdi pa v vodo, da ne bodo vsi videli, kako si vesel.\"", "Na nudistični plaži" },
                    { 1898, true, 43, "Janko reče dekletu: \"Tako te ljubim, da te vsako noč sanjam.\"    \"Lažeš! Če bi me tako zelo ljubil, ne bi mogel spati.\" ", "Ljubezen" },
                    { 1893, true, 43, "V krčmi, kjer se zbirajo žeparji in postopači, nekdo od njih lista po modni reviji.    \"Od kdaj pa se ti zanimaš za modo?\" ga vpraša eden.    \"Gledam samo to, kje bodo prihodnjo sezono prišiti žepi na oblačilih.\" ", "Žeparji na oddihu" },
                    { 1891, true, 43, "\"Zakaj pa hodiš s pomočjo palice?\"    \"Prometna nesreča.\"    \"Ali res ne moreš brez?\"    \"Zdravnik pravi, da lahko, odvetnik pa, da ne morem.\" ", "Posledice prometne nesreče" },
                    { 1888, true, 43, "Dobra vila mi je izpolnila dve želji.    Tretjič zapored nisem več mogel. ", "Dobra vila in želje" },
                    { 1886, true, 43, "Včeraj sem dobil avto.    Danes motor.    Pa tele Kinder jajčke so res zakon! ", "Vseskozi nekaj dobiš" },
                    { 1885, true, 43, "Sodnik je vprašal obtoženko: \"Vaš priimek in ime?\"    \"Berta Koren\".    \"Stari?\"    \"Čaka me pred sodno dvorano.\" ", "Na sodišču" },
                    { 1878, true, 43, "Zakaj Škoti nosijo kilte?    Ker so se ovce že navadile na zvok zadrge.", "Škoti in kilti" },
                    { 1988, true, 43, "Damjan Murko se vozi po Ljubljani, ko mu naenkrat na okno avtomobila potrka brezdomec: \"Dej mi 10 EUR\".    Murko brez besed odpelje naprej, ko čez nekaj časa zopet potrka isti brezdomec: \"Dej mi 10 EUR\".    Murko ves jezen pohodi gas. Čez kakšnih 20 minut vožnje pa po oknu zopet trka isti brezdomec.    Murko se ujezi: \"Pa dobro! Kako ti to uspeva, da si brez avta, a vedno pred menoj?!!\".    Brezdomec: \"Daj mi 10 EUR, pa ti pomagam iz krožišča\".", "Damjan Murko v prometu" },
                    { 1876, true, 43, "\"Jure, kje si pa bil tako dolgo?\" je mama vprašala desetletnega sina, ko se je ta vrnil domov.    \"S Sonjo sva šla v park in se usedla na klopco, nato pa gledala gospoda in gospo, ki sta sedela na drugi klopci.\"    \"In potem?\"    \"Potem je pa gospod začel poljubljati gospo in jaz sem začel poljubljati Sonjo.\"    \"Kaj je bilo pa potem?\"    \"Potem je gospod gospe slekel bluzo in ji otipavati prsi, zato sem tudi jaz Sonji slekel bluzo in ji začel otipavati prsi.\"    \"In potem?\" je zgroženo vprašala mama.    \"Potem je pa gospod slekel gospe še krilo in hlačke in sta odšla v grmovje.\"    \"In vidva?\"    \"Midva s Sonjo sva šla pa domov, ker naju ni tiščalo kakat!\"", "Pozno je prišel domov" },
                    { 1990, true, 43, "V drogerijo je prišel gospod in vprašal: \"Kdo je moji ženi včeraj dal lepilo namesto zobne paste?\"    \"Najbrž jaz,\" je oklevajoče dejal mlad prodajalec.    \"Hvala ti, tu imaš sto evrov,\" je dejal gospod. ", "Napaka" },
                    { 1994, true, 43, "Pred kipom ženske in moškega, ki že več let stojita v mestnem parku, se pojavi angel in reče: \"Ker sta že več let vzorna kipa in razveseljujeta množice ljudi, sem vama prišel izpolnit vajino največjo željo, zato vama za pol ure poklanjam dar življenja.\"    Kipa nenadoma oživita, se nasmehneta drug drugemu in stečeta v grmovje.    Angel se nasmehne in posluša hahljanje v grmičevju, pokanje vej in šumenje listja.    Po 15 minutah kipa prideta iz grmovja zadovoljna in nasmejana, angel pa jima reče: \"Še vedno vama je ostalo 15 minut. Ali bi rada nadaljevala?\"    Moški pogleda žensko in jo vpraša: \"Ali bi rada ponovila?\"    Ženska smeje odgovori: \"Seveda, ampak tokrat boš ti držal goloba, jaz pa bom tista, ki se mu bo posrala na glavo.\"", "Kipa in angel" },
                    { 2034, true, 48, "Na sodišču, sodnik vpraša obtoženca: \"Ali mi lahko navedete kakšne olajševalne okoliščine?\"    Obtoženec: \"Seveda! Prosim vas, da upoštevate mladost in neizkušenost odvetnika, ki ste mi ga dodelili!\"", "Olajševalne okoliščine" },
                    { 1948, true, 47, "Janez se seli in nosi na hrbtu veliko omaro.    Sosed ga vidi in vpraša, zakaj si ni priskrbel pomoči.    Janez odgovori: \"Saj mi Miha pomaga. V omari drži predale!\"", "Selitev" },
                    { 1911, true, 47, "\"Soseda, ali ste včeraj slišali prepir pri Korenčkovih?\"    \"Seveda sem ga, saj je ropotalo celo noč! Kaj pa sta imela?\"    \"On je dal oglas v erotični časopis da išče žensko, ki bi se igrala z njim razne spolne igrice, na oglas pa se je javila njegova žena!\" ", "Kakšno naklučje" },
                    { 2128, true, 43, "Gresta dva klošarja v park pa prvi vpraša drugega, če ima kaj kruha za golobe.    Pa reče drugi: \"Ne rabim jaz ga jem kar brez kruha.\".", "Klošarja v parku" },
                    { 2125, true, 43, "Jebeta 2 vati pa pride tretja notri pa reče: \"watafak\".", "Vati v akciji" },
                    { 2123, true, 43, "Slovenec na zmenku z Avstrijko opazi, da nima obrvi.    Obzirno jo vpraša: \"Raziren?\"    \"Nein, populen,\" mu odvrne ona.    Ko se začne slačiti opazi, da tudi pod pazduho nima dlak.    \"Populen?\" vpraša z zanimanjem.    \"Nein, raziren,\" mu odvrne ona.    Ko Slovenec opazi, da tudi tam spodaj nima dlak, vpraša: \"Raziren oder populen?\"    \"Abnutzen!\" mu odvrne ona.", "Mednarodni zmenek" },
                    { 2121, true, 43, "Kako je bilo na začetku sveta?    Moški se je osamljen sprehajal po raju in iskal kaj zanimivega.    Zagledal je žensko in vzkliknil: \"EVO!\".    Tedaj tudi ona zagleda njega, in vsa navdušena vzklikne: \"A dam!?\".", "Začetek" },
                    { 2099, true, 43, "Po koncu protokola so Busha, ko je obiskal Slovenijo, vprašali, če ima še kakšno posebno željo pa je rekel, da bi zelo rad videl Vinka iz Logatca. Tudi Putin je imel enako željo ob obisku Slovenije in je želel pozdraviti Vinka iz Logatca. Počasi se je direktorju KLI Logatca, kjer je bil Vinko zaposlen v obratu kartonaže, vse skupaj zdelo že malo preveč, in ga je poklical v pisarno. Šef: “Ja Vinko, kako to, da te Bush in Putin poznata?” Vinko:” Ah, to ni nič takega! Dosti potujem, pa srečujem ljudi…” Šef: “Pa dobro, ampak stavim, da papeža ne poznaš osebno.” Vinko: “Ah, kaj da ne! Seveda ga poznam.” Šef: “Tega pa ne verjamem. To boš dokazal.” In je šel KLI Logatec na sindikalni izlet v Vatikan. Komaj je Vinko stopil iz avtobusa, že je od daleč slišal papeža vpiti: “Oooo, Vinko, kje si! Dolgo te nisem videl!” Vinko je pohitel do papeža in prav prisrčno sta se objela in trepljala po ramenih. Naenkrat nastane pri avtobusu panika in Vinko takoj pohiti nazaj. Na tleh leži njegov šef, ki je omedlel. Ko se po nekaj trenutkih spet zave, ga Vinko zaskrbljen vpraša, kaj se je zgodilo. Šef: “Veš kaj, Vinko, vse sem prenesel. In to, da poznaš Busha, in da poznaš Putina. Tudi za papeža ti zdaj verjamem, ampak ko je pa Japonček zraven mene rekel “Kdo je tisti z belo kapco poleg Vinkota?”, je bilo pa preveč.", "Vinko iz kartonaže" },
                    { 2096, true, 43, "Znebil sem se tistega nadležnega zvoka v avtu.    Ustavil sem, in jo nagnal ven.", "Nadležni zvok v avtu" },
                    { 2095, true, 43, "Mladenič se je odločil, da je dovolj čakanja in, da mora končno izgubiti nedolžnost.    Odšel je na obisk k prelepi prostitutki.    Ker je bilo dokaj očitno, da bo zanj prvič, ga ljubeče vpraša: \"Si nervozen?\".    \"Da, zelo!\".    Prostitutka: \"Prvič?\"    Mladenič: \"Ne, že večkrat sem bil nervozen.\".", "Prvič pri prostitutki" },
                    { 2094, true, 43, "Zakaj ob nesreči najprej evakuiramo ženske in otroke?    Da lahko v miru poiščemo rešitev.", "Dokaj logično" },
                    { 2093, true, 43, "Stoji skupina otrok pred cerkvijo in gleda par, ki se je pravkar poročil.    \"Glej zdaj paniko!\" reče eden od mulcev, steče do ženina in reče: \"Žiiivjooo ati! ", "Malo za šalo" },
                    { 2089, true, 43, "Kaj je paradoks samomorilcev?    Več kot jih je manj jih je.", "Samomorilci" },
                    { 2087, true, 43, "V vrtec pridejo priklopit internet, rekoč: \"Zdravo jaz sem od Amisa.\".    Vzgojiteljica: \"Aha, bom pogledala, samo mislim da še spi.\".", "Priklop interneta v vrtcu" },
                    { 2079, true, 43, "Joža je k sebi povabil goste in jim ob povabilu naročil: \"Ko boste prihajali, pridite vsi skupaj!\"    \"Zakaj pa?\"    \"Da psu ne bo treba dvakrat lajati!\"", "Povabilo in prošnja" },
                    { 2063, true, 43, "Na podeželju prijatelj vpraša novopečenega voznika: \"No, kako ti gre kaj vožnja?\"    \"Po šahovsko.\"    \"Kako, po šahovsko?\"    \"Zbijem kmeta, zbijem konja...\"", "Novopečeni voznik" },
                    { 2053, true, 43, "Avtomehanik reče lastnici avtomobila: \"Gospa, bojim se, da je problem pri vašem avtomobilu večji, kot sem mislil. Prepričan sem bil, da vaš avto potrebuje nov akumulator.\"    \"In kaj sedaj?\"    \"Ravno obratno.\"    \"Kako?\"    \"Akumulator bo potreboval nov avto!\"", "Težave z avtomobilom" },
                    { 2044, true, 43, "Pride možakar v službo z izbitim zobom in modricami.    Prijatelji ga vprašajo: \"Kdo te je pa tako zdelal?\"    \"Janez.\"    \"Nemogoče! On pa vendar ni tak pretepač, pa še najboljša prijatelja sta.\"    \"Samo eno besedo sem mu rekel, pa je počilo.\"    \"Kaj si mu rekel?\"    \"Hvalil se je, kako sijajna je njegova žena v postelji, jaz pa sem samo pripomnil: ‘Vem!’\"", "Ves stolčen" },
                    { 2043, true, 43, "V temni noči taksi pobere osamljenega pešca.    Med vožnjo molčita, potnik pa bi želel nekaj vprašati in narahlo potrka taksista po rami.    Ta zakriči, izgubi oblast nad vozilom, skoraj zadene v avtobus, vendar še v zadnjem hipu obrne volan, poskoči čez visok robnik na pločnik in nazadnje le uspe ustaviti avto nekaj centimetrov pred izložbenim oknom.    Trenutek tišine.    Potnik se nato prestrašeno opraviči: \"Nisem si mislil, da vas bo moja kretnja tako prestrašila?\"    Ko voznik pride k sebi, odgovori: \"Pravzaprav niste vi krivi. Danes je moj prvi dan v službi taksista. Prej sem 15 let vozil mrliški avto!\"", "Taksist in potnik v temni noči" },
                    { 2031, true, 43, "Znanca se srečata po več letih.    \"Kaj počneš?\"    \"Mučim ženske, ženem jih, da se znojijo, ne dajem jim jesti, nazadnje jim pa še vzamem denar.\"    \"Ali ni to nemoralno in protizakonito?\"    \"Ne. Imam lepotni salon.\"", "Po dolgih letis se srečata" },
                    { 2029, true, 43, "Uslužbenec na ministrstvu za kmetijstvo je na pritožbo nekega kmeta vztrajal, da je treba živali žigosati.    \"Dobro, bom poskusil,\" se je vdal kmet.    Nekaj dni pozneje se je uslužbenec pozanimal, kako stvari napredujejo.    \"Ne gre slabo,\" je pojasnil kmet. \"Zdaj sem ožigosal vse piščance, čaka me pa še precej zahtevno delo s čebelami.", "Žigosanje živali na kmetiji" },
                    { 2027, true, 43, "Punca: \"Ali kadiš?\".    Fant: \"Da.\".    Punca: \"Koliko škatlic na dan pokadiš?\".    Fant: \"Ammmm 2/3.\".    Punca: \"Koliko pa stane zavojček cigaret?\".    Fant: \"3.50€.\".    Punca: \"In koliko časa kadiš?\".    Fant: \"15 let.\".    Punca: \"Torej 1 zavoj stane 3.50€ in ti jih na dan pokadiš tri, kar bi pomenilo da na mesec porabiš 400€ in v letu bi porabil 4.600€, imam prav?\".    Fant: \"Ja verjetno.\".    Punca: \"Torej, če bi ves ta denar šparal bi si danes lahko kupil Ferarija!\".    Fant: \"Res je, kaj pa ti, kadiš?\".    Punca: \"Seveda, da ne!\".    Fant: \"No, kje maš potem ti Ferarija? Pizda ti materna!\".", "Fant in punca o kajenju" },
                    { 2026, true, 43, "Možakar nabira drva v gozdu.    Nenadoma se pred njim pojavi gozdar in vpraša: \"Kaj pa delate?\"    \"Hrano za zajčke nabiram.\"    \"Kako, ali vaši zajčki jedo drva?\"    \"Poskusil bom. Če jih slučajno ne bodo hoteli jesti, jih bom pa skuril!\"", "Čuden razlog" },
                    { 2011, true, 43, "Kdaj je najslabši možni trenutek, da te zadane srčni infarkt?    Med igranjem pantomime!", "Neprimeren trenutek" },
                    { 2010, true, 43, "Zagrizenega samca sprašuje prijatelj: \"Si prepričan Polde, da ne bi poiskal prijaznega dekleta in se z njim poročil?\"    Polde: \"Le zakaj bi se? Saj zame skrbita dve sestri.\"    \"Že, že, sestri,\" pravi prijatelj, \"ampak sestri nista isto kot žena.\"    Polde: \"Kdo je pa rekel, da sta moji sestri!\"", "Svetuje mu, naj se oženi" },
                    { 2002, true, 43, "Mladenič je želel za svojo novo ljubezen kupiti darilo za rojstni dan.    Skupaj z dekletovo sestro sta odšla v veleblagovnico izbirati vsak svoje darilo.    Mladenič se je odločil, da bo dekletu kupil rokavice, saj je menil, da je za intimno darilo še prezgodaj.    Njena sestra pa ji je kupila svilene spodnje hlačke.    Mladenič je prodajalki izročil pismo za svoje dekle, ki naj ga shrani v škatlico z rokavicami.    Trgovka pa se je zmotila in se je pismo za njegovo dekle znašlo pri spodnjih hlačkah.    Dekletovo sestro je prosil, naj ji izroči njegovo darilo.    Ko je dekle prejelo darilo, je onemelo, ko je prebralo pismo:  \"Draga moja! Odločil sem se, da ti za darilo kupim nekaj, za kar vem, da na najinih zmenkih nikoli ne nosiš. Najprej sem ti hotel kupiti take z gumbki, pa je tvoja sestra rekla, da so krajše precej boljše za tebe. Tudi ona nosi takšne in pravi, da se lažje potegnejo dol. Morda ti barva ne bo všeč, toda prodajalka, ki mi jih je prodala, mi je pokazala svoje in povedala, da jih nosi že mesec dni, pa se popolnoma nič ne vidi, da bi bile umazane. Prosil sem jo, če tvoje lahko probam, in ko sem si jih dal gor, je rekla, da so izvrstne. Zaželel sem si, da bi ti jih jaz nataknil, ko te prvič vidim. Ker pa ne vem, kdaj to bo, ti jih raje pošiljam in tudi vem, da se jih bo dotlej dotaknilo že mnogo rok. Ko jih boš slekla, jih pa daj sušiti, saj mi je prodajalka rekla, da po uporabi postanejo nekoliko vlažne. No, upam, da jih boš nosila na najinem naslednjem zmenku.    Tvoj Peter.\"", "Nakup darila za novo punco" },
                    { 2001, true, 43, "Mlad fant vstopi v lekarno in reče lekarnarju: \"Dober dan, a lahko dobim en kondom? K punci grem na večerjo in mislim, da nekaj pričakuje od mene.\"    Lekarnar mu da kondom, fant plača, na izhodu pa se ustavi in vrne. \"Dajte mi še en kondom. Sestra moje punce je zelo mikavna. Vedno prekriža noge na provokativen način. Mislim, da tudi ona nekaj pričakuje od mene!\"    Lekarnar mu da še drugi kondom, ko se fant zopet oglasi: \"Dajte mi še en kondom, ker je mama moje punce zelo lepa ženska, vedno, ko me vidi, obrača oči. Ker me je ona povabila na večerjo, mislim, da tudi ona nekaj pričakuje od mene!\"    Na večerji za mizo fant sedi s svojo punco, njeno sestro in mamo, ko se pojavi dekletov oče. Fant spusti glavo in prične moliti.    Deset minut pozneje fant še vedno moli. Vsi ga gledajo presenečeno.    Punca se skloni k njemu in mu zašepeta na uho: \"Nisem vedela, da si tako pobožen!\"    Fant ji odgovori: \"Jaz tudi nisem vedel, da je tvoj oče lekarnar!!!\" ", "Treba se je pripraviti" },
                    { 1998, true, 43, "Slavisti so imeli simpozij v Portorožu in so se prepirali o jezikovnih pravilih.    Nikakor se niso mogli dogovoriti, kako se opiše deževno vreme. \"Dež pada,\" je trdil prvi.    \"Ne, ne, cenjeni kolega, reče se dežuje\", je vztrajal drugi.    \"Dež gre,\" je predlagal tretji.    \"Dež gre.\" \"Dežuje!\" \"Dež pada!\" \"Dež gre\" ... \"Dežuje\" ... \"Pada.\"    Tako so se kregali pozno v noč.    Ker se niso mogli dogovoriti, so sklenili, da za tisti večer končajo.    Stopili so iz hotela in v en glas vzkliknili: \"Mater, ščije!\"", "Slavisti na simpoziju" },
                    { 1996, true, 43, "Sherlock Holmes in dr. Watson gresta taborit.    Postavita šotor ter kmalu utrujena zaspita.    Čez nekaj ur Holmes zbudi svojega zvestega prijatelja: \"Watson, poglej v nebo in mi povej, kaj vidiš?\"    Watson odgovori: \"Vidim na milijone zvezd.\"    Holmes: \"In kaj ti to pove?\"    Watson se za nekaj časa globoko zamisli: \"Astronomsko mi pove, da obstaja na milijone galaksij in planetov, astrološko, da je Saturn v znamenju Leva, časovno, da je ura približno četrt na eno zjutraj, teološko, da je očitno Gospod vsemogočen in da smo mi majhni in nepomembni, meteorološko pa, da bova jutri imela lep dan. Kaj pa tebi pove?\"    Holmes za trenutek pomolči in nato reče: \"Bistvo, moj dragi Watson, bistvo! Nekdo nama je ukradel šotor!\"", "Holmes in dr. Watson kampirata" },
                    { 1992, true, 43, "Mali Miha v gneči izgubi svojo mamo.    Končno sreča policista in ga vpraša: \"Ali ste mogoče videli kakšno mamo brez mene?\" ", "Izgubil se je" },
                    { 1870, true, 43, "Mojca in Mirko sedita v parku na klopci in Mojca ves čas miži.    \"Zakaj pa mižiš?\" jo je začudeno vprašal Mirko.    \"Oče je rekel, da te ne smem več videti!\"", "V parku na klopci" },
                    { 1868, true, 43, "Za šankom sedi gospod in zamišljeno zre v kozarec.    Čez čas reče: \"Seksal sem s svojo pacientko.\"    Oštir, ki ga ni poznal, ga skuša pomiriti: \"To pa res ni tako hudo! Prepričan sem, da se veliko zdravnikov pregreši s svojimi pacientkami.\".    Zamišljeni gost dvigne pogled in reče: \"Ampak jaz sem živinozdravnik.\".", "Zamišljen gost" },
                    { 1861, true, 43, "Žeparja sta prišla iz gostilne in eden je vprašal: \"Si videl čudovito natakarjevo uro?\"    \"Ne, pokaži mi jo!\" ", "Žeparja med pogovorom" },
                    { 1703, true, 43, "V Švicarsko banko je vstopil možakar in povedal bančnemu uslužbencu, da želi odpreti račun in položiti denar.    \"Koliko boste pa položili na račun?\" ga je vprašal bančnik.    \"Tri milijone evrov!\" je zašepetal možakar.    \"Saj lahko govorite glasneje!\" mu je rekel bančnik. \"V Švici revščina ni sramota!\" ", "Polog na banko" },
                    { 1684, true, 43, "Japonci so geniji!    Naredili so fotoaparat s tako hitro zaslonko, da lahko slika žensko z zaprtimi usti. ", "Japonci znajo" },
                    { 1683, true, 43, "Vsak moški sanjari o treh stvareh:  - da je tako lep, kot misli njegova mama,  - da je tako bogat, kot misli njegov otrok,  - in da ima toliko žensk, kot sumi njegova žena.", "Moško sanjarjenje" },
                    { 1682, true, 43, "Prinese tip v polnem sexshopu k blagajni umetno vagino.    Pa se blagajničarka zadere: \"Kako jo boste pa uporabljali!?!\"    Zardel kupec se zadere nazaj: \"Kaj vas pa to briga?!\"    Blagajničarka odvrne: \"Zaradi DDV! Če jo boste lizali, je DDV za živila 8,5%, sicer je pa za storitve 20%!\"", "Nerodna situacija" },
                    { 1681, true, 43, "Mars vpraša Zemljo: \"kaj si tako slabotna?\"    Zemlja mu odgovori: \"Staknila sem človeka!\"    Mars odgovori: \"Ne skrbi saj bo hitro minilo!\"", "Vesoljski pogovor" },
                    { 1675, true, 43, "Šele ko ti pristane komar na jajcih ugotoviš, da se vseh problemov ne da rešiti z nasiljem.", "Nasilje ni rešitev" },
                    { 1673, true, 43, "Prijatelj je poučil mlajšega, odraščajočega fanta: \"Nikoli se ne spečaj z blondinko, ki te gleda s sijočimi očmi!\"    \"Zakaj pa ne?\"    \"Ker je velika verjetnost, da skozi njeno glavo sije sonce.\" ", "Pameten nasvet" },
                    { 1670, true, 43, "Kupil sem si nov bumerang.    Starega ne morem vreči stran.", "Resen problem" },
                    { 1658, true, 43, "Direktor se vrne iz Japonske s podarjeno umetno tajnico in jo razkazuje namestniku: \"Poglej Franc, je naravnost čudovita. Pritisneš na levo bradavico in začne tipkati, pritisneš na desno in piše stenogram. Če pritisneš na popek, se loti računalnika\" Pa še za poseksati je izvrstna.\"    Franc: \"A res?! A mi jo posodiš?\"    Direktor: \"Izvoli!\"    Franc pobaše tajnico na stranišče. Čez nekaj minut zatuli kot zverina.    Direktor se udari po glavi:\"Uh, jebemti, pozabil sem mu povedati, da ima v riti šilček!\"", "Robot tajnica" },
                    { 1656, true, 43, "Se Francoz, Italijan in Rus pogovarjajo kaj je najlepše na svetu.    Francoz: \"Predstavljajta si tole. Sem v restavraciji, na mizi polži, šampanjec in nasproti mene lepo dekle. Po večerji jo odpeljem domov, kjer poslušava glasbo in se potem strastno ljubiva celo noč.\"    Italijan mu pritrdi: ”Res je. Samo namesto polžev in šampanjca so na mizi špageti in kakšno dobro domače vino.\"    Rus pa samo zmaja z glavo in reče: \"Zdaj si pa vidva tole predstavljajta. Sibirija minus trideset stopinj in piha veter. Jaz v topli koči mirno spim v postelji.    Kar naekrat vstopi v sobo poveljnik in se zadere Vladimir, na stražo!\"    Francoz in Italijan se spogledata in vprašata: \"Kaj je pa tukaj tako lepega???\"    Pa pravi Rus: \"Da meni ni Vladimir ime!\"", "Najlepše na svetu" },
                    { 1654, true, 43, "Fant in dekle sedita na klopci v parku.    Ona mu reče: \"Boli me vrat!\"    On jo poljubi na vrat in bolečina ji izgine.    Ona: \"Zdaj me boli oko.\"    On jo poljubi na oko in bolečina ji izgine.    Ona: \"Zdaj me boli ustnica.\"    On jo poljubi na usta in bolečina ji izgine.    Vse to je poslušal en starček na sosednji klopi in vpraša: \"Ej poba, a hemeroide tudi zdraviš?\"", "Zdravilni poljubi" },
                    { 1653, true, 43, "Dve babici stanujoči v domu starejših občanov se pogovarjata: \"Marija veš, pes mi je poginil.\"    \"A res. Moje sožalje, kako je že bilo ime temu cucku?\"    \"Ne vem, se je bolj mož z njim ukvarjal.\"    \"Aha, ja kako pa je bilo ime tvojemu pokojnemu možu?\"    \"Ne vem, se je bolj pes z njim ukvarjal.\"", "Pogovor v domu za ostarele" },
                    { 1650, true, 43, "Trije dečki se pogovarjajo, čigav oče je najhitrejši.    Prvi: \"Moj ata je najhitrejši: strelja enajstmetrovko, nato pa sam skoči v gol in obrani.\"    Drugi: \"Moj ata je hitrejši: poserje se s stolpnice, nato pa teče dol in ujame drek!\"    Tretji: \"Moj ata je še hitrejši: V službi na ministrstvu dela do štirih, pa je že ob dveh doma!\"", "Kdo ima bolj hitrega forta" },
                    { 1646, true, 43, "On: \"Poklical te bom.\"    Ona: \"Ampak saj nimaš moje številke!\"    On: \"Če nama je usojeno, jo bom uganil.\"", "Usoda" },
                    { 1644, true, 43, "Rabelj je pred usmrtitvijo obiskal na smrt obsojenega in ga vprašal: \"Ali imate mogoče še kakšno željo?\"    Obsojeni mu odgovori: \"Ja, rad bi naredil doktorat.\"", "Zadnja želja" },
                    { 1642, true, 43, "Pomen \"dileme\" v praksi: recimo, da ležiš med prelestno mladenko in pedrom.    Komu boš obrnil hrbet?", "Resna dilema" },
                    { 1632, true, 43, "\"Na področju zaposlovanja je Slovenija velik fenomen.\"    \"Kako to misliš?\"    \"Na slovenskih uradih za zaposlovanje v čakalnici sedi bolj izobražen kader, kot je izobražen tisti v pisarni.\"", "Fenomen" },
                    { 1629, true, 43, "Kakšni časi so prišli: Greš po ulici, v žepu imaš najnovejši iPhone.    Spodrsne ti, padeš in slišiš škrccc.    Moliš boga, da je šel kolk!", "Res so čudni časi" },
                    { 1627, true, 43, "Poklicni šofer je vozil s tovornjakom po podeželski cesti. Nenadoma se je prikazal ob cesti majhen zelen možiček in ga ustavljal.    Šofer se je nekoliko začuden ustavil in ga vprašal: \"Kdo neki si pa ti in kaj hočeš??\"    Mali zeleni možiček je odvrnil: \"Jaz sem prišel z Venere, sem peder in sem lačen.\"    Voznik tovornjaka mu je dal sendvič in rekel: \"Tale sendvič je vse s čimer ti lahko ustrežem.\"    Peljal se je dalje, dokler ni ob cesti zagledal majhnega rdečega možička , ki ga je ustavljal.    Ustavil se je in vprašal: \"Od kod si spet ti vzel in kaj bi rad?\"    Mali rdeči možiček je odgovoril: \"Jaz sem prišel s Saturna, sem peder in sem žejen.\"    Šofer mu je dal pijačo in rekel: \"Žal mi je, toda to je vse kar lahko storim zate.\"    Čez nekaj časa je zagledal ob cesti majhnega modrega možička, ki ga je ustavljal. Zadeva z možički mu je bila zdaj že dokaj dobro poznana.    Zato se je ustavil in dejal: \"No ti mali modri peder , kaj bi pa ti rad dobil od mene?\"    Mali modri mož je odgovoril: \"Za začetek vaše vozniško in prometno dovoljenje, prosim...\"", "marsovci na vsakem koraku" },
                    { 1623, true, 43, "\"Punčka, rad bi te povabil k sebi,\" reče mladenič prikupni deklici.    \"Hvala, toda nisem za!\"    \"Toda - jaz ne povabim vsake!\" je uporen fant še naprej.    \"Tudi jaz ne zavrnem vsakega povabila.\"", "Ni vedno tako" },
                    { 1622, true, 43, "\"Eva, prisegam ti, da si prva ženska, v katero sem se zaljubil!\" je rekel Adam.    \"Ali si imel izbiro?\" ", "Prva" },
                    { 1621, true, 43, "\"Si pustil svoje dekle zato, ker je začela nositi očala?\"    \"Ne, ona me je zapustila, ko je začela nositi očala.\" ", "Razšla sta se" },
                    { 1616, true, 43, "Kaj postane daljše, kadar ga potegneš, se dobro prilagaja med joški, odlično se fiksira v luknjo in najbolje dela, kadar se nategne?      Ja varnostni pas v avtu, vendar!", "uganka" },
                    { 1601, true, 43, "Kateri instrument je najstarejši?    Harmonika, ker je najbolj zgubana.", "Starost inštrumenta" },
                    { 1600, true, 43, "Kdaj si že res star?    Takrat, ko stanejo svečke na torti več, kot torta.", "Starost" },
                    { 1598, true, 43, "Trije so v pisarni in eden dela. Kaj je to?    Dva uradnika in en ventilator.", "Javna uprava" },
                    { 1597, true, 43, "Blagor Kitajcem!    Kjerkoli kupujejo, kupujejo domače.", "Res so lahko srečni" },
                    { 1596, true, 43, "Na vlaku v kupeju sedijo: prekrasna in postavna blondinka, nuna, Hrvat in Slovenec.    Ko vlak zapelje v tunel, nastane popolna tema in zasliši se, kako pade krepka zaušnica. Ko vlak pripelje iz tunela, se Hrvat drži za otečen obraz in zmedeno gleda okrog sebe.    Nuna si pri sebi misli: \"Sigurno je ta prostak otipaval blondinko, in mu je ta vrnila tako, kot se spodobi.\"    Si misli blondinka: \"Sigurno me je hotel otipavati, in je slučajno zgrabil nuno in logično, dobil po zobeh.\"    Hrvat razmišlja: \"Sigurno je ta Slovenec otipaval eno od teh, in sem jih namesto njega, nič kriv, dobil jaz.\"    Sam pri sebi pomisli Slovenec: \"Kdaj bo spet tunel, da mu primažem še eno krepko?\"", "Zanimiva mešanica potnikov na vlaku" },
                    { 1594, true, 43, "Jože je svoji soplesalki, na plesišču, že tretjič stopil na nogo.    Soplesalka ga vpraša: \"Ali radi plešete?\"    \"Zelo rad!\" ji je odgovoril.    \"Zakaj se pa potem ne naučite?\"", "Na plesišču" },
                    { 1704, true, 43, "Pripravnik za pilota je prvič samostojno letel z letalom. Kliče ga kontrola poletov:    \"Me slišite?\"    \"Da.\"    \"Javite mi svojo višino!\"    \"Meter dvainosemdeset!\" ", "V zraku" },
                    { 1707, true, 43, "Že dolgo ugotavljam in sedaj mislim, da vem!    Nisem jutranja ptica in ne toliko nočna sova.    Vse kaže, da sem neka vrsta vedno utrujenega goloba", "No, da sem le ugotovil" },
                    { 1710, true, 43, "Janez in Mojca gresta na   slikarsko rastavo negdanjega  Mojcinega sosolca.  Nenadoma naletita na akt, v  katerem Janez prepozna Mojco.  O ljubi bog, ali si mu gola  pozirala?  Mojca v solzah:  Nisem, dragi, to je narisal  po spominu.", "Po spominu" },
                    { 1711, true, 43, "\"Tone, slišal sem, da imaš danes vozniški izpit!\"    \"Ja, danes, danes, toda to je že za menoj.    \"Si ga uspešno naredil?\"    \"Ne vem, član izpitne komisije me ne mara.\"    \"Ah, to si samo domišljaš. Kaj ti je pa rekel?\"    \"Nič. Ko so ga bolničarji nalagali na nosila, me je samo grdo pogledal.\" ", "Kandidat za vozniški izpit" },
                    { 1858, true, 43, "Miha je prijatelju pokazal novega psa.    \"Ima družinsko deblo?\" ga je vprašal prijatelj.    \"Ne, on lula pri vsakem drevesu.\" ", "Zanima ga rodovnik" },
                    { 1855, true, 43, "Prijatelj pride k direktorju na obisk in opazi, da ima ta odprt razporek na hlačah.    Ko ga opozori na to, si direktor zapne hlače in se v zadregi opraviči: \"Saj veš, te tajnice vse razmečejo. Za sabo pa nikoli ne pospravijo.\" ", "Direktorjev šlic" },
                    { 1850, true, 43, "Kužek vohlja čevlje fine dame.    Dama ga opazi in zavrešči: \"Da mi takoj odpeljete to ščene! Bolhe kar skačejo po moji nogi!\"    Lastnik: \"Pridi Valdi, gospa ima bolhe!\" ", "Bolhe ima" },
                    { 1832, true, 43, "Na dvorišču psihiatrične klinike se prepirajo trije pacienti: \"Jaz sem Prešeren!\" reče prvi.    \"Lažeš!\" zavpije drugi. \"Prešeren sem jaz!\"    \"Utihni! Meni je Bog povedal, kdo sem!\" se brani prvi.    \"Jaz ti nisem ničesar povedal!\" mu reče tretji.", "Na dvorišču se prepirajo" },
                    { 1820, true, 43, "Zadnjič sem se sprehajal po parku in v miru jedel burek.    Grem mimo enega gostega grma in iz njega se nenadoma zasliši pritajen glas: \"Daj ga sem, daj ga sem!\"    Ker nisem videl, kdo se oglaša izza grma, sem rekel: \"Kaj hočeš? Burek?\"    Glas izza grma: \"Ne burek, papir!\"", "Hotel je nekaj od mene" },
                    { 1817, true, 43, "Zakaj ni Mehičanov na olimpijski igrah?    Zato, ker so vsi, ki znajo hitro teči, plavati ali visoko skakati že na drugi strani meje.", "Mehičani in olimpijske igre" },
                    { 1814, true, 43, "\"Tisti tvoj prijatelj, ki je bil sinoči pri nas je odnesel odeje in brisače!\"    \"Ali je bilo vse skupaj kaj vredno?\"    \"Seveda! Saj sva jih šele pred tremi meseci odnesla iz hotela, kjer sva dopustovala!\" ", "O ti predrznež" },
                    { 1811, true, 43, "\"Ali veš, da je o moji ženi včeraj pisalo v časopisu.\"    \"Kaj res?\"    \"Da. Pisalo je, da je na svetu pet procentov žensk preveč.\"", "Omenjena v časopisu" },
                    { 1807, true, 43, "Sodnik obtožencu: \"Ali ste poročeni?\"    \"Nisem in tudi nikoli ne bom!\"    \"Kdo bi si mislil?! Tako pameten možakar, pa krade!\" je skomignil sodnik. ", "Na sodišču" },
                    { 1794, true, 43, "Bucek obisce male Eskimcke.  Ti mu hite razlagati, na  kaj mora se posebno paziti:  Nikar ne jej rumenega snega.", "Eskimi" },
                    { 1793, true, 43, "Pride kmet v kino. Se postavi v vrsto da bi kupil karto.    Prodajalka vstopnic ga vpraša:  \"Kaj pa imate tole na ramenu?\"    Kmet je odgovoril:  \"To je moja veverica, Maja. Vedno jo vzamem s  seboj, kamorkoli že grem.\"    \"Žal mi je\", pravi prodajalka. \"V kino ne spuščamo živali\".    Kmet je šel za vogal in Majo skril v hlače. Nato se je vrnil k prodajalki, kupil vstopnico, vstopil v dvorano in se usedel k dvema starejšima vdovama, Milki in Marički.    Film se je začel in Maja se je začela pritoževati nad neudobnim položajem.    Kmet si je odpel hlače, tako da je Maja lahko dala glavo ven in  gledala film.    \"Marička,\" je zašepetala Milka.    \"Kaj?\" pravi Marička, ki jo je film že popolnoma prevzel.    \"Mislim, da je moj sosed perverznež!\"    \"Zakaj?\" vpraša Marička.    \"Odpel si je hlače in ga dal ven.\"    \"No, ne sekiraj se zaradi tega,\" je rekla Marička, ki je še vedno pozorno gledala na platno.    \"Pri najini starosti sva videli že vse. Prav gotovo ni nič drugačen od ostalih. Centimeter več ali manj...\"    \"Tudi jaz sem tako mislila, ampak tale žre moje kokice!\"", "Kmet je šel v kino" },
                    { 1789, true, 43, "Možak potoži na policijski postaji: \"Denarnico so mi ukradli!\"     \"Kakšna pa je bila?\" vpraša policist.    Možaku se razjasni obraz: \"Lepa, velike oči, dolge noge, blond ...\" ", "Ukradli so mu denarnico" },
                    { 1787, true, 43, "\"Z ženskami ravnam kot s knjigami.\"    \"A tako pazljivo?\"    \"Ne, ko jo preberem, jo odložim in poiščem drugo!\" ", "Ravnanje z ženskami" },
                    { 1784, true, 43, "Dva pacienta psihiatrične bolnice sta odšla kot odposlanca vseh bolnikov na pogreb direktorja bolnice.    Ko sta se vrnila, so ju vprašali, kako je bilo.    \"Čudno!\" je odgovoril eden. \"Tako lepa muzika je bila, pa sva samo midva plesala!\" ", "Šla sta na pogreb" },
                    { 1573, true, 43, "Po cesti hodi starejša gospa in za sabo vleče dve veliki polni vreči za smeti.  V eni se ji naredi luknja in iz nje začnejo padati bankovci za 20 evrov, česar pa babica ne opazi. Zato pa nenavaden prizor pritegne pozornost policaja, ki pristopi k stari gospe.    \"Gospa, denar vam leti iz vreče,\" ji pove. Babica se obrne in res vidi, da je za sabo pustila pravo sled iz bankovcev.    \"Joj, hvala, da ste me opozorili,\" reče policistu.    \"Od kod pa taki stari ženici toliko denarja?\" je radoveden policist. \"Jah, veste,\" začne razlagati premetena gospa, \"živim čisto blizu nogometnega stadiona in obiskovalci tekem ves čas hodijo lulat k moji ograji. Ko si odprejo hlače in približajo svojega korenjaka k moji ograji, pa jaz nastavim škarje in rečem, plačaj 20 evrov, ali pa ti ga odstrižem.\"    \"A, tako, ja to ste se pa dobro spomnili,\" ji odvrne policist. \"Kaj imate pa potem v drugi vreči?\" jo še vpraša. Babica pa odgovori: \"Jah, veste, nočejo vsi plačati.\"", "Ženica in dve vreči" },
                    { 1783, true, 43, "Pred zabavo je rekla žena: \"Sploh nimam nikakršnega veselja oditi k Peternelovim na zabavo!\"    \"Misliš, da grem jaz rad?\" se je oglasil mož.    \"Toda, pomisli kako bosta vesela, če ne prideva!\"    \"Prav imaš! Greva!\" ", "Iti ali ne iti" },
                    { 1773, true, 43, "Sodnik je vprašal obtoženca: \"Ste kriv ali nedolžen?\"    \"To boste morali pa sami ugotoviti, saj ste vendar plačani za to!\" ", "Na sodišču" },
                    { 1772, true, 43, "Moški se ponudi lastniku nočnega kluba: \"Za tisoč evrov mesečno bi masiral vaše plesalke!\"    \"Prav!\" je rekel lastnik bara. \"Imate denar s seboj?\" ", "Masiral bi plesalke" },
                    { 1769, true, 43, "V knjigarno vstopi moški in reče prodajalki: \"Prosim, rad bi knjigo z naslovom Moški, gospodar v hiši.\"    Prodajalka ga pogleda in reče: \"Poglejte zgoraj, znanstveno fantastiko prodajamo v prvem nadstropju.\" ", "Zanima se za posebno knjigo" },
                    { 1761, true, 43, "\"Ti si moje Sonce, moja Venera.\" je šepetal fant, ko se je stiskal k dekletu.    \"Raje bi bila tvoj Saturn!\"    \"Zakaj pa Saturn?\"    \"Saturn ima prstan!\" ", "Vesoljski" },
                    { 1751, true, 43, "Janez kolesari preko mosta, ko na drugi strani ograje vidi stati punco, ki hoče skočiti.     Zaustavi se in pravi: \"Preden skočiš, bi te rad poljubil.\"    Punca pravi : \"Lahko,\" objameta se in globoko poljubita.    Janez: \"To je bil najlepši poljub v mojem življenju. Zakaj se hočeš vreči dol?\"    \"Starši ne marajo, da se preoblačim v punco.\"", "Tik pred zdajci" },
                    { 1749, true, 43, "\"Kakšna nesramnost!\" se razburja sedemdesetletnik. \"Razlagam ti, da je moja žena rodila sina, ti pa sprašuješ, kdo je oče!\"    \"No, nikar se ne razburjaj, no! Sem mislil, da veš.\"", "Res nesramno" },
                    { 1748, true, 43, "Trener rokometnega moštva je rekel vratarju: \"Ti bi lahko delal kot vratar v javni hiši!\"    \"Zakaj pa?\"    \"Ker tudi on vsakega pusti noter!\"", "Trener ga je okaral" },
                    { 1741, true, 43, "\"Gospod natakar, ali mi lahko poveste, kdo je gospod pri sosednji mizi? Ne vem, kam naj ga dam, ampak tako grozno se mi zdi znan!\"    \"Nič čudnega, saj ste ga prav gotovo videli na televiziji. Gospod je urednik našega največjega časopisa.\"    \"Kaj pa krasotica, ki je z njim?\"    \"To je pa sobotna priloga.\" ", "Nekam znan se mu zdi" },
                    { 1739, true, 43, "\"Ali ste testirali mojo mišelovko?\" vpraša izumitelj na patentnem uradu.    \"Smo.\"    \"Torej jo boste patentirali?\"    \"O tem bomo še razpravljali. Je pa zelo učinkovita! Danes zjutraj smo namreč pred mišelovko našli tri miši, ki so umrle od smeha, ko so jo videle.\" ", "Nova mišelovka" },
                    { 1735, true, 43, "Rocky, Jackie Chan in Chuck   Norris.  Rocky ponuja kokain in rece:  Mene je bog poslal na zemljo,   da imam najvec denarja in   vse zenske.  Jackie globoko vdihne, zaokrozi  z ocmi in rece:  Mene je bog poslal,da namesto  njega vodim svet....  Chuck Norris pa z globokim   glasom:  Nisem jaz nikogar nikamor   poslal.", "Jaz sem bog" },
                    { 1728, true, 43, "Vljuden gost, med zabavo, reče dekletu: \"Vaša šala o goskah je bila res enkratna!\"    \"Resno mislite?\"    \"Seveda! Kadarkoli bom videl gosko, se bom spomnil na vas!\" ", "Vljuden kompliment" },
                    { 1723, true, 43, "Rudi pride v knjigarno, si izbere knjigo in vpraša: \"Kaj jaz kot upokojenec lahko uveljavljam kakšen popust?\"    \"Seveda. Kot upokojenec ste upravičeni do posebnega popusta.\"    \"Kaj pa zato, ker sem bil borec?\"    \"Tudi to upoštevamo in dajemo popust.\"    \"Kaj pa to, da sem delničar vaše založbe?\"    \"Seveda, tudi zaradi tega imate pravico do popusta.\"    \"In koliko me bo torej stala ta knjiga?\"    \"Samo trenutek, da izračunam. Aha, sem že! 30 evrov smo mi dolžni vam.\"", "Vsi možni popusti" },
                    { 1722, true, 43, "Tone pride v trgovino in reče: \"Navaden dežnik bi rad kupil.\"    \"Vam lahko predlagam kaj boljšega?\"    \"Ni potrebno, saj ga bom tako ali tako nosil samo takrat, ko bo vreme zanič.\"", "Nakup dežnika" },
                    { 1719, true, 43, "Joža se usede na moped in odhiti domov. Kar naenkrat pred seboj zagleda ženico in jo podre.    \"Tepec, norec, idiot, kreten! A ne znate peljat' okoli?\"    \"Saj bi,\" odvrne Joža, \"pa bi mi potem bencina zmanjkalo!\"", "Povozil jo je" },
                    { 1780, true, 43, "Kaj je to zvestoba?    Da imaš po treh ločitvah če kar isto ljubico.", "Zvestoba" },
                    { 386, true, 41, "V nekem laboratoriju so delali vse možne poskuse z žabami. Pa najprej zdravi žabi rečejo:  “Skoči!”  In žaba skoči.  Nato žabi odrežejo nogo in rečejo:  “Skoči!”  A žaba se ne premakne.  Pa zapiše asistent v dnevnik:  “Če žabi odrežeš nogo postane gluha…”", "Poizkusi na žabi" },
                    { 865, true, 43, "Na krizarki Costa Luminosa,  ki pluje skozi Piranski zaliv,  stoji starejsa dama in z obema   rokama drzi klubuk,da ji ga ne  odnese veter.  Pa jo opozori mimoidoci castnik:  Gospa, ne zelim vas motit,a  verjetno niste opazili,da vam  veter dviguje krilo visoko  cez pas.  Ona:Hvala,toda tisto,kar vidite  tam spodaj,je staro ze 75 let.  Klobuk pa sem kupila sele vceraj.", "Starejsa dama" },
                    { 856, true, 43, "Mojca pride v trgovino z klobuki.  Trgovka je nemudoma pri njej.  Zelite,gospa?  Kupila bi klobuk s sirokim  obodom.  Trgovka:Na kaj konkretno  mislite,gospa?  Mojca:  Konkretno mislim na seks,  zdaj pa bi klubuk.", "Klobuki" },
                    { 119, true, 43, "Moški v lekarni: \"Kondome, prosim!\"    Lekarnarica: \"A dam vrečko zraven?\"    Moški: \"Ne, ni treba, ni tolk grda.\"", "Nakup kondomov" },
                    { 109, true, 43, "a neutron walks into a bar, orders a drink and asks bartender how much does it cost.  bartender: \"for you, no charge\"", "Angleški- znanstveni" },
                    { 108, true, 43, "a proton walks into a bar.    bartender:\"something to drink\"  proton:\"no thanks, i don't feel well\"  bartender:\"what's wrong?\"  proton:\" i think i lost an electron\"  bartener:\" are you sure?\"  proton:\"i'm positive\"", "Angleški- znanstveni" },
                    { 46, true, 43, "Poslanec gre po ulici in sreča mlado mamico z otrokom.  Otrok pokaže s prstom nanj in reče:” poslanec, poslanec!”  Poslanec je presenečen in mu reče nazaj: ” Kako pa ti veš da sem jaz poslanec? ”  Pa reče mamica:” Sej ne ve, samo R-ja še ne zna izgovoriti!!!”", "Poslanec" },
                    { 2117, true, 42, "Posodi za juho se reče jušnik.    Kako se pa reče posodi za župo?", "Pravo vprašanje" },
                    { 2039, true, 42, "Se pelje župnik z avtom in naleti na mrtvega osla, ki leži na cesti.    Pokliče policijo in reče: \"Tukaj župnik Anton, imate enega mrtvega osla na cesti, pa sem hotel, da ga umaknete, da se ne bi kdo zaletel v njega.\"    Dežurni policaj se hoče malo pošalit in reče: \"Hej župnik, a ste mu že zmolili oče naš?\"    Župnik: \"Še ne, sem najprej poklical naj bližnje sorodnike\"", "Župnik na cesti" },
                    { 2003, true, 42, "Par ima dva otroka, stara 8 in 10 let, ki sta zelo neubogljiva, nenehno se zapletata v težave in za vsako stvar, ki se zgodi v vasi, okrivijo njiju.    Nekega dne mami pride na uho, da je lokalni duhovnik precej uspešen pri discipliniranju neubogljivih otrok, zato ga vpraša, če se lahko pogovori z otrokoma.    Duhovnik se strinja, zato gre naslednji dan k njemu najprej mlajši.    Duhovnik, obilen možakar z globokim prodornim glasom, dečku ukaže, naj sede, ga pogleda naravnost v oči in z resnim glasom vpraša: \"Kje je Bog?\"    Deček nič ne odgovori, samo sedi tam s široko odprtimi očmi.    Duhovnik ponovi vprašanje: \"Kje je Bog?\"    Deček spet nič ne odgovori, zato duhovnik še dodatno povzdigne glas in uperi prst naravnost proti njegovemu obrazu: \"KJE JE BOG?!?\"    Deček bliskovito pobegne iz sobe, steče domov, se skrije v omaro in močno zaloputne vrata za seboj.    Ko ga tam najde starejši brat, ga vpraša, kaj se je zgodilo.    Mlajši, hlastajoč za zrakom, zgroženo reče: \"Zdaj sva pa v velikih težavah! Bog je izginil in vsi mislijo, da sva kriva midva!\"", "Po pomoč k župniku" },
                    { 2000, true, 42, "Mladoletni fant pride v spovednico: \"Odpustite mi, oče, grešil sem. Bil sem z žensko dvomljive morale.\"    Župnik vpraša: \"Ali si to ti, sosedov Jožek?\"    \"Da, oče.\"    \"Kako pa je ženski ime?\"    \"Tega vam ne morem povedati, oče. Ne bi hotel omadeževati njenega imena.\"    \"Slej kot prej ga bom izvedel. Saj ti ni treba imena povedati, le 'da' reci. Je bila Drginčeva Katra?\"    \"Res ne bom povedal.\"    \"Je bila Malejeva Marjanca?\"    \"Pa ne morem, če sem obljubil!\"    \"Srakarjeva Metka?\"    \"Molčal bom kot grob.\"    Župnik vztraja: \"Kaj pa mogoče Zupančeva Tinca?\"    \"Oče, ne sprašujte, ne bom je izdal.\"    \"Potem je bila pa Lavrinova Mici?\"    \"Prosim vas oče, zaobljubil sem se, da bom molčal.\"    Župnik nejevoljno vzdihne: \"Si pa res vztrajen, Jožek. Skoraj te moram občudovati. Vendar si grešil in za to se moraš pokoriti. Tri mesece ne smeš k maši. Zdaj pa pojdi v miru.\"    Jožek se vrne v svojo klop, kjer ga pričaka Franček, njegov najboljši prijatelj: \"No, kako je bilo?\"    \"Super!\"    \"Kaj si pa dobil?\"    \"Tri mesece počitnic in pet dobrih namigov.\"", "Pri spovedi" },
                    { 1943, true, 42, "Na avtobusni postaji se k župniku usede moški, ki zaudarja po alkoholu, ima razmazano šminko okoli ust, iz raztrganega žepa pa mu štrli steklenica vina.    Moški razgrne časopis in začne brati.    Kar naenkrat vpraša župnika: \"Kaj povzroča artritis?\"    Župnik pomisli, kako bi dal pijančku lekcijo, in reče: \"Artritis dobijo tisti, ki preveč razuzdano živijo, se družijo z ženskami dvomljivega slovesa, se vdajajo alkoholu in nimajo sočutja do sočloveka.\"    Čez nekaj minut župnik pomisli, da je bil mogoče pregrob do pijančka: \"Oprostite, da sem bil prej tako nevljuden. Kako dolgo pa že bolehate za artritisom?\"    Pijanček odgovori: \"Eh, nimam ga jaz. V časopisu sem prebral, da so ga našli pri papežu!\"", "Župnik in pijanec" },
                    { 1851, true, 42, "Trije duhovniki so šli na potovanje.    V gorskem jezercu so zaplavali v Adamovem kostimu, ko jih je presenetila skupina žensk, ki so se sprehajale ob jezeru.    Planili so iz vode, pograbili obleko in dva duhovnika sta si z obleko pokrila mednožje, eden pa obraz.    Ko so pritekli na varno razdaljo v bližnje grmovje je prvi vprašal tretjega: \"Zakaj si si pa ti z obleko pokril obraz?\"    \"No, ne vem, kako je v vajinih farah, toda v moji fari me ljudje prepoznajo po obrazu!\"", "Čudna prigoda na potovanju" },
                    { 1779, true, 42, "Župnik potuje z letalom v Rim.    Med poletom pride do njega stevardesa in ga vpraša: \"Boste malo konjaka?\"    \"Kako visoko pa smo, gospodična?\"    \"Deset tisoč metrov.\"    \"Potem pa raje ne, da me šef ne vidi.\" ", "Župnik na letalu" },
                    { 1463, true, 42, "Pred veroukom je sin vprasal oceta: \"Oci, kdo je bila Adamova tasca?\"  \"Adamova tasca? Adam ni imel tasce. To je bil raj!\"", "Raj" },
                    { 1453, true, 42, "Pri verouku zupnik vprasa Janezeka:  Kdo smo kristjani?  Ljudozerci.  Kako si upas tako nesramno govoriti?  Ce je pa res. V cerkvi nam vedno dajete Kristusovo telo in kri.", "Pri verouku" },
                    { 1446, true, 42, "Zupnik vidi pijanega Janeza in ga okara:\"Ali ne ves, da je alkohol clovekov najhujsi sovraznik?\"  Janez:\"Gospod zupnik, saj v Svetem pismu pise, da moramo ljubiti svojega sovraznika!\"", "Najhujsi sovraznik" },
                    { 1191, true, 42, "Nuna pri spovedi prizna zupniku, da so jo posilili. Zupnik ji za pokoro nalozi:  10 ocenasev,  10 zdravihmarij,  Cetrt limone.  Nuna: Zakaj pa limona?  Zupnik: Da ti izbrise ta blazeni nasmeh z obraza.", "Pri spovedi" },
                    { 1119, true, 42, "Pogovarjata se zupnika.  Pa vprasa prvi:  Ti, a mislis, da bo celibat kdaj  ukinjen?  Drugi odvrne:  Midva bova kaj takega tezko docakala,  nemara pa bodo vec srece imeli  najini otroci.", "Celibat" },
                    { 971, true, 42, "Župnik sprašuje Micko:  \"Mici, zakaj ste pa možu sredi maše primazali klofuto?\"  \"Gospod župnik, res se vam opravičujem,  ampak zadosti sem ga imela, ker me je  pogledal vsakokrat, ko ste rekli: \"In reši nas vsega hudega!\"", "Klofuta pri maši" },
                    { 955, true, 42, "Nedeljska pridiga v cerkvi.  Zupnik se jezi na vascane:  Kako strasno nemoralni ste  nekateri!  Samo poslusajte,kaj se mi je  vceraj zgodilo!  Grem na sprehod in ob reki za  grmom zagledam njega z njo.  Za drugim je on z njim,za  tretjim pa ona z njo.  Le kaj bo z vami,moji dragi farani?  Pa med otroskimi klopmi  Tincek zasepeta Mihcu:  Pozabil je povedati,da sem bil jaz  z njim na sprehodu.  Pa so bili vsi grmi zasedeni.", "Pridiga v cerkvi" },
                    { 813, true, 42, "Janezek pri verouku vprasa zupnika: Gospod zupnik, ali je Bog povsod?  Zupnik: Ja, Janezek, Bog je povsod!  Janezek: Zdaj sem pa vas, gospod zupnik. Mi sploh nimamo kleti. ", "Kje je Bog?" },
                    { 776, true, 42, "Bogdan je prišel s spovedi in rekel župniku:    \"Včeraj sem sedemkrat seksal!\"    \"Si prevaral svojo ženo?\"    \"Ne, seksal sem s svojo ženo!\"    \"To pa ja ni greh! Zato ti pa ne bi bilo potrebno priti k spovedi!\"    \"Ja, nekomu se pa le moram pohvaliti!\" je rekel Bogdan.", "Pri spovedi" },
                    { 764, true, 42, "Moški je prišel k spovedi in povedal duhovniku:  \"Oče, jaz sem zelo grešil!\"  \"Sinko, kar povej mi!\"  \"Veste, neki dan je k meni prišla sestra moje žene. Saj veste.... malo sva se zaklepetala, nato pa sem seksal z njo!\"  \"Sinko, saj to niti ni tako velik greh!\" ga je potolažil duhovnik. \"Bog odpušča tudi večje grehe!\"  \"Toda, to ni vse!\" je nadaljeval moški. \"K meni na obisk je prišla tašča. Malo sva se zaklepetala in tudi z njo sem seksal!\"  \"Tudi to ti bo Bog odpustil!\" je rekel duhovnik.  \"Veste,\" je nadaljeval moški pri spovedi, \"nekega dne sem šel mimo polja, ki ga je obdeloval sosed. Malo sva se zaklepetala, potem sem pa seksal tudi z njim!\"  \"Prav sinko, tudi to ti bo odpuščeno. Zdaj pa počasi odidi, da se ne bova zaklepetala.\"", "Pri spovedi" },
                    { 622, true, 42, "Mlada punca pride domov in razlaga mami: \"Mami, a veš, sem gospodu pomagala. Brisala sem porcelanast servis pa mi je padel na tra in sem vse razbila!\"    Mama zaprepadeno: \"PA je bil gospod župnik fejst jezen?\"    Punca: \"Niti ne! Naredla sva novi servis. Vidiš, da mi še zdaj porcelan teče po bedri.\"", "Pomagala je župniku" },
                    { 586, true, 42, "Župnik pred cerkvijo najde mrtvega osla in gre na policijo da to prijavi. Policisti odidejo z župnikom na kraj, si ogledajo kraj dejanja, nato pa eden od policistov reče župniku:  \"Gospod, ga boste pokopali z vsemi častmi?\"  \"Svojce sem obvestil in s tem sem svoje opravil. Vi pa organizirajte pogreb sorodnika kakor vam paše!\"", "Smrt osla" },
                    { 563, true, 42, "V večernih urah nuna zaustavi taksi:  \"V javno hišo, prosim!\"  Taksist jo odpelje do javne hiše, nuna mu pravi, naj jo počaka in gre noter. Čez pet minut se vrne in pravi:  \"Do samostana, prosim!\"  Taksist ne more brzdati radovednosti in jo vpraša:  \"Zakaj ste pa šli v javno hišo?\"  \"Morala sem preveriti cenik, da nas duhovniki ne bi goljufali.\"", "Nuna in javna hiša" },
                    { 459, true, 42, "Po maši k župniku prihajajo farani, mu podajo roko in se mu lepo zahvalijo.    Pristopi tudi lepo oblečen moški in reče: \"Gospod župnik - za popizdit dobro pridigo ste imeli!\"    \"Me veseli, da vam je bila všeč, vendar bi vas prosil, da takih besed ne uporabljate, ker se to v cerkvi ne spodobi.\"    \"Kakorkoli že,\" nadaljuje možakar, \"vaša pridiga mi je bila tako všeč, da sem vam fuknil 100 evrov v puščico.\"    \"Ne me jebat?!\" odvrne župnik.", "Dobra pridiga" },
                    { 260, true, 42, "Sredi džungle se, iz oči v oči, srečata župnik in lev.    Župnik: \"Gospod moj, navdihni to žival s krščanskim duhom!\"    Lev pa nazaj: \"Gospod, blagoslovi hrano, ki jo bom zaužil!\"", "Duhovnik na lovu" },
                    { 217, true, 42, "Mladi župnik je bil tako nervozen pred svojo prvo mašo, da ni mogel  spregovoriti niti besede. Vpraša škofa, kaj mu je storiti, le-ta pa mu  pove, naj naslednjič spije kozarec vode, v katerega naj kane dve kapljici vodke.  Takoj se bo počutil bolj sproščenega.  Mladi župnik stori, kot mu je svetoval škof. Potem se je župnik  počutil tako dobro, da ga ni moglo nič več vznemiriti.    Po končani maši najde škofovo sporočilo:  \"Naslednjič dajte dve kaplijici vodke v vodo in ne obratno.  Poleg tega je tu nekaj napotkov, da se ne bodo ponovno pripetili izpadi:  - ni potrebno dajati rezin limone na rob keliha,  - ne naslanjajte se več na kip device Marije, ne objemajte in ne poljubljajte je,  - obstaja 10 in ne 12 zapovedi,  - obstaja 12 apostolov in ne 7 in niti eden od njih ni Palček,  - Jezusa in njegove ucence ne nazivamo J.K. & Co.,  - David je premagal Goljata s fračo in kamnom, ni ga razbil kot kanto,  - Židov ne imenujemo kurbini sinovi,  - papeža ne smemo imenovati El Padrino,  - Bin Laden nima nobene veze z Jezusovo smrtjo,  - hostija ni prigrizek k vinu,  - grešniki gredo v pekel in ne v pizdo materino,  - tisti v vogalu, zraven zbora, ki ste ga imenovali travestit v obleki, sem bil pa jaz!", "Prva maša" },
                    { 174, true, 42, "\"Gospod župnik, grešila sem!\"    \"Povej, dete moje, svoj greh.\"     \"Nosim prekratko mini krilo.\"    \"No, saj to pa ni tak greh.\"    \"Ampak, gospod župnik, jaz spodaj ne nosim hlačk.\"    \"Jezus Marija, to je pa hud greh. Za pokoro zmoli tri Oče naše, tri Zdrava Marije pa še deset prevalov po sredini cerkve boš naredila!\" ", "Poredna mlada grešnica" },
                    { 173, true, 42, "Duhovnik iz male slovenske vasi je bil velik ljubitelj ptic, ki jih je skrbno čuval v kletki za cerkvijo.  Neko nedeljsko jutro je ob običajnem sprehodu med perjadjo opazil, da je izginil njegov najlepši ptič in ker je vedel, da ga je moral ukrasti nekdo tik pred mašo, se je odločil nagovoriti svoje vernike.    \"Kdo ima tiča?!\"  Vstali so vsi moški.    \"Ne, nisem mislil tako. Je kdo videl tiča?\"  Vstale so vse ženske.    \"Ne, ne, tudi tega nisem mislil. Je kdo videl tiča, ki mu ne pripada?\"  Vstala je polovica žensk.    \"Neeee, ne in ne, mislil sem ali je kdo videl MOJEGA tiča?\"  Vstali so ministranti, dva duhovnika in koza.    \"Neee mislil sem ali ima kdo zdaj tiča v rokah?\"  Vstala je punca v zadnji klopi in rekla fantu: \"Sm ti rekla, da bo videl!\" ", "Izgubljeni ptič" },
                    { 126, true, 43, "Klepetata na klopci v parku dva starejša upokojenca, pa gospa vpraša gospoda:  \"Koliko let pa imate?\"  On: \"95 \"  Ona: \"Ne bi vam dala\"  On: \"Sej tut ne bi mogu.\"", "Upokojenec v parku" },
                    { 130, true, 42, "Duhovnik v avtu med vožnjo zagleda pred sabo ob cesti nuno. Ustavi avto in  ji ponudi prevoz, kar nuna zahvalno sprejme.    Vstopi v avto in prekriža noge, tako da razgane svoje krilo in odkrije svojo prelepo nogo.    Duhovnik to vidi in ni veliko manjkalo , da bi povzročil nesrečo. Ko je ponovno prevzel kontrolo nad vozilom , naskrivaj  spusti roko na nunino koleno.    Nuna ga pogleda in reče: “Oče, se spomnite 129. Psalma?”    Duhovnik pordeči in se globoko opraviči ter umakne roko iz njenega kolena. Med menjanjem prestave zopet položi roko na koleno nune.    Pa ga nuna ogovori: “Oče, ali se res ne spomnite 129. Psalma?”  Še enkrat se duhovnik opraviči in reče:”Oprostite, toda telo tudi greši.”    Prišla sta do ženskega samostana, duhovnik ustavi avto, nuna ga pogleda in izstopi.    Duhovnik pa čim pride v  svojo cerkev vzame Sveto pismo in pogleda Psalm 129, v katerem je pisalo:  “O gospod, ti si na pravi poti, pojdi naprej in išči,  nadaljuj in spoznal boš vrhunec slave!”", "Župnik in nuna" },
                    { 143, true, 43, "Kaj čakajo pred javno hišo Američan, Žid in Ukrajinec?    Američan čaka, da se zamenja smena.    Žid čaka popust.    Ukrajinec čaka ženo.", "Čakanje pred javno hišo" },
                    { 155, true, 43, "Pride James Bond v en fancy lokal in pri baru sreča čudovito, dolgonogo, dolgolaso in na pravih mestih zaobljeno lepotico.  Vrže ji dolg pogled, nato pa pogleda na uro. In tako še nekajkrat.    Pa ga ogovori lepotica: Kaj pa je tako zanimivega na uri?    In odvrne James Bond: \"Ah, tole je najnovejši model ure. Z njo komuniciram preko alfa žarkov.\"  Lepotica: \"A ja? Kaj ti pa reče tvoja ura?\"    Bond: \"Ravnokar mi je povedala,da ne nosiš spodnjih hlačk.\"    Lepotica rahlo zardi, potem pa reče: \"To pa ni res. Saj imam spodnje hlačke.\"    Bond pogleda uro, jo potrka in prinese k usešu. Nato pa rece:  Jebenti, pa res prehiteva za eno uro! ", "James Bond in lepotica" },
                    { 366, true, 43, "Gredo trije prijatelji po travniku in srečajo dobro vilo.    Vila: \"Vsakemu bom izpolnila željo. Treba je skočiti v reko in izgovoriti eno besedo. In v izgovorjeni besedi se bo kopal celo življenje.\"    Prvi skoči in reče: \"Denar\"  Se je takoj valjal v denarju.    Drugi skoči, rekoč: \"Sladkarije!\"  In se že kopa v sladkarijah.    Tretjemu spodrsne in, ko ga nese proti reki se zadere: \"ŠIT!\"", "Dobra vila izpolni eno željo" },
                    { 331, true, 43, "Kaj imata kondom in cigaret skupnega?  Uporabiš, uživaš, odvržeš", "Kondom in cigaret" },
                    { 329, true, 43, "Se Italijan zaleti u podgurkino bajto pa reče:Skuzi,seniora,Skuzi.Pa reče podgurka:Nč skuzi okul bo treba!!", "Italjan in podgurka" },
                    { 325, true, 43, "Se grejo Arhimed, Newton in Pascal skrivalnice.    Pa Arhimed šteje. Pascal se takoj skrije Newton pa se postavi na vidno mesto in okrog sebe nariše kvadrat.     Arhimed prešteje do konca in se obrne. Zagleda Newtona in reče: \"Newton! Vidim te!\"    Newton: \"Ni res! Newton na kvadrat je Pascal.\" ", "Arhimed, Newton in Pascal" },
                    { 321, true, 43, "Grejo bosanec, italjn in slovenec na letalo.    Ker so bili pretežki, je bilo treba nekaj odvreči iz letala vse, česar ne bi pogrešali.    Vrže italjan makarone dol in pravi: \"Tega imamo mi še preveč!\"    Vrže bosanc smeti:  \"Tega imamo mi preveč!\"    Začne slovenec gledat bosanca.    Bosanec: \"Da NE BI slučajno!\"", "Slovenec, italijan in bosanec na avionu" },
                    { 320, true, 43, "Gresta 2 zobotrebca po cesti in srečata ježa.    Reče eden: \"Glej, cel avtobus folka!\" ", "Zobotrebca se sprehajata" }
                });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "Id", "Active", "CategoryId", "Description", "Title" },
                values: new object[,]
                {
                    { 318, true, 43, "Gresta dva pralna stroja čez cesto. Eenga zbije avto pa drug začne pet: \"Da pralni stroj bi dlje živel dodaj Kalgon.\" ", "Dva pralna stroja" },
                    { 317, true, 43, "Gresta zobotrebca po cesti, pa vidta šivanko in rečeta: \"Glej, Terminator!!!!\"", "Zobotrebca gresta po cesti" },
                    { 310, true, 43, "\"Veš, jaz diamante, ko se umažejo, čistim kar z milnico!\"    \"Jaz pa, ko so umazani, svoje vržem stran in si kupim druge.\"", "Pogovor dveh milijonarjev" },
                    { 309, true, 43, "Peter je ležal obnemogel v bolnišnici, kjer ga je obiskal sosed.    \"Kako je kaj s teboj, sosed?\" ga je vprašal.    \"Grozno! Že zdavnaj bi umrl, če medicinske sestre ne bi tako loputale z vrati!\"  ", "Obnemogel v bolnici" },
                    { 307, true, 43, "Gerhard je star že 40 let, pa še vedno nima dekleta.    Nekega dne ga prijatelj vpraša: \"Kako to, da pri tvojih letih še vedno nimaš žene. Vsi ostali iz družbe smo že poročeni, ti pa dekleta menjavaš kot po tekočem traku!\"    Gerhard: \"Tega pa nisem sam kriv. Katerokoli dekle pripeljem domov za mojo mamo ni dobra.\"    Prijatelj: \"No, potem moraš pa najti dekle, ki bo podobna tvoji mami\" mu je svetoval.    Čez nekaj tednov se ponovno srečata.    Prijatelj: \"In? Si našel dekle podobno tvoji materi?\" ga vpraša.    Gerhard: \"Seveda sem. Popolnoma tak karakter ima kot moja mama. Ko sem jo pripeljal domov in jo je mama spoznala je bila zelo zadovoljna in jo je z veseljem sprejela.\"    Prijatelj: \"Se bosta torej poročila?\"    Gerhard: \"Kje pa! Moj oče je sploh ne prenese!\"", "Nobena punca ni prava" },
                    { 306, true, 43, "Če se bom kdaj poročil, bom vzel takšno, ki bo imela smisel za humor.    \"no, saj kakšna druga te zagotovo ne bi vzela.\"", "Načrt za ženitev" },
                    { 303, true, 43, "\"Strašno! To noč sem sanjal, da sem Kitajec!\"    \"Kaj pa je v tem tako strašnega?\"    \"Nič nisem razumel, kaj so mi pravili.\"", "Sanjal je" },
                    { 301, true, 43, "Nekdanja sošolca se srečata na peronu železniške postaje.    Eden je bil oblečen v generalsko uniformo in bil vitek in visok, drugi pa je bil kardinal, precej širok in seveda oblečen v cerkvena oblačila.    Ko je kardinal opazil, da ga general noče prepoznati, ga je vprašal: \"Oprostite, gospod sprevodnik, ali veste kdaj odpelje vlak proti Mariboru?\"    General ga je ostro pogledal in mu odgovoril: \"Čez deset minut! Toda, draga gospa, jaz v vašem stanju ne bi potoval tako daleč!\"", "Nekdanja sošolca se srečata" },
                    { 288, true, 43, "Prijatelja, oba plešasta, se prepirata: \"Ti si bolj plešast kot jaz!\"    \"Kako naj bom bolj plešast, ko pa nihče od naju nima niti enega lasu več na glavi?\"    \"Ti imaš večjo glavo!\"", "Plešasta prijatelja" },
                    { 287, true, 43, "Kaj je to? Pije kri, pa ni vampir, ima krila, pa ni ptica?    \"Komar!\"    \"Ne, to so damski vložki s krilci.\"", "Pije kri in ima krilca" },
                    { 286, true, 43, "Do včeraj nisem vedel, da je Vinko tako močno veren!    \"Veren? Vinko? Nemogoče!\"    \"Pa je res. Včeraj sem ga videl pred izložbo mesnice, ko se je križal.\"", "Nenadoma postal veren" },
                    { 279, true, 43, "\"Pri nas imamo vsak dan meso!\" se pohvali Tine sosedu.    \"To pa ne bo res! Pri takšnih cenah je to praktično nemogoče!\"    \"Je mogoče! Kupimo ga, in ga imamo šest dni v zamrzovalniku. Sedmi dan ga pojemo in ga nato ponovno kupimo.\"", "Doma imajo meso" },
                    { 271, true, 43, "Srečata se italijanski in ukrajinski mafijski boss.    Vpraša italijan ukrajinca:  - Ali imas štirinadstropno hišo?  - Nimam, odgovori ukrajinec.  - Potem se nisi pravi mafijaš!      Čez par dni se spet srečata:  - Ali imas črno limuzino, Mercedesa?  - Nimam, odgovori ukrajinec.  - Potem se nisi pravi mafijaš!      Pri naslednjem srečanju:  - Ali imas debelo zlato verižico?  - Nimam, odgovori ukrajinec.  - Potem se nisi pravi mafijaš!      Ukrajinec se razjezi, gre domov in izda ukaz pomočniku: \"Dva štuka na bajti dol porušit, helikopterje prodat in kupit Mercedesa, zlato ketno vzet s psa, jo bom odslej jaz nosil.\"", "Italijanski in ukrajinski mafijaš" },
                    { 255, true, 43, "Rad bi umrl mirno, v spanju. Tako, kot moj dedek.    Ne ipično in kričeče, kot njegov sopotnik.", "Način, kako umreti" },
                    { 254, true, 43, "Kakšna je razlika med avtom in pijancem?    Ko avto natanka, lahko pride skoraj do Frankfurta.    Ko pijanec natanka, pa ne more niti čez cesto.", "Razlika: pijanec - avto" },
                    { 253, true, 43, "Kakšna je razlika med slabim strelcem in slabim šoferjem?    Slab strelec ne zadene ničesar.    Slab šofer pa vse.", "Šofer in strelec" },
                    { 252, true, 43, "Tovornjak se bliža predoru.    Pred njim stoji ozorilna tabla: \"Višina 4 m!\"    Eden od voznikov reče: \"Kaj pa sedaj? Najin kamion je pol metra višji!!!\"    Drugi odvrne: \"Nič hudega! Saj ni nikjer nobenega policaja!\"", "Tovornjak proti predoru" },
                    { 227, true, 43, "Komisija: \"Ali znate pisat?\"    Vprašani odgovori: \"Ne.\"    Komisija: \"Kaj pa brat?\"    Vprašani: \"Eh, brat je še večji cepec, kot jaz!\"    ", "Pismenost" },
                    { 221, true, 43, "Največja ženska laž: Čez 5 minut bom zrihtana.    Največja moška laž: Čez 5 minut bom doma.", "Laži" },
                    { 219, true, 43, "Moški se utaplja v morju.  Ko mu uspe priti na gladino, se dere: \"Na pomoč, NA POMOČ!!!\"    Moški na obali: \"Zakaj se dereš?\"    Nesrečnik: \"Ne znam plavati!!!\"    Iz obale: \"Ja, pa kaj zdaj? Jaz tudi ne znam plavati, pa se ne derem.\"", "Utapnjanje" },
                    { 172, true, 43, "Na sprehajališču dregne študent prijatelja:  \"Ali vidiš tisto v mini krilu na oni strani ceste?\"  \"Vidim, dobra mačka. Kaj je z njo?\"  \"Z njo sem že večkrat spal...\"  \"Res? Kje pa?\"  \"Na predavanjih.", "Spanje" },
                    { 159, true, 43, "Pride kmet na banko in želi dvigniti denar z računa. Pobrska po žepih in na dan privleče potrdilo o depozitu. Gospa za okencem si ga oglede in reče:  \"Žal mi je, ampak tega denarja ne morete dvigniti. Je namreč vezan za eno leto.\"  Kmet se začudi: \"Kako ne morem, če ga pa potrebujem?\"  \"Ja vezan je, gospod, šele čez eno leto ga boste lahko dvignili,\" mu pojasni uslužbenka.  Kmet se malo zamisli, potem pa se spomni, da ima še en depozit na drugem računu. Na dan privleče še drugo potrdilo, a tudi tukaj se zatakne.  \"Zelo mi je žal, veste, ampak tudi ta denar je vezan. Šele čez dve leti ga boste lahko dvignili.\"  \"Kako to mislite vezan?\"  \"Ja vezan je, gospod, in to pomeni, da ga v tem trenutku ne morete dvigniti.\"  Kmet že precej nejevoljno reče: \"Ampak jaz moram odplačati dolgove in nujno potrebujem ta denar sedaj.\"  Uslužbnenka za okencem spredvidi, da bo preprostemu možaku težko razložiti vse skupaj, zato predlaga drugačno rešitev:  \"Gospod, vi ste kmet, kajneda? Kaj pa če bi poskusili upniku plačati kako drugače? Recmo… ali imate jajca? Morda bi šlo pa na ta način?\"  Kmet jo za daljši trenutek pogleda, potem pa reče:  \"Da, imam jajca. Ampak veste, so vezana na tiča!\"", "Kmet na banki dviguje denar" },
                    { 158, true, 43, "Možakar vstopi v trgovino in pri mladi prodajalki naroči 10 dag pariškeklobase.    Prodajalka nareže klobaso, jo položi na tehtnico in vpraša: \"12dag je,jo lahko zavijem?\"  Možakar zavije z očmi:  \"Rekel sem 10 dag, prosim, da to upoštevate!\"    Prodajalki ne preostane drugega kakor, da odstrani dve rezini klobase in vpraša:  \"Devet dag je, bo v redu?\"    Možak nejevolno zmaja z glavo:  \"Devet ni 10. Rekel sem 10 dag.\"    Prodajalka doda eno rezino nazaj:  \"Ali je lahko 10 dag in pol?\"    Možakar pa vzroji:  \"Ali res moram stokrat ponavljati?! Hočem 10 dag in pika!\"    Prodajalka se nagne k njemu in ga po tiho vpraša:  \"Me lahko prosim primete za prsi?\"    Možakar je šokiran in zmedeno vpraša:  \"Zakaaaj pa zdaj to?\"    Prodajalka pa mirno odvrne:  \"Kadar me kdo jebe, mi je všeč, če me zraven drži za joške!\"", "Prodajalka in tečna stranka" },
                    { 152, true, 43, "Mlad igralec je dobil prvo vlogo na odru. Sicer vloga ni bila nič posebnega, moral bi priti na oder z rožo v roki, dvigniti rožo k nosu in reči:  \"Oh, ta nežni vonj moje drage!\"    Pred premiero je bil seveda močno živčen. Prišel je usodni trenutek. Fanta je nekdo sunil, stopil je na oder, privzdignil rožo k nosu, in na vso srečo brez problema povedal svoj znameniti stavek:  \"Oh, ta nežni vonj moje drage!\"    Ni se še dobro vrnil za oder, ko je dvorana eksplodirala od smeha.  Ljudje so noreli in kričali.  Seveda je zaskrbljen vprašujoče pogledal režiserja. Ta pa mu je odgovoril:  \"Bedak neumni, rožo si pozabil!\"", "Neizkušen igralec" },
                    { 2102, true, 41, "Katera riba se zelo trudi, a ji nikoli ne uspe?    Skuša.", "Ves trud je zaman" },
                    { 2101, true, 41, "Zakaj morski pes ne ugrizne črnca?    Ker misli, da je drek od kita.", "Ignoranca" },
                    { 2100, true, 41, "Uči mama malega morskega psa, kako naj lovi. Tako priplavata do  neke osamljene plaže in mama reče:  “Najprej priplavaš v bližino človeka in narediš dva kroga  okrog njega. Potem se malo oddaljiš, spet na hitro priplavaš  in ga udariš z repom. Potem ponovno priplavaš do njega in  samo malo zagrizeš vanj. Nato narediš še manjši krog okoli  njega in ga poješ.”  Pa vpraša mali morski pes: “Zakaj bi zgubljal toliko časa, zakaj ga  takoj ne pojem?”  “Lahko”, pravi mama: “Ampak potem ga boš pojedel z drekom  vred!”", "Postopek jedenja človeka" },
                    { 1123, true, 41, "Korel in Francelj v ljubljanskem  Tivoliju krmita golobe.  Korel: Ves kaj, ti golobi me vse bolj  spominjajo na politike.  Francelj: Kako to mislis?  Ko so spodaj, ti jedo iz roke, ko  pa so zgoraj, mirno serejo po tebi.", "Golobi" },
                    { 1110, true, 41, "Potrka volk na vrata sedmih kozlickov.   \"Kdo je?\"  \"Jaz sem vasa mama in sem vam prinesla toplega mleka.\"  \"Ne, nisi. Poslali smo jo po mrzli pir!\"", "Volk in sedem kozlickov" },
                    { 1100, true, 41, "Medved se odloci da gre pogledat  zlahto v Ameriko.  Na avijonu postane lacenin gre  v pilotsko kabino pojest pilota.  Pilot: Ne mene, jaz upravljam ,   avion, ce me pojes bomo   strmoglavili.  Obrne se k kopilotu: Bom pa tebe,   umiram od lakote.  Kopilot: Ne mene, jaz pomagam  pilotu, najmanj skode bo ce pojes  stevardeso!  Medo odlaca do stevardese, z njo  spregovori nekaj besed in gre  sedet na svoj sedez.  Gre pilot cez cas preverit stanje  v avionu. Vidi stevardeso zivo,  medveda pa na svojem mestu in   gre do njega.  Kako to, da nisi pojedel stevardese  ko si pa lacen za umret?  Ja, a pol bosta pa mene kavsala....", "Medved" },
                    { 1055, true, 41, "Medved je praznoval rojstni dan.  Na zabavo je povabil vse živali iz gozda, hkrati pa jim ukazal, da mu morajo prinesti lepa darila.  Medved se odloči, da bo tistega, ki mu ne bo prinesel dovolj dobro darilo pretepel s svojim kurcem.    Prva prideta volk in lisica ter medvedu prineseta videorekorder.  Medved je bil z darilom zadovoljen.    Nato pride zajček.  Ker je bil bolj reven in si ni mogel privoščiti dragega darila je medvedu prinesel korenček.    Medved je bil vidno razočaran, hkrati pa tudi jezen zato vzame svojega korenjaka v roke in začne udarjat po zajčku. Udarja ga po glavi, po hrbtu...zajček pa umira od smeha.    Ga medved vpraša: \"Zajček, kaj je pa tako smešnega?!\"    Zajček, ki umira od smeha, odgovori: \"Ježek ti bo hruško prinesel...\" ", "Medvedov rojstni dan" },
                    { 1032, true, 41, "Dva upokojenca sta v parku hranila golobe, ko prvi spregovori: Golobi so kot politiki.  Drugi: Zakaj?  Prvi: Ko so na tleh, ti jedo z roke, ko so zgoraj, pa ti serjejo po glavi.", "Golobi" },
                    { 1003, true, 41, "Oci,kaj jedo kiti?  Kaj pa vem.  Morda sardele.  Kako pa odpirajo konzerve?", "Sardele" },
                    { 943, true, 41, "Konj in osel se prepirata  o tem,kdo je vec vreden:  Konji smo stoletja bojevali  bitke,prevazali in prenasali  ljudi cez drzave,mi smo ponos  zgodovine.  Pusti to.Tehnika je konje povozila,  osli pa bodo vedno obstali. ", "Vecvrednost" },
                    { 905, true, 41, "Se pogovorjata dve kokosi.  Nekam zalostna se mi zdis danes. Je kaj narobe?  Ja, vrocina me kuha.  Si si jo izmerila?  Ne. Ze tri dni nesem kuhana jajca!", "Kokosi" },
                    { 822, true, 41, "Kako lahko ločimo spol muhe?    Ženska muha se v sobi odleti na ogledalo.    Moški muha pa se vsede na flašo od piva.  ", "Muhe" },
                    { 818, true, 41, "Neznanec stopi v vasko gostilno:  Cigav je pidbul,ki je privezan  zunaj?  Oglasi se Korel:Moj je.  Je kaj narobe?  Prislek:Ja,izgleda,da ga je ubila   moja civava.  Korel:Nemogoce,le kako bi lahko  civava ubila pitbula?  Neznanec: ocitno se mu je zataknila  v grlu.", "Pitbul" },
                    { 805, true, 41, "Bill Gates je lovil ribe in ujel zlato ribico ter jo vrgel nazaj v vodo. Zlata ribica je skocil iz vode: kaj pa tri zelje?  Bill Gates: Ja, povej, kaj bi rada mela!", "Bill Gates lovi ribe" },
                    { 803, true, 41, "V zivalskem vrtu so imeli razpis za sluzbo.   Franc se je prijavil na oglas. Na razgovoru mu je direktor zivalskega vrta razlozil, da iscejo nekoga, ki bo zamenjal majmuna, ki je crknil.  Franc: In kaj bom moral delati?  Direktor: Preoblekel se bos v majmuna in v kletki skakal z veje na vejo.  Franc je sluzbo sprejel. Naslednji dan se je oblekel v majmuna in se vihtel z veje na vejo. Ker se je prevec vzivel v nalogo, je izgubil nadzor nad sabo in se zavihtel v klerko, v kateri je bil lev.   Franc se je v levji kletki zacel dreti na vec glas, ko je lev rekel: Ne deri se tako glasno. Bi rad, da oba zgubima sluzbo.", "Zivalski vrt" },
                    { 753, true, 41, "Po Avstraliji skače kenguru in se vsakih sto metrov ustavi. Iz njegove vreče pokuka pingvinček in bruha kot nor.  Na Antarktiki med skupino pingvinov sedi kengurujček, občasno kihne in zagodrnja:  \"K***c pa taka izmenjava študentov!\"", "Izmenjava " },
                    { 746, true, 41, "Mlad ježek se je izgubil v puščavi. Ko se je zaletel v kaktus je vprašal:  “Si ti, mama?”", "Ježkova mama" },
                    { 745, true, 41, "Polž pleza po deblu češnje. Mimo prileti kos in mu reče:  “Nima smisla, da plezaš po drevesu, saj ni nič češenj!”  “Ko bom na vrhu bodo že!”", "Češnje na drevesu" },
                    { 744, true, 41, "Zajček je svojo zajkljo odpeljal v cirkus in tam sta videla nenavadno čarovniško predstavo.  Čarovnik je iz klobuka vlekel majhne zajčke. Pa se je oglasila zajklja: “Ni slabo, toda meni je še vedno bolj všeč tako, kot to delava midva!” ", "Zajčki" },
                    { 743, true, 41, "Zajček gre zvečer pijan z žurke. Omaga pod drevesom in zaspi.  Mimo prideta medved in volk. Stepeta se kdo bo požrl zajčka in v pretepu oba obležita v nezavesti.  Ko se zajček prebudi ju zagleda in zakolne: “Porka madona, ne smem več piti, kadar sem pijan res nimam prave mere, da sem ju tako hudo prebutal!” ", "Pijančevanje" },
                    { 742, true, 41, "Zakaj petelini tako zgodaj kikirikajo?  Ker, potem ko se zbudijo kokoši, ne pride do besede.", "Kikirikanje" },
                    { 741, true, 41, "Pridejo tri muhe v restavracijo.  Prva naroči: “Drek s čebulo”.  Druga naroči: “Drek s česnom”.  Tretja pa pravi: “Jaz bom pa samo drek, da mi ne bo potem iz ust smrdelo”.", "3 muhe v restavraciji" },
                    { 740, true, 41, "Želvica pleza na visoko drevo. Po dolgih urah mučnega plezanja pripleza na vejo in se požene v globino. Med padanjem na vso moč krili s sprednjima nogama. Z glasnim treskom prileti na tla in omedli.  Ko se zave, spet začne počasi plezati na drevo, spet skoči in ponovno trdo trešči ob tla. Toda po vsakem padcu želvica spet in spet spleza na drevo.  Z veje jo žalostno opazujeta dva ptička. Čez čas se samička obrne k samcu: “Veš, mislim, da je prišel čas, da najini želvici poveva, da je posvojena.!” ", "Želvica" },
                    { 739, true, 41, "Dve vrani se pogovarjata in srečata reaktivca kako leti.Pa reče prva vrana:>Glej kako hitro leti!<  pa druga vrana reče:>Tudi ti bi tako hitro letela če bi ti rit gorela<", "Goreča rit" },
                    { 711, true, 41, "Gresta prašič in pes po cesti, pa začne padat dež.  Reče prašič : “Pasje vreme”  Pa reče pes: “Ja, svinjsko lije”  ", "Vreme" },
                    { 634, true, 41, "Zakaj petelin kikirika tako zgodaj zjutraj?    Ker potem, ko se kure prebudijo, ne pride več do besede.", "Zgodaj zjutraj" },
                    { 630, true, 41, "Zakaj petelin tako veselo kikirika?    Ker ima veliko kur, pa nobene tašče.", "Kikirikanje" },
                    { 596, true, 41, "Orel sedi in počiva na veji, čisto nič ne dela..  Majhen zajček zagleda orla in ga vpraša: \"Ali lahko tudi jaz tako sedim in nič ne delam?\"  Orel odvrne: \"Seveda, zakaj pa ne?\"  In tako sede zajček pod vejo na zemljo in tudi on počiva. Nenadoma plane iz grmovja lisica, zagrabi zajčka in ga poje.  Morala zgodbe:  Da bi lahko sedel in nič delal, moraš sedeti zelo, zelo visoko..", "Orel, zajček in lisica" },
                    { 530, true, 41, "Žaba pogleda štorklji iz riti.    Presenečena nad višino vpraša: \"Aaaaaaaaa, kako visoko sva?\"    Štorklja: \"2700 metrov!\"    Žaba: \"Ne seri!!!\"", "Žaba in štorklja" },
                    { 514, true, 41, "Na veji visijo trije netopirji in se hvalijo češ, kako oni pijejo kri.    Odličili so se, da bodo tekmovali v pitju krvi.    Odleti prvi in se vrne nazaj krvav okoli ust in reče: \"Vidita tisti travnik, na katerem so bile ovce?\"    \"Vidima.\" odgovorita druga dva.    Prvi: \"Vse je mrtvo! Vsem ovcam sem popil kri.\"    Odleti drugi in se vrne čez čas še bolj krvav, kot prvi: \"Vidita tisto vasico?\"    Druga dva: \"Vidima.\"    Drugi: \"Vse je mrtvo, vsem ljudem sem popil kri!\"    Odleti tretji in se dokaj hitro vrne, najbolj krvav in vpraša: \"Vidita tisti hrib tamle?\"    Druga dva: \"Vidima!\"    Tretji: \"Pa vidita tisto drevo na hribu?\"    Druga dva: \"Vidima.\"    Tretji: \"No, jaz ga pa nisem videl.\"", "Trije netopirji" },
                    { 506, true, 41, "Zajček se zadane in gre plavat v jezero. Mimo prideta medved in lisica, in rečeta zajčku, naj gre ven iz jezera, da se ne bo utopil. Zajček pa jima nazaj zabrusi: \"Izginite ve kopenske živali!\"", "Zajček" },
                    { 484, true, 41, "Stvari, ki bi se jih morali ljudje naučiti od psov:  - lojalnost,  - zaupanje,  - ljubezen.    Kaj smo se pa dejansko naučil?    Položaja...", "Kaj se lahko naučimo" },
                    { 1127, true, 41, "Pes najde prazno steklenico  jacka danielsa, povoha   in rece:  Cudno, disi kot gospodar,   ampak to vendarle ni on...", "Viski" },
                    { 1145, true, 41, "Zakaj krave ne tečejo hitro?    Da ne polijejo mleka.", "Krave in tek" },
                    { 1174, true, 41, "Kosir v gostilni po tretji rundi  zbada druscino:  Mi lahko kdo od vas pove, ali je na   Kitajskem ze srecal kakega potepuskega  psa? Pa se eden le ojunaci:  Povej mi, Kosir, ali si v Srbiji ze  kdaj videl potepuskega prasca?", "Kosir" },
                    { 1179, true, 41, "Skupina krav: creda.  Skupina volkov: trop.  Skupina ptic: jata.  Skupina zuzelk: roj.  Skupina oslov: drzavni zbor. ", "Skupine zivali" },
                    { 2098, true, 41, "Katera žival ne mara ute na vrtu?    Anti-lopa.", "Vrtna utica" },
                    { 2051, true, 41, "Dve miški se sprehajata in kar naenkrat se znajdeta pred debelim mačkom.    Ena od mišk besno zalaja, zato maček stisne rep med noge in pobegne.    Miška se obrne k svoji prijateljici in reče: \"Ali si videla, kako prav mi je prišlo znanje tujih jezikov?\"", "Miški na sprehodu" },
                    { 2046, true, 41, "Stari dami sta imeli papagaja, ki je zelo preklinjal.    Nekoč sta izvedeli, da ima tudi vaški župnik papigo, zato sta ga prosili, če lahko za nekaj dni prineseta svojega papagaja na prevzgojo. Župnikova papiga je namreč ves čas sedela v kotu kletke in tiho molila.    Župnik je pristal in tako sta dami prinesli grešnega papagaja in ga spustili v kletko k papigi.    Papagaj se je stresel, zamahnil s krili in zakričal: \"A je tu kakšna ptička za seks?\"    Papiga se je zbudila in veselo zažvižgala: \"O, moj Bog! Pa si le uslišal moje molitve!\"", "Problemi s papagajem" },
                    { 2041, true, 41, "Podjetni medved v gozdu odpre trgovino.    Pride zajec in vpraša, če prodaja jagode.    Medved pravi, da nimajo jagod.    Vendar se zajček ne da in pride v trgovino vsak dan z istim vprašanjem.    Po tednu dni medved ponori in reče: \"Zajec, če me še enkrat vprašaš, ali imam jagode, te bom z žeblji pribil na steno!\"    Pride zajček naslednji dan spet v trgovino in vpraša medveda: \"Hej, medo, imaš žeblje?\"    Medved: \"Nimam!\"    Zajec: \"Aha, ali imaš mogoče potem vsaj jagode?!?\"", "Medo odpre trgovino" },
                    { 2025, true, 41, "Dva polža se srečata in prvi reče drugemu: \"Zakaj pa imaš tako buško na glavi?\"    \"Veš, šel sem na sprehod po gozdu in kar naenkrat pred menoj zraste velik jurček in jaz tresssk!!!\"", "Nenadna prepreka" },
                    { 2023, true, 41, "Želva oropa polža.    Ta gre na policijo in jo prijavi.    Policist vpraša: \"Kaj pa se je zgodilo?\"    Polž odgovori: \"Ne vem točno, vse se je dogajalo tako hitro!\"", "Rop" },
                    { 2019, true, 41, "Netopirji visijo v votlini z glavami navzdol, le netopir Mirko čepi na skalnem robu.    Pa vpraša eden od netopirjev svojega soseda: \"Kaj pa je z Mirkom?\"    \"Ah, nič. Z jogo se je začel ukvarjati!\"", "Trop netopirjev" },
                    { 2012, true, 41, "Polž zasopihan prileze iz gozda in sreča lisico.    Ta ga začudeno vpraša: \"Kaj je, polžek, zakaj tako hitiš?\"    Ta odgovori: \"Ne sprašuj, prišla je davčna inšpekcija.\"    \"Pa kaj?\"    \"No, saj veš, jaz imam hišo, moja žena ima hišo in tudi vsi moji otroci imajo hišo ... Lahko si predstavljaš, kaj to pomeni.\"    Lisica se zamisli in steče za njim.    Srečata štorkljo, ki presenečena vpraša lisico: \"Lisička, kam pa kam?\"    \"Ali nisi slišala? Po gozdu se sprehaja davčna inšpekcija!\"    \"In kaj zdaj?\"    \"No, jaz imam drago krzno, moj mož ima drago krzno in tudi otroci imajo drago krzno ... Lahko si predstavljaš, kaj to pomeni!\"    Štorklja se zamisli, se nasmehne in reče: \"Ah, mi, razen tega ubogega gnezda, nimamo nič. In še to je umazano, grdo in poceni. Praktično brez vrednosti.\"    Polž jo pogleda in reče: \"Hja, štorklja! Pol leta doma, pol leta v tujini ... Od kod pa to???\"", "Za vsakega se kaj najde" },
                    { 1962, true, 41, "Mestna miška na cesti sreča poljsko miško.    Začneta se pogovarjati in mestna miška se pohvali: \"Strašno dobrega tipa sem spoznala. Zaljubljena sem do ušes.\"    \"Imaš kakšno njegovo sliko?\" vpraša poljska miška.    Mestna miška iz torbice potegne fotografijo in jo pokaže.    \"Saj to je netopir!\" vzklikne poljska miška.    \"Oh, on mi je pa rekel, da je pilot!\"", "Mestna in poljska miška" },
                    { 1938, true, 41, "Medvedka se s svojim mladičem odpravi na zimsko spanje.    Medvedek se kmalu zbudi in vpraša mamo medvedko: \"Mami ali sem res medvedek?\"    Medvedka mu odgovori: \"Seveda si. Pojdi spat.\"    Čez eno uro medvedek ponovi vprašanje, medvedka pa mu isto odgovori.    Potem pa medvedek še enkrat vpraša: \"Mami ali sem res medvedek?\"    Medvedka se razjezi: \"Pa zakaj te to tako zelo zanima!?\"    Medvedek odgovori: \"Če me pa zebe kot psa!\"", "Zimsko spanje" },
                    { 1873, true, 41, "Dve miški se priglodata do videoteke in prva začne glodati filmski trak.    Druga miška pravi: \"Kakšen se ti zdi film?\"    Prva odgovori: \"Ti a veš, da je knjiga boljša\"", "Dve miški iščeta hrano" },
                    { 1796, true, 41, "Na policiji zvoni telefon:  Pomagajte, macka mi je usla v hiso!  Ampak, gospa, za to se ni treba   toliko razburjati.  Kaksna gospa, jaz sem papiga.", "Papiga" },
                    { 1657, true, 41, "Nekega dne je na naše dvorišče prišel vidno utrujen kuža. Po ovratnici in po tem, da je bil urejen in dobro hranjen sem sklepal, da ima dom in da dobro skrbijo zanj.  Mirno in ljubeznivo je prišel do mene, pobožal sem ga po glavi, potem pa je kar šel za mano v hišo, v kotu pa se je zvil v klobčič in trdno zaspal.    Pustil sem ga tam. Uro kasneje je prišel do vrat, spustil sem ga ven in je veselo odšel.    Naslednji dan je ponovno prišel, me pozdravil, šel v hišo na svoje mesto in ponovno odspal okoli uro in pol. To se je ponavljalo kar nekaj časa potem pa sem postal radoveden, za ovratnico sem mu zataknil listič: \"Prosim, da mi sporočite, kdo je lastnik tega čudovitega psa. Ali veste, da prihaja vsako popoldne k meni v hišo, kjer odspi kako urico?\"  Naslednji dan je pes ponovno prišel, za ovratnico pa je imel nov listek: \"Oprostite za nadlegovanje. Očitno ste dober človek. Naš kuže živi v družini s tremi otroki, od tega sta dva mlajša od treh let, zato poišče miren kotiček, da se naspi.  Če vam ne bi bilo odveč - bi smel jutri priti z njim????\"", "Čudna situacija" },
                    { 1617, true, 41, "Mačka vstopi v gostilno in se ustavi pri točilnem pultu.    \"Kozarec mleka kot običajno?\" vpraša natakar.    \"Ne, danes bi pa kar žganje!\" reče mačka.    \"Žganje?\" je presenečen natakar.    \"Ja, enkrat bi se zjutraj rada zbudila z mačkom.\" ", "Mačka v gostilni" },
                    { 377, true, 43, "Kateri je najnevarnejši šport?  odg: šah  kakšna je najhujša poškodba pri njem??  odg: izpah čelusti zaradi zehanja.", "Nevaren šport" },
                    { 1612, true, 41, "Dva goloba na veji.    Eden reče: “Mater, to je moč! Narediš se mrtvega, pa se pol mesta userje od strahu!” ", "Ptičja gripa" },
                    { 1589, true, 41, "Kako je ime medvedu, ki trenira Kung fu?    Griz Li", "Medved in borilne veščine" },
                    { 1588, true, 41, "Petelin je letel za dvema kurama.    Prva: \"Jaz ne morem več, jaz bom počakala, pa naj me nategne!\"    Druga: \"Jaz bom pa letela še en krog, da ne bojo rekli, da sem kurba.\"", "Petelin lovi kure" },
                    { 1587, true, 41, "Petelin se je odločil, da bo dal nekaj pod jajca.    Leti za kuro, a ona beži pred njim in razmišlja:  - če mu takoj dam bodo rekli, da rada dam,  - če mu utečem ne bom dobila,  - najbolje bo, da se spotaknem.", "Petelin bi seksal" },
                    { 1586, true, 41, "Gredo dve kači po gozdu.    Prva: \"A sva me dve strupeni kači?\"    Druga: \"Ne, zakaj?\"    Prva: \"Uuuu, kaka sreča! Ugriznila sem se v jezik.\"", "Kači v gozdu" },
                    { 1507, true, 41, "Srečali so se  medved, lisica in osel.    Skovali so načrt, da si začnejo graditi skupni domek, za katerega potrebujejo, gradbeno dovoljenje.    Najprej se na Upravno enoto odpravi medved in zaprosi za gradbeno dovoljenje.  Upravni možje mu zavrnejo vlogo za gradnjo.    Nato sta medved in osel poslala v akcijo na Upravno enoto lisico, katera bo sigurno uspela pridobiti dovoljenje s svojimi zvijačami.  Toda zaman, tudi njej ni uspelo prelisičiti upravne može.    Na koncu se odpravi še osel. Na upravni enoti se zadržki kar dolgo, zato sta bila medved in lisica prepričana, da ne bo nič uspel.    Po dolgem času se vrne osel, medved in lisica ga radovedno izprašujeta kaj je bilo in kakšen je odgovor.  Osel počasi odgovarja in na koncu pride k bistvu.  Prijatelja moja pridobil sem kar tri gradbena dovoljenja, zate medved - gradiš brlog, lisica gradiš svoj domek in jaz osel bom imel tudi svojo štalco.    Medved in lisica ga začudeno vprašata, \"Kako ti je pa to uspelo?\"    Ja prijatelja moja, na Upravni enoti sem srečal vse svoje sošolce!", "Pridobivanje gradbenega dovoljenja" },
                    { 1497, true, 41, "Kaj je najslabša stvar ki se lahko zgodi spečemu netopirju?    Driska!", "Najslabša stvar" },
                    { 1496, true, 41, "Se sprehaja želva po cesti in jo oropa pet polžev.    Pride policija in vpraša želvo, kaj se je zgodilo.    Želva: \"Joj, kaj pa vem ... Vse se je dogajalo tako hitro\"", "Predrzen rop sredi belega dneva" },
                    { 1495, true, 41, "Kaj je mučenje živali?    Če daš kači viagro.", "Mučenje živali" },
                    { 1487, true, 41, "Išče zajec nekoga k bi kadil travo z njim. Išče išče pa ne najde.    Potem pa najde kuro, ki je privolila. Zvija, zvija prižge in pravi: \"Kura čutiš kaj, stara?\"    Kura pravi: \"Nič.\"    Zajec še enkrat potegne: \"Kura čutiš zdej kej?\"    Kura: \"Nič\"    Zajec še enkrat potegne. Že ves zelen v faco se mu že zelo vrti: \"Kura čutiš zdej kej?\"    Kura: \"Nič! Niti kljuna niti nog niti kril, nič\"", "Zajec in konoplja" },
                    { 1445, true, 41, "Se srecata siva in bela mis.  Bela mis pravi sivi: Ti si pa najrevnejsa cerkvena mis, te je zjebala mariborska nadskofija.  Siva: Ti si pa gotovo iz laboratorija.   Bela: Ne, ne, jaz sem v bistvu polarni medved, ki je prezivel Janseve reforme.", "Cerkvene misi" },
                    { 1413, true, 41, "Imam res cudovitega psa! se  hvali Ivan prijatelju.  Vsak dan mi v posteljo prinese  casopis!  To pa res ni nic takega! rece  prijatelj.  Kako da ne? Saj sploh nisem  narocen na casopis!", "Cudovit pes" },
                    { 1328, true, 41, "Kako se parijo polži?    S kropom. ", "Polži" },
                    { 1222, true, 41, "Zajcek gre zvecer pijan z zurke.  Omaga pod drevesom in zaspi.  Mimo prideta medved in volk.   Stepeta se, kdo bo pozrl zajcka,   in v pretepu oba oblezita v nezavesti.   Ko se dolgouhec prebudi, ju zagleda  in sam pri sebi zakolne:  Porka madona, ne smem vec piti.  Kadar sem pijan, res nimam prave mere,   poglej, kako hudo sem ju premlatil!", "Zajcek" },
                    { 1193, true, 41, "Se dva crva pogovarjata.  Pa pravi prvi: Zakaj si pa ti tako dobre volje danes?  Drugi mu odgovori: Tasca je sla na ribolov. ", "Pogovor dveh crvov" },
                    { 1590, true, 41, "Mravlje so igrale nogomet proti slonom.    Po končani tekmi mravlje pridejo do slonov in rečejo: \"Oprostite, če smo malo grobo igrale.\"", "Nogometno prvenstvo" },
                    { 859, true, 43, "Pride delavec k sefu in mu pravi: Morali mi  boste dvigniti placo. Veliko podjetij se zanima za mene!  Sef: A res? Katera pa?  Delavec: Elektro, Plinarna, Vodovod, Snaga... Se najbolj pa Nova KBM.", "Dvig place" },
                    { 381, true, 43, "Upokojenca, 70 let. Ona ga pošlje v trgovino:  »Kupi kilo moke in kilo sladkorja.«  Čez eno uro se mož vrne s kilogramom pralnega praška. Ona ga nadere: »Bedak!  Naročila sem ti dve stvari! Kje imaš pa mleko?«", "Pozabljivost" },
                    { 383, true, 43, "Iznajditelj: »Ali ste testirali mojo mišelovko?«  »Smo.«  Iznajditelj: »Torej jo boste patentirali?«  »O tem še razpravljamo. Danes zjutraj smo namreč pred mišelovko našli tri miške, ki so umrle od smeha, ko so jo videle.«", "Mišelovka" },
                    { 669, true, 43, "Pride nekega dne ženska v lekarno pa reče lekarnarju: \"Jaz bi, prosim, kupila dozo arzena!\"    Pa pravi on: \"Gospa, arzen je hud strup. Kaj pa bi vi radi naredili z njim?\"    Ona: \"Ubila bom moža!\"    Lekarnar: \"Gospa, jaz vam arzena ne morem prodati, sploh pa ne za taksen namen!\"    Pa ona brez besed iz torbice potegne sliko in jo prisloni na steklo, ki loči lekarnarja in njo. Na sliki sta njen mož in lekarnarjeva žena v postelji.    Pa pravi on:\" Joj gospa, se opravičujem. Nisem vedel, da imate recept!\"", "V lekarni" },
                    { 668, true, 43, "Advokat daje navodila svojemu klientu tik pred obravnavo: \"Nekaj si morate dobro zapomniti.\"    Klient: \"Poslušam.\"    Odvetnik: \"Ko boste pred sodnikom na vsako vprašanje odgovarjajte na dolgo in široko.\"    \"Zakaj pa?\"    \"Dlje kot boste odgovarjali, dlje boste na svobodi.\"", "Posvet pred obravnavo" },
                    { 667, true, 43, "Je vprašal zvonček marjetico: \"Marjetica, a bi mi dala?\"    Marjetica: \"Ne morem, imam fotosintezo.\"", "Zvonček in marjetica" },
                    { 663, true, 43, "Janez se odloči prebeliti stanovanje.    Spomni se, da je Miha, ki stanuje nad njim v enakem stanovanju, stanovanje prebelil lani, in ga vpraša: \"Miha, koliko barve si kupil?\"    \"50 kil.\"    Janez kupi 50 kg barve in prepleska stanovanje. Ko konča, pravi Mihi: \"Miha, kako si pa ti pleskal, meni je ostalo 35 kil barve!\"    Miha: \"Meni tudi.\"", "Pleskanje stanovanja" },
                    { 662, true, 43, "Tomaž slastno zagrize v klobaso in mast brizgne Petru po srajci.    \"Pacek!\" mu zabrusi Peter.    \"Jaz? Sebe poglej!\"", "Mastna klobasa" },
                    { 656, true, 43, "Sosedi se pogovarjata.    \"Kmalu bomo stanovali v lepšem okolju!\" se je pohvalila prva.    \"In mi v mirnejšem okolju!\" je rekla druga.    \"Ah, torej se boste tudi vi preselili?\"     \"Ne, mi ostanemo tukaj!\"", "Selitev" },
                    { 642, true, 43, "\"O, mlada gospodična. Vedno kadar vas vidim kako se smejite, vas želim povabiti k sebi.\"     Gospodična: \"Ste samski?\"     On: \"Ne, zobozdravnik sem.\"", "Vabi jo" },
                    { 639, true, 43, "PRIZGEM TV- begunci  Prizgem radio- Sami begunci  Odprem fb- Spet begunci  Zdaj si pa ne upam pira odpret.", "begunci" },
                    { 637, true, 43, "V planinski koci je guzva,planinci   spijo natlaceni na pogradih.  Sredi noci zacne 80 letni  planinec kricat: Babo!  Hitro mi pripeljite babo!  Takoj hocem babo!!!  Oglasi se mladenic zraven njega:  Oca, lazen alarm....  Mojega drzite.", "hribovski" },
                    { 636, true, 43, "Ko te obišče ljubimec, to ve naenkrat ves blok.    Ko ti pa vlomijo, pa ni nihče ničesar videl ali slišal.", "A ni to čudno?" },
                    { 629, true, 43, "Sodnik obtoženemu: \"Zakaj ste oropali banko?\"    Obtoženi: \"Ona je prva začela!\"", "Rop" },
                    { 618, true, 43, "Je šla lepinja čez cesto in vidi na drugi strani pico.    Se ustavi in reče: \"Poglej jo, kurbo, kako je namazana!\"", "Lepinja sreča pico" },
                    { 614, true, 43, "Tank zajebava fičota in mu reče: \"Ti imaš pa motor v riti.\"    Fičo pa mu odvrne: \"Ti imaš pa kurca na glavi.\"", "Tank in fičo" },
                    { 612, true, 43, "Homoseksualec je prišel na bencinsko črpalko ter si cev porinil v zadnjico.    Črpalkar je to videl in zavpil: \"Kaj delaš? To je dizel!\"    \"Nič hudega! Meni se zdi SUPER!\" ", "Dizel" },
                    { 609, true, 43, "Vprašanje davčnemu inšpektorju:   Soseda me je sinoči zadovoljila. Ali sem jo dolžan prijaviti?     Težko vprašanje.     Če te je zadovoljila vaginalno in ni izstavila računa, potem je odgovor da.   Če te je oralno, potem ji moraš ti izstaviti račun za malico in prijaviti samega sebe, ker tega očitno še nisi storil.   Če ti ga je na roke, potem bosta zaradi razsipništva in neodgovornega odnosa do bodočih davkoplačevalcev kaznovana oba.   Če pa si jo analno pa nikome ništa, ker smo tako in tako vsi v riti.", "Lepo je biti sosed" },
                    { 608, true, 43, "Se pelje avtobus z prizadetimi otroci, nakar se ta avtobus sredi gozda pokvari. Šofer seveda stopi ven in začne nekaj brskati po motorju. Čez nekaj čas pride iz avtobusa Gregor   Gregor: jAZ pa veeeeeem kUaaaa SSee je pOOkvarLLL.   Šofer: no Gregor pojdi noter bom že popravil zadevo   Čez petnajst minut pride Gregor zopet ven   Gregor: jAZ pa veeeeeem kUaaaa SSee je pOOkvarLLL.   Šofer: Gregor ne skrbi vsak čas bom popravil ti kar pojdi nazaj notr.   Čez petnajst minut pride Gregor ven še bol glasen kot prej.   Gregor: jAZ pa veeeeeem kUaaaa SSee je pOOkvarLLL.   Šofer ga ima dosti in reče   Šofer: no pa povej kaj se je pokvarilo   Gregor: AAAAAvtooobUUUs!!!", "Pokvarjen avtobus" },
                    { 602, true, 43, "V banko uleti tip z nogavico na glavi. Jasno, oropal bi jo rad.   Dekletu zagrozi s pištolo:   \"Odpri sef!\"   \"Napako delate!\" se upira ona.   \"Nič te nisem vprašal! Odpri!\"   Končno se ona loti sefa.   \"Ampak res ste se zmotili.\"   \"A si slišala, kaj sem rekel? Odpri sef in bodi tiho!\"   Končno deklina odpre sef - semenske banke.   \"Vidiš tisto največjo flaško tam?\"   \"Aha ...\"   \"Vzemi jo in jo popij!\"   Bejba gleda in nič ji ni jasno, a iz strahu vseeno zeksa tisto flašo sperme.   Tedaj strašni ropar sname masko:   \"No, vidiš, Majči, da lahko! Samo nočeš .........\" ", "To je rop" },
                    { 597, true, 43, "Kaj je modro in je v kotu? Poredna sliva!", "V kotu" },
                    { 593, true, 43, "Ostareli kmet, ki je ostal sam na kmetiji, piše sinu v zapor: \"Dragi Matevž, tako žalosten sem, ker letos ne bom mogel posaditi krompirja. Moral bi prekopati njivo, pa me preveč boli hrbtenica.\" Sin odpiše: \"Oče, nikar ne koplji po njivi. Tam sem zakopal trupla.\" Naslednji dan na kmetijo pride 20 policistov, ki prekopljejo celo njivo. Oče pa dobi od sina pismo: \"Dragi oče, upam, da je njiva prekopana. To je bila edina pomoč, ki sem ti jo lahko ponudil v dani situaciji.\" ", "Kmet in njiva" },
                    { 589, true, 43, "Deset norcev se odloči pobegniti iz norišnice. Natanko sto zidov morajo preplezati, pa bodo prosti. In gredo na delo preplezajo prvega, pa drugega, tretjega ... in tako naprej vse do devetindevetdesetega. Potem ugotovijo, da so vsi že pošteno utrujeni, pa njihov kolovodja pripomni: \"Fantje, jaz sem utrujen gremo nazaj.\"", "Pobeg iz norišnice" },
                    { 584, true, 43, "\"Se spominjaš, ko sem ti prejšnji teden rekel, da bo šlo z Markotom strmo navzdol?\"    \"Ja, spomnim se, da si rekel nekaj podobnega.\"    \"In zdaj se je moja napoved uresničila.\"    \"Kaj se je pa zgodilo?\"    \"Padel je z jablane!\"  ", "Navzdol bo šlo" },
                    { 580, true, 43, "\"Danes sem imel nore sanje!\" reče Jure Petru. \"Imel sem 12. rojstni dan in mama mi je dala tisoč tolarjev ter me poslala v zabaviščni park.\"    \"Jaz pa sem sanjal še bolj noro\" reče Peter. \"Ponoči je k meni v posteljo prišla Madonna. Komaj se je stisnila k meni, je v sobo stopila še Sharon Stone. Sploh nisem vedel kaj naj storim.\"    \"Butec! Mene bi poklical na pomoč!\"    \"Saj sem te, pa je tvoja mama rekla, da si v zabaviščnem parku!\"", "Nore sanje" },
                    { 578, true, 43, "Jože in Franci sta odšla v ribjo restavracijo in naročila veliko ribo.    Ko jo je natakar postregel jo je Jože prerezal na večji in manjši kos in manjši kos postavil na Francijev krožnik večjega pa na svojega.    \"Zakaj si vzel večji kos?!\" je potarnal Franci.    Jože: \"Ja, če bi lahko izbiral, katerega bi pa ti vzel?\"    Franci: \"Manjšega!\"    Jože: \"No, saj si ga dobil.\"  ", "Delita si ribo" },
                    { 574, true, 43, "Milan je iz vasi prišel v mesto in obiskal prijatelja Lojzeta, ki je hudo poškodovan ležal v bolnišnici.    Kakšno uro se je zadržal pri njegovi postelji, ko pa je odhajal mu je rekel: \"Dobro se imej! Za tvoj pogreb pa ne skrbi, vsi bomo prišli!\"", "Obisk v bolnici" },
                    { 573, true, 43, "Strašna skleroza me muči. Včeraj sem šel v banjo kar oblečen.    \"To je bilo pa grozno, kajne?\"    \"Niti ne. Ampak, tudi pipo sem pozabil odpreti.\"", "Skleroza" },
                    { 572, true, 43, "Sosed zagleda Milana, ki proti svoji hiši nosi težko omaro na ramenih. Pristopi k njemu in ga vpraša: \"Ti lahko pomagam? Kaj res nisi uspel dobiti nikogar, da ti pomaga z omaro?\"    Milan: \"Saj mi pomaga Jure!\"    \"Ja, kje pa je?\"    Milan: \"V omari drži predmete, da se ne bi razbili\"  ", "Brez pomoči nosi omaro" },
                    { 571, true, 43, "\"Pred mesecem dni sem na sprejemu stavil da bom pojedel petdeset obloženih kruhkov.\"    \"In?\"    \"Stavo sem dobil!\"    \"Čestitam! Pa si imel kakšne posledice?\"    \"Seveda! Še danes jih imam!\"    \"Kakšne pa?\"    \"Od takrat naprej me nihče več ne povabi na zabavo!\"  ", "Stava" },
                    { 570, true, 43, "Prijatelja, homoseksualca, sta se sprehajala po gozdu. Naenkrat je eden rekel: \"Moram opraviti veliko potrebo!\" in zginil v grmovju.    Ko se je vrnil k prijatelju je ves zgrožen rekel: \"Rodil sem otroka!\"    \"Nemogoče! To biološko sploh ni mogoče!\"    \"Pa je res! Ima glavo, roke in noge, pa še premika se! Pojdi za grmovje in preveri!\"    Prijatelj je stopil za grmovje, se vrnil in nasmehnil: \"Si pa res norec! Otroka nisi rodil, ježa si pa posral!\"  ", "Rodil je otroka" },
                    { 569, true, 43, "\"Zdenko, kako se kaj počutiš zdaj, ko si se upokojil?\"    Zdenko: \"Kot pelinkovec: sladko-grenko.\"", "Upokojil se je" },
                    { 672, true, 43, "\"Mi posodiš 1000 Eurov?\"    \"Nimam toliko. Lahko ti posodim samo 300.\"    \"No, pa daj 300. 700 pa mi boš dolžan.\"", "Posoja denarja" },
                    { 568, true, 43, "Sosed, zdaj mi je pa že dovolj tega, kar počenjajo vaši otroci. Stalno navijajo glasbo tako, da sploh spati ne morem, včasih pa je slišati iz vašega stanovanja tak ropot, kot bi podirali stene! Če bi bili to moji otroci, bi že zdavnaj dobili krepke batine!    Sosed hladno odgovori: \"Prav imate, sosed! Če bi bili to vaši otroci, bi jih tudi jaz namlatil!\"", "Hrupni otroci" },
                    { 679, true, 43, "Steklenica: \"Jaz sem steklenica, kdor me razbije, bo imel eno leto nesrečo\"    Ogledalo: \"Jaz sem hujši, kdor razbije mene, bo imel sedem let nesreče!!!\"    Kondom: \"HA HA HA HA HA HA HA!!!!\"", "Nesreča" },
                    { 689, true, 43, "Pokojnine se bodo s 1. marcem dvignile za 3,6%.    Vlada sporoča,da denarja žal ne bo mogoče izplačati, lahko pa upokojenci koristijo ure.", "Višje pokojnine" },
                    { 854, true, 43, "Prišel je Rajko v bolnišnico. Pogovarja se z medicinsko sestro in preden ji pove za svoj problem, ji reče: \"Medicinske sestre se ne smete smejati pacientom, a ne?\"  \"Seveda ne. Ne bom se smejala, sem profesionalka. Že več kot 20 let sem medicinska sestra in se še nisem smejala pacientu.\"  \"Torej, v redu,\" reče Rajko, si sleče hlače in razkrije najmanjšo stvarco, kar jih je sestra kdajkoli videla. V dolžino in širino ni večji od majhne AAA baterije. Sestra ni mogla zdržati in se je začela režati, nato pa padla na tla od smeha.  Ko je čez nekaj časa prišla k sebi, se opraviči Rajkotu: \"Oprostite, zelo mi je žal, ne vem, kaj me je prijelo. Obljubim, da se to ne bo ponovilo.Povejte, kaj je vaš problem?\"  \"Zatekel mi je,\" je dejal Rajko.\"", "Rajko na pregledu " },
                    { 837, true, 43, "\"Kakšna je razlika med socializmom in kapitalizmom?\"  \"Ne vem.\"  \"V socializmu smo hodili po pralni prašek v tujino, v kapitalizmu pa na Rdeči križ.\"", "Socializem in kapitalizem " },
                    { 830, true, 43, "Vampir brska po kantah za smeti, ko mimo pride njegov prijatelj.  Kaj pa pocnes, kaj isces?  Stare tampone!  Zakaj pa?  Sin je prehlajen in bi mu rad skuhal caj.", "Vampir" },
                    { 827, true, 43, "Kaksna je razlika med dobrim sosedom in dobro sosedo?  Dober sosed ti posodi.  Dobra soseda pa ti da!", "Dober sosed" },
                    { 826, true, 43, "Polde se pred blokom pogovarja s sosedom Spahijo.  Ta v rokah drži jabolko in ne ve, kaj bi z njim.    Polde: \"A veš, kaj naredi moja žena, ko dobi jabolka?\"    Spahija: \"???\"    Polde: \"Jabolčno pito.\"    Spahija: \"A ti veš, kaj naredi moja žena, ko dobi slivo?\"    Polde skomigne z rameni.    Spahija: \"Vse, prijatelj, vse!\"", "Soseda se pogovarjata" },
                    { 823, true, 43, "Sodnik vprasa obdolzenca:  Kaj lahko poveste v  svoj zagovor?  Nisem kriv.  Tako vsi pravijo.  Ce vsi tako pravijo,potem  je jasno,da sem nedolzen,in me  zato izpustite.", "Nisem kriv" },
                    { 817, true, 43, "Kaj jedo ljudozerci, ki so vegetarijanci?  Sadjarje in vrtnarje!", "Ljudozerci vegetarianci" },
                    { 816, true, 43, "Moz je zadel na lotu.  Pride zena domov in pred vrati zagleda 2  kovcka.  Zena: A kam grema?  Moz: Ne, ti gres!", "Loto" },
                    { 797, true, 43, "Joze gre z prijatelico Tinko v kino,  pred vhodom si kupi  cokolado,med filmom jo odvije  in zacne grizljati.  A je dobra?ga vprasa Tinka.  Jozek:Odlicna.  Skoda,da si je nisi kupila se ti. ", "Kino" },
                    { 788, true, 43, "Oce se razjezi na sina, ko se sprehajata po mestu pa ga prijatelj vprasa zakaj se je razjezil. Oce odgovori:\"Prstek tu, prstek tam, potem pa doma noce jesti!\"", "Noce jesti" },
                    { 787, true, 43, "Gresta ata in sin ljudozerca po ulici in zagledata lepo zensko. Pa pravi ata sinu:\"Ta je pa lustna. Bi jo lahko pojedla!\"  Sin:\" Ne, ata, peljiva jo raje domov in pojejma mamo!\"", "Oce in sin ljudozerca" },
                    { 785, true, 43, "Gredo pred Boga Anglez, Francoz in Slovenec.   Prvi ga vprasa Francoz:\"Bog, kdaj no konec krize v Franciji?\"  Bog:\" Cez 100 let.\"  Francoz:\"Jaz tega ne bom docakal!\"  Drugi pred Boga stopi Anglez in vprasa:\"Kdaj bo konec krize v Angliji?\"  Bog:\"Cez 200 let.\"  Anglez:\"Jaz tega ne bom docakal.\"  Nazadnje stopi pred Boga se Slovenec in vprasa:\"Kdaj se bo koncala kriza v Sloveniii!\"  Bog:\"Jaz tega ne bom docakal!\"", "Kriza" },
                    { 784, true, 43, "Novinarka slovenskih novic  v bezigrajskem domu starejsih   sprasuje varovanca Korla:  Koliko pa jih stejete,gospod?  On:Ja,draga dama,ze 87 jihbo.  Ona;Nikoli vam nebi dala!  Korel:Saj tako ali tako   nebi mogel.", "Novinarka" },
                    { 777, true, 43, "Živel je moški, ki je zelo lepo skrbel za svojo postavo. Vsak dan je pretekel 10 km, potem je dvigal uteži, se razgibaval, šel v savno in se na koncu še malo posončil na plaži.    Nekega dne, ko se je spet vase - zagledano občudoval v ogledalu, je opazil, da je zelo lepo porjavel, vendar pa je njegov ponos bil povsem bel.    Zato je naslednji dan odšel na plažo, se zakopal v pesek in pustil samo svojega tiča zunaj, da se je ta nastavljal soncu in rjavel.    Čez nekaj časa sta prišli mimo dve zelo stari gospe. Ugledata čudno stvar,ki se je vzpenjala iz mivke in je ena otožno zavzdihnila:  Ko sem bila 20, sem bila radovedna glede tega.  Ko sem bila 30, sem uživala v tem.  Ko sem bila 40, sem spraševala za to.  Ko sem bila 50, sem plačevala za to.  Ko sem bila 60, sem molila za to.  Ko sem bila 70, sem pozabila na to.  In sedaj, ko sem 80, te preklete stvari divje rastejo naokoli kot plevel, jaz pa še počepnit ne morem, da bi ga pobrala!\"", "Porjavelost" },
                    { 774, true, 43, "Na nebeška vrata je potrkalo. Sv. Peter jih je odpel in pred vrati je stal bled moški.    \"Dober dan!\" je rekel. \"Jaz sem To...\" in že je izginil.    Sveti Peter se je začudil in zaprl vrata, toda nekaj sekund kasneje se je ponovilo isto.    \"Dober dan!\" Jaz sem To...\" in človek je izginil.    Sveti Peter se je pritožil Bogu, da se nekdo norčuje iz njega.    \"Ne, ne!\" je dejal Bog. \"Tega moškega poznam! Ime mu je Tomaž in v bolnici ga ravnokar oživljajo!\"", "Bled človek" },
                    { 773, true, 43, "\"Kako pa to, da imaš toliko modric po obrazu?\"    \"Pred dvema meseci sem imel prometno nesrečo.\"    \"Da se modrice tako dolgo poznajo, je pa le malo čudno, se ti ne zdi?\"    \"Pešec, ki sem ga podrl se je šele včeraj vrnil iz bolnišnice.\"", "Sveže modrice" },
                    { 772, true, 43, "\"Moj oče je numizmatik!\"    \"Kaj pa je to?    \"To je tisti, ki zbira kovance.\"    \"Včasih takim rekli klošarji!\"", "Numizmatika" },
                    { 758, true, 43, "Ali še hodiš z onim matematikom?    Ne, varal ma je!    Kako to?    Zadnjič sem ga, en večer, klicala.  Vprašala sem ga, kaj počne in je odvrnil, da se v postelji jebe z eno neznanko.  ", "Matematik" },
                    { 756, true, 43, "Ucitelj vprasa Janezeka:    Povej mi,kje zivijo velike ribe?    V vikendih na morju.", "Velike ribe" },
                    { 755, true, 43, "Dragi,ali ves,da so ovce    bolj neumne kot krave?    Vem,jagnje moje...", "Jagnje moje" },
                    { 754, true, 43, "Zakaj iz potapljajoče ladje najprej rešijo ženske?    Da lahko moški potem v miru pridejo do rešitve", "Brodolom" },
                    { 751, true, 43, "Upokojenci se ukvarjajo samo še s premičninami in nepremičninami.    Premičnine: proteza  Nepremičnenine: luleki", "Penzionisti" },
                    { 749, true, 43, "Kaj pomeni ekstremna suša?   Ko telegrafnica leti za psom, da bi jo poscal!", "Suša" },
                    { 730, true, 43, "Gresta 2 kolega po gozdu pa reče en drugemu: Glej, dreva! Pa reče dreva: Ja in? Glej tam je goba.", "Dreva" },
                    { 729, true, 43, "Gresta 2 kolega po gozdu pa reče en drugemu: Glej, goba! Pa reče goba: Ja in?", "Goba" },
                    { 702, true, 43, "Znani obrtnik se hvali  znani druzbi:  Ko sem sel na svoje,  nisem imel drugega kot  svojo pamet.  Pa se eden oglasi.  In s tako majhnim kapitaloom  ste prisli tako dalec.  Neverjetno.", "KAPITAL" },
                    { 700, true, 43, "Moz mi je za rojstni dan  kupil komplet AMC.    Posode?  Ne,ajmar,metlo in cunjo", "AMC" },
                    { 699, true, 43, "80-letna Francka povabi svoji vrstnici na kavico. Da ne bo kaj pozabila, si pripravi listek ter si ga obesi v kuhinji:  1. SKUHAJ KAVO  2. POSTREZI PIŠKOTE  3. POSTREZI SADJE    Prijateljici prideta, Francka gre v kuhinjo in hitro preveri listek:  1. SKUHAJ KAVO -- in skuha kavo in jo postreže prijatejicima.   Kasneje se vrne v kuhinjo in ponovno preveri listek:  1. SKUHAJ KAVO -- in skuha kavo in jo postreže prijatejicima.   In tako še enkrat.    Ženičke se poslovijo in odpravijo domov. Pa komentirata obisk pred vrati in pravi prva:  - ti, ampak Francka bi nama pa lahko vsaj kavo skuhala!    Druga pa: Katera Francka ?!?!", "Spomin" },
                    { 691, true, 43, "Na oglas iz cirkusa \"Iščemo krotilca levov\" sta se javila dva.    Eden je bil šestdesetletni igralec golfa, druga pa fantastična rjavolaska, dvajsetletna, s izjemno postavo.    Lastnik cirkusa je takoj povedal: \"Ne bom olepševal, lev je zelo nevaren, poslednjega krotilca je pojedel, zato bodita dobra - ali pa bosta zgodovina. Tu imata opremo - stol, bič in pištolo. Kdo bo prvi poskusil?\"    Čudovita rjavolaska je takoj rekla: \"Bom jaz prva.\"    Stopila je kar mimo stola, biča in pištole naravnost v kletko.    Lev je začel renčati, tolči z repom in jo izzivati.    Ko se je približal je čudovita rjavolaska odgrnila svoj plašč in razkrila prekrasno, popolno, golo telo.    Lev se je sunkovito ustavil, nakar pa se splazil do nje in ji začel lizati noge in gležnje. Nadaljeval je z lizanjem in poljubovanjem vsakega centimetra njene kože, potem pa legel pred njo in ji položil glavo na noge.    Lastnik cirkusa ni mogel niti zapreti ust. Rekel je: \"Pa to je izjemno. Še nikoli nisem videl nič podobnega v življenju.\"    Potem se je obrnil k golfistu in vprašal: \"Lahko vi napravite kaj podobnega?\"    Stari možakar je odgovoril:\"Možno... samo najprej boste morali spraviti leva ven.\"", "Krotilca levov" },
                    { 680, true, 43, "Sin: \"Ati, kaj je to teorija in kaj praksa?\"    Oče: \"Uuu, velika razlika! Idi vprašat sestro, če bi šla seksat za 2000 evrov.\"    Sin odide in pride nazaj: \"Rekla je, da bi.\"    Oče: \"No, zdaj pa idi vprašat enako še mamo.\"    Sin odide in se čez nekaj trenutkov vrne, rekoč: \"Tudi mama je rekla da!\"    Iz sobe zavrešči še stara mama: \"Hja, za dva jurja bi pa še jaz lulo dala!\"    Oče: \"Vidiš, teoretično imava midva šest jurjev v žepu. Praktično pa tri kurbe v hiši.\"", "Teorija in praksa" },
                    { 567, true, 43, "Očka, ali imajo davki res usta in zobe?  \"Kje si pa slišal takšno neumnost?\"  \"V trgovini je neki gospod rekel, da mu davki požrejo ves dobiček.\"", "Davek" },
                    { 559, true, 43, "Prijatelj prijatelju za šankom: \"Ti praviš, da si moj prijatelj, pa me nikoli ne vprašaš, kako mi gre!\"    \"No, kako ti gre?\"    \"Ah, ne sprašuj!\"", "Kako mu gre" },
                    { 558, true, 43, "\"Kaj bi naredil, če bi v hlačnem žepu našel 100€ ?\"    \"Vprašal bi se, čigave so hlače!\"  ", "Hlače" },
                    { 448, true, 43, "Moški pomoli glavo v frizerski salon: \"Koliko časa bi moral čakati na striženje?\"    Frizer se ozre po čakajočih v lokalu: \"Dobri dve uri.\"    Moški zapre vrata in ga tisti dan ni bili več nazaj.     Čez nekaj dni se zopet pojavi in kar na vratih vpraša: \"Čez koliko časa bom prišel na vrsto?\"    Brivec zopet pogleda po polnem lokalu in pravi: \"Ne prej kot čez tri ure.\"    Moški odide.    Čez teden dni pride spet: \"Kdaj bi lahko prišel na vrsto?\"    Frizer mu odgovori: \"Čez pol ure.\"    Možakar odide, brivec pa pravi svojemu vajencu: \"Joško, steci za njim in poglej, kam ta tip gre, ko zapre vrata lokala!\"    Vajenec se hitro vrne in komaj zadržuje smeh.    \"No, hudiča, ali si ugotovil, kam gre ta tip od tu!\"    \"K vam domov, šef!\"", "Pri frizerju" },
                    { 445, true, 43, "\"Dame imajo prednost\" je samo lepše rečeno :\"Pejt naprej, da te lahko v rit pogledam!\"", "Dame imjo prednost" },
                    { 442, true, 43, "Brezalkoholno pivo je kot seks s sestrično: občutek je isti, ampak veš da nekaj ni v redu.", "Brezalkoholno pivo" },
                    { 440, true, 43, "Kakšna je razlika med dobrimi in slabimi joški?    Med dobrimi je verižica, med slabimi pa popek!", "Joški" },
                    { 439, true, 43, "Ko umreš ti, ne veš da si mrtev in ti ni hudo.  Hudo je drugim.      Enako velja, če si neumen!", "Če si mrtev" },
                    { 435, true, 43, "Kaj naredi Damjan Murko ko hoče biti sam?      Koncert!", "Damjan Murko in samota" },
                    { 434, true, 43, "Novo leto je super!    Natančno ugotoviš kdo te ima shranjenega v imeniku, in kdo ne.", "Novo leto" },
                    { 433, true, 43, "Greš na Zavod za zaposlovanje pa na vratih piše \"Vstop nezaposlenim prepovedan!\"", "Ironija" },
                    { 432, true, 43, "Moj penis je bil v Giunessovi knjigi rekordov!    Potem pa so me vrgli ven iz knjižnice!", "Penis v Giunessovi knjigi rekordov" },
                    { 430, true, 43, "Pridem prej v trgovino, prodajalki rečem da bi imel 20 kondomov.    Opazim 2 bejbi da se mi začneta smejat.    Začudeno jo pogledam, nato rečem prodajalki: \"22, prosim\".", "Kupovanje kondomov" },
                    { 429, true, 43, "Zakaj je kalkulator človekov najboljši prijatelj?    Nanj lahko vedno računaš.", "Kalkulator" },
                    { 428, true, 43, "Punca brez oblin je kot jakna brez žepov - ne veš kam bi roke dal.", "Punca brez oblin" },
                    { 427, true, 43, "Vsi smo že slišali za srečo v nesreči.    Ne vemo pa kaj je nesreča v sreči.    Ko dobiš službo po letu dni pisanja prošenj, pa ti prvi dan novi sodelavci povejo,da že pol leta niso dobili plače.", "Nesreča v sreči" },
                    { 426, true, 43, "Kako pa facebook šteka danes...    5 krat sem že kliknil \"DOMOV\" pa sem še kar v gostilni.", "Facebook v gostilni" },
                    { 423, true, 43, "Se srečata dve spodnjici v pralnem stroju.    Reče prva: \"A's bla na dopustu?\"    Druga: \"Zakaj?\"    Prva: \"K's tko rjava!\"", "Spodnjice v pralnem stroju" },
                    { 421, true, 43, "Fant se sprehaja s punco po parku.    Nenadoma ji reče: \"Stopiva sem za grm, da ti nekaj pokažem.\"    Fant si odpne zadrgo in ji da roko v hlače in na tisto stvar. Dekle se ustraši! Obrne se in steče skozi grmovje.    Veje jo tolčejo po objokanih licih, oblekica se ji zatika v veje in se trga, visoke petke na čevljih se polomijo, toda ona teče dalje, ne ozirajoč se. Skozi glavo ji letijo misli: \"Ah... pa so me starši lepo opozarjali naj se pazim manijakov, le da jih jaz nisem poslušala. Samo da pridem domov...\"    Medtem priteče do stanovanjskega bloka,  vzame ključ in naenkrat začuti roko na ramenu.    Z grozo se obrne, ko zasliši zadihan glas, ki ji pravi: \"Prosim te, sam spust ga...\"", "Punco nagovori manijak" },
                    { 414, true, 43, "Je šel Bill Gates prvič, s svojo bodočo ženo, v posteljo.    Ko sta končala, mu bodoča žena reče: \"Sedaj pa vem, zakaj se tvoje podjetje imenuje Microsoft.\"", "Bill Gates v postelji" },
                    { 413, true, 43, "\"No, Nežka, kaj ti je povedala jasnovidka, ki si jo prejšnji teden obiskala?\"    Nežka: \"Sploh nisem vstopila v njeno stanovanje! Ko sem potrkala na vrata je vprašala: \"Kdo je?\", jaz pa sem se takoj obrnila in odšla domov.\"", "Pri jasnovidki" },
                    { 412, true, 43, "\"Koliko pa spiš vsak dan?\"    \"Tri do štiri ure.\"    \"To pa še zdaleč ni dovolj!\"    \"Seveda ne! Zato pa spim še, najmanj, 8 ur ponoči.\"", "Dovolj spanca" },
                    { 411, true, 43, "Miha in Štefan sedita v restavraciji.    \"Kaj bo šele poleti.....?\" vpraša Miha.    \"Poleti bo politično mrtvilo\" reče Štefan.    \"Ne, mislim kaj bo šele poleti....\"    \"Na morje bomo šli.\" ga spet prehiti Štefan.    \"Ali bi me že prenehal prekinjati!? Hotel sem te vprašati kaj bo šele poleti, če ti že zdaj noge tako smrdijo!\"", "Pogovor v restavraciji" },
                    { 410, true, 43, "Prijatelj prijatelju: \"Ali znaš plavati?\"    \"Znam!\"    \"Kje si se pa naučil?\"    \"V vodi!\"", "Plavanje" },
                    { 409, true, 43, "\"Lojze, zakaj pa počivaš ob vsakem drevesu?\"    \"Ah, mislil sem, da imam psa s seboj!\"", "Počiva" },
                    { 408, true, 43, "Ali mi lahko daš eno cigareto?    \"Ali nisi rekel, da boš nehal kaditi zdaj, ko so cigareti tako dragi?\"  \"Saj sem že v prvi fazi odvajanja.\"  \"Kaj pa to pomeni?\"  \"Da jih nič več ne kupujem.\"", "Nehal bo kaditi" },
                    { 397, true, 43, "Musliman se usede v taksi.   Prosi taksista, da ugasne radio, ker tako pravi Koran.   Ne sme poslušati muzike, ker za časa življenja preroka Mohameda ni bilo muzike, sploh pa ne zahodne muzike, ki je muzika nevernikov.   Taksist takoj ugasne radio, zaustavi taksi in odpre vrata.   Musli se začudi: \"In kaj to počnete?\"   \"Za časa življenja preroka Mohameda ni bilo taksijev, zato odjebi in čakaj kamelo!\"", "Musliman v taksiju" },
                    { 392, true, 43, "\"Mar misliš da so na Luni živa bitja podobna ljudem?\"    \"Seveda, saj vidiš da imajo vsako noč prižgane luči.\"", "Življenje na luni" },
                    { 390, true, 43, "\"Si bil včeraj ti ob 15. uri na vogalu Dunajske in Linhartove?\"    \"Ne.\"    \"Aha, potem sem videl pa kanto za smeti.\"", "Kje si bil?" },
                    { 389, true, 43, "Katere igre se najraje igrajo migranti?  Igre brez meja ! ", "Igre" },
                    { 388, true, 43, "V hotelu:  “Imate morda kakšno prazno sobo?”  “Žal je vse zasedeno.”  “Kaj pa, če bi prišla angleška kraljica?”  “No, potem bi se že kaj našlo.”  “Dajte mi torej to, kar bi se že našlo, kraljice zagotovo ne bo.”", "Prosta soba" },
                    { 385, true, 43, "Trije prijatelji se odpravijo kampirat. Prvi pravi:  “Jaz bom vzel s sabo karte, bomo kakšen tarok vrgli…”  Drugi reče:  “Jaz bom vzel s sabo šah, da vidim, če sta kaj dobra…” Tretji pa reče:  “Super, jaz bom pa vzel s sabo tampone.”  “Tampone???” se začudita oba prijatelja.  Tretji pa jima obrazloži:  “Ja ful so dobri, na škatlici piše da lahko z njimi jezdiš, igraš tenis, voziš kolo…”", "Tamponi" },
                    { 454, true, 43, "Kaj moraš vzeti s sabo v puščavo?    Jabolko in vato.    Zakaj?    V puščavi te prične loviti lev. Vržeš jabolko v zrak in ker jabolko ne pade daleč od drevesa, splezaš na drevo. Ko si na drevesu, začneš drobiti vato na tla. Lev misli, da sneži, zato zmrzne. Ko vidiš, da je lev zamrznjen, se ti odvali kamen od srca in pade levu na glavo, da se mu pokažejo vse zvezde.    Nato poiščeš severnico in greš domov.", "Rešite se iz puščave" },
                    { 456, true, 43, "Gleda Rus v Moskvi poročila na TV, kjer poročajo, da je v Sibiriji - 55°C.    Seveda ne verjame in pokliče po telefonu sorodnika: \"Daj povej koliko je stopinj pri vas?\"  \"Čaki, da pogledam. . . - 35°C, zakaj vprašaš?\"    Rus: \"Pa teleta na TV nakladajo - 55°C!\"    \"A, to pa lahko - zunaj.\"", "Mraz v Sibiriji" },
                    { 463, true, 43, "Janez si v nesreči odreže desno roko. Na urgenci mu rečejo, da njegova ne bo več uporabna, lahko mu pa prišijejo eno žensko roko.    \"Lahko\" se hitro odloči Janez. Bolje ženska, kot brez. Čez kak mesec pride na pregled in ga vpraša doktor, kako mu kaj služi.    \"Kar v redu! Samo po tem ko lulam, jo moram ugriszniti, da spusti...\"", "Ženska roka" },
                    { 464, true, 43, "Trije fantje se pogovarjajo o svojih očetih.    Prvi reče: \"Moj oče je tako majhen, da lahko stoji pod mizo.\"    Drugi reče: \"Moj oči lahko stoji pod stolom.\"    Tretji začne jokati.    Druga dva ga vprašata, zakaj joče.    Tretji nato reče: \"Moj oče se je pa hudo poškodoval, ko je borovnice nabiral. Je dol z lestve padel.\"", "Kdo ima manjšega očeta" },
                    { 556, true, 43, "Na vrata je potrkala soseda in rekla: \"Rada bi vam povedala, da je vaša mačka danes pojedla mojo potico, ki sem jo hladila na okenski polici!\"    Soseda odgovori: \"Hvala, da ste mi povedala. Danes ne bo dobila nič več za jesti, saj je gotovo sita!\"  ", "Težave z mačko" },
                    { 554, true, 43, "Francka: Marija, zakaj si pa vrgla podnajemnika iz svoje hiše?\"    Marija: \"Veš, da sem velikodušna, zaupljiva in nisem radovedna. Toda nekaj je bilo zelo narobe!\"     Francka: \"Kako veš?\"    Marija: \"Pokrival je luknjo od ključavnice\"", "Podnajemnika ve vrgla iz hiše" },
                    { 552, true, 43, "\"Vlado, zakaj si tako žalosten?\"    \"Čital sem knjižico, ki ima žalosten konec.\"    \"Katero knjižico?\"    \"Hranilno!\"", "Bral je" },
                    { 550, true, 43, "\"Ta sprehajalna palica je vendar mnogo prevelika zate!\"    \"Res je! Ampak samo ne eni strani, zgoraj. Spodaj je ravno pravšnja!\"", "Sprehajalna palica" },
                    { 548, true, 43, "\"Znaš igrati na klavir?\"    \"Ne vem!\"    \"Kako ne veš?\"    \"Nikoli še nisem poskusil.\"", "Klavir" },
                    { 547, true, 43, "\"Kako si se kaj imel na dopustu?\" Si imel lepo vreme?\" je France vprašal prijatelja.    \"Samo dvakrat je deževalo.\"    France: \"Potem si imel pa srečo!\"    \"Kakšno srečo, neki? Prvič je deževalo sedem, drugič pa pet dni!\"", "Dež na dopustu" },
                    { 546, true, 43, "Marko in Peter se sončita na plaži, ko Marko naenkrat pograbi časopis in steče proti toaletnim prostorom.    \"Čakaj!\" zavpije Peter za njim. \"To je vendar današnji časopis!\"    Marko: \"Žal mi je, a do jutri ne morem zdržati!\"  ", "Nuja je nuja" },
                    { 545, true, 43, "Peter je že večkrat potožil prijatelju, da v njegovem avtu nekaj čudno škriplje. Bil je že na servisu, toda avtomehaniki niso našli ničesar nenavadnega.    Končno je nekega dne veselo ogovoril prijatelja: \"Ugotovil sem, kaj tako škriplje v mojem avtu!\"    \"In kaj je to?\"    \"Rja ga tako naglas razjeda!\"", "Avto mu škriplje" },
                    { 539, true, 43, "\"Včasih so ženske vsakodnevno množično tekle za menoj!\"    \"In zakaj danes ni več tako?\"    \"Ne kradem jim več torbic.\"", "Tečejo za njim" },
                    { 537, true, 43, "\"Ali si že slišala, da Simona pričakuje otroka?\"    \"Ja, sem! In tudi mislim si, od koga bo ta otrok!\"    \"Potem jo pa pokliči in ji povej, da bo vedela, koga tožiti za očetovstvo!\"  ", "Rodila bo" },
                    { 535, true, 43, "Ali si ti sinoči tekel po naši ulici?    \"Ja, hotel sem preprečiti pretep.\"    \"Kdo se je pa tepel?\"    \"Jaz in neka Baraba.\"", "Tek po ulici" },
                    { 534, true, 43, "Prijatelja se sprehajata po mestu in si pripovedujeta ljubezenske avanture.  Prvi: \"Včeraj sem doživel nekaj neprijetnega. V kinu sem spoznal čudovito žensko in odšla sva k njej domov. Začela sva se igrati, ko se je nenadoma na vratih prikazal njen mož. V trenutku sem se izmazal in sem se izgovoril, da sem z gospodinjskega servisa. Potem pa sem moral celo popoldne likati perilo.\"    Drugi: \"Kje pa je to bilo?\"    Prvi: \"V tisti stolpnici, v sedmem nadstropju!\"    Drugi: \"O hudiča, tam sem jaz prejšnji teden celo popoldne brusil parket!\"", "Ljubezenske avanture" },
                    { 529, true, 43, "Na planino so sprejeli mladega pastirja.    Starejši pastirji mu vse razložijo: vstajanje ob rani uri, kako se dela sir, kje je najboljša paša, itd.    Mladi pastir: \"Že, že, ampak ... kako bi rekel ... kaj pa spolno življenje?\"    Eden od starejših pastirjev brez zadrege: \"Hja, žensk ni, kot vidiš. Ovce natepavamo!\"    Mine kak teden in stari pastirji gredo po poti, ko zalotijo mladega pastirja, kako za grmom obdeluje ovco.  Vsi se začnejo na glas smejat.    Mladi pastir, užaljeno: \"Kaj se smejete, saj ste rekli, da ovce natepavate?!?\"    Eden od starih pastirjev: \"Žem že, samo ne takih grdih!\"", "Mlad pastir na planini" },
                    { 528, true, 43, "\"Suzana, zakaj pa ti je moški, s katerim si se pogovarjala, rekel da se pojdi solit?\"    \"Da drugi ne bi razumeli, povabil me je na morje.\"", "Pojdi se solit" },
                    { 382, true, 43, "»Šla sem v ženitno posredovalnico, kjer ti z računalnikom poiščejo moža,« razlaga ena dama drugi. »In v računalnik so vstavili moje želje- da iščem moškega nižje postave, s prirojena eleganco, ki rad nosi večerne obleke in ki se ukvarja s športom, po možnosti vodnim…«  »In koga ti je izbral računalnik?«  »Pingvina!«", "Izbira partnerja" },
                    { 527, true, 43, "Jaka na sprehodu sreča zamišljenega prijatelja Toneta.    Jaka: \"Zakaj si pa tako zamišljen?\" ga vpraša.    Tone: \"Obujam spomine.\"    Jaka: \"Si že prišel do tam, ko sem ti posodil dvesto € ?\"", "Obuja spomine" },
                    { 525, true, 43, "\"Vi imate pa prekrasne otroke, gospa Kovačeva,\" je rekla nova soseda.    \"Ja, štirje so, peti je pa na poti!\"    \"Kaj? In kdaj ga pričakujete?\"    \"Čez pet minut pride iz šole!\"", "Pričakuje otroka" },
                    { 523, true, 43, "\"Gospod, ste vi samostojni podjetnik?\"    \"Ne, še vedno sem poročen!\"", "Samostojni podjetnik" },
                    { 522, true, 43, "Si že videl ženo od mojega slepega soseda?    \"Ne, še nikoli je nisem videl.\"    \"Nič hudega, saj je njen mož tudi še nikoli ni videl.\"", "Ni je videl" },
                    { 521, true, 43, "Soseda, kaj pa študira vaša hči?    \"Filozofijo.\"    \"Dober študij je izbrala. Zofe bodo šle vedno v promet!\"", "Študij" },
                    { 520, true, 43, "\"Lojze mi je rekel, da je suh kot poper pa sem mu posodil deset tisočakov!\"    \"Lažnivec! Meni je pa rekel da mu voda teče v grlo, pa sem mu tudi posodil deset tisočakov!\"", "Lažnivec" },
                    { 519, true, 43, "\"Ali veš, da v našem mestu dva človeka nista istih misli?\"    \"Kako da ne? Kar k meni domov pridi, pa ti bom pokazala poročna darila!\"", "Iste misli" },
                    { 517, true, 43, "\"Franci, kaj boš pa danes delal?\"    \"Nič!\"    \"No, potem ti pa lahko pomagam!\"", "Paln dela" },
                    { 516, true, 43, "Primož svojemu sostanovalcu Mateju: \"Matej, ali si kaj videl knjigo o alternativnem ogrevanju?\"    Primož: \"Ja, vrgel sem jo v peč!\"", "Alternativno ogrevanje" },
                    { 515, true, 43, "Poglej tole Tino! Saj sploh nima prsi!    \"Ne bodi tak! Veš, ona ima zelo stroge starše in ji ne dovolijo, da bi jih nosila naokoli.\"", "Nima prsi" },
                    { 499, true, 43, "Paznik je naročil zapornikom: \"Jetniške celice morajo biti čiste, kot nove! Prišel bo pravosodni minister!\"    \"Končno so prijeli to barabo!\" se je oglasil eden od zapornikov.", "Prijeli so ga" },
                    { 498, true, 43, "\"Obdolženi, tožniku ste rekli idiot. Ali bi radi kaj dodali?\"    \"Še veliko, pa bi me stalo preveč denarja.\"", "Grde besede" },
                    { 497, true, 43, "Sodnik obtoženki: \"In vi pravite, da vas je tale gospod udaril? Saj je invalid, skorajda nepokreten!\"      Obtoženka: \"Ko me je udaril, še ni bil invalid!\"", "Invalid jo je udaril" },
                    { 488, true, 43, "\"Poklicali ste 113, Klic v sili, prosim.\"    \"Dve punci se tepeta zame!\"    \"Dobro...\" po krajšem premoru \"...in kje je tu problem?\"    \"Ta grda zmaguje!\"", "Klic v sili" },
                    { 475, true, 43, "Moža ni bilo doma in žena si je med tem privoščila ljubimca. Naenkrat zaškrta ključavnica, sliši se odklepanje.     Žena hitro skrije ljubimca v omaro, sklene roke k nebu in prosi: \"O Bog, naredi z menoj kar hočeš, samo ne dovoli, da naju najde moj mož. Grozno je ljubosumen in gotovo bi ubil ne samo mene, ampak tudi ljubimca.\"    Nebesa se odprejo in zasliši se zamolkel glas: \"Dobro, naj bo kot želiš, toda čez tri leta te pokličem k sebi…utopila se boš.\"     Žena: \"Dobro, dobro…samo da naju ne zaloti!\"    Kočljiva situacija se je razrešila popolnoma gladko.    Tri leta se nato žena ni kopala v banji, ni hodila v kopališča, toplice…vodam se je na daleč izogibala.    Tri leta so minila, minilo je četrto, peto. Na zaobljubo je žena pozabila. Po petih letih si je kupila vozovnico za križarjenje po morju okoli sveta.    Na ladji so bile same ženske, odlično so se zabavale. Kar naenkrat se začne ladja potapljati. Žena se je spomnila na božje besede: \"Torej nisi pozabil in me boš vzel k sebi!? Poglej malo naokrog koliko nedolžnih žensk bo umrlo skupaj z menoj!\"    Odprejo se nebesa in zasliši se strogi glas: \"Dve leti! Dve leti sem se mučil, da sem vas, prasice, spravil na eno ladjo!\"", "Bog ne pozabi" },
                    { 526, true, 43, "\"Včeraj sem govoril s sosedom. Natvezil mi je da pozna tvojega pra-pra-pra-pra-deda. Nisem mu verjel!\"    \"Oh, kaj ne veš, da sosed jeclja?\"", "Pozna pradedka" },
                    { 168, true, 27, "Se poročita 80-letnik in 20-letnica.  Po nekaj mesecih se jima rodi otrok in sestra v porodnišnici vpraša očeta: To je nemogoče. Kako vam je to uspelo pri teh letih?    Pa ji odgovori: \"Star motor je treba negovati.\"    Zgodba se po kakem letu ponovi. Še drugo rojstvo.    Sestra ponovno: \"Ne morem verjeti. Kako vam je lahko spet uspelo?\"    Pa 80-letnik spet ponosno: \"Star motor je treba negovati.\"    Naslednje leto pa že tretje rojstvo. Sestra: \"Ste pa res možakar!\"    Srečni oča: \"Star motor je treba negovati\", ji odgovori.    Sestra pa pripomni: \"Samo sedaj je pa že čas, da zamenjate olje, ker je vaš tretji otrok črn!\"", "80 letnik in 20 letnica" },
                    { 167, true, 27, "So bili trije pedri na nočnem prekooceanskem letu.  Pa reče prvi: \"Kaj, ko bi me vidva nabrisala?\"    \"Si nor, bo kdo videl!\"   \"Ma nobeden, saj vsi spijo.\"  \"Bo pa kdo slišal in se zbudil, verjetno je pa vsaj stevardesa budna!!\"    \"Nobeden, bosta videla!\" In začne klicati: \"Bi lahko dobil kozarec vode!\"   In nič se ni zgodilo. \"BI LAHKO DOBIL KOZAREC VODE, KER MI JE SLABO!!\"    In spet se ni nič zgodilo.    \"No vidiš, nobeden se ne zbudi, sedaj me pa kar po vrsti naguzita.\"    Zgodaj zjutraj gre stevardesa po avionu in opazi starčka, ki se trese od mraza.  \"Gospod, vam je hladno?\"  \"Ma, zebe me kot psa!\"  \"Zakaj pa niste poklicali in prosili za odejo?\"  \"Ni šans! Je eden klical in prosil za vodo, pa so ga potem celo noč jebali!!\"", "Nočni let" },
                    { 166, true, 27, "Mož in žena praznujeta 30. obletnico poroke. Odločita se, da bosta ponovila poročno potovanje.    In res se odpravita na pot. Ko se peljeta po neki cesti na podeželju, ob kateri je ograja za krave, žena reče: \"Kaj če bi zdaj naredila tisto, kar sva pred 30 leti?\"    Mož ustavi avto in naslonita se na ograjo ter začneta seksat.    Ko končata, mož reče ženi: \"Pred 30 leti pa nisi tolk migala.\"    Žena mu odgovori: \"Pred 30 leti ograja še ni bla električna.\"", "Trideseta obletnica poroke" },
                    { 607, true, 11, "Mala Tinca pride domov iz šole vsa nasmejana in reče mami:   \"Jurček mi je danes pokazal svojega lulcča!\"     Se preden se mama zaskrbljeno zave, Tinca nadaljuje:   \"Spomnil me je na arašid\"     Mama si oddahne in se nasmehne:   \"Tako majhen je bil?\"     Tinca odgovori: \"Ne.... slan!\"", "Arašidek" },
                    { 605, true, 11, "Trije starčki, stari 70, 80 in 90 let, se pogovarjajo o svojih starostnih tegobah.   - \"Mene muči prostata. Zbudim se že ob šestih, uščijem se pa komaj do sedmih\", potoži 70-letnik.  - \"Ja, mene pa črevesje matra. Zbudim se ob šestih, userjem se pa komaj do osmih\", pravi 80-letnik.   - \"Eh, vidva sta še dobra,\" pojamra 90-letnik. \"Jaz se pa uščijem ob šestih, userjem se ob sedmih, zbudim se pa ob osmih...\"", "Trije starčki" },
                    { 598, true, 11, "Ljubi, oprosti, da sem tako pozno prišla domov, toda iz službe sem šla še v lepotilni salon.  Mož jo premeri od glave do peta in reče:\"A nisi prišla na vrsto?\" ", "Lepotilni salon" },
                    { 533, true, 11, "Sosed vpraša soseda: \"Zakaj pa letos ne boš šel z družino na morje?\"    \"Ker so me dolgoletne izkušnje izučile, da doma ceneje dežuje.\"", "Dopust in dež" },
                    { 518, true, 11, "\"Slišal sem, da se z bratom tožarita za hišo, ki jo je zapustil dedek?\"    \"To je že zdavnaj mimo!\"    \"In kdo jo je dobil?\"    \"Odvetnik!\"", "Zapuščina" },
                    { 505, true, 11, "Babica je imela tri odrasle vnuke, za katere je domnevala, da je nimajo preveč radi. Da bi ugotovila, kako radi jo imajo, jih je preizkusila.  Prvi dan je povabila prvega vnuka na sprehod ob reki. Naredila se je, kot da ji je spodrsnilo in “padla” v reko, nato pa zavpila na pomoč. Vnuk je skočil v reko in jo rešil. Naslednji dan je vnuka pred hišo čakal nov Mercedes, za brisalci pa je bil zataknjen listek z napisom: “Hvala, ker si me rešil! Tvoja babica.”  Drugi dan je na sprehod povabila drugega vnuka. Prav tako se je naredila, da ji je spodrsnilo in skočila v reko, nato pa poklicala na pomoč. Vnuk je skočil v reko in jo rešil. Naslednje jutro je drugega vnuka pred hišo čakal Mercedes z lističem za brisalci: “Hvala, ker si me rešil! Tvoja babica”.  Naslednji dan je preizkusila še tretjega vnuka. Povabila ga je na sprehod ob reki in se zopet naredila, da ji je spodrsnilo. Skočila je v reko in poklicala na pomoč, toda tretji vnuk se ni niti ozrl, temveč je nadaljeval svojo pot. Naslednje jutro ga je pred hišo čakal nov Ferrari, v njem je bil kovček z desetimi milijoni dolarjev, za brisalci pa je bil zataknjen listek z napisom: “Hvala, ker si me rešil! Tvoj dedek!”", "Babica in dedek" },
                    { 496, true, 11, "Sodnik vpraša obtoženko:  \"Torej ne zanikate, da ste med prenosom nogometne tekme ustrelili svojega moža?\"    Obtoženka: \"Ne, priznam, da sem to storila.\"    Sodnik: \"In katere so bile moževe zadnje besede?\"    Obtoženka:\"Streljaj! Streljaj!\"", "ustrelila je moža" },
                    { 493, true, 11, "Koliko denarja imaš ti, in koliko ga ima žena, če imaš ti v žepu 25EUR in ona 5€?    Ti nimaš nič, ona ima pa 30EUR.", "Enostavna matematika" },
                    { 492, true, 11, "21. rojstni dan, Tine  iz Bohinja je slišal zgodbice o neverjetni družinski tradiciji.    Pravili so, da so njegov oče, dedek in pradedek na svoj 21. rojstni dan imeli  možnost hoditi po vodi čez Bohinjsko jezero, do oštarije, kjer so  si privoščili svojo prvo alkoholno pijačo.    Tako  je Tine na svoj 21. rojstni dan, skupaj s prijateljem Martinom, odveslal na sredo jezera. Tine je stopil iz čolna in se skoraj utopil. A Martin ga je uspel rešiti iz vode.    Besen in zmeden se je Tine odpravil do svoje babice.     \"Babica\", jo je vprasal, \"danes je moj 21. rojstni  dan. Zakaj torej ne morem hoditi po vodi, tako kot so lahko moj oče, dedek in pradedek?\"    Babica se je zazrla v Tinetove oči in odgovorila: \"Ker so se tvoj oče, dedek in pradedek rodili januarja. Ti pa si se rodil avgusta.\"", "Hoja po vodi" },
                    { 490, true, 11, "Se pogovarjata dva prijatelja, pa pravi prvi: \"Janez, si že naredil kakšen načrt za dopust?\"    Janez: \"Ne, čemu bi ga? Moja žena določi, kam bomo šli, moj šef določi, kdaj bomo šli, in moja banka določi, kako dolgo bomo na dopustu!\"", "Planiranje dopusta" },
                    { 486, true, 11, "\"Ti si pa ful shujšal!\"    \"Ja, sem na ločevalni dieti.\"    \"Kako pa to zgleda?\"    \"Ločujem se, kuhat pa ne znam.\"", "Ločevalna dieta" },
                    { 476, true, 11, "\"Oj stari, kaj pa delaš?\"    \"Stol za ženo.\"    \"Ajaaa! Pa gre?\"    \"Ooo ja gre gre, sam elektrika me še mal zajebava.\"", "Stol za ženo" },
                    { 465, true, 11, "Mladenič navdušeno pove mami, da se bo kmalu poročil.    Reče ji: \"Za test bom domov pripeljal tri dekleta, ti pa poskusi uganiti, katere je moja izbranka!\"    Mama se strinja s predlogom in naslednji dan sin pripelje domov tri lepotice ter jih posadi na kavč.    Nekaj časa sproščeno kramljajo. Nato se sin obrne k mami in jo vpraša: !No, mami, s katero se bom poročil?\"    Ona izstreli: \"Rdečelaska na sredini.\"    Osupel, sin vpraša: \"To je neverjetno, kako si vedela??\"    Mama: \"Na živce mi gre kot hudič.\"", "Katera bo izbranka" },
                    { 461, true, 11, "Janez se zvečer vrne domov iz druge “smene”, se sesede na stol v kuhinji in vpraša: \"Kaj bo za večerjo?\"    Žena se postavi v zapeljivo pozo in pravi: \"Mogoče jaz?\"    Janez: \"Saj veš, da ne smem nič mastnega.\"", "Kaj bo za večerjo" },
                    { 458, true, 11, "Mica: \"Kok pa s' dobiva, ksta naša dva v hosti podirava smreke in je Tvoj France škripnu pod smreko.\"    Jožefa: \"Dva miljona.\"    Mica: \"Bog se me usmil! Moj bk Ivan je pa odskoču!\"", "Nesreča v gozdu" },
                    { 444, true, 11, "Objavi punca na facebook: \"Eni morte v šolo, eni smo pa na kavici\".    Mama spodaj komentira: \"Ene čaka kosilo, ko pridejo iz šole, ene pa batine\".", "Ni v šoli" },
                    { 443, true, 11, "Kako veš, da je otrok v puberteti?    - neha spraševati od kod je prišel,  - noče povedat kam gre.", "Pubertetnik" },
                    { 431, true, 11, "Spoštujem svoje bivše.    Če ne drugega so imele vsaj dober okus.", "Bivše" },
                    { 425, true, 11, "Hčerka se pritožuje: \"Moja soba je najgrša soba v naši hiši!\"    Oče: \"V redu no, jutri ti bom odstranil vsa ogledala.\"", "Grda soba" },
                    { 422, true, 11, "Nekega jutra mož ženo, ki pripravlja zajtrk, uščipne v zadnjico in pravi: “Veš, če bi ti malo utrdila tole, bi se lahko znebila teh grdih spodnjic.”    Žena stisne zobe in ne reče ničesar.    Naslednje jutro jo mož zbudi s ščipanjem v prsi in pokomentira: “Veš, če bi si malo utrdila tele, bi se lahko znebila modrca.”    Tokrat žena ne more več biti tiho, zagrabi ga med noge in jezno zabrusi: “Veš, če bi ti utrdil tole, bi se lahko znebila poštarja, vrtnarja in tvojega brata.”", "Mož zbada ženo" },
                    { 418, true, 11, "Janez se odpravi lovit ribe in že čez uro se mu nasmehne sreča - ujame tolstega krapa. Teče domov in zavpije:    \"Marta, hočem ocvrtega za kosilo!\"    \"S čim pa?\" posmrkne Marta. \"Nimava ne za drobtine in ne za jajca.\"    \"Pa ga kar tako vrzi na olje.\"    \"Zadnje olje od Rdečega križa sva porabila predvčerajšnjim, saj veš ...\"    \"Pa naj bo kuhan!\"    \"Aja? Ta čas, ko si lovil, so bili tukaj od Elektra. Tri mesece že nisva plačala elektrike in so nama jo odklopili.\"    \"Potem pa je najbolje, da ga odnesem nazaj,\" ves razočaran reče Janez.    \"Bolje, bolje,\" zašepeta Marta.    Rečeno - storjeno. Janez izpusti krapa nazaj v vodo, ta veselo odplava, se na sredi reke obrne in zavpije:    \"Naj živi vlada Slovenije!!!!\"", "Janez lovi ribe" },
                    { 417, true, 11, "Janez se z Micko sprehaja po sejmu. Ogovorita ga dve dekleti, ki predstavljata belo tehniko rekoč:    \"Gospod imate doma pomivalni stroj\"?    Janez odvrne:\"Seveda ga imam\"    Dekleti: \"No potem pa dovolite, da vam predstaviva revolucionarne tablete za pomivalni stroj, jih želite kupiti?\"    Janez pokliče Micko in jo vpraša:    \"Micka, boš jedla te tablete?\"", "Janez in micka na sejmu" },
                    { 416, true, 11, "Sta šla zakonca v sveto deželo Jeruzalem, kjer je žena nenadoma umrla.    Mimo je prišel katoliški duhovnik, ki je možu ponudil dve možnosti:  1. Ženo lahko pokopljete tukaj, v sveti zemlji za 200 EUR.  2. Lahko jo odpeljete domov, kar bi s prevozom in vsemi papirji stalo 3.000 EUR.    Možakar takoj: \"Kar spakirajte mi babo za domov, jaz vam bom pa plačal.\"    Duhovnik: \"Čudi me gospod, da ste se odločili za to varianto. Ali ne bi bilo lepše in ceneje, če bi bila pokopana v sveti zemlji ???\"    Možakar: \"Enkrat davno, vi to veste, je en človek umrl in je bil pokopan prav tu. Po treh dneh je vstal od mrtvih. Zeher je ziher!\"", "Ziher je ziher" },
                    { 399, true, 11, "Pride Janezek v lekarno in rece lekarnarju da rabi kondom, saj ga je punca, s katero hodi ze pol leta, danes povabila na druzinsko vecerjo in kot posladek pricakuje nekaj akcije. Lekarnar mu da kondom in Janezek odide iz lekarne.  Cez pet minut se vrne po nov kondom in razlozi, da je tudi sestra njegove punce dokaj micna gospodicna, ki mu ze kar nekaj casa namiguje in vzbuja pregresne misli. Lekarnar mu da novi kondom in Janezek odide.  Ne traja dolgo, pa je Janezek spet v lekarni, ces, da rabi se tretji kondom. Lekarnarju razlozi, da je mama njegove punce kljub starosti se dobra mrha in da na tihem upa, da se mu bo tudi pri njej nocoj nasmehnila sreca. Tako odide iz lekarne zalozen s tremi kondomi.  Zvecer se vsa familija vsede za mizo in Janezek zacne z molitvijo. Moli 5 minut, 10 minut, 15 minut... Pa kar ne neha... Njegova punca se nagne k  njemu in ga vsa zacudena vprasa: \"Nisem vedela, da si tako veren?\"  Janezek pa ji odgovori: \"Tudi jaz nisem vedel, da je tvoj oce lekarnar.\"", "Lekarnar" },
                    { 395, true, 11, "Tašča pride nepričakovano na obisk.    In to ravno pred kosilom!    Ko tašča opazi, da se spravljajo h kosilu se začne opravičevati in poslavljati.    Zet elegantno: \"Rezka, lahko ostanete pri nas na kosilu. Juhi sem že prilil vodo!\"", "Tašča na obisku" },
                    { 393, true, 11, "\"Žal mi je, da je tvoja žena zgorela v avtu s šoferjem.\"    \"Saj sploh ni tako hudo. Šoferja sem tako in tako hotel odpustiti!\"", "Zgorela v avtomobilu" },
                    { 391, true, 11, "\"In kako je bilo na kosilu pri starših tvojega dekleta?\"    \"Ne sprašuj! Zdaj mi je pa zares jasno zakaj pred jedjo vedno molijo!\"", "Kosilo pri starših od dekleta" },
                    { 315, true, 11, "Mož vpraša ženo: \"Kaj bi storila, če bi jaz zadel na lotu?\"    Žena: \"Vzela bi polovico denarja in odšla. Nikoli več me ne bi videl!\"    Mož potegne iz žepa 10€ rekoč: \"Na, tu je tvoja polovica in spizdi!\"", "Kaj bi storila, če bi zadel na lotu?" },
                    { 300, true, 11, "jože: \"Kje si bil med zimskimi počitnicami ? Si bil z otroci na smučanju?\"    Franc: \"Da, smučali smo?\"    Jože: \"In? Je bilo lepo?\"    Franc: \"Najboljši občutek sem imel, ko so mi sneli mavec iz noge!\"", "Počitnice na smučišču" },
                    { 638, true, 11, "Zakonca na potovanju.  Ko potujeta po dolini nad katero  se vspenjajo mogocne gore,zena rece:  Dragi kako lepo!  Kar brez besed sem ostala!  \"Super!Potem bova kar tu ostala!", "zakonca" },
                    { 298, true, 11, "\"Odkar sem se pred tednom dni razšla s svojim zaročencem, je vsak dan pijan.\" razlaga mlada punca svoji prijateljici.    Prijateljica: \"Ta pa res dolgo proslavlja!\"", "Razšla sta se" },
                    { 649, true, 11, "Štefan je povabil svojo mamo na večerjo v svoje študentsko stanovanje.    Med večerjo je njegova mama ugotovila, da je njegova sostanovalka Julija zelo lepo dekle. Že nekaj časa ji je po glavi rojila misel, da imata morda le tesnejši odnos.    Nenadoma se je počutila nesigurno...     Med večerjo ju je opazovala. Večkrat se je vprašala, ali ima Štefan z lepo sostanovalko mogoče le več skupnega, kot normalno oko lahko vidi.    Štefan je videl zamišljeno mamo in rekel: Draga mama, vem kaj misliš, ampak lahko mi verjameš, ona je samo moja sostanovalka in nič več!    Čez slab teden pravi Julija: Štefan, odkar je bila tvoja mama tu, pogrešam majhen lonec. Nikjer ga ne najdem!    Štefan pravi: Ne verjamem, da ga je mama nesla s seboj, vseeno pa ji bom pisal.    Usedel se je za mizo in pisal: Draga mama, ne rečem, da si vzela moj lonec s sabo, in tudi ne rečem, da ga nisi vzela. Dejstvo pa je, da odkar si bila pri nama na večerji, pogrešava lonec.  Tvoj Štefan.    Nekaj dni kasneje je dobil Štefan pismo.    Odpre ga in bere: Dragi Štefan, ne rečem, da ti z Julijo spiš, in tudi ne rečem, da ti z Julijo ne spiš. Dejstvo pa je, da če bi ona spala v SVOJI postelji, bi lonec že zdavnaj našla...  Tvoja mama", "Mama na obisku" },
                    { 657, true, 11, "Jurij: \"Koširček moj, kako si kaj?\"     \"Slabo, zelo slabo, očka sem postal.\"     \"To je vendar čudovito. Čestitam. In kako je kaj Marta?\"    \"V redu je, ni še izvedela.\"", "Postal je očka" },
                    { 911, true, 11, "Žena pogosto gnjavi moža, češ da mu nič ne uspe v življenju.    Nekega dne, po obilnem kosilu pa se mož, ko čuti, da je žena dobre volje, ojunači in reče:     \"Žena, dve stvari pa sta mi v življenju zelo dobro izpadli!\"     \"Kaj le?\" vpraša žena.     Mož odgovori: \"Zobje in lasje!", "Pohvali se, da je dobro izpadlo" },
                    { 908, true, 11, "Včeraj zvečer sva z ženo sedela na kavču in se pogovarjala o življenju.    Pogovor je nanesel tudi na pomen dostojanstva človeškega življenja, pa sem ji rekel:     \"Draga, če bi se meni kdaj zgodilo, da bi bil v stanju vegetiranja, odvisen od aparatov in tekočin, prosim, da odklopiš vse tisto, kar bi me ohranjalo pri življenju.\"     Žena je v trenutku vstala, izklopila televizijo in mi vzela pivo. ", "Če bo na aparatih" },
                    { 900, true, 11, "Ko ga ona zagleda v kopalkah, mu reče: \"Oh, kakšna ramena!\"     \"Na služenju vojaškega roka sem nosil strojnico\" je povedal fant.     \"Pa kakšna močna, mišičasta stegna imaš!\" ga je pohvalila.     \"Ja, veš, v vojski smo veliko pešačili.\"     Zvečer ga je prvič videla popolnoma golega.     \"Lulali ste pa v vojski bolj malo, kajne?\"", "Fant in dekle prvič skupaj na morju" },
                    { 897, true, 11, "Mama je sina za kazen predčasno poslala v posteljo, toda kmalu se je sin zadrl:  \"Mami!\"  \"Kaj je?\"  \"Žejen sem! Prinesi mi kozarec vode!\"  \"Nič ne bo! Ugasni luč in zaspi!\"  \"Mami!\" se je še bolj zadrl.  \"Kaj je spet?\"  \"Žejen sem! Ali grem lahko sam popit kozarec vode?\"  \"Rekla sem, da bodi tiho in zaspi! Če ne boš dal miru in se boš še enkrat oglasil, boš dobil batine!\"  \"Mama!\"  \"Kaj?\"  \"Ko boš prišla v mojo sobo, da mi daš batine, mi prosim prinesi še kozarec vode!\"", "Spat je treba" },
                    { 891, true, 11, "- Bemti, vsak dan isto za kosilo!!! Daj, sine, pojdi in reci mami, da ima kuharska knjiga čez 200 strani!  - Oči, sem že povedal.  - In,... kaj je rekla???  - Da ima Kamasutra tud toliko strani!", "Vedno isto kosilo" },
                    { 890, true, 11, "Prvo leto zakona, 60 letnega bogatega gospoda z mlado ženo, je bilo vse v najlepšem redu.    Potem je nekega dne gospod odšel k zdravniku:  - Želiva imeti otroka, ampak bolj ko se trudiva, nama nikakor ne uspe!  - V Vaših letih je to pogost pojav, zato Vam svetujem, da vzamete podnajemnika.    Tri mesece kasneje pride gospod k zdravniku in se pohvali:  - Hvala vam za nasvet, moja žena je noseča.  - No, a sem Vam rekel? Kako je pa kaj podnajemnik??  - Tudi ona je noseča!", "Težave z zanositvijo" },
                    { 882, true, 11, "Moz se vrne s sluzbene poti  in najde zeno,kako pripravlja  romanticno vecerjo za dva.  O,to je pa presenecenje!  pripomni zadovoljno.  Zena:  Ja,pa res.Nisem te pricakovala  pred petkom.", "Prisrcen sprejem" },
                    { 880, true, 11, "Mladi par se poroci.  Prvo noc se ne zgodi nic,drugo,  tretjo noc nic in tako   mesec dni.  Pa rece nevesta:  Zdaj grem na cesto in pripeljem  v posteljo prvega,ki ga srecam.  Moz ji ponizno odgovori:  Prosim,pripelji se meni enega.", "Moderni zakon" },
                    { 875, true, 11, "Marta je besna,benti na  Kosirja:  Zakaj toliko kadis?  Poglej statistiko,  zaradi tobaka vsako leto  umre kar 5o.ooo Italjanov.  Kosir mirno:  kaj me briga,jaz sem Slovenec.", "Tobak" },
                    { 873, true, 11, "Zapornik si ogleduje sliko novega sojetnika in mu pravi:   Tako lepa zena te ze ne bo cakala sedem let.  On nazaj: Ja, pa me bo. Ona je dobila deset.", "V zaporu" },
                    { 866, true, 11, "Bertu umre zena,kaksne posebne  zalosti ne kaze.  Preden pogrebniki zaprejo krsto,  se le oglasi:  Prosim,obrnite zeno na trebuh.  Pogrebnik je zacuden:  Zakaj pa to?  Berto strumno:  Ce se slucajno zbudi,da bo  kopala navzdol!", "Berto" },
                    { 864, true, 11, "Janezek prihiti domov  in rece:  Ata,mamo kar prodajmo.  Zakaj pa?  Jaz ne pijem vec pri njej,  ti ne spis v njeni postelji  in res ne vem,zakaj bi jo  redili za soseda.", "Mama naprodaj" },
                    { 863, true, 11, "Peter je iz davcne uprave  prejel vrnjeno davcno napoved  s pripisom:  Pogresamo prihodke vase zene!  Takoj jim odgovori:  Jaz tudi!", "Pomankljiva napoved" },
                    { 842, true, 11, "Stric opazi Janezeka,ki ze  pol ure hodi po dvoriscu,  gleda v tla in ocitno  nekaj isce.  Kj pa delas?ga vprasa.  Izgubil sem pet evrov in  jih iscem.  Stri seze v denarnico in  mu da pet evrov.  Na,da ne bos imel izgube.  Janezek se zahvali,spravi   denar,cez nekaj casa pa stric   opazi,da se vedno nekaj isce:  Kaj vendar delas?Saj sem ti  dal pet evrov.  Seveda,da ne bom imel izgube.  Jaz pa bi zdaj rad imel dobicek.                                                    ", "Pet evrov" },
                    { 821, true, 11, "Miha se pozno zvecer vrne domov  in leze k zeni ter se zacne  stiskat k njej.  Ona pa:  Dragi,danes nisem razpolozena.  Pa kaj vam je danes vsem?  Ali ste se dogovorile?", "Dogovorjene" },
                    { 820, true, 11, "Tinka mamici:  Mami,nasla sem babico.    Mami:Otrok moj,pa sem ti  rekla,da ne koplji po vrtu.", "Vrt" },
                    { 819, true, 11, "Polde in Pepca lezita na postelji.  On bere casopis,vsake tolike casa pa  njegova roka smukne pod odejo.  Pepca vsa polna pricakovanja:Kaj ti je?  Kot da bi kaj hotel?  On:Ne,ne kje pa.Samo da lazje  listam casopis.", "Polde" },
                    { 809, true, 11, "V vsakem zakonu kdaj pa kdaj zaskiplje.   Najbolje pa je da skriplje postelja.", "Skripanje v zakonu" },
                    { 806, true, 11, "Mami, mami kaj je to orgazem?  Ne vem, vprasaj ateja.", "Orgazem" },
                    { 798, true, 11, "Kosir obupan stece na ulico  in nagovori prvega  mimoidocega pesca:  Poslusajte,prodam tasco,koliko  daste zanjo?  Mimoidoci:Nic!  Kosir:Dogovorjeno,prodano!", "Tasca" },
                    { 778, true, 11, "Ko je Bog ustvarjal ženam može ... je ženam obljubil, da bodo lahko dobre in idealne može našle v čisto vsakem kotu sveta.  In potem je naredil Zemljo okroglo.", "Idealen mož " },
                    { 771, true, 11, "\"Mami, ali res angeli letijo?\"    \"Ja, otrok moj.\"    \"Ampak naša Rozi ne zna leteti!\"    \"Ne, Rozi je naša gospodinjska pomočnica in ne zna leteti!\"    \"Ampak očka ji vedno reče, da je njegov angelček!\"    \"Potem bo pa letela!\" ", "Angeli letijo" },
                    { 767, true, 11, "Se Jože zjutraj zbudi, stopi na balkon in v snegu zagleda s scanjem napisano: \"Jože je prasec\"    To ga seveda močno razjezi. Pokliče šefa varnostne službe in mu naroči, naj takoj poišče storilca.    Policaji podpis fotografirajo in vzamejo vzorce urina...    Čez teden dni šef policije poroča rezultate, rekoč: \"Imamo popolne rezultate. V zvezi z njimi vam moram sporočiti eno dobro in eno slabo novico.\"     Jože reče: \"Povej najprej dobro novico!\"    Policaj odvrne: \"Urin je 100% od Hasota.\"    \"Saj sem vedel,\" odvrne Jože.    \"In kakšna je slaba novica?\"    \"Pisava pa je od vaše žene,\" odvrne policaj.", "Scanje v snegu" },
                    { 750, true, 11, "Hčerka se hoče zvečer neopaženo izmuzniti iz hiše.    Oče jo zaloti in jo vpraša: \"Kam pa kam?\"    Hčerka zardi in reče: \"Samo pismo nesem v nabiralnik.\"    Oče: \"Potem pa pohiti. Nabiralnik je že dvakrat zažvižgal!\"", "Ven bi šla" },
                    { 707, true, 11, "Kosir vstopi v kopalnico,zeli  oprati majco.  Gleda gumbe na pralnem stroju,a   mu nic ni jasno.  Zaklice Marti:Kateri program je  treba vklopiti za pranje majce?  Ona iz kuhinje:Je majca bombazna  ali sinteticna?  On:Ne vem!Marta nervozna:  Kaj pise na majci?  Kosir:Lasko je zakon!", "Lasko je zakon" },
                    { 705, true, 11, "Mati pride v trgovino z dvojčicama. Ko pomerita novi oblekici ju prodajalka napoti k ogledalu, toda mati pravi: \"Saj se lahko sami pogledata!!!!\"", "Dvojčici" },
                    { 696, true, 11, "Mojca doma vsa nervozna  hiti razlagati svoji mami:    Ves,srecala sem fanta,  zaprosil me je za roko,nevem,  kaj naj storim.  Nekam hitro je vse,sploh  me se ni dobro spoznal.  Mama:>>Poroci se,hcerka,cim  prej,nikar ne cakaj,da  te spozna!<<", "Mojca" },
                    { 666, true, 11, "\"Moj mož in jaz sva se dogovorila, da se bova ločila brez škandala in prepirov.\"     Odvetnik: \"Čudovito! Danes je malo zakoncev, ki se tako lepo razumejo.\"", "Ločitev" },
                    { 659, true, 11, "\"Očka, očka!\" je zavpil Andrej sredi kosila.    \"Med jedjo se ne govori.\" ga je ustavil očka.    Ko so pojedli ga je vprašal: \"Kaj si mi hotel povedati prej?\"     \"Zdaj je že vseeno, polža, ki je bil na solati si tako že pojedel.\"", "Med kosiom" },
                    { 653, true, 11, "\"Dragi, najin sin je postal diplomiran pravnik. Lahko sva ponosna na njega.\"    \"Super, pri njegovih tridesetih letih se ga bova končno znebila!\"    \"No, glede tega.... Zdaj je vpisal še podiplomski študij. Nekoč bo postal magister.\"", "Ponosna na sina" },
                    { 261, true, 11, "\"Kaj pa je s tabo? Te je avto povozil, da si cel v mavcu in ves plav?\"    \"Ne. Žena se je prehitro vrnila z dopusta.\" ", "Cel v mavcu" },
                    { 249, true, 11, "Mož: \"Žena, povej mi, kako to, da so ti že spet zvišali plačo?\"    Žena: \"Četudi ti povem si ti, s tem, ne bi mogel prav nič pomagati.\" ", "Povišica" },
                    { 223, true, 11, "Mož se, iz letališča, s taksijem vrača domov s službenega potovanja.  Polnoč je že zdavnaj mimo.    Ker že dolgo sumi, da ga žena vara, ponudi taksistu 100€, če gre z njim v hišo za pričo, da ga žena vara.  Potiho sta se splazila do spalnice, mož prižge luč, odkrije posteljo in zagleda v njej ženo z ljubimcem.    Izza pasu potegne pištolo in jo nastavi ljubimcu na čelo.    Žena vzklikne: \"Ne streljaj, lagala sem ti, da sem denar podedovala.  ON je plačal tvojo Corvetto, ki sem ti jo podarila, ON je plačal jahto, ON je plačal letno karto za nogometne tekme, ON je plačal vikend ob jezeru. Celo mesečne kredite plačuje ON.\"    Mož spusti pištolo, pogleda taksista in ga vpraša: \"Kaj bi ti naredil?\"    Taksist odgovori: \"Hitro bi ga pokril z odejo, da se ne prehladi!\"  ", "Mož sumi ženo, da ga vara" },
                    { 1337, true, 9, "Zakaj v Star Treku ni nobenega muslimana?    Ker se dogaja v prihodnosti.", "Star Trek in muslimani" },
                    { 1336, true, 9, "Kakšna je razlika med avtomobilsko pnevmatiko in nigerjem?    Guma ne tečnari, ko jo daš v verige.", "V verigah" },
                    { 1335, true, 9, "Kaj dobiš, če križaš črnca in hobotnico?    Zaboga, da ne vem! Ampak, a si predstavljaš kako ta niger pobira bombaž?", "Križanje" },
                    { 1326, true, 9, "Janezek se odloči da bo končno seksal. Odpravi se v javno hišo, pa gleda izbiro in vidi same lepe prostitutke, vmes pa tudi eno staro kot zemlja.    In si reče: \"Use sem že podrl sam stare pa še ne!\"    In tako si kupi pravo babico za 1 noc.    Ko konča jo vpraša: \"Babica zakaj je bilo na začetku, ko sem prodrl vate tako grobo pa hrapavo, kasneje pa je šlo vse tako gladko?\"    Stara gospa mu odvrne: \"Janezek, veš najprej so kraste, pol globlje je pa gnoj.\" ", "Privošči si starejšo" },
                    { 1324, true, 9, "Moški se dere: \"Pobil bom vse cigane!\"    Nihče mu ne oporeka.    Moški zopet: \"Pobil bom vse cigane!\"    Zopet mu nihče ne oporeka.    Moški zakriči: \"Pobil bom vse cigane in enega klovna!\"    Nekdo ga vpraša: \"Zakaj pa klovna?\"    Moški: \"Vidite, nikomur ni mar za cigane!\"", "Agresivni moški kriči" },
                    { 1134, true, 9, "Vedezevka pravi radovednezu:\"V kratkem bodo na vas metali cvetje in o vas lepo govorilo!\"  \"O res, s cim si pa bom to prisluzil?\"  \"Ne boste si prisluzili, taksna je navada na pogrebih.\"", "Vedezevalka" },
                    { 1133, true, 9, "Kanibalka pride v trgovino in vprasa trgovko:\"Ali imate mogoce Eskime?\"  Trgovka:\"Zakaj pa potrebujete Eskime?\"  Kanibka:\"Za hladni bife!\"", "Kanibalka v trgovini" },
                    { 1040, true, 9, "Mesar je na vrata izlozbe izobesil napis: Ze prvi greh Adama in Eve je pokazal, kako je vegetarijanstvo nevarno in skodljivo!", "Adam in Eva ter vegetarijanstvo" },
                    { 913, true, 9, "V ljudozerski vasi je vladala lakota, noben tujec ni prisel v vas, skratka ni bilo kaj jesti. Zaradi tega so se ze spravili na kosti.  Prvi ljudozerec pravi drugemu: Daj mi malo kosti, da jo vsaj polizem.  Drugi: Ne dam ti.  Daj no, prosim.  Ne dam ti, sem prevec lacen.  Dobro, saj bo meni tudi umrla mama, pa jaz tebi tudi ne bom nic dal vstran.", "Lakota" },
                    { 846, true, 9, "Katera je najtanjsa knjiga na svetu?  Hitlerjeva dobra dela!", "Najtanjsa knjiga" },
                    { 831, true, 9, "Mali kanibalcek pride domov in vprasa mamo.   Mami, koga pa danes kuhas, da tako lepo disi?", "Kosilo" },
                    { 710, true, 9, "Kaj je optimizem?  Ko vidiš klošarja v parku, ki bere revijo Moj dom!", "Optimizem" },
                    { 600, true, 9, "Hitler v taborišču:   Hitler: \"Si zdrav?\"   Žid: \"ja.\"   Hitler: \"Levo za golaž.\"   Hitler drugemu: \"Si zdrav?\"   Žid: \"Ja.\"   Hitler: \"Levo za golaž.\"   Hitler tretjemu: \"Si zdrav?\"   Žid: \"Ne.\"   Hitler: \"Kaj ti pa manjka?\"   Žid: \"Sladkorno imam.\"   Hitler: \"Desno za kompot.\"", "Dnevi kulinarike" },
                    { 599, true, 9, "Koliko je v Auschwitzu rekord na 100 metrov?      ---> 75 metrov", "Rekord" },
                    { 595, true, 9, "Policijo so poklicali zaradi nasilnega dogodka.  – Šef, prispeli smo na kraj incidenta.  – Kakšno je stanje?  – Žena je poškodovala moža. Osem vbodov z nožem, dve strelni rani, odprt zlom golenice, vržen po stopnicah dvonadstropne hiše, nato pa v jarek pred hišo. Stoka, res je v slabem stanju, ne verjamem, da bo preživel.  – O moj bog! In kaj je žena navedla kot razlog? Zakaj ga je tako brutalno obdelala?  – Pravi, da je njen mož začel hoditi po tleh v hodniku, ki jih je ravno obrisala in se še niso posušila.  – Hudo, res. In? Je prva pomoč že prispela? Ste obdolženko že odvedli na postajo?  – Eeee … nismo ... Ponovno je obrisala tla, pa čakamo, da se posušijo!", "Vunshudiča žena" },
                    { 460, true, 9, "Pri Novakovih se rodi otrok.    Njegova prva beseda je: \"Babica\". Naslednji dan ta umre.    Njegova druga beseda je: \"Dedek\". Ta naslednji dan umre.    Otrokova tretja beseda je: \"Ati\". Ta celo noč ni mogel spati saj je mislil, da bo tudi on umrl.    Zjutraj se zbudi in spozna, da se mu to ni zgodilo. Ves vesel priteče ven in začne kričati: \"Nisem mrtev, nisem mrtev...!\" Žena priteče k njemu ter mu reče: \"TIHO BODI, SOSED JE UMRL!\"", "Preroške besede" },
                    { 407, true, 9, "Pacientka: In doktor, kakšni so rezultati izvidov?   Doktor: Amm, povejte mi najprej, kaj ste po horoskopu?   Pacientka: Rak, zakaj?  Doktor: Oh, kakšno naključje", "Horoskop" },
                    { 324, true, 9, "V Črnobilju pride hčerka do mame in ji reče: \"Mama meni raste tretja dojka, zakaj to?    Mama: \"Kaj jaz vem, boli me kurac!\" ", "Tretja dojka" },
                    { 274, true, 9, "Janezek: \"Mama, mama, našel sem očeta!\"      Mama: \"Janezek, stokrat sem ti že rekla, da ne rovaj po vrtu!\" ", "Vrtičkanje" },
                    { 273, true, 9, "Partizani vkorakajo v hišo, katere lastnica je bila stara žena.    Partizani: \"Hitro mamka, skrijte nas, nemci prihajajo!\"    Star žena jih skrije.    Pridejo nemci. Vprašajo po partizanih a mamka se dela, da nič ne ve. Odrežejo ji eno nogo, a mamka še zmeraj noče povedati. Odrežejo ji drugo nogo. Še zmeraj je tiho.    Nemci odidejo.     Pridejo partizani iz skrivališča smeje: \"Ha mamka, laž ima kratke noge!\" ", "Laž ima kratke noge" },
                    { 264, true, 9, "Sin: \"Mami, jaz pa nimam rad stare mame.\"    Mama: \"Tiho bodi, in pojej do konca!!!\"", "Nima rad stare mame" },
                    { 1763, true, 8, "Po plaži v Fiesi se sprehajajo trije goli črnci. Vsi so od nog do glave črne barve, le eden ima tisto moško zadevo belo.    Vsi jih z začudenjem gledajo, potem se pa le en domačin opogumi, stopi zraven in vpraša: \"Oprostite, kako pa to, da vaš kolega ni v celoti črn? Še nikoli nisem videl črnca z belim tičem\"    \"Ah ne, saj mi sploh nismo črnci. Rudarji iz Velenja smo, ki smo tukaj na počitnicah, kolegu je pa včeraj prišla žena na obisk.\"", "Črnc z belim tičem" },
                    { 1489, true, 8, "V 5. razredu so belec, črnc in Azijec!    Kdo ima najdaljšega tiča?    Črnc!    Zakaj? Zato ker je star 18 let!", "Trije fantje v petem razredu" },
                    { 814, true, 8, "Crnec je ujel zlato ribico, ki mu je, v zameno, da jo izpusti, izpolni tri zelje.   Crnec si zazeli:  1. zelja: Rad bi bil bel.  2. zelja: Vedno bi rad imel veliko vode.  3. zelja: Celo zivljenje bi rad gledal zenske ritke.  In tako je postal straniscna skoljka na zenskem wcju.", "Zlata ribica" },
                    { 345, true, 8, "Zakaj imajo črnci raje belo čokolado?    Da se ne ugriznejo v prste", "Bela čokolada" },
                    { 344, true, 8, "Kdo vozi avtomobil v katerem so 4-je črnci?    Policaj", "Policaj" },
                    { 343, true, 8, "Kdo je belec med 1000 črnci?    Paznik v zaporu", "Zapor" },
                    { 342, true, 8, "Kaj imata skupnega črnec in kolo?    Verigo in gospodarja", "Črnec in kolo" },
                    { 332, true, 8, "Zakaj črnec ko je čokolado mora imeti na rokah bele rokavice?    Zato da se ne ugrizne v roko", "Čokolada" },
                    { 1338, true, 9, "Zakaj je torta na ciganski poroki narejena iz dreka?    Da se muhe ne zbirajo na nevesti.", "Torta na ciganski poroki" },
                    { 1533, true, 9, "Kdaj umirajo sladkorni bolniki?    Takrat, ko jim je najslajše.", "Sladkorni bolniki" },
                    { 1535, true, 9, "V celici v zaporu sta bila skupaj gobavec in narkoman.    Nekega dne, ko so pazniki imeli obhod, je en paznik izgubil ključe malo stran od njunih vrat.    Gobavec se stegne, da bi jih pobral, pa mu odpade roka. Poskusil je z drugo roko in mu je tudi ta odpadla.    Nato je poskusil še z nogo, de bi jih potegnil k sebi, da bi lahko narkoman odklenil vrata in bi skupaj pobegnila. A mu je tudi noga odpadla.    Narkoman stoji v kotu in se smeji: \"Hehehe, staaaari, še malo, pa boš ti zunaj.\"", "Šansa za pobeg" },
                    { 1557, true, 9, "V osamljeni ulici moški sreča prikupno gospodično.    Pristopi k njej in ji reče: \"Imam nož in tiča. Nekaj od tega bom zarinil vate.\"", "Nespodobno povabilo" },
                    { 218, true, 11, "Mož: \"Žena, kaj hudiča počne ta goli moški v moji postelji?!?\"  Žena: \"Čudeže, dragi, čudeže!\"", "Mož zaloti ženo" },
                    { 211, true, 11, "Pride žena domov in zaloti moža v kuhinji, ko na pultu davi purana.    Žena: \"Pusti ubogo žival, kaj delaš?\"    Mož: \"Ne blebetaj, v kuharici lepo piše: purana dušiti 45 minut.\"", "Mož kuha kosilo" },
                    { 170, true, 11, "Babica stara 98 let leži na smrtni postelji in želi se pred smrtjo razkriti 99 letnemu možu, ki sedi žalosten ob njeni postelji, še zadnjo skrivnost.    Gerardo, moj mali Gege, preden bom za vedno zatisnila oči, ti želim razodeti mojo skrivnost. Pojdi na skedenj in pod tretjim stebrom na levi strani strehe, boš našel dve škatlji in jih prinesi. Gerardo gre na skedenj in se po petih minutah vrne noseč v rokah dve skatlji.    V prvi najde tri jajca, v drugi pa 250,000,00 evrov, kar oci se mu razsvetljijo.    Povej mi moja draga, kaj pomenijo ta tri jajca. Ves Gerardo, poročena sva že 78 let, in vsakič ko sva seksala in jaz nisem dosegla orgazma, sem položila v škatljo eno jajco.    Gerardo postane izredno zadovoljen in ponosen, v 78 letih ni uspel zadovoljiti svoje žene samo trikrat, nato pa še vpraša: in kaj pomeni 250,000,00 evrov?    Oh, vsakikrat, ko sem napolnila škatljo z dvanajstimi jajci, sem jih šla prodati na tržnico.", "Pred smrtjo razkrita skrivnost" },
                    { 164, true, 11, "So se dogovorile tri prijateljice, da bodo svojim dragim pripravile presenečenje.    Oblekle so se v sado-mazo črne oprijete usnjene jakne, črne tange, štikle, črne preveze čez oči in vse kar pač zraven paše. Pa da vidijo kaj bo.    Prva je imela ljubimca, druga zaročenca, tretja pa je bila že kar nekaj let poročena. Čez nekaj dni se srečajo.    Tista z ljubimcem: \"Ej stara, ko mej zagledu je čist znoru, je reku da sem ženska njegovega življenja in pol stara, sva sekala ceeellooo noč pa še dopoldne\"    Zaročenka: \"Ja itak, ko me je zagledu me je pograbu pa sva seksala kot mlada zajčka.\"    In tista poročena: \"Ma ja, ko je prišel s šihta, me je najprej vprašujoče pogledal ,potem pa dejal:  \"Hej, Zorro kaj je pa za večerjo??\"", "Presenečenje za moške" },
                    { 163, true, 11, "Sin: \"Ati, ati, kako sem jaz prišel na svet?\"    Oče: \"Jaaa ... veš, štorklja te je prinesla.\"    Sin: \"Uuuu, ati, ti si taki car! Kaj vse si ti nategno!?\"", "Razlaga, kako je prišel na svet" },
                    { 160, true, 11, "Kaj je sreča v nesreči?    Ko ti žena reče, da imaš največjega tiča v domači ulici .....", "Sreča v nesreči" },
                    { 150, true, 11, "Sin vpraša očeta: \"Ati, kako izgleda ženska med nogami?\"    Oče: \"Pred seksom je to dišeče, kot rožica. Lepo je je prav tako. Čudovita reč, ti rečem!\"    Sin: \"Aha, pred seksom. Ja, kako pa zgleda po seksu?\"    Oče se malo zamisli, in reče: \"A si videl kdaj pitbula, ko je jedel majonezo?\"", "Ženski spolni organ pred in po seksu" },
                    { 144, true, 11, "Mami, lahko oblečem mini krilo?  Ne, ne smeš!  Mami, se lahko našminkam?  Ne, ne smeš!  Mami, lahko vsaj salonarje z visoko peto obujem?  Ne, tudi tega ne smeš!  Ampak, mami, saj imam že več kot 18 let.      Vem, Marko, vem.. ", "Lišpanje" },
                    { 142, true, 11, "Žena reče možu: \"Povej mi nekaj, kar me bo osrečilo in razžalostilo hkrati.\"    Mož: \"Naj pomislim ...\"    Žena: \"No, le daj.\"    Mož: \"Tvoje joške so na otip bolj prijetne kot joške tvoje sestre.\"", "Dobre joške" },
                    { 137, true, 11, "Kako mož pomaga pri pospravljanju?    Dvigne noge, da žena lažje posesa.", "Pospravljanje" },
                    { 122, true, 11, "Mož rešuje križanko, žena ga opazuje čez ramo.    Čez nekaj časa mu reče: \"Tule si se pa zmotil, veš...največji tič ... ne pride MOJ ampak NOJ...\"", "Križanka" },
                    { 120, true, 11, "Zvečer se mož in žena odpravita v posteljo.    Mož začne božat ženino nogo in nežno vpraša:  \"Draga, a bova malo ....\"  Žena: \"Ma dragi moj, oprosti, ampak jutri imam pregled pri ginekologu, pa bi rada ostala sveža in čista!\"  Mož se, vidno razočaran, obrne na drugo stran in molči.  A ne mine dolgo časa, ko se ponovno obrne k njej in vpraša:  \"Ali imaš pri zobozdravniku tudi pregled?\"", "Šred spanjem" },
                    { 115, true, 11, "Mož in žena se zjutraj pogovarjata:  \"Dragi, a nama naredim jajčka s šunko? Pa kavico?\"  Mož: \"Ma ne ... to je zarad viagre ... sploh nimam apetita...\"  Potem pride čas kosila:  Žena: \"Dragi, a naredim eno fovš župco, pa un meso lahko spečem, bo hitr narjen\"  mož: \"Ne ... to je zarad viagre ... sploh nimam apetita ...\"  Zvečer, čas večerje:  Žena: \"Dragi, a nama pripravim sendvičke, pa čaj? Bo čist kuj narjen?\"  Mož: \"Ne ... to je zarad viagre ... sploh nimam apetita\"    Žena:\"PA DOBR ČLOVK, ZLEZ ŽE ENKRAT DOL Z MENE, JST UMIRAM OD LAKOTE!!!!!!!\"", "Viagra" },
                    { 102, true, 11, "Pride razjarjen dec v gostilno z dvocevko in zavpije:  \"Kdo je seksal z mojo ženo ???\"    Eden iz množice: \"Stari, imaš pa malo premal metkov !!!\"", "Zajeb na kubik" },
                    { 914, true, 11, "Mož sedi pred televizijo, ko do njega pristopi žena. Prične ga masirati, medtem pa mu šepne na uho: \"Dragi, nekaj ti moram povedati. Kmalu ne bova več sama v hiši … trije bomo!\"    Mož se navdušeno ozre proti njenemu trebuščku, ga poboža ter pravi: \"Ljubica, naj te poljubim. Kako veš?\"    Žena še malo tišje reče: \"Zjutraj me je klicala mami in rekla, da pride na večdnevni obisk\".", "Počasi bodo trije" },
                    { 48, true, 11, "Moška družba se ga je napila in eden sklene, da bo šel v bordel.    Prijatelji mu pravijo: \"Ja, ja, OK!\", vendar sklenejo, da je preveč pijan, in ga odpeljejo domov.    Ker se nočejo zameriti njegovi ženi, ga izkrcajo pred hišo in mu rečejo, naj gre notri sam.    Pozvoni na vratih, odpreta mu žena in hčerka.    On debelo gleda in momlja sam pri sebi: \"Hmm, te kurbe pa od nekod poznam...\"", "Pijanščina in javna hiša" },
                    { 45, true, 11, "Se srečata sedanji in bivši mož žene in bivši vpraša sedanjega: \"Kako je kaj rabljena roba?\"    Mu reče sedanji: \"Do 7cm tako tako, naprej je pa kot nova.\"", "Sedanji in bivši mož" },
                    { 2, true, 11, "Podjetnik pokliče k sebi svojega lenega sina, ki mu ni do ničesar, in mu pravi:   \"Odločil sem se, in ti prepisal 25 % podjetja. Tu imaš papirje.  Kaj bi rad v podjetju počel?\"     \"Ne vem... na tehniko se ne spoznam, od računovodstva mi je slabo, v prodaji se je treba ukvarjati s tečnimi kupci...\"     Oče: \"Torej, česa se boš lotil?\"     Sin: \"Prodaje mojega delaža...\"", "Sin od lastnika podjetja" },
                    { 1760, true, 10, "Kako Dolenjci stopnjujejo  crko š?  Šilce, štamperle, štuc,   štefan, škaf...", "Stopnjevanje" },
                    { 1304, true, 10, "Dolenjca se zbašeta v taksi.    Voznik: \"Do kod?\"    Prvi Dolenjec: \"Do kolodvora!\"    Voznik: \"Saj smo vendar že tukaj!\"    Drugi Dolenjec: \"Tu 'mate denar, drugič pa nikar tako ne divjajte!!!\"", "Hitra vožnja" },
                    { 1130, true, 10, "Zakaj ob polnoci na Dolenjskem zvonijo zvonovi?  Zato da se Dolenjciv postelji obrnejo, ker bi jih cvicek drugace razzrl zelodec.", "Zvonovi na Dolenjskem" },
                    { 1216, true, 38, "Kaj dobimo, če križamo japonca in črnogorca?    Človeka, ki bi rad delal, a se mu ne ljubi vstat.", "Križanje ras" },
                    { 812, true, 38, "Zakaj Crnogorec joce, ko sedi na leseni deski.  Zato ker se je vsedel na zebelj pa se mu ne ljubi vstat.", "Kdaj Crnogorec joka" },
                    { 801, true, 38, "Vprasajo Crnogorca, kaj bi najraje delal pri policiji. Crnogorec odgovori: Bil bi lezeci policaj.", "Crnogorski policaj" },
                    { 351, true, 38, "Kateri prometni znak ne obstaja v Črni Gori?    Delo na cesti", "Prometni znak" },
                    { 350, true, 38, "Zakaj ima Črnogorec dva kamna pod posteljo?    Z enim ugasne luč, z drugim pa preveri če je okno zaprto", "Kamenje" },
                    { 348, true, 38, "Vprašajo Črnogorca kaj si želi biti v drugem življenju?  Kača.  Zakaj pa kača?  Ker ležiš pa se vseeno premikaš naprej...", "Drugo življenje" },
                    { 220, true, 38, "Dva črnogorca, na obali, opazujeta žensko, ki se utaplja.    Prvi: \"Poglej, ženska se utaplja, midva pa tu stojima.\"    Drugi: \"Imaš poplnoma prav! Vsediva se.\"", "Črnogorca gledata utapljajočo žensko" },
                    { 2085, true, 9, "Kaj imata skupnega 14-letna nosečnica in njen plod?  Oba razmišljata: “O šit, moja mama me bo ubila”", "14-letna nosečnica " },
                    { 1913, true, 9, "Mladi fant, zvečer v parku, ogovori mlado gospodično: \"Ali veš, da je drugi najbolj pogost način, da punco pripraviš do tega, da bi seksala s tabo smeh?\"    Punca: \"Ne, nisem vedela. Kaj je pa prvi?\"    Fant: \"Nož!\"    Punca: \"Hi hi hi hi.\"    Fant: \"Pametno si se odločila!\" ", "Ogovoril je neznanko" },
                    { 47, true, 11, "Možakar končno zbere pogum, se odpravi k urologu in prizna: \"Gospod doktor, imam eno veliko težavo. Ob moji ženi ga ne morem več spraviti pokonci. Kaj mi lahko predpišete?\"    Zdravnik trenutek razmišlja, nato pa preudarno odvrne: \"Pridite jutri spet k meni na pregled. S seboj pripeljite tudi ženo.\"    Naslednji dan možakar res pripelje ženo. Zdravnik ji ukaže: \"Gospa, slecite se do golega in lezite na hrbet na mizo.\"    Žena naredi, kot ji zdravnik naroči. Nato zdravnik nekaj minut hodi okrog mize in si jo ogleduje.    Nato potegne \"bolnika\" na stran in mu prišepne: \"Z vami ni nič narobe. Tudi meni se ob njej ne dvigne.\"", "Problemi z erekcijo" },
                    { 111, true, 8, "Kako se reče nigerju v Rusiji?    Nigor.", "Niger v Rusiji" },
                    { 916, true, 11, "Mladoporočenca sta na poročnem potovanju, prispeta na Havaje.     Po nekaj dneh zvečer delata načrt za drugi dan. On bi šel na bazen, ona pa raje na kak izlet po otoku. Beseda da besedo in pride do prvega prepira.      On: \"Če ne bi bilo mojega denarja, midva sploh ne bi bila na Havajih!\"      Ona: \"Če ne bi bilo tvojega denarja, ne samo da MIDVA ne bi bila na Havajih, MIDVA ne bi bila niti na poročnem potovanju, sploh pa ne bi bilo nobenega MIDVA!\"", "Mladoporočenca na Havajih" },
                    { 920, true, 11, "Mož jo ogleduje in reče: \"Moja tajnica ima tudi tako, toda s pet centimetrov globjim dekoltejem. Saj ni veliko, toda poživi!\"    Naslednjič žena kupi novo krilo in ga pokaže možu.     Mož si ga zopet ogleda in reče: \"Moja tajnica ima prav tako krilo, toda deset centimetrov krajše. Saj ni veliko, toda poživi.\"    Zvečer v spalnici opravljata zakonsko dolžnost, ko se oglasi žena:    \"Sosedov Francelj ima tudi takega, toda deset centimetrov daljšega. Saj ni veliko, toda poživi!\"", "Malo, a poživi" },
                    { 1674, true, 11, "Prva: Moj vnuk je čisto nor.    Celo noč sedi pred računalnikom, tolče po tipkovnici, nekaj govori računalniku, telefonska linija ni nikoli prosta, nič ne bo iz njega.    Druga pravi: Oh, moj bo pa zdravnik ali pa pilot, ga nočem vprašati, naj se sam odloči.    Kako veš? vpraša prva.    Lej, vedno ko pridem v njegovo sobo, so injekcije vsepovsod, on pa se mirno obrne k meni in mi reče: Babi, a bi ti tut mal poletela?", "Babici se pogovarjata" },
                    { 1672, true, 11, "Janezek je vprašal očeta: \"Očka, kako težek je moj penis?\"    \"Kakšnih 50 gramov!\"    \"Koliko tehta pa tvoj?\"    \"Moj tehta pa okoli 150 gramov.\"    Nato je Janezek vprašal še dedka: \"Dedek, kako težek je tvoj penis?\"    \"Precej težek mora biti, saj ga babica ne more več dvigniti!\" ", "Teža penisa" },
                    { 1651, true, 11, "Moz rece zeni:  Draga moja, glej, leta in leta  sva v zakonu, pa te nisem se nikoli  vprasal. Daj, povej, koliko jih je   bilo, ko so spali s teboj.  Hja, posteno ti povem...Takole...  Khm...Ena, dva, tri, pa Miha,  Tone...Sedem jih je bilo! Ampak,   toliko, da bos vedel. Ti si  bil pa prvi.", "Sedem" },
                    { 1649, true, 11, "Dedek leži bolan in jamra: \"Joj, otroci moji, tako sem bolan, skoraj bom umrl.\"    Vnuk ga svari: \"Dedek, raje ne, ker potem boš pa spet srečal babico!\"", "Na smrtni postelji" },
                    { 1648, true, 11, "Žena mi je pustila sporočilo na hladilniku: \"To vse skup sploh ne deluje več, sem se preselila k svojim!\"    In sem odprl hladilnik. Lučka dela, pivo je hladno...", "Sporočilo na hladilniku" },
                    { 1645, true, 11, "Punca se prebudi iz narkoze po presaditvi srca.    Pogleda okoli sebe in vpraša po svojem fantu: \"Ati, kje je Mirko?\"    Ata: \"Kako? Kaj ne veš, kdo ti je dal srce?\"    Ona: \"Neeeee! Neeeeeeeeee!!! Joooooj...joooooj....\"    Ata: \"Saj se samo hecam. Scat je šel!!!!\"", "Presaditev srca" },
                    { 1631, true, 11, "Ona: \"Dovolj mi je, da me stalno zajebavaš zaradi moje teže. Zapuščam te!\"    On: \"Tega ne moreš storiti, kaj pa najin otrok?\"    Ona: \"Kakšen otrok?\"    On: \"Aja, sem mislil, da si noseča!!!\"", "Ne more iz svoje kože" },
                    { 1628, true, 11, "\"Ati, s prijatelji gremo ven.\"    \"V tem mini krilu ne greš nikamor! Preobleci se!\"    \"Kaj pa naj oblečem?\"    \"Kakšne hlače ali kaj takega, Marko!\"", "Sobotni večer in treba je na žur" },
                    { 1625, true, 11, "Žena, ki se pozno ponoči po enem tednu vrne s službenega potovanja, tiho odpre vrata spalnice, odgrne pokrivalo na postelji in zagleda štiri noge, ki so molele izpod odeje.    V trenutku se ji zmegli pred očmi, pograbi baseball palico, ki je bila za vrati in prične udrihati po odeji.    Ko se je utrudila, odide v kuhinjo po pijačo, da si malo opomore od šoka.    Tam pa ponovno doživi šok, ko za mizo zagleda svojega moža, ki pije pivo in ji reče: \"Tvoji starši so prišli na obisk za vikend, pa sem jima odstopil najino posteljo. Pojdi ju pozdravit.\"", "Sveža iz dopusta" },
                    { 1595, true, 11, "Špelca se z mamico potepa po mestu.    Ko zaideta mimo gostilne se Špelca oglasi: \"Mami, mami! Tu notri pa diši po očkovem parfumu!\"", "Sprehod po mestu in nenavadna opazka" },
                    { 1593, true, 11, "Sedim, kadim, razmišljam...  Ko sem v postelji z ženo,  neprestano mislim na ljubico in  v mislih ponavljam njeno ime.  Da se ne bi zmotil in naglas  izgovoril imena ljhubice, sem  kupil mačko in ji dal ime po   ljubici.  Danes je prišla domov žena in   prinesla malega psa maltežana.   Dala mu je ime Joza.  Sedim, kadim, in razmišljam...", "Sedim,kadim in razmišljam" },
                    { 1585, true, 11, "\"Kje sta oči in mami?\", vpraša fantek zjutraj babico, ko pride na zajtrk.    \"V postelji sta\", mu odgovori. Fantek se prične hihitati in se odide igrat.    Ko pride na kosilo spet vpraša babico: \"kje sta oči in mami?\"    \"Še vedno sta v postelji\", mu le-ta odgovori.    Fant se zahihita, poje kosilo in se odide igrat.    Ko pa pride na večerjo ponovno vpraša kje je sta starša. In ko dobi enak odgovor, se začne hihitat na vsa usta.    Babica ga začudeno pogleda in vpraša: \"Kaj pa se dogaja s tabo, fant?\"    Deček pove: \"Včeraj zvečer je prišel oče v mojo sobo in me prosil za vazelin, pa sem mu dal sekundno lepilo.\"", "Dobro jo je zagodel" },
                    { 1584, true, 11, "\"Naslednji teden se bom poročila\", se pohvali mlada dama svojim sodelavcem v firmi.    \"Uganite, kaj dela moj mož?\"    Oglasi se eden od sodelavcev: \"Največjo bedarijo v njegovem življenju!\"", "Vesela je, ker se bo poročila" },
                    { 1583, true, 11, "12 letna hčerka je rekla svoji mami: \"V našem razredu je samo ena devica.\"    Mamo skoraj zadane kap. Cela omotična komajda obstoji na nogah.    Hčerka nadaljuje: \"Ostalo so tehtnice, kozorogi, vodnarji, ...\"", "Hčerkica je priznala" },
                    { 1582, true, 11, "Kakšen je popolni zakon?    Takšen, da je žena slepa, mož pa gluh.", "Popolni zakon" },
                    { 1579, true, 11, "Starejša gospa, pri osemdesetih, vendar še precej živahna, vstopi v  lekarno:    - Dober dan, gospod, imate aspirine?    - Da, seveda, gospa!    - Kaj pa analgetike?    - Vsekakor, gospa!    - In antirevmatike?    - Gotovo, gospa!    - Kaj pa Viagro?    - Imamo, gospa, vendar je za viagro potreben zdravniški recept.    - In gel za hemoroide?    - Imamo, gospa.    - Kaj pa kaj zeliščnega za jetra in žolčnik?    - Vsekakor, gospa!    - In antidepresive?    - Imamo, gospa, ampak samo na recept.    - Pa uspavala?    - Ja, ampak že spet potrebujete recept.    - Kaj za izboljšanje spomina?    - Seveda, imamo tudi to.    - In plenice za inkontinenco?    - Seveda, tamle na polici so.    - Kaj pa...    - Poslušajte, gospa, to je najbolje založena lekarna v mestu z  najboljšo ponudbo daleč naokrog. Kaj pravzaprav potrebujete?    - Veste, konec meseca se poročim z Jožetom, ki jih ima petindevetdeset, pa sva želela vedeti, če bi lahko pri vas odprla knjigo mladoporočencev.", "Povpraševanje v lekarni" },
                    { 1578, true, 11, "Ženska pri jutranji kavici bere časopis in ugotovi, da je srečna loto dobitnica. Rekorden dobitek, skoraj milijarda, pripada samo njej.    Vsa srečna gre v službo, direktno v direktorjevo pisarno, da bi dala odpoved, ko ji šef reče, da je vedno manj dela, da je tehnološki višek, se ji opravičuje, ampak jo potolaži, da bo dobila visoko odpravnino.    Tako srečna, se odloči, da si bo kupila nov avto. Vstopi v najbližji avto salon in v tem trenutku nad avto salonom ognjemet, vse bliska v salonu, fanfare.    Pristopi prodajalec in reče: \"Vi ste naš 10 000. obiskovalec. Za nagrado dobite najnovejši model Mercedesa brezplačno\"    Ženska, še v šoku, se z novim avtom odpelje domov. Natoči si kozarec penine, stopi k oknu in vidi, da se je domov pripeljal njen mož.    Mož odvihra v spalnico, spakira svoje stvari in pove ženi, da jo zapušča.    Ženska dvigne kozarec penine in si zamrmra: \"Madona, ko zalaufa, PA ZALAUFA!\"", "Srečnica" },
                    { 1577, true, 11, "Žena pride izpod tuša in šepne možu na uho: \"Dragi, a te nocoj lahko zvežem?\"    Možu takoj začne delovati domišljija, zato takoj privoli. Med tem, ko ga žena trdno veže na posteljo postaja vedno bolj razgret.    Ko žena konča ves razburjen vpraša: \"In kaj zdaj?\"    Žena: \"Nič, lahko noč.\"", "Igračkanje v postelji" },
                    { 1576, true, 11, "Mož piše ženi SMS: \"Padel sem v službi. Zlomil sem si nogo na več mestih. Imam tudi zlomljen kolk. Ana me je odpeljala v bolnišnico.  Zdaj čakam na operacijo ampak zdravnik se boji, da mi bodo morali amputirati nogo.\"    Žena: \"Kdo za vraga je Ana?!?\"", "Poškodoval se je na delovnem mestu" },
                    { 1556, true, 11, "Na kmetiji hčerka prihiti do očeta: \"Ati, ati, hlapec mi je himen pretrgal!\"    Oče: \"Aja? Franček je res neroden, včeraj je grablje zlomil.\"", "Pretrgan himen" },
                    { 1534, true, 11, "Hčerka: \"Mama, noseča sem.\"    Mama jo okara: \"Pa kje hudiča si imela glavo?\"    Hčerka: \"Na havbi, mama, na haubi.\"", "Noseča je" },
                    { 1512, true, 11, "Mož je ženo, svakinjo in taščo povabil na večerjo v ugledno restavracijo. Pristopil je natakar in mož je naročil: \"Jaz bom goveji zrezek v gobovi omaki.\"    \"Kaj pa nore krave?\" ga je začudeno vprašal natakar.    \"One bodo pa kar same naročile.\" ", "V ugledni restavraciji" },
                    { 1506, true, 11, "Mlada ženska se primoži v revno družino.    Ugotovi, da je hiša umazana, pa nikjer nobene krpe za čiščenje zato odreže rokave moževi srajci in počisti stanovanje.    Naslednji dan sklene, da bo prebelila stene, pa tudi čopiča nimajo, zato moževemu očetu Jožetu odreže brado in z njo nanaša barvo.    Naslednji dan pride na obisk sosed in vidi Jožeta na drevesu.    Vpraša ga, če se mu je zmešalo, da pri takem mrazu čepi zunaj na drevesu?    Jože: “Danes bo naša ta mlada palačinke pekla, pa ne vem, če imamo jajca pri hiši!”", "Nova tamlada je od hudiča" },
                    { 1505, true, 11, "Mož je že kar nekaj mesecev v komi, žena mu nenehno stoji ob strani.    Ko se končno zbudi, ji pomigne, naj se mu približa.    Ko se žena usede zraven njega, ji reče: \"Veš kaj, z menoj si bila skozi vse slabe čase. Ko sem bil odpuščen, si me podpirala, ko mi je propadel posel prav tako, ko sva izgubila hišo si še vedno stala ob meni, ko mi je začelo pešati zdravje, prav tako. Veš kaj, draga?\"    \"Kaj, srce?\", ga vpraša nežno.    \"Mislim, da mi prinašaš smolo.\"", "Mož obleži v komi" },
                    { 1504, true, 11, "Oče sedi v kavču in uživa ob gledanju nogometne tekme, njegovemu mulcu pa je bilo neizmerno dolgčas, zato ga je kar naprej neuspešno nagovarjal.    Nakar mali nenadoma reče: \"Oči, če mi daš 10€ ti povem kdo spi z mami v vajini postelji medtem ko te ni doma.\"    Končno je zadel na pravo točko pri svojem starem in ta se je nemudoma ves razjarjen obrnil k njemu in mu rekel: \"Mulc, tu imaš 50€, pa da mi takoj po resnici poveš.\"    Mali prešteje denar, potem pa ves nasmejan: \"Jazzzzz spim pri njej, ko te ni\"", "Kdo spi z mamo" },
                    { 1483, true, 11, "Mož brez žene je kot pes brez bolh.    Živi, ampak dolgočasno.    ​​    Žena brez moža je kot bolha brez psa.    Živi, ampak nima nikogar za žret.", "Mož in žena, oh kako lepo" },
                    { 1479, true, 11, "Metka iz spalnice: \"Mami, mami! Ali je človek res prah in v prah se povrne?\"    \"Ja, tako uči krščanska vera. Zakaj me to sprašuješ?\"    \"Če je vse to res, je pod našim kavčem najmanj pet mrtvih.\"", "Otroško razmišljanje" },
                    { 1478, true, 11, "Žena je opazovala moža pri jedi in ga vprašala: \"Kako ti je kaj všeč moje kosilo?\"    Mož je samo pokimal z glavo in jedel naprej, žena pa je dejala:    \"Moja mama pravi, da obe jedi, ki jih znam pripraviti, jagodni kolač in morsko solato, pripravim res zelo okusno!\"    Mož je nenadoma dvignil pogled od krožnika in vprašal: \"In kaj od tega zdaj jem?\" ", "Pri kosilu" },
                    { 1473, true, 11, "Mici je hotela poklicati moza pa se ji je spraznila baterija na mobilniku, zato je prosila sina naj poklice oceta. Sin Janezek je poklical:\"Mami, klical sem trikrat in se je vedno oglasila neka zenska.  Ko moz pride domov, ga zena pricaka pri vratih in mu prisoli zausnico.   Moz zacudeno:\"Zakaj pa zdaj to?\"  Zena:\"Janezek pravi, da se na tvoj telefon oglasa zenska. Kdo je?\"  Moz:\"Janezek, potem pa povej, kaj je rekla!\"  Janezek:\"Stevilka trenutno ni dosegljiva, prosimo poklicite kasneje.\"", "Prazna baterija" },
                    { 1676, true, 11, "- Mama, z možem sva se na smrt sprla.    - Hčerka moja, to se dogaja v vsakem zakonu.    - Potem mi pa povej, kam naj skrijem truplo.", "Sprla sta se" },
                    { 1472, true, 11, "Marta se vrne domov in Kosirju   zabrusi:  Bila sem pri jasnovidki.  Placala sem ji 50 evrov in povedala  mi je, da me ne ljubis vec!   Kosir: Neumnica,to bi ti jaz lahko   povedal brezplacno.", "Neumnica" },
                    { 1678, true, 11, "- Po desetih letih zakona greva z ženo ponovno na medene tedne.    - No, to je pa res romantično. Kdaj pa gresta?    - Jaz avgusta, ona pa oktobra.", "Še eni medeni tedni" },
                    { 1686, true, 11, "Mama vpraša sina: \"Zakaj jočeš?\"    Sin: \"Ati se je udaril po prstu s kladivom!\"    Mama: \"In zakaj se ti zdaj jočeš zaradi tega?\"    Sin: \"Hja, saj najprej sem se smejal.\"", "Sinek se joče" },
                    { 1839, true, 11, "Pokoplje mož ženo in uredi vse potrebno na pokopališču.     Ko pride domov se ulije, utrga se oblak, grmi, strele švigajo povsod,...     Pogleda mož  v nebo in reče: \"Evo, je že gor!\"", "Žena mu je umrla" },
                    { 1837, true, 11, "Mami mami, a ti je oči kupil to lepo obleko?    \"Ne sinek, če bi nanj čakala, tudi tebe ne bi imela.\"", "Nova obleka" },
                    { 1833, true, 11, "\"Draga, jutri bova pa uživala! Kupil sem tri vstopnice za gledališko predstavo!\"    \"Tri? Zakaj pa tri?\"    \"No, ja ... eno za tvojega očeta, eno za tvojo mamo in eno za tvojega bratca!\" ", "Vstopnice za gledališko predstavo" },
                    { 1831, true, 11, "Žena pride v nebesa in išče svojega moža.    Sveti Peter jo vpraša, koga išče in ko mu razloži, doda: \"Rekel mi je, da se lahko za vsakokrat, ko me je prevaral, obrne v grobu!\"    \"Aja, tega mislite! Pri nas ga imamo za ventilator!\" ", "V nebesih išče moža" },
                    { 1830, true, 11, "Ginekolog vprašal pacientko: \"Imata z možem urejeno spolno življenje?\"    \"Jaz ga imam, za moža pa ne vem!\" ", "Pri ginekologu" },
                    { 1825, true, 11, "\"Dragi, kaj ti ne nameravaš skleniti življenjskega zavarovanja?\"    \"Tega pa ne! Moj znanec že trideset let plačuje pa še vedno ni umrl!\"    \"Morda boš pa ti imel več sreče!\" ", "Življensko zavarovanje" },
                    { 1822, true, 11, "\"Si že slišal, da je Dušanu žena pobegnila z najboljšim prijateljem?\"    \"Verjetno je zdaj zelo osamljen!\"    \"Res je. Pravi, da prijatelja zelo pogreša.\" ", "Pobegnila je" },
                    { 1821, true, 11, "Žena možu šepeta na uho: \"Dragi, kmalu bomo trije.\"    \"Kaj res?\" veselo vzklikne mož.    \"Ja, moja mama se bo preselila k nama.\" ", "Ni ravno tako, kot se sliši" },
                    { 1818, true, 11, "\"Imaš zdaj kaj drugačno življenje kot prej, ko si bil še samski?\" je Polde vprašal prijatelja, ki se je pred kratkim poročil.    \"Samo v čevljih je razlika.\"    \"Kako? V čevljih?\"    \"Ja. Prej sem jih imel vedno v predsobi, zdaj pa jih, če prepozno pridem domov, dobim v glavo.\"", "Poročil se je" },
                    { 1815, true, 11, "\"Si slišala, da je Petri umrl mož?\"    \"Ja, sem. Koliko časa se je pa mučil?\"    \"Ne dolgo. Poročena sta bila šele dve leti.\" ", "Pobralo ga je" },
                    { 1774, true, 11, "Mala Barbara je zlezla k mamici v posteljo in ji rekla: \"Mami, povej mi kakšno pravljico za lahko noč.\"    Mama: \"Počakaj, da se vrne očka, pa jo bo povedal obema!\" ", "Pravljica za lahko noč" },
                    { 1767, true, 11, "Bodoča mamica v porodnišnici vpraša ginekologa: \"Je moj mož lahko prisoten ob porodu?\"    Doktor nima nič proti: \"Seveda, mi celo spodbujamo, da so očetje poleg.\"    \"Potem pa nič! Veste, onadva ne prenašata drug drugega preveč dobro.\" ", "Rodila bo" },
                    { 1765, true, 11, "Žena je obiskala moža v zaporu in mu potarnala: \"Otroci kar hitro odraščajo. Vedno večji so in že so začeli praševati!\"    \"Po meni?\"    \"Ne! Sprašujejo kam si skril denar!\"", "Žena obišče moža v zaporu" },
                    { 1762, true, 11, "\"Že zelo dolgo nisem videl tvojega očeta!\"    \"Žrtev znanosti je postal.\"    \"Kaj? Operacija?\"    \"Ne, prstni odtisi.\" ", "Oče in znanost" },
                    { 1759, true, 11, "Oce zagrozi sinu:  Ce se ne bos resno lotil  studija, bos sel delad.  Sin pa se zasmeji:  Haha, oci. Kam pa?", "Prazne groznje" },
                    { 1742, true, 11, "\"Dve leti sva bila srečno poročena, zdaj pa je neznosno!\" reče žena svojemu odvetniku.    \"In zakaj se je, po vašem mnenju, zakonsko življenje tako grozno spremenilo?\"    \"Mož je pustil delo v tujini in se vrnil domov.\" ", "Kar naenkrat so se pojavili problemi" },
                    { 1733, true, 11, "Mama se prijateljici pritožuje nad svojo odraščajočo hčerko: \"Današnja mladina je grozna! Samo mojo hči poglej! Petnajst let je stara pa ima že resnega fanta, na moj devetindvajseti rojstni dan je pa čisto pozabila!\" ", "Mladina je pokvarjena" },
                    { 1727, true, 11, "Desetletni Jure je prišel domov ves raztrgan in mama se je razjezila: \"Kaj misliš, da ti bom vsak teden kupovala nova oblačila?\"    \"Bodi vesela, da je tako!\" je odgovoril sin. \"Sosedje bodo morali kupiti novega sina, ker sem mu pošteno preštel rebra!\" ", "Ves razcapan" },
                    { 1717, true, 11, "Sin profesionalnega nogometaša se je zadnji dan pouka vrnil domov in oče ga je vprašal:\"No, kako je kaj s tvojim spričevalom?\"    \"Odlično! Vsi v razredu morajo zamenjati razred, le meni so podaljšali pogodbo.\" ", "Sin nogometaša v šoli" },
                    { 1714, true, 11, "Janez pride k zdravniku in  pravi:  Z zeno imava probleme s seksom.  Videti je, da imam premajhen   penis. Zdravnik ga vprasa:  Kaj najrajsi pijete?  Pivo.  Kaksno?  Zlatorog.  Za svetlo pivo so raziskave  pokazale, da stvari krcijo.  Pijte rajsi temno pivo.  Janez se cez mesec dni prismeji  k zdravniku:  Hvala, zdaj je vse v redu.  Ali pijete temno pivo?  Da. Zeno pa sem navadil na   zlatorog.", "Svetlo pivo" },
                    { 1713, true, 11, "Stefan se je sprehodil skozi  sadovnjak, ravno v tistem trenutku  pa je bil potres.  Zena se nagne skozi okno in mu   zacne vpiti:  Stefan, potres, potres!  Kaj bom tresel jablano. Saj  vendar vidis, da je cisto suha.", "Potres" },
                    { 1709, true, 11, "Barbara in Suzana se vračata iz diskoteke. Že zdavnaj je odbila polnoč.    Barbara se ozre k prijateljici in reče: \"Kako zelo si zdajle želim, da bi bila miška!\"    \"Zakaj pa miška?\" se začudi Suzana.    \"Ker se moja mami miši zelo boji.\" ", "Situacija ni zavidljiva" },
                    { 1708, true, 11, "\"Se spominjaš, da si bil pred pol leta na ribolovu?\" je žena vprašala moža.    \"Seveda se spominjam! Odličen ulov je bil!\"    \"Klicala te je riba, ki si jo ulovil! Pričakuje male ribice!\" ", "Uspešen ribolov" },
                    { 1706, true, 11, "\"Kako lepe zobe imate, gospodična!\"    \"Hvala, podedovala sem jih po mami.\"    \"Potem je pa še dobro, da so vam prav.\" ", "Pohvali lepe zobe" },
                    { 1701, true, 11, "Mihec bere knjigo. Ko mami   vidi naslov knjige, ga vprasa:  Mihec, zakaj beres knjigo o   vzgoji otrok?  Nadziram vaju, ali me pravilno  vzgajata.", "Vzgoja" },
                    { 1695, true, 11, "Marta rece Kosirju:  Ves kaj, ko zjutraj spijeva kavico,  me tako pozivi, da se pocutim vsaj  dvajset let mlajso.  Kosir odvrne:  Ce je pa tako, se kaksno spij, preden  greva spat.", "Kavica" }
                });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "Id", "Active", "CategoryId", "Description", "Title" },
                values: new object[,]
                {
                    { 1694, true, 11, "Mož gre sredi noči na stranišče. Ko se vrne, zbudi ženo in ji reče: \"Nekaj čarobnega se je zgodilo! Šel sem na stranišče in se je luč  sama od sebe prižgala, ko sem končal, pa je sama od sebe  ugasnila. Čarovnija!\"    Žena mu odgovori: \"Nobena čarovnija, kreten! Spet si se v hladilnik poscal!\"", "Čudež" },
                    { 1690, true, 11, "\"Ati, zakaj se zemlja vrti?\"    \"Kako hudiča vrti? Sine, a si ti kaj stikal po moji omari, kjer imam skrit viski?\"", "Pravi geograf" },
                    { 1689, true, 11, "Kaj je rekla tvoja huda žena, ko si zadnjič prišel šele zjutraj domov?    Rekla ni nič, ampak dva polomljena zoba sem vseeno moral dat izpulit.", "Ponočevanje in posledice" },
                    { 1679, true, 11, "Trgovski potnik sprašuje gospodinjo: \"Bi morda kupili spalno vrečo?\"    \"Ne, hvala, jo že imam. Pred desetimi leti sem se z njo poročila.\"", "Ponudba" },
                    { 1467, true, 11, "Zena pravi mozu: Najin sin je zelo inteligenten. Pamet je prav gotovo podedoval po meni.   Moz: S tem se pa strinjam, meni je pamet ostala.", "Pamet" },
                    { 1464, true, 11, "Mimoidoci pred hiso vprasa fantka:\"cigav pa si, fantic?\"  \"Midva z ockom ne vema, mamica pa noce povedati!\"", "Kdo je oce" },
                    { 1460, true, 11, "Sinko, mamica mi je povedala, da danes nisi bil priden.   Ves, oci, jaz mislim, da ima mamica nekaj proti nama. Danes je mene zatozila tebi, vceraj pa je pri babici tebe opravljala.", "Speckahla" },
                    { 1137, true, 11, "Mati hcerki: Lepoticka moja, si se  ze odlocila, kaj mora biti tvoj  bodoci moz po poklicu?  hcerka odgovori: Politik, vendar.  Mati zacudeno: On pa ja samo brez   veze govori.  Hcerka pomembno: Ja, med sluzbenim  casom res brez veze govori, doma  pa, hvala bogu, molci.", "Politik" },
                    { 1117, true, 11, "Marta svojemu Kosirju:  Povej mi posteno.  Me ljubis samo zato, ker mi je  stric zapostil pravo bogastvo?  Kosir:Ne, ljubil bi te tudi, ce  bi ti bogastvo zapostil gdo  drugi.", "Bogastvo" },
                    { 1104, true, 11, "Ostareli parcek lezi v  postelji.  Ona: Vcasih si me nezno pobozal,   preden sva zaspala.  On se obrne, jo poboza po rami in   hoce zaspati.  Takrat spet ona: Nato si me nezno  poljubil...  On se dvigne, ji da poljupcek na   lice ter se obrne, da bi saspal.  Pa mu se ne da miru:  Potem si me grizljal po vratu.  On jezno vstane in odkoraka iz  spalnice.  Ona: Ja, kam pa gres?  On sikne: V kopalnico po zobe!", "Starejsi par" },
                    { 1092, true, 11, "Moz pride v trgovino in mlado trgovko prosi za pomoc.   \"Rad bi kupil darilo za zeno. Mi lahko pomagate?\"  \"A je lepa?\"  \"Ne prevec.\"  \"A je mlada?\"  \"Je ze v letih.\"  \"Je bogata?\"  \"Ne, ni.\"  \"No, potem vam svetujem, da darilo kupite kateri drugi!\"", "Darilo" },
                    { 1090, true, 11, "Gostje pridejo v hiso. Mihec opazuje strica, ki si prizge cigareto.  Stric:\"Mihec, ali ti ze kaj kadis?\"  Mihec:\"Ce jo dobim, jo pokadim!\"  Oce nato odgovori:\"Pravilno je, ce jo pokadim, jih dobim!\"", "Gostje v hisi" },
                    { 1088, true, 11, "Polde in Pepca sta po dalsem   casu znova v spalnici.  Ko opravita, je on po mosko  radoveden:  Povej mi, draga, kaksen sem v postelji?  Se vedno dober?  Pepca: Si kot vulkan.  Polde: Uf, to pa je lepo slisati.  Tako vroc, tako eksploziven, kajne?   Pepca:Ne, ne, aktiviras se na  vsakih 5 do 7 let.", "Vulkan" },
                    { 1082, true, 11, "Marta se odpelje v Celovec in v Ikei kupi omaro.    Doma jo sama sestavi, a kaj, ko omara takoj, ko mimo pripelje avtobus, ob tresenju razpade.    Besna pokliče v trgovino, od koder ji na pomoč pošljejo delavca montažerja. Ta se loti posla in v pol ure je omara znova sestavljena.    A ker je natančen, hoče preveriti, kaj se bo zgodilo, ki mimo znova pripelje avtobus.    Stopi v omaro in čaka.    Takrat se doma nenadoma pojavi Košir. Ne more verjeti svojim očem, gleda delavca v omari, gleda ženo, lovi sapo, Marta ga prehiti: \"Ne boš verjel, čaka na avtobus ...\"", "Nakup nove omare" },
                    { 1074, true, 11, "Prodajalec ji pokaže čudovito araro: \"Vam je všeč, gospa?\"    Marta: \"Res je lepa, a nisem zadela na lotu. Ne morem si je privoščiti.\"    Prodajalec obljubi, da ji jo bo dal po polovični ceni, ker je živela v bordelu in ima zelo sočen besednjak.    Marta je zelo navdušena in takoj sklene kupčijo.    V varnem zavetju novega doma pernato bitje ni dolgo tiho: \"Hej, nov bordel in nova madam!\"    Marta nazaj: \"To ni bordel in jaz nisem madam, jasno?\"    Čez eno uro pride domov hčerki, in papiga takoj: \"Hej, nov bordel, nova madam in nove kurbe!\"    Hčerki užaljeno pokarata papigo, a se sprijaznita z novo pridobitvijo.    Popoldne se iz službe vrne Košir. Papiga ga zagleda in zavrešči: \"Hej, nov bordel, nova madam, nove kurbe pa iste stranke. Kak se maš, Košir?\"", "Marta kupuje papigo" },
                    { 1071, true, 11, "Košir: \"Draga, danes sem povabil Janeza na kosilo.\"    Marta: \"Si znorel, norec blesavi!?! Bajta je razmetana, kopalnica ni očiščena, včerajšnja posoda še ni pomita, jaz pa tudi ne bom ne vem kaj kuhala! Le zakaj si ga povabil?\"    Košir: \"A veš, da revež razmišlja, da bi se oženil.\"", "Nenadno povabilo" },
                    { 1069, true, 11, "Košir v enem zamahu prebere knjigo Bodi gospodar v svoji hiši.    Primerno opogumljen stopi v kuhinjo do Marte: \"Vedi, da sem jaz gospodar te hiše in, da je moja beseda poslej vselej zadnja! Danes boš skuhala večerjo, ki ti jo bom jaz naročil, zatem spekla moje najljubše kolače, potem greva za eno uro v spalnico. Po seksu me mora čakati brezova kopel, na obešalniku pa sveža pižama. Postrigla mi boš še nohte na rokah in nogah ter zmasirala stopala. Le uganeš lahko, kdo me bo po vsem tem še počesal...\"    Marta še tisto sekundo: \"Nekdo iz pogrebnega zavoda.\"", "Gospodar v svoji hiši" },
                    { 1062, true, 11, "Marta in Kosir srkata popoldansko  kavo.  Marta zlepa:  Povej prosim posteno, kaksne zenske  imas rad.  Pametne ali lepe?  Kosir brez premisleka:  Ne enih ne ndrugih.Dobro ves, da  imam rad samo tebe!", "Imam rad samo tebe" },
                    { 1059, true, 11, "Mož: \"Žena! Ti prideš k meni le takrat, kadar rabiš denar!\"    Žena pravi: \"Dragi! A to ni dovolj pogosto?!\" ", "K njemu pride" },
                    { 1042, true, 11, "Policist zaslisuje Janezeka:  Kje stanujes?  Pri starsih.  Kje pa oni stanujejo?  Pri meni.  Kje torej zivite vsi?  Vsi skupaj zivimo v hisi.  Kje je vasa hisa?  Zraven sosedove.  ", "Zaslisevanje" },
                    { 1036, true, 11, "Kje pa dela tvoj moz?  V pivovarni.  Ze dolgo?  Slab mesec.  Pa mu ugaja?  Pojma nimam.  Ga se ni bilo domov.", "Pivovarna" },
                    { 1031, true, 11, "Medvedek:Mami,a sem jaz medvedek?  Ona:Ja,seveda.  Mali:Mami,a sem jaz res medvedek?  Mati:Si,sine,si.  Medvedek:Pa sem cisto zares medvedek?  Ona nejevoljno:Ja,seveda,zakaj pa ne bi bil?  Malcek:Zato,ker me zebe kot psa!", "Medvedek" },
                    { 1008, true, 11, "Kosir se slabo pocuti in  rece Marti:  Prosim,poklici mi veterinarja.  Ona:A mislis zdravnika?  Kosir:Kaj mi bo zdravnik?  Delam kot konj,zivim kot pes,  spim s kaco...", "Veterinar" },
                    { 1007, true, 11, "Bucek pise domov iz internata:  Dragi starsi!  Ze dolgo nimam nobenih vesti  od doma,prosim,posljite mi  dvajset evrov,da bom vedel,da  vam gre dobro.", "Dvajset evrov" },
                    { 999, true, 11, "Kosir Marti:  Daj,vstani,poglej,kako lep dan je.  Ona:Pusti me spati,saj vidis,da  sem utrujena.  On se ne da:Vstani,no.  Poglej,kako lep dan je.  Marta spet:Daj mi mir,jaz bi se spala.  Kosir vstraja:Res je lep dan,  vstani,no.  Marta:Pa kaj potem,ce je lep dan.  Jaz bi spala.  Kosir:Kaj nisi nrekla,da bos nekega  lepega dne sla?", "Lep dan" },
                    { 988, true, 11, "Gospod doktor, težave imam s spanjem, saj nikakor ne morem zaspati!  \"Čisto počasi štejte do tisoč, pa vas bo zmanjkalo.\"  Čez nekaj dni se je pacient ponovno oglasil pri doktorju.  \"No, je štetje pomagalo?\"  \"Sploh ne. Ko sem preštel do petsto sem bil tako zaspan, da sem si moral skuhati kavo, da sem lahko štel naprej do tisoč.\"", "Nespečnost" },
                    { 982, true, 11, "Kako se u familiji stopnuje beseda slab?  slab  slabši  tak k fotr", "Stopnjevanje v družini" },
                    { 980, true, 11, "Sin: \"Ata, kupi mi Iphone.\"  Ata: \"Ja pa ja. Reci čarobno besedo!\"  Sin: \"Majda.\"  Ata: \"Kakšna Majda?\"  Sin: \"Tvoja ljubica.\"  Ata: \"Kateri model?\"", "Ljubica in sin" },
                    { 974, true, 11, "Rekla mi je, da sem zanjo tisto, brez česar rože ne morejo živeti.  Kasneje sem izvedel, da je to gnoj.", "Zaljubljen par" },
                    { 968, true, 11, "Marta in Kosir sta na smrt skregana.  Brez besede se vozita kilometre,  naposled le prispeta k sorodnikom  na dezelo.  Zagledata, kako se par svinj valja  po blatu.  Tvoji sorodniki? zajedljivo   vprasa Marta.  Kosir odvrne:Ja,tast in tasca.", "Sorodniki" },
                    { 965, true, 11, "Mali Toncek sedi ob cesti   in joka.  Mimo pride gospod in socutno   vprasa:Kaj je,dete,zakaj jokas?  Kaj ne bi.  Umrla mi je mama.  Neznanec:Poklicem duhovnika?  Toncek:Ne,nikakor,zdaj mi pa res  ni do meckanja.", "Mali Toncek" },
                    { 963, true, 11, "Pri Kosirjevih je vihar.  Marta maha po mozu,on se  skrije pod mizo.  Marta besno:  Zlezi ven,sicer bom razbila  se mizo!  Kosir iz varnega zavetja:  Jaz sem gospodar te hise in  bom tam,kjer bom sam hotel.", "Gospodar" },
                    { 958, true, 11, "Direktorjeva žena je želela presenetiti svojega moža in ga je obiskala v njegovi pisarni.  Ko vstopi vidi, da mu na krilu sedi tajnica.    Mož brez obotavljanja: \"Šparamo, ali ne šparamo upam, da vidite, da samo z enim stolom ne moremo normalno delati!\"", "Obisk v pisarni" },
                    { 945, true, 11, "Luka iz cerkve,kjer je bil  pri spovedi,prijoka domov.  Mama ga vprasa:  Ja kaj pa je?  Zupnik mi je narocil,naj  zmolim tri ocenase,jaz  znam pa samo enega.", "Ocenas" },
                    { 930, true, 11, "Kaj v zakonu pomeni delitev obveznosti na 50:50?   Zenske kuhajo, moski jedo,   zenske cistijo, moski umazejo,  zenske likajo, moski meckajo!", "50:50" },
                    { 925, true, 11, "Jure je prišel s potepanja s prijatelji prepozno domov. Pred vrati ga je pričakal oče in se razjezil: \"Obljubil si mi, da boš ob osmih doma!\"     \"Ja, očka, res sem obljubil\"     \"Jaz pa sem ti obljubil, da boš tepen, če boš zamudil!\"     \"Ja, res je, očka! Ampak če jaz nisem držal besede, je tudi tebi ni treba!\"", "Prepozno je prišel domov" },
                    { 1140, true, 11, "Žena možu, nejevoljno: \"Saj to ni res! Zdaj, ko sem s tabo samo še kuham, perem, likam, ribam in brišem!\"    Mož: \"Vidiš, sem ti rekel, da ti bo z mano, kot v pravljici!\"    Žena še bolj jezno: \"Kako to misliš?\"    Mož: \"Si kot Pepelka.\"", "Žena se pritožuje" },
                    { 1194, true, 11, "Mata se obrne k Kosirju:  Dragi, jutri je obletnica  najine poroke.  Ali zakoljeva kokos?  Kosir nazaj:  Le zakaj? Saj kokos ni nic  kriva!", "Kokos" },
                    { 1208, true, 11, "Zdravnik je vprašal ženo: \"Kako, da niste opazili, da je vašega moža infarkt?\"    \"Saj je bilo res nekaj čudnega! Po dvajsetih letih mi je spet enkrat rekel: Žena, moje srce!\"", "Pri zdravniku" },
                    { 1210, true, 11, "Zena:Ce mi za 8. marec  ne bos nic kupil, mi vsaj  reci, da sem lepa.  Moz: To bom naredil 1. aprila.", "8. marec" },
                    { 1458, true, 11, "Mati nadere svojo hcerko: \"Ko sem bila jaz stara 25 let, sem bila ze porocena!\"  \"Ja, ampak ne zaradi ateje, ampak po moji zaslugi!\"", "Poroka" },
                    { 1428, true, 11, "S petimi težkimi kovčki sta zakonca zadnji čas prispela na letališče.    \"Škoda, da s seboj nisva vzela še klavirja!\" je rekel mož.    \"In kaj naj to pomeni?\" se je začudila žena.    \"Na klavirju sta ostali najini letalski vozovnici!\"", "Odšla sta na potovanje" },
                    { 1423, true, 11, "Sin sreča očeta v javni hiši.    \"Ja očka, kaj pa ti tukaj?\"    \"Ah, zaradi sto evrov pa res nisem želel zbuditi mame.\"", "Srečanje" },
                    { 1420, true, 11, "Sinko, se ti drogiras?  Ne, zakaj mislis, da se?  Pticka mi je povedala!  Ti se pogovarjas s ptici,  potem pa pravis, da se jaz  drogiram?", "Droga" },
                    { 1321, true, 11, "On: \"Če bi ne imela nog, ali bi si kupila čevlje?\"    Ona: \"Seveda ne!\"    On: \"Zakaj si potem kupuješ modrček?\"", "Mož in žena v trgovini" },
                    { 1310, true, 11, "Mož in žena ležita na kavču in gledata boks.    Mož: \"Kako dolgočasno! Vse se je končalo v dveh minutah.\"    Žena: \"Hja, no, zdaj vidiš, kako je meni!\"", "Gledata boks" },
                    { 1307, true, 11, "\"Jej, jej! Kako lepega sina imaš!\"    \"Ja, lep je. Tak je kot njegov očka!\"    \"Po čem pa to sklepaš?\"    \"Takoj ko mu vzamem stekleničko, se začne dreti na vse grlo!!!\"", "Tak, kot oče" },
                    { 1306, true, 11, "\"Mici, tvoj mož France se je očitno poboljšal. Videla sem, da je včeraj kar precej zgodaj šel iz gostilne.\"    \"Nič se ni poboljšal!\"    \"Kaj pa se je potem zgodilo?\"    \"Zmanjkalo mu je denarja.\"", "Poboljšal se je" },
                    { 1302, true, 11, "\"Joža, a me imaš ti sploh kaj rad?\"    \"Micka. Če na tem svetu ne bi bilo nogometa, televizorja in alkohola, bi ti bila za mene najpomembnejša stvar na tem svetu!!!\"", "Hotela se je prepričati" },
                    { 1298, true, 11, "Oče in sin, oba Gorenjca, gresta na trg. Oče si nekaj časa ogleduje kravo, jo otipava.    Sin to gleda in vpraša: \"Očka, kaj pa delaš?\"    \"Morali bomo kupiti eno, pa se hočem prepričati, da bo dobra in vredna svojega denarja.\"    Čez nekaj dni, ko se oče vrača s polja, mu sin pride nasproti in reče: \"Očka, kmalu se bomo znebili mamice!\"    \"Zakaj?\"    \"Ko te ni bilo doma, si jo je ogledoval in otipaval sosedov Joža. Morda jo bo pa kupil!!!????\"", "Nakup krave" },
                    { 1296, true, 11, "Štiri žene modrujejo: \"Moj pride iz gostilne po enem vrčku piva.\"    \"Moj po dveh.\"    \"Moj po treh.\"    \"Moj pa običajno po vseh štirih!!!\"", "Ženska debata o moških" },
                    { 1282, true, 11, "\"France, zakaj v gostilno vedno prideš v tej stari oguljeni obleki?\"    \"Ker je žena rekla, da z mano ne bo šla nikamor, dokler se bom tako oblačil!\"", "Vedno se isto oblači" },
                    { 1279, true, 11, "Zvečer v postelji.    Žena: \"Obrila sem si muco, ali veš, kaj to pomeni?\"    Mož, nejevoljno: \"Vem, hudiča! Vem! To pomeni, da je odtok spet zamašen.\"", "Obrila si je muco" },
                    { 1278, true, 11, "Žena: \"Najin sin je zelo inteligenten, zagotovo je dobil pamet od mene!\"    Mož: \"Se strinjam, meni je pamet ostala.\"", "Podedovanje pameti" },
                    { 919, true, 11, "Vinko se je odločil, da se bo ločil od svoje žene Polonce. Njena mati jo je vprašala: \"Polonca, pa si res poskusila vse, da bi ga prepričala, da ostaneta skupaj?\"     \"Vse, mama, vse! Niti en krožnik ni ostal cel!\"", "Preprečila bi ločitev" },
                    { 1277, true, 11, "Babica in dedi se odlocita,   da bo on preiskusil viagro.  Ona zvecer leze v posteljo,  dedi pa pride do vrat spalnice  in potrka. Ona vprasa:  Zakaj pa trkas?  Ne vprasa se, zakaj, ampak  s cim trkam.", "Trkanje" },
                    { 1271, true, 11, "Kosir se zacuda spomni obletnice  poroke in Marto preseneti z darilom.  In to kaksnim! Podari ji zlato  zapestnico.  Marta kar ne more verjeti.  Nejeverno vprasa: Ali je zapestnica   cisto zares iz pravega zlata?  Kosir: Seveda je! Ce ni, so me  nategnili za 10 evrov!", "  Obletnica poroke" },
                    { 1268, true, 11, "Žena pošlje moža na tržnico, naj kupi kilogram polžev, da bodo imeli za kosilo francosko specialiteto.    Mož se odpravi na pot, vendar na poti iz tržnice sreča prijatelja, ki se že dolgo nista videla. Po kratkem pogovoru zavijeta v bližnjo gostilno in se ga napijeta.    Pozno zvečer se mož z vrečko polžev vrne domov pred vhodnimi vrati zloži polže na tla in pogumno pozvoni.    Žena vsa razjarjena odpre  vrata  in  še  preden  odpre  usta, mož pogleda polže in reče: \"No pojdite polžki moji, že tako smo pozni!\"", "Poslala ga je kupiti polže" },
                    { 1263, true, 11, "Mama se dere na Bucka:  Le kako si lahko spet dobil  cvek?  Bucko nazaj: Preprosto, uciteljica   je spet sprasevala.", "Cvek" },
                    { 1262, true, 11, "Marta! zaklice Kosir, ko se   vrne iz sluzbe.  Danes sem bil v zavarovalnici in  sklenil zivljensko zavarovanje  za 150.000 evrov!  Marta: Super! Zdaj ti vsaj ne bo  treba vec za vsako malenkost  hoditi k zdravniku.", "Zavarovanje" },
                    { 1258, true, 11, "Rudi seka drva in k njemu   pride zena;  Ali te zanima, koliko sem vceraj  zapravila po nakupih?  Lepo te prosim, ne zdaj, ko  imam sekiro v rokah.", "Sekira" },
                    { 1256, true, 11, "Zena poslje mozu SMS sporocilo:  Danes imam rojstni dan.  On ji odgovori:  Joj draga, ti pa res na vse   mislis.", "Rojstni dan" },
                    { 1254, true, 11, "Mama se zelo boji za nedolznost  svoje osemnajstletne hcere in v  pogovuru rece prijateljici:  Ves Lizika, ce tako pomislim,   se mi otrok kar smili. Pri teh  letih, pa bi ze igrala posteljne  igrice. Bi bila najraje kar sama  na njenem mestu.", "Nedolznost" },
                    { 1253, true, 11, "Po opravljenem delu, na poročno noč, se mladoporočenca odpravita spat.    Mladi ženin zapre oči in si misli: \"Od danes naprej bom lahko seksal kadar koli bom hotel in koliko bom hotel.\"    Mlada nevesta si pa misli: \"Od danes naprej bom dobila karkoli bom hotela, ko si bo zaželel seksa.\"", "Mladoporočenca v postelji" },
                    { 1247, true, 11, "Z deklico svojega srca sem hodil že več kot leto dni, ko sva sklenila, da se poročiva. Moji starši so nama v vseh pogledih pomagali, prijatelji so me spodbujali, moja deklica pa... Bila je sanjska.    Samo ena stvar me je malce vznemirjala - moja bodoča tašča. Bila je uspešna poslovna ženska, bistra, predvsem pa lepa in seksi. Včasih se je z menoj čisto očitno spogledovala, kar me je spravljalo v zadrego.    Nekega dne me je poklicala, naj se oglasim, da bova pregledala seznam gostov. Šel sem. Bila je sama in ko sem prišel, mi je zašepetala, da se bom kmalu poročil, njej pa sem všeč in si me želi. Rada bi se z menoj ljubila, samo enkrat, preden se poročim in se zapišem njeni hčeri.    Kaj naj bi ji rekel?    Bil sem tako presenečen, da nisem mogel izustiti niti besede.\"Grem v spalnico,\" je rekla, \"in če si pripravljen, pridi za menoj.\"    Ko je odhajala po stopnicah v spalnico, sem gledal za njo in občudoval njeno graciozno zadnjico. Samo trenutek sem premišljeval,potem sem pa šel k vhodnim vratom, jih odprl in stopil iz hiše...    Pred hišo je stal njen mož, me s solznimi očmi objel in rekel: \"Zelo smo srečni in zadovoljni, da si opravil našo malo preizkušnjo..Ne bi si mogli želeti boljšega moža za svojo hčer, kot si ti.Dobrodošel v družini.\"    Iz tega sem se naučil: kondome imej vedno v avtu.", "Vražji preizkus" },
                    { 1244, true, 11, "Žena se, iz kuhinje zadere možu v dnevno sobo: \"Danes je najina obletnica!\"    Mož, ležerno, na kavču. Z daljincem v roki: \"A res? Na katerem programu?\"", "Obletnica" },
                    { 1238, true, 11, "Mož pomiva posodo, med tem pa žena rešuje križanko.    Ker ne ve, kaj je to \"človek pripravljen na poroko\" na pet črk, vpraša moža, kaj je to.    Mož, kot iz topa: \"I-D-I-O-T\"", "Žena rešuje križanko" },
                    { 1225, true, 11, "Korel in Polde za sankom.  Polde:Ves, pri nas je tako, jaz  imam za zajtrk raje caj, moja  Pepca pa kavo.  Korel: O, to pa je res nerodno,   potem morate pripravljati za zajtrk   kavo in caj. Kdo pa vse to kuha?  Polde zacudeno: Zakaj bi bilo nerodno?  Saj pijemo zmeraj kavo.", "Kava in caj" },
                    { 1214, true, 11, "Polde se sprehaja po mestu, ko ga ogovori klošar. Prosi ga za drobiž.    Polde ima poseben dan, zares izvleče iz žepa denarnico in vpraša klošarja: \"A boš denar porabil za viski?\"    Klošar: \"Ne, piti sem nehal že pred leti.\"    Polde naprej: \"A ga boš porabil za hazardiranje?\"    \"Za hazardiranje? Tudi tega nisem počel že celo večnost,\" de klošar.    Polde vrta naprej: \"A ga boš nemara porabil za igro golfa?\"    Brezdomec: \"Ne, ne spomnim se, kdaj sem nazadnje igral golf.\"    Takrat Polde: \"Potem ti pa ne dam denarja. Namesto tega te vabim k sebi domov na večerjo, ki jo bo skuhala moja žena.\"    Klošar je šokiran: \"A ne bo vaša žena jezna? Ne oddajam najprijetnejših vonjav in sem groznega videza.\"    Polde ga že vleče za seboj in vmes razlaga: \"Ne skrbi! Rad bi ji samo pokazal, kako je videti nekdo, ki se je odpovedal pijači, hazardiranju in igranju golfa.\"", "Polde sreča klošarja" },
                    { 1213, true, 11, "Polde svojemu zetu: \"Upam, da se boš sedaj, ko si se poročil, zresnil in prenehal z neumnostmi.\"    Zet: \"Obljubim, ta neumnost je bila zadnja.\"", "Novopečeni zet" },
                    { 1276, true, 11, "Maja obisce odvetnika.  Zeli se cim prej lociti od moza,   temu primerno ga ves cas kritizira.  Po desetih minutah jo odvetnik  le prekine: Oprostite, a nekaj je   pa le bilo pozitivnega na njem, da  ste se z njim porocili. Kajne?  Maja: Ja, je bilo, toda vse do  zadnjega evra sva porabila.", "Locitev" },
                    { 1843, true, 11, "Hčerka veselo razlaga mami: \"Mami, mami! A veš, da me je moj fant zaprosil? Ne vem, kaj naj naredim? Saj me še sploh ne pozna tako dobro!\".    Mama: \"Omoži se, preden te dodobra spozna!\".", "Presrečna je" },
                    { 1753, true, 7, "Mali cigo vpraša očeta: \"Čale, ka je to demokracija?\"    \"To je, da slovenci hodijo vsak dan delat, mi pa samo sedimo doma in jim krademo, pa še socialno podporo in otroške doklade dobivamo od njih\"    \"Kako pa, da jih to ne nervira?\"    \"Sej jih nervira, sam to je pa že diskriminacija.\"", "Demokracija" },
                    { 1606, true, 7, "Štiri laži v enem stavku: cigan, edinec, se vstane zgodaj zjutraj in se, pred odhodom v  službo, stušira.", "Huda laž" },
                    { 368, true, 4, "Kako blondinka naredi marmelado?    Olupi krof!", "Marmelada" },
                    { 355, true, 4, "Zakaj blondinka iz Slovenije da v Angliji knjige na policijski avto?    Zato, ker na avtu piše: \"police\".", "Blondinka v Angliji" },
                    { 349, true, 4, "Zakaj gre blondinka v trgovino naga z brisačo?    Ker na trgovini piše TUŠ.", "Blondinka v trgovino" },
                    { 346, true, 4, "Zakaj gre blondinka z buldožerjem v trgovino?    Zato ker na vratih piše: \"RINI\".", "Blondinka v trgovino" },
                    { 312, true, 4, "Zakaj blondinka pusti odprta vrata ko gre na WC?    Da je ne bi kdo slučajno skozi klučavnico gledal!", "Blondinka na WC-ju" },
                    { 267, true, 4, "Blondinka rodi dvojčke.    Po porodu začne razmišljati: le kdo bi utegnil biti oče od tadrugega otroka.", "Blondinka v dvomih" },
                    { 266, true, 4, "Ustavi policaj blondinko, rekoč: \"Dajte mi vaše ime in priimek.\"    Blondinka: \"A ste neumni? Ne morem! Kako bo pa potem meni ime?\"", "Blondinka in prometna kontrola" },
                    { 265, true, 4, "Zakaj si je blondinka privezala uro na rano?    Slišala je, da čas celi vse rane.", "Blondinka in rane" },
                    { 246, true, 4, "Zakaj blondinka leži na cesti?    Ker osvaja ležečega policaja.", "Blondinka leži" },
                    { 245, true, 4, "Zakaj blondinka meče seno na cesto?    Ker hrani zebro.", "Blondinka in seno" },
                    { 244, true, 4, "Dve blondinki se pogovarjata v parku.    Prva: \"Ali vidiš ona dva moška? Tisti na levi je moj fant. Oni na desni pa je moj porivač.\"    Druga: \"Kako sva si različni, pri meni je moj porivač na levi.\"", "Blondinkin fant in porivač" },
                    { 243, true, 4, "Dve blondinki se pogovarjata.    Prva: \"Ali je res, da je v štiridesetih nosečnost rizična?\"    Druga: \"Seveda!\"    Prva: \"Kako veš?\"    Druga: \"V štiridesetih je bila svetovna vojna.\"", "Blondinki in rizična nosečnost" },
                    { 242, true, 4, "Zakaj blondinka nosi čelado, ko gre v gostilno?    Da ji alkohol ne vdari v glavo.", "Blondinka in čelada" },
                    { 237, true, 4, "Moški se je poročil z blondinko.    Po dolgih letih zakona mož pride domov in v svoji postelji najde tujega moškega.    Odpre omaro, in se zadere na svojo ženo, ki je bila skrita v njej: \"Kolikokrat sem ti že povedal, da se mora skriti ON in ne ti!?!\"", "Blondinka se poroči" },
                    { 236, true, 4, "Blondinka se toži prijateljici: \"Moj fant se do mene obnaša kot, da bi sem pes.\"    Prijateljica začudeno: \"Kaj pa ti je naredil?\"    Blondinka: \"Pričakuje, da mu bom zvesta!\" ", "Blondinka se toži" },
                    { 235, true, 4, "Zakaj ima blondinka, nalkašč, vsake toliko časa nalašč poplavi stanovanje?    Da lahko uporabi globinski sesalnik.", "Blondinka poplavi stanovanje" },
                    { 234, true, 4, "Zakaj blodinka, na romatičnem koncertu, nosi neprebojni jopič?    Da jo nobena pesem ne zadane v srce. ", "Blondinka na romatičnem koncertu" },
                    { 233, true, 4, "Kaj narediš, da se blondinki zasvetijo oči?    S svetilko ji posvetiš v uho. ", "Blondinka in svetleče oči" },
                    { 232, true, 4, "Na koliko načinov blondinke odgovarjajo na vprašanja?    Na dva:  1. Ne vem.  2. Ha, ha, ha ... ", "Blondinkini odgovori" },
                    { 229, true, 4, "Zakaj gre v kino, skupaj, vedno nekaj čez osemnajst blondink?    Ker so slišale, da je pod osemnajst ogled prepovedan.", "Blondinke družno v kino" },
                    { 228, true, 4, "Blondinki so bili primorani operirati glavo.    Ko jo odprejo glavo presenečeni ugotovijo, da je skoraj prazna.  Znotraj je bila le ena napeta vrvica.    Ko jo previdno prerežejo .... blondinki odpadejo ušesa.", "Blondinki operirajo možgane" },
                    { 224, true, 4, "Poletje, vročina, Mujo hodi po stari Ljubljani.  Pride do vodnjaka in mu pade na misel: \"Ooo, voda, kaj ko bi se osvežil?\"     Se sleče do nagega in hop v vodo.    Nato se spomni, da ima s sabo tudi milo in zakaj se ne bi še umil.    Pri tem prijetnem opravilu pridejo mimo tri blondinke. Mujo da milo med zobe in se postavi ves trd od strahu. Se pretvarja, da je kip.    Tudi blondinkam pade na pamet odlična ideja, da bi se osvežile.  In skočijo v vodo. Ena pride do Mujota in vidi milo, ter mu ga hoče izvleči iz ust.    Mujo pa ne da. Ona ga potegne za luleka in Mujo pregrizne milo na pol.    Vsa srečna, da je dobila milo, se začne umivati, nakar jo vpraša druga: \"Ja, kje pa si dobila milo?\"  Prva: \"Glej, tam na avtomatu.\"    Druga gre do Mujota, ga gleda in ga potegne za luleka. Mujotu pade iz ust še druga polovica mila.    Pride še tretja in tudi z namenom, da dobi milo.  Gleda Mujota, pa potegne za luleka in nič.  Pa potegne še enkrat, pa se dvakrat pa se trikrat... in vzklikne: \"Ooo, jaz sem pa dobila tekoče milo!\"", "Mujo in blondinke" },
                    { 210, true, 4, "Kako rečemo blondinki, ki je izgubila 90 % pameti?    Vdova!", "Izguba pameti" },
                    { 209, true, 4, "Blondinka drži dojenčka nad velikim loncem vrele vode in za vsak slučaj še enkrat bere navodilo v knjigi o dojenčkih:  \"Če otrok noče piti kravjega mleka, ga prekuhamo.\"", "Dojenček in mleko" },
                    { 208, true, 4, "Blondinka in rjavolaska gledata poročila ob 18h.  Novinarka je govorila o moškem, ki se je pripravljal da bo skočil z mosta in naredil samomor.  Rjavolaska se obrne k blondinki in reče: \"Stavim 50 EUR tisoč da bo skočil!\"  Blondinka odvrne: \"Ok velja!\"  Gledata naprej moški skoči z mosta in blondinka da rjavolaski denar.  \"Ne morem sprejeti tega denarja\" pravi rjavolaska.  \"Gledala sem že poročila ob 17h in sem vedela da bo moški skočil.\"  \"Ne ne! moraš vzeti. Tudi jaz sem gledala poročila ob 17h, ampak si nisem mislila da bo skočil še enkrat.\"", "Stava" },
                    { 207, true, 4, "Tri ženske so skupaj delale v isti pisarni in so imele žensko za šefico.    Vsak dan je šefica odšla iz službe že precej pred iztekom delovnega časa. Punce so to opazovale kar dolgo in potem so sklenile, da bodo tudi one začele odhajati prej. Konec koncev, šefica ni nikoli poklicala nazaj v službo in le kako naj bi vedela, da jih ni tam?       Črnolaska je odšla prva. Napotila se je naravnost domov in se lotila vrtnarjenja. Presadila je nekaj zelenjave in obrezala vrtnice, potem pa je prišla njena hčerka iz šole in ji je pomagala napraviti domačo nalogo. Potemje skuhala kosilo in zvečer je šla zgodaj spat.       Rdečelaska je bila srečna, da je lahko odšla prej, kajti fant jo je povabil na večerjo in je imela tako dovolj časa, da se je lepo uredila in pripravila zanj. Šla je k kozmetičarki, potem sta šla na večerjo s svečami in potem k njemu in naravnost v posteljo.       Blondinka je bila zelo vesela, da bo lahko prišla domov prej in presenetila brezposelnega moža. Ampak ko je prišla domov, ga ni bilo nikjer. Potem je iz spalnice zaslišala čudne glasove. Potiho se je prikradla do vrat spalnice in potihoma odškrknila vrata. Imela je kaj videti... Njen mož je bil v postelji z njeno šefico. Ona je jahala na njem in iz grla so ji prihajali nerazločni zvoki. Prav potihoma je zaprla vrata in se kradoma izmuznila iz hiše.       Naslednji dan, ob opoldanski kavi, sta črnolaska in rdečelaska objavili, da bosta spet odšli prej iz službe. Vprašali sta blondinko, če bo prej odšla tudi ona.    \"Ni govora,\" je rekla blondinka: \"včeraj bi me šefica skoraj dobila!\" ", "Šefica predhodno iz službe" },
                    { 206, true, 4, "Dve blondini se pogovarjata:   \"Si slišala, da je našega dimnikarja povozil avto?\"    Druga: \"Strašno! Niti na strehi nismo več varni!\"", "Dimnikarja je povozil avto" },
                    { 205, true, 4, "Črnolaska, rjavolaska in blondinka se pogovarjajo o otrocih.    Črnolaska pove, da je v reviji brala, da se spol otroka lahko načrtuje.    Tudi rjavolaska je to prebrala in sedaj razlagata blondinki: \"Jaz bom rodila punčko\", pravi črnolaska, \"ker med seksom ležim spodaj\".    Jaz bom pa dobila fantka, ker sem zgoraj, pove rjavolaska.    \"Torej bom jaz dobila psička?\" presenečeno vpraša blondinka.", "Babji čvek o otrocih" },
                    { 204, true, 4, "Dragi dnevnik,    lani sem dala na hiši zamenjati stara lesena okna z novimi PVC okvirji. Okna  so super, prišparamo na gretju,... in vse bi bilo super, ce me nebi pred  nekaj dnevi poklical lastnik firme, ki je vstavila nova okna, in me opomnil,  da okna po letu dni še vedno niso placana.    Bila sem zelo presenečena nad njegovo izjavo in sem ga opomnila kaj so mi  takrat, ko sem kupovala okna, rekli njegovi prodajalci.  \"Ta okna so tako dobra in varčna, da se že po letu dni sama poplacajo.\"  Halooooooooooooo !!!!!!!!!!!! Poteklo je leto dni !!!!!!!!!    Čeprav sem blond, se ne pomeni da sem glupa.  Na drugi strani slušalke je nastal molk, pa sem poklopila slušalko. Sigurno  se je tip počutil kot prava budala. ", "Nova okna" },
                    { 369, true, 4, "Se dve blondinki pogovarjata v baru pa reče ena drugi:  \"Veš včeraj sem imela nosečniški test.\"  Pa druga ereče \"aja, pa je bil težki?\"", "Nosečnostni test" },
                    { 202, true, 4, "Blondinka potuje z vlakom.  Odide na stranišče, nato pa ne najde več svojega kupeja.    Sprevodnik ji poskuša pomagati:  \"Pa se vsaj približno spomnite, kje ste sedeli?\"    Blondinka:\" Am....vem samo to, da je bila zunaj reka.\"", "Blondinka s slabim spominom" },
                    { 371, true, 4, "Kako zaposliš blondinko za nedoločen čas?    Na mizo daš papir in na obe strani napišeš obrni.", "Zaposlitev za nedoločen čas" },
                    { 404, true, 4, "Blondinka se je zvečer vrnila iz zabave domov in mama jo je vprašala:   \"Kako se kaj počutiš?\"   \"Kot sončnica!\"   \"Zakaj pa kot sončnica?\" se je začudila mama.   \"Ker sem polna semen!\" ", "Sončnica" },
                    { 1019, true, 4, "Blondinka brezvoljno  potarna:  Kakšen dan.  Kar pištolo bi vzela in  se obesila", "Blondinka in samomor" },
                    { 1006, true, 4, "Kaksna je razlika med blondinko in telefonsko govorilnico?  Uporaba telefonske govorilnice ni zastonj!", "Blondinka in telefonska govorilnica" },
                    { 993, true, 4, "Kaj imata skupnega blondinka in jederska elektrarna?  Vse, na zacetku je draga investicija, nato sledi drago vzdrzevanje, po 20 letih pa ne ves kam z odpadki.", "Blondinka in jedrska elektrarna" },
                    { 960, true, 4, "Kaj dobiš, ko najdeš v omari mrtvo blondinko?    Zmagovalko skrivalnic iz leta 1996.", "Mrtva blondinka" },
                    { 954, true, 4, "Polde modruje prijateljem:  Ste slisali,kaksna je  razlika med Titanikom  in blondinko?  Molk.  Polde:Koliko ljudi je bilo  na Titaniku,je znano,koliko  na blondinki,pa se ne ve. ", "Modruvanje" },
                    { 950, true, 4, "Blondinka gre na zmenek z novim fantom. Po obisku kina fant zapelje na zapuščeno parkirišče, kjer se začneta mečkati.    Ker so stvari postale dokaj vroče, jo fant ogovori: \"A bi rada šla na zadnji sedež?\"    \"Ne.\" odgovori blondika.    Situacija se še bolj razvname in fant ponovno vpraša, če bi želela na zadnji sedež.    \"Ne, nočem na zadnji sedež!!\" začne ipično kričati blondinka.    Fant: \"Zakaj ne?\"     Blondinka: \"Ker bi rada ostala tu spredaj, s tabo.\"", "Blondinka na zmenku" },
                    { 933, true, 4, "Katera deklica v prvem razredu ima najlepso postavo? Rjavolaska, rdecelaska ali blondinka?  Blondinka, ker je stara 18 let!", "Postava" },
                    { 927, true, 4, "Blondinka se po avtocesti vozi v napacno smer in ustavi jo policaj.  Policaj: Ali veste, kam ste se vozili?  Blondinka: Ne, ne vem, ampak mora biti grozno, ker se vsi vracajo.", "Avtocesta" },
                    { 926, true, 4, "Zakaj imajo blondinke rade nevihte?  Ker mislijo, da jih nekdo slika.", "Nevihta" },
                    { 921, true, 4, "Blondinka pokliče svojega fanta v službo: \"Dragi, tu imam ene puzzle, ampak mi zlaganje ne gre in ne gre. Vsi deli izgledajo enaki.\"    Njen fant pravi: \"Imaš sliko?\"    \"Ja, na škatli je narisan en rdeči petelin. Ampak vseeno ne gre.\"    Fant: \"Ne vznemirjaj se, bova zvečer skupaj poskusila.\"    Zvečer si fant ogleda škatlo. Sledi dolg pomenljiv molk in nato reče: \"Tako, zdaj bova pa te koruzne kosmiče lepo pospravila nazaj v škatlo, potem pa nobene besede več o tem.\" ", "Blondinka in puzzle" },
                    { 895, true, 4, "Kako je blondinka poskusila ubiti ptico?    Vrgla jo je v prepad.", "Umor ptice" },
                    { 844, true, 4, "Kaj imata skupnega pametna blondinka in dinozaver?  Oba sta izumrla!", "Blondinka in dinozaver" },
                    { 843, true, 4, "Katera je najbolj pametna blondinka?  Brez dvoma je to zlati prinasalec.", "Pametna blondinka" },
                    { 795, true, 4, "Zakaj gre blondinka v trgovino s pistolo?  Ker na vratih pise AKCIJA!", "Blondinka nakupuje" },
                    { 722, true, 4, "Srečajo se trije morski psi in se pogovarjajo: “Požrl sem rjavolasko, ki je bila tako pijana, da tri dni nisem mogel naravnost plavati,” je rekel prvi.  “Požrl sem rdečelasko, ki je bila polna tlablet, tako da se mi je tri dni dremalo,” je dejal drugi.  “Jaz sem pa požrl blondinko, ki je imela tako prazno glavo, da se tri dni nisem mogel potopiti,” je rekel tretji morski pes.", "Morski pes" },
                    { 721, true, 4, "Zakaj blondinkam umirajo akvarijske ribice? “Ker na škatli s hrano piše: “Hraniti na suhem!” ", "Akvarijske ribice" },
                    { 720, true, 4, "Prijateljica je blondinki pripovedovala, kako hudo je bilo na smučanju. “Padla sem po strmini in se tako polomila, da sem obležala za tri tedne.” “Ali si bila na tako zapuščenem kraju, da te niso mogli prej najti?” jo je vprašala blondinka. ", "Smučanje" },
                    { 719, true, 4, "Blondinki sta se sprehajali ob obrežju reke in našli dve ročni bombi.”Odnesiva ju na policijo!” je rekla ena.”Kaj pa če ena bomba eksplodira?” je vprašal druga.”Bova pa policistom rekli, da sva našli le eno!”", "Bomba" },
                    { 718, true, 4, "“Včeraj sem delala test za nosečnost.” pove prva blondinka.  “So bila težka vprašanja?” vpraša druga.", "Test za nosečnost" },
                    { 685, true, 4, "Se peljeta dve blondinki v avtu, nakar poči guma.    Izstopita, da bi si ogledali situacijo.    Prva: \"Joj, guma je uničena.\"    Druga: \"A cela?\"    Prva: \"Ne, samo spodnji del.\"", "Blondinki in gumidefekt" },
                    { 664, true, 4, "Čakata blondinki na avtobus.    Prva vpraša drugo: \"Na kateri avtobus čakaš?\"     \"Na 1.\" pravi druga, \"na katerega pa ti ?\"    \"Na 3.,\" odvrne prva.     Nato se pripelje avtobus št.13.    \"SUPER!\" vzklikneta blondinki, \"zdaj pa lahko greva skupaj!\"", "Blondinki čakajo na avtobus" },
                    { 652, true, 4, "Mama pokliče hčerko blondinko: “Tina, si prestavila uro tako, kot sem ti naročila?”    Tina: “Sem! Iz kuhinje sem jo prestavila v kopalnico.”", "Ura se prestavi" },
                    { 651, true, 4, "Dve prijateljici, blondinki, se pogovarjata: “Zdravnik mi je svetoval, da dva tedna živim le na jabolkih.”    Druga: “Kaj pa če dol padeš?”", "Jabolka" },
                    { 645, true, 4, "Zakaj hodi blondinka v kot ko jo zebe?    Ker ima kot 90 stopinj.", "Gre v kot" },
                    { 603, true, 4, "Dve blondinki vozita tovornjak in prispeta do podvoza, kjer je oznaka višine 3,60 metra.   Prva vpraša: \"Kako visok je najin kamion?\"   \"3,70.\"   \"Oh ... Vidiš kje policaje?\"   \"Ne!\"   \"Gas! Gas!\" ", "Gas! Gas!" },
                    { 587, true, 4, "Kaj piše blondinki na nagrobnem spomeniku ?  \"Prvic ležim sama.\"", "Blondinka in nagroben spomenik" },
                    { 577, true, 4, "Blondinka dobi za darilo vibrator. Po vklopu se prične tresti, nakar mu blodinka pravi:  ?Kaj se treseš, saj je tudi zame prvič?!", "Blondinka in vibrator" },
                    { 419, true, 4, "Se sprehaja blondinka po cesti, pa se ustavi pri obcestni luči.  Na drogu je obešen letak na katerem piše ODDAJAMO STANOVANJE.    Blondinka potrka na drog. Čaka, čaka pa nič.    Mimo pride policaj pa vpraša blondinko:\"Ja kaj pa počnete?\"    Blondinka: \"Tukaj piše, da oddajajo stanovanje. Trkam, pa se noben ne oglasi.\"    Policaj pogleda navzgor pa pravi: \"Ja, to je pa res čudno. Zgleda da so doma, saj imajo prižgano luč.\"", "Blondinka in policaj" },
                    { 405, true, 4, "Kako se lahko 4 blondinke usedejo na en stol?    Obrnejo ga.", "Stol" },
                    { 372, true, 4, "Kako pripraviš blondinko do tega da se ji zmeša?    Daš jo v okroglo sobo in ji rečeš da je v kotu zaklad", "Zaklad" },
                    { 201, true, 4, "Policaj pregleduje avto blondinke: \"Žarnice so ok, prva pomoč tudi\"    \"Dvigne pogled k dekletu: \"kaj pa trikotnik....???\"    \"Nimam ga več, sem si jo zjutraj obrila\"", "Blondinka na policijski kontroli" },
                    { 200, true, 4, "Blondinka razlaga svoji blont prijateljici:  \"Padla sem na vozniškem izpitu. Zapeljala sem v krožišče in ker je pisalo 30, sem 30-krat peljala okoli. Pa me je vrgel.\"    Prijateljica: \"Sigurno si se zaštela.....\"", "Blondinka na vozniškem izpitu" },
                    { 199, true, 4, "Zakaj blondinka s prstom dreza po majonezi?    Ker išče Tomija.", "Blondinka in majoneza" },
                    { 1456, true, 3, "Zakaj potrebujemo stiri Bosance, da izvedemo ugrabitev?  Eden ugrabi zrtev, trije pa pisejo pismo za odkupnino.", "Ugrabitev" },
                    { 1230, true, 3, "Pride Mujo domov in začne razlagat: \"Fata, si slišala, da so izglasovali novi zakon?\"    Fata: \"Nisem, kakšen zakon?\"    Mujo: \"Ženska, ki ima štiri otroke lahko gre v pokoj.\"    Fata: \"Pa kaj nas to briga? Imamo tri otroke in četrtega ne bomo imeli!!!\"    Mujo: \"Že, že. Ampak, jaz imam enega nezakonskega. Grem po njega, bomo imeli štiri in lahko greš v pokoj in dobiš pokojnino.\"    Fata nejevoljno: \"Vredu, pripelji ga!\"    Mujo se odpravi in čez pol ure se že vrne s svojim zunajzakonskim sinom.    Fata pa sama doma.    Mujo: \"Kje so najini trije otroci?\"    Fata: \"Drugi so tudi slišali za ta zakon, pa so prišli vsak po svojega.\"", "Nov zakon o otrocih" },
                    { 1219, true, 3, "Francka gleda kuharsko  oddajo, Miran pa se spotakne  ob to:  Zakaj to gledas, itak ne znas  kuhati...  Saj tudi ti gledas pornice...", "Kuharska oddaja" },
                    { 1204, true, 3, "Kaj dobimo, ce prikljucimo Bosanca na elektricni stol?  Dobimo elektricnega pastirja.", "Elektricni pastir" },
                    { 1113, true, 3, "»Doktore, treba mi potvrda, da nisam sposoban za rad!« »Dobro, a što vam fali?« »Pa ta potvrda!«", "Nesposoben" },
                    { 1070, true, 3, "Slovenec, Hrvat in Srb družno oropajo banko. Pregledajo plen in vidijo, da imajo kup evrov, kun in dinarjev.    Naredijo tri kupe, po valutah, nato začne Janez deliti: \"Tisoč evrov meni, tisoč kun tebi, tisoč dinarjev tebi.\"  Pa spet: \"Tisoč evrov meni, tisoč kun tebi, tisoč dinarjev tebi.\"    In tako še večkrat.    Onadva ga gledata, čez nekaj časa se Hrvat obrne k Srbu: \"Ta Janez mi gre že nekaj časa na jetra, a nekaj morava priznati - pošten pa je\"", "Slovenec, Hrvat in Srb oropajo banko" },
                    { 989, true, 3, "V Bosni, na eni izmed avtobusnih postaj, vstopi na poln avtobus urejen moški. Iz jakne potegne pištolo in zakriči: \"Slušajte ljudi! Ovo je pljačka!\" V zadnji vrsti se vstane moški in zakriči nazaj: \"Jaooo bože, kako sam se uplašio, bio sam siguran da je ispekcija karata!", "Rop na avtobusu" },
                    { 953, true, 3, "Se dva moska srecata na letaliscu.  Prvi: Where are you from?  Drugi: From Germany!  Prvi: Ma nemoj!  Drugi: Pa da, stvarno!", "Where are you from" },
                    { 894, true, 3, "Zakaj je črnogorec postal len?    Bosanc mu je rekel \"sedi, da ti nekaj razložim\"", "Začetek zgodbe" },
                    { 889, true, 3, "Gre bosanec v gozd in ga začne lovit medved pa spleza bosanec na bukev pa začne govorit: \"mama pomagaj mi\"    Reče bukev \"sve je v redu sine, tata se samo šali\"", "Bosanc v gozdu" },
                    { 631, true, 3, "Pravi Mujo Fati: \"Fata, ti prava idiotkinja!\" Pa pravi Fata Mujotu:\"Pa da bi imala cara, bila bi carica!\"", "Mujo in Fata" },
                    { 402, true, 3, "Ako te boli želudac...popij pelinkovac!  A za sve ostalo što te zaboli popij jeger! Ima 56 trava.  - Da ga jebeš, jedna će ti pomoći!", "Jagermeister" },
                    { 375, true, 3, "Slovenec, Bosanec in Hrvat se dajejo, kdo več časa zdrži pod vodo:  - prvi gre Slovenec: zdrži 30 sekund.  - drugi gre Hrvat: zdrži 1 minuto.  - zadnji gre pa Bosanec: ni ga bilo 30 sekund, 1 minuto, dan, mesec in še danec ga ni iz vode", "Čas pod vodo" },
                    { 347, true, 3, "Kdaj nastane v Črni Gori potres?    Ko Črnogorec prime za lopato in se mu cela Zemlja smeji", "Potres" },
                    { 293, true, 3, "Zove baka unuka na mobilni:    Baka: \"Sine, kako se zove onaj Njemac što mi skriva stvari po kući?!\"  Unuk: \"Alzheimer baba, Alzheimer!\" :)", "Stanar Alzheimer" },
                    { 268, true, 3, "Upišite vaš password:  sarma    Žao nam je, password mora da sadrži više od 8 znakova:  kuvana sarma    Žao nam je, password mora da sadrži bar jednu brojku:  1 kuvana sarma    Žao nam je, password ne sme sadržavati razmake:  5jebenihkuvanihsarmi    Žao nam je, password mora sadržavati bar jedno veliko slovo:  5jebenihKUVANIHsarmi    Žao nam je, password ne sme sadržavati više od jednog velikog slova uzastopce:  5jebenihKuvanihsarmi, i da se nosiš u pičku materinu govno jedno    Žao nam je, password ne sme sadržavati interpukcijske znake:  5jebenihKUVANIHsarmi nabijem te na kurac i tebe i tvoj password mamicu ti jebem kretenčino    Žao nam je, taj password se već koristi!", "Sarma" },
                    { 36, true, 3, "Mujo se vrže iz nebotičnika. Ko prileti na tla, se pobere in se malo očisti. Nato priteče nek gospod k njemu in ga praša, kaj se je zgodilo. Mujo odgovori: \"Kako naj jaz vem, saj sem ravnokar prišel.\"", "Nebotičnik" },
                    { 32, true, 3, "Fata gre v Bosni v bolnico, pa vidi unproforovca, kako tuli od bolečin.  \"Plava kacigo, što ti je, sto tako urlaš ?\"  \"Yao, yao, boli, metak u noga...!!\"  \"Šuti plava kacigo! Dobio jučer Mujo metak ravno u glavu, ma nije ni pisnuo!!\"", "Hrabrost" },
                    { 31, true, 3, "Mujo sreča Hasota in ga vpraša: \"Kako si, bolan, Haso?\"  \"Pa, danas prilično luksuzno,\" mu odvrne Haso.  \"A kako to misliš - luksuzno?\"  \"Pa, upravo sam uzeo luk in nasjeckao ga i odma´ mi navrle suze na oči!\"", "Luksuz" },
                    { 29, true, 3, "Američan, nemec in bosanec se srečajo v nebesih in se pogovarjajo kako so umrli.  Pa reče američan: \"Kupil sem lotusa, pa sem se zaletel v drevo in ubil.\"  Pa reče nemec: \"Kupil sem poršeja, pa sem se zaletel in ubil.\"  Pa reče Haso: \"Kupio sam fičota a umro od gladi.\"", "Vzrok smrti" },
                    { 28, true, 3, "Mujo si v restavraciji zazeli za kosilo divje svinje. Natakar mu odvrne: \"Žal mi je, zmanjkalo. Imamo pa eno navadno svinjo, ampak bom naročil kuharju, naj jo pošteno znervira!\"", "Divja svinja" },
                    { 27, true, 3, "Kako ti je ime?  Mujo.  Pa prezime?  Pa pre zime i posle zime!", "Ime" },
                    { 2107, true, 2, "Mlada dama vstopi v BMW-jev salon. Na sredi salona zagleda  kabrioleta svojih sanj. Stopi bližje, da si ga ogleda. Ko se nagne, da bi pogledala notranjost, ji uide malo  glasnejši prdec Nervozna in  osramočena se obrne, da bi videla, če jo je kdo slišal. Za njo  je stal prodajalec.  Dober dan želim! Kako vam lahko pomagam?  Ona, vsa rdeča od sramu mu odgovori:  Da, hotela bi vas vprašati, koliko stane ta prečudovit avto?  Prodajalec ji odgovori: Poglejte, pri samem pogledu na  notranjost ste prdnili. Če vam povem, koliko stane, se boste  pa usrali.", "Prdec" },
                    { 594, true, 2, "Dva avta se zaletita. Šoferja izstopita, eden ima v roki steklenico, ki jo ponudi drugemu: “Namesto, da se prepirava, ga cukniva, ostala sva živa.” Drugi dobro potegne, jo vrne in vpraša: “Ali vi ne boste?” “Jaz bom potem, ko bo alkotest mimo.", "Prometna nesreča" },
                    { 553, true, 2, "Na avtobusni postaji sta stala moški in ženska.  Ženska vpraša moškega:”Na kater avtobus čakaš?”  Moški:”Avtobus številka 1”  Ženska:”Jaz pa na številko 2.”  Mimo pripelje avtobus številka 12, moški pa vzklikne:  “Zdaj se lahko peljeva oba hkrati!”", "Avtobus št. 12" },
                    { 541, true, 2, "Peter je v avtomehanično delavnico pripeljal na redno servisiranje. Ko se je popoldan vrnil po avto so mu izročili račun. Zrl je vanj in ni mogel verjeti temu kar je videl.  \"Je kaj narobe, gospod Peter?\" ga je vprašal mehanik.  \"Ne vem, ali je to račun za popravilo ali je predračun za nov avto!\"", "Popravilo avtomobila" },
                    { 485, true, 2, "Prodam rezervne dela za Audi A6, limuzina, črn, metalne barve, letnik 2012.     Dele si lahko ogledate v Ljubljani, od Celovške ceste 150 do 190.", "Oglas" },
                    { 49, true, 2, "Ivan pove prijatelju.  Ali ves,da so mi ukradli vse  kreditne kartice?  In si tatvino prijavil policiji?  Nisem.  Zakaj pa ne?  Sem na boljsem.Tat manj porabi  kot moja zena...", "Ceneje" },
                    { 500, true, 1, ".", "zelo kratek vic" },
                    { 1469, true, 3, "Zakaj je v Crni Gori opozicija izgubila na volitvah?  Ker je vsem obljubila zaposlitev.", "Na volitvah" },
                    { 1734, true, 3, "Kako locis Hrvata od  Slovenca?  Med njima postavis  zicnato ograjo.", "Locitev" },
                    { 1755, true, 3, "Mali Mujo pride k mami in ji reče: \"Mami, danes smo se učili abecedo. Vsi so poznali samo črke do C, jaz pa vso abecedo!\"    \"To je pa zato sinko, ker si Bosanec,\" mu reče mama.    Naslednji dan mali Mujo spet pride k mami: \"Mami, danes smo se učili šteti. Vsi so šteli do 10, jaz pa do 100!\"    \"To je pa zato sinko, ker si Bosanec,\" mu reče mama.    Naslednji dan: \"Mami, danes smo bili na zdravniškem pregledu. Videl sem,da imajo vsi moji sošolci majhne pimplne, jaz imam pa velikega. A je to zato, ker sem Bosanec?\"    \"Ne, sinko. To je pa zato, ker imaš petindvajset let!\"", "Ker je bosanec" },
                    { 1829, true, 3, "Droge povzročajo odvisnost.    Le na Kosovu povzročajo neodvisnost.", "Droge" },
                    { 198, true, 4, "Poštar pozvoni pri vratih in blondinka odpre okno:  \"Letalsko pismo za vas, gospa!\"    Blondinka: \"Lažnivec! Videla sem vas, kako ste se pripeljali s kolesom.\"", "Letalsko pismo" },
                    { 197, true, 4, "Blondinka leži v bolnici in pravi zdravniku:  \"Gospod doktor, ali bi lahko dobila svežo prevleko za blazino?\"    \"Recite sestri.\"    \"Ampak jaz nimam sestre.\"", "Blondinka v bolnici" },
                    { 196, true, 4, "Prva: \"A veš, da lahko od trdega penisa dobiš raka na materničnem vratu?\"    Druga: \"Tega ne vem, vem pa, da se od mehkega lahko dobi živčni zlom!\"", "Blondinki o penisu" },
                    { 195, true, 4, "Gre blondinka pozimi na ribolov. V led zvrta luknjo in hoče začeti, ko z neba zasliši glas: \"Tukaj ni rib.\"Odide malo naprej, ponovno izvrta luknjo, da bo začela loviti in spet z neba: \"Tukaj ni rib.\"Ker gre v tretje rado, se odloči, da bo poskusila se na drugi strani ledene ploskve.  Izbere primeren kraj, zvrta luknjo, pripravi palico, skoraj vrže...  Z neba zadoni: \"Pravim ti, da tukaj ni rib.\"  Blondinki je prekipelo. Zadere se nazaj: \"Kdo mi to govori, da tuki not ni rib? A si bog, al kdo me prepričuje, da ni rib?\"  Z neba se zasliši: \"Ne, jaz sem napovedovalec v hokejski dvorani in pusti led pri miru.\"", "Blondinka in ribolov" },
                    { 194, true, 4, "Pride blondinka do urarja zamenjati baterijo na uri.    Urar: Draga gospodična, ta ura ni na baterije, ampak na navijanje!    Blondinka začne skakati in ploskati: \"Dajmo ura, dajmo ura!!!\"", "Blondinka pri urarju" },
                    { 193, true, 4, "Blondinka je končala policijsko šolo in je na svoji prvi kontroli prometa.    Zaustavi vozilo, zahteva dokumente in vpraša voznika:  \"Boste kaj popili?\"", "Blondinka kontrolira promet" },
                    { 192, true, 4, "Blondinka pravi prijateljici: \"Danes sem bila pri ginekologu in sem izvedela, da sem noseča.\"    \"Oh, kako lepo, si že razmišljala o imenu?\"    \"Ne, zdaj razmišljam o priimku.\"", "Blondinka je noseča" },
                    { 190, true, 4, "\"Dober dan. 300 € bi rada položila na svoj bančni račun.\"    Bančna uslužbenka pogleda v računalnik in presenečeno vpraša:  \"Ampak gospodična, denar ste ravnokar dvignili na bankomatu pred banko. Ste se morda zmotili pri dvigu?\"    \"Ne, pomislila sem, da bo moj denar bolj varen na banki, kot zunaj v avtomatu.\"", "Blondinka na banki" },
                    { 60, true, 4, "Zakaj so vse blondinke po obisku Londona žalostne?  \"Ker ugotovijo, da je Big Ben samo ura.\"", "Blondinka in London" },
                    { 59, true, 4, "V restavraciji se pogovarjajo tri blondinke.  \"Predstavljajta si, moj fant mi je poklonil nalivno pero, pa sploh pisati ne znam\" reče prva. \"Meni je pa moj poklonil knjigo, pa še brati ne znam\" reče druga. Tretja pa pravi. \"Meni je pa kupil deo-roller, pa še nimam opravljenega tečaja za uporabo.\"", "Blondinka in darilo" },
                    { 58, true, 4, "Kaj reče blondinka, ko ji ginekolog pove da je noseča?  \"Ste sigurni da je moj?\"", "Nosečnost" },
                    { 56, true, 4, "Zakaj blondinke ne skačejo čez plot?  \"Ker dajo že pred plotom.\"", "Skok čez plot" },
                    { 55, true, 4, "Zakaj so Japonci tako napredni?  \"Ker nimajo naravnih blondink.\"", "Japonci" },
                    { 54, true, 4, "Zakaj se stena podre, ko se na njo nasloni blondinka?   Pametnejši odneha.", "Blondinka in stena" },
                    { 1029, true, 4, "Zakaj blondinke nosijo nausnike?  Zato, ker se bojijo, da bi jim prepih iz glave odnesel edino mozgansko celico.", "Blondinka in nausniki" },
                    { 53, true, 4, "Črnolaska je rekla blondinki:  \"V časopisu piše, da iščejo roparja in morilca.\"  \"Ne verjamem, da se bo javil,\" je rekla blondinka.", "Ropar" },
                    { 51, true, 4, "Zakaj blondinka odpre mleko že v trgovini?  \"Ker na embalaži piše: \"Odprite tukaj!\"", "Blondinka in mleko" },
                    { 50, true, 4, "Kako blondinka pride do marmelade?  \"Kupi krof in ga olupi.\"", "Blondinka in marmelada" },
                    { 20, true, 4, "Zakaj imajo blondinke apriori višji glas od moškega?  Ker jim lobanja deluje kot rezonator.", "Višji glas" },
                    { 19, true, 4, "Zakaj ženske igrajo šah slabše od moških ?  Kje pa si že videl žensko, da bi bila lahko tiho 5 ur skupaj!", "Šah" },
                    { 18, true, 4, "Če se poročita blondinka in policaj..", "Kaj je ekstrem?" },
                    { 17, true, 4, "A veste zakaj se blondinka smeji, ko udari strela?  Zato ker misli, da jo fotografirajo...", "Strela" },
                    { 16, true, 4, "Kdo že vrsto let uspešno zmaguje na tekmovanjih za najbolj pametno blondinko?  Zlata prinašalka!", "Inteligenca" },
                    { 15, true, 4, "Zakaj so blondinke resne, ko pijejo sok iz tetrapaka ?  Ker na njem piše \"concentrate\".", "Sok" },
                    { 14, true, 4, "Zakaj blondinka shranjuje superge v kletko na dvorišču?  \"Ker na supergah piše: \"PUMA\".\"", "Blondinka in superge" },
                    { 12, true, 4, "Zakaj blondinka naliva vodo v računalnik?  \"Ker želi srfati po internetu.\"", "Blondinka in računalnik" },
                    { 11, true, 4, "Zakaj je blondinka razbila stekleno steno ?  Ker jo je zanimalo, kaj je na drugi strani.", "Blondinka in steklena stena" },
                    { 10, true, 4, "Kaj naredi blondinka po seksu?    Obleče se in gre domov.", "Blondinka po seksu" },
                    { 6, true, 4, "Kakšna je podobnost med blondinko in dvocevko?    Obe prepogneš in nafilaš od zadaj.", "Podobnost med blondinko in dvocevko" },
                    { 2090, true, 3, "V Slovenijo se preseli družina iz juga.    Čez en teden sin vpraša mamo: \"Mama mama, kako to, da računalnik ve moje ime?\"    Mama: \"Pa ne znam, Admine.\".", "Ni mu jasno" },
                    { 52, true, 4, "Zakaj blondinke delajo sedem dni v tednu?  \"Da se jim v ponedeljek ni potrebno na novo učiti dela, ki ga opravljajo.\"", "Blondinka in delo" },
                    { 1726, true, 7, "Kako najbolj razjezis  Roma?  Kako?  Vprasas ga, ali njegov  btat kaj violino pogresa...", "Romi in jeza" },
                    { 1030, true, 4, "Kdaj je Bog ustvaril blondinko?  V ponedeljek je ustvaril moske.  V torek je ustvaril rjavolaske in rdecelaske.  V sredo je ustvaril kure.  Nato mu je zmanjkalo perja, zato je v cetrtek ustvaril blondinke.", "Bog je ustvaril blondinko" },
                    { 1158, true, 4, "Zakaj blondinka vsako leto okoli novega leta kupi avto.   Ker mora menjati vinjeto!", "Blondinka kupi novi avto" },
                    { 799, true, 6, "Kako Chuck Norris je kikiriki?  Tako, da tocno ve, kateri je kiki in kateri riki.", "Kikiriki" },
                    { 794, true, 6, " Se dve blondinki pogovarjata.  Vprasa prva:\"Kaj je blizje Luna ali London?\"  Druga:\" Normalno, da Luna. Ali lahko London vidis od tukaj.\"", "Luna" },
                    { 793, true, 6, "Koliko sklec naredi Chuck Norris?  Vse!  Koliko pa naredi trebusnjakov?  Se enega vec!", "Sklece in trebusnjaki" },
                    { 560, true, 6, "Za informacijo, žirafe so nastale, ko je Chuck Norris usekal konja v brado.", "Chuck Norris in konj" },
                    { 531, true, 6, "Chuck Norris se lahko podpiše na zvočni zid!", "Podpis" },
                    { 175, true, 6, "Ko Chuck Norris prečka cesto, morajo avtomobili pogledati levo in desno.", "Chuck Norris prečka cesto" },
                    { 110, true, 6, "Kaj dela Chuck Norris na pohorju? Tisto, kar mu pohorci rečejo", "Pohorje" },
                    { 105, true, 6, "Chuck norris lahko posuši perilo pod vodo", "PERILO" },
                    { 100, true, 6, "Kako Chuck Norris spije špricer?    Tako, da voda notri v kozarcu ostane.", "Chuck Norris pije špricer" },
                    { 99, true, 6, "Smrt potrka na vrata.    Odpre Chuck Norris.    Matilda se za trenutek zdrzne in prestrašeno izdavi: \"A mate kaj za pusta hrusta?\"", "Smrt pride po Chucka Norrisa" },
                    { 97, true, 6, "Ko Chuck Norris vozi avto, navigacija govori v pretekliku.", "Navigacija" },
                    { 96, true, 6, "Chuck Norris je igral namizni tenis z steno in zmagal!", "Namizni tenis" },
                    { 95, true, 6, "En je šel levo, en je šel desno, Chuck Norris pa za obema", "Lovljenje" },
                    { 94, true, 6, "Zakaj Chuck Norris ni dobil glavne vloge v Gospodarju prstanov?  Ker bi on sam premagal Saurona in odnesel prstan", "Gospodar prstanov" },
                    { 93, true, 6, "Chuck Norris je pregledal že cel internet....... .in to dvakrat", "Internet" },
                    { 92, true, 6, "Chuck Norris eksa vodo iz pipe", "Voda iz pipe" },
                    { 91, true, 6, "Zakaj Chuck Norris hodi na Brezje?  Zato da se prikazuje Mariji", "Marija na Brezju" },
                    { 90, true, 6, "Ko Chuck Norris je kikiriki, točno ve kateri je kiki, kateri pa riki", "Kikiriki" },
                    { 89, true, 6, "Če bi uspeli obrniti Kitajsko okoli, bi tam pisalo, made in Chuck Norris", "Kitajska" },
                    { 88, true, 6, "Kaj je to – videt je kot piščanec, diši kot piščanec, okus ima kot piščanec? Če Chuck Norris reče, da je to govedina – potem je to govedina.", "Piščanec ali govedina" },
                    { 87, true, 6, "Otroci nosijo pižamo z likom Supermana. Superman nosi pižamo z likom Chucka Norrisa.", "Super man" },
                    { 86, true, 6, "Chuck Norris je že bil na Marsu. Zato tam ni sledov življenja.", "Chuck Norris na Marsu" },
                    { 85, true, 6, "Bog je hotel ustvariti svet v 10 dneh. Chuck Norris mu je dal 6 dni časa.", "Nastanek Zemlje" },
                    { 84, true, 6, "Chuck Norris je pogledal v 20minutah 60minutni film", "Chuck Norris in film" },
                    { 83, true, 6, "Ko Chuck Norris ne zmore več, Petra Majdič vztraja!", "Chuck Norris in Petra Majdič" },
                    { 82, true, 6, "Chuck Norris je izgubil nedolžnost pred svojim očetom. Še več, zgradil je lastno rodno bajto.", "Nedolžnost" },
                    { 81, true, 6, "Samo Chuck Norris lahko ploska z eno samo roko.", "Ploskanje" },
                    { 80, true, 6, "Chuck Norris se ne napenja, ko serje. Drek mu zaradi prestrašenosti sam beži iz riti.", "Chuck Norris na wcju" },
                    { 79, true, 6, "Solze Chucka Norrisa zdravijo raka. Škoda samo, ker Chuck Norris še nikoli v življenju ni jokal.", "Zdravilo za raka" },
                    { 888, true, 6, "Božiček je obstajal.    Potem pa je, nekega dne, pozabil Chucku Norrisu nesti darilo.", "Božiček" },
                    { 78, true, 6, "Chuck Norris uporablja Mr. Muscolo kot kapljice za oči.", "Mr. Muscolo" },
                    { 1128, true, 6, "Chuck Norris je edini, ki lahko na androide nalozi apple aplokacije!", "Chuck Norris" },
                    { 2084, true, 6, "Chuck Norris lahko pije led po slamici.", "Chuck Norris in led" },
                    { 1554, true, 7, "Dela cigo izpot za avto pa ga instruktov vprasa:\"Ti sploh ves, kaksen znak je to?\"  Cigo:\"Znam, znam...aluminjast!", "Cigo dela izpit" },
                    { 1525, true, 7, "Kaj je bolj redko od siamskih dvojčkov?    Cigan edinec!", "Redkost" },
                    { 1524, true, 7, "Pokliče cigo svojega prijatelja: \"Kaj je stari, kaj počneš?\"    Tadrugi: \"Nič, prejle sem si glavo opral, zdaj pa malo svojo sestro porivam.\"    Prvi: \"Kaj??? Glavo si si opral?\"", "Pogovor po telefonu" },
                    { 1523, true, 7, "Ciganka vpraša svojega moža: \"Na kateri WC naj grem?\"    Mož jo takoj okara: \"Joj, si pa res neumna! Vse je jasno, saj ti piše! Ti greš na M, ker si madam, jaz pa na Ž, ker sem žentlemen!\"", "Na kateri WC naj gre" },
                    { 1522, true, 7, "Mali cigo vpraša starega cigana: \"Kako oblečem gate?\"    Tastari: \"Rumeno spredaj, rjavo odzadaj.\"", "Vprašanje, kako se obleči" },
                    { 1521, true, 7, "Kdaj si cigan umije roke? Pred scanjem ali po scanju?    Med scanjem.", "Cigan in umivanje rok" },
                    { 1520, true, 7, "Ata cigo: \"Otroci, pridite sem.\"    Ko se zberejo, jim reče: \"Danes je čas za menjavo gat.\"    Otroci: \"Huraaaaaa!\"    Oče: \"OK, ti zamenjaš z njim, ti z njim...\"", "Čas za menjavo" },
                    { 1519, true, 7, "Cigo se odloči, da bo obiskal brata v Nemčiji.    Ker je imel brat malo stanovanje, ga je namestil v hotel.    Cigo stopi v kopalnico. Gleda bano, tuš, umivalnik in vse ostalo. Vse je čisto, da se kar sveti. Nakar reče: \"Eh, škoda, da ni sobota, da bi se umil.\"", "Cigo obišče bratra" },
                    { 1518, true, 7, "Mama ciganka je dala malega cigota kopat.    Po petih minutah že sili ven iz banje, a mu stara naroči, naj se še umiva.    Ko mine pol ure zakriči: \"Mama, mama, en sloj umazanije je že odstopil.\"    Mama: \"Dobro! Ampak še ni dovolj. Še se umivaj.\"    Mali cigo se umiva še eno uro, nakar zakriči: \"Mama, drugi sloj je tudi že šel dol!\"    Mama: \"Dobro, še malo.\"    Čez eno uro: \"Mama, našel sem majico, ki sem jo izgubil pred tremi leti.\"", "Mali cigo se kopa" },
                    { 1517, true, 7, "Zakaj cigan ne spusti žene na Kubo?    Čegavara!", "Ne spusti je" },
                    { 1516, true, 7, "Zakaj mora mali cigan za 4. rojstni dan na torti upihniti kar 40 svečk?    Ker ga oče testira, če ima pljučno kapaciteto za igranje trobente.", "Rojstnodnevna torta" },
                    { 1515, true, 7, "Pride cigo v slaščičarno in reče: \"Dajte mi ljimunadu.\"    Punca, ki streže: \"Ne morete je dobiti.\"    Cigan: \"Zakaj?\"    \"Ne reče sa ljimunada ampak limonada.\"    \"Dobro, dajte limonado.\" In jo dobi.    Cigan: \"Mi daste bakljavu\".    \"Ne, ne morete.\"    Cigan: \"Zakaj?\"    Punca: \"Ne reče se bakljava, apmapk baklava.\"    Cigan: \"OK, baklavo, dajte mi baklavo.\" In jo dobi.    Ko je pojedel in spil je rekel: \"Lahko pljačam?\"    Punca: \"Ne, ne morete.\"    Cigan: \"Ooooo, najlepša hvala!\" In odide iz slaščičarne.", "Cigan v slaščičarni" },
                    { 1514, true, 7, "Kaj vpije ciganka, ki pade v vodo?    \"Na pomoč! Na pomoč, ne znam se kopati.\"", "Če slučajno pade v vodo" },
                    { 1340, true, 7, "Kaj nastane če cigana povozi valjar?    CD-rom", "Povozi ga" },
                    { 1097, true, 7, "Na ulici se srecata Cigana.  Berto: Halo, prijatelj, imas  res lepo jakno.  Brajdimir: Hvala, kupil sem  jo na popust.  Kako na popust?  Lepo, prodajalki je popustila  pozornost.", "Cigan" },
                    { 1043, true, 7, "Clovek besen pride s sodisca  in zavije v bife.  Naroci pijaco in glasno rece:  Odvetniki so cigani!  Negdo s strani se oglasi:  Halo,pazi,kaj govoris!  Francelj ga grdo pogleda:  Si ti odvetnik?  Ne,Cigan!", "Pazi, kaj govoris" },
                    { 992, true, 7, "Televizijska ekipa dela intervju s cigotom.  Kdaj ste bolje ziveli: v dobi Tita ali sedaj.  Cigo:V Titovi dobi si nabavil meso, klobase, cistila, kozmetiko,...  TV ekipa: Kako pa je danes?  Cigo: Kamera tu, kamera tam...", "V Titovi dobi ali zdaj" },
                    { 940, true, 7, "Berto, Stojan in Branimir se pogovarjajo v romski beznici.  Sama hvala jih je.    Prvi: \"V petnajstih dneh sem dal dol 35 kilogramov.\"    Se pohvali Stojan: \"Kaj to, jaz sem jih v devetih dneh 40.\"    Branimir je še boljši: \"Kar 40 kilogramov sem dal dol v osmih dneh!\"    Natakar, ki vse to posluša, ne more brez komentarja: \"Lažete, nemogoče je v tako kratkem času toliko shujšati! Poleg tega se vam sploh ne vidi.\"    Nakar vsi trije v en glas: \"Idiot, kdo pa govori o hujšanju? Mi smo se pogovarjali o bakrenih žlebovih.\"", "Cigani se hvalijo" },
                    { 848, true, 7, "Zakaj cigani raje volijo levico?  Zato ker jim desnica obljublja delo in sluzbo.", "Politika med cigani" },
                    { 847, true, 7, "Kako v ficota spravis 15 ciganov?  V njega vrzes potrdilo o socialni pomoci!  Kako pa jih spravis iz njega?  V njega vrzes potrdilo o delovni pogodbi!", "Fico" },
                    { 836, true, 7, "Zakaj cigani jocejo ko v kinu gledajo Titanik?  Zato ker se potaplja 50000 ton zeleza!", "Titanik" },
                    { 591, true, 7, "Srečata se dva cigota: »U jebote, dobar mobitel… kolko si dao?«  »Enemu malemu dva šamara.«", "Dobar mobitel ;)" },
                    { 540, true, 7, "Kako spraviš? 15 ciganov v fičota?  V njega vržeš socialno pomoč!  Kako pa jih spraviš ven?  V njega vržeš prijavnico za delo!", "Cigoti in fičo" },
                    { 503, true, 7, "Zakaj se vsi bojijo malega cigota iz 1a razreda???    Zato ker ima fotra v 8b !!!", "Cigo fajter" },
                    { 374, true, 7, "Cigani nič ne kradejo. Oni si samo sposodijo in nikoli ne vrnejo.", "Cigani ne kradejo" },
                    { 297, true, 7, "Cigan je kuhal psa. Sosedje so ga prijavili, pride policija in društvo za mučenje živali.   Vprašajo ga: \"Kaj pa delaš s psom?!\"   Cigan pa odgovori: \"Jaz nic, sam je not skocu!\"", "Pes" },
                    { 296, true, 7, "Pes ki laja, ni dovolj kuhan.", "Ciganski pregovor" },
                    { 106, true, 7, "Kaj počnejo cigani na olimpijskih igrah? smrdijo na 100 metrov", "atletika" },
                    { 2091, true, 6, "Chuck Norris lahko podatke shrani tudi na navadni ključ.", "Chuck Norris in podatki" },
                    { 1372, true, 6, "Chuck Norris je naredil samomor.    Dvakrat!", "Samomor" },
                    { 77, true, 6, "Ko je bil Chuck Norris mulc, nikoli ni močil postelje. Postelja se je sama poscala od strahu.", "Močenje postelje" },
                    { 76, true, 6, "Chuck Norris se je nekoč bojeval s sabljo. Sablja je izgubila.", "Chuck Norris in sablja" },
                    { 75, true, 6, "Na Kitajskem je obstajala legenda: Zmaj bo rodil človeka, ki bo odrastel in premagal zlo na svetu. Ta človek ni Chuck Norris. Chuck Norris je ubil tega človeka.", "Kitajska legenda" },
                    { 1775, true, 4, "Pride blondinka v bar in jo moški ogovori: \"Gospodična, kaj boste spili?\"    Blondinka: \"A si ti fukjen? Jaz imam fanta!\"    Moški: \"Pa, a si ti fukjena? Jaz sem natakar!\"", "V gostilni" },
                    { 1771, true, 4, "Blondinka je na klopci v parku sedela z novim znancem.    Ta jo je vprašal: \"Bi me hotela osrečiti?\"    \"Seveda!\" mu je zašepetala.    \"Potem mi pa predstavi svojo črnolaso prijateljico!\" ", "Nerodno vprašanje" },
                    { 1766, true, 4, "\"Tu imate zdravilo za vašega moža\", je farmacevtka rekla blondinki.  \"Pred uporabo ga je potrebno pretresti.\"    \"Le kako bom to izvedla, ko pa ima 120 kilogramov!\" je obupano dejala blondinka. ", "Blondinka v lekarni" },
                    { 1705, true, 4, "Blondinka razlaga prijateljici: \"Z očali vred imam 59 kg.\"    \"Kaj pa brez očal?\"    \"Ne vem, ne vidim\"", "Teža z in brez" },
                    { 1693, true, 4, "Blondinka v menjalnici poskuša zamenjati 50€.    Blagajničarka: \"Gospa, tole pa ne bo šlo. Denar je ponarejen.\"    Blondinka: \"Ponarejen?!!? Hitro pokličite policijo, posiljena sem bila!\"", "V menjalnici" },
                    { 1663, true, 4, "Kupuje blondinka torbico.    \"Iz kakšnega usnja je ta?\", pokaže na prvo, ki je stala 20€.    \"Iz kačje kože\", reče prodajalec.    \"Iz kakšnega usnja je ta?\", pokaže na drugo, ki je stala 50€.    \"Iz krokodilje kože\", odgovori prodajalec.    \"Iz kakšnega usnja pa je ta?\", pokaže na tretjo, ki je stala 500€.    \"Iz kože slonovega penisa\", odgovori prodajalec.    \"In zakaj je tako draga?\", zanima blodinko.    \"Ko se boš malo podrgnila ob torbico, se bo povečala v potovalno torboo.\"", "Nakup torbice" },
                    { 1619, true, 4, "Kako pravimo blondinki, kaj je kuro?    Kanibal !", "Blondinka in kokoš" },
                    { 1553, true, 4, "Se pogovarjata dve blondinki.    Prva: \"Včeraj sem naredila test nosečnosti.\"    Druga: \"A so bila težka vprašanja?\"", "Test nosečnosti" },
                    { 1531, true, 4, "Se pogovarjate dve blondikne.    Prva: \"Kako je bilo v kinu?\"    Druga: \"Grozno, trikrat sem se morala presesti.\"    Prva: \"Kaj, a so te otipavali?\"    Druga: \"Da! Ampak šele, ko sem se vsedla na četrti stol.\"", "Nadlegovanje v kinu" },
                    { 1498, true, 4, "Blondinki Maja in Mojca se pogovarjata:    Maja: \"Slišala sem, da imaš novega prijatelja.\"    \"Ja, enkraten je. Bogat je in avto ima.\"    \"Kako pa izgleda?\"    Mojca: \"Kabrio, kovinsko rdeče barve.\"", "Nov prijatelj" },
                    { 1471, true, 4, "Maja, prikupna blondinka, potuje  z vlakom. Odide na stranisce, nato  pa ne najde vec svojega kupeja.  Sprevodnik ji poskusa pomagati:   Pa se vsaj priblizno spomnite,   kje ste sedeli?  Maja: Hm, vem, da je bila zunaj  reka.", "Sprevodnik" },
                    { 1457, true, 4, "Kaj rece mama blondinki, ko gre v \"life\"?  Ce ne bos do 1h v postelji, pa pridi domov spat.", "Life" },
                    { 1455, true, 4, "Zakaj gre blondinka mimo omarice za zdravila po prstih?  Da ne bi zbudila uspavalnih tablet.", "Omarica za zdravila" },
                    { 1452, true, 4, "Zakaj blondinka sedi na prehodu za pesce?  Ker misli, da jaha zebro.", "Blondinka na zebri" },
                    { 1449, true, 4, "Blondinka na policijo prijavi posilstvo.  Bil je visok, temnolas Crnogorec.  Kako pa veste, da je bil crnogorec?  Ker sem morala vse narediti sama!", "Posilstvo" },
                    { 1448, true, 4, "Zakaj mora biti blondinka pozorna, ko grabi listje?  Da ne pade z drevesa.", "Listje" },
                    { 1442, true, 4, "Zakaj se blondinka, ko hujsa, maze s prilom?  Ker je odlicen v boju z mascobo!", "Hujsanje" },
                    { 1439, true, 4, "Blondinka poklice na brezplacno  stevilko za racunalnisko tehnicno  pomoc:  Racunalnik mi nagaja.  Kaksnega pa imate?  Belega.  Dobro. Ali mi lahko poveste,  kaj imate na monitorju?  Medvedka, ki mi ga je kupil  moj fant.", "Racunalniske tezave" },
                    { 1437, true, 4, "Zakaj imajo blondinke doma vedno tudi prazne steklenice piva?  Ker lahko pride na obisk kdo, ki ni zejen.", "Prazne steklenice" },
                    { 1436, true, 4, "Zakaj blondinka nosi crne spodnje hlacke?  Ker zaluje za nedolznostjo!0", "Crne hlacke" },
                    { 1435, true, 4, "Zakaj je okoli blondinkine banje zicnata ograja  Da ne bi odplavala predalec!", "Ograja" },
                    { 1434, true, 4, "Kaksna je razlika med desetimi kurami in blondinko?  Devet.", "Razlika" },
                    { 1356, true, 4, "Kako ves, da je fax odposlala blondinka?  Ker je na njem nalepljena znamka.", "Fax" },
                    { 1354, true, 4, "Kaj pomeni ce je na nihajnih vratih razbito steklo?  Da blondinka ni nasla kljuke!", "Razbita vrata" },
                    { 1349, true, 4, "Policist ustavi blondinko: \"Vozniško in prometno, prosim.\"  \"Kaj pa je to?\"  \"Ja, gospodična, vozniška je taksna rdeča knjižica, ki jo mora imeti vsak voznik, dobi pa jo, ko naredi izpit\"  Blondinka živčno brska po torbici in privleče rdečo knjižico: \"Je to vozniška?\"  \"Je ja, še prometno prosim?  \"Kaj pa je to?\"  \"To je pa siva knjižica, ki jo mora imeti vsako vozilo.\"  Blondinka strese vsebino torbice na sedež in izbrska sivo knjižico: \"Je ta prava?\"  \"Je in vaši dokumenti so v redu, vendar vas prosim, da malo stopite iz avta,\" reče policist in si pri tem popravlja zadrgo.  \"Joj, pa ja ne bo spet alkotest?\" ", "Blondinka in prometna kontrola" },
                    { 1272, true, 4, "Je pritekel mimo blondinke Zorro in na zid vgraviral črko Z.    Po njegovem odhodu blondinka reče poglej Zuperman je bil tu!", "Blondinka in Zorro" },
                    { 1223, true, 4, "Bozicek, zlobna vila, butasta   blondinka in pametna blondinka  hodijo po cesti in zagledajo  bankovec za 500 evrov.  Kdo ga pobere?  Jasno, butasta blondinka,   preostali trije namrec ne  obstajajo.", "Blondinka" },
                    { 1205, true, 4, "Zakaj gre blondinka na plazo z vrati od avtomobila?  Da lahko odpre okno, ce ji je vroce.", "Blondinka na plazi" },
                    { 1201, true, 4, "Kaj je ekstrem?  Ce se porocita policaj in blondinka.", "Ekstrem" },
                    { 1776, true, 4, "Blondinka na bencinski črpalki prosi delavca, da ji natoči gorivo.    Delavec: \"Bencin ali diesel?\"    Blondinka: \"Bencin.\"    Delavec: \"95 ali 98?\"    Blondinka: \"A kaj bolj novega nimate?\"", "Blondinka na pumpi" },
                    { 1778, true, 4, "Blondinka se je sprehajala ob reki in na drugi strani reke zagledala drugo blondinko.    \"Kako se pride na drugo stran?\" ji je zakričala.    \"Saj si že na drugi strani!\" ji je odgovorila blondinka. ", "Na drugo stran" },
                    { 1824, true, 4, "Mehanik pove blondinki, da bo na avtu potrebno zamenjati svečke.    \"Tega pa res ne razumem. Še nikoli jih nisem prižgala, vedno vozim s prižganimi lučmi.\" ", "Menjava svečk" },
                    { 1853, true, 4, "Blondinki sta se srečali v letalu in prva vpraša: \"Ali si ti morda iz Ljubljane?\"    \"Ne, nisem!\"    \"Jaz tudi ne!\" je druga veselo zavpila. \"Oh, kako majhen je ta svet!\" ", "Ni iz Ljubljane" },
                    { 74, true, 6, "Chuck Norris je preštel do neskončno. Dvakrat.", "Chuck Norris in štetje" },
                    { 73, true, 6, "Chuck Norris lahko deli z ničlo.", "Chuck Norris in deljenje" },
                    { 72, true, 6, "Chuck Norris je Velikega brata nominiral za izpad iz hiše.", "Chuck Norris in veliki brat" },
                    { 71, true, 6, "Chuck Norris je edini, ki se lahko podpiše na zvočni zid.", "Podpis" },
                    { 70, true, 6, "Koliko sklec je naredil Chuck Norris? Vse!", "Sklece" },
                    { 69, true, 6, "Chuck Norris je mrtev že 10 let. Ampak se mu smrt ne upa približati, da bi mu to povedala.", "Chuck Norris in smrt" },
                    { 2104, true, 5, "Karli se je spovedoval, da je sosedu z njive ukradel nekaj buč.    \"Za pokoro zmolite tri očenaše!\"    \"Tega pa ne morem.\"    \"Zakaj ne?\"    \"Ker znam samo enega!\"", "Naloži mu preveč pokore" },
                    { 2086, true, 5, "Kako se reče dečku, ki ga je spočel župnik?    Fant od fare.", "Sin od župnika" },
                    { 2008, true, 5, "Na meji mlada gospodična ogovori starejšega meniha: \"Gospod, nekaj vas bi prosila!\"    Menih: \"Da, hči, povej!\"    Gospodična: \"Kupila sem si nov ženski depilatorski strojček, pa me je strah carine ... Ali bi ga lahko vi pod kuto spravili čez.\"    Menih: \"O, hči, rad bi, a ne smem lagati! Pa se bom vseeno česa domislil.\"    Carinik: \"Oče, imate kaj za prijavit?\"    Menih: \"Od brade do pasu nič.\"    Carinik: \"Pa od pasu navzdol?\"    Menih: \"Tam je strojček za ženske, ki pa še nikoli ni bil uporabljen!\"", "Mlada gospodična in menih na carini" },
                    { 1662, true, 5, "Pride glavni direktor Coca-Cole k papežu v Rim in ga prosi, ali je mogoče, seveda za velike denarce, v molitvi \"Oče naš, ki si v nebesih, daj nam danes naš vsakdanji kruh ...\" besedo kruh zamenjati z besedo kokakola.    \"Daj nam danes našo kokakolo?\"    Pa papež razmišlja in razmišlja in slednjič le reče: \"Žal, fant, ne bo šlo.\"    Direktor poklapano odide, papež pa pokliče ekonoma: \"Ti, kdaj se nam pa izteče tista pogodba s pekom?\"", "Direktor Coca Cole v Rimu" },
                    { 1509, true, 5, "Mala Urška ni bila ravno najbolj zgledna učenka pri verouku. Pravzaprav je večino časa med poukom kar prespala.  Nekega dne, pa jo je duhovnik poklical ravno, ko je že zapadla v svoj dremež.    Duhovnik: \"Povej mi, Urška, kdo je napravil vesolje?\"  Je pa za Urško sedel Tomaž in, da bi jo opozoril jo je v hrbet špiknil s svojim svinčnikom.   \"JEZUS KRISTUS!\", je takoj zavpila Urška in duhovnik je bil presenečen ampak jo je vseeno lepo pohvalil. Tudi Urška je   bila presenečena nad pohvalo, vendar se s tem ni ravno preveč obremenjevala in je kmalu spet padla v svoj spanec.    Duhovnik je tako nadaljeval s svojim predavanjem ampak čez nekaj časa je spet prišel do Urška in jo vprašal:\"Urška, povej mi,  kdo je naš gospod in odrešenik?\"  Ker se Urška spet ni odzvala jo je Tomaž zopet rahlo premočno s svinčnikom zabodel v hrbet in Urška je spet na glas zavpila:\"O MOJ BOG!\"    Duhovnik je bil že navdušen nad njenim entuziazmom, Urška pa se ni pustila motiti in je spet kmalu zadremala. No, duhovnik pa se je odločil,  da je Urška pripravljena na bolj težko vprašanje, zato jo je vprašal:\"Kaj je Eva rekla Adamu potem, ko je rodila že njegovega 23. otroka?\"  Najprej je bilo vse tiho, potem pa jo je Tomaž hitro spet zabodel s svinčnikom, tokrat pa res premočno...  Urška:\"JEBEMTIŠ, SAMO ŠE ENKRAT VAME ZARIJ TOLE JEBENO TRDO STVAR, PA TI JO BOM POLOMILA NA POL, PA TI JO ZABILA V RIT!\"", "Neposlušna pri verouku" },
                    { 1368, true, 5, "Pride možakar k spovedi: \"Včeraj se žena nagne v hladilno skrinjo, mene pa prime in jo kresnem od zadaj, a je to greh?\"    Župnik: \"Ne, to je naravno, tako mora biti.\"    Naslednji dan pride žena k spovedi: \"Gospod župnik, jaz grem v hladilno skrinjo iskat meso, naš pa mene od zadaj, a je to greh?\"    Župnik: \"Ne, saj je že včeraj vaš mož spraševal isto in sem mu povedal, da je to naravno in tako mora biti.\"    Ženska pa: \"A sva še naprej dobrodošla v cerkvi?\"    Župnik: \"Seveda...\"    Ženska. \"Dobro, ker v Merkatorju nisva več.\"", "Mož jo je kresnil" },
                    { 1266, true, 5, "Starejši par sedi v cerkvi pri maši.    Žena se nagne k možu. \"Potiho sm prdnla a bo ok?\"     Mož odgovori: \"Zamenjaj si batarije v slušnem aparatu!\"", "Pri maši" },
                    { 1167, true, 5, "Sv.Peter pride do boga in mu  rece:  Zunaj pred vrati so stirje ateisti,   ki bi radi govorili z vami.  Reci jim, da me ni!", "Ateisti" },
                    { 1044, true, 4, "Kaj pomeni, ce vidis blondinko, ki ima eno boso nogo?  Da je racunala do 15!", "Blondinka " },
                    { 811, true, 5, "Zakaj je bil Adam najsrecnejsi moski?  Ker ni imel tasce!", "Adam in sreca" },
                    { 604, true, 5, "Je bil župnik pred božičem na romanju, pa pride proti večeru do samostana in potrka ter prosi za prenočišče. Menih mu pove da posteljo še imajo prosto, da pa si bo moral sobo deliti z nuno.   Pa pravi župnik:   \"Brez panike, saj živimo v celibatu!\".   Pride čas za spanje, župnik je že v postelji, ko pride nuna. Nuna se sleče, odpre okno, si nagrabi snega in si ga začne ribati po mednožju.   Župnik jo vpraša, zakaj to počne. Pa pravi:   \"Zato, da imam v spominu, da je tam spodaj vse hladno in zamrznjeno...\"   Pa zgrabi župnik rožni venec in si ga namota okoli batine. Nuna ga vpraša, kaj naj to pomeni.   > Župnik: \"Ketne montiram!\" ", "Led in ketne" },
                    { 601, true, 5, "Pride nuna h ginekologu na pregled.   \"Noseči ste,\" postavi doktor neverjetno diagnozo.   \"Kaj,\" je ogorcena nuna, \"kako je to mogoce?\"   Doktor jo le stežka prepriča, DA je njegova diagnoza pač pravilna in je res noseča.   Nuna odide iz ordinacije naravnost v cerkev, se postavi na sredino in se na ves glas zadere:   \"Kateri kurac si ga je drkal po svečah!?\"", "Noseča nuna" },
                    { 489, true, 5, "Janez gre k spovedi. Župnik ga pričaka in mu reče, da lahko svoje kolo parkira pred cerkvijo in sveti duh ga bo čuval.  Možakar parkira kolo in gre v spovednico.    Tam mu župnik naroči, naj ponavlja za njim: \"V imenu očeta in sina in svetega duha, amen.\"    Janez ponovi: \"V imenu očeta in sina, amen.\"    Župnik: \"Kje pa imaš svetega duha?    Janez: \"Ja pred cerkvijo pazi na moje kolo.\"", "Sveti duh" },
                    { 384, true, 5, "Na Brezjah prileti iz cerkve starejši moški, pogleda okrog sebe in začne vpiti: »Spet bom hodil, spet bom hodil!«  Starejša ženička stopi k njemu in vpraša: »Gospod, a je čudež?«  »Kakšen čudež! Medtem ko sem bil v cerkvi, so mi ukradli moped!« ", "Kraja" },
                    { 270, true, 5, "Novi župnik je bil pred svojim prvim bogoslužjem tako živčen, da iz sebe ni spravil niti besedice.     Tako je za nasvet vprasal škofa. Ta mu svetuje, naj pred mašo v kozarec vode kapne 2 kapljici Tequille, naj to spije in ne bo več živčen.     To novi župnik stori in izgubi nervozo. Šlo mu je dobro. Bil je tako miren, da ga tudi najhujše neurje ne bi moglo spraviti iz tira.     Ko je novi župnik hotel oditi iz zakristije, je na mizi našel napisan list, ki mu ga je napisal škof:     ----    Spoštovani župnik!     Imam nekaj pripomb glede vaše prve maše in upam, da se tak dogodek na naslednjem bogoslužju ne ponovi:     1. Na rob keliha ni potrebno zatikati nikakršnih limoninih rezin.     2. Kabinica poleg oltarja je spovednica in ne WC.     3. Božjih zapovedi je 10 in ne cirka 12.     4. Apostolov je bilo 12 in ne približno 7.     5. Jezusa in apostolov ne poimenujemo J.C. and the gang.     6. David je Goljata premagal z metom kamenja v glavo in ga ni nafiksal s kokainom do smrti.     7. Judasa ne poimenujemo kurbin sin in Papeža ne poimenujemo El Padrino.     8. Bin Laden ni imel nikakršnega opravka s smrtjo Jezusa.     9. Blagoslovljena voda ni tam za umivanje obraza in vratu, temveč za blagoslavljanje.     10. Zakaj ste mašno vino spili z enim požirkom, zatem polizali sol z roke in na koncu ugriznili v rezino limone, mi tudi ni čisto jasno.     11. Predvsem pa ne smete moliti tako, da se usedete na stopnico pred oltarjem in položite noge na Sveto pismo.     12. Hostije niso mišljene kot prigrizek k vinu, ampak so mišljene za vernike.     13. Noe je zgradil barko in ne >offshore-Boat<.     14. Abraham ni bil >Ata Smrk<.     15. Povabilo k plesu ni tako slaba zamisel, vendar pa je skakanje v koloni skozi celotno cerkev šlo predaleč.     16. >P... z majhnimi joški< je Devica Marija. Ni potrebe, da njen kip stalno objemate, poljubljate in ližete.     17. Tako imenovani >Freak< nad oltarjem je Jezus. In on tam tudi ne visi kar tako, temveč je pribit na križ.     18. Tisti, ki je stal v kotu cerkve pri pevskem zboru in katerega ste poimenovali >transvestitska pederčina v dolgi kikli< sem bil jaz!     19. Naslednjič vas prosim, da date 2 kaplji Tequille v kozarec vode in ne obratno. ", "JC and The Gang" },
                    { 117, true, 5, "Faran: “Oče, imel sem bližnje srečanje z neko žensko ... skoraj ...”  Župnik: “Kako to misliš ... skoraj ... sin moj?”  Faran: “No, slekla sva se, legla v posteljo, drgnila najine intimne dele ... pa sem se pravočasno ustavil, še preden bi se lahko kaj resnega zgodilo ...”  Župnik: “Sin moj, drgnenje intimnih delov je isto kot da bi ga dal noter. Pusti to žensko, za pokoro pa zmoli petdeset očenašev in vrzi 50 € v pušico za reveže ...”  Naslednjo nedeljo:  Župnik: “Sin moj, si zmolil pokoro, ki sem ti jo naložil prejšnjo nedeljo? Si izpolnil vse, kar sem ti naročil?”  Faran: “Sem, seveda sem, oče.”  Župnik: “Nisem opazil, da bi vrgel 50 € v pušico za reveže.”  Faran: “No, z bankovcem za 50 € sem podrgnil po pušici, noter ga pa nisem dal. Pa saj ste sami rekli, da je drgnenje isto, kot da bi ga dal noter.”", "faran pri spovedi" },
                    { 2124, true, 4, "Pride blondinka na Petrol.    Boste 95 ali 98 jo vpraša bencin kelner.    Blondinka: \"A letošnjega pa nimate?\".", "Blondinka na črpalki" },
                    { 2109, true, 4, "Mlad lovec osvaja blondinko in jo povabi s seboj na lov, da bi ji pokazal, kakšen strelec je. Ko prileti nekaj rac, eno ustreli v letu in raca pade pred njune noge. Blondinka pravi: \"Lahko bi prihranil metek, padca s te višine itak ne bi preživela.\"", "Višina" },
                    { 2103, true, 4, "v letalu se na sedežu znajdeta bjonda in advokat.    Ona se ravno pripravlja na dremež ,ko se k njej skloni odvetnik in ji predlaga igrico.    Blondinka ni za stvar. Ne drugič,ne tretjič,ne četrtič.    Naposled je tudi advokatu dovolj.Zdaj predlaga,da ji bo zastavil vprašanje.Če nanj ne bo pravilno odgovorila,mu dolguje 5 evrov,če pa on ne bo pravilno odgovoril na njeno vprašanje,bo ona dobila 500 evrov.    Blondinka klone.Advokat: \"Koliko kilometrov je od Zemlje do Lune?\"    Bjonda mirno seže v torbico in mu da 5 evrov.    Zdaj je na vrsti ona: \"Kaj je to? Zjutraj gre s tremi nogami na drevo, zvečer pa s štirimi dol pride?\"    Odvetnik se praska po glavi, odpre prenosni računalnik, se poveže z internetom,a nič. Kliče tudi svoje kolege, a neuspešno. Naposled prizna poraz, zbudi svetlolasko in ji da 500 evrov.    A radovednost mu ne da miru: \"In kakšen je odgovor na tvoje vprašanje?\"    Blondinka spet seže v torbico in mu da 5 evrov.", "Blondinka in advokat" },
                    { 2082, true, 4, "So šle 3 blondinke v gozd po novoletno jelko.    Iščejo od jutra pa vse do mraka.    Končno 1 predlaga: \"Kaj pa če vzamemo kar eno brez okraskov?\"", "Blondinke in novoletna jelka" },
                    { 1966, true, 4, "Slišal sem, da je hišnik spal že z vsemi ženskami iz našega bloka, razen z eno je rekel mož svoji ženi blondinki.    \"Ja, to je gotovo tista važna iz petega nadstropja\" ugotavlja blondinka.", "Spal je skoraj z vsemi" },
                    { 1883, true, 4, "Blondinka v cvetličarni: \"Želim lepo rdečo vrtnico.\"    \"Dolgo?\"    \"Kaj? Tudi izposodim si jo lahko?\"", "Blondinka v cvetličarni" },
                    { 1874, true, 4, "Blondinki se v gozd odpravita iskat božično drevo.    Nenadoma se ena ustavi in reče: \"Jaz imam tega dovolj. Ne grem se več!\"    \"Kako to misliš?\", vpraša druga.    Pa ji odgovori: \"Dovolj imam iskanja božičnega drevesa. Prvo drevo, ki ga zagledava, vzameva, četudi brez okraskov!\"", "Blondinki v gozdu" },
                    { 1867, true, 4, "Pri zajtrku ljubimec vpraša blondinko: \"Zakaj so pa jajca tako trda? Kako dolgo si jih pa kuhala?\"    \"Trideset minut!\"    \"Kako? Trideset minut? Jajca se kuha največ pet minut!\"    \"To vem, ampak jajc je bilo šest!\" ", "Kuhana jajca za zajtrk" },
                    { 606, true, 5, "Pride mladenka v cerkev k spovedi.   -Oče, spala sem z župnikom iz sosednje fare, ali je to greh?   -Seveda je greh dete, ti pripadaš tej fari.", "Pri spovedi" },
                    { 1849, true, 11, "\"Pojdiva danes zvečer ven in se zabavajva!\" je ženi predlagal mož.    \"Prav!\" je dejala žena.    \"Ampak če boš doma pred menoj, pusti vrata odklenjena!\" ", "Da ne bo tako monotono" },
                    { 1856, true, 11, "Micka je umirala in na smrtni postelji je prosila Jožeta: \"Prosim, ne dovoli, da bi tvoja naslednja žena nosila moja oblačila!\"    \"Bodi kar brez skrbi, saj ji tako ali tako niso prav!\" ", "Na smrtni postelji še zadnja želja" },
                    { 1860, true, 11, " Na sodišču sprašujejo ženo: \"Zakaj je umrl vaš prvi mož?\"    \"Zaradi zastrupitve z gobami, gospod sodnik.\"    \"Zakaj pa je umrl vaš drugi mož?\"    \"Tudi zaradi zastrupitve z gobami, gospod sodnik.\"    \"Pa tretji mož?\"    \"Bila je nesreča, padel je po stopnicah, ni maral gob.\"", "Zasliševanje na sodišču" },
                    { 1555, true, 18, "Vprasa sodnik Mujota na sodiscu: Zakaj ste povozili 52 ljudi?  Mujo: Odpovedale so mi zavore s hriba v dolino.  Zakaj pa niste kam zavili, da ne bi povozili toliko ljudi?  Saj sem. Na desni strani sta bila dva cloveka, na levi na avtobusni postaji pa 50. Pomislil sem, da je bolje, da povozim dva in zavil na desno. Toda, ko sem povozil prvega, je oni drugi idiot stekel med tistih 50!", "Mujo na sodiscu" },
                    { 1528, true, 18, "Mujo pelje svojo ženo po plaži na sprehod.    Srečata slikarja, ki na platno riše sončni zahod.    Mujo: \"Fata, a vidiš kako se matra, ker nima fotoaparata?\"", "Sprehod po plaži" },
                    { 1527, true, 18, "Mujo: \"Haso, koliko otrok imaš ti?\"    Haso: \"Pet.\"    Mujo: \"Kako to, saj si star šele 21 let?\"    Haso: \"Saj vem. Zdaj niti iz hrenovke ne slečem več ovoja.\"", "Kotracepcija" },
                    { 1526, true, 18, "Mujo toži Fati: \"Fata, kaj je to? Že šest dni ležim zraven krave in čakam, da bo povrgla, pa nič!\"    Fata: \"Logično, ko te vidi ležat poleg nje misli, da se je tele že povrglo.\"", "Breja krava" },
                    { 1486, true, 18, "En model ulovi zelo debelo zlato ribico in jo vpraša: \"zakaj si tako debela?\"    Ribica : \"Me je Mujo ujel in sem mu rekla, da mu izpolnim 3 želje, če me izpusti. Pa me je vrgel nazaj v vodo in rekel: ajd ne seri.\"", "Ulovil je zlato ribico" },
                    { 1376, true, 18, "Reče Mujo Hasotu: \"Ja volim paranormalne žene!\"    Haso začudeno: \"Kakve su ti to žene?\"    Mujo: \"Pa one normalne, samo što imaju para!\" ", "Rad ima paranormalne" },
                    { 1367, true, 18, "Se vozita Mujo in Haso v avtobusu.    Vročina za popizdit in šofer ju vpraša: \"Hočete li, da vam pustim air condition?\"    Haso: \"Ma daj rađe neke narodnjake nismo mi za taj hard rock.\"", "Vročina na avtobusu" },
                    { 1325, true, 18, "Vpraša Mujo Fato: \"Fato, mogu li te zvati Eva?\"    Fata: \"Pa zašto?\"    Mujo: \"Ti si mi prva i jedina!\", ji razloži mujo.    Potem fata vpraša Mujota: \"A mogu li ja onda tebe zvati Peugeot?\"    Mujo: \"A zasto?\"    Fata: \"Jer si mi 607!\"", "Vzdevki" },
                    { 1320, true, 18, "Mujotu je umrla žena. Odloči se, da bo dal osmrtnico v časopis.    Uslužbenka mu razloži: \"Pet besed je zastonj, za vsako nadaljnjo pa bo treba plačat\"    Mujo misli in premišljuje in se odloči: \"Dajte napisati UMRLA FATA\".    Uslužbenka pravi: \"To sta samo dve besedi, lahko dodate še tri in osmrtnica bo še vedno brezplačna!\"    Mujo spet misli in misli pa ji reče: \"Dodajte še PRODAJEM GOLF DIZEL!\"", "Fata je umrla" },
                    { 1317, true, 18, "Preko Atlantika pluje ladja in mornarji naenkrat opazijo v vodi Mujota, ki plava sem in tja.    Potegnejo ga na krov in kapitan ga vpraša, kaj dela sredi Atlantika.  Mujo pravi: \"Dobio sam nagradil put oko svjeta za dvije osobe. Ja uzeo sa sobom svoju majku.\"    Kapitan ga vpraša, kakšno zvezo ima to z njegovim plavanjem po Atlantiku.    Mujo pojasni: \"Letimo ti mi nekim Boingom, kad ti ona stevardesa kaže: Vankufer. I ja uzmem kufer, te ga bacim van. Nije prošlo ni pola sata, kad ona kaže: Jamajka. Bacim ja i majku. Opet ni bilo ni pet minuta, kaže ona: Hajiti. I eto ti mene tu.\"", "Mujo na potovanju okoli sveta" },
                    { 1207, true, 18, "Mujo se odpravi delat v Nemcijo, da bi dokazal, da se da na posten nacim zasluzit. Po desetih letih koncno zasluzi dovolj, da si lahko kupi mercedesa in se odpravi v Bosno, da bi ga pokazal. Na poti mu poci guma. Ko menjava gumo, pride mimo Haso in ga vprasa kaj dela.   Mujo:\"Gumo jemljem dol.\"  Haso pobere kamen in ga vrze v sipo:\"Dobro, ti vzami gumo, jaz bom pa avtoradio!\"", "Mujo dela v Nemciji" },
                    { 1163, true, 18, "Vroce poletje. Mujo in Haso pa se druzita v elitni okolici.   Mujo: To je zivljenje: sonce, voda in pesek...  Haso: Utihni in vrzi lopato v mesalec!", "Vroce poletje" },
                    { 1161, true, 18, "Mujo: Kje bos za novo leto?  Haso: Doma, kje pa cem bit.  Mujo: Si videl on reklamo, ko lahko za 400eur na Dunaju pricakas novo leto.  Haso: In, bos sel?  Mujo: Si nor, za 400 eur lahko v Bosni pricakam 1. maj.", "Novo leto na Dunaju" },
                    { 1156, true, 18, "Mujo je lovil ribe in ujel zlato ribico. Zlata ribica mu v zameno, da jo izpusti, zeli izpolniti tri zelje.   Mujo:\" Zelim novi Audi A 4.\"  Zlata ribica: \"Zelis na leasing ali na kredit?\"  Mujo: \"Zelis ti na olje ali na mast?\"", "Mujo in zlata ribica" },
                    { 1095, true, 18, "Mujo vprasa Hasa, ali bi bil raje lep ali neumen.  Haso: \"Neumen.\"  Mujo: \"Zakaj pa?\"  Haso: \"Ker je lepota minljiva!\"", "Smesno vprasanje" },
                    { 1094, true, 18, "Mujo je dobil dvojcka in je obema dal ime Suljo.  Fata:\"Budalo, zakaj si dal obema ime Suljo?\"  Mujo: \"Ko se bom zadrl: Suljo prinesi pivo, bom takoj imel pred seboj dva piva!\"", "Mujo dobi dvojcka" },
                    { 1093, true, 18, "Mujo in Haso na letaliscu opazujeta letala.  \"Haso, kako lahko nekdo ugrabi letalo, ko pa so tako velika?\"  \"Tepec\", odgovori Haso. \"Ugrabijo jih, ko so v zraku in so cisto majhna!\"", "Na letaliscu" },
                    { 1046, true, 18, "V šoli se učenci pogovarjajo o svojem izvoru.  In vpraša učiteljica malega Mujota:  Mujo kje si ti rojen?  Mujo: V Kopru.  Učiteljica: Torej si Slovenec Mujo?  Mali Mujo: Seveda.  Čez 5 sekund se sliši iz zadnje vrste glas malega Janezka:  Gospa učiteljica, to torej pomeni, da če je osel rojen v Lipici,  je potem Lipicanec?", "Mujo Slovenec" },
                    { 1013, true, 18, "Mujo dobi stanovanje v bloku.    Gospod iz stanovanjske mu preda ključ in mu razkaže prostore:  \"Tu imate kuhinjo.\"  \"Tu je spalnica.\"  \"Tu je straniče.\"    Mujo pri tem vzklikne: \"A baš u mom stanu !!\"", "Mujo dobi stanovanje" },
                    { 1012, true, 18, "Mujo je moral nujno odpotovati, pa je prosil Hasota, da mu tačas vodi lekarno. Ko se vrne, ga vpraša kako je bilo.    Haso: \"Bio je Meho, i rekao je da ga boli glava.\"  Mujo: \"I što si mu dao?\"  Haso: \"Aspirin.\"    Mujo: \"Odlično, i tko je još bio?\"  Haso: \"Bila je Fata, i rekla je da nije tri mjeseca kurca vidila.\"  Mujo: \"I što si joj dao?\"  Haso: \"Kapi za oči.\"", "Haso je lekarnar" },
                    { 1011, true, 18, "Je šel Mujo že petič na izputno vožnjo. Pride domov in Fata ga vpraša: \"Kako je bilo?\"    Mujo: \"Ma pusti me bona, opet sam pao!! Jebo me u krivini, jebo me u pravcu, jebo me na semaforu !!!\"    Nakar pravi Fata: \"Mene samo jebo u garaži, i ja položila iz prve!\"", "Padel na izpitni vožnji" },
                    { 1010, true, 18, "Mujo v Ameriki zagleda avtomat za Coca-Colo. Vrže prvi kovanec in dobi Coca-Colo, vrže drugega, spet dobi Coca-Colo, vrže tretjega....in za njim se nabere vrsta.    Eden iz vrste pride do njega: \"A nimate že dosti!? Mi smo tudi žejni!\"    Mujo mu odgovori: \"Dok Muju dobiva, Mujo igra.\"", "Avtomat za Coca Colo" },
                    { 1009, true, 18, "- Zdravo Mujo, čuo san, da si kupia novi auto.  - Jesan, bre.  - A koji?  - Nisan, bre.  - Pa šta, jes' il' nis'?  - Pa jesan !  - A koji, pitam te drugi put!  - Nisan, bre!  - Ajd, bež u pizdu mater!  ...  - A koje je boje taj tvoj Nisan?  - Bež.  - Nemoj ti meni bež', pitah ja, koje boje je avto.  - Rekoh bež.  - Dobro, dobro, odoh ja.", "Kupil je avto" },
                    { 934, true, 18, "Vprasa uciteljica: Mujo, koliko je dva in dva?  Mujo: Cetri  Uciteljica: Dobro, Mujo, sjedi, pet.  Mujo sede v klop: Pa znao sam da je pet.", "Matematika" },
                    { 918, true, 18, "Mujo na upravni enoti zaprosi za slovensko državljanstvo.    Po končanem postopku vpraša uslužbenko:    \"Na katerem okencu pa dobim slovenske značilnosti?\"    \"Prosim?\"    \"Saj veste: jamranje, nevoščljivost...\"", "Mujo in državljanstvo" },
                    { 877, true, 18, "Se po vec letih srecata Mujo in Haso.  Mujo: Haso, pa kje si mi ti?   Haso: Studiral sem mednarodno pravo.  Mujo: Res, kje pa?  Haso: V arestu v Nemciji!", "Mednarodno pravo" },
                    { 876, true, 18, "Fata: Mujo, kaj je za tebe najvecja romantika?  Mujo: Nogometni stadion, osvetljrn z zarometi.", "Romantika" },
                    { 852, true, 18, "Gresta Mujo in Fata po dzungli in srecata Tarzana in opico Cito.  Pa se Tarzan predstavi: Jaz Tarzan, ona Cita.  Pa Mujo nazaj: Jaz Mujo, ona ne cita. In pokaze na Fato.", "Dzungla" },
                    { 851, true, 18, "MUJO SE REGISTRIRA NA FACEBOOK....  Upisite vas password  sarma  Zao nam je, password mora sadrzavati vise od 8 znakova  kuvana sarma  Zao nam je, password mora sadrzavati bar jednu brojku  1 kuvana sarma  Zao nam je, password ne smije sadrzavati razmake  5jebenihkuvanihsarmi  Zao nam je, password mora sadrzavati bar jedno veliko slovo  5jebenihKUVANIHsarmi  Zao nam je, password ne smije sadrzavati vise od jednog velikog slova uzastopce  5jebenihKuvanihsarmi, i da se nosis u pizdu materinu govno jedno  Zao nam je, password ne smije sadrzavati interpukcijske znakove  5jebenihKuvanihsarminabijemtenakuracitebeitvojpasswordmamicutijebemkretencino  Zao nam je, taj password se vec koristi", "MUJO I FB " },
                    { 1607, true, 18, "Haso je šel obiskat Mujota v bolnišnico.    Haso: \"Kako je, Mujo? Kaj pravijo zdravniki?\"    Mujo: \"Slabo, slabo.\"    Haso: \"Kako slabo?\"    Mujo: \"Zelo slabo! Imam kislino v želodcu, vodo v kolenu in sladkor v krvi.\"    Haco: \"Človek, pa ti si živa limonada!\"", "Mujo v bolnišnici" },
                    { 850, true, 18, "MUJO SE REGISTRIRA NA FACEBOOK....  Upisite vas password  sarma  Zao nam je, password mora sadrzavati vise od 8 znakova  kuvana sarma  Zao nam je, password mora sadrzavati bar jednu brojku  1 kuvana sarma  Zao nam je, password ne smije sadrzavati razmake  5jebenihkuvanihsarmi  Zao nam je, password mora sadrzavati bar jedno veliko slovo  5jebenihKUVANIHsarmi  Zao nam je, password ne smije sadrzavati vise od jednog velikog slova uzastopce  5jebenihKuvanihsarmi, i da se nosis u pizdu materinu govno jedno  Zao nam je, password ne smije sadrzavati interpukcijske znakove  5jebenihKuvanihsarminabijemtenakuracitebeitvojpasswordmamicutijebemkretencino  Zao nam je, taj password se vec koristi", "MUJO I FB " },
                    { 1647, true, 18, "Mujo je v Nemčiji za svojo Fato kupil usnjeno jakno za 500 Eur in jo poslal Fati v domovino.    Da je ne bi skrbelo, ji napiše, da je dal zanjo 100 Eur.    Čez tri dni dobi pismo:\"Mujo, pošlji še več takih jaken! Odprla sem firmo, tisto jakno sem takoj prodala za 150 Eur!\"", "Nova jakna" },
                    { 2088, true, 18, "Mujo in Haso sta lovila ribe, nakar ulovita zlatega kuharja.    Zlati kuhar: \"Mujo, mujo izpusti me! Izpuniču ti tri paprike!\".", "Mujo, haso in ribolov" },
                    { 1297, true, 21, "France se vrača iz gostilne in le s težavo lovi ravnotežje.    Sam pri sebi naglas razmišlja: \"Neverjetno! Le kako lahko vse vino steče na eno stran, da me vleče malo v levo, pa potem spet vse na desno, da me vleče malo v desno!!!\"", "Čudna gravitacija" },
                    { 1295, true, 21, "France, ki se ga je precej nalezel, ustavi taksi. Ko odpre vrata na drugi strani avtomobila, pade ven. S težavo vstane in skozi okno reče vozniku: \"To je pa bila zelo hitra vožnja! Koliko sem pa dolžan????\"", "Dogodivščine s taksijem" },
                    { 1294, true, 21, "\"Zakaj sta se z Ireno razšla?\"    \"Nisva več zdržala skupaj!\"    \"Kaj pa je bilo tako hudega?\"    \"Ona me ni prenašala, ko sem bil pijan, jaz pa nje ne, ko sem bil trezen!!!\"", "Razšla sta se" },
                    { 1293, true, 21, "\"Kako si ugotovil, da je Branko pijan?\"    \"Kako pa ne bi? Saj je začel govoriti, da se ne boji žene in da se s taščo odlično razume!!!\"", "Očitno je pijan" },
                    { 1292, true, 21, "Dolenjec gre iz gostilne in se zaleti v mimoidočo žensko.    Ta mu takoj primaže eno okrog ušes, on pa se strese in reče: \"Madonca, taku hitru pa še nikul nej s'm pr'šu damu!!!\"", "Uleti iz gostilne" },
                    { 1291, true, 21, "Štajerec: \"Jaz pijem le takrat, kadar nimam drugega dela!\"    Dolenjec: \"Jaz pa delam le takrat, kadar nimam nobene pijače!!!!\"", "Štajerc, dolenjc in pijača" },
                    { 1290, true, 21, "Prijatelja, ki sta preveč pogledala v kozarec, se peljeta domov od Višnje Gore proti Ivančni Gorici. Avto drvi od bankine do bankine, pa reče prvi: \"Paz', kaku voziš!\"    \"Jest? A ne šofiraš ti?\"", "Nalita na cesti" },
                    { 1289, true, 21, "\"France, posodi mi no 5 eurov za en liter pa še malo. Mi plačo dobimo šele jutri,\" fehta Jože.    \"Žal ne morem. Veš, mi smo jo dobili že včeraj.\"", "Nima za pijačo" },
                    { 1288, true, 21, "Jože se zjutraj zbudi v celici za streznitev.   Ko zagleda policaja, ga vpraša: \"Zakaj ste me pa pripeljali sem?\"    Policaj: \"Zaradi pijače.\"    Jože, veselo: \"Krasno! Kje jo pa imate???\"", "Na iztreznitvi" },
                    { 1287, true, 21, "France se pijan vrne domov in žena ga jezna pričaka na vratih: \"Nikar se ne jezi, ljubica. Veš, da imam rad samo tebe!\"    \"Figo me imaš rad. Če bi me imel rad, ne bi pil vsak dan.\"    \"Motiš se, draga. Ko sem pijan te imam dvakrat bolj rad.\"    \"Kako pa to?\"    \"Ker te pijan dvojno vidim!\"", "Pije vsaki dan" },
                    { 1286, true, 21, "\"France, le kako lahko popiješ toliko alkohola?\"    \"Plačaj mi en liter vina - pa ti takoj pokažem!\"", "Pitje alkohola" },
                    { 1281, true, 21, "\"Gospod, po cesti ste vozili cik-cak. Ste mogoče kaj pili?\" zanima policaja.    \"Hk, jest nejsm, hk, n'č pil.\"    \"Zakaj ste pa potem tako vozili?\"    \"Da ne bi povozu belih miši.\"", "Cik cak vožnja" },
                    { 1267, true, 21, "\"Kako te je pa včeraj zvečer sprejela žena, ko si prišel tako nabrgljan domov?\"    \"Vame je metala rožice.\"    \"Kaj takega!\"    \"Ja, samo iz lončkov jih pa ni dala.\" ", "Pijan je prišel domov" },
                    { 1215, true, 21, "Korel Poldetu: \"Zdravo, prijatelj! Ti pa ne izgledaš najbolje.\"    Polde: \"Mogoče res, a sem že bil pri zdravniku. Priporočil mi je več zelenjave.\"    \"In kaj si ukrenil?\"    \"Namesto ene olive dam sedaj v martini po dve ali tri.\"", "Doktorjev nasvet" },
                    { 1212, true, 21, "Ferdo se primerno okajen opoteče v cerkev in sede v spovednici na klop.    Župnik čaka, da bo kaj rekel, a se nič ne zgodi. Zato nekajkrat diskretno zakašlja, vendar z druge strani nobenega odziva.    Nazadnje potrka na predelno steno.    \"Ne trkajte,\" se naposled oglasi Ferdo, \"tudi na tej strani ni papirja.\"", "Zateče se v cerkev" },
                    { 1169, true, 21, "Gas po telefonu: \"Dober dan. Ali je to društvo za pomoč alkoholikom?\"    \"Da, kako vam lahko pomagamo?\"    \"Kako se naredi bovla?\"", "Društvo za pomoč alkoholikom" },
                    { 1014, true, 21, "Se pogovarjata dva pijančka za šankom.  Prvi: \"Veš, tri dobre razloge imam, da ženi pred seksom nataknem gas masko.\"    Drugi: \"Kateri trije razlogi so to?\"    Prvi: \"Takole je:  - ni mi treba gledati, kako je grda  - ni mi treba vohati, kako ji iz ust smrdi  - in hudičevo dobro začne mešati, ko ji dam pokrov gor na filter\"", "Gas maska" },
                    { 951, true, 21, "Dva pijana prijatelja se vozita po cesti.    Šofer, koma pijan: \"Daj odlepi nalepke iz pivovskih flaš, pa nama jih nalepi na čelo.\"    Sopotnik takoj uboga in nalepi etikete obema na čelo in še na vsako lice po eno.    Nedolgo zatem ju ustavi policija.    Policaj: \"Prometno in vozniško, prosim.\"    Šofer, opotekajoče: \"Izvolijo.\"    Policaj: \"Gospod, ali ste kaj popil?\"    Šofer: \"Ne, nisem. Niti videl nisem alkohola!\"    Policaj: \"Kaj pa imate to nalepljeno na čelu?\"    Šofer obmolkne, nakar se oglasi sopotnik: \"Oba sva alkoholika, pa sva si nalepila obliže.\"", "Pijana na cesti" },
                    { 737, true, 21, "Mlada punca je, utrujena od dolgega sprehoda po parku, sedla na klop in se zleknila nanjo. Mimo je prišel klošar, sedel poleg nje in jo vprašal:  “Punca, ali si razpoložena za kakšno igrico?”  “Sram naj vas bo. Kaj pa si mislite o meni?”  “Kaj neki pa naj bi si mislil, saj si vendar v moji postelji!”", "Klopca" },
                    { 655, true, 21, "Policaj ustavi avto, ki pridrvi dvesto, omejitev pa štirideset: \"Vi, ali niste videli table z omejitvijo hitrosti?\"    Voznik protestira: \"Kako neki! Potem pa vi to poskusite pri tej brzini in še malo okajeni!\"", "Spregledal je" },
                    { 536, true, 21, "Kaj je, v mrzli zimi, boljše od kozarca kuhanega vina?    Dva kozarca kuhanega vina!", "Kuhano vino" },
                    { 532, true, 21, "Dva se prepirata za šankom.    Prvi: \"Ti si res pravi osel, samo da ti še rogovi manjkajo!\"  Drugi: \"Saj osli nimajo rogov!\"  Prvi: \"No, potem ti pa sploh nič ne manjka!\"", "Pravi osel" },
                    { 468, true, 21, "Bolnik pride k zdravniku. Ta ga preiskuje do onemoglosti, na koncu pa reče: \"Ne morem in ne morem odkriti kaj vam je! Ampak mislim, da je kriva pijača.\"    Pacient odgovori: \"Nič hudega, bom pa prišel, ko boste trezni.\"", "Pijača je kriva" },
                    { 447, true, 21, "\"Francl, k'daj teb špricer najbul paše?\"    Francl: \"Ku smrejke zelenijo.\"    \"Pa sej smrejke so ja skuz zeljane?!\"    Francl: \"Vejm ...\"", "Dolenjski pogovor" },
                    { 438, true, 21, "Ko sem pijan me vsi vidite!    Ko sem pa žejen pa nihče!", "Kdaj me vidite?" },
                    { 424, true, 21, "Kaj je vrhunec pijančevanja?    Da objemaš tuš in mu govoriš, naj neha jokat!", "Višek pijančevanja" },
                    { 302, true, 21, "Prijatelja v baru, za šankom.    Prvi reče: \"Poglej tisto, kako je namazana!\"    Drugi: \"Tista je pa sigurno prostitutka!\"    Prvi: \"Mislim da ne. Prej bi rekel, da je kurba!\"", "Umazana je" },
                    { 291, true, 21, "\"Peter, ali si že slišal, da je Uroš prenehal piti?\"    Peter: \"Nemogoče! Saj pije že vse življenje! Ali je šel na zdravljenje?\"    \"Ne, umrl je!\"", "Nehal je popivati" },
                    { 272, true, 21, "Kadar ležiš in se moraš za nekaj držati, ker si tako pijan.", "Kdaj si dejansko pijan?" },
                    { 1756, true, 18, "Mujo se s Štefanom pelje po Ljubljani. Ko prideta na križišče do semaforja, Štefan opazi rdečo luč. Mujo pa kar pelje.    Štefan ga vpraša, zakaj je peljal skozi?    \"Moj brat Haso bi tudi...\"    Na naslednjem križišču se zgodba spet ponovi.    Potem pa prideta do naslednjega križišča in semaforja z zeleno lučjo. Mujo ustavi.    Štefan pa ga vpraša: \"Zakaj si pa sedaj ustavil?\"    \"Kaj pa, če pride mimo moj brat Haso, a?\"", "Počaka pri rdeči" },
                    { 807, true, 18, "Mujo in Haso lovita ribe in ujameta zlatega kita.   Kit: Ce me spustita, vama izpolnem tri zelje.   Mujo in Haso: Jebes ti tri zelje, ti gres z nama k zlatarju.", "Kit" },
                    { 804, true, 18, "Mujo in Haso lovita ribe in ujameta gosko, ki jima obljubi, da ce jo spustita bo vsakemu znesla eno zlato jajco. Ko bosta imela jajco, si zazelita tri stvari in vrzeta jajco na tla.  Mujo in Haso ponudbo sprejmeta in se odpravita domov. Mujo pride domov, si zazeli, da bi namesto stare bajte zrasla vila, v kateri bi bilo 100 lepih punci, da bi imel steklenico vina, ki ne bi bila nikoli prazna in da bi imel denarnico, v kateri bi bil vedno denar. Mujo vrze na tla jajco in pred njim stoji vila, v njej je 100 mladih, lepih zensk. V vili je steklenica z vinom, Mujo si nalije vino in steklenica je zopet polna, odpre denarnico, iz nje vzame ves denar in denarnica se zopet napolni. Mujo tako uziva mesec dni, nato pa se le spomni na Hasota in se odloci, da ga obisce.  Ko pride do Hasota, se vedno stoji stara kocura, v njej je 100 moskih z velikimi batinami, v kotu pa Haso joce od obupa.   Mujo: Pa, Haso, pa sta si to ti zazelio.  Haso: Dodem ja kod kuce, pa mislim: fali meni tisocu nekih kuraca, kad mi izpadne jaja. ", "Zlata jajca" },
                    { 789, true, 18, "Fata in Mujo sta v financni stiski, zato se odlocita, da bo Fata poskusila zasluziti s prostitucijo. Fata se odpravi na delo in ko se zjutraj vrne domov, jo Mujo vprasa, koliko je zasluzila. Fata:\"101 evro!\"  Mujo:\"kako 101 evro, ne razumem.\"  Fata:\" Evro po evro, pa se nabere!\"", "Fata gre sluzit " },
                    { 1838, true, 17, "Poznaš razliko med možem in psom?    Je ni! Oba te gledata, kot da te razumeta.", "Mož in pes" },
                    { 1802, true, 17, "Joški so živ dokaz, da se moški lahko osredotoči na dve stvari naenkrat.", "Osredotočenost moških" },
                    { 1786, true, 17, "Mladenič vpraša dekle: \"Ti je že kdo rekel, da si podobna Sharon Stone?\"    \"Ne, nihče!\" z žarom v očeh odgovori dekle.    \"Ja, se mi je kar zdelo!\" komentira fant. ", "Mladenič jo ogovori" },
                    { 1715, true, 17, "Ferdo je imel lepo kmetijo,   bil pa je izredno skop.  Janez je zanj,ki je bil ze v  zrelih letih, se vedno iskal zeno:  Zate imam pravo zeno.  Skromno,da je ne bos nasel dalec  naokoli.  Skromnost pa taka.  To je 1095 krompirjev, na prestopno   leto pa se tri vec...", "Skromni" },
                    { 1696, true, 17, "Polde vprasa prijatelja Ferda:  Ej, slisal sem, da je tvoja zena  rodila. Mr res?  Ferdo: Res, prijatelj, res.  Polde: Pa imas res dvojcka?  Srecnez: Imam.  Polde vrta naprej: Pa sta tvoja   dvojcka enojajcna ali dvojajcna?  Ferdo:Eden je dvojajcni, drugi  pa puncka.", "Dvojcka" },
                    { 1691, true, 17, "\"Kaj me tako gledaš? Ali še nikoli nisi videl gole ženske?\"    \"Sem videl. Ampak zanima me, od kje boš potegnila denar za plačilo pijače.\"", "Na nudistični plaži" },
                    { 1668, true, 17, "V čem je podobnost med moškim in avtomobilom?    Oboji so poceni, se jih lahko dobi in so nezanesljivi.", "Ena resnična" },
                    { 1667, true, 17, "Moški so kot ... dobre počitnice.    Dolžina v večini primerov ni taka, kot bi si jo želele.", "Moški, pač" },
                    { 1666, true, 17, "Moški so kot ... vreme.    Nič ne more spremeniti ne enega ne drugega.", "Hja, tako pač je" },
                    { 1639, true, 17, "\"Kaj reče ženska, ko vidi velikega tiča?\"    \"Ne vem.\"    \"Sem si kar mislil!\"", "Hitri test" },
                    { 1638, true, 17, "Zaljubljena ženska pošlje SMS z veliko ljubezni na mobi njenega ljubljenega, z vsebino:  Moja ljubezen,  če spiš, mi pošlji svoje sanje,  če se smejiš, mi pošlji tvoj nasmeh,  če jočeš, mi pošlji svoje solze.  Jaz te ljubim!    In moški odgovori svoji ljubezni.  Moja ljubezen,  kakam... želiš, da ti kaj pošljem?", "Zaljubljena gospodična piše svojemu dragemu" },
                    { 1635, true, 17, "Katera je največja želja vsakega lastnika BMW?    Da bi imel večjega tiča!", "Želja je eno, realnost pa drugo" },
                    { 1626, true, 17, "\"Dame imajo prednost\"    je samo moški izgovor za: \"Pejt naprej, da te v rit pogledam!\"", "Dame imajo prednost" }
                });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "Id", "Active", "CategoryId", "Description", "Title" },
                values: new object[,]
                {
                    { 1611, true, 17, "Se pogovarjata dva moška: \"Žena mi očita, da se premalo ukvarjam z otroci.\"    \"Koliko jih pa imaš?\"    \"Pet ali šest ali nekaj takega.\"", "Žena mu očita" },
                    { 1608, true, 17, "Milan je zelo ponosen na svoje brke. Nekega dne mu brivec reče: \"Če bi tele brčice ponesreči postrigel, te zagotovo ne bi nihče prepoznal.\"    Milan: \"Tebe tudi ne!\"", "Brčice" },
                    { 1603, true, 17, "Po pregledu doktor reče Fati: \"Bojim se, da ne izgledate preveč dobro.\"    Ko hoče nadaljevati ga prekine Mujo: \"Vem, gospod doktor, tudi meni ni lepa, ampak dobro kuha, pere in zna z otroci.\"", "Fata na zdravniškem pregledu" },
                    { 1602, true, 17, "Tovornjakar, v pristanišču, nagovori prostitutko: \"Kaj narediš za 50 €?\"    Prostitutka: \"Vse!\"    Tovornjakar: \"Na, tu imaš 50€. Skoči gor, da te peljem do trgovine kjer bomo raztovarjali to težko robo.\"", "Tovornjakar in prostitutka" },
                    { 1599, true, 17, "Ne pijem drugega kot samo vodo. Ne kadim, jem skromno in nikamor ne grem, ne v kino, ne v gledališče, ne na nogometne tekme. Še v gostilno ne.    Ne družim se več z ženskami še pogledam jih ne.    Denarja ne zapravljam, pokra in biljarda ne igram več.    Spat grem ob osmih, vstanem se ob šestih, se umijem z mrzlo vodo in grem na delo.    Ko bom pa prišel iz zapora, bo pa spet malo drugače.", "Vzoren človek" },
                    { 1580, true, 17, "Ženske: moški se med seboj tako malo razlikujejo, da se vam ne splača ločiti in vzeti drugega.", "Nasvet za ženske" },
                    { 1500, true, 17, "Košir sedi v avtu na parkirišču.    Zagleda ga prijatelj in vljudno vpraša, če sme prisesti, saj ju pot vodi v isto smer.    Košir velikodušno prikima.    Urno odpre vrata in prisede, a Košir se ne premakne.    Nekaj časa še čaka nato pa obzirno vpraša: \"Ali še koga čakaš?\"    Košir: \"Ja, čakam, da poteče čas na parkirni uri.\"", "Na parkirišču" },
                    { 1482, true, 17, "Star kavboj gre v bar in naroči pijačo.  Sedi in srka svoj viski, poleg njega sede mladenka.    Obrne se k njemu in ga vpraša: \"Si ti pravi kavboj?\"    Tip: \"No, že vse življenje živim na ranču, kjer pasem konje, popravljam ograjo in žigosam živino. Bo že držalo.\"    Nakar dekle prostodušno: \"Jaz sem pa lezbijka. Ves dan mislim na ženske. Takoj, ko vstanem, mislim na ženske. Kadar se tuširam ali gledam televizijo, mislim na ženske.\" In odide.    Čez nekaj časa poleg starega kavboja sede par srednjih let in ga vpraša: \"Si pravi kavboj?\"    Ta: \"Doslej sem bil prepričan, da sem, zdaj sem pa odkril, da sem lezbijka.\"", "Pravi kavboj" },
                    { 1481, true, 17, "Srečajo se trije, ki so zaradi službe veliko odsotni od doma.    Pilot: \"Ko se vračam domov, najprej nizko in glasno preletim nad hišo.\"    Kapetan ladje: \"Ko plujem v domači pristan, v bližini doma trikrat zatrobim z ladijsko sireno.\"    Polde, šofer tovornjaka, prijavi: \"Jaz pa parkiram že kilometer pred domom, grem peš do hiše, se odplazim na dvorišče, s pajserjem odprem okno spalnice in skočim noter. Povem vama, še nobeden mi ni ušel.\"", "Možje na potovanju" },
                    { 1441, true, 17, "Se pogovarjata Tone in Joze.  Tone: Joze, si ti kdaj gledal svoji zeni v oci med seksom?  Joze: Sem Tone, bilo je grozno, stala je med vrati...", "Srhljivo" },
                    { 1417, true, 17, "Pes, avto in zvocniki  morajo biti nemski, za  zensko je pa vseeno,   od kod je...", "Moska izjava tedna" },
                    { 1403, true, 17, "\"Janez, kaj običajno uporabljaš po britju?\"    \"Najpogosteje hanzaplast flajštre.\" ", "Po britju" },
                    { 1390, true, 17, "Koliko moških je potrebno, da odprejo pločevinko piva?    Noben!    Pločevinka mora biti odprta že, ko jo ženska prinese.", "Odpiranje pločevinke piva" },
                    { 1381, true, 17, "\"Končno sem dosegel, da mi je Urška rekla DA!\"    \"Krasno, čestitam! Kdaj bo pa poroka?\"    \"Kakšna poroka?\" ", "Je le dočakal" },
                    { 1371, true, 17, "Če sem se bala teme, ali me je zeblo, me je mama vedno objela, stisnila k sebi in me poljubila.    Mož ves zaspan nejevoljno: \"Pa ti zares nisi normalna! Sedaj sredi noči naj te peljem k mami!\"", "Zebe jo" },
                    { 1358, true, 17, "Moz predlaga zeni, da gresta na nudisticno plazo. Zena se s tem ne strinja:\"Nocem, da vsi vidijo, da sem se porocila zaradi denarja!\"", "Nudisticna plaza" },
                    { 1848, true, 17, "Če bi ženske znale brati misli bi moški dobili klofuto vsako sekundo.", "Branje misli" },
                    { 2059, true, 17, "Žena vpraša moža: \"Veš, kaj me zanima? Zakaj moški toliko lažete?\"    Mož: \"Čisto enostavno. Zato, ker ženske toliko sprašujete!\"", "Poizvedava žena" },
                    { 2076, true, 17, "Moški jemlje v roke različne predmete in sprašuje za ceno.    Vse mu je predrago.    Končno vpraša prodajalko: \"Kaj bi si želeli za rojstni dan, če bi bila moja žena?\"    Prodajalka: \"Drugega moža!\"", "Škrtuh kupuje darilo za svojo ženo" },
                    { 2127, true, 17, "Tri leta star fantek se kopa in proučuje svoja jajčka.    \"Mami, a so to moji možgani?\", vpraša.    Mamica: \"Ne še.\".", "Fantek v kadi" },
                    { 765, true, 18, "Pride Mujo na železniško postajo in vidi nov avtomat. Na njemu piše: Ubaci novčič, stavi ovdje ruku I ti mašina kaže, tko si!     Mujo res poskusi in vrže kovanec. Avtomat mu reče: Ti si Mujo, čekaš vlak za Sarajevo.    Ker pa hoče pretentati avtomat, se našminka in spet vrže kovanec. Ti si Mujo, čekaš vlak za Sarajevo.    Potem mora na WC in tam vidi kondomat. Kupi kondom in si ga potegne preko glave in spet vrže kovanec: \"Ti si Mujo I dok glumiš kurca ode ti vlak za Sarajevo.\"", "Mujo in avtomat" },
                    { 717, true, 18, "Mujo dobi puzzle. Pa sestavlja, pa sestalja,… mine devet dni, pa  še ni gotovo… Pa pride 10. dan, pa mu končno rata. Zlaufa k Hasotu,  ter se mu pohvali: “Jes vidio, pazl sam sastavio u 10 dana, a na  kutiji piše 4-5 godina!!!”  ", "Puzzle" },
                    { 716, true, 18, "Haso povabi Mujota na večerjo. Mujo pride do Hasota in zagleda na vratih listek:  “Ha, ha, ha, Mujo, sploh me ni doma!”  Mujo se odloči, da mu bo to vrnil, zato pripiše na listek:  “Ha, ha, ha, Haso, sploh nisem bil tukaj!!”", "Povabilo" },
                    { 715, true, 18, "Fata pere perilo pod slapom. Pa prileti en kamen na Fato in jo ubije.  Mujo pa pravi: “Spet ta vodni kamen. Uničil mi je že tretji pralni stroj”.", "Mujo in pralno stroj" },
                    { 714, true, 18, "Kliče Mujo Hasota: ‘Haso ali bi mi prišel pomagat drva cepit?’  Haso: ‘Ne ne morem imam spolno bolezen.  Mujo ga pokliče naslednji dan in ga ponovno vpraša: ‘Bi mi prišel drva cepit?’.  Ne morem imam spolno bolezen, Odgovori Haso. Nato ga pokliče tretjič in ga še zadnjič vpraša, če bi mu prišel pomagat drva cepit.  Haso: ‘Ne morem imam spolno bolezen. ‘  Mujo se razjezi: ‘Katera je potem ta tvoja spolna bolezen?’  Haso pa odgovori:’ Boli me k….za tvoja drva’.", "Spolna bolezen" },
                    { 713, true, 18, "Haso prinese Mujotu gate za rojstni dan.  Mujo vpraša: “Kaj pa je to?”  Haso pravi: “To so spodnje hlače. To obleci predno oblečeš hlače.”  Mujo pravi: “Jaz tega ne rabim. To je za mestne učene ljudi.”  Haso pravi: “Probaj. Boš videl. Je bolj higijenično in topleje ti bo.”  Naslednji dan zjutraj Mujo res prvič v življenju obleče gate.  Čez nekaj časa ga prime na stranišče. Normalno odide na stranišče, in sleče hlače, gate pa pozabi sleči.  Opravi potrebo in pogleda v školjko: “Pa je res bolj higijenično.”  Obleče hlače in odide iz stranišča, nato pa pravi: “Pa tudi bolj toplo je.”", "Gate" },
                    { 712, true, 18, "Nekega dne se gre Mujo učit k Hasotu. Ko se nauči in hoče oditi domov vidi, da zunaj močno dežuje. Zato mu Haso reče naj prespi pri njemu. In Mujo se strinja. Ko pa gre Haso pod tuš vidi Mujota zelo mokrega in ga vpraša: “Zakaj si pa moker ?” Mujo mu pojasni:”Šel sem domov po pidžamo.”", "Mujo spi pri Hasotu" },
                    { 617, true, 18, "Fata in Mujo ne moreta imeti otrok.    Mujo se potoži Hasu in ta mu svetuje, da naj po seksu Fato obesi za noge, tako se bo reč bolje prijela.    Mujo se naslednje jutro drži nasveta in zatem oddide po opravkih. Med tem se oglasi Poštar in ko zagleda Fato ga popade poželenje in jo nagovarja naj mu dovoli, da jo poliže.    Končno mu Fata dovoli, a glej ravno tedaj vstopi Mujo in zakriči: \"Ti, baraba, mi torej požreš otroke!\"", "Poskuša zanositi" },
                    { 513, true, 18, "Mujo je potreboval denar, zato je svojo Fato poslal na delo v javno hišo, da zasluži nekaj denarja.  Fata se zvečer vrne in prinese 101 evro.  “Svaka ti čast!” je bil navdušen Mujo in nadaljeval: “A zakaj tisti 1 evro?”  Fata: “Eh moj Mujo. Evro na evro!”101 E", "101 Evrov" },
                    { 511, true, 18, "Haso: \"Mujo, znaš li da mrav može nositi teret, 20 puta veći od njegove težine?\"    Mujo: \"A Fata mi se pravila važna, kad je sama nosila veš mašinu na treći sprat!\"", "Mrav i Fata" },
                    { 491, true, 18, "Kupi Mujo burek za na pot. Komaj se malo oddalji od lokala se takoj vrne!    Mujo strogo: \"Je li, bolan, gdje ti držiš meso?\"     Mojster ga začudeno pogleda, in odgovori: \"U frižideru, gdje bi drugo ...\"    Mujo nejevoljno: \"Pa stavi malo i u burek, matere ti...\"", "Burek za na pot" },
                    { 420, true, 18, "Mujo in haso sta šla na nogometno tekmo in s sabo vzela nekaj litrov domačega šnopsa.    Dogovorila sta se, da vedno, ko pade zadetek, malo cukneta.    Tekma se je končala 0:0.    Mujo: \"Jebeš ti to, ajmo mi na košarku\"!", "Na nogometni tekmi" },
                    { 373, true, 18, "Kako Mujo vlovi zajca?  Vsede se v grmovje in žvižga kot zelje!", "Lovec Mujo" },
                    { 367, true, 18, "Haso in Mujo stanujeta v bloku. Eden je na vrhu bloka, drug pa na dnu.   Vsak dan se na balkonih pogovarjata.   Sosedom gre njuno vpitje na živce, zato jima kupijo telefon.   Naslednji dan Haso pokliče Mujota in mu reče:     \"Pridi na svoj balkon, da ti nekaj povem!\"", "Telefon" },
                    { 1305, true, 21, "\"Vidim, da se vam zelo tresejo roke,\" komentira zdravnik. \"France, povejte mi po resnici a preveč pijete?\"    \"Kej pa, gaspud dohtar,\" odvrne France. \"Preveč palijem ... \"", "Roke se mu tresejo" },
                    { 365, true, 18, "Se Mujo preseli v Slovenijo in se zaobljubi, da ne bo izgovoril več nobene \"ta spodne\" besede!!  Pol pa gre v trgovino pa pravi:  Mujo: \"Dajte mi sira!\"  Prodajalka: \"Al Jošta?\"  Mujo: \"Ništa!\"", "Nakup sira" },
                    { 363, true, 18, "Se vozijo Mujo in Haso v avtobusu in reče Mujo Hasotu : Haso poglej kako lep razgled na gozd!  Pa reče Haso nič ne vidim drevesa mi zakrivajo pogled!", "Prelep razgled" },
                    { 362, true, 18, "Seksata Mujo in Fata, pa po koncu divjega seksa Mujo vpraša:    \"Fata kje si se pa to naučila?\"    pa Fata odgovori \"Gledam pornofilme!\"    Mujo pa odvrne \"Gledam tudi jaz tekme, pa ne igram kot Pele!\"", "Izkušnje" },
                    { 361, true, 18, "Mujo in Haso sta zmenjena da gresta na piknik , pa pride Haso . Mujotove hise , na vratih pa listek : Haso jaz grem na piknik z zeno ne zameri.Pa se Haso razjezi in napise na listek : no mene pa sploh ni bilo tu!", "Piknik" },
                    { 359, true, 18, "Mujo dobi zlate ribice  Fata ga vpraša če je zamenjal vodo ribam?  Mujo pa ji odgovori: počakaj vidiš da še to niso spile", "Mujo in zlate ribice" },
                    { 358, true, 18, "Se pogovarjata Mujo in Haso pa Haso reče: \"Mujo kdaj greš v kino?\"  Mujo se čudi in vpraša \"Zakaj te pa to zanima?\"  pa Haso odgovori \"da mi kupiš kokice\"", "Kino in kokice" },
                    { 354, true, 18, "Mujo dela v Nemčiji, da bi na pošten način zaslužil denar za avto. Po 10 letih končno prihrani dovolj za Mercedeza in se z njim odpravi pokazat v Bosno, kako se da s poštenim delom tudi dobro zaslužiti. Sredi poti pa se mu zgodi nesreča, poči mu guma. Med menjavanjem pride mimo Haso in ga vpraša: “Šta je Mujo, šta radiš?”  Mujo mu odgovori: “Zar ne vidiš? Skidam gumo!”.  V tem trenutku Haso pograbi kamen in ga vrže v sprednjo šipo ter se zadere: “Ajde, ti uzmi gumo, a ja ču uzet radio!”", "Nov mercedes" },
                    { 319, true, 18, "Na klopci v parku sedi lepa ženska.    Pride mimo Mujo in jo vpraš: \"Ljepotice, kako ti je ime?\"    Mladenka: \"Izabela.\"    Mujo: \"Iza čega???\"", "Mujo sreča lepotico v parku" },
                    { 314, true, 18, "Mujo in Haso prideta do reke. Reka ni globoka in lahko bi jo prebrodila. Vendar se pojavi težava.    Haso: \"Mujo! Ne znam da plivam.\"    Mujo: \"Nema problema Haso, nosiču te. Samo se ti mene dobro drži\"    In tako onadva čez reko. Na sredi reke pa...    Mujo: \"U jebemu Haso...ušla mi ribica u dupe!\"    Haso: \"Nije nije Mujo...samo sam se ja malo dodatno učvrstio.\"", "Mujo in Haso čez reko" },
                    { 247, true, 18, "Trije brodolomci se znajdejo na samotnem otočku: Anglež, Nemec in Mujo.     Lovijo ribe in ulovijo zlato ribico.  Ribica jim reče, da vsakemu, v zameno za svojo svobodo, izpolni eno željo.    \"Rad bi bil s svojimi najdražjimi,\" reče Anglež in izgine.    \"Tudi jaz bi bil rad s svojimi najdražjimi,\" reče Nemec in izgine.    Tako Mujo zadnji ostane na samotnem otočku, malce pomisli in reče: \"Kaj bom jaz zdaj sam tu?. Pripelji mi on adva nazaj!\" ", "Brodolomci na otoku" },
                    { 225, true, 18, "Smrt potrka Mujutu na vrata.    Mujo ji odpre in vpraša: \"Tko si ti?\"    Smrt: \"Ja sam ti smrt, i došla sam po tvoju dušu.\"    Mujo se obrne proti hodniku in se zadere: \"Fato dušo, netko te traži!!!\"", "Smrt obišče mujota" },
                    { 101, true, 18, "Se vozita Mujo in inštruktor po Sarajevu, ker Mujo dela izpit za avto.    Inštruktor: \"Sa leve strane ti je opasna riba a sa desne baba, sta ćeš da zgaziš?\"    Mujo zmedeno odgovori: \"Pa..., babu, jebi ga!\"    Inštruktor, jezno: \"Pa, kočnicu, pička ti materina!\"", "Mujo dela izpit za avto" },
                    { 37, true, 18, "Mujo in Haso se vozita z avtomobilom. Zavijeta na avtocesto. Prižgeta radio in uživata v glasbi. Nenadoma se oglasi napovedovalec: \"Pažnja, pažnja! Neki ludak na avtoputu A1 vozi u suprotnom smjeru !!\"  A Haso: \"Ma kaki jedan, bolan, ima jih na stotine !!\"", "Mujo in Haso na avtocesti" },
                    { 34, true, 18, "Haso in Mujo gresta prvič v življenju v nebotičnik.  Mujo reče Hasotu: \"Bolan Haso, pozovi lift!\"  Haso: \"LIFT, LIFT !!\"", "Lift" },
                    { 33, true, 18, "Vpraša Haso Mujota: \"Ma Mujo, šta bi ti bio radije: homoseksualac ili intelektualac ?\"  Mujo nekaj časa premišljuje in odgovori: \"Znaš šta, Haso, radije bi bio homoseksualac.\"  \"Zašto ?!\"  \"Zato, jer mi ide lakše u dupe nego u glavu.\"", "Intelektualec" },
                    { 364, true, 18, "Haso stoji na veji drevesa in mim pride Mujo in reče:     \"Haso red bull a ?\"    Haso pa:     \"ma ne red bull. za tabo je pitt bull!\"", "Red bull" },
                    { 1342, true, 17, "Kdaj je moški resnično \"copata\"?    Ko svoji noseči ženi ne upa povedati, da je neploden!", "Copata" },
                    { 1308, true, 21, "France prizna, da mora vsak večer, ko se pozno vrača domov, dahniti skozi ključavnico. In če žena ugotovi, da je v njegovi sapi preveč vinskih hlapov, ga ne spusti v stanovanje.    Prijatelj pa mu takole svetuje: \"Vsak večer, preden greš domov, pojej malo gorgonzole! \"    Rečeno - storjeno. France poje gorgonzolo in ko se vrne pred domača vrata, se izza njih oglasi žena: \"France! Pihni!\"    France pihne.    \"O ti prasec, ne prdaj skozi ključavnico!\"", "Test sape, ko pride domov" },
                    { 1375, true, 21, "\"Jaz sem Bog v naši družini!\"    \"Kako to misliš?\"    \"Vsi se obnašajo do mene kot, da me ni!\" ", "Debata za šankom" },
                    { 738, true, 26, "Ženska gre v posteljo z Billyem Gatesom. Ko opravita, mu ona reče: “Gospod, sedaj pa vem, zakaj se vaše podjetje imenuje Microsoft…", "Microsoft" },
                    { 67, true, 26, "Mali računalničar pravi abecedo: a..b...c ..d..e... f...g... h...t...t..p... w..w..w......", "Računalniška abeceda" },
                    { 66, true, 26, "Kako kastriraš fanatika, ki cele dneve prečepi pred Windowsi?  \"Odrežeš kabel od miške!\"", "Kastracija fanatika" },
                    { 2065, true, 23, "Ko Japonci slišijo, da je kak njihov politik naredil samomor, rečejo: \"Hara - kiri?\"    Če bi ga naredil pa slovenski politik, bi pa ljudje rekli: \"Hura - keri?\"", "Politiki in samomor" },
                    { 1871, true, 23, "Pri vhodu v parlament sta se srečala poslanca. Eden je odhajal, drugi je bil šele namenjen v parlament.    \"Kako je kaj notri. Se na zasedanju kaj posebnega dogaja?\"    \"Ja. Minister ima že dve uri zelo pomemben govor.\"    \"O čem pa govori?\"    \"Tega pa še ni povedal.\"", "Pri parlamentu" },
                    { 1845, true, 23, "Jezus Kristus se je odločil, da gre za en dan pogledat v Ljubljano, kaj se dogaja z njemu preljubimi Slovenci.    Napoti se proti predsedniški palači, kjer sreča Pahorja, ki mu ponudi cigareto s travo. Pri tem poudari, da je ta trava zelo dobra.    Jezus potegne in pravi Pahorju: \"Da se ti predstavim, jaz sem Jezus Kristus!\".    Pahor pa pravi: \"Sem ti rekel, da je ta trava zelo dobra!\".", "Jezus obišče Ljubljano" },
                    { 1801, true, 23, "Kako ves, da nekdo laze?  Das mu pojoco travico.  Kako pa ves, kdaj politik laze?  Ko se mu ustnice premikajo.", "Pojoca travica" },
                    { 1790, true, 23, "Janša in njegov šofer se peljeta po mirni podeželjski cesti.    Ko se peljeta mimo samotne kmetije priteče na cesto svinja in šofer jo zbije tako hudo, da je bila na mestu mrtva.    Janša: \"Joj, kako se je pa to zgodilo? Svinja je verjetno pobegnila iz tele bližnje kmetije. Pojdi tja, jim povej kaj se je zgodilo, in kmetu svinjo plačaj.\"    Šofer se odpravi do kmetije in Janša ga čaka. Minule so že dve uri in Janša postaja že živčen.    Po treh urah in pol se šofer vrne, ves nasmejan.    \"Kaj se je zgodilo?\", ga ves nervozen vpraša Janša.    Šofer: \"Gospod, ko bi vi vedeli, kako tale gospodinja dobro kuha! To še ni vse! Kmet ima res odlično črno vino! Jedel in pil sem, kot še v življenju ne. Imata pa tudi zelo postavno hčerko. Prava mrha je mala! Ko sem se najedel, me je peljala v spalnico. Tako sva se žgala, da ne vem, če sem kdaj doživel tako divji seks.\"    Janša, ves začuden: \"Pa kako je to mogoče, kaj si jim rekel?\"    Šofer: \"Rekel sem jim: jaz sem od Janše šofer in povozil sem prasca.\"", "Janša se pelje po podeželjski cesti" },
                    { 1659, true, 23, "Pride g. minister v mesarijo in naroči krvavice.    Mesar postavi prašičje stegno na stroj in ven pridejo klobase.    G. minister se nato pošali na mesarjev račun in reče: \"Škoda, da vi nimate takšnega stroja, da daš na stroj klobaso, ven pa pride pujs.\"    Mesar ga strogo pogleda in mu odvrne zbadljivo:\"Ne, takšnega je imel pa vaš oče!\"", "Minister v mesariji" },
                    { 1564, true, 23, "Kakšna je razlika med Citroenom C5 in slovenskim parlamentom?    Slovenski parlament ima več konjev.", "Citroen C5 in parlament" },
                    { 1374, true, 23, "Politik je rekel arhitektu: \"Če ne bi bil politik, bi tudi jaz gradil hiše.\"    Arhitekt mu je odgovoril: \"Če vi ne bi bili politik, bi jih jaz tudi.\"", "Gradnja hiš" },
                    { 1239, true, 23, "Policijska ministrica na glas: \"Mi lovimo tudi ta velike ribe!\"    Državni tožilec, malo bolj potiho: \"A jih, kot pravi športni ribiči, potem takoj izpustimo.\"", "Lovljenje velikih rib" },
                    { 1186, true, 23, "Kaj dobis, ce operes   politika?  Usrano vodo in cistega  kriminalca.", "Cisti  kriminalec" },
                    { 1181, true, 23, "Notranji minister je na sprejemu pri  predsedniku republike.  Sledi vecerja, po kateri zeli na vsak  nacin zaplesati s prvo damo.  Po uvodnih ritmih ji zasepeta:  Gospa predsednikova, a se vam ne zdi,  da je ze cas, da prepovemo policijske  vice?   Ona: Ce sem iskrena, mislim, da je v teh  vicih vendarle nekaj resnice. Vi ste prvi,   ki me je ob igranju himne povabil na ples.", "Policiski vici" },
                    { 1064, true, 23, "Na avtocesti je zastoj in kolona je dolga vec kilometrov. Nihce ne ve, kaj se je zgodilo. Koncno pridem mimo nekdo s kanto bencina. Cakajaci v koloni ga vprasa kaj se je zgodilo.   \"Teroristi so ujeli Janeza Janso in zanj zahvetajo 10 milijonov evrov. Ce denarja ne zberemo, ga bodo zasgali.\"  \"In koliko ste uspeli zbrati?\"  \"10 evrov, 500 litrov bencina in 30 vzigalnikov...\"", "Teroristi in Janez Jansa" },
                    { 996, true, 23, "V parlamentu zunanji opazovalec vprasa: Kje je tukaj WC?  Vratar: Kaksen WC neki? Tu ga ne rabijo, saj serjejo drug po drugem. ", "WC" },
                    { 995, true, 23, "Kaj je to?   Stirje v sobi in samo eden dela?  Trije drzavni usluzbenci in klima.", "Kaj je to?" },
                    { 994, true, 23, "V slovenskem parlamentu zazvoni telefon.  Javi se pleskar, ki renovira sejno sobo.  \"Danes ni tu nikogar, danes delamo!\"", "V parlamentu" },
                    { 975, true, 23, "Učitelj: \"Gospod Novak je uspešen poslovnež. Janezek, povej mi ta stavek v prihodnjem času.\"  Janezek: \"Gospod Novak je v arestu.\"", "Uspešni poslovneži" },
                    { 899, true, 23, "So olimpijske igre pa ima bosanski predsednik govor.    Pa govori:\"ooo...ooo\".    Pa ga vsi čudno gledajo.Pa pride do njega njegova žena,pa gleda v besedilo,pa mu reče:\"Ne moj muž,ovo so olimpijski krugovi\"!", "Predsedniški govor" },
                    { 832, true, 23, "Kaksna je razlika med kuhinjskim in drzavnim aparatom?  Drzavni aparat deluje tudi ko je popolnoma pokvarjen.", "Drzavni aparat" },
                    { 731, true, 23, "V državnem zboru. Sprašuje opazovalec:  “Oprostite, prosim, kje pa je tukaj WC?”  “Kakšen sekret neki!” reče vratar. “Ga ne rabijo, drug po drugem serjejo.”", "WC" },
                    { 728, true, 23, "V koncentracijskem taborišču. Četniški komandant ustavi jetnika in reče:  »Prost si, če uganeš, katero oko imam stekleno!«  »Ta levo.«  Četnik: »Kako si pa tako hitro uganil?«  »S ta levim ste me tako prijazno pogledali.«", "Stekleno oko" },
                    { 640, true, 23, "Kakšna je podobnost med politikom in golobom?    Ko so od spodaj, ti oboji jedo iz roke, ko so pa odzgoraj, ti pa tudi oboji serjejo po glavi.", "Podobnost politik in golob" },
                    { 512, true, 23, "Kdo si ves čas izmišljuje vse te nove gospodarske in politične ukrepe? Politiki ali znanstveniki?  “Verjetno politiki, saj, če bi si jih izmišljevali znanstveniki, bi jih prej preizkusili na podganah.”", "Ukrepi" },
                    { 502, true, 23, "Na avtocesti je zastoj - vrsta dolga par kilometrov. Nihče ne ve, kaj se je pravzaprav zgodilo in nervozen voznik končno le zagleda nekoga, ki se mu približuje s kanto za bencin.   -Ja, kaj se je pa zgodilo?   -Skupina teroristov je ugrabila Janšo in zdaj zahtevajo odkupnino 10 milijonov evrov. Če ne bomo zbrali, ga bodo polili z bencinom in zažgali..   - In koliko ste uspeli zbrati doslej?   - 10 evrov, 500 litrov bencina in 30 vžigalnikov...!!!", "JJ in teroristi" },
                    { 357, true, 23, "Se na letalu pogovarjata Pahor in Jansa pa reče Pahor jaz bom vrgev 500€ iz letala in bom osrečil enega Slovenca.     Pa reče Jansa js bom vrgu 2x po 500€ in bom osrečil dva Slovenca.     Pa reče pilot ja bom vrgev obedva dol in bom osrečil celo slovenijo. ", "Pahor in Janša" },
                    { 191, true, 23, "Na odru, na totalno nabasani javni novinarski konferenci, Janez Janša, Zoran Jankovič in Borut Pahor.  En moški potrka po rami moškega pred sabo in mu reče: \"Oprostite, a lahko prosim snamete klobuk, nič ne vidim...\"  Moški vljudno sname klobuk in posluša naprej, ko čez nekaj trenutkov spet začuti trkanje po rami.  \"Oprostite, a lahko stopite malce bolj levo, še vedno nič ne vidim...\"  Moški, že malce nejevoljen, stopi bolj levo. A čez nekaj trenutkov spet začuti trkanje po rami.  \"Oprostite, a lahko...\"  Moški ga jezno prekine: \"Pa dobr no, a zdej bi radi pa še daljnogled, al kaj??\"    \"Ne ne, hvala, ni treba, ga mam na puški...,\"", "Ivan, Zoki in Borči" },
                    { 103, true, 23, "Se pogovarjata Kangler in Bossman.    Kangler: \"Čuj, ki si se te rodil ti?\"    Bossman: \"V Gani.\"    Kangler: \"Kaj bom te vgibo!? Povej mi!\"", "Kangler in Bossman" },
                    { 972, true, 26, "Profesorski zbor Strojne fakultete so odpeljali na letališče in jih posadili v letalo.  Ko so vsi posedli, so jim po zvočniku povedali:  \"To letalo so v celoti konstruirali študenti naše Strojne fakultete.\"  Profesorji poskačejo pokonci in v paniki zbežijo iz letala, samo eden obsedi.  Vprašajo ga, kako to.  Pravi: \"Če so ga konstruirali naši študenti, zagotovo ne bo niti štartal.\"", "Strojna fakulteta" },
                    { 2119, true, 22, "Policist ustavi voznika.    Policaj: \"Vozniško, prosim.\".    Šofer: \"Pozabil sem ga.\".    Policaj: \"Doma?\".    Šofer: \"Ga naredit.\".", "Prometna kontrola" },
                    { 1015, true, 26, "Dve deklici v vrtcu se pogovarjata:\"Ali ti tudi greš kaj na internet?\"    \"Ne, mi hodimo v Interšpar.", "Pogovor v vrtcu" },
                    { 9, true, 27, "Sta seksala slovenka in albanec.    Albanec je imel zelo veliko \"orodje\", zato je žensko počasi začelo boleti.    Ker moški kar ni nehal, je začea tarnati: \"Boli, boli.\"    Albanec: \"Kolegice, je kakav je, nema bolji.\"", "Slovenka seksa z albancem" },
                    { 165, true, 27, "Starejša gospa gre h župniku, da se izpove in mu reče:  \"Joj gospod župnik kako pogrešam seks!\"    Župnik ji odgovori:  \"Na onem svetu boš imela toliko seks, kolikor boš hotela.\"    Ženska gre malo razočarana iz cerkve, pride do mosta, ko se ji porodi ideja, da bi se vrgla z mosta na avtocesto in tako prišla do sexa. Spleza preko ograje in skoči. Ravno v tistem trenutku se pripelje tovarnjak z bananami in ženska zleti na banane.    Ko pride k sebi je vse temno okrog nje, začne otipavati okoli sebe in vzhičeno reče:  \"Počasi fantje počasi..., vsi pridete na vrsto!\"", "Obupana zaradi pomanjkanja seksa" },
                    { 161, true, 27, "Arestant po 15 letih zbeži iz zapora.    Vdre v hišo, da bi našel hrano in orožje, in naleti na par v postelji.  Ukaže moškemu, naj zleze iz nje, in ga priveže na stol, žensko pa priveže na posteljo, jo poljubi na vrat, vstane in odide v kopalnico.  Medtem mož reče ženi: \"Poslušaj, ta tip je pobegli zapornik. Verjetno je bil dolgo v zaporu in že leta ni videl ženske.  Videl sem, kako je poljubil tvoj vrat.  Če bo želel seksati s tabo, se mu ne upiraj in se ne pritožuj, samo naredi, kar hoče.  Bodi močna, draga. Ljubim te.\"    Žena mu odgovori:  \"Ni poljubil mojega vratu, na uho mi je zašepetal, da je gej in da se mu zdiš seksi, in me vprašal, ali imava kaj vazelina.  Rekla sem mu, da je v kopalnici.  Bodi močen, dragi. Tudi jaz te ljubim.\"", "Po petnajstih letih zapora" },
                    { 157, true, 27, "Mož zaloti ženo v postelji z ljubimcem.  Ta skoči iz postelje in hoče zbežati.    Žena zavpije ljubimcu:  \"Dokaži, da si moški!\"    Ljubimec:  \"A zdaj pa še njemu?\"", "Dokaži, da si moški" },
                    { 156, true, 27, "Micka si je privoščila skok čez plot z Janezom. Ko sta tako nekega dne seksala, slišita avto, ki se ustavi na dvorišču.  Micka plane iz postelje, pogleda na dvorišče in vzlikne:  \"Moj Bog, moj mož se je prej vrnil s potovanja. Janez, takoj skoči skozi okno na cesto in izgini!\"    Janez pogleda skozi okno in odvrne:  \"Ne morem, Micka. Saj vidiš, da dežuje!\"    Micka se obupano zgrabi za glavo in krikne:  \"Janez, če naju moj mož zasači, naju bo oba ubil.\"    Janez torej plane iz postelje, pograbi svojo obleko, skoči skozi okno na cesto in se znajde v skupini maratoncev, ki prav tisti hip tečejo mimo Mickine hiše. Da bi zabrisal sled za seboj, se jim Janez pridruži.    Čez nekaj časa se Janezu med tekom približa prvi maratonec in vpraša:  \"Kolega, ali teceš maraton vedno nag?\"  Janez: \"Vedno. Tako prijetno je čutiti pihljanje vetra, ko sem nag, in tako bolje čutim povezanost z naravo.\"    Čez nekaj časa se Janezu med tekom približa drugi maratonec in vpraša:  \"Kolega, ali tečeš maraton vedno z obleko pod pazduho?\"  Janez: \"Vedno. Tako praktično je imeti obleko pri sebi. Ko pritečem na cilj, se lahko takoj oblečem, usedem v avto in odpeljem domov.\"    Čez nekaj časa se Janezu med tekom približa tretji maratonec in vpraša:  \"Kolega, ali teceš maraton vedno s kondomom na tiču?\"  Janez: \"Ne vedno. Samo če dežuje.\"", "Skok čez plot in bežanje" },
                    { 151, true, 27, "Pride mož iz kopalnice in se začne smukati okrog žene.    Ona kot vedno reče:  \"Ne danes, dragi. Glava me boli.\"    \"Ni problema, draga\", reče mož.  \"Ravnokar sem napudral penis z aspirinom, tako, da lahko izbiraš!    Ga boš vzela oralno ali kot svečko?\"", "Glavobol in nič seksa" },
                    { 141, true, 27, "Mož se je vrnil domov z nočne izmene in zavil naravnost v spalnico. Tam je našel ženo, z odejo potegnjeno čez glavo. Moža to sploh ni motilo, zlezel je pod odejo in jo veselo poseksal.    Zadovoljen in lačen se je nato odpravil po stopnicah dol, v kuhinjo, kjer je presenečen našel zajtrk na mizi in ženo za štedilnikom.    \"Kako ti je uspelo tako hitro priti v kuhinjo??\" je vprašal osuplo, \"Saj sva vendar ravnokar seksala, v spalnici!\"    \"O moj bog!\" vzklikne žena, \"V spalnici je vendar moja mati!! Prišla je na obisk, potem ji je postalo slabo, zato sem ji rekla, naj se malo uleže!\"      Odvihrala je v spalnico: \"Mati, ne morem verjeti, da se je zgodilo kaj takega ... Zakaj vendar nisi nič rekla???\"    Tašča odrezavo odvrne: \"S tem kretenom že petnajst let nisem spregovorila besedice, zakaj bi ravno zdaj?\" ", "Tašča na obisku" },
                    { 140, true, 27, "Marjan pojasni doktorju, da doma z ženo že sedem mesecev ni imel spolnih odnosov.    Doktor je predlagal Marjanu naj mu pošlje ženo na razgovor, saj je Marjan izpostavil njeno utrujenost in slabo voljo ter odpor do seksa. Ko je žena prišla na razgovor je pojasnila doktorju:  “Vsako jutro grem v službo s taksijem. Ker nimam denarja mi taksist vsak dan reče naj izstopim ali pa….. Jaz sem se odločila za ali pa… Potem pogosto pridem prepozno v službo in šef me ponavadi vpraša ali delavska knjižica ali pa… In jaz se odločim za drugo varianto.    Domov se spet peljem s taksijem, procedura od zjutraj se ponovi..In jaz sem po vsem tem grozno utrujena in mi res ni več še do seksa v domači postelji.”    Doktor malo pomisli, nato pa reče:  “Ali naj vse to razložim vašemu možu ali pa….?”", "Žena noče seksati" },
                    { 139, true, 27, "Ko je Francelj opazil, da mu \"orodje\" čudežno hitro raste in da je erekcija tudi daljša,  je bil najprej navdušen, njegova žena pa še bolj.    Kmalu je bil njegov penis dolg kar celih 50 cm.    Francelj se je seveda ustrašil. Imel je kup problemov, z oblačenjem, hojo in  odločil se je z ženo obiskati urologa.    Po pregledu mu je zdravnik razložil, da je zbolel za redko boleznjo \"Oslovski sindrom\"  in da je potrebna operacija.    Žena vpraša zdravnika nervozno?: \"Ja, kako dolgo pa bo Francelj na bergljah ?\"   \"Berglje? Zakaj berglje?\" vpraša zdravnik.  \"Pa,\" reče žena hladnokrvno, \"ja..saj mu boste podaljšali noge, kajne?????\" ", "Penis mu je rastel" },
                    { 138, true, 27, "Pride gospa k lepotnemu kururgu in mu reče, da bi rada, da ji na bedro, z operacijo, naštima še eno vagino.    Kirurg začudeno vpraša: \"Gospa, zakaj jo boste pa imeli?\"    Ona: \"Rada bi kaj še postrani zaslužila.\"", "Še ena vagina" },
                    { 136, true, 27, "Starejša gospoda, oba že več let spolno vzdržna, skleneta, da je skrajni čas, da obnovita znanje v javni hiši.     Ko ju madame zagleda, si misli, da na teh dveh že ne bo trošila svojih deklet, zato obema podtakne napihljivo lutko.     Ko se starca vrneta vsak iz svoje sobe, sta videti zbegana, a ne rečeta nobene. Na poti domov se eden le odpre:     \"Brane, nerodno mi je tole priznati, ampak mislim, da je bila moja punca mrtva.  Niti enkrat se ni premaknila, niti enkrat zastokala, niti ene besede mi ni namenila, nič. Kako je bilo pa pri tebi?\"     Drugi tudi ni prepričan:   \"Moja, mislim, da je bila čarovnica.\"   \"Kako to misliš?\"   \"Ko sem ji grizljal vrat, je iznenada zasikala in odfrčala skozi okno.\"", "Obisk javne hiše" },
                    { 135, true, 27, "Opazi Franček, da Micka po vsakem seksu vzame beležko in si nekaj zapiše.  Čez nekaj časa ga le premaga radovednost in poškili v beležinko.     Tam prebere, lepo z datumi opremljene, ocene njunega seksa:   datum, . , danes je bil še kar,  datum, ., danes je bilo total zanič,  datum, ., z njim je kot z mrtvim konjem,  in tako dalje.       Franček se odloči, da se bo poskušal izboljšati. V sredo, ko žena dela   malo dlje, pohiti iz službe, skuha kosilo, speče torto, pripravi najboljšo buteljko, po celem stanovanju prižge sveče, prižge   kadila in dišave, glasba.    Micka je navdušena, sledi dolgo cartanje in osvajanje, vse se seveda   konča v postelji.     Naslednji dan Franček spet poškili v beležinko in ocena je bila en sam   superlativ. Lepo ga je pohvalila.    Nato po enem mesecu brez seksa Micka popizdi in vpraša Frančeka   kaj mu je.    Franček: \"Hja, ne bi si rad pokvaril ocene!\"", "Franček in Micika" },
                    { 134, true, 27, "Pride zakonski par v posvetovalnico zaradi seksualnih težav.    Ju vpraša svetovalka: \"Kdaj sta zadnjič seksala?\"    Mož: \"Jaz včeraj, za njo pa ne vem.\"", "Težave s seksom" },
                    { 133, true, 27, "\"Mladostnica se je odpravljala na ples in mama je opazila, da si ni oblekla spodnjih hlačk.     Mama: \"Kaj? Brez spodnjih hlačk greš na ples?\"    Mlada punca: \"Ali si daš ti vato v ušesa, kadar greš na koncert?\"", "Brez spodnjih hlačk" },
                    { 132, true, 27, "Mlada punca je prišla k spovedniku in povedala ,da ima fanta .   spovednik jo vpraša: \"ali te fant kaj otipava?\"   Ona: \"Da\"  Župnik: \"Zgoraj?\"   Ona: \"Da.\"   Župnik: \"Spodaj?\"   Ona: \"O, ja!\"   Župnik:  \"Ali kaj grešita?\".     Ona: \"To pa ne, zmeraj zadene\"", "Punca pri spovedi" },
                    { 131, true, 27, "Zakaj na občini uslužbenci ne seksajo med sabo?    Ker so si vsi v sorodu.", "Seks na občini" },
                    { 129, true, 27, "V službi se pri kofetu menita kolegici:    \"Kakšen sex pa si imela včeraj?\"    \"Katastrofa... Mož je prišel iz službe, v 3 minutah je pojedel kosilo, po kosilu 4 minute sexa in potem je po 2 minutah zaspal. A pri tebi?\"    \"Pri meni fantazija. Mož je prišel domov, me je peljal na prekrasno romantično večerjo, po večerji sva se počasi eno uro sprehodila do doma, doma spet sveče in ena ura extra predigre, potlej pa ena ura fantastičnega sexa, na koncu pa sva se še eno uro pogovarjala. Z eno besedo – bajka.    Ob istem času se pogovarjate dva kolega:    \"Kakšen sex pa si imel včeraj?\"    \"Super! Pridem domov, kosilo na mizi, pojedel sem, izseksal sem se in potem blaženo zaspal. Kaj pa pri tebi?\"    \"Pri meni katastrofa. Pridem domov, pa ni elektrike, ker sem pozabil plačati račun. Kaj se mogel. Ženo sem moral peljati ven na večerjo. Neka brezvezna hrana je bila tako svinjsko draga, da še za taksi nisem imel denarja, pa sva morala domov peš. Prideva domov, doma – jasno – ni elektrike, pa sem moral prižgat tiste preklete sveče. Bil sem tolk besen, da se mi eno uro ni dvignil, potem mi od živčnosti eno uro ni prišlo, vse skupaj pa me je tolk razpizdilo, da še eno uro nisem mogel zaspati.\"", "Različni pogledi na isto stvar" },
                    { 128, true, 27, "Francka obeša perilo na vrtu. K ograji pride soseda  in ji reče:  \"Ne morem razumeti Francka, kako ti vedno  uspe, da kadar ti pereš, vedno sije sonce?\"  Francka: \"Za to imam posebno tehniko.  Zjutraj pogledam pod odejo. Če ga ima moj Francelj  na desni, vem, da bo dež. Če ga ima na levi, vem, da  bo sonce in operem perilo.\"    Soseda: Že, že, kaj pa, če mu stoji ?    Francka: \"Takrat pa pri nas ne peremo perila ...\"", "Sušenje perila" },
                    { 127, true, 27, "Mama, odkod pridejo dojenčki?    Mama: \"Poglej ljubica .... Mami in oči se prvo zaljubita in poročita. Potem se poljubljata in objemata ter ljubita. To pomeni, DA oči DA svoj penis v mamicino vagino. Tako se dobijo dojenčki.\"     Hčerka: \"A, tako torej. Ko pa sem jaz enkrat pogledala v vajino sobo, je očijev penis bil v tvojih ustih. Kaj se pa takrat dobi, ko se to dela?\"    Mama: \"Nakit, ljubica!\"", "Od kod prihajajo dojenčki" },
                    { 125, true, 27, "Kaj dobimo, če seksata kmet in kmetica?  Kmečkega otroka.    Kaj pa če seksata ekološki kmet in njegova žena?  Nič, ker ekološki kmet ne šprica!", "Seks na kmetiji" },
                    { 123, true, 27, "Prijateljici se pogovarjata po telefonu:  \"Si lahko predstavljaš kaj takega, ko sem prišla domov, je moj dragi sedel na kavču v dnevni sobi in masturbiral!\"    \"Vau, neverjetno! In kaj si storila?\"    \"Ja kaj, vzela sem mu ga v usta in opravila do konca!\"    Prijateljica začudeno: \"Vau, in zakaj to...?\"    \"Lažje izperem usta in očistim zobe, kot celo sedežno, tepih in zavese.\"", "Mastrubiranje na kavču" },
                    { 121, true, 27, "Mož in žena po seksu utrujena ležita v postelji in dremata.  Ko nekaj zaropota v predsobi žena skoči pokonci in reče:  \"Madona moj mož je prišel\".     Mož skoči iz postelje, zagrabi hlače in se začne oblačiti.    Potem obstane in reče: \"Pizda pokvarjena, saj sem jaz tvoj mož!\"", "Mož in žena po seksu" },
                    { 98, true, 27, "Halo, Mojca, prideš k meni?  Ti me vedno kličeš samo zaradi seksa!  Dobro, te bom poklical jutri, ko bom postavljal nadstrešek.", "Postavljanje strehe" },
                    { 57, true, 27, "Kaksna je razlika med žensko in torto??  V torto gredo tudi jajca!", "Ženska in torta" },
                    { 44, true, 27, "Dva Slovenca se pogovarjata pri opravljanje male potrebe o predvolilnem boju.  \"Franc, kaj misliš, v čigavih rokah je usoda Slovencev ?\"  \"V najinih,\" mu odgovori drugi.", "Usoda slovencev" },
                    { 43, true, 27, "Pride prostitutka k tattoo mojstru. Ker pa je imela izjemno rada praznike mu veli, da ji na levo stegno vtetovira \"Srečno Novo leto\", na desno pa \"Vesele božične praznike.\"  Ko mojster konča mu reče: \"Najlepša hvala, gospod mojster, pa obiščite me kaj med prazniki!\"", "Tetovaža" },
                    { 41, true, 27, "Se srečajo trije 16-letni sošolci. Beseda je nanesla na seks. Pa pravi prvi, da seksa skoraj vsak mesec. Drugi se pohvali, da seksa skoraj vsak teden. Tretji pa pravi: \"Jaz pa seksam skoraj vsak dan!\"  Druga dva ga začudeno pogledata: \"Kako to?\"  Tretji odgovori: \"V ponedeljek skoraj, v torek skoraj, v sredo skoraj...\"", "Prijatelji" },
                    { 40, true, 27, "Gre pijanček mimo javne hiše in vidi lepo prostitutko, ki sloni na oknu. Spodaj pri vratih pa pes \"obdeluje\" psico na železnih rešetkah. Naenkrat pa rešetke popustijo in parček zleti v klet. Takrat se pijanček obrne k prostitutki in pravi: \"Glej, zdaj vam je pa reklama dol padla!\"", "Reklama" },
                    { 39, true, 27, "Dve ničli gresta po puščavi in vidita v daljavi osmico.   Nato ena vpraša: \"Kako se jima v tej vročini le ljubi?\"", "Številke" },
                    { 26, true, 27, "\"Halo, Mojca, prideš k meni?\"     \"Ne!!! Ti me vedno kličeš samo zaradi seksa!\"     \"Dobro, te bom poklical jutri, ko bom postavljal nadstrešek.\"", "Samo do seksa mu je" },
                    { 8, true, 27, "Se spravi en bosanc na eno slovenko, sredi poletja, kar sredi visoke trave.  Slovenka na hrbtu in bosanec na njej.    Čez čas ženska opazi, da se je v bližino njuju priplazila ena kača.    Začela je vpiti na vso grlo: \"Kače, kače, kače!!!\"    Bosanec: \"Pa, sad če.\"", "Seks v travi" },
                    { 2110, true, 22, "Se pogovarjata dva policista: “Povej mi, kje si ti rojen?”  “Doma, v domači hiši. Pa ti?”  “V bolnišnici.”  “Zakaj, si bil bolan?”", "Rojen doma" },
                    { 2078, true, 22, "Kriminalist pride k kmetu, da bi preiskal njegovo posest.    Kmet mu pravi, da lahko vse pregleda, razen tistega nasada tam.    Kriminalist mu pokaže značko in pravi: \"Vidiš to značko? S to značko lahko počnem karkoli in ti ne moreš nič naredit za to!\"    Čez nekaj minut se kriminalist začne dreti, ko beži pred razjarjenim bikom.    Kmet odvrže orodje, steče k ograji in se zadere: \"Potegni značko ven! Pokaži mu značko!\"", "Ni ovir, če imaš značko" },
                    { 1982, true, 22, "Mali Jure je na cesti opazoval policista pri delu.    Policist ga je zagledal, pristopil k njemu in ga vprašal: \"Boš ti tudi policist, ko boš velik?\"    \"Jaz ne, bo pa moj brat, on je bolj slab v šoli.\"", "Malček opazuje policaja pri delu" },
                    { 759, true, 22, "V kadetski šoli profesorica razlaga: \"Osebe z omrzlinami pozimi masiramo s snegom.\"    Eden od kadetov: \"Kaj pa poleti?\"", "Na predavanju" },
                    { 734, true, 22, "Policista v knjigarni kupujeta knjigo za komandirjev rojstni dan.  “Kaj pa želite?” vpraša prodajalka. “Leksikon, filozofijo ali kaj lažjega?”  “Lahko je tudi kaj težjega, saj sva prišla z avtom.”  ", "Težja literatura" },
                    { 733, true, 22, "Policaj je odšel na safari v Afriko. Ko se je vrnil so ga sodelavci spraševali kakšne živali je lovil. Odgovoril je, da slone, leve, tigre in plisnote. Ko so ga vprašali kaj je to plisnot jim pove, da so čudne črne živali, ki skačejo po zadnjih nogah s sprednjimi krilijo in kričijo: “plisnot!”", "Plis not" },
                    { 732, true, 22, "Pretep  Mlajši in starejši policist patruljirata po ulici. Dežurni jih po radijski zvezi napoti na intervencijo v gostilno, kjer je množični pretep.  Kar ti pojdi noter, ki si mlajši in poglej, če je gneča! reče starejši policist.  Mlajši se takoj vrne s krvavim nosom.  Nobene gneče, takoj sem bil na vrsti! ", "Pretep" },
                    { 709, true, 22, "Zakaj krava leti za policijskim avtom?  Ker sta notri dva bika!", "Krava in policijski avto" },
                    { 708, true, 22, "Policaj ustavi avto, ki pridrvi dvesto, omejitev pa štirideset:  “Vi, ali niste videli table z omejitvijo hitrosti?”  Voznik: “Kako neki! Pri tej brzini?”", "Omejitev 40" },
                    { 693, true, 22, "Policist se  razgleduje po mega centru, kjer prodajajo praktično vse in nato le reče  prodajalcu.     \"Mislim sem, da so CD plošče popolnoma zamenjale gramofonske  plošče, tamle pa vidim štiri. Kar vse štiri bom vzel!\"    \"Ste vi policist?\"     \"Ja. Kako pa veste?\"     \"Veste, to je električni  štedilnik ne pa gramofonske plošče!\" ", "Nesporazum" },
                    { 641, true, 22, "Policaja privedeta s patrulje sumljivega neznanca.    Komandir: “Kaj pa je ta naredil?”     Policaja: “Nič. Ta tretjega za tarok rabva.”", "Pridržanje" },
                    { 469, true, 22, "Ura matematike na policijski akademiji.    Predavatelj v policijski uniformi razlaga račun: 5 - 7 + 2 = 0    V razredu je smrtna tišina, nihče nič ne razume.    Predavatelj se odloči, da bo enačbo razrešil s praktičnim primerom: \"V avtobusu je pet policajev. Sedem jih izstopi. Koliko policajev mora vstopiti, da bo avtobus prazen?\"", "Na policijski akademiji" },
                    { 466, true, 22, "Pogovarjata se dva policaja:    Prvi: \"Včeraj sem kupil WC ščetko!\"    Drugi: \"In?\"    Prvi: \"Mah ... Kaj pa vem. S papirjem je meni vseeno boljše!\"", "WC ščetka" },
                    { 378, true, 22, "Zakaj imajo policaji vedno sekiro v avtu?    Da lahko sekajo ovinke", "Sekira v avtu" },
                    { 230, true, 22, "Poštar: \"Za običajno pošiljko je pismo za pet gramov pretežko!\"    Policaj: \"Potem pa pustite, da se pljunek posuši in bo teža ravno pravšnja.\" ", "Policaj pošilja pismo" },
                    { 24, true, 22, "Kakšna je razlika med policajem in teroristom?  Teroristi imajo simpatizerje...", "Razlika!" },
                    { 23, true, 22, "Zakaj pride policaj v trgovino z nabito puško?  Ker na vratih piše \"akcija\".", "Akcija!" },
                    { 22, true, 22, "Gre mimo policajev otrok in začudeno vpraša: \"Zakaj obračate avto na streho?\"  Policaji: \"Saj je logično. Da stresemo pepelnik!\"", "Pepelnik!" },
                    { 21, true, 22, "Kaj je največja želja vsakega policaja ?  Da si kupi privat križišče in da gre končno na svoje.", "Želja!" },
                    { 2060, true, 21, "Pijan moški vstopi v gostilno.    Zagleda se v žensko, ki sedi za pultom, odmaje se do nje in se nagne, da bi jo poljubil.    Gospa poskoči in ga klofne.    Tip se začne opravičevati: \"Joj, res mi je žal, ampak mislil sem, da ste moja žena.\"    \"O, ti pijani, smrdljivi, neznosni bedak!\"    \"Zanimivo, ampak tudi govorite tako kot ona!\"", "Pijanček in neznanka" },
                    { 1924, true, 21, "\"Poklical sem, da vam povem, da vas imam rad.\"    \"Gospod, poklicali ste v gostilno.\"    \"Vem.\"", "Prava ljubezen" },
                    { 1882, true, 21, "Dva pijančka gresta domov iz gostilne in se izgubita.    Srečata policaja in ga prvi vpraša: \"Ej ti, a nama poveš, kje smo.\"    Policaj odgovori: \"Kako si dovolita, a vesta kdo sem jaz?\"    Pa pravi drugi pijanček:\" Nič ne bo, midva ne veva kje sva, ma ta tip ne ve niti, kdo je!\" ", "Dva pijančka v akciji" },
                    { 1841, true, 21, "Policaj zaustavi pijanca ob 4 zjutraj: \"Kam pa vi greste?\"    \"K spovedi\", odgovori pijanec.    \"A ti zajebavaš, kdo pa izpoveduje ob 4 ponoči?\"    \"Moja žena.\"", "Ob štirih zjutraj na cesti" },
                    { 1764, true, 21, "V gostilno vstopi pijanček Nace in naroči pet viskijev. Vse spije enega za drugim, nato naroči štiri viskije. Tudi te spije enega za drugim, nato naroči tri viskije, pa dva in nazadnje enega.      \"Ali ni čudno?\" je rekel natakarju, \"manj kot spijem, bolj sem pijan!\" ", "Pijanček in viskiji" },
                    { 1743, true, 21, "Doktor za bolezni odvisnosti vpraša paciente: \"Žejnemu oslu ponudijo vedro vode in vedro vina. Kaj bo spil?\"    \"Vodo!\" so v en glas povedali udeleženci srečanja.    \"In zakaj?\"    \"Ker je osel.\" ", "Srečanje alkoholikov" },
                    { 1716, true, 21, "Egon je v družbi prijatelja sključeno sedel za mizo, nagnil vrček piva in dejal:\"Nič me ne bo več prepričalo o nasprotnem! Odločil sem se, da se bom končno ločil od najbolj sitne žene na svetu!\"    \"Ne govori traparij!\" mu je rekel njegov prijatelj. \"Od moje žene se pa ti ne moreš ločiti!\" ", "Odločil se je" },
                    { 1660, true, 21, "Srečata se dva pijančka in se pogovarjata:    Joško: \"Živjo Franci, kako si?\"  Franci: \"Dobr, pa ti?\"  Joško: \"Tudi dobr. A še kaj piješ?\"  Franci: \"Pijem, pijem, saj veš, žeja. Kaj pa ti?\"  Joško: \"Normaln, tud jaz sem žejen.\"  Franci: \"A nis bil ti na zdravljenju proti alkoholizmu?\"  Joško: \"Bil, 3 mesce!\"  Franci: \"Zakva pa pol še piješ?\"  Joško: \"Ja, zašuštral so me, zašuštral!!!!\"", "Srečanje po dolgem času" },
                    { 1643, true, 21, "Pijanec se priziblje v gostilno in zakriči: \"Srečno in zdravo novo leto vsem!\"    Kelner mu reče: \"Ej, gospod, saj je komaj september!\"    \"O sranje, žena me bo ubila, tako dolgo pa še nisem nikoli bil na novoletni fešti!\"", "Srečno novo leto" },
                    { 1641, true, 21, "\"Jože, si ti kdaj slišal za zlorabo alkohola?\"    \"Seveda, to je ko nekateri s šnopsom čistijo rane, brišejo prah, perejo okna, celo mažejo rame in kolena!\"", "Neverjetno, kaj vse počnejo ljudje" },
                    { 1561, true, 21, "Policaj: \"Gospod, ste kaj popili?\"    \"Ne, nič.\"    \"Bova testirala: povejte abecedo nazaj!\"    \"ž z v u t š s r p o n m l k j i h g f e d č c b a.\"    \"Neverjetno, jaz tega ne bi mogel niti trezen.\"    \"Jaz tudi ne.\"", "Patrulja ustavi voznika" },
                    { 1550, true, 21, "Pijančka je, na sredi ulice, močno pritisnilo lulat.    Kar sredi ulice si odpre šlic in začne lulat na avtobusni postaji.    Mimo prihrumi policaj in ga opazi: \"Kaj? Uriniranje na javnem mestu? Tole bo 25€ kazni!\"    Pijanček ga komaj pospravi v hlače in začne iskati po žepih. Nakar izbrska 50€, ki jih izroči policaju.    Policaj jih vzame in začne po žepih iskati denar, da bi mu 25€ vrnil. In kar ne najde, in ne najde.    Pijanček: \"Hiiik vidim, da tole ne bo šlo. Dajte se polulat, jaz častim.\"", "Ko je nuja, je nuja" },
                    { 1546, true, 21, "Kaj je boljše od litra vina?    Dva litra vina!", "Bolje in bolje" },
                    { 775, true, 22, "\"Svečana obleka (4 črke)?\"......... \"Črna!\"    \"Mesto v Italiji (3 črke)?............. \"Trs!\"    \"Ženin brat (4 črke)?\"................ \"Mare!\"    \"Del jedilnega pribora (3 črke)?\"... \"Zob!\"    \"Najmanjše trištevilčno število (3 črke)?\".... \"000!\"    \"Utežna mera (4 črke)?\"............. \"Utež!\"    \"Zdrava pijača (3 črke)?\"........... \"Pir!\"    \"Hladno orožje (3 črke)?\"........... \"Top!\"    \"Neozdravljiva bolezen (4 črke)?\".... \"Smrt!\"    \"Mera za dragocenosti (5 črk)?\"...... \"Denar!\"", "Policaj rešuje križanko" },
                    { 853, true, 22, "Zakaj ima policaj s seboj policijskega psa.  Da je vsaj eden solan.", "Policaj in pes" },
                    { 855, true, 22, "Kaj dobiš, če križaš policaja in opico?  Nič, ker nobena opica ne bi dala policaju!", "Križanje" },
                    { 907, true, 22, "Pripelje mama sina na policijsko postajo in reče: \"Želim, da bi moj sin bil policaj.\"    Zakaj pa, gospa, vpraša policaj.     Zato, ker je neumen, mu odvrne mama.     To pa morate dokazati ...     Sine, pojdi pogledat, če je tvoja mami zunaj, reče gospa.     Sin gre ven in pogleda, nato pa policaj reče:     Je pa res neumen, lahko bi tudi čez okno pogledal!", "Želi si, da bi bil policaj" },
                    { 1979, true, 22, "Skozi predor se pelje avto in na koncu predora stoji policist, ki ta avto ustavi.    Voznik odpre okno in policist mu z nasmehom na ustih reče: \"Čestitam, vi ste milijonti voznik, ki ste se pripeljali skozi ta predor, zato vam naša država poklanja milijon evrov.\"    Voznik je začel vriskati od veselja, zato ga je policist vprašal: \"Če ni skrivnost, kako pa boste zapravili ta denar?\"    Voznik: \"Kako? Vozniški izpit bom naredil!\"    Policist malo začudeno pogleda in hoče nekaj reči, ko ga prekine voznikova žena: \"Ne mu verjeti, ali ne vidite, da je pijan?\"    Za voznikovo ženo je sedel voznikov oče, ki je bil malo naglušen in je pripomnil: \"Saj sem vedel, da z ukradenim avtomobilom ne bomo daleč prišli.\"    Policist je bil tako jezen zaradi vseh izjav, da je trikrat udaril po pokrovu prtljažnika na avtomobilu in izpod pokrova se zasliši glas: \"Francelj, a smo že čez?\"", "Nesreča v sreči" },
                    { 1960, true, 22, "Policist je pristopil k prodajalcu pečk in ga vprašal: \"Kaj prodajaš?\"    \"Pečke od jabolk.\"     \"Po koliko pa so?\"    \"10 evrov za eno pečko.\"    \"Zakaj so pa tako drage?\"    \"Ker ti po njih začnejo delovati možgani.\"    \"No, bom pa kupil eno!\" se je odločil policist.    Policist je pojedel pečko, odšel, nato pa se je kmalu vrnil. \"Prevaral si me!\" je rekel prodajalcu. \"Za deset evrov bi si lahko kupil deset kilogramov jabolk in tako dobil več sto pečk!\"    \"No, vidiš, da deluje! Možgani so ti začeli delovati!\" je rekel prodajalec.", "Pečke od jabolk" },
                    { 1915, true, 22, "Štirje policisti so se ob koncu tedna odpravili na lahka dekleta.    Dva sta se v avtomobilu usedla spredaj, dva pa zadaj.    Oddrveli so v najbolj živahno ulico. Ko so zagledali prvo prostitutko, jo voznik vpraša: \"Koliko?\" \"Kot ponavadi.Sto evrov od spredaj, od zadaj pa 50 % dražje.\"    Pa se oglasita policista zadaj: \"Zakaj je pa za naju dražje?\"", "Policisti so šli na kurbe" },
                    { 1892, true, 22, "Policist ustavi voznika zaradi prehitre vožnje in ga vpraša: \"Ali veste, kaj ste storili narobe?\"    \"Vem! Prepozno sem vas zagledal.\" ", "Ustavil ga je" },
                    { 1877, true, 22, "Štirje policaji so se za konec tedna odpravljali na taborjenje.    Da se ne bi dolgočasili, so se dogovorili, da vsak s seboj prinese kakšno družabno igro.    Ko so v kampu postavili šotor, eden vpraša: \"No, kakšne družabne igre ste prinesli s seboj?\"    \"Jaz sem prinesel pikado.\"    \"Jaz sem s seboj vzel šah\", je rekel drugi.    \"Jaz pa monopoli\", se je oglasil tretji.    \"Jaz pa vložke\", je ponosno povedal četrti.    \"Allways vložke?\", so se začudili ostali trije policisti. Za kaj pa boš potreboval vložke?    \"Enkratni so! Na televiziji sem videl reklamo, da z vložki lahko delaš kar hočeš: plavaš, jahaš, tečeš, voziš kolo, igraš tenis...\"", "Policaji in kampiranje" },
                    { 1865, true, 22, "Nemški turist se zaustavi pred slovenskim policistom in reče: \"Oprostite, iščem parkirni prostor.\"    \"In zato ste prišli iz Nemčije?\" se čudi policist.", "Išče parkirni prostor" },
                    { 1862, true, 22, "V veleblagovnici kupec želi kupiti harmoniko.    \"Kar tisto bom vzel,\" je rekel prodajalki.    \"Ste vi policist?\"    \"Kako pa veste?\"    \"Tisto je radiator, in ne harmonika.\"", "Kupil bi harmoniko" },
                    { 1859, true, 22, "Policist je pred vrtcem čakal na svojega prijatelja.    K njemu je pristopila vzgojiteljica in ga vprašala: \"Čakate na otroka?\"    \"Ne, trebuh imam od piva!\"", "Čaka pred vrtcem" },
                    { 1854, true, 22, "Trije možakarji, med njimi tudi policist, so se pogovarjali o svojih ženah.    \"Moja je kupila čoln, pa še plavati ne zna!\" je dejal prvi.    \"Moja si je kupila modrček, pa nima jošk!\" je rekel drugi.    \"Moja je pa včeraj kupila škatlo kondomov, pa niti penisa nima!\" se je oglasil policist. ", "Trije možakarji o svojih ženah" },
                    { 1852, true, 22, "\"Vi ste pili!\" reče policist vozniku.    \"Nisem!\"    \"Ste, ste. Oči imate čisto rdeče!\"    \"No, če me že žalite, tudi vi imate štrleča ušesa!\" ", "Ustavil ga je" },
                    { 1803, true, 22, "\"Katerega smo danes?\" vpraša policist svojega kolega.    \"Ne vem.\"    \"Ali ne piše v časopisu?\"    \"Ta je včerajšnji.\" ", "Dilema glede datuma" },
                    { 1795, true, 22, "Policist ustavlja vozilo, ki je  prevozilo rdeco luc.  A sok! Ko pride do avta, ugotovi.  da je za volanom njegov komandir.  Ta strogo: Zakaj si me ustavil?   Prevozili ste rdeco.  Pa kaj potem?   Menda vidis, da se mi mudi?  Ze, ze, a sem se bal, da bo kaksen  norec istocasno zapeljal v zeleno.", "Rdeca luc" },
                    { 1747, true, 22, "Policista se pogovarjata: \"Kje si bil rojen?\"    \"Doma. Kje pa ti?\"    \"V bolnici.!    \"Ubožec! A si bil tako hudo bolan?\"", "Kje je bil rojen" },
                    { 1636, true, 22, "Omejitev hitrosti je 40, ženska vozi 6 km/h prehitro in ujame jo radar. Policaj pride počasi do avtomobila in pravi:\"Kam pa vi tako hitite?\"    \"Zamujam v službo.\"    \"Dajte no, kaj pa delate tako pomembnega?\"    \"Riti raztegujem.\"    \"Kaj? Kako pa raztegujete riti?\"    \"Najprej porinem noter en prst, potem dva, pa tri, in potem celo roko. Nato obe roki in po malem raztegujem, dokler ni rit velika kaka dva metra.\"    \"Kaj za božjo voljo pa potem naredite z dvometersko ritjo?\"    \"Damo ji radar in jo postavimo tja, kjer je omejitev 40 km/h.\"", "Naletela je na radar" },
                    { 1309, true, 21, "Dolenjčki se pogovarjajo v gostilni: \"Moja žena je zelo pridna.\"    \"Kako to misliš?\"    \"Kadarkoli pridem domov, ima kaj v roki. Kuhalnico, valjar, metlo ... \"", "Ima zelo pridno ženo" },
                    { 1609, true, 22, "\"Tri hude prekrške ste storili!\" je hud policist. \"Še tistega, ki vam je dal vozniško dovoljenje, bi bilo treba kaznovati!\"    Voznik: \"Saj so ga že, zaradi ponarejanja dokumentov!\"", "Nič dobrega se mu ne piše" },
                    { 1551, true, 22, "Policaj se sprehaja po ulici in zagleda malčka, ki se trudi pritisniti na zvonec nekega stanovanja, a je premali.    Pristopi in reče: \"Ali lahko pomagam?\"    Malček: \"Da, pozvonite številko 14, prosim.\"    Policaj pozvoni, rekoč: \"Kaj pa zdaj?\"    Malček: \"Beživa!\"", "Policaj želi pomagati" },
                    { 1454, true, 22, "Zakaj policaj mece stresnike s strehe, ko piha burja? Ker z burjo tekmuje kdo jih vec vrze.", "Policaj in burja" },
                    { 1451, true, 22, "Ko se je Janezek rodil je rekel: a2+b2=c2.   Zdravniki so ga takoj operirali. Ko se je spet zbudil je rekel: a2... In zopet so ga operirali in mu iz glave pobrali vse mozgane. Ko se je tretjic zbudil je rekel: voznisko in prometno, prosim.", "Janezek bo policaj" },
                    { 1447, true, 22, "Zakaj policaj v kinu sedi v prvi vrsti?  Da bo prvi videl film.    Zakaj pa pri komediji sedi v zadnji vrsti?  Kdor se zadnji smeje, se najslajse smeje.", "Kino" },
                    { 1425, true, 22, "Poštar se pred policistom zvrne s kolesa.    \"Ali je še več takih štorov pri pošti?\" vpraša policist.    \"Ne, samo jaz sem še ostal. Drugi so že vsi pri policiji.\" ", "Poštar in policaj" },
                    { 1350, true, 22, "Železničar na železniški postaji vpraša policista: \"Ali ves, kakšna je razlika med tem vagonom in teboj?\"    \"Ne vem!\"    \"Vidiš, ta vagon ima dva razreda, ti pa samo enega.\"    \"Pa mi ti povej, kakšna je razlika med tem vagonom in teboj?\"    \"Ne vem!\"    \"Vagon bo ostal tukaj, ti greš pa z mano na postajo.\" ", "Železničar in policaj" },
                    { 1347, true, 22, "Komandir razlaga policistu, ki je komaj zapustil kadetnico, kaj so žične in kaj brezžične zveze.    Fant ne razume razlike, zato se komandir odloči, da mu bo zadevo pojasnil bolj preprosto in nazorno: \"Predstavljaj si mačka. Ko ga potegneš za rep, bo spredaj rekel miiijaaaau. Vidis, tako je pri žičnih zvezah, pri brezžičnih pa je isto, samo brez mačka.\" ", "Brezžično in žično" },
                    { 1346, true, 22, "Zakaj nosi policaj trenirko na glavi.    Ker na njej piše Kappa. ", "Policaj in trenirka" },
                    { 1200, true, 22, "Zakaj hodijo policaji gledat otrosko matinejo.  Ker otroci berejo podnapise naglas.", "Kino" },
                    { 1189, true, 22, "V kadetski soli profesor pri  predmetu o prvi pomoci razlaga  bodocim policistom:  Veste, osebe z omrzlinami po navadi   zmasiramo s snegom.  Pa se oglasi eden od kadetov:  Kaj pa poleti?", "Prva pomoc" },
                    { 1173, true, 22, "Polde vozi po enosmerni cesti  v nasprotno smer.  Ustavi ga policist in vprasa:  Mar niste vidli puscice?  Polde: Kake puscice? Se Indijancev  nisem videl!", "Puscica" },
                    { 1115, true, 22, "Kaksna je razlika med policajem in cokolado?  Nobena. Oba zapirata!", "Cokolada" },
                    { 1066, true, 22, "\"A ti ves, kaj je to policaj?\"  \"Ne.\"  \"Policaj je zakon!\"  \"Kaj pa je potem policistka?\"  \"Policistka je luknja v zakonu.\"  \"Kaj pa policijski pes?\"  \"No, vidis, to pa je solani kader!\"", "Izobrazba" },
                    { 997, true, 22, "Stajerca sredi Ljubljane ustavi policaj in ga opozori, da je prehitro vozil.  Policaj: To bo kazen 250eur in 3 pike.  Stajerc: Kazen bom placal, pike pa dajte raje NK Olimpiji, ker jih bolj potrebuje kot jaz.", "Pike" },
                    { 1552, true, 22, "Obiskovalec na policijski postaji zagleda na stenah izobešene tiralice in vpraša: \"Kdo so pa tile ljudje?\"    \"To so kriminalci, ki jih iščemo?\"    \"Zakaj jih pa niste prijeli takrat, ko ste jih slikali?\"", "Na policijski postaji" },
                    { 1323, true, 17, "Kako dobiš idealnega moškega?    Z genetskim inženiringom: križaš vibrator z bankomatom.", "Idealni moški" },
                    { 1319, true, 17, "Ona: \"Joj, dragi! Samo še en poljub mi daj, in ostanem tvoja celo življenje!\"    On: \"Hvala za opozorilo.\"", "Po romantičnem večeru" },
                    { 1315, true, 17, "Milivoj pride mimo hise  Radkomirja in ga zagleda,   kako ob 12. uri sedi na terasi   pred hiso:  Ka pa delas?  Nic.  To si rekel tudi vceraj.  Pa se nisem dokoncal...", "Ni se koncal" },
                    { 280, true, 13, "Se je odvijal simpozij pivovarjev in v odmoru se prijatelji in ostali odločijo nekaj popiti.  - Predstavnik Heinekena naroči pivo Heineken.  - iz Budweisera naroči pivo Budweiser.  - iz iz Stelle naroči Stella.  - Samo slovenec iz pivovarne Laško naroči FRUC.  Pa ga vprašajo ostali: “Pa dobro no, kako lahko na simpoziju pivovarjev naročiš FRUC?”  Pa odgovori Slovenec iz pivovarne Laško: “Pa… če vi nočete piva, potem ga ne bom tudi jaz.”", "Laško pivo in FRUC!" },
                    { 276, true, 13, "\"Ne manjka ti dosti do kretena!\" je Jože zabrusil Marku, s katerim se je prerekal v gostilni.    Marko: \"Vem! Samo korak je do tebe.\"", "Prepir za šankom" },
                    { 262, true, 13, "Gost: \"Natakar, a vi temu rečete piščanec? Počil bom od smeha.\"    Natakar: \"Vi se kar smejte, ste zelo prijazni! Drugi so me preklinjali in za menoj metali krožnike.\"", "Zanič piščanec" },
                    { 107, true, 13, "Natakar, s čim mi lahko najhitreje postrežete?    z računom", "naročilo" },
                    { 5, true, 13, "Gost: \"Gospod natakar, tale naravni zrezek sploh ni užiten.\"    Natakar: \"Ni problema! Zamenjali vam ga bomo za dunajskega.\"    Gost: \"Hja, ampak zrezek sem že načel.\"    Natakar: \"Nič zato, saj imamo tudi načete dunajske zrezke.\"  ", "Neužiten zrezek" },
                    { 4, true, 13, "Gost: \"Natakar, v moji juhi se utaplja ena muha!\"    Natakar: \"Ne skrbite, vrgel ji bom rešilni jopič.\"", "Muha plava v juhi" },
                    { 3, true, 13, "Gost: \"Natakar, v moji juhi plavata dve muhi!\"    Natakar: \"Ali mislite, da vam bosta za ta denar igrali vaterpolo?\"  ", "Dve muhe v krožniku" },
                    { 1935, true, 12, "Gorenjec je kupil novo stanovanje in se pohvalil prijatelju: \"Kupil sem novo stanovanje. Povem ti, to je zadnji krik arhitekture! Pri vratih lahko pozvoniš z nogo, z brado, z laktom, s čelom ...\"    \"A tako, normalno, z roko, se ne da?\"    \"Lahko. Ampak saj vendar ne boš prišel na obisk praznih rok?\"", "Gorenjec in novo stanovanje" },
                    { 1897, true, 12, "Gorenjcu so, na britofu, trugo skup zabili.    Zato, ker ga je pes že trikrat domov privlekel, ker je mislil, da je pijan. ", "Ni in ni odnehal" },
                    { 1890, true, 12, "Gorenjec se pritožuje: \"Kajenje zame ni noben užitek!\"    \"Zakaj?\"    \"Če kadim svoj tobak, mi je žal denarja.\"    \"Kaj pa če kadiš tujega?\"    \"Takrat pa pipa ne vleče dobro, ker jo preveč natlačim.\"", "Gorenjec in kajenje" },
                    { 1863, true, 12, "Znanec vpraša Gorenjca: \"Zakaj pa vašemu fantu tolikokrat poveste, da se zemlja vrti?\"    \"Zato, da me ne bi prosil za denar za vrtiljak.\" ", "Zemlja se vrti" },
                    { 1810, true, 12, "Žena je rekla možu Gorenjcu: \"Dragi, ali bi šla v kino?\"    \"Saj sva že bila!\"    \"Toda zdaj vrtijo že barvne filme z zvokom!\" ", "Žena bi rada šla v kino" },
                    { 1737, true, 12, "Gorenjec vstopi na matični urad in pove: \"Rad bi prijavil, da je moja žena rodila otroka. Koliko stane prijava?\"    \"Nič.\"    \"No, potem vam pa povem, da so trojčki. Pa še enega, ki je bil rojen pred leti, bi tudi rad prijavil!\" ", "Ne more iz svoje kože" },
                    { 1725, true, 12, "Zakaj gorenjci med branjem knjige za kratek čas ugašajo luči?    Med obračanjem lista pa res ne rabijo svetlobe.", "Malo po malo, pa se prišpara" },
                    { 1724, true, 12, "\"Si slišal, da na Gorenjskem mačkam porežejo repe, ko so še mlade.\"    \"Ne. Zakaj pa?\"    \"Da potem pozimi lahko hitreje za njimi zapahnejo vrata.\"", "Šparat je treba" },
                    { 1721, true, 12, "V pekarno na Gorenjskem pride možakar in hoče kupiti kruh. Pek mu odvrne: \"Podražili smo kruh! Od sedaj bo za hlebček kruha potrebno odšteti 5 evrov!\"    \"Koliko? 5 evrov? Ste mar znoreli? Zakaj pa ravno toliko?\"    \"Država zahteva od vsakega hlebca 3 evre, občina še dodatnih 1 evro, preostali 1 evro pa stane kruh, ki ga spečem.\"    Joža jezno skomigne z rokami, seže v žep in na pult položi 5 evrov. Pek pospravi denar, iz blagajne vzame 1 evro in mu jih vrne.    \"Kaj pa zdaj to pomeni?\" popeni Joža.    \"Nič. Žal mi je kruha zmanjkalo.\"", "Tole je pa rahlo sumljivo" },
                    { 1720, true, 12, "Na kmečkem turizmu turisti opazijo, da lastnik jaha svojega konja tako, da je s hrbtom obrnjen v smer ježe. Eden izmed gostov vpraša: \"Joža, zakaj pa jahaš tako? Obrniti bi se moral!\"    \"Saj se bom. Včeraj je konj med obrokom ovsa pojedel en cent pa čakam, da pride ven. Potem se bom pa obrnil.\"", "Pravi gorenjc" },
                    { 1665, true, 12, "Gorenjec ženi: \"Obleci si plašč, jaz grem v gostilno!\"    \"O! A me boš peljal na kozarček?\"    \"Ne bodi no trapasta. Samo peč sem ugasnil!\"", "Šel bo od doma" },
                    { 1484, true, 12, "Gorenjec pravi ženi: \"Obleci se plašč, jaz grem na pivo.\"    Žena reče: \"Menda me ne boš na pijačo povabil?\"    Gorenjec: \"Ne trapa, samo peč bom ugasnil!\"", "Na pijačo gre" },
                    { 1432, true, 12, "Gorenjec vprasa taksista: Koliko stane do centra.  20 evrov!  Koliko pa za prtljago?  Zastonj!  Super, potem mi pa peljite kufre, jaz pa pridem za vami pes!", "Taksi" },
                    { 1415, true, 12, "Gorenjec vstopi v gostinski  lokal in zagleda prikupno  dekle, ki samo sedi za prazno  mizo. Pristopi k lepotici in jo   ogovori:  Kaj pijete, gospodicna?  Ona: Sok.  On: Mi daste en pozirek", "Lepotica" },
                    { 1363, true, 12, "Gorenjca Kosirja obisce prijatelj  Korel s stajerskega konca.  S tresocimi se rokami mu Kosir  nalije kozarec piva, Korel ga  seveda urno zvrne.  Nato pa pol ure vrti prazen kozarec  v roki, naposled mu prekipi:  Cuj, imam prazen kozarec, mi   das se enega?  Kosir:Kaj pa ti bosta dva prazna  kozarca?", "Prazen kozarec" },
                    { 1333, true, 12, "Zakaj imajo Gorenjci tako velik nos?    Zato ker je zrak zastonj. ", "Gorenjci in velik nos" },
                    { 1332, true, 12, "Poslovni partner pride h Gorenjcu na obisk.    Naposled ga Gorenc vpraša: \"A ste za osvežitev?\"    Poslovnež reče: \"Seveda\"    Gorenc pa zavpije: \"Marta, odpri malo okno, prosim!\" ", "Gorenjc in poslovni prtner" },
                    { 1280, true, 12, "Gorenjec vpraša mladeniča: \"Ste vi tisti mladenič, ki je rešil mojo hčer izpod ledene skorje, ko je drsala na zamrznjenem jezeru?\"    \"Ja, jaz sem tisti.\"    \"In kje so njene drsalke?\"", "Rešitelj" },
                    { 1252, true, 12, "V Bohinju so hoteli zgraditi plavalni bazen.    Predsednik krajevne skupnosti je obiskal bogatega kmeta, da bi kaj prispeval.    Predsednik krajevne skupnosti: \"France boš kej prispevu za bazen?\"     France \"Bom ja! Mica dej gvaž frišne vode.\" ", "Bazen v Bohinju" },
                    { 1198, true, 12, "Kako izgleda zajtrk Gorenjca?  Dva jajca na kolo in v sluzbo.", "Zajtrk" },
                    { 1197, true, 12, "Gorenjc pride ves nesrecen v gostilno in ga vprasajo, kaj je narobe.   \"Pred tremi dnevi mi je umrl dedek in mi zapustil 10 milijonov, predvcerajsnjim mi je umrla babica in mi zapustila 25 milijonov. Vceraj mi je umrla mama in mi zapustila 30 milijonov. Danes pa je ura ze sedem zvecer in mi ni se nihce umrl.\"  ", "Nesrecen Gorenjc" },
                    { 1192, true, 12, "Kaj naredi Primorec, ce mu izpadejo vsi lasje? Kupi lasuljo.  Kaj naredi Gorenjec, ce mu izpadejo vsi lasje? Proda glavnik.", "Lasje" },
                    { 283, true, 13, "\"Tone, poglej Gorana! Tako se je napil, da ddaj že osvaja svojo ženo!\"", "Napil se je" },
                    { 1045, true, 12, "Ali ves, zakaj Gorenjci jedo regrat sele ko dobi rumene cvetove?  Da jim na solato ni treba rezati jajc.", "Regrat" },
                    { 677, true, 13, "Gost: \"Ta kolač je od včeraj, hočem današnjega!\"    Natakar: \"Potem pa pridite jutri.\"", "Kolač" },
                    { 780, true, 13, "Vesela druzba sodelavcev  popiva na sindikalni  zabavi.  Le Janez je nekako  neraspolozen in ne pije.  Zato ga sodelavec vprasa:  Kaj ti ne pijes?  Ne.Ce prevec popijem,mi  iz nosa zacne teci kri.  Poznam to.  Tudi jaz sem nekoc  imel tako zeno.", "Kri iz nosa" },
                    { 879, true, 14, "Korel in Polde bi na Hrvasko.  Prideta do meje,ko ugotovita,  da sploh nimata potnih listov.  Nekaj casa gruntata,nakar se  odlocita,da se bosta zaprla v  zaboje na bliznjem tovornjaku.  Na meji.Policija potrka po enem  od zabojnikov.  Oglasi se Korel in zakurika.  Policija gre dalje,mislec,  da so v njem res kokosi.  Potrka se na zadnji zaboj.  Glej ga,zlomka,v njem je Polde.  Ta se oglas:  Tukaj krumpir.  ", "Korel in Polde" },
                    { 871, true, 14, "Slovenec in Hrvat sta stavila, kdo bo povedal najbolj neverjetno zgodbo.  Hrvat je zacel: Nekoc je zivel eden posten Hrvat...  Slovenec ga prekine: Dobro, nehaj, dobil si stavo!", "Posteni Hrvat" },
                    { 684, true, 14, "Slovenec je zjutraj v nekem lokalu v Ljubljani pil kavo in jedel toast z maslom in marmelado, ko je k njemu prisedel Hrvat, ki je prav zoprno važno žvečil žvečilni gumi.    Slovenec ga je sicer ignoriral, ampak Hrvat je kljub temu začel s pogovorom.    \"A vi, Slovenci, pojeste ves kos kruha za zajtrk?\"    Slovenec je, nejevoljen zaradi vsiljivosti, odvrnil: \"Ja, seveda.....\"    Hrvat je iz žvečilca napihnil velik balon in potem nadaljeval: \"Mi pa ne. Na Hrvaškem pojemo le sredico. Skorje zbiramo v kontejnerjih, jih recikliramo, potem jih predelamo v toast kruhke in jih nazadnje prodamo v Slovenijo.\"  Hrvat je to rekel s porogljivim nasmeškom na obrazu, Slovenec pa ga je le tiho poslušal.    Hrvat je kljub temu vztrajal: \"A vi, Slovenci, pojeste tudi vso tisto marmelado na toastu?\"    Slovenec je spet mirno odvrnil: \"Seveda.\"    Hrvat, s čikgumijem med zobmi, je spet cinično dejal: \"Mi pa ne. Na Hrvaškem za zajtrk jemo sveže sadje. Vse olupke, koščke in ogrizke vržemo v kontejnerje, jih recikliramo, predelamo v marmelado in jo potem prodamo v Slovenijo.\"    Potem je Slovenec vprašal Hrvata: \"A vi na Hrvaškem kaj seksate?\"  Hrvat se je vzvišeno nasmehnil in dejal: \"Valjda!\"    Slovenec se je nagnil bliže k Hrvatu in vprašal: \"In kaj naredite s kondomi potem, ko jih uporabite?\"    Hrvat:\"Stran jih vržemo, kaj pa drugega?!\"    Slovenec: \"Mi pa ne! V Sloveniji jih vržemo v kontejnerje, jih recikliramo, pretopimo v žvečilne gumije in jih prodamo na Hrvaško!", "Slovenec in hrvat se pogovarjata" },
                    { 576, true, 14, "Slovenec in Hrvat stavita, kateri od njiju bo povedal bolj neverjetno zgodbo.  Hrvat je začel: \"Nekoč je živel pošten Hrvat.\"  \"Stavo si dobil!\" ga je prekinil Slovenec.", "Pošten Hrvat" },
                    { 2057, true, 13, "Gost v gostilni po celovečernem popivanju pokliče natakarja in reče: \"Pijan sem kot čep. Prinesite mi kaj, da se streznim, preden se odpeljem domov.\"    Natakar: \"Da, gospod! Takoj vam prinesem račun!\"", "Nasipal se ga je" },
                    { 1957, true, 13, "V gostilni želi gost plačati račun.    \"Kaj ste jedli?\" ga vpraša natakar.    \"To pa ve le kuhar. Jaz sem sicer naročil postrv!\"", "Malica v gostilni" },
                    { 1933, true, 13, "\"Natakar, kakšno kavo ste mi prinesli?!\"    \"Poživljajočo!\"    \"Saj je v skodelici sama voda!\"    \"No, vidite, en požirek kave, pa ste že razburjeni!\"", "Kava" },
                    { 1925, true, 13, "Tri mične gospodične v restavraciji.    Natakar pristopi k mizi in prva ga takoj ogovori: \"Kakšno je geslo za WiFi?\".    Natakar: \"jebovaskelnar\".    Druga spre vpraša: \"A z malim?\".    Natakar: \"Ne, z velikim!\".    Tretja: \"A posebej?\".    Natakar: \"Ne, vse naenkrat!\".", "WiFi geslo" },
                    { 1881, true, 13, "\"Natakar, kaj mi priporočate?\"    \"Flambirano juho, flambiran zrezek, flambirano solato.\"    \"Zakaj pa vse flambirano?\"    \"Kuhinja nam gori!\" ", "Priporočila za kosilo" },
                    { 1785, true, 13, "\"Natakar, kaj priporočate za malico?\"    \"Kaviar, gospod!\"    \"Kaj pa je to?\"    \"To so ribja jajca!\"    \"Potem mi pa prinesite tri. Ampak mehko kuhana!\" ", "Predlog za malico" },
                    { 1781, true, 13, "Dva pritlikavca sta vstopila v gostilno in za točilnim pultom naročila: \"Dva kratka!\"    \"Ja, to vidim! Kaj bosta pa pila?\" ju je vprašal natakar. ", "Pritlikavca v gostilni" },
                    { 1777, true, 13, "\"Imel sem pivo, zrezek, krompir in solato,\" našteva gost natakarju, ki piše račun.    \"Solate vam ne bom računal. Tisto so bile rože.\"", "Malo ga je zaneslo" },
                    { 1702, true, 13, "V gostilno pride razjarjen  moski z dvocevko v roki in  zavpije:  Kdo je seksal z mojo zeno?  Eden iz mnozice mu zabrusi:  Imas pa premalo nabojev.", "Premalo nabojev" },
                    { 1613, true, 13, "Na terasi: \"Natakar, zakaj ribo držite s prstom?\"    \"Iz previdnosti.\"    \"Kakšne previdnosti?\"    \"Da mi ne bi še enkrat padla na tla in bi spet stopil nanjo!\" ", "Previdnost ni odveč" },
                    { 1592, true, 13, "Prijatelja sedita ob kozarčku v  gostilni za šankom. Na proti  njiju pa dva stara zanemarjena,  zapita tipa. Poglej Lojze, takšna  bova midva čez kakšnih trideset   let, ko bova stara! Lojze ga grdo   pogleda in reče:   To je ogledalo, butelj!", "Ogledalo" },
                    { 1416, true, 13, "Dober dan! Eno mrzlo lasko  prosim!  Oprostite. Laskega pa nimam!  Je v redu, ce vam dam union?  Je potem v redu, ce vam placam  z denarjem iz monopolya?  ", "Monopoly" },
                    { 1361, true, 13, "\"Natakar, ali vaš ansambel zaigra tudi kaj po želji gostov?\"    \"Seveda!\"    \"Potem pa članom ansambla povejte, naj zaigrajo biljard, da bom lahko v miru pojedel večerjo.\" ", "Večerja ob glasbi" },
                    { 1285, true, 13, "Korel pride v gostilno na   malico.  Natakar mu prinese izbrano jed,   Korel pa:  Ta zrezek smrdi po zganju.  Natakar stopi dva metra stran in  vprasa:   A se vedno?", "Malica" },
                    { 1196, true, 13, "Stopi Polde nakresan iz gostilne in  se takoj zaleti v mimoidoco zensko.  Ta mu primaze eno okoli uses.  Polde pa: Madonca, tako hitro pa   se nikoli nisem prisel domov.", "Polde iz gostilne" },
                    { 1180, true, 13, "Polde in Korel osamljeno debatirata  za sankom. Korel: A ti ves, kdo je bil  Aleksander Veliki?  Polde: Pojma nimam.  To je bil veliki vojskovodja, pred katerim  je trepetalo pol sveta.  A si nemara ze slisal za Napoleona?  Polde molci. Vidis, tudi on je bil veliki  vojskovodja, ki je poraz dozivel sele v  bitki pri Waterlooju.  Polde ne more, da nebi vprasal:  Od kod tebi nenadoma toliko znanja?  Korel ponosno: Hja, vsak dan med sedmo in  deseto hodim v vecerno solo.  Polde je nekaj casa tiho, nakar prijavi:  Prijatelj, a ti ves, kdo je Pero Komadina?  Korel se zacudi in skomigne z rameni:  Pojma nimam.  Polde: To je tisti tip, ki je vsak vecer med  sedmo in deseto, ko si ti v vecerni soli,  pri tvoji Stefki.", "Pojma nimam" },
                    { 1154, true, 13, "Prideta dva Bosanca v gostilno in vprasata natakarja kaj ponujajo. Natakar:\"Imamo karadzodzevicev zrezek, srbsko solato in vino Car Lazar.\"  Bosanec:\"Da vam kuhar ni mogoce Drazen Mihajlovic.\"", "V gostilni" },
                    { 1135, true, 13, "Polde v gostilni utapla zalost.  Tolce pivo za pivom.  Pa ga zagleda Korel.  Kaj ti je, prijatelj?  Polde: Moja pepca me vara.  Kako? Od kod ti to?  Polde: Vracal sem se s poti,   poslal sem ji telegram, da pridem  domov, a sem jo vseeno v postelji  ujel z sosedom.  Takrat Polde nekaj presine, sam  pri sebi zamomlja: Mogoce pa le   ni tako hudo.  Kaj pa ce sploh ni dobila telegrama?", "Pepca me vara" },
                    { 1091, true, 13, "Tone sreca pred vasko gostilno  prijatelja Lojzeta.  Ta je nenavadno dobre volje,   kmalu raskrije tudi razlog za  to: Ta dez je prisel kot narocen.   Vse, kar je v zemlji, bo sedaj  ozivelo.  Tone: Si nor? Ne ga srat, ravnokar  sem pokopal tasco.", "Dobre volje" },
                    { 1028, true, 13, "Natakar, narocil sem dva jajca, vi pa ste mi prinesli samo eno. Pa se smrdi, za znoret!  Bodite srecni, da ste dobili samo eno. Pomislite, kako sele bi smrdeli dve!", "Jajca" },
                    { 1027, true, 13, "Kako pravimo cloveku, ki je od jutra do vecera v gostilni?  Natakar!", "Od jutra do vecera" },
                    { 967, true, 13, "V vaski gostilni je zivahno,  runde padajo ena za drugo,ko  se nenadoma odperejo vrata.  Z naperjeno pusko v roki vstopi  Polde.Zakrici:  Kdo je spal z mojo Pepco?  Nekaj casa je vse tiho,ko se  oglasi nekdo iz mnozice:  Premalo metkov imas s seboj.", "V vaski gostilni" },
                    { 922, true, 13, "\"Poskusite juho!\" je rekel gost.      \"Je prevroča ali prehladna?\"      \"Poskusite juho!\" je spet vztrajal gost.      \"Je preslana?!\"      \"Poskusite juho!\" je zakričal gost.      Natakar: \"Aja, žlice nimate!\"", "Poskusite juho" },
                    { 857, true, 13, "Kosir v gostilni,za druscino  je ze peta runda.  Narocajo sesto,ko Kosiru uide:  Zakaj pijem?  Marta mi je dolgo govorila,  da sem zanjo tisto,  brez cesar roze ne morejo ziveti.  Danes sem izvedel,da je to gnoj.  Natakar,ponovi!", "Gnoj" },
                    { 835, true, 13, "Maja sedi v baru,ko se ji pribliza  neznanec:  Gospodicna,vam lahko narocim  kaksno pijaco?  Plavolaska:Ne,hvala,alkohol ni  dober za moje noge:  on:A vam otecejo?  Maja:Ne,razmaknejo se.", "Neznanec" },
                    { 692, true, 13, "Policaj zaustavi pijanca ob 4 zjutraj.  \"Kam pa vi greste?\"  \"Na predavanje\" - odgovori pijanec.  \"A ti zajebavaš, kdo ima predavanje ob 4 ponoči ?!\"  \"Moja žena.\"  ", "Predavanje" },
                    { 1039, true, 12, "Gorenjc sedi v dnevni sobi in bere revijo ter vsake toliko casa ugasne luc.   Cez nekaj casa pride sosed: Je kaj narobe? Neprestano se ti priziga in ugasa luc.  Ne, nic ni narobe. Berem revijo.  Zakaj pa se potem luc priziga in ugasa?  Ja, medtem ko obracam strani pa ja ne potrebujem luci!", "Gorenjc in luc" },
                    { 1034, true, 12, "Gorenjc, s svojimi zadnjimi vzdihljaji, na smrtni postelji: \"Žena, ali si ob meni?\"    Žena: \"Da, dragi mož, tu ob tebi sem.\"    Umirajoči zopet: \"Hčerke, ali ste ob meni?\"    Hčerke: \"Da, ata, tu smo.\"    Umirajoči: \"Sinovi, ali ste tukaj?\"    Eden od sinov: \"Da, ata, vsi smo tu ob tebi\".    Umirajoči: \"Ali so tudi vsi vnukeci tu ob meni?\"    Žena: \"Da, tudi vsi vnukeci so tu pri tebi.\"    Umirajoči: \"Torej ste vsi tukaj?\"    Žena: \"Da, vsi smo tukaj.\"    Umirajoči, že čisto pri koncu, dahne: \"Zakaj pa potem tam v kuhinji luč gori?\"", "Gorenjc na smrtni postelji" },
                    { 1033, true, 12, "Kako spoznas Gorenjca na plazi?  Objema vsakogar, ki se je namazal s kremo za soncenje!", "Gorenjc na plazi" },
                    { 2015, true, 11, "Gospa pride k odvetniku, ker se želi ločiti od moža.    Odvetnik jo vpraša: \"Ali vaš mož pije?\"    \"Ne, ne pije.\"    \"Ali se drogira?\"    \"Kje pa, sploh ne ve, kaj je to droga.\"    \"Ima slabo plačo?\"    \"Ne, zasluži 4000 evrov na mesec.\"    \"Ali vas pretepa?\"    \"Ne, seveda ne!\"    \"Slabo skrbi za otroke?\"    \"Pravzaprav zelo lepo skrbi za njih.\"    \"Ali vas vara?\"    \"Nikoli me ni prevaral. On ni te sorte.\"    \"Vam ne pomaga pri hišnih opravilih?\"    \"O, pomaga. Veliko postori.\"    \"Ja, ljuba gospa, zakaj se pa potem želite ločiti od njega?\"    \"Oh, on res počne vse prav, ampak, da vidite, kakšne face ob tem poka!\"", "Zahteva ločitev" },
                    { 2007, true, 11, "Mož pride domov ob sedmih zjutraj in se skoraj zaleti v ženo, ki ga čaka na hodniku.    Žena: \"Nekam pozen si, Superman?!\"    Mož: \"Lahko ti pojasnim, draga. Bil sem s strankami ...\"    Žena: \"... in potem si z njimi razpravljal do sedmih zjutraj, kajne, Superman?\"    Mož: \"Počakaj, da končam. Uspelo mi je pridobiti novo stranko, zato sem ga odpeljal na večerjo ...\"    Žena: \"... ki je trajala do sedmih zjutraj? Superman, nikar me ne imej za norca!\"    Mož: \"Priznam, da smo šli še v nočni klub na pijačo in smo bili tam do treh ... \"    Žena: \"... ja, ja, Superman, do treh. In kje si bil do sedmih?\"    Mož: \"Nooo, odšli smo še v striptiz klub, ampak jaz sem samo gledal, bil je živi dolgčas!\"    Žena: \"Vse je v redu, Superman, ti si samo gledal in čakal. Kaj naj ti se verjamem, Superman?\"    Mož: \"Pusti, da končno povem do konca. In zakaj mi stalno govoriš Superman?\"    Žena: \"Zato, ker samo Supermannosi gate prek hlač ...\"", "Domov je prišel šele zjutraj" },
                    { 2005, true, 11, "Žena sredi noči ugotovi, da moža ni v skupni postelji.    Obleče se in ga gre iskat.    Najde ga za mizo v kuhinji, s skodelico kave pred njim.    Globoko je zamišljen in strmi v zid. Vsake toliko si obriše solzo in srkne požirek kave.    \"Kaj pa je s tabo, dragi? Kaj počneš tukaj sredi noči?\"    Soprog dvigne pogled z mize: \"Kaj se spomniš, kako sva se dobivala pred 20 leti, ko ti je bilo samo 16 let?\"    Žena, ganjena do solz, da je mož tako čutec in da se vsega spomni. \"Seveda se,\" odgovori.    On napravi najprej kratko pavzo, besede mu ne grejo lahko z jezika. \"Se spomniš, kako naju je tvoj oče zalotil, ko sva se ljubila v avtu na zadnjih sedežih ?\"    \"Da, da, spomnim, se, kaj se ne bi,\" pravi ona in sede v najbližji stol, da bi mu bila bližje.    Možak nadaljuje: \"Se spomniš, kako mi je v obraz porinil cev od šibrovke in rekel, ali se boš poročil z mojo hčerko ali pa te pošljem za dvajset let v zapor?\"    \"Tudi tega se spominjam,\" pravi ona mehko, skoraj zaljubljeno.    On pa si obriše še eno solzo z lica in reče: \"No, vidiš, na današnji dan bi me izpustili.\"", "Sama v postelji" },
                    { 1989, true, 11, "\"Draga, kaj ko bi si privoščila en lep vikend?\"    \"Prav imaš. Dajva si ga!\"    \"No, prav. Potem pa se vidiva v ponedeljek!\"", "Treba si je privoščiti" },
                    { 1986, true, 11, "Se hvali Micka prijateljici, kako ji mož pomaga pri kuhanju, pomivanju posode in likanju, odkar je bral, da so spočite žene boljše ponoči v postelji.    \"In? Ali pomaga?\" vpraša prijateljica.    \"Ne vem. Je preveč utrujen.\"", "Pomoč pri opravilih" },
                    { 1985, true, 11, "Mož: \"Mislim, da bi se morala naučiti likati, potem bi lahko shajala tudi brez služkinje!\"    Žena: \"No, če bi se ti naučil ženo malo bolj porihtati, bi nam zneslo tudi brez vrtnarja!\"", "Služinčad" },
                    { 1984, true, 11, "Mož: \"Žena, dajva, igrajva se Big Brotherja.\"    Žena: \"No, pa dajva.\"    Mož: \"Govori Big Brother. Imaš dve minuti časa, da zapustiš hišo.\"", "Big brother" },
                    { 1980, true, 11, "Mihec bere knjigo.    Ko mama vidi naslov knjige, ga vpraša: \"Mihec, zakaj bereš knjigo o vzgoji otrok?\"    \"Nadziram, ali me pravilno vzgajata!\"", "Vzgoja otrok" },
                    { 1976, true, 11, "\"Kaj je rekel oče, ko si mu povedal, da si razbil avto?\"    \"Ali naj kletvice izpustim?\"    \"Seveda.\"    \"Nič!\"", "Razbil mu je avto" },
                    { 1969, true, 11, "\"Naslednjič pokličite meteorologe!\" zavpije Lojze v slušalko in besno odloži telefon.    \"Kaj pa je bilo?\" ga vpraša žena.    \"Neki norec je že tretjič klical in vprašal, ali je zrak čist!\"", "Norec na telefonu" },
                    { 1968, true, 11, "Tinček prosi očeta: \"Očka, pelji me v cirkus!\"    \"Dragi sinko, nimam časa.\"    \"Ah, očka, pa tako zanimiv program imajo. Na tigru pleše naga lepotica.\"    \"Prav, pa pojdiva. Saj res že dolgo nisem videl živega tigra!\"", "Želi si obiskati cirkus" },
                    { 1967, true, 11, "Odvetnik posluša klientko, ki se želi ločiti od moža in ga ves čas kritizira.    \"Ampak nekaj je pa le moralo biti pozitivnega, da ste se z njim poročili?\" vpraša odvetnik.    \"Ja, je bilo, toda vse to sem do zadnjega evra potrošila!\"", "Hoče se ločiti" },
                    { 1954, true, 11, "Očka, mamica in petletni Lukec se peljejo z vlakom skozi dolg tunel.    Očka pogleda mamico in se nasmehne: \"Ali se spomniš vožnje skozi ta tunel pred šestimi leti?\"    Tudi mamica se nasmehne in pomenljivo prikima.    Sinko z zanimanjem vpraša: \"Kje sem bil pa jaz takrat?\"    Očka pojasni: \"Ko smo šli v predor, si bil pri meni, ko pa smo prišli iz predora, si bil že pri mamici.\"", "Vožnja skozi tunel" },
                    { 1949, true, 11, "Žena pravi možu: \"Danes sem veliko razmišljala o najinem včerajšnjem prepiru in ugotovila, da je bilo vse skupaj trapasto. Še posebej vse tisto, kar si rekel ti!\"", "Po prepiru" },
                    { 1939, true, 11, "Lojzka ima dva sinova.    Eden je optimist in drugi pesimist.    Ko sinova na božično jutro odpirata vsak svoje darilo, ga najprej odpre sin pesimist.  Dobi velikega plišastega medveda, pa pravi: \"Ah, to se bo takoj strgalo in umazalo.\"    Potem odpre darilni paket optimist. V njem je konjski drek.    Ko ga brat vpraša, kaj je dobil, ta navdušeno odgovori: \"Ponija, ampak ga še ni tu!\"", "Optimist in pesimist" },
                    { 1936, true, 11, "Peter je mami ponosno pokazal letno šolsko spričevalo in dejal: \"Poglej, popravil sem vse ocene!\"    \"Joj!\" je zastokala mama. \"Upam, da v šoli tega ne bodo opazili!\"", "Ponosen na spričevalo" },
                    { 1923, true, 11, "\"Očka, zakaj ti moj novi fant ni všeč?\"    \"Zato, ker s teboj hodi samo zaradi mojega denarja!\"    \"To ni res! Rekel mi je, da bi z menoj hodil, tudi če bi bila revna.\"    \"Potem je pa še večji bedak, kot sem mislil.\"", "Novi fant mu ni všeč" },
                    { 1920, true, 11, "Oče je vprašal sina, ki se je vrnil iz šole: \"In, kaj je rekla učiteljica za domačo nalogo, ki sem ti jo naredil včeraj?\"    \"Rekla mi je, da sem vsak dan bolj zabit.\" ", "Hvala za pomoč" },
                    { 1917, true, 11, "Mama razočarano pogleda Marijo. \"Marija, tvoje spričevalo je prava katastrofa! Kaj naj rečem na to?\"    \"To, kar si mi vedno rekla, če se mi je kaj slabega zgodilo!\"    \"In kaj sem rekla?\"    \"Glavno je, da si zdrava, otrok moj. Ostalo ni važno!\"", "Slabo spričevalo" },
                    { 1916, true, 11, "Prijatelj potarna prijatelju: \"Ima me, da bi se ločil.\"    \"Kaj pa se ti je zgodilo?\"    \"Občutek imam, da me žena vara.\"    \"Kako si pa to ugotovil?\"    \"Včeraj ni prespala doma in ko sem jo zjutraj vprašal, kje je bila, mi je odgovorila, da pri prijateljici Micki.\"    \"Pa, saj to ni nič takega\"    \"O, pa je!\"    \"Zakaj pa?\"    \"Pri Micki sem bil jaz.\"", "Sumi, da ga vara" },
                    { 1904, true, 11, "Miha benti na ženo: \"Z mano si nežna samo takrat, ko potrebuješ denar.\"    \"Dragi, ali ni to dovolj pogosto?\"", "Pogosto" },
                    { 1900, true, 11, "Na modni reviji. Žena se obrne k možu in mu reče: \"Ko vidim tako lepo oblečene manekenke, si takoj zaželim novo obleko.\"    \"Jaz pa novo ženo.\" ", "Mož in žena na modni reviji" },
                    { 1895, true, 11, "Par iz Minneapolisa se je odločil, da gre na dopust na Florido.    Planirala sta biti v istem hotelu, kot že velikokrat prej.    Zaradi poslovnih razlogov žena ni mogla odpotovati istočasno z možem, zato je odšel sam. Žena pa naj bi prišla naslednji dan.    Mož se je prijavil v hotel in ker je imel računalnik v sobi, je ženi poslal email. Vendar se je zmotil pri vpisovanju naslova in izpustil eno črko.    Medtem pa se je nekje v Houstonu vdova ravnokar vrnila iz pogreba svojega moža.    Odločila se je, da preveri elektronsko pošto, v pričakovanju izrazov sožalja zaradi smrti moža.    Ko je prebrala prvo sporočilo, je omedlela.    Ko je v sobo prišel njen sin, je videl nezavestno mamo na tleh in sporočilo na ekranu. To: Moji preljubi ženi Subject: Prišel sem Vem, da si presenečena, da se ti javljam, vendar imajo sedaj tu računalnike in lahko pošiljam sporočila svojim bližnjim. Ravnokar sem prispel in se vpisal ter ti sporočam, da je vse pripravljeno za tvoj prihod jutri. Se že veselim, da te spet vidim. P.S. Je pa res vroče tu doli! ", "Elektronska pošta na napačen naslov" },
                    { 1889, true, 11, "Očka, kdo je bil v tvojih otroških letih najbolj pameten?    \"Moji starši.\"    \"Kdo pa je danes najpametnejši?\"    \"Danes ste najbolj pametni otroci.\"    \"Ubogi očka. Ti pa res nikoli nisi bil pameten.\"", "Kdo je najbolj pameten?" },
                    { 1884, true, 11, "Babica pravi svoji 13-letni vnukinji: \"Ko sem bila stara toliko kot ti, sem že delala!\"    Vnukinja ji odgovori: \"Ko bom stara toliko kot ti, bom tudi še delala.\" ", "Babica in vnukinja se pogavarjata" },
                    { 1875, true, 11, "Mož predlaga ženi, da gresta na nudistično plažo.    Žena pa ni za to in pravi: \"Nočem, da vsi vidijo, da sem se poročila zaradi denarja!\"", "Kar je res, je res" },
                    { 1872, true, 11, "Sin je vstopil v spalnico staršev, ko je ravno mama skakala po očetu.    \"Ja kaj pa delata?\" je vprašal sin.    Starša, osramočeno zardita, mama pa reče: \"Poglej, kako velik trebuh ima oče! Skačem po njemu, da ne bo imel tako velikega!\"    \"Brez zveze, mami!\" je rekel sin. \"Ko tebe ni doma, mu pa ga gospodinjska pomočnica napihuje!\"", "Akcija v spalnici" },
                    { 1866, true, 11, "Mož in žena sta na sodišču, ker se želita ločiti.    Sodnik: \"Imata tri otroke, kako si jih bosta razdelila?\"    Po dolgem premisleku nista mogla priti do rešitve. Nato rečeta: \"Čez devet mesecev se vrneva s še enim!\".    Čez devet mesecev sta dobila dvojčke.", "Ločujeta se" },
                    { 1864, true, 11, "Mira se je vrnila domov precej pozno in se pohvalila bratu Igorju: \"Danes sem bila pa v lepotilnem salonu!\"    \"In kdaj boš na vrsti?\" jo je vprašal bratec.", "Vrnila se je iz salona" },
                    { 2020, true, 11, "Micka prebira horoskop in reče svojemu Janezu: \"Če bi ti prišel pet dni prej na svet, bi bil danes prijazen, pozoren do mene in velik ljubimec!\"", "Horoskop" },
                    { 2021, true, 11, "Mož in žena zdolgočaseno sedita v dnevni sobi in gledata televizijo.    Žena nenadoma vstane, se postavi pred moža in mu prisoli krepko zaušnico.    Mož v šoku začudeno vpraša: \"Zakaj pa to?\"    Žena: \"Zato, ker si slab ljubimec!\"    Mine petnajst minut, ko mož nenadoma vstane, stopi do žene in jo močno klofne.    Žena ga vpraša: \"Zakaj pa to?\"    Mož: \"Zato, ker poznaš razliko med dobrimi in slabimi ljubimci!\"", "Nenadoma pride do akcije" },
                    { 2028, true, 11, "Žena je hotela napraviti moža ljubosumnega, zato ga je vprašala: \"Dragi, kaj bi rekel, če bi ti priznala, da sem spala s človekom, ki ga imaš ti najraje?\".    Mož: \"Da si lezbijka!\".", "Ljubosumje" },
                    { 2036, true, 11, "Če želite spremeniti svet to storite dokler ste še samski.    Ko boste poročeni, ne boste mogli zamenjati niti TV programa.", "Spremeniti svet" },
                    { 1020, true, 12, "Si ze pil caj po gorenjsko?  Ne, kako pa se pije taksen caj?  Ko dezuje, vzames skodelico, se vsedes pod lipo in pocakas, da se napolni.", "Gorenjski caj" },
                    { 981, true, 12, "Gorenjec pride v nobel gostilno in stopi do glavnega natakarja:  \"Tu imate en euro!\"  Natakar: \"Ali želite rezervacijo?\"  Gorenjec : \"Ne. Zvečer pridem z žensko. Rekel vam bom za mizo, vi pa recite , da je na žalost vse zasedeno.\"", "Poceni večerja" },
                    { 978, true, 12, "Pride Gorenjc domov ves besen in pojamra ženi:  - A veš, da se je pocenil autobus za petdest centov.  - Pa zakaj si potem jezen?  -Zato, ker bom manj prišparal, ko bom šel peš.", "Znižanje cene" },
                    { 924, true, 12, "\"Zadnjič sem pa čisto ponorel...\"     \"Ja, kaj pa je bilo?\"     \"Pridem domov in najdem soseda na ženi.\"     \"Aha, in potem si znorel?\"    \"Ah, kje pa. Kaj pa naj reva počne. Mene cele dneve ni, ker delam, in ko se vrnem, sem utrujen, padem in zaspim. Naj si da duška.\"    \"Kaj pa je bilo potem?\"    \"Grem v sobo od hčere in jo najdem z dvema.\"    \"Aha, to je bilo.\"    \"Ne, ne. Saj mora punca eksperimentirati, bo potem bolj umirjena.\"    \"Grem v sobo od mulca in si ravno iglo v žilo rine.\"    \"In potem si imel dosti?\"    \"Kje pa. Sem si mislil, da je to nekaj modernega in da pač mora tako biti.\"    \"Ja, kaj pa je bilo potem?\"    \"Pridem v dnevno sobo, nobenega tam, radiator pa na maksimumu in prižgana luč... pol se mi je pa čist utrgal!!!\"", "Znorel je" },
                    { 912, true, 12, "Uspešen poslovnež živi izjemno stresno življenje v mestu in nekega dne se odloči temu narediti konec. Vzame vse svoje prihranke in kupi veliko kmetijo nekje na samem na Gorenjskem.    Po par mesecih prijetnega življenja v samoti zasliši bobnenje kopit pred svojo hišo. Pograbi lovsko puško in jo usmeri proti moškemu na konju.    \"Počasi, počasi, sosed,\" mu reče moški. \"Posprav puško. Jaz sem tvoj sosed. Moja kmetija je samo 10 kilometrov stran in rad bi te povabil na zabavo za dobrodošlico, ki ti jo bom priredil naslednjo soboto. Imeli bomo glasbo, plesalo se bo, objemalo, poljubljalo, pilo, teplo … Skratka, super žur.\"    Ker noče biti nesramen, spusti puško in vpraša: \"Aha, no, kako pa naj se oblečem za ta super žur?\"    \"Hja, kokr češ,\" mu odgovori, \"itak bova samo jst in ti.\"", "Kupil je kmetijo na gorensjekm" },
                    { 870, true, 12, "Katera je najboljsa gorenjska delovna zival?  Zirafa!  Ker se pri sosedu pase, doji pa doma.", "Delovna zival" },
                    { 868, true, 12, "Druzba mladih Gorenjcev  se po sluzbi napoti v  gostilno.  Ko si eden od njih premisli:  Danes ne grem z vami!  Prijatelji so zacudeni:  Zakaj pa ne?  A nisi nic zejen?  Sem,toda brez denarja sem.  Drugi v en glas:  Nic hudega.  Zaradi tega gres lahko vseeno z  nami.Saj ni treba,da kaj narocis!", "Brez denarja" },
                    { 841, true, 12, "Marto ena od prijateljic zaupno  vprasa:  Sem slisala,da si se zaljubila v  Gorenjca.  Marta zardevajoce:  Ja,res je.  Mi lahko pokazes njegovo sliko?  Ne se,poslal mi jo je,  a moram prej razviti negative.", "Ljubezen" },
                    { 646, true, 12, "Vprašajo Gorenjca: \"Ali imaš kakšnega prijatelja?\"    Gorenjc: \"Imam enega ... ampak ga ne maram!\"", "Prijatelji" },
                    { 561, true, 12, "Žena svojemu možu gorenjcu napiše SMS: “Dragi nujno potrebujem nekaj denarja... Bi lahko prosim šel na bankomat in dvignil 50€?”  Gorenjc nekaj časa razmišlja, kaj bi naredil nato pa ženi odgovori: “Napaka! Sporočilo ni bilo dostavljeno.”", "Gorenjc in bankomat" },
                    { 403, true, 12, "Kdaj gre Dolenjec trezen iz gostilne?     Takrat ko Gorenjec plača pijačo.", "Gostilna" },
                    { 338, true, 12, "Kako je nastal bulldog??  Gorenjec ga je hranil skozi šipo.", "Bulldog" },
                    { 250, true, 12, "Taksist pelje gorenjca po klancu navzdol in avto vedno bolj pridobiva na hitrosti. Vedno hitreje in hitreje. Na ovinkih že škripljejo gume. Taksist se obrne k potniku in mu zgroženo reče:  \"Ne morem ustaviti avta! Zavore so odpovedale!\"    Gorenjc: \"Potem pa vsaj ugasnite taksimeter!\" ", "Gorenjc in taksi" },
                    { 231, true, 12, "Katera narečna skupina v Sloveniji se najhitreje dogovori za seks?    Gorenjci!    Zakaj?    Moški: \"A b?\"  Ženska: \"B!\"", "Dogovarjanje za seks" },
                    { 13, true, 15, "Janez je radoveden, nekaj mu ne da miru, zato se obrne k fotru:     Janezek: \"Alo foter, daj mi povej kaj je to impotenca?\"     Tastar nekaj časa poglobljeno razmišlja in izusti: \"Veš sine, to je približno tako kot, če bi igral pikado s kuhanimi špageti.\"", "Impotenca" },
                    { 65, true, 12, "Zakaj Gorenjci umrle pokopavajo tako, da zadnjica mrličev štrli iz zemlje?  Zato, da lahko parkirajo kolesa.", "Gorenjci in pokop" },
                    { 63, true, 12, "Gorenjec je povabil prijatelje na praznovanje svoje petdesetletnice in jim rekel:  \"Pridite vsi naenkrat, da se ne bodo znucali tečaji na vratih!\"", "Gorenjec in abraham" },
                    { 62, true, 12, "Gorenjec in njegovo dekle sta sedela v kinu in Gorenjec je grizel čokolado, ki jo je kupil pri vhodu v dvorano.  \"Ali je dobra?\" ga je vprašalo dekle.  \"Ja, odlična je! Tudi ti bi si jo morala kupiti!\"", "Par v kinu" },
                    { 61, true, 12, "Srečata se dve muhi in ena reče:  \"Kje si bila tako dolgo? Že več let te nisem videla!\"  \"Slučajno sem poletela v denarnico nekega Gorenjca!\" je povedala izgubljenka.", "Muha v denarnici" },
                    { 2126, true, 11, "V tej miniki ne greš ven pa pika!    Ampak zakaj ne oči???    Ker se ti vidijo jajca, Marko.", "Strog oče" },
                    { 2118, true, 11, "Sin: \"Ati, zakaj je moji sestri ime Jagoda?\".    Oče: \"Ker ima tvoja mami rada jagode.\".    Sin: \"Hvala, ati.\".    Oče: \"Ni problema, Vinko.\".", "Imena otrok" },
                    { 2108, true, 11, "Sin: \"Ata, mamo moramo prodati!\"  Oče: \"Zakaj?\"  Sin: \"Jaz več ne zizam, ti ne seksaš, zakaj bi jo hranili za soseda?\"", "Prodati mamo" },
                    { 2068, true, 11, "\"Po kom pa imaš modre oči?\"    \"Po očetu, ki je bil boksar.\"", "Modre šči" },
                    { 2067, true, 11, "\"Končno je moj mož prenehal gristi nohte!\"    \"Kako mu je pa to uspelo?\" \"Skrila sem mu zobe!\"", "Grda razvada in rešitev" },
                    { 2056, true, 11, "Janez je imel šest otrok in je bil na to tako ponosen, da je ženo, kljub njenemu nasprotovanju, začel klicati mati šestih.    Ko sta se nekega večera odpravljala na zabavo, je zavpil proti kopalnici: \"Mati šestih, ali boš kmalu gotova?\"     \"Samo še minutko, oče štirih!\"", "Prekipelo ji je" },
                    { 2050, true, 11, "Mož besno vpraša svojo ženo: \"Žena, zakaj si me varala s skoraj vsemi mojimi prijatelji?\"    Žena: \"Zato, ker mi sovražnikov nisi predstavil!\"", "Resno vprašanje" },
                    { 2048, true, 11, "Ugleden zdravnik je z ženo v gledališču.    Med premorom pijeta šampanjec, ko se mimo njiju sprehodi dekle v tesni oblekici. Pogleda zdravnika in reče: \"Pozdravljeni, gospod zdravnik!\"    Zdravnik v zadregi pogleda soprogo in se začne opravičevati: \"Saj razumeš, draga, da v tem poklicu spoznaš veliko ljudi.\"    Žena: \"Čigavem poklicu? Tvojem ali njenem?\"", "Neprijetna situacija" },
                    { 2047, true, 11, "Žena se huduje nad možem: \"Občutek imam, da te sploh ne zanima, kako gre najinim otrokom v šoli.\"    Mož: \"Oh, draga, pretiravaš, tvoji občutki te varajo. Ravno prejšnji teden sem jih vprašal, v kateri razred hodijo!\"", "Skrb za otroke" },
                    { 2040, true, 11, "Ženska se pritožuje arhitektu, ki je projektiral hišo, da se tla in zidovi neznosno tresejo, ko pelje mimo hiše avtobus.    \"Tresenje je tako močno, da me skoraj vrže iz postelje. Če mislite, da pretiravam, preizkusite,\" pravi ženska.    Arhitekt res leže v posteljo.    Takrat vstopi mož in začuden zavpije: \"Kaj pa vi v moji postelji?!\"    Arhitekt: \"Saj vem, da mi ne boste verjeli, ampak na avtobus čakam!''", "Ženska se pritožuje" },
                    { 2037, true, 11, "Odpravila sva se na dopust.    Vključil sem telefonski odzivnik, pokril kletko s kanarčkom in spustil mačko na dvorišče.    Žena je poklicala taksi, ki je precej hitro pripeljal.    Ko sva zapuščala hišo, se je mačka nekako med nogami izmuznila nazaj v hišo.    Nisva je želela pustiti v hiši, ker se neprestano trudi požreti kanarčka.    Žena je vstopila v taksi, jaz pa sem se vrnil v hišo, da bi mačko spet pregnal na dvorišče.    Medtem je že zbežala v zgornje nadstropje.    Žena, ki je čakala v taksiju, ni želela, da bi taksist izvedel, da bo hiša nekaj dni prazna, zato je pojasnila, da sem se vrnil v hišo zato, da bi voščil lahko noč njeni mami.    Čez dobrih 10 minut sem se končno usedel v taksi. \"Žal mi je, ker ste tako dolgo čakali,\" sem rekel in naprej pojasnjeval: \"Neumnica se je skrila pod posteljo. Z dežnikom sem jo moral drezati v rit, da je prilezla ven. Potem se je odločila, da pobegne, pa sem jo zagrabil za vrat. Začela je praskati, tako da sem jo zavil v odejo, da me prasica ne opraska. Ampak uspelo mi je! Na koncu sem jo odvlekel po stopnicah in jo vrgel na dvorišče. Upam, da se nam ne bo spet posrala pred vrati!\"    Lahko si predstavljate tišino, ki je nastala v taksiju!", "Odhod na dopust" },
                    { 64, true, 12, "Kdaj gre Dolenjec trezen iz gostilne?  \"Kadar ga časti Gorenjec.\"", "Gorenjc in Dolenjec" },
                    { 38, true, 15, "Oče vozi avto, na zadnjih sedežih sedita Janezek in njegova punca.    Dan je vroč, klima je crknila, oče odpre okno in veter potegne po avtu.  Vpraša sina: \"Janezek, ti vleče?\"    Janezek: \"Ne, samo objemava se.\"", "Janezek s punco na zadnjem sedežu" },
                    { 104, true, 15, "Janezek vpraša svojo učiteljico, če lahko govori z njo po šolski uri. Ona se strinja.      Učiteljica: In, Janezek, kaj mi želiš povedati?    Janezek: Mislim, da sem preveč pameten, da bi ostal v tem razredu, ker se dolgočasim.  Želim, da me daste direktno v gimnazijo.    Učiteljica obvesti o tem ravnatelja, ki vpraša Janezka, če lahko naredi test.    Janezek se strinja brez oklevanja in ravnatelj začne s vprašanji:    Ravnatelj: No, Janezek, da vidimo... 13x4?  Janezek: 52!    Ravnatelj: In kvadratni koren iz 9 ?  Janezek: 3, gospod ravnatelj.    Ravnatelj: Glavno mesto JaponskeJanezek: Tokio.    Test traja še pol ure, Janezek pa ne naredi nobene napake. Na koncu je ravnatelj  zadovoljen z rezultatom, učiteljica pa vpraša, ali mu lahko zdaj ona postavi nekaj vprašanj.  Oba se strinjata in učiteljica začne spraševati:    Učiteljica: Dobro, Janezek. Krava ima 4, jaz pa 2. Kaj je to?  Janezek: Noge, gospa učiteljica.      Učiteljica: Točno. Kaj lahko najdemo v tvojih hlačah, v mojih pa ne?    Ravnatelj je presenečen nad vprašanjem...    Janezek: Žepe!    Učiteljica: Dobro, Janezek. Kje so ženske najbolj kodraste ?      Ravnatelj se pripravlja, da poseže z besedo med njiju,    a Janezek odgovori:V Afriki    Učiteljica: Kaj je mehko a na rokah ženske postane trdo?    Ravnatelj zavije z očmi, a Janezek spet odgovarja.    Janezek: Lak za nohte.    Učiteljica: Kaj imajo moški in ženske na sredini nog?    Janezek: Kolena!    Učiteljica: V redu. Kaj ima poročena ženska širše kot neporočena?    Ravnatelj ne more verjeti svojim ušesom.    Janezek: Posteljo, gospa učiteljica.    Učiteljica: Kateri del mojega telesa je največkrat vlažen?    Janezek: Vaš jezik!    Učiteljica: Katera beseda se začne s črko ''p'' in označuje nekaj, kar se pod moško roko orosi, moški pa hoče še.    Janezek: Pivo    Ravnatelj je brez sape, ves moker od znoja, odloči se, da bo prekinil test in vzklikne:  Ne bom te poslal v gimnazijo ampak direktno na fakulteto! Zame bi bila vprašanja pretežka!      Nauk: Perverznost se pojavi z leti! ", "Janezek na testu, ker je pameten" },
                    { 112, true, 15, "Janezek stoji v vrsti v lekarni in se dere: \"Kondome rabim, kondome rabim!!!\".    Ko pride končno na vrsto, ga lekarnar okara:  \"Prvo, kot prvo se ne dere v vrsti.  Drugo, kot drugo si premlad, da bi rabil kondome.  Tretje, kot tretje sploh ne vem kakšno velikost bi ti rabil.\".    Janezek mu ne ostane dolžen:  \"Prvo, kot prvo so nas v šoli naučili, da moramo vse povedati jasno in glasno.  Drugo, kot drugo kondomi niso zame, ampak za mojo sestro.  Tretje, kot tretje rabi različne velikosti, ker gre na maturantski izlet!\".", "Janezek kupuje kondome" },
                    { 149, true, 17, "Pride moški v trgovino in prosi prodajalko, naj mu pomaga izbrati moderček za ženo.    Prodajalka: \"Kakšno velikost pa rabite?\"    Moški; \"Ne vem.\"    Prodajalka: \"Ja kakšne prsi ima vaša žena? Take, kot jabolka?\"    Moški: \"Ne.\"    Prodajalka: \"Takšne kot lubenice?\"    Moški: \"Eh, pozabite sadje. Ali veste, kakšne uhe ima koer španjel?\"", "Mož kupuje modrček" },
                    { 148, true, 17, "Mož se je odločil, da bo ženi za rojstni dan kupil lep kostim, zato je obiskal prodajalno in res izbral prelep kostim.    Prodajalka ga je vprašala, katero številko potrebuje, on pa je pojasnil:  \"Za številko ne vem, toda ko doma vstane s kavča, mi z ritjo zakrije celoten ekran televizije, ki v diagonali meri 82 cm!\" ", "Številka kostima" },
                    { 2080, true, 35, "Po lovu so vsi lovci dali 2 evra za slasten golaž, ki jim ga je pripravil kolega, le lovec Jaka ni nikoli dal prispevka, raje si je prinesel malico od doma.    Nekoč po lovu so mu kolegi izmaknili iz suknjiča malico. Pol krajnske klobase so mu zamenjali z zamrznjenim pasjim iztrebkom in vrnili zavitek v žep suknjiča.    Ko že vsi jedo golaž Jaka še vedno nemirno hodi okrog in kadi. Pa ga le eden od lovcev privoščljivo vpraša: \"Kaj je s tabo Jaka, a ne boš danes nič malical?\"    \"Saj bi, pa sem pol klobase dal pogreti v golaž, sedaj je pa kuhar ne najde!\" ", "Navihani lovci" },
                    { 1902, true, 35, "Včeraj je lovec Aleš spet prišel pijan z lova.    \"Kako pa veš, da je bil pijan?\"    \"Psa je nesel v nahrbtniku, fazana pa je imel privezanega na vrvici.\"", "Malo je zamešal" },
                    { 1813, true, 35, "Jure je obiskal lovskega tovariša in ga vprašal: \"Je res, da si na lovu zadel? Kje imaš pa plen? V pečici?\"    \"Ne, v bolnišnici.\" ", "Uspešen ulov" },
                    { 1812, true, 35, "Lovska disciplinska komisija obravnava kmeta Andreja.    \"Zakaj ste ustrelili zajca, če pa niste član lovske družine?\"    \"Zato ker je jedel moje zelje, čeprav ni član moje družine.\" ", "Na obravnavi pred lovsko komisijo" },
                    { 1699, true, 35, "Zena je rekla mozu lovcu, ki se je  odpravljal na lov:  Dragi. Ce bo divjacina predraga,   lahko kupis tudi govedino!", "Meso" },
                    { 1604, true, 35, "Oženil se je mladi lovec, katerega žena je bila tudi lovka.    Imeli so pravo lovsko poroko, ki je trajala celo noč.    Proti jutro sta šla ženin in nevesta k \"počitku\" in tašča ,se je odločila, da jih bo opazovala skozi ključavnico,kako se bo njen ta mladi, prvo noč obnesel.    Seveda sta bila v trenutku že v \"elementu\". Ona je vzela tangice in mu jih je začela voziti mimo nosa sem cik-cak. Ta mladi jih zavoha, obrne ženo na hrbet in hop jo že napiči od zadaj.    Tašča to vidi in si misli: \"To je treba danes pri mojem dedcu poskusiti.\"    Rečeno storjeno! Pohiti v spalnico in vidi ta starega, kako že mrtvo pijan leži v postelji. Takoj se sleče in njene ogromne gate začne ujčkat ta staremu pred nos.    Stari rukne pokonci in pravi: \"Baba puško brž! Dihurja imamo v bajti!\"", "Mlad lovec se oženi" },
                    { 1352, true, 35, "Predsednik lovske družine sprašuje kandidata za sprejem med lovce: \"Kaj je potrebno, da postaneš dober lovec?\"    \"Mirna roka, bister pogled in močan glas ... \"    \"Zakaj pa močan glas?\"    \"Da te slišijo, ko pri lovu na divje prašiče z drevesa kričiš na pomoč!\" ", "Kakšen mora biti lovec" },
                    { 1351, true, 35, "\"Lisica je najbolj zvita zver!\" razlaga lovec Miha.    \"Si prepričan?\"    \"Sem. Ko sem jo ustrelil - se je pri priči spremenila v mojega psa.\"", "Lisica je zvita zver" },
                    { 834, true, 35, "Umre lovec Lojze,zelena bratofcina  ga pride kropit.  Stopijo do krste in vidijo,da je  revez vanjo pribit z zeblji.  Pa se le ojunacijo in vprasajo  vdovo:Francka,zakaj pa je tvoj  Lojze pribit v krsti?  Ona:Ni mi preostalo drugega,ga je   pes ze trikrat privlekel v kuhinjo,  ker, je mislil,da se ga je spet  nacedil!", "Bratofcina" },
                    { 703, true, 35, "\"V nedeljo sem ustrelil pet rac!\" se hvali Polde.    \"So bile divje?\"    \"Race ne. Je pa bil divji njihov lastnik.\"", "Streljanje rac" },
                    { 673, true, 35, "Dva lovca hodita po gozdu in eden od njih se kar naenkrat zgrudi na tla in negibno obleži.    Drugi lovec hitro potegne iz žepa svoj mobilni telefon in pokliče 112.    Ves razburjen pove operaterju, \"Moj prijatelj je mrtev! Kaj naj storim?\"    Operater ga miri: \"Pomirite se. Pomagal vam bom. Najprej, prepričajte se da je res mrtev.\"    Nastopi tišina, nato se zasliši strel. Spet se javi lovec \"OK, kaj pa zdaj?\"", "Situacija na lovu" },
                    { 258, true, 35, "Za šankom stoji lovec in razlaga svojemu prijatelju: \"Veš, zadnjič smo imeli skupni lov. In mojo ženo je lovski kolega ustrelili v prst. In zdaj je ni več!\"    Njegov prijatelj: \"Pa, saj zaradi tega ni mogla umreti? Prst poviješ, pa je!\"    Lovec: \"Ne, ne. Tako se je drla, da sem ji bil primoran dat milostni strel ...\"", "Lovec, ki je vdovec, razlaga" },
                    { 257, true, 35, "Med organiziranim lovom lovec na robu gozda, v zasedi, čaka na strel.    Nakar iz grmovja prideta dva možakarja z nosili.     Začudeno ju vpraša: \"Kaj pa je to?\"    Možakarja: \"Enega izmed gonjačev so obstrelili.\"    Lovec: \"Kaj tudi njih lahko streljamo? Škoda, da tega nisem prej vedel.\" ", "Lovec na skupnem lovu" },
                    { 256, true, 35, "Med lovom, na katerem imajo lovci tudi žene, se zgodi nesreča: lovec svojemu lovskemu prijatelju, po nesreči, ustreli ženo.    Vdovec: \"Ti bedak, a si ti nor?!? Kaj si zmešan??? Kako si mi lahko ustrelil ženo?\"    Strelec: \"Pa kaj se toliko dereš? Na, tu imaš puško, pa ti ustreli mojo!\"", "Lovci z ženami na lovu" },
                    { 7, true, 35, "Zakaj imajo lovski psi povešena ušesa?    Zato, da ne slišijo, kako se jager laže!", "Ušesa od lovsega psa" },
                    { 328, true, 16, "V Ribnici je sejem pa nekemu gospodu stopi na nogo Itlijan pa rece skuzi senior,skuzi... Pa rece Ribnčan:ne,nč nej šlu skuzi sm mau je bolajlu", "Sejem" },
                    { 2070, true, 15, "\"Kaj bi rad postal, ko odrasteš,\" vpraša Janezka soseda.    \"Zdravnik,\" odgovori Janezek.    \"A res? Zakaj pa,\" je radovedna.    \"Ker je to edini poklic, v katerem lahko ženskam rečeš naj se slečejo, račun za storitev pa naprtiš njihovim možem.\"", "Ko odraste" },
                    { 2064, true, 15, "Učiteljica sprašuje otroke, kako so prišli na svet.    Metka pravi, da jo je prinesla štorklja, Anže je rekel, da ga je prinesla teta iz Amerike, Vanja je rekla, da so jo kupili v trgovini.    Janezek pa vpraša: \"Učiteljica, kaj tisti, ki že seksamo, lahko gremo ven iz razreda, na en čik?\"", "Kako smo prišli na svet" },
                    { 2049, true, 15, "Janezek pride v ginekološko ambulanto. Dolgočasi se, ko čaka, da pride mamica na vrsto.    Mimo pride nosečnica in Janezek z roko pokaže na njen trebuh ter jo vpraša: \"Teta, kaj pa je to?\"    \"To je moj dojenček.\"    \"Pa ga imate radi?\"    \"Seveda, zelo ga imam rada.\"    \"Zakaj ste ga pa potem pojedli?\"", "Janezek v čakalnici" },
                    { 2016, true, 15, "Janezek za rojstni dan dobi papagaja.    Nekega dne ga ponesreči pozabi v hladilniku.    Po dveh urah iskanja se končno spomni, kje je.    Odpre hladilnik, se zagleda v ptiča in ljubeče reče: \"Koga moje očke vidijo?\"    Papagaj jezno začivka: \"Pingvina, idiot!\"", "Janezek in pingvin" },
                    { 1995, true, 15, "Učiteljica: \"Povejte vsaj eno kratko zgodbico z naukom na koncu!\"    Mojca: \"Moj dedek je nesel jajca v košari, pa se je spotaknil, košara mu je padla na tla in vsa jajca so se razbila.\"    Učiteljica: \"Dobro, in kakšen je nauk?\"    Mojca: \"Nikoli ne nosi vseh jajc v eni košari!\"    Jožek: \"Moj ata je imel v inkubatorju 10.000 jajc in je že vnaprej prodal 10.000 mladih piščancev, potem pa se jih je izvalilo samo 8.000.\"    Učiteljica: \"In nauk?\"    Jožek: \"Nikoli ne prodajaj piščancev, dokler se ne izvalijo.\"    Janezek: \"Moj stric Franc je bil v tujski legiji. Nekoč so leteli in letalo se je pokvarilo. Moral je skočiti s padalom in s seboj je uspel vzeti samo brzostrelko, mačeto in liter šnopsa. Med padanjem je popil ves šnops. Ko je pristal, ga je napadel bataljon črncev. Najprej jih je 50 postrelil z brzostrelko. Ko mu je zmanjkalo nabojev, jih je še 20 posekal z mačeto. Ko se je zlomila, je pa še preostalih 10 pokončal z golimi rokami.\"    Učiteljica požre slino, se odkašlja in zajame sapo: \"In kaj je tu nauk zgodbe Janezek?\"    Janezek: \"Nikoli se ne zajebavaj s stricem Francem, kadar se napije!\"", "Nauk zgodbe" },
                    { 1991, true, 15, "Učiteljica naroči učencem, naj do konca pouka narišejo risbo in jo oddajo.    Janezek odda prazen list.    Učiteljica ga vpraša: \"Janezek, kaj si pa ti narisal?\"    Janezek: \"Kravo in travo.\"    Učiteljica: \"Kje pa je trava?\"    Janezek: \"Krava jo je pojedla.\"    Učiteljica: \"Kje pa je krava?\"    Janezek: \"Šla je, ker ni bilo več trave!\"", "Izvirna risba" },
                    { 1977, true, 15, "V šoli se pogovarjajo, kako so nastali.    Skoraj vsi v razredu zakričijo, da jih je prinesla štorklja, le Janezek je tiho.    Pa ga vpraša učiteljica: \"Kako si pa ti nastal?\"    Janezek odgovori: \"Iz jajca.\"    \"Ne moreš priti iz jajca,\" pravi učiteljica.    \"Kako ne? Če sem pa včeraj slišal sosedo, ki je rekla svoji prijateljici, da sem sin tiste koklje Marte!\"", "Kako pridemo na svet" },
                    { 1964, true, 15, "V šoli pri pouku matematike učiteljica vpraša Janezka: \"Janezek, na veji sedijo tri vrane, lovec eno ustreli, koliko jih še sedi na veji?\".    \"Nobena, učiteljica. Ustreljena pade, ostali dve pa odletita.\".    \"Janezek, narobe. Dve še sedita na veji. Ampak mi je pa všeč tvoj način razmišljanja.\".    Janezek je nekaj časa tiho, nato pa dvigne roko: \"Učiteljica, sedaj bi pa jaz vas nekaj vprašal!\".    Učiteljica malo premišljuje, kaj neki bo Janezek spet ušpičil, pa ji radovednost ne da miru in se odloči: \"No, Janezek, pa vprašaj!\".    \"Takole, po cesti hodijo tri ženske in v roki držijo sladoled. Prva ga grizlja, druga ga sesa, tretja ga pa liže. Kaj mislite, katera od teh treh je poročena?\"    Učiteljica zardi in je malo v zadregi, nato pa le odgovori: \"Janezek, mislim da tista ki ga sesa!\".    \"Učiteljica, narobe. Tista, ki ima na roki poročni prstan. Ampak mi je pa všeč vaš način razmišljanja!\".", "Navzkrižna vprašanja" },
                    { 1951, true, 15, "Janezek gre v gostilno in naroči viski.    Natakar pravi, da mu ne more dati viskija, ker ni dovolj star.    Janezek plane v jok in natakar ga vpraša, zakaj joka.    Janezek odgovori: \"Ati in mami sta mi rekla, če bom pil alkohol, da bom dobil mačka!\"", "Janezek in alkohol" },
                    { 1922, true, 15, "Učiteljica je dala učencem za domačo nalogo da napišejo, kako so prišli na svet.    Janezek je doma, ravno med lupljenjem krompirja, vprašal mamo, iz česa je nastal.    Mami se ni dalo pogovarjati o tej temi, zato je pokazala na krompir in rekla: \"Iz tega!\"    Naslednji dan v šoli. Janezek ima krompir v žepu, tako kratko nalogo kot je dobil pa ni napisal.    Vsi njegovi sošolci so že prebrali svojo domačo nalogo, ko pa je prišel na vrsto Janezek je vprašal učiteljico: \"Ali naj ga najprej izvlečem in nato pripovedujem, ali naj najprej povem in ga nato izvlečem?\"    \"Nič ni potrebno!\" ga je prekinila učiteljica, \"očitno se zelo dobro spoznaš na to temo!\"", "Kako so prišli na svet" },
                    { 1894, true, 15, "Janezek je nekoliko zamudil pouk, zato se je poskušal potihoma pritihotapiti v razred.    Učiteljica ga opazi in ga ozmerja: \"Kaj je Janezek? A se tvoj oče, ko pride domov, tudi takole hinavsko priplazi domov? Pojdi ven in pridi v razred, kot se spodobi!\"    Janezek gre ven in zapre vrata.    Čez nekaj časa vrata skoraj padejo s tečajev, Janezek pa s čikom v kotičku ust in steklenico piva v roki prilomasti v razred, zaloputne vrata, vrže čik na tla, ga pohodi, na dušek spije preostanek piva in reče: \"Kva j'tastara, kva pa z'jaš? A si misl'la, da me še ne bo?\" ", "Janezek zamudi k pouku" },
                    { 171, true, 17, "Samski moški je stanoval v 4. nadstropju. Moral bi si zlikat srajco, zaradi sestanka naslednji dan, in ni imel likalnika.    Spomni se na sosedo iz pritlicja in sklene, da jo bo prosil, ce mu posodi likalnik.    Ko je bil v 3. nadstropju si misli  \"Ni slaba tale soseda, pravzaprav je kar dobra mrha. Mogoče me bo ogovorila, pa pade še kaksna kavica.\"    Ko je bil v 2. nadstropju si misli  \"Jah, kavica, pol pa tralala, pa vincka, pol smo pa tam, jo bom moral povabiti še k sebi.\"    Ko je bil v 1. nadstropju si misli  \"Če jo povabim k sebi, bo pol prišla. Pol jo bom pa kresnu. Pa enkrat pri njej, pa spet pri meni, pol pa spet pri meni, pa spet.\"    Ko je bil v pritlicju si misli  \"Mater, pol bo pa že stvari začela gor nosit in pri meni spat, pa stvari urejat po svoje, pa pohištvo premikat, pa se psa ima, pol se je pa znebit ne bom mogel\"    In ko takole premišljuje že avtomatično pozvoni, soseda odpre vrata, se veselo nasmehne in zažvrgoli:  \"O sosed, kako ste kaj, vam lahko kako pomagam?\"    Moški pa reče:  \"Ma jebi se ti s tvojim likalnikom vred!!!\"", "Moški brez likalnika" },
                    { 226, true, 17, "To, da so vsi moški isti, si je izmislila ena kitajka, ki je svojega deca izgubila v gužvi...", "Vsi moški so isti!!!" },
                    { 294, true, 17, "Biti poročen je isto, kot da bi polno karjolo vozil v hrib. Sam težko, dva pa ne moreta.", "Poroka" },
                    { 311, true, 17, "pogovor med dvema prijateljema:    Prvi: \"To dekle je pa res čedno. Samo poglej kakšno postavico ima!\"    Drugi: \"Ja, pa inteligentna je tudi! Včeraj sem jo samo pogledal itn je že vedela kaj mislim in mi prisolila klofuto.\"", "Postavna in inteligentna punca" },
                    { 1313, true, 17, "Mladenica se pogovarjata:  Ali imas radi prestavljene  ure kaj problemov?  Pa se koliko.  Prej mi je stal v postelji,   zdaj pa mi na avtobusu.", "Ura" },
                    { 1303, true, 17, "Zdravnik pregleda Anžeta in mu reče: \"Anže, tole pa ne izgleda ničkaj rožnato. Izogibati se boš moral vinu, tobaku in ženskam.\"    \"Vinu in tobaku se lahko odpovem, ženskam pa nikakor ne!\" se brani Anže.    \"Zakaj pa ne?\"    \"Ja, kdo mi bo pa kuhal in pral umazane gate???\"", "Diagnoza pri zdravniku" },
                    { 1206, true, 17, "Zakaj moski ne morejo biti intelegentni?  Zato ker bi potem bili ze zenske!", "Intelegenca" },
                    { 1178, true, 17, "Sin vprasa oceta:  Ocka, kaj ima mami med nogami?  Raj.  Kaj imas pa ti med nogami?  Kljuc do raja.  Mogoce bi bilo dobro, da bi ti ta kljuc zamenjal.   Zakaj?  Ker ima sosed Bine kopijo kljuca!", "Kljuc do raja" },
                    { 1168, true, 17, "Ženska: \"Čez petnajst minut bom pripravljena.\"    Moški:. \"Čez petnajst minut pridem domov.\"", "Ženske in moški" },
                    { 1147, true, 17, "Mož se šele zjutraj vrne domov in žena ga vpraša: \"Kje si spal?\"    \"Pri prijatelju,\" ji odgovori mož.    Žena se odloči, da bo zadevi prišla do dna in pokliče deset njegovih prijateljev. Nazadnje ugotovi, da je pri šestih zares prespal, pri štirih pa tisti hip še vedno spi na kavču.", "Moški o prijateljstvu" },
                    { 1129, true, 17, "Pridejo v Nemciji trije moski  v javno hiso, Nemec, Turk in  Poljak.  In, zakaj so prisli tja?  Nemec, da bi seksal.  Turek, da bi pocistil prostore.  In Poljak? Ta je pa prisel iskat  zeno, da jo po sluzbi pelje  domov.", "Javna hsa" },
                    { 1109, true, 17, "Vprasanje: katera je najtanjsa in najmanjsa knjiga na svetu?  Odgovor: Kaj moski vedo o zenskah.", "Knjiga" },
                    { 1106, true, 17, "Mlad fant se je v trgovini zagledal v prodajalko, ki je nosila zlato verizico, na kateri je bil obesek letala.   Dekle:\"Ste se zaljubili v avioncek?\"  Fant:\" Ne, v letalisce!\"", "Ljubezen na prvi pogled" },
                    { 1098, true, 17, "Vprasa Kosir svojega prijatelja  Janeza:  Zaupaj mi, kako ti vzgajas svoje  otroke. Ali z lepimi besedami  ali z udarci?  Janez: Z lepimi besedami, seveda.  Kosir: Pa udarci?  Uporabim jih le tu in tam, pa se   to izkljucno v samoobrambi.", "Vzgaja otrok" },
                    { 1086, true, 17, "\"A ves, da je Janezova zena padla po stopnicah in ostala brez jezika?\"  \"Vidis, nekateri moski pa res imajo sreco!\"", "Sreca" },
                    { 1025, true, 17, "Zakaj je moski kot snezna nevihta?  Ne ves, kdaj bo prisel, koliko cm bo prinesel in kako dolgo bo trajal.", "Snezna nevihta" },
                    { 1023, true, 17, "Zakaj ima veliko moskih noge na O?  Ker so nepomembne stvari pogosto v oklepajih ", "Noge na O" },
                    { 1022, true, 17, "Kaj rekel Bog, ko je ustvaril moskega?  Znam narediti se kaj boljsega. In naredil je zensko!", "Bog je ustvaril..." },
                    { 1823, true, 15, "\"Kaj delaš tam zadaj, Janezek?\" vpraša učitelj Janezka.    \"Verjetno nič pametnega, kajne?\"    \"Res je. Vas poslušam!\" ", "Med poukom" },
                    { 944, true, 17, "Crnec je na nudisticni plazi  stopil iz vode in okoli njega  se je zbralo mnozica ljudi,ki  so preseneceno opazovali njegov  veliki penis.  On se razjezi:  Kaj pa zijate? Ali ne veste,da  se v mrzli vodi skrci?", "Skrcen" },
                    { 910, true, 17, "Nek moški je iskal pomoč v trgovini in je vprašal prodajalko, kje so tamponi. Ta mu razloži in moški jih gre iskat.     Nakar pride do blagajne s polnim velikim vozičkom vate in zavojem vrvice.     Pa ga prodajalka začudeno gleda in vpraša, če ni našel tamponov.       Pa reče moški: \"Včeraj sem poslal ženo po škatlico cigaret, pa mi je prinesla tobak in papirčke, ker je to VEEELIKO CENEJE. Pa sem si rekel, če moram jaz zvijat svoje, pa naj še ona zvija svoje.", "Po tampone je šel" },
                    { 904, true, 17, "Kaksna je razlika med moskim in E.T.jem?  E.T. Poklice domov.", "Moski in E.T." },
                    { 881, true, 17, "Ko nag moski vstopi v zensko  garderobo,zacnejo zenske vpiti  nanj in ga rinejo ven.  Ko pa naga zenska vstopi v mosko  garderobo,so vsi moski veseli  in gostoljubni.  Kaj govori vse to?  To jasno pokaze vso dobroto  moskega srca", "Dobrota moskega sveta" },
                    { 872, true, 17, "Kaksna je podpbnost med moskim in parketom?  Ce ga na zacetku dobro polozis, lahko se zelo dolgo hodis po njem.", "Moski in parket" },
                    { 849, true, 17, "Franci povabi Ferda na  vecerjo.  Ta se lepo oblece,pride do  Franceljnvih vrat,na njih pa listek:  Ha,ha,ha,Ferdo,sploh me ni doma!  Ferdo je besen,odloci se,da bo  vrnil milo za drago.  Na listek pripise:  Ha,ha,ha,Francelj,sploh me   ni bilo tukaj.", "Povabilo" },
                    { 839, true, 17, "Poklice moski na policijo.  Nujen primer, pridite hitro. Dve punci se tepeta za mene.  Na drugi strani: In kje je tu problem?  Moski: Zmaguje grda.", "Klic v sili" },
                    { 838, true, 17, "Se srecata dva prijatelja in prvi pravi drugemu:  Si pa fejst shujsal!  Ja, sem na locevalni dieti.  Kako pa to zgleda?  Locujem se od zene, kuhat pa ne znam!", "Locevalna dieta" },
                    { 810, true, 17, "Zakaj moski umrejo prej kot zenske?  Ker cas za sankom hitreje tece!", "Sank" },
                    { 790, true, 17, "Lojze in Korel sta udarila  po pivu.  Vmes seveda po mosko  debatirata.  Korel:Kako bi ti,opisal,  kaj so to mesani obcutki?  Pojma nimam.  Mesani obcutki so,  ce se tasca ubije za volanom  tvojega novega beemveja.", "Tasca" },
                    { 701, true, 17, "Londonski klubocar je v izlozbi  rastavil klobuk z napisom:  Nasi klobuki so najboljsi na  svetu.Nosil jih je celo Charli  Chaplin.  Ponoci je njegov konkurent  na steklo pripisal:  In zato se mu smeje ves svet.", "SMEH" },
                    { 687, true, 17, "Ko je Bog ustvaril Adama in Evo, jima je želel pokloniti dva darova.  \"Dva darova bi vama poklonil; prvi dar je lulanje stoje...\"    Adam ga je takoj prekinil: \"Jaz bi to imel, bilo bi čudovito! Življenje bi bilo enostavnejše in zabavnejše!\"    Bog se je ozrl k Evi, ki je Adamovo željo podprla: \"Da, oče. Osreči Adama. Meni to ni tako zelo pomembno...\"    Tako je Bog prvi dar podaril moškemu, ki je jel od samega veselja skakati in lulati na vse strani. Razmočil je vsa drevesa in nato stekel do obale, koder se je bil znova polulal in občudoval vzorec, ki ga je uspel zarisati v peščena tla na obali.    Bog in Eva sta opazovala njegovo neizmerno veselje.    Navsezadnje pa je Eva le vprašala Boga:\"Katero je drugo darilo, oče?\"    Bog: \"Možgani, Eva... Možgani!!!\"", "Kako to, da moški lulajo stoje" },
                    { 681, true, 17, "Mož vstopi v kopalnico, ker želi oprati v pralnem stroju oprati majico.    Gleda gumbe, a po dveh minutah razmišljanja nima pojma kako.    Mož: \"Kateri program je potrebno vklopiti za pranje majice?\"    Žena: \"Ali je majica bombažna ali sintetična?\"    Mož: \"Ne vem!\"    Žena (znervirano): \"Kaj piše na majici?!\"    Mož: \"Laško je zakon!\"", "Miški in pralni stroj" },
                    { 632, true, 17, "Alpinista plezata v visoki gori in  nenadoma se prvi znajde v težavah  in vzklikne:  O moj bog.  Spodnji pa se zadere:  Ali sva že tako visoko?", "Visoko v gorah" },
                    { 473, true, 17, "Moški so, kot parket.    Če ga dobro položiš, lahko 30 let hodiš po njem.", "Parket" },
                    { 931, true, 17, "Dva moska se srecata na zabavi in obcudujeta mlada dekleta.   Prvi pravi drugemu: Super zabava, poglej koliko svezega mesa je.  Drugi: Ja, res, toda jaz imam na zalost s seboj svojo konzervo!", "Na zabavi" },
                    { 2069, true, 48, "Odvetnik svoji stranki: \"Imam dobro in slabo novico.\"    \"Kakšna je slaba,\" vpraša stranka.    \"Vaša kri ustreza DNA vzorcu, ki so ga našli na prizorišču umora,\" je zaskrbljen odvetnik.    \"Hudiča! Kakšna pa je dobra novica,\" vpraša stranka.    \"Vaš holesterol je končno v mejah normale.\"", "Dobra in slaba novica" },
                    { 1808, true, 15, "Učiteljica:\"Ja Janezek, zakaj si pa prinesel muco v šolo?\" Janezek:\"Sem zjutraj slišal očeta kako je mamici reku, da takoj ko gre mali v šolo, da ji bo pojedu muco!\"", "Muca" },
                    { 1752, true, 15, "Janezek vpraša očeta: \"Kakšna je razlika med grehom in sramoto?\"    Oče: \"Greh je, če jaz spim z drugo žensko, sramota pa je, če izpustim tako priložnost.\"", "Greh in sramota" },
                    { 644, true, 15, "\"Zakaj si pa tako pozno prišel iz šole?\" je Janezka vprašal oče.     Janezek: \"Moral sem ostati po pouku v razredu, ker nisem vedel, kje so Azori!\"    Oče: \"Potem pa drugič bolj pazi na svoje stvari!\"", "Ni vedel" },
                    { 628, true, 15, "\"Sram naj te bo, Janezek!\" se jezi učitelj.    \"Ko sem bi v tvojih letih, nisem nikoli lagal!\"    \"Kdaj pa ste začeli?\" je radoveden Janezek.", "Ni lagal" },
                    { 627, true, 15, "\"Učiteljica, jaz sem včeraj pojedel deset kilogramov hrušk!\" se je pohvalil Janezek.    \"No, to pa ne bo res!\" je rekla učiteljica. \"Verjetno jih je bilo nekoliko manj!\"    \"Ne, ne, res jih je bilo deset kilogramov, toda bile so zelo drobne!\"", "Jedel je hruške" },
                    { 626, true, 15, "Učiteljica je učencem hotela razložiti, kako na svet pridejo otroci.    Janezek neučakano: \"Tršica, kaj mi, ko že fukamo lahko gremo ven na en cigaret?\"", "Spolna vzgoja" },
                    { 625, true, 15, "\"Ali je pošteno, da je nekdo kaznovan za nekaj, česar ni storil?\" vpraša Janezek učiteljico.    \"Ne, to pa ne! To ne bi bilo pošteno!\"    \"Dobro, domače naloge nisem napisal,\" reče Janezek olajšano.", "Nič ni storil" },
                    { 624, true, 15, "\"Kako to, da na roditeljskih sestankih še nisem videla tvoje mame? Sploh ne vem, kako izgleda!\" vpraša učiteljica Janezka.    \"Prinesel vam bom sliko,\" je odgovoril Janezek.  ", "Ne ve, kako izgleda" },
                    { 623, true, 15, "V šoli so govorili o rimah.    Učiteljica je vprašala, če kdo ve kakšno rimo.    Janezek dvigne roko in pove rimo: \"Po morju plava kit, iz vode kaže rit.\"    Učiteljica ga poduči: \"Janezek, ne govorit tako grdo. Lahko bi rekel: po morju plava kit iz vode kaže R, pa bi vseeno vedeli, zakaj se gre.\"    Učiteljica: \"No, otroci, še kdo ve kakžno rimo?\"    Janezek: \"Se peljem mimo Bleda, iz hlač mi kurac G.\"", "Nespodobne besede" },
                    { 588, true, 15, "\"Janezek zakaj si direktorju povedal napačno ime, ko te je zalotil pijanega na delovnem mestu?\"  \"Veš, ko sem pijan, niti samega sebe ne prepoznam ...\"", "Janezek pijan" },
                    { 581, true, 15, "Učiteljica vpraša Janezka: \"Janezek, kakšnega spola je veter ?\"  \"Moškega.\"  \"Pravilno. In zakaj ?\"  Janezek odgovori: \"Zato, ker ženskam krila dviguje.\"", "Janezek v šoli" },
                    { 508, true, 15, "Janezek sedi ob cesti in meša drek. Mimo pride župan in pravi:   \"Kaj pa delaš Janezek?\"   Janezek reče:   \"Župana\".   Seveda ga župan premlati.   Ista zgodba se ponovi z župnikom. Omenjena gospoda se nato posvetujeta s policajem, ki gre osebno v akcijo in zaloti Janezka, ko ob cesti še vedno meša drek. Pa ga policaj vpraša:   \"Kaj je Janezek? A policaja delaš?\"   Janezek:\"Ne, premau dreka!\"", "Mešanje dreka" },
                    { 504, true, 15, "Janezek: “Kateri šport je najbolj varen?”  Ata: “Šah.”  Janezek: “In kaj je najhujša poškodba pri šahu?”  Ata: “Izpah čeljusti zaradi zehanja.”", "Varen šport" },
                    { 462, true, 15, "Janezek je v šoli še vedno sešteval na prste. Učiteljica zahteva zdaj od njega, da s tem preneha in računa na pamet. In ga preveri.    \"No Janezek. Koliko je 2 plus 2?\"    Janezek takoj začne šteti prste: \"Štiri!\"    \"Janezek, rekla sva brez prstov. Roke za hrbet in poskusi znova. Koliko je 4 plus 4?\"    Janezek da roke za hrbet, a še vedno šteje s prsti:\"Osem!\"    \"Spet si štel s prsti. Tokrat roke v žepe. Koliko je 5 plus 5?\"    Janezek malce okleva:\"Enajst!\"", "Sešteva na prste" },
                    { 457, true, 15, "Janezek: \"Mami mami, cukr mi je padu.\"    Mami: \"Pejd, pa pojej čokolado.\"    Janezek: \"Mami noooo, cukr.\"    Mami: \"Ja, pa pojej to čokolado !!!!\"     Po eni uri pride mami v kuhinjo in se dere: \"Madonca, kdo je stresu ceu cukr po tleh ??\"    Janezek: \"Ja pa sej sem ti reku, da mi je cukr padu, pa si rekla, da naj pojem čokolado.\"", "Padel mu je cuker" },
                    { 455, true, 15, "Eden tistih profesorjev matematike, ki radi izjavljajo: Le Bog zna za 5, jaz znam za 4, vi pa v najboljšem primeru lahko dobite 3.... se je odločil presenetiti svoje učence z nalogo, ki gre takole:    Predstavljajte si, da ste skupaj s še 25 timi potniki v avtobusu, ki vozi s hitrostjo 60 km/h v smeri jugozahoda, temperatura je +20 stopinj C, ob cesti teče potok v katerem je voda s temperaturo +14 stopinj C, šoferju manjkata dva sprednja zoba. Sobota je...  Koliko let imam?    V razredu zavlada tišina. Profesor se zmagoslavno reži.  Janezek dvigne dva prsta, profesor pa cinično: No, Janezek?    \"Stari ste 44 let!\"    Učitelj presenečeno: \"Bravo! Kako si pa prišel do tega?\"    Janezek: \"Enostavno: Pri nas imamo soseda Mihca, ki mu je 22 let, in zanj trdijo, da je na pol idiot.\"", "Težko vprašanje" },
                    { 401, true, 15, "\"Če možgani nehajo delati, a človek potem umre?\" vpraša Janezek.   \"Saj si še živ, a ne?\" naglo odgovori učiteljica. ", "Možgani" },
                    { 400, true, 15, "\"Zakaj ima naš Janezek pri matematiki cvek?\" vpraša mama učiteljico.   \"Zato,\" odgovori učiteljica \"ker nižjih ocen nimamo.\" ", "Ocene" },
                    { 380, true, 15, "V šoli se učijo o naših prednikih. Učitelj vneto razlaga, da smo nastali iz Adama in Eve.  Janezek pa dvigne roko in pojasni: “Moj oče je rekel, da smo nastali iz opic.”  Učitelj pa: “Vaša družinska zgodovina me ne zanima…”", "Družinska zgodovina" },
                    { 379, true, 15, "Janezek vpraša župnika:  “Gospod župnik, kakšna je razlika med mamo in atom?”  “To je pa težko razložiti,” odgovori župnik.  Janezek še vedno vztraja, zato župnik popusti:  “Dobro. Kakšno številko čevljev nosi tvoja mama?”  “38.”  “Kaj pa ata?”  “43.”  “No vidiš, Janezek, med nogami je razlika.”", "Razlike staršev" },
                    { 376, true, 15, "Učiteljica v šoli vpraša Janezka:  “Katere živali so že izumrle?”  Janezek se ne more spomniti.  “Mamuti, mamuti” mu šepeta sošolec za njim.  Janezek se razjezi, obrne in reče: “A ja tebi sestru!", "Izumrle živali" },
                    { 370, true, 15, "Janezek zadnji dan pouka prinese iz šole domov odlično spričevalo.    Janezek: \"Mami, za tako lepo spričevalo mi morata kupiti kolo!\"    Mamica: \"Janezek, spričevalo je res lepo, toda kolo.... Ne vem, če bo očka za to. Vprašala ga bova, ko se vrne iz službe.\"    Janezek: \"Mami, če mi ne kupiš kolesa se pa hočem zvečer igrati s teboj mamico in očka! Sama izberi, kaj ti je ljubše.\"    Ko se je Janezkov oče vrnil domov, mu je žena povedala za otrokov ultimat. Oče nekaj časa premišljuje, potem pa reče: \"Veš kaj, kolo stane 400€. Ceneje bo, če se gresta zvečer igrat očka in mamico, pa bova prihranila denar.\"    Zvečer se je Janezek odpravil v spalnico, oče pa si je pripravil ležišče v dnevni sobi na kavču.    Janezek se vleže vznak na posteljo, obe roki namesti pod glavo, nekaj časa gleda v strop, nato pa zavpije: \"Stara, jutri bova mulcu kupila kolo!\" ", "Janezek in njegovo spričevalo" },
                    { 341, true, 15, "Janezek pride domov in reče: \"Mama imam dobro in slabo novico.   Dobra je ta da sem pri matematiki dobil pet, slaba pa ta da sem se zlagal\".", "Dobra in slaba novica" },
                    { 337, true, 15, "Janezek pri spolni vzoji dobi nezadostno oceno.pa rece sosolcu Mihu. Ko bo uciteljica sla domov,bos ji dvignu krilo,jaz pa jo bom tako po jajcih vdaro,da si bo zapomnila za vse case!!!", "Učiteljica in jajca" },
                    { 335, true, 15, "Mama se dere na Janeza: ”kako si lahko dobil spet 1 ?!!!”; jure pa mami: ”preprosto. učiteljica je spet spraševala.”", "Enka" },
                    { 327, true, 15, "Je prišel Janezek v šolo. Pa ga je učiteljica vprašala:kje ima mamo pa ji je odgovoril:traktor jo je povozil.Kje imaš očeta traktor ga je povozil.Kje pa si bil takrat ti?Traktor sem vozil.", "Traktor" },
                    { 316, true, 15, "Janezek vpraša očeta: \"Ati, zakaj si se ti poročil z mamo?\"    Oče jezno vstane in reče: \"Vidiš žena, še njemu ni jasno zakaj.\"", "Zakaj sta se poročila?" },
                    { 304, true, 15, "Janezek je nekega dne napravil luknjo skozi steno v sosedovo stanovanje.    Sosed strogo: \"Janezek, si znorel!?! Kaj pa to pomeni?\"    Janezek: \"Če moram vsako noč poslušati vašo televizijo, mislim, da imam pravico tudi do tega, da jo gledam.\"", "Janezek razbije steno" },
                    { 281, true, 15, "Gre Janez po mestu in mu nasproti pride ena dobra bejba.  Pa gleda in si misli.  \"Da bi moja imela take noge.\"  Potem ga ena dobra bejba prehiti in:  \"Da bi moja imela tako dobro tazadnjo.\"  Pride zopet ena dobra bejba nasproti, dekolte:  \"Da bi moja imela take prsi.\"  Na avtobusu ena dobra bejba in:  \"Da bi moja imela take dobre ustnice...\"  No in pride domov pa pravi ženi:  \"Veš, sem celo pot mislil nate!\"", "Dobra bejba!" },
                    { 259, true, 15, "Janezek: \"Ata, kaj, če bi midva prodala mamo?\"    Oče: \"Janezek, kaj si nor? Zakaj?\"    Janezek: \"Poglej:  - kuhat ne zna,  - jaz ne sesam več,  - ti fukaš tudi ne!  Torej, zakaj bi jo redila za soseda?\"", "Janazek bi prodal mamo" },
                    { 248, true, 15, "Janezek, zakaj imaš pa povezano oko?    Janezek: \"Soseda me je vanj sunila s pletilko!\"    \"Ponesreči?\"    Janezek: \"Ne, skozi ključavnico.\" ", "Janezek in poškodovano oko" },
                    { 654, true, 15, "\"Janezek, zakaj skačeš po učilnici!?\" jezno kriči učiteljica.    \"Učitelca, pa saj ste rekli včeraj …\"    \"Kaj sem rekla?\"    Janezek: \"Da, če se dovolj potrudim, lahko preskočim razred!\"", "Skače po razredu" },
                    { 658, true, 15, "Janezek se vrne iz kopališča in pravi očetu: \"Nobena punca se noče pogovarjati z mano!\"    Oče: \"Jutri vzami krompir in ga daj v kopalke, boš videl, da se bodo kar lepile nate!\"    Ko se Janezek drugi dan vrne, pravi: \"Danes je bilo še slabše, kar bežale so pred mano!\"    Oče ga pogleda: \"Seveda, sine, krompir je treba dati spredaj!\"", "Težave s puncami" },
                    { 665, true, 15, "Učitelj: \"Voda ima veliko moč. Kdo lahko navede primere?\"    Janezek: \"Če moja mama joka, lahko dobi od očeta kar hoče.\"", "Moč vode" }
                });

            migrationBuilder.InsertData(
                table: "Jokes",
                columns: new[] { "Id", "Active", "CategoryId", "Description", "Title" },
                values: new object[,]
                {
                    { 670, true, 15, "Reče Janezek učiteljici: \"Jaz bom prvi človek ki bo pristal na Soncu\".    Učiteljica mu odvrne: \"Kako!? To ja vendar ni mogoče te bo ja zažgalo.\"    Janezek: \"Jaz bom pristal ponoči.\"", "Pot v vesolje" },
                    { 1744, true, 15, "Učiteljica vpraša učence: \"Katera žival daje jajca?\"    \"Gos!\" se oglasi Metka.    \"V principu res, toda jaz sem mislila na kokoš,\" je rekla učiteljica.    \"No, in katera žival daje mleko?\"    \"Koza!\" se oglasi Mateja.    \"V principu res, toda jaz sem mislila na kravo!\"    Nenadoma se oglasi Janezek: \"Učiteljica, tudi jaz znam eno uganko. Ko ga daš noter je trd, ko ga vzameš ven pa je mehek. Kaj je to?\"    Učiteljica zardi in obstane kot vkopana. \"Ampak, Janezek....!\"    \"V principu res,\" odgovori Janezek,\" toda jaz sem mislil na žvečilni gumi!\" ", "Uganke" },
                    { 1698, true, 15, "Nekega dne je uciteljica v razredu  govorila o poroki.  Janezek, kaksno zeno bi rad imel?  Rad bi imel tako, kot je luna.  Oh, kaksna izbira...Ali bi rad, da  je lepa kot luna?  Ne. Rad bi, da bi prisla zvecer in  izginila zjutraj.", "Luna" },
                    { 1677, true, 15, "Učiteljica biologije vpraša Janezka: \"Ali mi znaš povedati vsaj en primerek sesalca, ki je brez zob?\"    \"Seveda! To je moj dedek.\"", "Janezka zopet sprašujejo" },
                    { 1640, true, 15, "Ata gleda prenos finalne nogometne tekme, ko skoči v sobo Janezek in se dere: \"Ati, mamo je na cesti povozil kamion, pridi hitro, jooooj....!\"    Ata pravi: \"Janezek, pojdi ven in začni jokati, jaz pridem kmalu!\"", "Nesreča med nogometno tekmo" },
                    { 1633, true, 15, "Janezek teče po hodniku, vrata dvigala se počasi zapirajo.    Ženska stisne gumb in vpraša: \"Ali greste z nami?\"    \"Ah, ne … zalet za stopnice jemljem!\"", "Zalet" },
                    { 1574, true, 15, "Pride mama z Janezkom k dotorju in pravi: \"Doktor pomagajte. Sin že cel teden ne more WC.\"    Pravi doktor: \"Naj sedi pred televizorjem in gleda sejo vlade ali parlamenta, sigurno ga bo pognalo.\"    Čez dve uri mama kliče doktorja. \"Gospod doktor, Janezek je posral celo stanovanje. Kaj naj storim?\"    Doktor: \"Kaj pa gleda?\"    Mama: \"Predsednika vlade.\"    Doktor: \"Ma neeeeee, on je doza za odrasle.\"", "Janezek je zaprt" },
                    { 1544, true, 15, "Janezek: \"Ata, kaj je to strup za miši?\"    Oče: \"Joj, kako bi ti to razložil? Sine, to je mačka v prahu.\"", "Razlaga" },
                    { 1543, true, 15, "Janezek gre peš čez carino in ima na prtljažniku kolesa privezano veliko vrečo.    Carinik ga vpraša: \"Kaj imaš v vreči?\"    Janezek: \"Pesek!\"    Cariniku je bilo sumljivo, zato je vsebino vreče pregledal. Ugotovil je, da je v vreči res samo pesek.  \"Lahko greš!\", mu reče.    Drugi dan Janezek zopet pride čez carino z istim tovorom.    Carinik: \"Kaj imaš v vreči?\"    Janezek: \"Pesek!\"    Carinik zopet pregleda vsebino in res je bil v vreči samo pesek.    Tretji dan Janezek zopet pride na carino in vozi isti tovor.    Carinik: \"Pa dobro, kaj hudiča ti švercaš?\"    Janezek: \"Kolesa.\"", "Janezek na carini" },
                    { 1542, true, 15, "Janezek: \"Mami, a bomo danes, ko obiščemo živalski vrt, videli tudi štorkljo?\"    Mama: \"Da, Janezek.\"    Janezek: \"Čudovito, prav zanima me, če me bo prepoznala.\"", "Obisk živalskega vrta" },
                    { 1450, true, 15, "V soli uciteljica vprasa Janezeka: Janezek, zakaj si manjkal v soli?  Janezek: mama mi je prala gate in nisem moral v solo.  Ja, zakaj pa si manjkal dva dni?  Vceraj sem mislil iti v solo, pa sem sel mimo vase hise in videl viseti vase gate pa sem pomislil, da pouk odpade.", "Spodnje perilo" },
                    { 1444, true, 15, "Poredni Janezek vprasa mamo.  Mami, kaj si ti najbolj zelis za rojstni dan?  Rada bi pridnega otroka.  No, potem bos pa mogla pocakati, da se oci vrne iz Nemcije!", "Rojstni dan" },
                    { 1341, true, 15, "Janezek vidi očeta piti laško pivo in ga vpraša, če lahko tudi on dobi en požirek.    Oče ga pa vpraša: \"Sine, a se ti lahko z lulčkom dotakneš ritke?\"    Janezek poskusi in pravi da ne gre.    \"No, potem si pa še premajhen,\" mu reče oče.    Po dveh tednih je Janezek dobil na lotu sedmico in oče ga zaprosi, če odstopi tudi njemu kakšen milijonček, da bo zamenjal avto.    Janezek pa ga vpraša: \"Oči, a se ti lahko z lulčkom dotakneš ritke?\"    \"Seveda se lahko\" mu ponosno odvrne oče.    \"No, potem se pa jebi!\" ", "Hitro se mu je maščevalo" },
                    { 1327, true, 15, "8-letni Janezek pride v javno hišo: \"Takoj zdele hočem kurbo z AIDSom, denar ni problem!\"    Prostitutke planejo v smeh, nakar pristopi glavna in ga poskuša pregovoriti, češ, premlad si za take zadeve, pojdi raje na igrišče brcat žogo.    Janezek je seveda vztrajen, denar ni problem, zato teži toliko časa, da res dobi okuženo kurbo.    Gresta v sobo in opravita svoje.    Po končanem opravilu pride najstarejša do njega in ga pobara: \"Poglej, toliko lepih in zdravih deklet je tu, zakaj si zahteval ravno okuženo?\"    Janezek mirno razloži \"No, takole je: danes zvečer sta me starša pustila samega z mojo varuško. Varuška je pedofilka in bo hotela seksati z menoj, ko bom prišel domov. Tako bo dobila AIDS.  Ko se bosta starša vrnila, bo oče varuško odpeljal domov, nakar bosta seksala. Tako bo še on dobil AIDS.  Ko se bo vrnil domov, bo seksal z mamo, ki se bo tako okužila z AIDSom.  Zjutraj bo šel oče v službo in takrat bo prišel poštar. Seveda bo seksal z mojo mamo...    No, on je tisti prasec, ki je zjutraj, s svojim kolesom, povozil mojo žabo!\" ", "Janezek in posebne zahteve v bordelu" },
                    { 1273, true, 15, "Janezek je dobil stanovanje v 3. nadstropju, a ni bil prav nič zadovoljen.    \"Kaj ti ni všeč?\" so ga vprašali.    \"Dvigalo je nerodno. V njem piše SAMO ZA 4 OSEBE.\"    \"In kaj potem?\"    \"Veliko časa traja, da zjutraj zbudim še 3 sosede in jih prepričam, da se skupaj odpeljemo.\"", "Novo stanovanje v bloku" },
                    { 1804, true, 15, "Dva pubertetnika se zabavata pred stanovanjskim blokom, ko je mimo njiju prišla ženska,  ki je bila na pogled bolj podobna moškemu.   Eden od pubertetnikov se je oglasil:  \"Poglej jo! Kakšna omara!\"  Ženska je pristopila k njemu in mu dala močno zaušnico, on pa je vprašal:  \"Kaj pa zdaj to pomeni?\"  \"Vrata od omare so se odprla!\" mu je odgovorila ženska.", "Omara" },
                    { 1265, true, 15, "\"Janezek, ali še imaš dedka in babico?\"  \"Ne, umrla sta od seksa.\"  \"Kako pa je to mogoče?\"  \"Babica se je zjebala po stopnicah.\"  \"Kaj pa deda?\"  \"Deda pa je nekaj drkal okrog elektrike.\"", "Izgubil je stare starše" },
                    { 1203, true, 15, "Uciteljica sprasuje ucence: Povejte kaksno bolezen!  Janezek: Driska.  Uciteljica: Dobro Janezek. Pa ves zakaj je driska bolezen?  Janez: Ja, vceraj sem slisal iz spalnice, ko je mama rekla ateju: bo ta tvoj drek ze koncno postal trd!", "Bolezni" },
                    { 1176, true, 15, "Kako to, da ne ves kaj je internet? sprasuje Janezek dedka.   Dedek mu odgovarja: Ko bos v mojih letih, ti tudi ne bos vedel kaj je to penzija.", "Internet" },
                    { 1157, true, 15, "Janezek, vceraj si zopet manjkal v soli? Kaj se dogaja?  Babica je zbolela.  Vsakic, ko manjkas v soli, je tvoja babica bolna. Ne verjamem ti!  Veste, uciteljica, tudi mi doma smo zaceli sumiti, da babica le igra.", "Izostanek od pouka" },
                    { 1148, true, 15, "Učitelj: \"Če ti dam dva zajca in še dva zajca in potem še dva zajca, koliko zajcev imaš?\"  Janezek: \"Sedem!\"  Učitelj: \"Ne, poslušaj pazljivo še enkrat. Če ti dam dva zajca in še dva zajca in potem še dva zajca, koliko zajcev imaš?\"  Janezek: \"Sedem!\"  Učitelj: \"Poskusiva malo drugače. Če ti dam dve jabolki in še dve jabolki in potem še dve jabolki, koliko jabolk imaš?\"  Janezek: \" Šest!\"  Učitelj: \"Dobro. No, zdaj pa še enkrat z zajci. Če ti dam dva zajca in še dva zajca in nato še dva zajca, koliko zajcev imaš potem?\"  Janezek: \"Sedem!\"  Učitelj: \"Kako, za boga, lahko po tem, ko ti trikrat dam po dva zajca, prideš do sedmih?\"  Janezek: \"Enega imam doma.\"", "Računstvo z zajci" },
                    { 1146, true, 15, "Učiteljica sprašuje otroke, kaj pomeni beseda \"očitno\".    Javi se mali Marko: \"Moj oče vozi Mercedesa, mama vozi Jaguarja, babica pa džipa - očitno imamo denar.\"    Učiteljica pohvali Marka in vpraša, če še kdo hoče kaj povedati.    Janezek se javi: \"Moja babica vsako jutro odide na travnik. Pod levo roko nosi Allgemeine Zeitung, pod desno pa Washington Post.\"    \"Ja, in ... kaj je s tem,\" je nestrpna učiteljica?    \"Ja, nič,\" odvrne Janezek. \"Babica ne zna ne nemško ne angleško - očitno gre srat.\"", "Učiteljica, Janezek in očitno" },
                    { 1116, true, 15, "Uciteljica v soli vprasa, katera streha je najvecja na svetu. Vsi ucenci molcijo le Janezek dvigne roko: kombineza, ker pokriva dve mlekarni in nocno zabavisce.", "Streha" },
                    { 1114, true, 15, "\"Zakaj je sel Kristof Kolumb odkrivat Ameriko z ladjo?\" vprasa uciteljica Janezka.  Janezek: \"Ker se mu ni dalo cakati se vsaj pol tisocletja, da bi lahko sel z letalom.\"", "Kolumb" },
                    { 990, true, 15, "Janezek vprasa oceta: Ati, koliko tehta moj lulek?  Oce: Kaksnih 5 dkg.  Janezek: Koliko pa tehta tvoj?  Oce: Ja, glede na to, da sem jaz ze starejsi pa moj tehta kaksnih 15 dkg.  Janezek: Potem pa mora biti od dedija zelo tezek, glede na to, da ga babica niti dvigniti ne more!", "Teza" },
                    { 977, true, 15, "Janezek je prišel iz šole in povedal, da so imeli prvo uro spolne vzgoje.  \"In kako je bilo?\" se je pozanimal oče.  \"Najprej je prišel župnik in nam razložil, zakaj tega ne smemo delati.  Nato je prišel zdravnik in povedal, kako tega ne smemo delati.  Za njim pa je v razred prišel še ravnatelj in povedal, kje tega ne smemo delati!\"", "Spolna vzgoja" },
                    { 915, true, 15, "\"Janezek, ti pa preveč klepetaš.\"     \"To je pri nas družinska tradicija.\"     \"Kako to misliš?\"     \"Dedek je bil učitelj, ata je pa pevec.\"     \"Kaj pa mama?\"    \"Ona je pa itak baba.\"", "Klepetanje" },
                    { 786, true, 15, "Pravi Janezek ateju: \" Ata, jaz vec ne zizam, ti  vec ne seksas. Kaj, ce bi midva prodala mamo?\"", "Janezek in ata" },
                    { 766, true, 15, "Učiteljica vpraša Janezka: \"Zakaj je materino mleko za dojenčka boljše od kravjega mleka?\"    Janezek: \"Ker je vedno pravilno segreto, ne more se skisati, ker ga ni potrebno iti iskat v trgovino, pa še v lepi embalaži je.\"", "Matrino mleko" },
                    { 706, true, 15, "Gre Janezek na roditeljski sestanek in s sabo pripelje dedka.Učiteljica mu reče: Zakaj si s sabo pripeljal dedka?  Edino on slabo sliši in hitro pozabi!!!", "Roditeljski sestanek" },
                    { 694, true, 15, "Janezek: »Janezek moj, kako si kaj?« »Slabo, zelo slabo, očka sem postal.« »To je vendar lepo. Čestitam. In kako je kaj Marta?« »V redu, še ni izvedela.«", "Janezek postane atek" },
                    { 1235, true, 15, "Janezek je ostal pokonci do pozne ure. Tako dolgo, da so na TVju so začeli oddajati program za odrasle.    Janezek z zanimanjem opazuje, ko se glavna akterja začneta slačiti.    Mama v zadregi: \"Janezek, hitro spat! Vidiš, da se stric in teta tudi odpravljata v posteljo.\"", "Janezek pokonci do pozne ure" },
                    { 2092, true, 48, "Na sojenju morilcu branilec zaslišuje patologa.    \"Ali ste, preden ste podpisali mrliški list, preverili, ali umrli morda ne diha in ali morda nima srčnega utripa?\" \"Ne.\"    \"Torej ne morete z gotovostjo trditi, da je bil mrtev, ko ste podpisali mrliški list, kajne?\"    \"No, njegovi možgani so bili v kozarcu na moji mizi, ampak, ja, očitno bi bil najbrž še res sposoben delati kot odvetnik!\"", "Treba bi se bilo prepričati" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1897);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1899);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1911);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1912);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1913);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1914);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1915);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1916);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1917);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1918);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1919);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1920);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1921);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1922);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1923);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1924);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1926);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1928);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1931);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1932);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1933);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1934);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1935);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1936);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1937);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1938);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1939);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1940);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1941);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1942);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1943);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1944);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1945);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1946);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1948);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1949);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1950);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1952);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1953);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1956);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1957);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1958);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1959);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1961);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1962);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1963);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1964);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1965);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1969);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1970);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1971);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1972);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1973);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1975);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1976);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1977);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1978);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1979);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1980);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1981);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1982);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1983);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1984);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1985);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1986);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1987);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1988);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1989);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1990);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1991);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1994);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1995);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1996);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1998);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 1999);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2075);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2088);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2115);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2116);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2119);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2121);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2123);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2124);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2125);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2127);

            migrationBuilder.DeleteData(
                table: "Jokes",
                keyColumn: "Id",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48);
        }
    }
}
