using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class ExportSysData : EditorWindow {



	[MenuItem("Weapon/打包SysData")]
	static void ToolBar() {
		GetWindow<ExportSysData>().Show();
	}



	void OnGUI() {

		GUILayout.BeginVertical();
		string p = "Assets/Abs/SysData.asset";

		if (GUILayout.Button("测试打包SysData")) {
			var sysData = ScriptableObject.CreateInstance<SysData>();
			sysData.content = new List<Vector3>();
			sysData.content.Add(new Vector3(1, 2, 3));
			sysData.content.Add(new Vector3(3, 2, 3));
			sysData.content.Add(new Vector3(4, 2, 3));
			sysData.content.Add(new Vector3(5, 2, 3));
			sysData.content.Add(new Vector3(6, 2, 3));

			string[] subFolders = AssetDatabase.GetSubFolders("Assets");

			bool isCreateAbs = true;

			for(int i = 0; i < subFolders.Length; i++) {
				string subName = subFolders[i];
				if (subName.Contains("Abs")) {
					isCreateAbs = false;
					break;
				}
			}

			if(isCreateAbs) {
				AssetDatabase.CreateFolder("Assets", "Abs");
			}


			AssetDatabase.CreateAsset(sysData, p);
			AssetDatabase.Refresh();
		}

		if (GUILayout.Button("创建Bundle")) {
			BuildPipeline.BuildAssetBundles("Assets/Abs", BuildAssetBundleOptions.None, BuildTarget.StandaloneOSXUniversal);
			AssetDatabase.Refresh();

			//
		}

		if (GUILayout.Button("删除")) {
			AssetDatabase.DeleteAsset(p);
			AssetDatabase.Refresh();

			//BuildPipeline.BuildAssetBundles
		}

		GUILayout.EndVertical();

	}
}