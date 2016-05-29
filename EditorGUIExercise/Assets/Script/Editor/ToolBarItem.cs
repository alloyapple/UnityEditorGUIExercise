using UnityEngine;
using UnityEditor;
using System.Collections;

public class ToolBarItemWindow : EditorWindow {

	[MenuItem("Weapon/ToolBar")]
	static void ToolBar() {
		GetWindow<ToolBarItemWindow>().Show();
	}

	void OnGUI() {
		GUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.ExpandWidth(true));
		GUILayout.Button("Hello", EditorStyles.toolbarButton, GUILayout.ExpandWidth(false));
		GUILayout.EndHorizontal();
			
	}
}
