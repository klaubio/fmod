using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD;

public class PauseManager : MonoBehaviour
{



    private void OnEnable()
    {
        InputManager.OnPause += Toggle;
    }


    private void OnDisable()
    {
        InputManager.OnPause += Toggle;
    }


    private void Toggle()
    {

    }
}
