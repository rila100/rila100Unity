using UnityEngine;
using System.Collections;

public class Sketch : MonoBehaviour {

	public GameObject myPrefab;
    //put your URL here
    //public
    string _WebsiteURL = "http://informgmt192.azurewebsites.net/tables/products?zumo-api-version=2.0.0";

	void Start () {
	
		int totalcubes = 30;

		float totalDistance = 2.9f;
	 for (int i = 0; i < totalcubes; i++)  
			// remember to play monodevelop before contunie
		{
			float perc = i / (float)totalcubes;
			float sin = Mathf.Sin (perc * Mathf.PI/2);

			float x =1.8f + sin  *totalDistance;
			float y = 5.0f;
			float z = 0.0f;


			var newCube = (GameObject)Instantiate (myPrefab, new Vector3 (x, y, z), Quaternion.identity);
			newCube.GetComponent<cudescript> ().SetSize (.45f * (1.0f - perc) );
			newCube.GetComponent<cudescript> ().rotateSpeed = .2f + perc*4.0f;  

	}

	}

	void Update () {
		
	}

}
