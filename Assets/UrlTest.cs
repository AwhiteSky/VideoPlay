using System.Collections;
using System.Collections.Generic;
using TMPro;
using UMP;
using UnityEngine;
using UnityEngine.UI;

public class UrlTest : MonoBehaviour
{
    // Start is called before the first frame update

    public UniversalMediaPlayer universalMediaPlayer;

    public TMP_InputField tMP_InputField;

    public InputField inputField;

    public Button playButton;
    public Button stopButton;
    public Button escButton;
    void Start()
    {
        playButton.onClick.AddListener(ChangeUrl);
        escButton.onClick.AddListener(Esc);
        stopButton.onClick.AddListener(StopPlay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeUrl()
    {
        universalMediaPlayer.Path = inputField.text;
        universalMediaPlayer.Play();
    }

    public void StopPlay()
    {

        universalMediaPlayer.Stop();
    }

    public void Esc()
    {
        universalMediaPlayer.Stop();
        Application.Quit();
    }
}
