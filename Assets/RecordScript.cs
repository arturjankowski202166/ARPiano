using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordScript : MonoBehaviour
{
    private bool isRecording = false;
    private AudioRenderer audioRenderer;

    void Start()
    {
        audioRenderer = new AudioRenderer();
    }

    public void SwitchRecording()
    {
        if(isRecording)
        {
            Debug.Log(audioRenderer.Save("NewRecord.wav").Message);
            isRecording = false;
        }
        else
        {
            audioRenderer.Clear();
            isRecording = true;
        }
    }
}