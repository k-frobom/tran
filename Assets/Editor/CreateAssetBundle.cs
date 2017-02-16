using UnityEngine;
using System.Collections;
using UnityEditor;

public class AssetBundleCreate : MonoBehaviour {

	[MenuItem ("Assets/Build AssetBundles")]

	static void BuildAllAssetBundles()
	{
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles", BuildAssetBundleOptions.None, BuildTarget.Android);
	}

}
