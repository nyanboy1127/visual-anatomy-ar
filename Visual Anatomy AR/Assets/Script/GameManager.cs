﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public void penjelasanTulangManusia()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(0);
        
    }

    public void penjelasanHati()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(1);
    }

    public void penjelasanUsusBesar()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(9);
    }

    public void penjelasanTulangKepala()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(10);
    }

}
