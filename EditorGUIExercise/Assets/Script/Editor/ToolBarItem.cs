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
		
			GUI.backgroundColor = backupColor;

			GUILayout.Button("Change Background Color", EditorStyles.toolbarButton, GUILayout.ExpandWidth(false));

			var color = GUI.color;
			GUI.color = Color.red;

			GUILayout.Button("Change  Color", EditorStyles.toolbarButton, GUILayout.ExpandWidth(false));
			GUI.color = color;
		}
		GUILayout.EndHorizontal();

		EditorGUILayout.BeginHorizontal(GUILayout.MinHeight(10f));
		{
			EditorGUILayout.SelectableLabel("hello World");
			EditorGUILayout.Space();
			EditorGUILayout.SelectableLabel("hello Swift");
		}
		EditorGUILayout.EndHorizontal();
			
	}
}
