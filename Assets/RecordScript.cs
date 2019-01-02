using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class RecordScript : MonoBehaviour
{

    private const int HEADER_SIZE = 44;
    private const short BITS_PER_SAMPLE = 16;
    private const int SAMPLE_RATE = 44100;
    public bool isLoaded = true;

    private bool isRecording = false;
    private AudioRenderer audioRenderer;
    // should this object be rendering to the output stream?
    public bool Rendering = false;

    // the audio stream instance
    private MemoryStream outputStream;
    private BinaryWriter outputWriter;
    private FileStream fileStream;

    private int channels = 2;
    void Start()
    {
        audioRenderer = gameObject.AddComponent(typeof(AudioRenderer)) as AudioRenderer;
    }

    void Update()
    {
        
    }

    public void SwitchRecording()
    {
        if(isRecording)
        {
            Debug.Log("Tried to save");
            //Save(Application.persistentDataPath + "/filename.wav");
            audioRenderer.recOutput = false;
            isRecording = false;
            audioRenderer.WriteHeader();
        }
        else
        {
            Debug.Log("Start recording");
            audioRenderer.recOutput = true;
            isRecording = true;
        }
    }
}