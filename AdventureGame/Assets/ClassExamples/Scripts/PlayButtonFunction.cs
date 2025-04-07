using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class PlayButtonFunction : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("Clicked!");
    }
}
