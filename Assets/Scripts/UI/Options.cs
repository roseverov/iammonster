using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Options : MonoBehaviour {

    public AudioMixer am;
    public Slider sliderVolume;
    public bool isFullScreen = false;
    public Toggle toggleIsFullScreen;
    public Button closeButton;
    

	// Use this for initialization
	void Start () {
        closeButton.onClick.AddListener(Close);
	}
	
	// Update is called once per frame
	void Update () {
        AudioVolume();
        FullScreenToggle();
    }

    public void FullScreenToggle()  {
        isFullScreen = toggleIsFullScreen.isOn;
        Screen.fullScreen = isFullScreen;
    }

    public void AudioVolume()  {
        am.SetFloat("Master", sliderVolume.value);
    }

    public void Close() {
        gameObject.SetActive(false);
    }
}
