using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarrr
{
    class SepetManager // bunlar bir operasyon tutuyor...
    {
        //naming convetion isimlendirme kuralı 
        // bir yerde normal parantez varsa metottur 
        public void Ekle(Product product)
        {
            //ne eklemek istediğimizi parametre olarak metota vermeliyiz 
            Console.WriteLine("Tebrikler ,Sepete eklendi: "+ product.Adi);
            //ortak operasyonlar yine bir class içinde yazar 
            // sepere ürün ekleme sepeti listeleme müşteri işlemleri vs. ürün işlemleri vs vs... 
            //convention buyük harfle başlar 
        }
        public void Ekle2(Product product)
        {
            Console.WriteLine("Sepete eklendi:"+product.Id);

        }



    }
}
