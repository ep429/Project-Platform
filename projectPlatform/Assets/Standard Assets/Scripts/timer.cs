using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

	public float remTime = 100f;
	int remTimeInt;
	public float sizeX;
	public float sizeY;
	public LoseLives lives;
	public Texture Player;
	public int Levels;
	public Font MyFont;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		remTime -= Time.deltaTime;
		if ((remTime % 1) >= 0.5)
			remTimeInt = Mathf.FloorToInt (remTime);

		if (remTime <= 0) {
			lives.Kill ();
			Application.LoadLevel (Levels);
		}

	}

	void OnGUI(){

		GUI.skin.font = MyFont;
		GUI.Label (new Rect(720, 0, 275, 100), "Time Remaining: ");
		GUI.Label (new Rect (925, 25, 275, 100), remTimeInt.ToString ());


	}
}

