using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Container/SoundTrack")]
public class SoundTrack : ScriptableObject
{
    public bool isPlaying;
    public int nowBGMIndex = 0;
    public List<AudioClip> bgms;

    public AudioClip GetMusic()
    {
        AudioClip bgm = bgms[nowBGMIndex];
        nowBGMIndex++;
        return bgm;
    }

    public void ResetTrack()
    {
        isPlaying = false;
        nowBGMIndex = 0;
    }
}
