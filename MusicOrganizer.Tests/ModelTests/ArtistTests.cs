using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests // : IDisposable
{
  [TestClass]
  public class ArtistTest
  {
    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("Bela Fleck");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

  }
}