using UnityEngine;
using System.Collections;

public class BackCube : MonoBehaviour {
   
    bool flag;
    bool ifMove;
    float wait;
    Vector3 vec1;
    Vector3 pos;
    /*************While****************/
    float TempPos;
    bool IsWait;
    /*************While****************/
    // Use this for initialization
    void Start () {
        flag = false;
        vec1 = this.transform.right;
        vec1.Normalize();
        TempPos = this.transform.position.x;
        ifMove = true;
        wait = 2.0f;

        pos = this.transform.position;
        IsWait = false;
        StartCoroutine("WaitWhile", 2.0f);
    }
	
	// Update is called once per frame
	//void Update () {

 //       if (ifMove)
 //       {
 //           if (flag)
 //           {
 //               this.transform.position -= vec1 * 0.02f;
 //           }
 //           else
 //           {
 //               this.transform.position += vec1 * 0.02f;
 //           }
 //       }
 //       move();
 //   }
    public void move()
    {
        if (this.transform.position.x >= TempPos&&ifMove)
        {
            ifMove = false;
            StartCoroutine(WaitAndChange(wait));
            flag = true;
        }
        if (this.transform.position.x <= -7.4&&ifMove)
        {
            ifMove = false;
            StartCoroutine(WaitAndChange(wait));
            flag = false;
        }
    }
    private IEnumerator WaitAndChange(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ifMove = true;
    }

    private IEnumerator WaitWhile(float WaitTime)
    {
        while(true)
        {
            if (transform.position.x >= TempPos || transform.position.x <= -7.4f)
            {
                IsWait = true;
                yield return new WaitForSeconds(2.0f);
            }
            else
                yield return null;
            if(!IsWait)
            {

            }
        }
    }
}
