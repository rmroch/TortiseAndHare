using UnityEngine;
using System.Collections;

public class CheckHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.LogWarning(col.gameObject.name);
        if (col.gameObject.name == "CannonBall")
        {
            Destroy(col.gameObject);
            Destroy(this);
        }
    }
}
