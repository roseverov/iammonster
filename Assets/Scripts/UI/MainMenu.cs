using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Button playButton;
    public Button optionsButton;
    public Button quitButton;
    public Canvas options;
    public Logger logger;
    private AsyncOperation async = null;
    private bool isLoading = false;
    public Canvas loading;
    public Slider loadingSlider;
    public Text loadingText;

	// Use this for initialization
	void Start () {
        quitButton.onClick.AddListener(Quit);
        playButton.onClick.AddListener(Play);
        optionsButton.onClick.AddListener(Options);
	}
	
	// Update is called once per frame
	void Update () {
        if (isLoading)  {
            Debug.Log(string.Format("Loading {0}%", async.progress * 100));
            loadingSlider.value = async.progress * 100;
            loadingText.text = string.Format("Loading {0}%", async.progress * 100);

        }
	}

    private void Quit() {
        Debug.Log("Pressed button Quit");
        Application.Quit();
    }

    private void Play()  {
        Debug.Log("Pressed button Play");
        gameObject.SetActive(false);
        loading.gameObject.SetActive(true);
        isLoading = true;
        async = SceneManager.LoadSceneAsync("MainCharacterGame");
    }

    private void Options()  {
        Debug.Log("Pressed button Options");
        options.gameObject.SetActive(true);
    }

}
