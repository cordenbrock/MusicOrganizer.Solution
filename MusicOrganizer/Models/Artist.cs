using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Album> Albums { get; set; }

    public Artist(string artistName)
    {
      Name = artistName;
      _instances.Add(this);
    }

    public static List<Artist> GetAll()
    {
      List<Artist> emptyList = new List<Artist> {};
      return emptyList;
      // return _instances;
    }
  }
}