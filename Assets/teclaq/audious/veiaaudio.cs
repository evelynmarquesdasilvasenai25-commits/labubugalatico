using UnityEngine;
using UnityEngine.InputSystem.Utilities;

public class veiaaudio : MonoBehaviour
{
    [SerializeField] AudioSource stepsSource;
    [SerializeField] AudioClip steps;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void PlaySteps()
    {
        Debug.Log("Play Steps");
        stepsSource.clip = steps;
        stepsSource.Play();

    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
