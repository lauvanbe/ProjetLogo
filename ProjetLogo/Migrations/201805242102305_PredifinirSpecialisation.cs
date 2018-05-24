namespace ProjetLogo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PredifinirSpecialisation : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Specialisations ON");
            Sql("INSERT INTO Specialisations(Id, Nom, Description) VALUES (1, 'Généraliste', 'Soigne toutes maladie')");
            Sql("INSERT INTO Specialisations(Id, Nom, Description) VALUES (2, 'Discalculie', 'Problème avec les maths')");
        }
        
        public override void Down()
        {
        }
    }
}
