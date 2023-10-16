using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaker : MonoBehaviour
{
    public int firstPlayTrackIndex;
    public List<SoundTrack> tracks = new List<SoundTrack>();
    private AudioSource audioSource;
    private int playingTrackIndex;
    private Coroutine playTrackCoroutine;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        PlayTrack(firstPlayTrackIndex);
    }

    public void PlayTrack(int _trackIndex)
    {
        audioSource.Stop();
        if (tracks[playingTrackIndex].isPlaying)
            tracks[playingTrackIndex].ResetTrack();

        playingTrackIndex = _trackIndex;
        SoundTrack track = tracks[playingTrackIndex];
        track.isPlaying = true;
        audioSource.clip = track.GetMusic();
        audioSource.Play();
        playTrackCoroutine = StartCoroutine(PlayTrackRoutine(audioSource.clip.length));
    }

    public IEnumerator PlayTrackRoutine(float _musicTime)
    {
        yield return new WaitForSeconds(_musicTime);
        audioSource.Stop();
        audioSource.clip = tracks[playingTrackIndex].GetMusic();
        audioSource.Play();
        playTrackCoroutine = StartCoroutine(PlayTrackRoutine(audioSource.clip.length));
    }

    public void StopTrack()
    {
        audioSource.Stop();
        audioSource.clip = null;
        if (tracks[playingTrackIndex].isPlaying)
            tracks[playingTrackIndex].ResetTrack();
        playingTrackIndex = 0;
    }
}
