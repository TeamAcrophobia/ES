using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeToScene : MonoBehaviour {

	//changes scene after tap or clicked

    public void changetoScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
	
}
