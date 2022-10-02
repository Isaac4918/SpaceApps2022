using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyButton : MonoBehaviour
{
    public Animator readyAnimation;

    public void Ready()
    {
        readyAnimation.SetTrigger("Ready");
    }
}
