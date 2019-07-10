using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardSceneManager : MonoBehaviour
{

    // BackTitleアイコンに呼ばれる
    public void OnClickBack()
    {
        SceneManager.LoadScene("Title");
    }

    // Reloadアイコンに呼ばれる
    public void OnClickReload()
    {
        string nowScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(nowScene);
    }

    // キー入力
    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            OnClickBack();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            OnClickReload();
        }
    }

}
