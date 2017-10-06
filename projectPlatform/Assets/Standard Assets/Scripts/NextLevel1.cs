using UnityEngine;
using System.Collections;

public class NextLevel1 : MonoBehaviour {

	public int level;

	void OnTriggerEnter2D()
	{
		Application.LoadLevel (level);
	}
}
