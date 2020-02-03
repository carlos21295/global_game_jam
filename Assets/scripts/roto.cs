using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roto : MonoBehaviour
{
    // Start is called before the first frame update
 	public Sprite[] sprite;
	private bool enabled;
	public SpriteRenderer spriteRenderer;
	public Collider2D collision;
	public desactivator desactivatorScript;
	public AudioClip clip;
	public AudioSource source;
    // Start is called before the first frame update
	void Awake()
	{
		source = GetComponent<AudioSource>();		
	}   
    void Start()
    {
		spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
		collision = gameObject.GetComponent<Collider2D>();
		spriteRenderer.sprite = sprite[0];
		source.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {

    }
	void OnCollisionEnter2D (Collision2D choque)
	{
		if (choque.gameObject.tag == "Player" && desactivatorScript.players[1].GetComponent<player>().enabled == true)
		{
		Debug.Log("hola");

			spriteRenderer.sprite = sprite[1];
			collision.isTrigger = true;
			source.PlayOneShot(source.clip);
		}
	}

	void OnTriggerExit2D (Collider2D choque)
	{
		if (choque.gameObject.tag == "Player" && desactivatorScript.players[0].GetComponent<player>().enabled == true)
		{
			spriteRenderer.sprite = sprite[0];
			collision.isTrigger = false;
		}
	}
	public void	destroy()
	{
		this.spriteRenderer.sprite = sprite[1];
	}
	public void	fix()
	{
		spriteRenderer.sprite = sprite[0];
	}
}
