<Query Kind="Statements">
  <Connection>
    <ID>38bfb990-61e1-4e62-a48b-d3581f1b3f5f</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              orderby g.Name
			  select new 
			  {
			   Genre = g.Name,
			   TracksCount = g.Tracks.Count()
			  };
results.Dump("Query Math");