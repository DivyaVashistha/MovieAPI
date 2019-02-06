namespace MovieAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovie : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values(1,'Hitman\'s Bodygaurd',1,'2000-03-11','Action')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Comedy')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Crime')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Drama')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Fantasy')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Historical')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Horror')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Mystery')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Philosophical')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Political')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Romance')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Science fiction')");
            Sql("insert into Movies(Id,Name,GenreId,ReleaseDate,Description,Rating,Genre_Id) values('Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
