using System;

namespace metotlarrr
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            //class tanımlama ,  classın örneği =class dan bir değişken tanımlamam için sağında newlemek gerekir. ürün oluşturdum
            
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elmasi";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu ";
            //classlar sayesinde düzene girdi 
            Product[] products = new Product[] 
            // diziler çoğul olarak isimlendirilir 
            // array bir veri tipinde  ne kadar data istersek o kadar datayı içinde tutan  yapıdır . 
  
            {
               product1,product2
                //neyin ne olduğu tipleri classlar sayesinde düzene sokuyoruz 
            };
            foreach (Product product in products)
            {
                //products dediğimde benim dizimi tek tek gez getir anlamına gelir .Gelen datayı tek tek ekrana basmaktadır 
                // o anki elemana takma isim denir product denir 
                // c# tip güvenliği olduğundan çalışcağım veri tipini bilmek isterim derler 
                // var dersekte olur  producta çevirir 
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);

            }

            Console.WriteLine("........Metot................");
            SepetManager sepetManager = new SepetManager();
            //instance oluşturduk class örneği 
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle2(product1);
            sepetManager.Ekle2(product2 );
            
          ;
        }
    }
}
//dont repeat yourself - clean code - best practice
// c# java gibi dillerede her şey classlardan oluşur temel yapı classların içinde olur 

