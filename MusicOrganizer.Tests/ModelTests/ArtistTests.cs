using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTests : IDisposable
  {
    
    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("Bela Fleck");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsArtistName_String()
    {
      string artistName = "Benny Goodman";
      Artist newArtist = new Artist(artistName);

      string result = newArtist.Name;

      Assert.AreEqual(artistName, result);
    }

    [TestMethod]
    public void SetName_SetsArtistNameOnInstance_String()
    {
      string artistNameOriginal = "Kenny Loggins";
      string artistTwo = "Kenny Rogers";
      Artist firstArtist = new Artist(artistNameOriginal);
      firstArtist.Name = artistTwo;
      Assert.AreEqual("Kenny Rogers", firstArtist.Name);
    }

    [TestMethod]
    public void GetAll_ReturnsList_List()
    {
      Artist artistOne = new Artist("Lead Belly");
      Artist artistTwo = new Artist("Skip James");
      List<Artist> newList = new List<Artist> { artistOne, artistTwo };

      List<Artist> result = Artist.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

  }
}