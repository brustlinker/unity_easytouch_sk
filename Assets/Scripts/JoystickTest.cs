using UnityEngine;
using System.Collections;

public class JoystickTest : MonoBehaviour {

	public EasyJoystick joystick;
	
	// Update is called once per frame
	void Update () {
		print(joystick.JoystickAxis);
	}
}
