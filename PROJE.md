### BİLGİSAYAR ORGANİZASYONU VE TASARIMI DERSİ PROJE ÖDEVİ
			   
Dersin projesi kapsamında, ekte detaylı yapısı ve komut seti verilen MARIE bilgisayarı için
yazılan programları çalıştıran bir simülatör geliştirmeniz istenmektedir. Simülatörün
geliştirilmesinde kullanılacak programlama dili açısından herhangi bir kısıtlama yoktur.
İstediğiniz dili kullanabilirsiniz.

Aşağıdaki resimde bu görev için hazırlanmış bir simülatör ve örnek çıktısı görülmektedir.
Örnekte X ve Y etiketli bellek gözlerindeki sayıları kendileri ile toplayıp yeniden üzerlerine
yazan bir MARIE programı görülmektedir. Assembly programı ekrana yazıldıktan sonra
öncelikle “Programı Yükle” butonu vasıtasıyla hexadecimal karşılığına çevrilmeli; etiketlerin,
komutların ve değişkenlerin adresleri hesaplanarak bellek üzerindeki yerleşimi ve değeri
gösterilmelidir. Sonrasında “Çalıştır” butonu vasıtasıyla bellekteki hexadecimal formattaki
kod çalıştırılmalı ve işlem bittikten sonraki yeni bellek yapısı ve saklayıcı içerikleri ekranda
gösterilmelidir.

![alt text](https://fatihbozik.files.wordpress.com/2015/02/resim11.png)

Hazırlayacağınız program GUI ya da konsol tabanlı olabilir. Ancak her iki şekilde de yazılan
assembly programı icra edilmeden önceki ve edildikten sonraki bellek içeriği ve saklayıcı
değerleri raporlanabilmelidir. Bu nedenle konsol uygulaması geliştireceklerin sonuçları ayrı
bir dosyaya yazdırmaları tavsiye edilir.

**Dikkat edilmesi gereken noktalar:** <br/>
**1-** Bellekteki tüm sayılar hexadecimal formattadır. Aritmetik işlemler sırasında isterseniz
kolaylık sağlaması açısından bu değerleri onluk tabana çevirip kullanabilirsiniz. Ancak
sonucu bellek veya saklayıcılara yine hexadecimal formatta yazmanız gerekmektedir.

**2-** Simülatörünüz ORG, END, DEC, HEX gibi pseudo komutları tanımak zorundadır.
Kullanıcı, yazdığı programın bellekte hangi konumdan itibaren saklanacağını ORG ile
seçebilmelidir.

**3-** Simülatörünüz ile bir MARIE kodunu işlerken iki geçiş yapmanız gerekmektedir.
İlk geçişte tanımlanan etiketleri ve her satıra karşılık gelen fiziksel adresi hesaplamanız
gerekmektedir (ORG komutuna göre). İlk geçişte bulduğunuz etiketlerin değerlerini ayrı bir
tablo ya da dosyada raporlamanız gerekmektedir. İkinci geçişte önceden hesaplamış
olduğunuz etiket adreslerine göre hexadecimal komutları oluşturmanız gerekmektedir.

**4-** Saklayıcıların içerikleri raporlanırken bit sayılarına uygun notasyonda gösterilmelerine
dikkat edilmelidir. AC, 16 bit ise mutlaka 4 haneli bir hexadecimal sayı ile ifade edilmelidir.
Daha az hane ile gösterilemez.

![alt text](https://fatihbozik.files.wordpress.com/2015/02/resim12.png)

--

![alt text](https://fatihbozik.files.wordpress.com/2015/02/resim13.png)

--

![alt text](https://fatihbozik.files.wordpress.com/2015/02/resim14.png)

Simülatörünüzün test aşamasında üç farklı MARIE programı hazırlayıp yazdığınız program
ile çalıştırmanız beklenmektedir. Bu programlar şu şekilde olmalıdır:

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**i)** Bellekteki (210)<sub>16</sub> - (22F)<sub>16</sub> alanları arasındaki sayıların her &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;birini 8 ile çarpıp üzerine yazdıran MARIE programı

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**ii)** Fibonacci serisinin ilk 50 elemanını (4FF)<sub>16</sub> adresinden başlayan bellek &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;gözlerine kaydeden MARIE programı

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**iii)** Bellekteki (350)<sub>16</sub> - (36F)<sub>16</sub> alanları arasındaki sayıların kaçının pozitif, kaçının negatif ve kaçının sıfır olduğunu bularak bu bilgileri istediğiniz ardışık 3 bellek gözüne yazan MARIE programı

i. ve iii. programda kullanacağınız sayıları negatif ve pozitif sayılar kümesinden rasgele
üretebilirsiniz

--

**Uyulması gereken kurallar ve hatırlatmalar:** <br/>

**-** Proje en fazla 4’er kişilik gruplar halinde hazırlanabilir. <br/>

**-** Projelerinizi bir .rar sıkıştırılmış dosyası (dosya içeriğinde kaynak kod + rapor olmalı) şeklinde ödev sistemine yüklemeniz gerekmektedir. Rapor için yazılı çıktı istenmemektedir. <br/>

**-** Söz konusu simülatörün benzeri internette bulunmaktadır. Bunun çalışmasını inceleyebilirsiniz ancak kesinlikle kaynak kodundan kopya alamazsınız. <br/>

**-** Örgün ve ikinci öğretim öğrencilerinden oluşan bir proje grubu olamaz. Her bölüm öğrencisi sadece kendi bölümünden öğrencilerle proje grubu oluşturabilir. <br/>

**-** Ders etkinliklerinin ağırlık dağılımı; Vize: %25, Proje: %25, Final: %50 şeklinde düzenlenmiştir. Vize sonuçlarınız ve kopya ödev durumunda proje grubunun/gruplarının tüm üyelerinin 0 ile cezalandırılacağı düşünüldüğünde kopya
ödev teslim etmektense eksik ama tamamıyla özgün bir projeyi teslim etmenin daha iyi olacağı hatırlatılır. <br/>

**-** Ödev sistemine proje grubundan sadece bir öğrencinin proje yüklemesi yeterlidir (Raporunuza proje grubundaki tüm öğrencilerin isim ve numaralarını yazdığınız sürece sorun yoktur). Çoklu yükleme yapmayın. <br/>

**Son teslim tarihi: 16 Mayıs 2014 Cuma** <br/>
