# Şarkıcılar LINQ Uygulaması

Bu C# uygulaması, popüler Türk şarkıcılarının bilgilerini içeren bir liste üzerinde LINQ sorguları gerçekleştirerek çeşitli analizler yapar. Uygulama, `System.Linq` kütüphanesini kullanarak veri filtreleme, sıralama, gruplama gibi işlemleri içerir.

## 📌 Kullanılan Özellikler

- LINQ sorguları (`Where`, `Select`, `OrderBy`, `GroupBy`, `FirstOrDefault`)
- `TryParse` ile metin içinden sayısal veri ayrıştırma
- String filtreleme (örneğin, `StartsWith`)
- Gruplama ve alfabetik sıralama

## 🧠 Uygulamanın Yaptığı İşlemler

1. **Adı 'S' ile Başlayan Şarkıcılar**
   - `NameSurname` özelliği `"S"` harfi ile başlayan sanatçılar listelenir.

2. **Albüm Satışı 10 Milyon Üzerinde Olanlar**
   - `Selling` alanından sayısal veri ayrıştırılarak 10 milyondan fazla satış yapan şarkıcılar bulunur.

3. **2000 Yılı Öncesi Pop Şarkıcıları (Çıkış Yılına Göre Gruplu ve İsim Sırasına Göre)**
   - 2000 yılından önce çıkış yapan, sadece `Pop` türündeki sanatçılar çıkış yılına göre gruplanır ve isimlerine göre sıralanarak yazdırılır.

4. **En Çok Albüm Satan Şarkıcı**
   - Tüm şarkıcılar arasından en yüksek satış değerine sahip kişi belirlenir ve yazdırılır.

5. **En Yeni ve En Eski Çıkış Yapan Şarkıcılar**
   - Liste üzerinden çıkış yıllarına göre en eski ve en yeni sanatçılar bulunur ve gösterilir.


