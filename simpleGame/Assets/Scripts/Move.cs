using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public GameObject cube;
    public Camera MyCamera;
    Color col1,col2;
    Material Material1, Material2;
    Renderer RenderR;
    float a;
    int b;
    // Use this for initialization
    void Start () {
        RenderR = this.GetComponent<Renderer>();
        Material1 = this.GetComponent<Renderer>().materials[0];
        Material2 = this.GetComponent<Renderer>().materials[1];
        col1 = Material1.GetColor("_Color");
        col2 = Material2.GetColor("_Color");
        a = 0f;
        b = 0;
    }

    // Update is called once per frame
    void Update () {
       //cube.transform.rotation *= Quaternion.Euler(0, 5, 0);
        if (Input.GetKey(KeyCode.A)){
            cube.transform.rotation *= Quaternion.Euler(0, 5, 0);
        }
        if(Input.GetKey(KeyCode.D)){
            cube.transform.Rotate(Vector3.up, -5, Space.Self);
        }
        if (Input.GetKey(KeyCode.W))
        {
            cube.transform.position += MyCamera.transform.forward *0.04f;
            MyCamera.transform.position += MyCamera.transform.forward * 0.04f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            cube.transform.position += MyCamera.transform.forward * -0.04f;
            MyCamera.transform.position += MyCamera.transform.forward * -0.04f;
        }
        if(Input.GetKey(KeyCode.F))
        {
            a += 0.1f;
            Material1.SetTextureOffset("_MainTex", new Vector2(a, 0));
            Material2.SetTextureOffset("_MainTex", new Vector2(a, 0));
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            b++;
            if(b%2==0)
            {
                RenderR.material = Material1;
            }
            else
                RenderR.material = Material2;
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            b++;
            if (b % 2 == 0)
            {
                Material1.SetColor("_Color", col1);
                Material2.SetColor("_Color", col2);
            }
            else
            {
                Material1.SetColor("_Color", new Color(0, 255, 0, 255));
                Material2.SetColor("_Color", new Color(0, 0, 255, 255));

            }
        }
        if (b > 100)
            b = 0;
        if (a > 100)
            a = 0;
    }
}
