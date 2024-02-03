using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{


    // bir class'ı iki parça halinde tasarlamaya partial class denir.
    // iki farklı class gibi dursada partial keywordü aslında her iki sınıfı da birleştirme için kullanılır.

    // partial class'lar iki yada daha çok parça şeklinde tasarlanabilir.


    // Partial class tasarlarken, her partial'in aynı namespace içerisinde olması gerekmektedir.

    // partial class tasarlanırken, tüm partial'ların aynı erişim belirteci alıyor olması gerkemektedir.
    // gerçek hayatta partial class'lar, kod okunabilirliğini sağlamak için kullanılmaktadır.


    // örnek : iki partial classlı bir yapımız olduğunu düşünelim.

    // 1. partial'a prop'lar
    // 2. partial'a metotlar yerleştirilebilir.
    public partial class Partial
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public partial class Partial
    {
        public void Barcode()
        {
            Console.WriteLine("Barcode Number : 466564");
        }
        public void Stock()
        {
            Console.WriteLine("5 in stock");
        }
    }
    public partial class Partial
    {
        public int LastPartial { get; set; }
        public delegate void LastDelege();
    }
}
