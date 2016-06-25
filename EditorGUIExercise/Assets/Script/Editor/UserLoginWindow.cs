using UnityEngine;
using UnityEditor;

using System.Collections;

public class UserLoginWindow : EditorWindow {

	private string userName = "";

	[MenuItem("Weapon/UserLogin")]
	static void ToolBar() {
		GetWindow<UserLoginWindow>().Show();
	}

	void OnGUI() {

		GUILayout.BeginHorizontal();
		GUILayout.Label("User Name:", GUILayout.Width(80));
		userName = GUILayout.TextArea(userName, GUILayout.Width(200));
		GUILayout.EndHorizontal();
		
	}
}
