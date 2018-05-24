namespace ProjetLogo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutPersonne : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Prenom = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        TelFixe = c.Int(nullable: false),
                        Gsm = c.Int(nullable: false),
                        Inami = c.Int(),
                        SpecialisationId = c.Byte(),
                        FonctionId = c.Byte(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Fonction_Id = c.Int(),
                        Specialisation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fonctions", t => t.Fonction_Id)
                .ForeignKey("dbo.Specialisations", t => t.Specialisation_Id)
                .Index(t => t.Fonction_Id)
                .Index(t => t.Specialisation_Id);
            
            CreateTable(
                "dbo.Fonctions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Specialisations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personnes", "Specialisation_Id", "dbo.Specialisations");
            DropForeignKey("dbo.Personnes", "Fonction_Id", "dbo.Fonctions");
            DropIndex("dbo.Personnes", new[] { "Specialisation_Id" });
            DropIndex("dbo.Personnes", new[] { "Fonction_Id" });
            DropTable("dbo.Specialisations");
            DropTable("dbo.Fonctions");
            DropTable("dbo.Personnes");
        }
    }
}
