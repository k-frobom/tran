using System;
using UnityEngine;
using System.Collections;

public class AssetLoader : MonoBehaviour {


	public string BundleURL;//http://www.frobom.com/cinema/video_asset.file
	public string AssetName;
	public int version = 1;
	AssetBundle bundle;

	void Start() {
		StartCoroutine (DownloadAndCache());
	}

	IEnumerator DownloadAndCache (){

		yield return StartCoroutine(AssetBundleManager.downloadAssetBundle(BundleURL, version));

        bundle = AssetBundleManager.getAssetBundle(BundleURL, version);

		GameObject girl= Instantiate(bundle.LoadAsset("betadine002") as GameObject);
        
		//girl.transform.localScale = new Vector3(15.0f, 13.5f, 16.0f);
		//girl.transform.position = new Vector3(0, 0.046f, -0.225f);
		girl.transform.parent = GameObject.Find("ImageTarget").transform;
        // icon.SetActive(false);
        // icon_obj = icon.transform;


        bundle.Unload(false);

    }
}
