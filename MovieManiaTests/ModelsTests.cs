using NUnit.Framework;
using MovieMania.Models;

namespace MovieManiaTests
{
    public class ModelsTests
    {
        [Test]
        public void TestFilmModelIdPropertie()
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
        public void TestFilmModelTitlePropertie()
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
        public void TestFilmModelDescriptionPropertie()
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
        public void TestFilmModelGenrePropertie()
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
        public void TestFilmModelRatingPropertie()
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
        public void TestFilmModelImagePropertie()
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
        public void TestFilmModelTrailerPropertie()
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
        public void TestUserModelIdPropertie()
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
        public void TestUserModelUserNamePropertie()
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
        public void TestUserModelEmailPropertie()
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
        public void TestUserModelPassWordPropertie()
        {
            //Arrange
            var user = new AppUser();

            //Act
            user.PasswordHash = "password";

            //Assert
            Assert.AreEqual(user.PasswordHash, "password");
            Assert.IsNotNull(user.PasswordHash);
        }
    }
}