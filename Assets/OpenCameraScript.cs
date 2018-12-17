using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenCameraScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseUp()
    {
        SceneManager.LoadScene("PianoScene", LoadSceneMode.Single);
    }
}
