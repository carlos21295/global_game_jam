using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class marvin : MonoBehaviour
{
    // Start is called before the first frame update
	public	GameObject[] repair;
	public	SpriteRenderer renderer;
	public	bool	enabled;

	public	Image	uiImage;
	public	Image	press;

    void Start()
    {
        renderer = repair[2].GetComponent<SpriteRenderer>();
		renderer.enabled = false;
		press.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

		void OnCollisionEnter2D (Collision2D choque)
	{
		if (choque.gameObject.tag == "Player" && uiImage.GetComponent<Image>().enabled == true)
		{
			renderer.enabled = true;
			uiImage.GetComponent<Image>().enabled = false;
			press.GetComponent<Image>().enabled = true;

		}
	}

}
