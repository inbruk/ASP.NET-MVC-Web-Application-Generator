//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.DataAccessLayer.AppIdAndAuth
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblApplicationIdApplication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblApplicationIdApplication()
        {
            this.tblApplicationIdSubsystem = new HashSet<tblApplicationIdSubsystem>();
            this.tblAuthorizationApplication = new HashSet<tblAuthorizationApplication>();
        }
    
        public long Id { get; set; }
        public string EnumName { get; set; }
        public long ProjectId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblApplicationIdSubsystem> tblApplicationIdSubsystem { get; set; }
        public virtual tblApplicationIdProject tblApplicationIdProject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAuthorizationApplication> tblAuthorizationApplication { get; set; }
    }
}
