using UnityEngine;
using System.Collections;

[System.Serializable]
public class FooBar {

	public int foo = 0;
	[System.NonSerialized]
	public int bar = 2;
	
}

public class WeaponItem : MonoBehaviour {

	// Use this for initialization

	public FooBar fooBar;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
