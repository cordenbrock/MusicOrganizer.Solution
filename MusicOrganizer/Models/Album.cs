using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string Title { get; set; }

    public Album(string albumTitle)
    {
      Title = albumTitle;
    }

  }
}