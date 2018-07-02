using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SphereScript : MonoBehaviour
{

    private GameObject camera1;
    private Rigidbody rigiBody;
    private GameObject[] arrObject;
    private int Conut;
    // Use this for initialization
    void Start()
    {
        camera1 = GameObject.Find("Main Camera");
        if (!camera1)
        {
            Debug.Log("获取相机错误");
        }
        rigiBody = this.GetComponent<Rigidbody>();

        arrObject = GameObject.FindGameObjectsWithTag("Coin");
        Conut = arrObject.Length;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forwardDir = camera1.transform.forward;
        forwardDir.y = 0;
        forwardDir.Normalize();
        rigiBody.AddForce((Input.GetAxis("Horizontal") * camera1.transform.right + Input.GetAxis("Vertical") * forwardDir)*7 );

        
    }

    public void OnTriggerEnter(Collider other)//穿透
    {
        if (other.gameObject.tag == "Coin")
        {
            DestroyObject(other.gameObject);
            Conut--;
        }
        
    }

    public void OnCollisionEnter(Collision collision)//不穿透
    {
        
        string SceneName = SceneManager.GetActiveScene().name;
        if (collision.gameObject.tag == "Door" && Conut == 0)
        {
            switch (SceneName)
            {
                case "Level1 1":
                    SceneManager.LoadScene("Level1 2");
                    break;
                case "Level1 2":
                    SceneManager.LoadScene("Level1 3");
                    break;
                case "Level1 3":
                    SceneManager.LoadScene("Level1 4");
                    break;
                case "Level1 4":
                    SceneManager.LoadScene("Level1 5");
                    break;
                case "Level1 5":
                    SceneManager.LoadScene("Level1 6");
                    break;
                case "Level1 6":
                    //SceneManager.LoadScene("Level1 1");
                    Debug.Log("游戏结束");
                    break;
            }

            
        }
    }
}
