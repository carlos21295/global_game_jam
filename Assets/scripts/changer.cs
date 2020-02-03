using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changer : MonoBehaviour
{
	public marvin marv;
	void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Level1");
        }
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
    }
}