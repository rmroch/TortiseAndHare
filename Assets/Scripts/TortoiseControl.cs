using UnityEngine;
using System.Collections;

public class TortoiseControl : MonoBehaviour {
    public float speed = 1.0f;
    public float rotSpeed = 10.0f;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(-transform.up);
        }
	}
}
