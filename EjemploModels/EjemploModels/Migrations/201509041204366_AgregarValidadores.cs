namespace EjemploModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarValidadores : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personas", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Personas", "Apellido", c => c.String(nullable: false));
            AlterColumn("dbo.Personas", "Direccion", c => c.String(nullable: false));
            AlterColumn("dbo.Personas", "Telefono", c => c.String(maxLength: 8));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personas", "Telefono", c => c.String());
            AlterColumn("dbo.Personas", "Direccion", c => c.String());
            AlterColumn("dbo.Personas", "Apellido", c => c.String());
            AlterColumn("dbo.Personas", "Nombre", c => c.String());
        }
    }
}
