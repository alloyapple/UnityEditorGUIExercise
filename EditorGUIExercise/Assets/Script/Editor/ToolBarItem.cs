using UnityEngine;
using UnityEditor;
using System.Collections;

public class ToolBarItemWindow : EditorWindow {

	[MenuItem("Weapon/ToolBar")]
	static void ToolBar() {
		GetWindow<ToolBarItemWindow>().Show();
	}

	void OnGUI() {

		Color backupColor = GUI.backgroundColor;

		GUILayout.BeginHorizontal(EditorStyles.toolbar, GUILayout.ExpandWidth(true));
		{
			GUI.backgroundColor = Color.green;
			for(int i = 0; i < 10; ++i) {
				if (GUILayout.Button("Button" + i, EditorStyles.toolbarButton, GUILayout.ExpandWidth(false))) {
					EditorUtility.DisplayDialog("hello", "Button click is " + i, "确定"); 
				}
			}
		}
		GUI.backgroundColor = backupColor;

		GUILayout.Button("Test Color", EditorStyles.toolbarButton, GUILayout.ExpandWidth(false));

			
		GUILayout.EndHorizontal();
			
	}
}
