######Bilgisayar Organizasyonu ve Tasarımı Dersi Proje Ödevi
######-Marie Simülatörü-

**Projede Görev Alanlar** <br/>
*	Kübra Açıkgöz   	
*	Ahmet Eroğlu       
*	Fatih Bozik			   

**Simülatör Hakkında** <br/>
C# dili ile hazırlanmıştır.<br/>
Etiketler virgül ile birlikte kullanılmalı. <br/>
Etiket ve virgülden sonra bir boşluk bırakılması sonra DEC ya da HEX yazılması lazım. <br/>

***Örnek :*** <br/>
X, DEC 20 <br/>
Loop, Load X 	vs.. <br/>

**Simülatör Testleri** <br/>
**i)**   Bellekteki  (210)<sub>16</sub>-(22F)<sub>16</sub>  alanları arasındaki sayıların her birini 8 ile çarpıp üzerine yazdıran MARIE programı. <br/>
**ii)**	 Fibonacci serisinin ilk 50 elemanını (4FF)<sub>16</sub> adresinden başlayan bellek gözlerini kaydeden MARIE programı. <br/>
**iii)** Bellekteki (350)<sub>16</sub>-(36F)<sub>16</sub> alanları arasındaki sayıların kaçının pozitif kaçının, kaçının negatif ve kaçının sıfır olduğunu bularak bu bilgileri istediğimiz ardışık 3 bellek gözüne yazan MARIE programı

***NOT :*** *Simulasyon için gerekli görülen bellek alanlarına kod içinde rastgele değerler atanmıştır.* 

--

**i)** <br/>
L1, Load L2_temp <br/>  <img align="right" src="https://fatihbozik.files.wordpress.com/2015/02/resim15.png">
Store L2_sayac <br/>
Load Toplam_temp <br/>
Store Toplam <br/>
L2, Load Toplam <br/>
AddI Adres <br/>
Store Toplam <br/>
Load L2_sayac <br/>
Subt One <br/>
Store L2_sayac <br/>
Skipcond 400 <br/>
Jump L2 <br/>
Load Toplam <br/>
StoreI Adres <br/>
Load Adres <br/>
Add One <br/>
Store Adres <br/>
Load L1_sayac <br/>
Subt One <br/>
Store L1_sayac <br/>
Skipcond 400 <br/>
Jump L1 <br/>
Halt <br/>
L2_sayac, DEC 8 <br/>
L2_temp, DEC 8 <br/>
L1_sayac, DEC 32 <br/>
Adres, HEX 210 <br/>
One, DEC 1 <br/>
Toplam, DEC 0 <br/>
Toplam_temp, DEC 0 <br/>

--

**ii)** <br/>
***Not:*** *Belleklerde taşma olmasın diye Fibonaccinin ilk 20 elemanını bulduruyorum.* <br/> <br/>
ORG 4E6 <br/> <img align="right" src="https://fatihbozik.files.wordpress.com/2015/02/resim16.png">
Loop, LoadI Adres1 <br/>
Store Sayi <br/> 
LoadI Adres2 <br/>
Add Sayi <br/>
Store Temp <br/>
Load Adres1 <br/>
Add One <br/>
Store Adres1 <br/>
Load Adres2 <br/>
Add One <br/>
Store Adres2 <br/>
Load Temp <br/>
StoreI Adres2 <br/>
Load Sayac <br/>
Subt One <br/>
Store Sayac <br/> 
Skipcond 400 <br/>
Jump Loop <br/>
Halt <br/>
Sayi, DEC 0 <br/>
Adres1, HEX 4FF <br/>
Adres2, HEX 500 <br/>
Temp, DEC 0 <br/>
One, DEC 1 <br/>
Sayac, DEC 20 <br/>
F1, DEC 1 <br/>
F2, DEC 1 <br/>

--

**iii)** <br/>
DONGU, LoadI Adres <br/> <img align="right" src="https://fatihbozik.files.wordpress.com/2015/02/resim17.png">
Skipcond 000 <br/>
Jump SIFIRMIPOZITIFMI <br/>
Load Neg_sayac <br/>
Add One <br/>
Store Neg_sayac <br/>
Jump ATLA <br/>
SIFIRMIPOZITIFMI, Skipcond 400 <br/>
Jump POZITIF <br/>
Load Sıfır_sayac <br/>
Add One <br/>
Store Sıfır_sayac <br/>
Jump ATLA <br/>
POZITIF, Load Poz_sayac <br/>
Add One <br/>
Store Poz_sayac <br/>
ATLA, Load Adres <br/>
Add One <br/>
Store Adres <br/>
Load Sayac <br/>
Subt One <br/>
Store Sayac <br/>
Skipcond 400 <br/>
Jump DONGU <br/>
Halt <br/>
Adres, HEX 350 <br/>
Sayac, DEC 32 <br/>
Sayac, DEC 32 <br/>
One, DEC 1 <br/>
Neg_sayac, DEC 0 <br/>
Poz_sayac, DEC 0 <br/>
Sıfır_sayac, DEC 0 <br/>




