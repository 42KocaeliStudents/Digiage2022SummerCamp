# Thundercalypse Game Documentation

## İçerik
1. [Proje Hakkında](#proje-hakkında)
	- [Vizyon](#vizyon)
	- [Kapsam](#kapsam)
	- [Proje Hedefi](#projenin-hedefi)
	- [Konsept](#konsept)
	- [Hikaye](#hikaye)
	- [Pazar Araştırması ve Hedef Kitle](#pazar-araştırması-ve-hedef-kitle)
	- [Ekip](#takım-rolleri)
2. [Teknik Tasarım Detayları](#teknik-tasarım-detayları)
	- [Teknik Yapı](#teknik-yapı)
		- [Teknik Donanım](#teknik-donanım)
		- [Teknik Yazılım](#teknik-yazılım)
		- [Yapay Zeka](#yapay-zeka)
	- [Grafik ve Animasyon](#grafik-ve-animasyon)
3. [Haraket Mekanikleri](#haraket-mekanikleri)
	- [Keyboard](#keyboard)
	- [Controller](#controller)
1. [Core Game](#2-core-loop)
1. [Hayatta Kalma](#hayatta-kalma)
2. [Savaş Sistemi](#4-savaş-sistemi-combat-systems)
	- [Düşman Çeşitleri](#düşman-çeşitleri-enemy-styles)
		- [Askerler](#askerler)
		- [Böcek](#böcekler)
		- [Enerji formu](#enerji-formları)
	- [Savaş Mekanikleri](#savaş-mekanikleri-combat-mechanics)
		- [Saldırı](#1-saldırı)
		- [Savunma](#2-savunma)
		- [Kaçınma](#3-kaçınma)
	- [Silahlar](#silahlar)
		- [Silah Levelleri](#silah-levelleri)
		- [Kılıç](#kılıç)
		- [Mızrak](#mızrak)
		- [Kalkan](#kalkan)
		- [Yay](#yay)
3. [Yetenek Ağacı](#skill-three)
4. [kesin unuttuğum birşey vardır aq _(Yakında..)_ ]()

## Proje Hakkında
 * ### Vizyon :
	Vizyon olarak günümüzdeki fabrikaların bacalarından çıkan gazların yeteri kadar kontrol edilmediğini ve böyle giderse gelecekte bizi nasıl bir dünya olabileceğini düşündük ve bunu oyuncuya hissettirmek istedik. Post-Apocalpystic(Kıyamet sonrası) bir dünya atmosferi inanılmaz dengesiz durumda ve heryere yıldırımlar, düşmekte şimşekler çakmakta.
 * ### Kapsam :
	Vizyonun görünüşüne göre, oyunun kapsamı büyüktür. Demo için hazırladığımız bölümler oyunun sadece başlangıcını barındırmakta ve projenin ilerleyen süreçlerinde çeşitlenerek gelişecektir. Aynı şekilde Düşmanlar, Silahlar, ve silah seviyeleri yine demoya uygun şekilde oyunun sadece belirli bir kısmını barındırmaktadır. Bu döküman sadece demo için hazırlandığından dolayı kafamızdaki planın yanında küçük bir projeymiş gibi gözükebilir.
 * ### Projenin Hedefi :
	Ekibimiz ile beraber bize verilen etkinlik süreci(10 gün) içerisinde tasarladığımız oyunun oynanabilir bir demosunu çıkartıp bu demoyu yayıncılara sunmak.
### Konsept
 *  **Başlık :** Oyun sahasında belirtildiği gibi oyunun adı “Thundercalypse” dir. Bu, “Yıldırım ve Şimşekler” olan oyunun gerekli temasını takip eder.
 *  **Oynanış Kancası :** Ana karakterimiz Dış dünyayı keşfeder, Ayarında zorluğu ile düşmanlarla savaşır. Oyunun sonuna kadar devam eden dünyayı yaşanmaz hale getiren şirketlere bunun bedelini ödetme arzusunu da devam ettirecektir.
 *  **Tür :** Platform, Macera, Aksiyon.
 *  **Tema :** Yıldırımlar ve şimşekler.
 *  **Platform :** _(Demo için sadece)_ PC
### Hikaye:
&nbsp; &nbsp; Sene 2242, önü kesilemeyen fabrikalaşma ve sanayileşmenin denetimsiz kalması yüzünden atmosfer çoğu canlı için yaşanılmaz hale geldi. Yeryüzünde yaşayan canlıların neredeyse hepsi öldü hayatta kalanlar ise mutasyona uğradı, Atmosferdeki kirlilik yüzünden kontrolsüz şekilde şimşekler çakmakta ve yıldırımlar düşmekte. İnsanlık bu atmosferden sığınmak için yer altına çekildi ve yer altında sığınaklar kurarak yaşamaya başladı, tabiki bu sığınakları yeryüzünün bu hale gelmesine sebeb olan şirketler yönetiyor. Kahramanımız bir iftira sonucu yargısız infaza mağruz kalıyor ve sığınaklardan yeryüzüne sürgün ediliyor. Büyüleyici şekilde atmosferin kendisine zarar vermediğini gören kahramanımız bu düzene dur demek için ant içiyor ve şirketlere karşı savaşmaya başlıyor.
### Pazar Araştırması ve Hedef Kitle
&nbsp; &nbsp;Oyun sahasına göre bu oyun için belirlediğimiz ana kitle 16-25. Bunun nedeni 16-25 yaşındaki çoğu kişinin oyunlara daha eleştirel yaklaşması. Bu sebeble onların isteklerine uygun bir yapı kurduk. Ayrıca Uluslararası alanda 13 yaş ve üzerinde olan herkes oyunumuzu oynayabilir.
### Takım Rolleri
|İsim | Rol|
|:-|-:|
|Ömer Faruk TOPLUOĞLU| Project Manager|
|Ahmet ERYILMAZ| Game Manager / Level Designer|
|Onur DEMİREL| 3D Desingner|
|Yunus Emre AKTAŞ| 3D Desingner|
|Alper DEMİRÇİ| Sound Desinger|
|Erdoğan ÇAYIR| Animation Designer|
|Muhammet Batuhan FİLİZ| Animation Designer|
|Ahmet ÖZSAYAR| Unity Developer|
|Enes ÖZMERT| Unity Developer|
|Rafet Can Tosun| Unity Developer|
|Burak YILDIRIM| Unity Developer|
|Bahadır DURMUŞ| Unity Developer|

## Teknik Tasarım Detayları

### Teknik Yapı
* #### Teknik Donanım
	&nbsp; &nbsp;Bu oyun PC ve Console da oynamaya uygundur. Bilgisayara orta alt seviye veya üstü CPU-GPU kombinasyonuna sahipseniz veya son 2 jenerasyon consollardan birini kullanıyorsanız bu oyunu rahatlıkla oynayabilirsiniz.
* #### Teknik Yazılım
	&nbsp; &nbsp;Bu oyunu oluşturmak için Unity yazılımını kullandık, Unity sayesinde 3 boyutlu bir dünya yapmakta zorluk çekmedik. Objeleri Blender programını kullanarak programladık.
* #### Yapay Zeka
	&nbsp; &nbsp; Düşman yapay zekası oyunda belirlenen zorluğa göre tasarlanmıştır. Normal zamanda devriye şeklinde gezen düşmanlar oyuncuyu gördüklerinde oyuncuya karşı agresif bir tavırla saldırırlar.
### Grafik Ve Animasyon
&nbsp; &nbsp; Oyunu ilk başta 2D olarak planlıyorduk ama daha sonra 3D yapmanın oyun için daha faydalı olacağını düşünüp 3D tasarlamaya başladık. Oyundaki nesneleri karakterleri ve objeleri Blender isimli programı kullanarak oluşturduk ve oyuna ekledik.
## Haraket Mekanikleri
### Keyboard
![Keyboard Controls]()
- ileri geri için A ve D
- Zıplamak için Space ve W
- Etkileşim tuşu E
- Envanterde Gezinme ScrollUp ve ScrollDown _(Demoda bulunmuyor.)_
- Saldırı ve savunma LMB, RMB
- Kaçınma Ctrl
### Controller
![Controller Controls]()
> _Tuşlar Xbox kumandası baz alınarak verilmiştir_
- İleri geri için LeftJoystick
- Zıplamak için A
- Etkileşim tuşu RightTrigger
- Envanterde Gezinme DpadLeft ve Dpad right _(Demoda bulunmuyor.)_
- Saldırı ve savunma X, Y
- Kaçınma B

## Core Loop
![coregameloop](./img/gameloop.png)

## Hayatta Kalma
&nbsp;&nbsp; Hayatta kalma mekanikleri can ve enerji baz alarak ilerliyor. Karakterin çoğu aksiyonu enerji harcar, eğer enerjisi biter ise karakter yorulur ve soluklanmak için bir müddet olduğu yerde kalır.

![can_bar]()

Karakterin canı: (100 + ((Kullandığı silahın seviyesi) * 30)), enerjisi: 150 dir. Oyuncu eğer enerji harcayan bir eylem gerçekleştirmez ise enerji saniyede 50 dolacak şekilde dolmaya başlar. Can kendi kendine dolmaz.


## Savaş Sistemi
&nbsp; &nbsp; Oyuncu bölüm başında silahını seçer ve maceraya başlar. Bu macerada karşısına belirli düşmanlar çıkacaktır, Düşmanla karşılaşıldığında ise;

### Düşman Çeşitleri
&nbsp; &nbsp; Oyunda farklı yapıya sahip 3 düşman tipi var, bunlar; Askerler, Böcekler ve Enerji formları.
#### Askerler
![askerler]()
&nbsp; &nbsp; Askerler klasik ve normal düşman tipidir, oyuncunun kullandığı silahları onlarda kullanır. Görüş alanına girdiğinizde sizi takip eder ve vuruş menziline girerseniz size saldırırlar. Kullandıkları silaha göre dayanılıkları, hızları ve hasarları değişkenlik gösterir.
Can Havuzu: Değişken

![bocek]()
&nbsp; &nbsp; Böcekler yerden çıkar ve yaydıkları güçlü Aura ile aura menzilindeki düşmanları hasar almaz hale getirirler ama kendileri hasar alabilir. Çok dayanıklı değillerdir ama Hızlı haraket ederler. Can havuzu: 100.
#### Enerji Formları
![enerjiform]()
&nbsp; &nbsp; Enerji formları saçtıkları elektik ile oyuncuyu çarpar ve bir süreliğine yavaşlatır. Hasarı azdır ama kendisi dayanıksız değildir çok fazla haraket kabiliyetleri de yoktur. Çarpılan oyuncunun haraketi ve saldırıları yavaşlar, çarpılma etkisinden kurtulana kadar defans duruşuna geçemez. Can havuzu: 150;

### Savaş Mekanikleri
&nbsp;&nbsp; Oyuncu savaş esnasında toplamda 3 Mekaniğe sahip, Bunlar Saldırı Savunma ve Kaçınma;

#### 1. Saldırı
&nbsp;&nbsp; Oyuncu farenin Sol tuşu ile saldırıya geçer. Saldırmaya karar verdiği anda bir miktar enerji harcar _(Eğer yeterli enerjisi yok ise saldıramaz)_ ardından saldırı animasyonu devreye girer. Saldırı gerçekleştiğinde silahın çeşitine göre menzilinde bir düşman var ise ilgili düşman hasar alır , Silahın etkileri üzerine uygulanır ve 0.1 saniye sersemler. Ard arda yapılan öldürmeler kombo olarak nitelendirilir ve her 5X comboda hasar (Kombo sayacı * 3x) kadar artar.
#### 2. Savunma
&nbsp;&nbsp; Oyuncu farenin sağ tuşu ile defans duruşuna geçer, sağ tuşu bıraktığında karakter defans duruşunu bırakır. Defans duruşu sırasında enerji emilim şeklinde azalır, enerji bitiminde defans duruşunu bırakır. Aynı zamanda defans duruşu sırasında vuruş alırsa ilgili savunan ve saldıran silah kombinasyonuna göre oyuncu; azaltılmış hasar alabilir, vuruşu engelleyebilir veya her şeye rağmen saldırıyı engelleyemeyebilir. Eğer parry aktifleşir ise toplam enerjisinin %5 kadarını anında geri kazanır.

Parry: Eğer hasar yemeden 0.3 saniye önce Defans duruşuna geçmiş ise ilgili saldıran/savunan silah kombinasyonuna göre parry yapabilir.
#### 3. Kaçınma
&nbsp;&nbsp; Oyuncu kaçınma animasyonunda iken hasar almaz ve saldırı yapamaz.

### Silahlar
&nbsp;&nbsp; Oyunda 3'ü yakın 1'i uzak mesafe olmak üzere toplamda 4 tane silah bulunmakta bunlar; kılıç, mızrak, kalkan ve yay'dır. Silahlar kullanıldıkça deneyim puanı kazanırlar ve bu puanlar ile seviye atlarlar, her 2 seviyede bir silahın görünümü bir üst düzeye geçer. Ayrıca her silahın challange ile açılan özelleştirilmiş rünleri vardır, bu rünlerden 1 tanesini silah seçerken aktif edilir ve bölüm ortasında değiştirilemez.

#### Silah Levelleri
 - Level 0-25, Seviye 0
 - level 25-50, Seviye 1 -> Görünüş güncellemesi
 - level 50-75, Seviye 2
 - level 75-100, Seviye 3 -> Görünüş güncellemesi
 - level 100-125, Seviye 4
 - level 125, 150, Seviye 5 -> Görünüş güncelemesi

#### Kılıç
![kilic]()
- Saldırı anında menzilindeki bütün düşmanlara kesme şeklinde vurarak hasar uygular, kısa mesafede etkilidir. Hasar : (20 * seviye)
- Defans duruşunda iken uzak mesafeli saldırıları %10 ihtimalle savurur, Kalkan ve mızrak saldırılarını engelleyemez iken Kılıç saldırılarını %100 engeller.
- **Rünleri ise**;
	- **Dişli Yüzey**: Yapılan her saldırı düşman üzerinde kanama efekti uygular. _(İlk bölümü bu silah ile bitirince unlock olur.)_ Hasar: Saniye başına 10 hasar. Etki 3 saniye sürer.
	- **Şifalı Vuruş**: Düşman öldürmek eksik canının %2'sini geri doldurur. _(Bu silah ile herhangi bir hasar almadan 10 düşman öldürünce unlock olur.)_
	- **Kesici Dalga**: Yapılan saldırılar ileri doğru bir dalga yollar ve dalgaya deyen herkes hasar alır. _(Bu silah ile tek vuruşta 3 kill alınca unlock olur.)_ Hasar: (10 * seviye)
	- **Seri katil**: 10x kombo yapınca hasar artışı sağlar. _(Bu silah ile 5 vuruşta toplam 5 kill alınca unlock olur.)_ hasar artışı: +%30

#### Mızrak
![mizrak]()
- Saldırı anında menzilindeki bütün düşmanlara delme şeklinde saldırarak hasar uygular, orta mesafede etkilidir. Kısa mesafede hasar vuramaz. Hasar : (25 * seviye)
- Default olarak %5 zırh deşmeye sahiptir _(Zırhlı düşmanlara %5 fazladan vurur)_
- Defans duruşunda iken kılıç saldırılarını %50 ihtimalle savurur. Kalkan, Yay ve Mızrak saldırılarını engelleyemez.
- **Rünleri ise**
	- **Zehir Diş**: Yapılan her saldırı düşman üzerinde zehir efekti uygular. _(İlk bölümü bu silah ile bitirince unlock olur.)_ Hasar: Saniye başına 10 hasar. Etki 3 saniye sürer.
	- **Hızlı Vuruş**: Normal saldırılar 3'lü vuruş yapar. 3 vuruş birden vurma etkileri uygular. _(Bu silah ile tek saldırıda 3 kill alınca unlock olur.)_ Hasar: (hasar * 3)
	- **Kırık Zırh**: Zırh deşme oranı %20 artarak %25 olur. _(Bu silah ile ard arda 4 vuruşta 4 kill alınca açılır.)_
	- **İtici Vuruş**: Mızrağı yere vurup yakınındaki düşmaları saldırı menziline iter. _(Bu silah ile 2 sn içinde hem önünden hemde arkadan kill alınca unlock olur.)_

#### Kalkan
![kalkan]()
 - Saldırı anında menzilindeki düşmanlara itme şeklinde saldırarak hasar uygular ve düşmanları bir miktar itip 0.1sn sersemletir. Ağır saldırı yapar. Çok kısa mesafede hasar uygular. Hasar : (50 * seviye)
 - Defans duruşunda bütün silahlardan gelen saldırıları savuşturur, ve defans duruşunda %10 daha yavaş enerji tüketir.
 - **Rünleri ise**
 	 - **Dodge Master**: Parry halinde düşman 0.5sn sersemler. _(İlk bölümü bu silah ile bitirince unlock olur.)_
	 - **Hurraa**: Oyuncu hücuma kalkar ve önündeki bütün düşmanları durduğu yere kadar iter. _()_
	 - **Kapı Gibi**: Karşı yönden gelen bütün hasarı defans duruşuna gerek kalmadan engeller. _()_
	 - **Tokalaşma**: Hem önünde hem arkasında düşman var ise arkadaki düşmanı alıp önüne atar _()_

#### Yay
![yay]()
 - Saldırı halinde karakter bir ok atar ve rün çeşitine göre hasar verir. Rün yok ise ok dediği ilk düşmana saplanır ve hasar uygular. Yay'ın farklı gerginlikleri yoktur belirli, sadece ayarlanan mesafede gider. Hasar : (20 * seviye)
 - Defans duruşu yoktur. Ama hafifliğinden dolayı karakter yay kullanırken daha hızlıdır.
 - **Rünleri ise**
	 - **Çift Ok**: Saldırı esnasında aynı anda 2 ok atar. Hasar: 2x _(İlk bölümü bu silah ile bitirince unlock olur.)_
	 - **Yıldırım Oku**: Attığı okların ucu gümüştendir. Bu sayede çarptığı yüzeye yıldırım düşer. Yıldırım hasarı : 60.
	 - **Kaboom**: Attığı okların ucunda barut torbası bulunur. Bu sayede çarptığı yerde bir patlama oluşur. Patlama Hasarı: (40 * seviye).
	 - **Ateş Topları**: Attığı okların ucunda çakmaktaşı ve saman bulunur. Bu sayede çarptığı yer bir müddet yanar. Ates hasarı : saniye başına 10;

## Skill Three
![skill_tree](./img/skill_tree.png)

&nbsp; &nbsp; Yetenek ağacı'nın ilk yeteneği tutorialda açılır ve karaktere dash mekaniğini ekler. Daha sonra 3 ana dala bölünür, bu temalar; Saldırı, Savunma, ve Haraketlilik. Her bir dal temasına uygun bir pasif(kullanmak için çaba gerektirmeyen) güç ekler.
