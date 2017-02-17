using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

#if WINDOWS_UWP
using Windows.System;
using System.Threading.Tasks;
#endif


public class StartBrowser : MonoBehaviour {
    // public string uriToLaunch = @"http://www.google.com";
    // var uri = new Uri(uriToLaunch);

    public Button myButton;
    public string uri;

	// Use this for initialization
	void Start () {
        Button btn = myButton.GetComponent<Button>();
#if WINDOWS_UWP
        btn.onClick.AddListener(TaskOnTap);
#endif
	}

#if WINDOWS_UWP
    private async void TaskOnTap()
    {
        Debug.Log("You clikced on the button.");

        // The URI to launch
        var uriBing = new Uri(@uri);

        // Launch the URI
        var success = await Windows.System.Launcher.LaunchUriAsync(uriBing);

        if (success)
        {
           // URI launched
        }
        else
        {
           // URI launch failed
        }

    }
#endif


    // Update is called once per frame
    void Update () {
		
	}

    private void OnClick()
    {

    }
}
