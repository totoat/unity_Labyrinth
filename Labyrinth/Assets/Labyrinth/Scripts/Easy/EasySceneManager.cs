using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EasySceneManager : MonoBehaviour {

    [SerializeField] Button NextButton;

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

    // Nextアイコンに呼ばれる
    public void OnClickNext()
    {
        SceneManager.LoadScene("Hard");
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
        if (Input.GetKeyUp(KeyCode.Return))
        {
            OnClickNext();
        }
    }

}
