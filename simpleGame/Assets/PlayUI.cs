using UnityEngine;
using System.Collections;

public class PlayUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit = new RaycastHit();
        if(Physics.Raycast(ray,out Hit))
        {
            if(Hit.collider.gameObject.name=="Play")
            {
                Debug.Log("Play");
            }
        }
	}
}
