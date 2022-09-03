
# X Game Documentation
&nbsp;&nbsp; Oyunumuz yıldırımların hükmettiği Post-Apocalyptic bir dünyada geçmektedir. Kahramanımız hayatta kalmak için silahını kuşanıp dışarıdaki tehlikelere karşı savaşmaktadır.

## Haraket Mekanikleri

### Keyboard
![Keyboard Controls]()
- ileri geri için A ve D
- Zıplamak için Space ve W
- Etkileşim tuşu E
- Envanterde Gezinme ScrollUp ve ScrollDown
- Saldırı ve savunma LMB, RMB
- Kaçınma Ctrl
### Controller
![Controller Controls]()
> _Tuşlar Xbox kumandası baz alınarak verilmiştir_
- İleri geri için LeftJoystick
- Zıplamak için A
- Etkileşim tuşu RightTrigger
- Envanterde Gezinme DpadLeft ve Dpad right
- Saldırı ve savunma X, Y
- Kaçınma B

## Savaş _(Combat)_
&nbsp; &nbsp; Oyuncu bölüm başında silahını seçer ve maceraya başlar. Bu macerada karşısına belirli düşmanlar çıkacaktır, Düşmanla karşılaşıldığında ise;

### Düşman Çeşitleri _(Enemy Styles)_
&nbsp; &nbsp; Oyunda farklı yapıya sahip 3 düşman tipi var, bunlar; Askerler, Böcekler ve Enerji formları.
#### Askerler
![askerler]()
&nbsp; &nbsp; Askerler klasik ve normal düşman tipidir, oyuncunun kullandığı silahları onlarda kullanır. Görüş alanına girdiğinizde sizi takip eder ve vuruş menziline girerseniz size saldırırlar. Kullandıkları silaha göre dayanılıkları, hızları ve hasarları değişkenlik gösterir. 
#### Böcekler
![bocek]()
&nbsp; &nbsp; Böcekler yerden çıkar ve yaydıkları güçlü Aura ile aura menzilindeki düşmanları hasar almaz hale getirirler ama kendileri hasar alabilir. Çok dayanıklı değillerdir ama Hızlı haraket ederler.
#### Enerji Formları
![enerjiform]()
&nbsp; &nbsp; Enerji formları saçtıkları elektik ile oyuncuyu çarpar ve bir süreliğine yavaşlatır. Hasarı azdır ama kendisi dayanıksız değildir çok fazla haraket kabiliyetleri de yoktur. Çarpılan oyuncunun haraketi ve saldırıları yavaşlar, çarpılma etkisinden kurtulana kadar defan duruşuna geçemez.

### Savaş Mekanikleri _(Combat Mechanics)_
&nbsp;&nbsp; Oyuncu savaş esnasında toplamda 3 Mekaniğe sahip, Bunlar Saldırı Savunma ve Kaçınma;
#### 1. Saldırı
&nbsp;&nbsp; Oyuncu farenin Sol tuşu ile saldırıya geçer. Saldırmaya karar verdiği anda bir miktar enerji harcar _(Eğer yeterli enerjisi yok ise saldıramaz)_ ardından saldırı animasyonu devreye girer. Saldırı gerçekleştiğinde silahın çeşitine göre menzilinde bir düşman var ise ilgili düşman hasar alır , Silahın etkileri üzerine uygulanır ve 0.1 saniye sersemler. Ard arda yapılan öldürmeler kombo olarak nitelendirilir ve her 5X comboda hasar (Kombo sayacı * 3x) kadar artar.
#### 2. Savunma
&nbsp;&nbsp; Oyuncu farenin sağ tuşu ile defans duruşuna geçer, sağ tuşu bıraktığında karakter defans duruşunu bırakır. Defans duruşu sırasında enerji emilim şeklinde azalır, enerji bitiminde defans duruşunu bırakır. Aynı zamanda defans duruşu sırasında vuruş alırsa ilgili savunan ve saldıran silah kombinasyonuna göre oyuncu; azaltılmış hasar alabilir, vuruşu engelleyebilir veya her şeye rağmen saldırıyı engelleyemeyebilir. Eğer hasar yemeden 0.3 saniye önce Defans duruşuna geçmiş ise ilgili saldıran/savunan silah kombinasyonuna göre pery yapabilir. Eğer pery aktifleşir ise toplam enerjisinin %5 kadarını anında geri kazanır.
#### 3. Kaçınma
&nbsp;&nbsp; Oyuncu kaçınma animasyonunda iken hasar almaz ve saldırı yapamaz.

### Silahlar
&nbsp;&nbsp; Oyunda 3'ü yakın 1'i uzak mesafe olmak üzere toplamda 4 tane silah bulunmakta bunlar; kılıç, mızrak, kalkan ve yay'dır. Silahlar kullanıldıkça deneyim puanı kazanırlar ve bu puanlar ile seviye atlarlar, her 2 seviyede bir silahın görünümü bir üst düzeye geçer. Ayrıca her silahın challange ile açılan özelleştirilmiş rünleri vardır, bu rünlerden 1 tanesini silah seçerken aktif edilir ve bölüm ortasında değiştirilemez.

#### Kılıç
![kilic]()
- Saldırı anında menzilindeki bütün düşmanlara kesme şeklinde vurarak hasar uygular, kısa mesafede etkilidir.
- Defans modunda iken uzak mesafeli saldırıları %10 ihtimalle savurur, Kalkan ve mızrak saldırılarını engelleyemez iken Kılıç saldırılarını %100 engeller.
- **Rünleri ise**;
	- **Tırtıklı Yüzey**: Yapılan her saldırı düşman üzerinde kanama efekti uygular. _(İlk bölümü bu silah ile bitirince unlock olur.)_
	- **Şifalı Vuruş**: Düşman öldürmek eksik canının %2'sini geri doldurur. _(Bu silah ile herhangi bir hasar almadan 10 düşman öldürünce unlock olur.)_
	- **Kesici Dalga**: Yapılan saldırılar ileri doğru bir dalga yollar ve dalgaya deyen herkes hasar alır. _(Bu silah ile tek vuruşta 3 kill alınca unlock olur.)_
	- **Seri katil**: 10x kombo yapınca hasar artışı sağlar. _(Bu silah ile 5 vuruşta toplam 5 kill alınca unlock olur.)_

#### Mızrak
![mizrak]()
- Saldırı anında menzilindeki bütün düşmanlara delme şeklinde saldırarak hasar uygular, orta mesafede etkilidir. Kısa mesafede hasar vuramaz.
- Default olarak %5 zırh deşmeye sahiptir _(Zırhlı düşmanlara %5 fazladan vurur)_
- Defans modunda iken kılıç saldırılarını %50 ihtimalle savurur. Kalkan, Yay ve Mızrak saldırılarını engelleyemez.
- **Rünleri ise**
	- **Zehir Diş**: Yapılan her saldırı düşman üzerinde zehir efekti uygular. _(İlk bölümü bu silah ile bitirince unlock olur.)_
 	- **Hızlı Vuruş**: Normal saldırılar 3'lü vuruş yapar. 3 vuruş birden vurma etkileri uygular. _(Bu silah ile tek saldırıda 3 kill alınca unlock olur.)_ 
	- **Kırık Zırh**: Zırh deşme oranı %20 artarak %25 olur. _(Bu silah ile ard arda 4 vuruşta 4 kill alınca açılır.)_
	- **İtici vuruş**: Mızrağı yere vurup yakınındaki düşmaları saldırı menziline iter. _(Bu silah ile 2 sn içinde hem önünden hemde arkadan kill alınca unlock olur.)_
