using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string Title { get; set; }
    private static List<Album> _instances = new List<Album> {};

    public Album(string albumTitle)
    {
      Title = albumTitle;
      // _instances.Add("expected fail");
    }

  }
}