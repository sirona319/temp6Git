using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Resolution : MonoBehaviour
{

    // メソッドの戻り値は void である必要があります
    //[Conditional("UNITY_EDITOR")]
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int fullsc = PlayerPrefs.GetInt("ResoFull",0);
        bool isFull = true;
        if (fullsc == 0) isFull = false;

        Screen.SetResolution(
            PlayerPrefs.GetInt("ResoW", 1280), PlayerPrefs.GetInt("ResoH", 720), isFull);


    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Keyboard.current.digit1Key.wasPressedThisFrame)
    //    {

    //        // 例: 816×624のウィンドウモードで実行する場合
    //        Screen.SetResolution(816, 624, false);
    //        UnityEngine.Debug.Log("win 816×624");

    //        PlayerPrefs.SetInt("ResoW", 816);
    //        PlayerPrefs.SetInt("ResoH", 624);
    //        PlayerPrefs.GetInt("ResoFull", 0);

    //        PlayerPrefs.Save();
    //    }

    //    if (Keyboard.current.digit2Key.wasPressedThisFrame)
    //    {
    //        // 例: 1280x720のウィンドウモードで実行する場合
    //        Screen.SetResolution(1280, 720, false);
    //        UnityEngine.Debug.Log("win 1280");

    //        PlayerPrefs.SetInt("ResoW", 1280);
    //        PlayerPrefs.SetInt("ResoH", 720);
    //        PlayerPrefs.GetInt("ResoFull", 0);

    //        PlayerPrefs.Save();
    //    }

    //    if (Keyboard.current.digit3Key.wasPressedThisFrame)
    //    {
    //        // 例: 1920x1080のフルスクリーンで実行する場合
    //        Screen.SetResolution(1920, 1080, true);
    //        UnityEngine.Debug.Log("full 1920");

    //        PlayerPrefs.SetInt("ResoW", 1920);
    //        PlayerPrefs.SetInt("ResoH", 1080);
    //        PlayerPrefs.GetInt("ResoFull", 1);

    //        PlayerPrefs.Save();
    //    }
    //}


    public void Resolution816()
    {
        Screen.SetResolution(816, 624, false);
        UnityEngine.Debug.Log("win 816×624");

        PlayerPrefs.SetInt("ResoW", 816);
        PlayerPrefs.SetInt("ResoH", 624);
        PlayerPrefs.GetInt("ResoFull", 0);

        PlayerPrefs.Save();
    }

    public void Resolution1280()
    {
        // 例: 1280x720のウィンドウモードで実行する場合
        Screen.SetResolution(1280, 720, false);
        UnityEngine.Debug.Log("win 1280");

        PlayerPrefs.SetInt("ResoW", 1280);
        PlayerPrefs.SetInt("ResoH", 720);
        PlayerPrefs.GetInt("ResoFull", 0);

        PlayerPrefs.Save();
    }

    public void Resolution1920()
    {
        // 例: 1920x1080のフルスクリーンで実行する場合
        Screen.SetResolution(1920, 1080, true);
        UnityEngine.Debug.Log("full 1920");

        PlayerPrefs.SetInt("ResoW", 1920);
        PlayerPrefs.SetInt("ResoH", 1080);
        PlayerPrefs.GetInt("ResoFull", 1);

        PlayerPrefs.Save();
    }
}
