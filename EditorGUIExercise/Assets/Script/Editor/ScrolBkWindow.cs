using UnityEngine;
using UnityEditor;

using System.Collections;

public class ScrolBkWindow : EditorWindow {

	private Vector2 scrollPosition = Vector2.zero;

	[MenuItem("Weapon/滚动测试")]
	static void ToolBar() {
		GetWindow<ScrolBkWindow>().Show();
	}

	void OnGUI() {
		scrollPosition = GUI.BeginScrollView(new Rect(20, 0, 200, 200), scrollPosition, new Rect(0, 0, Screen.width, 300));
		GUI.Label(new Rect(100, 40, Screen.width, 30), "测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图测试滚动视图内容测试滚动视图");
		GUI.EndScrollView();
	}
}
