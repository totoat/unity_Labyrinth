using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sentaku : MonoBehaviour {

    public MeshRenderer meshRenderer;
    public Color Default;
    public AudioClip soundChoise;
    public AudioClip soundDecision;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        meshRenderer = GetComponent<MeshRenderer>();
        Default = meshRenderer.material.color;
        audioSource = GetComponent<AudioSource>();        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            meshRenderer.material.color = new Color(256, 256, 256, 0);
            audioSource.PlayOneShot(soundChoise);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            meshRenderer.material.color = Default;
            audioSource.PlayOneShot(soundChoise);
        }

        if (Input.GetKeyUp(KeyCode.Return) && meshRenderer.material.color == Default)
        {
            audioSource.PlayOneShot(soundDecision);
            SceneManager.LoadScene("Easy");
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("ゲームを終了します");
            Application.Quit();
        }
    }
}
