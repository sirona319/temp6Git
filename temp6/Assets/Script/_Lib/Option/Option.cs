using Unity.VectorGraphics;
using UnityEngine;

public class Option : MonoBehaviour
{

    public void ResetBtn()
    {

        Screen.SetResolution(
            1280, 720, false);


        GetComponent<SoundOption>().Reset();

        PlayerPrefs.DeleteAll();
    }

    public void End()
    {
        //Escが押された時
        //if (Keyboard.current.escapeKey.wasPressedThisFrame)
        //{


#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
        // }
    }
}
