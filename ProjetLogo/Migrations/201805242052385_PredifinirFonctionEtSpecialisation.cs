namespace ProjetLogo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PredifinirFonctionEtSpecialisation : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Fonctions ON");
            Sql("INSERT INTO Fonctions(Id, Nom) VALUES (1, 'Logopède')");
            Sql("INSERT INTO Fonctions(Id, Nom) VALUES (2, 'Docteur')");
        }
        
        public override void Down()
        {
        }
    }
}
