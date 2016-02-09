using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour
{

    public int health = 1;

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2d()
    {
        Debug.Log("Trigger!");

        health--;
    }

	// Update is called once per frame
	void Update () {

        if (health <= 0)
        {
            Die();
        }
	}

    void Die()
    {
        Destroy(gameObject);
    }
}
