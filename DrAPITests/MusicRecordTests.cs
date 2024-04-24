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
            MusicRecord m = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1973 };
            m.ValidateArtist();

            MusicRecord artistNull = new MusicRecord { Title = "The Dark Side of the Moon", Artist = null, DurationInSeconds = 2580, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentNullException>(() => artistNull.ValidateArtist());

            MusicRecord artistShort = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "A", DurationInSeconds = 2580, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => artistShort.ValidateArtist());
            
        }

        [TestMethod()]
        public void ValidateDurationTest()
        {
            MusicRecord m = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1973 };
            m.ValidateDuration();

            MusicRecord durationNull = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = null, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentNullException>(() => durationNull.ValidateDuration());

            MusicRecord durationNegative = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = -1, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => durationNegative.ValidateDuration());
            
        }

        [TestMethod()]
        public void ValidatePublicationYearTest()
        {
            MusicRecord m = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1973 };
            m.ValidatePublicationYear();

            MusicRecord yearNull = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = null };
            Assert.ThrowsException<ArgumentNullException>(() => yearNull.ValidatePublicationYear());

            MusicRecord yearLow = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1859 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => yearLow.ValidatePublicationYear());
            
        }

        [TestMethod()]
        public void ValidateTest()
        {
            MusicRecord m = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1973 };
            m.Validate();

            MusicRecord titleNull = new MusicRecord { Title = null, Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentNullException>(() => titleNull.Validate());

            MusicRecord titleShort = new MusicRecord { Title = "A", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => titleShort.Validate());

            MusicRecord artistNull = new MusicRecord { Title = "The Dark Side of the Moon", Artist = null, DurationInSeconds = 2580, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentNullException>(() => artistNull.Validate());

            MusicRecord artistShort = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "A", DurationInSeconds = 2580, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => artistShort.Validate());

            MusicRecord durationNull = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = null, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentNullException>(() => durationNull.Validate());

            MusicRecord durationShort = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = -1, publicationYear = 1973 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => durationShort.Validate());

            MusicRecord yearNull = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = null };
            Assert.ThrowsException<ArgumentNullException>(() => yearNull.Validate());

            MusicRecord yearLow = new MusicRecord { Title = "The Dark Side of the Moon", Artist = "Pink Floyd", DurationInSeconds = 2580, publicationYear = 1859 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => yearLow.Validate());

            
        }
    }
}