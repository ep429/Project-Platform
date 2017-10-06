using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour {

	int Collected;
	public Texture Credit1;
	public Texture Credit2;
	public Texture Credit3;
	public Texture Credit4;


	void OnTriggerEnter2D(Collider2D hit)
	{
		if(hit.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			Collected++;


		}
	}

	void OnGUI()
	{
		GUI.Label(new Rect(400,0,300,100), Credit1);
		GUI.Label(new Rect(425,0,300,100), Credit2);
		GUI.Label(new Rect(450,0,300,100), Credit3);
		GUI.Label(new Rect(500,0,300,100), Credit4);

	}
}