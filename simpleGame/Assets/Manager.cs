using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    public AudioSource source;
    public AudioClip[] clips;
    private int coinNnum;
    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayAudio(string name)
    {
        switch (name)
        {
            case "play":
                source.clip = clips[0];
                break;
        }
        source.Play();
    }
}
