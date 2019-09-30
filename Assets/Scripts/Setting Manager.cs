using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingManager : MonoBehaviour
{
    public Toggle toggle;
    public Text ScreenResoultion;
    public Text Volume;
    public Resolution[] resolutions;
    public Gamesettings gamesettings;
    public GameObject Arrow; 
    public void OnEnable()
    {
        //ScreenResoultion =toggle.getValue. AddListenner(delegate { OnScreenChange(); }); 
        gamesettings = new Gamesettings();
        resolutions = Screen.resolutions;
    }
    public void  OnScreenChange()
    {

    }
   

}