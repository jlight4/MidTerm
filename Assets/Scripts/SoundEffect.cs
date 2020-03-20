using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public static bool KillEffect;

    public AudioSource SFX;
    public AudioClip Jump;

    // Start is called before the first frame update
    void Start()
    {
        KillEffect = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (KillEffect)
        {
            SFX.PlayOneShot(Jump);
            KillEffect = false;
        }
    }
}
