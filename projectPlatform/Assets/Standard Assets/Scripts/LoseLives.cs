using UnityEngine;
using System.Collections;

public class LoseLives : MonoBehaviour {

	static int Lives = 3;
	public int Levels;
	public Texture Player;

	void OnTriggerEnter2D(Collider2D Player)
	{
		if (Player.gameObject.tag == "Player") {
						Application.LoadLevel (Levels);
			Destroy (gameObject);
			Kill ();
		}

	}
	void OnGUI(){

		Rect r = new Rect(0,0, 200,100); //Adjust the rectangle position and size for your own needs
		GUILayout.BeginArea(r);
		GUILayout.BeginHorizontal();
		
		for(int i = 0; i < Lives; i++)
		GUILayout.Label(Player); //assign your heart image to this texture
		
		
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();

	}
	public void Kill()
	{
		Lives -= 1;
		
		if (Lives <= 0) 
		{
			Application.LoadLevel (9);
			Lives = 3;

		}
	}
}