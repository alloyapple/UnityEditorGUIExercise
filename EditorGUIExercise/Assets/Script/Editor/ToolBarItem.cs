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

			var color = GUI.contentColor;
			GUI.contentColor = Color.red;

			GUILayout.Button("Change  Color", EditorStyles.toolbarButton, GUILayout.ExpandWidth(false));
			GUI.contentColor = color;
		}
		GUILayout.EndHorizontal();

		EditorGUILayout.BeginHorizontal(GUILayout.MinHeight(10f));
		{
			EditorGUILayout.SelectableLabel("hello World");
			EditorGUILayout.Space();
			EditorGUILayout.SelectableLabel("hello Swift");
		}
		EditorGUILayout.EndHorizontal();

		var r = EditorGUILayout.BeginHorizontal("Button");
		{
			if (GUI.Button(r, GUIContent.none)) {
				Debug.Log("Go here");
			}

			GUILayout.Label("I am in side button");
			GUILayout.Label("So am I");
		}

		EditorGUILayout.EndHorizontal();

		Texture2D sprite = (Texture2D)AssetDatabase.LoadAssetAtPath("Assets/Texture/bird.png", typeof(Texture2D));

		EditorGUI.DrawPreviewTexture(new Rect(0, 100, 32, 32), sprite);


			
	}
}
