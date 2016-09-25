using UnityEngine;
using System.Collections;

public class EasyTouchTest2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void On_TouchStart(Gesture g)
	{
		Debug.Log("TouchStart"+g.position);
	}
}
