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
    
    public partial class cMember
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cMember()
        {
            this.aRecipe = new HashSet<aRecipe>();
            this.CollectionRecipe = new HashSet<CollectionRecipe>();
            this.DraftRecipes = new HashSet<DraftRecipes>();
            this.GoodRecipe = new HashSet<GoodRecipe>();
            this.MessageRecipe = new HashSet<MessageRecipe>();
        }
    
        public int cId { get; set; }
        public string cUserId { get; set; }
        public string cPwd { get; set; }
        public string cPPwd { get; set; }
        public string cNickname { get; set; }
        public string cSex { get; set; }
        public string cPhoneNum { get; set; }
        public string cEmail { get; set; }
        public Nullable<System.DateTime> cBirth { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aRecipe> aRecipe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CollectionRecipe> CollectionRecipe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DraftRecipes> DraftRecipes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodRecipe> GoodRecipe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageRecipe> MessageRecipe { get; set; }
    }
}