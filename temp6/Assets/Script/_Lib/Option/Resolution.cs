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



    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            // 例: 1280x720のウィンドウモードで実行する場合
            Screen.SetResolution(816, 624, false);
            UnityEngine.Debug.Log("win 816×624");
        }

        if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            // 例: 1280x720のウィンドウモードで実行する場合
            Screen.SetResolution(1280, 720, false);
            UnityEngine.Debug.Log("win 1280");
        }

        if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            // 例: 1920x1080のフルスクリーンで実行する場合
            Screen.SetResolution(1920, 1080, true);
            UnityEngine.Debug.Log("full 1920");
        }
    }
}
