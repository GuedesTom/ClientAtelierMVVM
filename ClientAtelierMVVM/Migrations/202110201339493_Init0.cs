namespace ClientAtelierMVVM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DemandeCreations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Motif = c.String(),
                        NomBoite = c.String(),
                        ServiceAdminId = c.Int(nullable: false),
                        NomDemandeur = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ServiceAdmins", t => t.ServiceAdminId, cascadeDelete: true)
                .Index(t => t.ServiceAdminId);
            
            CreateTable(
                "dbo.ServiceAdmins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomServiceAdmin = c.String(),
                        ChefService = c.String(),
                        Mail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Demandes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DemandeChangement = c.String(),
                        AncienResId = c.Int(nullable: false),
                        NouveauResId = c.Int(nullable: false),
                        ServiceAdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Salaries", t => t.AncienResId, cascadeDelete: false)
                .ForeignKey("dbo.Salaries", t => t.NouveauResId, cascadeDelete: false)
                .ForeignKey("dbo.ServiceAdmins", t => t.ServiceAdminId, cascadeDelete: false)
                .Index(t => t.AncienResId)
                .Index(t => t.NouveauResId)
                .Index(t => t.ServiceAdminId);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        TypeContrat = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        LieuNaissance = c.String(),
                        PhotoProfil = c.String(),
                        Adresse = c.String(),
                        AdresseMail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Demandes", "ServiceAdminId", "dbo.ServiceAdmins");
            DropForeignKey("dbo.Demandes", "NouveauResId", "dbo.Salaries");
            DropForeignKey("dbo.Demandes", "AncienResId", "dbo.Salaries");
            DropForeignKey("dbo.DemandeCreations", "ServiceAdminId", "dbo.ServiceAdmins");
            DropIndex("dbo.Demandes", new[] { "ServiceAdminId" });
            DropIndex("dbo.Demandes", new[] { "NouveauResId" });
            DropIndex("dbo.Demandes", new[] { "AncienResId" });
            DropIndex("dbo.DemandeCreations", new[] { "ServiceAdminId" });
            DropTable("dbo.Salaries");
            DropTable("dbo.Demandes");
            DropTable("dbo.ServiceAdmins");
            DropTable("dbo.DemandeCreations");
        }
    }
}
