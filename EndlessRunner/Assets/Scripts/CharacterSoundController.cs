using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip scoreHighlight;
    public AudioClip gameOverSound;

    private AudioSource audioPlayer;

    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }

    public void PlayGameOverSound()
    {
        audioPlayer.PlayOneShot(gameOverSound);
    }

    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }
}
