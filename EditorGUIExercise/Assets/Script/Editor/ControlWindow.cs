

using UnityEngine;
using UnityEditor;

using System.Collections;

public class ControlWindow : EditorWindow {



	[MenuItem("Weapon/Control属性")]
	static void ToolBar() {
		GetWindow<ControlWindow>().Show();
	}

	static int buttonHash = "Button".GetHashCode();

	void OnGUI() {

		GUILayout.BeginVertical();

		if (GUILayout.Button("显示控件属性")) {
			var id = GUIUtility.GetControlID(buttonHash, FocusType.Passive);

			EditorUtility.DisplayDialog("id is " + id,
										"显示",
										"OK");
		}



		GUILayout.EndVertical();
		
	}
}