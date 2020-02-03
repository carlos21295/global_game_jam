using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insecto : MonoBehaviour
{
    // Start is called before the first frame update
	public desactivator desactivatorScript;
	public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void OnCollisionEnter2D (Collision2D choque)
	{
		if (choque.gameObject.tag == "Player" && desactivatorScript.players[1].GetComponent<player>().enabled == enabled)
		{
			Application.LoadLevel("Level1");
		}
		if (choque.gameObject.tag == "Player" && desactivatorScript.players[0].GetComponent<player>().enabled == enabled)
		{
			source.enabled = false;
			Destroy(gameObject);
		}
	}
}
