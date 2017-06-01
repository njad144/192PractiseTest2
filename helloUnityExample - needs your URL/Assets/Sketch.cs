using UnityEngine;
using Pathfinding.Serialization.JsonFx; //make sure you include this using

public class Sketch : MonoBehaviour {
    public GameObject myPrefab;
    string _WebsiteURL = "http://infomgmt192.azurewebsites.net/tables/" + "movies" + "?zumo-api-version=2.0.0";

    void Start () {
        string jsonResponse = Request.GET(_WebsiteURL);
        if (string.IsNullOrEmpty(jsonResponse))
        {
            return;
        }

        Movies[] movies = JsonReader.Deserialize<Movies[]>(jsonResponse);
        int totalCubes = movies.Length;
        int totalDistance = 5;
        int i = 0;

        foreach (Movies movie in movies)
        {
            float perc = i / (float)totalCubes;
            float x = perc * totalDistance;
			float y = Random.Range(3.0f, 8.0f);//5.0f;//treesurvey.Y;// 5.0f;
            float z = -3.0f;
            GameObject newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
			myCubeScript cubeScript = newCube.GetComponent<myCubeScript>();

			cubeScript.setSize((1.0f - perc) * 2/3);
			cubeScript.ratateSpeed = perc;
            newCube.GetComponentInChildren<TextMesh>().text = movie.Title;

			if (movie.Action == "1") cubeScript.setColor(Color.red);
			if (movie.Childrens == "1") cubeScript.setColor(Color.blue);
			if (movie.Comedy == "1") cubeScript.setColor(Color.yellow);
			if (movie.Documentary == "1") cubeScript.setColor(Color.green);
			if (movie.Drama == "1") cubeScript.setColor(Color.cyan);
			if (movie.Fantasy == "1") cubeScript.setColor(Color.clear);
			if (movie.Horror == "1") cubeScript.setColor(Color.black);
			if (movie.Mystery == "1") cubeScript.setColor(Color.gray);
			if (movie.Romance == "1") cubeScript.setColor(Color.magenta);
			if (movie.SciFi == "1") cubeScript.setColor(Color.white);
			if (movie.Thriller == "1") cubeScript.setColor(new Color(120f, 120f, 120f));
			if (movie.Comedy == "1" && movie.Drama == "1") cubeScript.setColor(Color.red);

			i++;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
