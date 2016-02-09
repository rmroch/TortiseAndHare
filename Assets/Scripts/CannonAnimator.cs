using UnityEngine;
using System.Collections;

public class CannonAnimator : MonoBehaviour
{

    public Sprite[] sprites;
    public float framesPerSecond;
    public GameObject CannonBallPrefab;
    public float cannonBallSpawnDistance = 10f;

    private SpriteRenderer spriteRenderer;
    private bool playing;
    public AudioClip CannonAudioClip;
    AudioSource audioSource;

	// Use this for initialization
	void Start ()
	{
	    spriteRenderer = GetComponent<Renderer>() as SpriteRenderer;
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (playing)
        {
            int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
            index = index % sprites.Length;
            spriteRenderer.sprite = sprites[index];
            if (index == sprites.Length - 1)
            {
                playing = false;
                index = 0;
            }
        }
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playing = true;
            audioSource.PlayOneShot(CannonAudioClip, 0.7F);

            Vector3 offset = transform.rotation * new Vector3(0, 0.5f, 0);

            Instantiate(CannonBallPrefab, transform.position + offset, transform.rotation);
        }
    }
}
