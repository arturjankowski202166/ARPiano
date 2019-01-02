using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SoundPlayer : MonoBehaviour, IVirtualButtonEventHandler
{
    #region Buttons
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
    public GameObject C2;
    #endregion

    public GameObject soundC;
    int transpose = 36;
    // Use this for initialization
    #region InitButtons
    void Start()
    {
        C = GameObject.Find("C");
        D = GameObject.Find("D");
        E = GameObject.Find("E");
        F = GameObject.Find("F");
        G = GameObject.Find("G");
        H = GameObject.Find("H");
        A = GameObject.Find("A");
        CSharp = GameObject.Find("CS");
        DSharp = GameObject.Find("DS");
        FSharp = GameObject.Find("FS");
        GSharp = GameObject.Find("GS");
        HSharp = GameObject.Find("HS");
        C2 = GameObject.Find("C2");

        soundC = GameObject.Find("C_src");
        C.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        D.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        E.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        F.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        G.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        H.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        A.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        CSharp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        DSharp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        FSharp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        GSharp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        HSharp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        C2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        PlaySound(vb.VirtualButtonName);
    }

    public void PlaySound(string vb)
    {
        GameObject sound = Instantiate(this.soundC);
        Debug.Log(vb);
        switch (vb)
        {
            case "C":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 0 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    break;
                }
            case "D":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 2 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    break;
                }
            case "CS":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 1 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    break;
                }
            case "DS":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 3 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    break;
                }
            case "E":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 4 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    break;
                }
            case "F":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 6 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    break;
                }
            case "G":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 8 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    break;
                }
            case "H":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 10 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    Debug.LogWarning(vb);
                    break;
                }
            case "FS":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 7 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    Debug.LogWarning(vb);
                    break;
                }
            case "GS":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 9 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    Debug.LogWarning(vb);
                    break;
                }
            case "HS":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 11 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogError("DETECT");
                    Debug.LogWarning(vb);
                    break;
                }
            case "A":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 12 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogWarning(vb);
                    Debug.LogError("DETECT");
                    break;
                }
            case "C2":
                {
                    sound.GetComponent<AudioSource>().pitch = Mathf.Pow(1.05946f, 14 + transpose) / 12.0f;
                    sound.GetComponent<AudioSource>().Play();
                    Debug.LogWarning(vb);
                    Debug.LogError("DETECT");
                    break;
                }
        }
    }

    public void NextOctave()
    {
        transpose += 12;
        Debug.Log(transpose);
    }

    public void PreviousOctave()
    {
        transpose -= 12;
        Debug.Log(transpose);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        soundC.GetComponent<AudioSource>().Stop();
        Debug.LogError("DETECTSTOP");
    }
}
