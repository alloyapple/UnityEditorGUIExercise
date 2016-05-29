using UnityEngine;
using UnityEditor;
using System.Collections;

public class WeaponWindow : EditorWindow {

	// Use this for initialization

	[MenuItem("Weapon/Item")]
	static void init() {
		GetWindow<WeaponWindow>().Show();

	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
