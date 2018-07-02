using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Cylinder : MonoBehaviour {

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Level1 2");
        }
        this.transform.Rotate(0, 5, 0, Space.World);
    }
}
