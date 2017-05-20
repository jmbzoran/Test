using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

    public float speed=2;

    public float force = 400;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}

