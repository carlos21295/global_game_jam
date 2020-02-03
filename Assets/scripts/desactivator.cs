using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivator : MonoBehaviour
{
	public bool enabled;
	public GameObject[] players;

	public camara camara;
	public	player player;
    // Start is called before the first frame update

    void Start()
    {
		enabled = false;
		//camera = GetComponent<Camera>().gameObject.GetComponent<Camera>();
		players[0].GetComponent<player>().enabled = enabled;
		players[1].GetComponent<player>().enabled = !enabled;
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.P))
		{
			camara.music_swap();
			enabled = !enabled;
			players[0].GetComponent<player>().enabled = enabled;
			players[1].GetComponent<player>().enabled = !enabled;
			player.timer = 15f;
		}
    }
}
