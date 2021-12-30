using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarrr
{
    class Product
    {
        //ürünü anlatan veri tipi oluştu 
        public  int   Id { get; set; }
        //Id: bir datayı diğerlerinden ayırmak için kullandığımız eşşiz bilgilerdir 
        public string Adi { get; set; }
        public double  Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }


        // diğer yerlerden ulaşabilmek için public dedim 
        //manager controller vs bu classlar bir operasyon tutuyor
        //ortak operasyonlar yine bir classda tutulur 


    }
}

