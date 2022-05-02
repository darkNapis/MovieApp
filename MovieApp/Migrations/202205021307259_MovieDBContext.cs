namespace MovieApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieDBContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Rating = c.Int(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        ImageData = c.String(),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.MovieId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.MovieGenre",
                c => new
                    {
                        Movie_MovieId = c.Int(nullable: false),
                        Genre_GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_MovieId, t.Genre_GenreId })
                .ForeignKey("dbo.Movie", t => t.Movie_MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Genre", t => t.Genre_GenreId, cascadeDelete: true)
                .Index(t => t.Movie_MovieId)
                .Index(t => t.Genre_GenreId);
            
            CreateTable(
                "dbo.PersonMovie",
                c => new
                    {
                        Person_PersonId = c.Int(nullable: false),
                        Movie_MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Person_PersonId, t.Movie_MovieId })
                .ForeignKey("dbo.Person", t => t.Person_PersonId, cascadeDelete: true)
                .ForeignKey("dbo.Movie", t => t.Movie_MovieId, cascadeDelete: true)
                .Index(t => t.Person_PersonId)
                .Index(t => t.Movie_MovieId);
            
            CreateTable(
                "dbo.RolePerson",
                c => new
                    {
                        Role_RoleId = c.Int(nullable: false),
                        Person_PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_RoleId, t.Person_PersonId })
                .ForeignKey("dbo.Role", t => t.Role_RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Person", t => t.Person_PersonId, cascadeDelete: true)
                .Index(t => t.Role_RoleId)
                .Index(t => t.Person_PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolePerson", "Person_PersonId", "dbo.Person");
            DropForeignKey("dbo.RolePerson", "Role_RoleId", "dbo.Role");
            DropForeignKey("dbo.PersonMovie", "Movie_MovieId", "dbo.Movie");
            DropForeignKey("dbo.PersonMovie", "Person_PersonId", "dbo.Person");
            DropForeignKey("dbo.MovieGenre", "Genre_GenreId", "dbo.Genre");
            DropForeignKey("dbo.MovieGenre", "Movie_MovieId", "dbo.Movie");
            DropIndex("dbo.RolePerson", new[] { "Person_PersonId" });
            DropIndex("dbo.RolePerson", new[] { "Role_RoleId" });
            DropIndex("dbo.PersonMovie", new[] { "Movie_MovieId" });
            DropIndex("dbo.PersonMovie", new[] { "Person_PersonId" });
            DropIndex("dbo.MovieGenre", new[] { "Genre_GenreId" });
            DropIndex("dbo.MovieGenre", new[] { "Movie_MovieId" });
            DropTable("dbo.RolePerson");
            DropTable("dbo.PersonMovie");
            DropTable("dbo.MovieGenre");
            DropTable("dbo.Role");
            DropTable("dbo.Person");
            DropTable("dbo.Movie");
            DropTable("dbo.Genre");
        }
    }
}
