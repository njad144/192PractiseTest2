using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Pathfinding.Serialization.JsonFx;

//Make sure you get rid of the namespace that is automatically generated here.
class Movies
{
    //List all the columns of your table here in the same format as below.
    public string MovieID { get; set; }
	[JsonName("Movie Title")]
	public string Title { get; set; }
	[JsonName("Release Date")]
	public string Release { get; set; }
	[JsonName("IMDB URL")]
	public string URL { get; set; }
	public string Action { get; set; }
	public string Childrens { get; set; }
	public string Comedy { get; set; }
	public string Documentary { get; set; }
	public string Drama { get; set; }
	public string Fantasy { get; set; }
	public string Horror { get; set; }
	public string Mystery { get; set; }
	public string Romance { get; set; }
	[JsonName("Sci-Fi")]
	public string SciFi { get; set; }
	public string Thriller { get; set; }
}
