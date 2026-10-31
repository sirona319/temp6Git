using DG.Tweening;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngine.UI;

public class SoundManager : Singleton<SoundManager>
{
    public enum BGMType
    {
        easy,
        normal,
        hard,
    }

    AudioMixer audioMixer;

    //bool isSoundOn = true;
    [SerializeField] float bgmVol=.03f;
    [SerializeField] AudioMixerGroup targetMixerGroup;
    [SerializeField]AudioClip[] clipList;
    [SerializeField] List<AudioSource> sourceLists=new ();
    //[SerializeField] private AudioSource gameBGM;
   // [SerializeField] private AudioSource titleBGM;
    [SerializeField] public AudioSource se;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        foreach (AudioClip clip in clipList)
        {

            //var source = gameObject.AddComponent<AudioSource>();

            var source = gameObject.AddComponent<AudioSource>();

            source.clip = clip;
            source.volume = 0;
            source.outputAudioMixerGroup = targetMixerGroup;
            source.playOnAwake = false;
            sourceLists.Add(source);
            //DontDestroyOnLoad(this.gameObject);
        }

    }
    void Start()
    {


        
        audioMixer = Resources.Load<AudioMixer>("AudioMixer");

        if (!audioMixer)
            audioMixer = Resources.Load<AudioMixer>("NewAudioMixer");
            //オーディオミキサーはResourcesフォルダに作成する
            //Debug.Log(audioMixer);

            if (!audioMixer)
        Debug.Log("オーディオミキサーが存在しない");



        //sourceLists[0].Play();
    }

    public void BgmChange(AudioClip clip)
    {
        const float OUTTIME = 0.3f;
        const float INTIME = 2f;
        //const float VOLUME = 0.03f;
        //Debug.Log(sourceLists[0].name);
        foreach (AudioSource sl in sourceLists)
        {
            sl.DOKill();
            if (sl.clip == clip)
            {
                sl.Play();
                sl.DOFade(bgmVol, INTIME);
                Debug.Log("testplayBGM");
            }
            else
            {
                if (sl.isPlaying)
                    sl.DOFade(0f, OUTTIME).OnComplete(() => sl.Stop());
                //sl.mute = true;
                //Debug.Log("test");
            }
            //Debug.Log("sss");
        }
       // Debug.Log(clip.name);
    }

    public void SetSoundMaster(float value)
    {
        // if (audioMixer == null) audioMixer = Resources.Load<AudioMixer>("AudioMixer");

        //フェード機能が欲しい


        //const float volumeMin = 80f;
        audioMixer.SetFloat("MasterVolume", value);
        //isSoundOn = false;
        
        //else
        //{
        //    const float volumeMax = 0f;
        //    audioMixer.SetFloat("MasterVolume", -volumeMax);
        //    //isSoundOn = true;
        //    Debug.Log("サウンドオフ");
        //}

    }

    //public void SetSoundSE(float value)
    //{
    //    //if (audioMixer == null) audioMixer = Resources.Load<AudioMixer>("AudioMixer");

    //    audioMixer.SetFloat("SEVolume", value);

    //}

    //public void SetSoundSEOff()
    //{
    //    //if (audioMixer == null) audioMixer = Resources.Load<AudioMixer>("AudioMixer");

    //    const float volumeMin = -80f;
    //    audioMixer.SetFloat("SEVolume", volumeMin);

    //}

    public void BgmChange(BGMType type)
    {
        //ボリュームを下げていって　切り替える





        //const float OUTTIME = 0.3f;
        //const float INTIME = 2f;
        //const float VOLUME = 0.1f;
        //if (type == BGMType.title)
        //{


        //   // titleBGM.DOFade(VOLUME, INTIME);
        //    //gameBGM.DOFade(0f, OUTTIME);
        //    //const float TARGETVOLUME = 0.04f;
        //    //StartCoroutine(SoundFadeOnCoroutine(TARGETVOLUME, aquaBGM));
        //    //StartCoroutine(SoundFadeOffCoroutine(groundBGM, 0.0001f));
        //}
        //else if (type == BGMType.game)
        //{
        //   // titleBGM.DOFade(0f, OUTTIME);
        //    //gameBGM.DOFade(VOLUME, INTIME);
        //    //StartCoroutine(SoundFadeOffCoroutine(aquaBGM));
        //    //const float TARGETVOLUME = 0.01f;
        //    //StartCoroutine(SoundFadeOnCoroutine(TARGETVOLUME, groundBGM, 0.0001f));
        //}
    }

    public IEnumerator SoundFadeOffCoroutine(AudioSource audio, float fadeSpeed = 0.001f)
    {

        while (audio.volume > 0)
        {
            audio.volume -= fadeSpeed;
            yield return new WaitForSeconds(0.1f);
        }

    }
}
