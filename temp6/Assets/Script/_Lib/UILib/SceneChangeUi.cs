using UnityEngine;
using UnityEngine.InputSystem;

public class SceneChangeUi : MonoBehaviour
{

    //[SerializeField] GameObject[] BtnList;
    //[SerializeField] string BottuonNameTwo;
    //[SerializeField] string BottuonNameThree;

   // bool isSelect = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    // //   isSelect = false;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    //var time = GameObject.FindGameObjectWithTag("Fade").GetComponent<FadeScene>().fadeWaitTime -= Time.deltaTime;
    //    //if (time > 0) return;


    //    //if (Mouse.current.leftButton.wasPressedThisFrame)
    //    //{
    //    //    Debug.Log("SceneChangeStage1");
    //    //    //ボタンを押したとき遷移
    //    //    //if (selectObj.gameObject.name == btn)
    //    //    //{
    //    //    const float sceneChangeTime = 2f;

    //    //    GameObject.FindGameObjectWithTag("Fade").GetComponent<FadeScene>().
    //    //        SceneFade("Stage1", 0f, sceneChangeTime);

    //    //    var se = GameObject.FindGameObjectWithTag("SoundM").GetComponent<SoundManager>().se.gameObject;
    //    //    var volume = .3f;
    //    //    MyLib.MyPlayOneSound("SE/決定ボタンを押す12", volume, se);

    //    //    // }
    //    //}

    //    //if (Mouse.current.rightButton.wasPressedThisFrame)
    //    //{
    //    //    Debug.Log("SceneChangeStage1");
    //    //    //ボタンを押したとき遷移
    //    //    //if (selectObj.gameObject.name == btn)
    //    //    //{
    //    //    const float sceneChangeTime = 2f;

    //    //    GameObject.FindGameObjectWithTag("Fade").GetComponent<FadeScene>().
    //    //        SceneFade("Title", 0f, sceneChangeTime);

    //    //    var se = GameObject.FindGameObjectWithTag("SoundM").GetComponent<SoundManager>().se.gameObject;
    //    //    var volume = .3f;
    //    //    MyLib.MyPlayOneSound("SE/決定ボタンを押す12", volume, se);
    //    //    return;
    //    //    // }
    //    //}












    //    ////const int LEFT = 0;
    //    ////if (!Input.GetMouseButtonDown(LEFT)) return;
    //    //if (!Mouse.current.leftButton.wasPressedThisFrame) return;



    //    //var selectObj = MyLib.DebugRayViewCameraPosZ();
    //    ////Debug.Log(selectObj);
    //    //if(selectObj==null) return;

    //    //foreach (GameObject btn in BtnList) 
    //    //{
    //    //    ////ボタンを押したとき遷移
    //    //    //if (selectObj.gameObject.name == btn.name)
    //    //    //{
    //    //    //    const float sceneChangeTime = 2f;

    //    //    //    GameObject.FindGameObjectWithTag("Fade").GetComponent<FadeScene>().
    //    //    //        SceneFade(btn.name, 0f, sceneChangeTime);

    //    //    //    var se = GameObject.FindGameObjectWithTag("SoundM").GetComponent<SoundManager>().se.gameObject;
    //    //    //    var volume = .3f;
    //    //    //    MyLib.MyPlayOneSound("SE/決定ボタンを押す12", volume, se);
    //    //    //}
    //    //}

 

    //    //else if (selectObj.gameObject.name == BottuonNameTwo)
    //    //{
    //    //    SelectStart2();
    //    //}

    //    //else if (selectObj.gameObject.name == BottuonNameThree)
    //    //{
    //    //    SelectStart3();
    //    //}

    //}

    public void SceneChangeTrigger(GameObject go)
    {
        const float sceneChangeTime = 2f;

        GameObject.FindGameObjectWithTag("Fade").GetComponent<FadeScene>().
            SceneFade(go.name, 0f, sceneChangeTime);

        var se = GameObject.FindGameObjectWithTag("SoundM").GetComponent<SoundManager>().se.gameObject;
        var volume = .3f;
        MyLib.MyPlayOneSound("SE/決定ボタンを押す12", volume, se);
    }

    //[SerializeField] FadeScene fadeScene;
    //public void SelectStart()
    //{
    //    ///if(isSelect) return;

    //    const float sceneChangeTime = 2f;

    //    GameObject.FindGameObjectWithTag("Fade").GetComponent<FadeScene>().
    //        SceneFade(BottuonNameOne.ToString(), 0f, sceneChangeTime);

    //    var se = GameObject.FindGameObjectWithTag("SoundM").GetComponent<SoundManager>().se.gameObject;
    //    var volume = .3f;
    //    MyLib.MyPlayOneSound("SE/決定ボタンを押す12", volume, se);

    //    //isSelect = true;
    //}

    //public void SelectStart2()
    //{
    //    if (isSelect) return;

    //    const float sceneChangeTime = 2f;

    //    GameObject.FindGameObjectWithTag("Fade").GetComponent<FadeScene>().
    //        SceneFade(BottuonNameTwo.ToString(), 0f, sceneChangeTime);

    //    var se = GameObject.FindGameObjectWithTag("SoundM").GetComponent<SoundManager>().se.gameObject;
    //    var volume = .3f;
    //    MyLib.MyPlayOneSound("SE/決定ボタンを押す12", volume, se);

    //    isSelect = true;
    //}

    //public void SelectStart3()
    //{
    //    if (isSelect) return;

    //    const float sceneChangeTime = 2f;

    //    GameObject.FindGameObjectWithTag("Fade").GetComponent<FadeScene>().
    //    SceneFade(BottuonNameThree.ToString(), 0f, sceneChangeTime);

    //    var se = GameObject.FindGameObjectWithTag("SoundM").GetComponent<SoundManager>().se.gameObject;
    //    var volume = .3f;
    //    MyLib.MyPlayOneSound("SE/決定ボタンを押す12", volume, se);

    //    isSelect = true;
    //}
}
