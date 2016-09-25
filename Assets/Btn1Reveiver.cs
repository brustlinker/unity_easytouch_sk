using UnityEngine;
using System.Collections;

public class Btn1Reveiver : MonoBehaviour {

	void DownMethod(string btnName)
	{
		print(btnName+"Down");
	}

	void PressMethod(string btnName)
	{
		print(btnName+"Press");
	}

	void UpMethod(string btnName)
	{
		print(btnName+"Up");
	}
}
