using UnityEngine;
using UnityEngine.UI;

public class InstrumentChanger : MonoBehaviour {
    private GameObject soundC;
    public AudioClip piano;
    public AudioClip rhodes;
    public AudioClip guitar;

    // Use this for initialization
    void Start () {
        soundC = GameObject.Find("C_src");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void setInstrument()
    {
        var instrumentName = GameObject.Find("Dropdown").GetComponent<Dropdown>().value.ToString();
        switch(instrumentName)
        {
            case "0":
                {
                    soundC.GetComponent<AudioSource>().clip = piano;
                    Debug.Log("Piano choosen");
                    break;
                }
            case "1":
                {
                    soundC.GetComponent<AudioSource>().clip = rhodes;
                    Debug.Log("Rhodes choosen");
                    break;
                }
            case "2":
                {
                    soundC.GetComponent<AudioSource>().clip = guitar;
                    Debug.Log("Guitar choosen");
                    break;
                }
            default:
                {
                    Debug.LogError("Something went wrong " + instrumentName);
                    break;
                }
        }
    }
}
