using UnityEngine;
using System.Collections;

public class GButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.multiTouchEnabled) {

			for(int i = 0; i < Input.touchCount; ++i) {
				Touch touch = Input.GetTouch(i);
				Debug.Log("" + touch.position);
			}
		}
	
	}
}
