using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleSceneManager : MonoBehaviour {
    
    public GameObject allowH;
    private Renderer rendE;
    private Renderer rendH;
    
    public AudioClip soundChoice;
    public AudioClip soundDecision;
    AudioSource audioSource;

	void Start () {
        rendE = this.GetComponent<Renderer>();
        rendH = allowH.GetComponent<Renderer>();
        rendE.enabled = true;
        rendH.enabled = false;
        
        audioSource = this.GetComponent<AudioSource>();
    }
	
    //ButtonEに呼ばれる
    public void OnClickE()
    {
        audioSource.PlayOneShot(soundDecision);
        SceneManager.LoadScene("Easy");
    }
    //ButtonHに呼ばれる
    public void OnClickH()
    {
        audioSource.PlayOneShot(soundDecision);
        SceneManager.LoadScene("Easy");
    }

    // キー入力
	void Update () {
        Choice();
        Decision();
    }

    // シーンの選択(キー入力)
    void Choice()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rendE.enabled = true;
            rendH.enabled = false;
            audioSource.PlayOneShot(soundChoice);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rendE.enabled = false;
            rendH.enabled = true;
            audioSource.PlayOneShot(soundChoice);
        }

    }
    // シーンの決定(キー入力)
    void Decision()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            audioSource.PlayOneShot(soundDecision);
        }

        if (Input.GetKeyUp(KeyCode.Return))
        {
            if (rendE.enabled)
            {
                SceneManager.LoadScene("Easy");
            }
            if (rendH.enabled)
            {
                SceneManager.LoadScene("Easy");
            }
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("ゲームを終了します");
            Application.Quit();
        }
    }
}
