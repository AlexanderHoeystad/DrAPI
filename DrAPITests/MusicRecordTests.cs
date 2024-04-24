using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrAPI.Tests
{

    [TestClass()]
    public class MusicRecordTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            MusicRecord m = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1973 };
            string str = m.ToString();

            Assert.AreEqual("The Dark Side of the Moon by Pink Floyd (1973) Duration In Seconds: 2580", str);
        }

        [TestMethod()]
        public void ValidateTitleTest()
        {
            MusicRecord m = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1973 };
            m.ValidateTitle();

            

            MusicRecord titleNull = new MusicRecord { Title = null, Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentNullException>(() => titleNull.ValidateTitle());

            MusicRecord titleShort = new MusicRecord { Title = "A", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => titleShort.ValidateTitle());



        }

        [TestMethod()]
        public void ValidateArtistTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ValidateDurationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ValidatePublicationYearTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ValidateTest()
        {
            Assert.Fail();
        }
    }
}