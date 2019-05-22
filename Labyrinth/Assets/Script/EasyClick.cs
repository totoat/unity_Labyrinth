using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class EasyClick : MonoBehaviour {

    public Material mat = null;   // Inspectorから指定
    public string objname = "";     // Inspectorから指定

    // Use this for initialization
    void Start () {

        if (mat == null)
        {
            return;
        }
        GameObject obj = GameObject.Find("easy");
        if (obj)// オブジェクトが取得できたら以下を実行
        {
            // マテリアルを割り当て
            
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
