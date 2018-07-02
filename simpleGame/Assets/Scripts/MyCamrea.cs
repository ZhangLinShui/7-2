using UnityEngine;
using System.Collections;

public class MyCamrea : MonoBehaviour {

    public Transform target;
    private float dist;
    private float angleX;
    private float angleY;
   
    // Use this for initialization
    void Start () {
        Vector3 dir = target.position - this.transform.position;
        dist = dir.magnitude;
        dir.Normalize();
        angleX = this.transform.rotation.eulerAngles.x;
        angleY = this.transform.rotation.eulerAngles.y;
        //arrObject = GameObject.Find("Coin");
       
    }
	
	// Update is called once per frame
	void Update () {
        angleX -= Input.GetAxis("Mouse Y");
        angleY += Input.GetAxis("Mouse X");
        if(Input.GetAxis("Mouse ScrollWheel")<0)
        {
            dist += 0.2f;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            dist -= 0.2f;
        }
        this.transform.rotation = Quaternion.Euler(angleX, angleY, 0);
        this.transform.position = target.position - dist * this.transform.forward;
    }
}
