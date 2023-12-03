using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System.Linq;
using System.Globalization;
using TMPro;

public class SettingsInitialization : MonoBehaviour
{
    public Slider audioSlider;
    public Toggle fullscreenToggle;
    public TMP_Dropdown resolutionDropdown;

    public AudioSource droneSFX;

    private string dataFilePath;
    private int line = -1;
    private List<string> fileLines;
    private bool isFullscreen = true;

    // Start is called before the first frame update
    void Awake()
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

        // Add resolution options
        resolutionDropdown.options.Clear();

        List<string> resolutions = new List<string>();
        resolutions.Add("native");
        resolutions.Add("3840x2160");
        resolutions.Add("2560x1440");
        resolutions.Add("1920x1080");
        resolutions.Add("1280x720");

        foreach (var resolution in resolutions)
        {
            resolutionDropdown.options.Add(new TMP_Dropdown.OptionData() { text = resolution });
        }

        // loop through and set all the game settings
        for (var i = 0; i < fileLines.Count; i++)
        {
            if (fileLines[i].Contains("audio"))
            {
                audioSlider.value = float.Parse(fileLines[i].Substring(fileLines[i].IndexOf("=") + 1), CultureInfo.InvariantCulture.NumberFormat);
                droneSFX.volume = audioSlider.value;
            }
            else if (fileLines[i].Contains("fullscreen"))
            {
                int mode = int.Parse(fileLines[i].Substring(fileLines[i].IndexOf("=") + 1));

                if (mode > 0)
                {
                    fullscreenToggle.isOn = true;
                    isFullscreen = true;
                }
                else
                {
                    fullscreenToggle.isOn = false;
                    isFullscreen = false;
                }
            }
            else if (fileLines[i].Contains("resolution"))
            {
                string selectedResolution = fileLines[i].Substring(fileLines[i].IndexOf("=") + 1);

                if (selectedResolution == "native")
                {
                    Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, isFullscreen);
                    resolutionDropdown.value = 0;
                }
                else if (selectedResolution == "3840x2160")
                {
                    Screen.SetResolution(3840, 2160, isFullscreen);
                    resolutionDropdown.value = 1;
                }
                else if (selectedResolution == "2560x1440")
                {
                    Screen.SetResolution(2560, 1440, isFullscreen);
                    resolutionDropdown.value = 2;
                }
                else if (selectedResolution == "1920x1080")
                {
                    Screen.SetResolution(1920, 1080, isFullscreen);
                    resolutionDropdown.value = 3;
                }
                else if (selectedResolution == "1280x720")
                {
                    Screen.SetResolution(1280, 720, isFullscreen);
                    resolutionDropdown.value = 4;
                }
            }

        }
    }
}
