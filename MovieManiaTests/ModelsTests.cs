using NUnit.Framework;
using MovieMania.Models;

namespace MovieManiaTests
{
    public class ModelsTests
    {
        [Test]
        public void TestFilmModelId()
        {
            //Arrange
            var film = new Film();

            //Act
            film.FilmId = "id";

            //Assert
            Assert.AreEqual(film.FilmId, "id");
            Assert.IsNotNull(film.FilmId);
        }

        [Test]
        public void TestFilmModelTitle()
        {
            //Arrange
            var film = new Film();

            //Act
            film.Title = "title";

            //Assert
            Assert.AreEqual(film.Title, "title");
            Assert.IsNotNull(film.Title);
        }

        [Test]
        public void TestFilmModelDescription()
        {
            //Arrange
            var film = new Film();

            //Act
            film.Description = "description";

            //Assert
            Assert.AreEqual(film.Description, "description");
            Assert.IsNotNull(film.Description);
        }

        [Test]
        public void TestFilmModelGenre()
        {
            //Arrange
            var film = new Film();

            //Act
            film.Genre = "genre";

            //Assert
            Assert.AreEqual(film.Genre, "genre");
            Assert.IsNotNull(film.Genre);
        }

        [Test]
        public void TestFilmModelRating()
        {
            //Arrange
            var film = new Film();

            //Act
            film.Rating = 5;

            //Assert
            Assert.AreEqual(film.Rating, 5);
            Assert.IsNotNull(film.Rating);
        }

        [Test]
        public void TestFilmModelImage()
        {
            //Arrange
            var film = new Film();

            //Act
            film.ImageUrl = "image";

            //Assert
            Assert.AreEqual(film.ImageUrl, "image");
            Assert.IsNotNull(film.ImageUrl);
        }

        [Test]
        public void TestFilmModelTrailer()
        {
            //Arrange
            var film = new Film();

            //Act
            film.TrailerUrl = "trailer";

            //Assert
            Assert.AreEqual(film.TrailerUrl, "trailer");
            Assert.IsNotNull(film.TrailerUrl);
        }

        [Test]
        public void TestUserModelId()
        {
            //Arrange
            var user = new AppUser();

            //Act
            user.Id = "id";

            //Assert
            Assert.AreEqual(user.Id, "id");
            Assert.IsNotNull(user.Id);
        }

        [Test]
        public void TestUserModelUserName()
        {
            //Arrange
            var user = new AppUser();

            //Act
            user.UserName = "username";

            //Assert
            Assert.AreEqual(user.UserName, "username");
            Assert.IsNotNull(user.UserName);
        }

        [Test]
        public void TestUserModelEmail()
        {
            //Arrange
            var user = new AppUser();

            //Act
            user.Email = "email";

            //Assert
            Assert.AreEqual(user.Email, "email");
            Assert.IsNotNull(user.Email);
        }

        [Test]
        public void TestUserModelPassWord()
        {
            //Arrange
            var user = new AppUser();

            //Act
            user.PasswordHash = "password";

            //Assert
            Assert.AreEqual(user.PasswordHash, "password");
            Assert.IsNotNull(user.PasswordHash);
        }
        [Test]
        public void TestCommentModelId()
        {
            //Arrange
            var comment = new Comment();

            //Act
            comment.Id = "id";

            //Assert
            Assert.AreEqual(comment.Id, "id");
            Assert.IsNotNull(comment.Id);
        }
        [Test]
        public void TestCommentModelUserId()
        {
            //Arrange
            var comment = new Comment();

            //Act
            comment.UserId = "UserId";

            //Assert
            Assert.AreEqual(comment.UserId, "UserId");
            Assert.IsNotNull(comment.UserId);
        }
        [Test]
        public void TestCommentModelFilmId()
        {
            //Arrange
            var comment = new Comment();

            //Act
            comment.FilmId = "FilmId";

            //Assert
            Assert.AreEqual(comment.FilmId, "FilmId");
            Assert.IsNotNull(comment.FilmId);
        }

        [Test]
        public void TestCommentModel()
        {
            //Arrange
            var comment = new Comment();

            //Act
            comment.Content = "Content";

            //Assert
            Assert.AreEqual(comment.Content, "Content");
            Assert.IsNotNull(comment.Content);
        }
    }
}