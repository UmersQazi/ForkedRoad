using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinVolume : MonoBehaviour
{
    [SerializeField] AudioClip winSFX = null;
    [SerializeField] string winText = "You Win!";
    UIController uIController;
    AudioSource audioSource = null;
    private void Awake()
    {
        uIController = FindObjectOfType<UIController>();
        audioSource = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        if(uIController != null)
        {
            uIController.ShowWinText(winText);
            PlayFeedback();
        }
        
    }

    void PlayFeedback()
    {
        if (audioSource != null && winSFX != null) {
            audioSource.clip = winSFX;
            audioSource.Play();
        }
    }
}
