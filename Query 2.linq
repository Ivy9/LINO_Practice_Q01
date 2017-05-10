<Query Kind="Statements">
  <Connection>
    <ID>38bfb990-61e1-4e62-a48b-d3581f1b3f5f</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
			  where g.Name.Equals("Heavy Metal")
			  select new 
			  {
			   TracksCount = g.Tracks.Count(),
			   Tracks = from t in g.Tracks
			   	select new 
				{
				 TracksName = t.Name,
				 AlbumName = t.Album.Title,
				 Milliseconds = t.Milliseconds,
				 Size = (t.Bytes / 1000) + " kb",
				 Prise = t.UnitPrice
				}
			  };
results.Dump("More Math");