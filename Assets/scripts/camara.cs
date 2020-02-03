using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class camara : MonoBehaviour
{
    Transform target;
	public GameObject[] players;
	public bool enabled;
public AudioClip[] clip;
	public AudioSource source;
    // Start is called before the first frame update
	void Awake()
	{
		source = GetComponent<AudioSource>();		
	}    
	void start () 
	{
        target = players[1].GetComponent<player>().transform;
		source.clip = clip[0];
		source.Play();
    }
    // Update is called once per frame
    void Update()
    {
		if (players[0].GetComponent<player>().enabled == !enabled)
			target = players[0].GetComponent<player>().transform;
		if (players[1].GetComponent<player>().enabled == !enabled)
			target = players[1].GetComponent<player>().transform;
        transform.position = new Vector3(
            target.position.x,
            target.position.y,
            transform.position.z
        );
    }

	public void music_swap()
	{
		if (source.clip == clip[1])
			source.clip = clip[0];
		else
			source.clip = clip[1];
		source.Play();
	}
}