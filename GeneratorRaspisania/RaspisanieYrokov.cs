//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneratorRaspisania
{
    using System;
    using System.Collections.Generic;
    
    public partial class RaspisanieYrokov
    {
        public int Id { get; set; }
        public int LessonNumber { get; set; }
        public System.DateTime LessonDate { get; set; }
        public int ItemID { get; set; }
    
        public virtual Items Items { get; set; }
    }
}