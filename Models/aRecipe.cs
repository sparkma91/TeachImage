//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeachImageWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class aRecipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public aRecipe()
        {
            this.CollectionRecipe = new HashSet<CollectionRecipe>();
            this.GoodRecipe = new HashSet<GoodRecipe>();
            this.Ingredient = new HashSet<Ingredient>();
            this.MessageRecipe = new HashSet<MessageRecipe>();
            this.Steps = new HashSet<Steps>();
        }
    
        public int aId { get; set; }
        public string aName { get; set; }
        public int classId { get; set; }
        public string aIntroduce { get; set; }
        public byte[] aImg { get; set; }
        public int aQuantity { get; set; }
        public int aTime { get; set; }
        public int cId { get; set; }
    
        public virtual cMember cMember { get; set; }
        public virtual RClass RClass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectionRecipe> CollectionRecipe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodRecipe> GoodRecipe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingredient> Ingredient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageRecipe> MessageRecipe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Steps> Steps { get; set; }
    }
}
