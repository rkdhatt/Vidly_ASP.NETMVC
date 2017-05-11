namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('HangOver', 5, '1900-01-01 12:00:00 AM', '1900-01-01 12:00:00 AM', 5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Die Hard', 1, '1900-01-01 12:00:00 AM', '1900-01-01 12:00:00 AM', 3)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('The Terminator', 1, '1900-01-01 12:00:00 AM', '1900-01-01 12:00:00 AM', 1)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Toy Story', 3, '1900-01-01 12:00:00 AM', '1900-01-01 12:00:00 AM', 4)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ('Titanic', 4, '1900-01-01 12:00:00 AM', '1900-01-01 12:00:00 AM', 6)");
        }

        public override void Down()
        {
        }
    }
}
