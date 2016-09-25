using UnityEngine;
using System.Collections;

public class EasyTouchTest : MonoBehaviour {

	void On_TouchStart(Gesture g)
	{
		Debug.Log("TouchStart"+g.position);
	}
}
