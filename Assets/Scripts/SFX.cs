using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SFX : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource Asource;

    private void Start()
    {
        Asource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(EventSystem.current.currentSelectedGameObject.GetComponent<Button>()!=null)
            {
                PlaySound(clickSound);
            }
        }
    }

    public void PlaySound(AudioClip Aclip)
    {
        Asource.PlayOneShot(Aclip);
    }
}
