using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SoundPlayer : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject F;
    public GameObject G;
    public GameObject H;
    public GameObject A;
    public GameObject CSharp;
    public GameObject DSharp;
    public GameObject FSharp;
    public GameObject GSharp;
    public GameObject HSharp;

    public GameObject soundC;
    int transpose = 36;
    // Use this for initialization
    void Start()
    {
        C = GameObject.Find("C");
        D = GameObject.Find("D");
        E = GameObject.Find("E");
        F = GameObject.Find("F");
        G = GameObject.Find("G");
        H = GameObject.Find("H");
        A = GameObject.Find("A");
        CSharp = GameObject.Find("C#");
        DSharp = GameObject.Find("D#");
        FSharp = GameObject.Find("F#");
        GSharp = GameObject.Find("G#");
        HSharp = GameObject.Find("H#");

        soundC = GameObject.Find("C_src");
        C.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        D.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        E.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        F.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        G.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        H.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        A.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Debug.Log("started lololol");
        Debug.Log(C.ToString());
        Debug.Log(soundC.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        //switch(
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        AudioSource newsoundC = GameObject.Instantiate(soundC).GetComponent<AudioSource>();
        float counter = 0;
        float waitTime = 1;
        while (counter < waitTime)
        {

            counter += Time.deltaTime;
        }
        switch (vb.VirtualButtonName)
        {
        case "C":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 0+transpose) / 12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                Debug.LogError("DETECT");
                break;
            }
        case "D":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f,2 + transpose) /12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    break;
            }
        case "C#":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 1 + transpose) / 12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                Debug.LogError("DETECT");
                break;
            }
        case "D#":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 3 + transpose) / 12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                Debug.LogError("DETECT");
                break;
            }
        case "E":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 4 + transpose) / 12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    break;
            }
        case "F":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 6 + transpose) / 12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    break;
            }
        case "G":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 8 + transpose) / 12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                Debug.LogError("DETECT");
                break;
            }
        case "H":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 10 + transpose) / 12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                Debug.LogError("DETECT");
                break;
            }
        case "F#":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 7 + transpose) / 12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                Debug.LogError("DETECT");
                break;
            }
        case "G#":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 9 + transpose) / 12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                Debug.LogError("DETECT");
                break;
            }
        case "H#":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 11 + transpose) / 12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                Debug.LogError("DETECT");
                break;
            }
        case "A":
            {
                    newsoundC.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 12 + transpose) / 12.0f;
                    newsoundC.GetComponent<AudioSource>().Play();
                Debug.LogError("DETECT");
                break;
            }
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        soundC.GetComponent<AudioSource>().Stop();
        Debug.LogError("DETECTSTOP");
    }
}
