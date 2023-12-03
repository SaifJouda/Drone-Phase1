using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using TMPro;

public class SettingsBehaviour : MonoBehaviour
{
    public Slider audioSlider;
    public Toggle fullscreenToggle;
    public TMP_Dropdown resolutionDropdown;

    public AudioSource droneSFX;

    private string dataFilePath;
    private int line = -1;
    private List<string> fileLines;

    // Start is called before the first frame update
    void Start()
    {
        dataFilePath = Application.streamingAssetsPath + "/GameSettings.txt";

        //Create file if not already exist
        if (!File.Exists(dataFilePath))
        {
            File.WriteAllText(dataFilePath, "audio=1\nfullscreen=1\nresolution=native");
            fileLines = File.ReadAllLines(dataFilePath).ToList();
        }
        else
        {
            // read all data from file to a list
            fileLines = File.ReadAllLines(dataFilePath).ToList();

        }

        audioSlider.onValueChanged.AddListener(delegate { ChangeAudioLevel(audioSlider, droneSFX); });
        resolutionDropdown.onValueChanged.AddListener(delegate { ChangeResolution(resolutionDropdown); });
        fullscreenToggle.onValueChanged.AddListener(delegate { ChangeScreenSize(fullscreenToggle); });
    }

    private void ChangeAudioLevel(Slider slider, AudioSource audio)
    {
        audio.volume = slider.value;
        WriteToFileFloat("audio", slider.value);
        
    }

    private void ChangeScreenSize(Toggle toggle)
    {
        if (toggle.isOn)
        {
            ChangeResolution(resolutionDropdown, true);
            WriteToFileFloat("fullscreen", 1);
            Debug.Log("FullScreen Mode");
        }
        else
        {
            ChangeResolution(resolutionDropdown, false);
            WriteToFileFloat("fullscreen", 0);
            Debug.Log("Not FullScreen Mode");
        }
    }

    private void ChangeResolution(TMP_Dropdown dropdown, bool? isFullscreen = null)
    {
        int index = dropdown.value;
        if (isFullscreen == null)
        {
            isFullscreen = Screen.fullScreen;
        }
        // shouldn't be null anymore, but default to true if it is
        bool isFullscreenBool = isFullscreen ?? true;

        if (index == 0)
        {
            Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, isFullscreenBool);
        }
        else if (index == 1)
        {
            Screen.SetResolution(3840, 2160, isFullscreenBool);
        }
        else if (index == 2)
        {
            Screen.SetResolution(2560, 1440, isFullscreenBool);
        }
        else if (index == 3)
        {
            Screen.SetResolution(1920, 1080, isFullscreenBool);
        }
        else if (index == 4)
        {
            Screen.SetResolution(1280, 720, isFullscreenBool);
        }

        WriteToFileString("resolution", dropdown.options[dropdown.value].text);
    }

    private void WriteToFileFloat(string setting, float value)
    {
        // get the line of which contains the setting type
        for (var i = 0; i < fileLines.Count; i++)
        {
            if (fileLines[i].Contains(setting))
            {
                line = i;
                break;
            }
        }

        // if line is valid, meaning setting type is in file
        if (line >= 0)
        {
            fileLines[line] = setting + "=" + value;
            File.WriteAllLines(dataFilePath, fileLines);
        }

    }

    private void WriteToFileString(string setting, string value)
    {
        // get the line of which contains the setting type
        for (var i = 0; i < fileLines.Count; i++)
        {
            if (fileLines[i].Contains(setting))
            {
                line = i;
                break;
            }
        }

        // if line is valid, meaning setting type is in file
        if (line >= 0)
        {
            fileLines[line] = setting + "=" + value;
            File.WriteAllLines(dataFilePath, fileLines);
        }

    }
}
