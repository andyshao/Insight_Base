//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insight.WS.Base.Common.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_ModuleGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYS_ModuleGroup()
        {
            this.SYS_Module = new HashSet<SYS_Module>();
        }
    
        public System.Guid ID { get; set; }
        public long SN { get; set; }
        public Nullable<int> Index { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Icon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_Module> SYS_Module { get; set; }
    }
}
