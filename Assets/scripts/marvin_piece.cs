using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class marvin_piece : MonoBehaviour
{
    // Start is called before the first frame update
	public Image uiImage;
    void Start()
    {
		uiImage.GetComponent<Image>().enabled = !enabled;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnCollisionEnter2D (Collision2D choque)
	{
		if (choque.gameObject.tag == "Player")
		{
			uiImage.GetComponent<Image>().enabled = enabled;
			Destroy(this.gameObject);
		}
	}
}
