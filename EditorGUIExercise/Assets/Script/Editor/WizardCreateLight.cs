using UnityEngine;
using UnityEditor;

using System.Collections;

public class WizardCreateLight : ScriptableWizard {

	public float range = 500;
	public Color color = Color.red;

	[MenuItem("GameObject/Create Light Wizard")]
	static void CreateWizard() {
		ScriptableWizard.DisplayWizard<WizardCreateLight>("Create light", "Create", "Apply");

	}

	void OnWizardCreate() {
		GameObject go = new GameObject("New Light");
		Light lt = go.AddComponent<Light>();
		lt.range = range;
		lt.color = color;
	}

	void OnWizardUpdate() {
		helpString = "Please set light color";
	}

	void OnWizardOtherButton() {
		if (Selection.activeTransform != null) {
			Light lt = Selection.activeTransform.GetComponent<Light>();
			if (lt != null) {
				lt.color = Color.red;
			}
		}
	}
}
