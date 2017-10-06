using UnityEngine;
using System.Collections;

public class ChangeScreen : MonoBehaviour {

	public int Levels;
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown (KeyCode.Return)){
			Application.LoadLevel (Levels);
		}

	
	}
}
