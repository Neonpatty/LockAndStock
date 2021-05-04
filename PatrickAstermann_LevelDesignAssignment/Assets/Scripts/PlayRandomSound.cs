using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{
    public AudioSource _as;

    public AudioClip[] AudioClipArray;

    
    // Start is called before the first frame update
    void Start()
    {
        _as = GetComponent<AudioSource>();
        _as.clip = AudioClipArray[Random.Range(0, AudioClipArray.Length)];
        _as.PlayOneShot(_as.clip);
    }

    void Update()
    {
        
    }
}
