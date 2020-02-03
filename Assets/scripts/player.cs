using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
	public float speed = 4f;
	public float timer = 10f; //Tiempo de acción
    public Text uiText; //Canvas de texto que hay que pasar
	Vector3 mov;
	private Animator anim;
	public desactivator desactivator;
	public marvin marv;

    // Starts called before the first frame update
	void Start()
    {
		anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
		if(timer > 0.0f && desactivator.enabled == true)
        {
			uiText.GetComponent<Text>().enabled = enabled;
           	transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, speed * Time.deltaTime);
            timer -= Time.deltaTime;
			anim.SetFloat("movX", mov.x);
			anim.SetFloat("movY", mov.y);
			uiText.text = timer.ToString("F");
			if (timer <= 0.02f)
				Application.LoadLevel("Level1");
        }
		else if (desactivator.enabled == false)
		{
			transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, speed * Time.deltaTime);
			anim.SetFloat("movX", mov.x);
			anim.SetFloat("movY", mov.y);
			uiText.GetComponent<Text>().enabled = !enabled;
		}
		if(marv.renderer == true && Input.GetKeyDown(KeyCode.Return))
		{
            SceneManager.LoadScene("intro");
        }
    }
	void OnCollisionEnter2D(Collision2D muro)
	{
		if (muro.gameObject.tag == "wall")
		{
			
		}
	}

}
