using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    [SerializeField] AudioClip don;

    private new Rigidbody rigidbody;
    private new Renderer renderer;
    private Color playerCol;

    AudioSource audioSource;

    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        renderer = GetComponent<Renderer>();
        playerCol= GetComponent<Renderer>().material.color;
        
	}

	void Update ()
    {
        // すり抜け防止策
        transform.Rotate(1, 0, 1);
        rigidbody.AddForce(new Vector3(0, -10, 0));

        //ブレーキ機能
        PlayerBrake();

    }

    private void PlayerBrake()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            renderer.material.color = Color.red;
            rigidbody.isKinematic = true;

        }

        if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            renderer.material.color = playerCol;
            rigidbody.isKinematic = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(don);
    }
}
