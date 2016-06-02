using UnityEngine;
using UnityEditor;
using System.Collections;

public class ToolBarItemWindow : EditorWindow {

	[MenuItem("Weapon/ToolBar")]
	static void ToolBar() {
		GetWindow<ToolBarItemWindow>().Show();
	}

	static private Texture2D _backdropTexture;

	static public Texture2D backdropTexture {
		get {
			if (_backdropTexture == null) {
				_backdropTexture = CreateCheckerTex(new Color(0.1f, 0.1f, 0.1f, 0.5f), new Color(0.2f, 0.2f, 0.2f, 0.5f));
			}

			return _backdropTexture;
		}
	}

	static Texture2D CreateCheckerTex (Color c0, Color c1) {
		Texture2D tex = new Texture2D(16, 16);
		tex.name = "[Generated] Checker Texture";
		tex.hideFlags = HideFlags.DontSave;

		for (int y = 0; y < 8; ++y) for (int x = 0; x < 8; ++x) tex.SetPixel(x, y, c1);
		for (int y = 8; y < 16; ++y) for (int x = 0; x < 8; ++x) tex.SetPixel(x, y, c0);
		for (int y = 0; y < 8; ++y) for (int x = 8; x < 16; ++x) tex.SetPixel(x, y, c0);
		for (int y = 8; y < 16; ++y) for (int x = 8; x < 16; ++x) tex.SetPixel(x, y, c1);

		tex.Apply();
		tex.filterMode = FilterMode.Point;
		return tex;
	}

	void DrawTiledTexture(Rect rect, Texture tex) {
		GUI.BeginGroup(rect); 
		{
			int width = Mathf.RoundToInt(rect.width);
			int height = Mathf.RoundToInt(rect.height);

			for(int y = 0; y < height; y += tex.height) {
				for(int x = 0; x < width; x += tex.width) {
					GUI.DrawTexture(new Rect(x, y, tex.width, tex.height), tex);
				}
			}
		}
		GUI.EndGroup();
	}

	void DrawBackground(float ratio) {
		Rect rect = GUILayoutUtility.GetRect(0, 0);
		rect.width = Screen.width - rect.xMin;
		rect.height = Screen.width * ratio;
		GUILayout.Space(rect.height);

		if (Event.current.type == EventType.Repaint) {
			Texture2D blank = EditorGUIUtility.whiteTexture;
			Texture2D check = backdropTexture;

			GUI.color = new Color(0f, 0f, 0f, 0.2f);
			GUI.DrawTexture(new Rect(rect.xMin, rect.yMin - 1, rect.width, 1f), blank);
			GUI.DrawTexture(new Rect(rect.xMin, rect.yMax - 1, rect.width, 1f), blank);
			GUI.color = Color.white;

			DrawTiledTexture(rect, check);

		}
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

		for(int i = 0; i < 100; i++) {
			EditorGUI.DrawPreviewTexture(new Rect(i * 32, 100, 32, 32), sprite);

		}

		DrawBackground(1.0f);



			
	}
}




