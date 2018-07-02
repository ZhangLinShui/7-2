using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube;
    public Camera MyCamera;
    Vector3 vec;
    float Speed, Length;
    Transform Trans;
    // Use this for initialization
    void Start()
    {
        Speed = 0.1f;
        Trans = this.transform;

        vec = Trans.position - MyCamera.transform.position;
        Length = Vector3.Distance(Trans.position, MyCamera.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 vec1;
            vec1 = MyCamera.transform.forward;
            vec1.y = 0;
            vec1 = vec1.normalized;
            Trans.position += vec1 * Speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 vec1;
            vec1 = MyCamera.transform.forward;
            vec1.y = 0;
            vec1 = vec1.normalized;
            Trans.position -= vec1 * Speed;
        }
    }
}
