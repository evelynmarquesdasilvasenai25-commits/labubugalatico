using UnityEngine;
using UnityEngine.InputSystem.Utilities;
using NUnit.Framework;
using System.ComponentModel.Design.Serialization;
using System.Collections.Generic;

public class veiaaudio : MonoBehaviour
{
    [SerializeField] AudioSource wooshSource;
    [SerializeField] AudioClip wooshChute1;
    [SerializeField] AudioSource stepSource;
    [SerializeField] AudioClip step1;
    [SerializeField] List<AudioClip> grunts;
    [SerializeField] AudioSource voiceSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void PlayWoosh()
    {
        Debug.Log("Play woosh");
        wooshSource.clip = wooshChute1;
        
        wooshSource.Play();

        voiceSource.clip = grunts[Random.Range(0, grunts.Count)];

        voiceSource.pitch = Random.Range(0.8f, 1.1f);

        voiceSource.Play();



    }

    public void PlayStep()
    {
        Debug.Log("Play Step");
        stepSource.clip = step1;
        stepSource.Play();
    }
}
