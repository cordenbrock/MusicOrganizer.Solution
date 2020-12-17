using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string Title { get; set; }
    private static List<Album> _instances = new List<Album> {};
    public int Id { get; }

    public Album(string albumTitle)
    {
      Title = albumTitle;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Album> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }


  }
}