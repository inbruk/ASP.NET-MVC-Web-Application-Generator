//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppExample.DataAccessLayer.Engine
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAccount()
        {
            this.tblCustomer = new HashSet<tblCustomer>();
            this.tblDriver = new HashSet<tblDriver>();
        }
    
        public long Id { get; set; }
        public string Comment { get; set; }
        public Nullable<long> Balance { get; set; }
        public Nullable<long> AccountState { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomer> tblCustomer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDriver> tblDriver { get; set; }
    }
}
