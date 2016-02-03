using UnityEngine;
using System.Collections;

public class CannonAnimator : MonoBehaviour
{

    public Sprite[] sprites;
    public float framesPerSecond;

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
            audioSource.PlayOneShot(CannonAudioClip, 0.7F);
            playing = true;
        }
    }
}
