using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasySceneManager : MonoBehaviour {

    // BackTitleアイコンに呼ばれる
    public void OnClickBack()
    {
        SceneManager.LoadScene("Title");
    }

    // Reloadアイコンに呼ばれる
    public void OnClickReload()
    {
        SceneManager.LoadScene("Easy");
    }

    // キー入力
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title");
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene("Easy");
        }
    }

}
