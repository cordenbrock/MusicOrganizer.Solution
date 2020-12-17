using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTest
  {
    
    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album newAlbum = new Album("test title");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Ziggy Stardust";

      Album newAlbum = new Album(title);
      string result = newAlbum.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_ReturnsTitle_String()
    {
      string newTitle = "self-titled";
      Album testAlbum = new Album(newTitle);
      string updatedTitle = "Alanis Morisette";
      testAlbum.Title = updatedTitle;
      Assert.AreEqual("Alanis Morisette", testAlbum.Title);
    }
  }
}