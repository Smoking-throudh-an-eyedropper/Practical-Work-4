//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AAA_PR4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jurnal
    {
        public int ID { get; set; }
        public Nullable<int> Student { get; set; }
        public Nullable<int> Predmet { get; set; }
        public Nullable<int> Assessment { get; set; }
    
        public virtual Assessment Assessment1 { get; set; }
        public virtual Predmet Predmet1 { get; set; }
        public virtual Student Student1 { get; set; }
    }
}
