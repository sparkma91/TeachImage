﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class projectsqlEntities : DbContext
    {
        public projectsqlEntities()
            : base("name=projectsqlEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<aRecipe> aRecipe { get; set; }
        public virtual DbSet<cMember> cMember { get; set; }
        public virtual DbSet<CollectionRecipe> CollectionRecipe { get; set; }
        public virtual DbSet<DraftClass> DraftClass { get; set; }
        public virtual DbSet<DraftIngredient> DraftIngredient { get; set; }
        public virtual DbSet<DraftRecipes> DraftRecipes { get; set; }
        public virtual DbSet<DraftSteps> DraftSteps { get; set; }
        public virtual DbSet<GoodRecipe> GoodRecipe { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<MessageRecipe> MessageRecipe { get; set; }
        public virtual DbSet<RClass> RClass { get; set; }
        public virtual DbSet<Steps> Steps { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Blacklist> Blacklist { get; set; }
        public virtual DbSet<Planning> Planning { get; set; }
        public virtual DbSet<PlanningIngredient> PlanningIngredient { get; set; }
        public virtual DbSet<ReportMessage> ReportMessage { get; set; }
        public virtual DbSet<ReportRecipe> ReportRecipe { get; set; }
    }
}