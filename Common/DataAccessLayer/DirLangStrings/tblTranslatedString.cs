//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.DataAccessLayer.DirLangStrings
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTranslatedString
    {
        public long Id { get; set; }
        public long Language { get; set; }
        public int Type { get; set; }
        public Nullable<long> ReferencedItemId { get; set; }
        public string Value { get; set; }
        public bool IsDeleted { get; set; }
    }
}
