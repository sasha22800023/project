//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pr7
{
    using System;
    using System.Collections.Generic;
    
    public partial class Компьютер
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Компьютер()
        {
            this.Установка = new HashSet<Установка>();
        }
    
        public int Номер_компьютера { get; set; }
        public string IP_адрес { get; set; }
        public string Кабинет { get; set; }
        public string Характеристики { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Установка> Установка { get; set; }
    }
}
