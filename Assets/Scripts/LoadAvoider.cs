//Joshua Wisdom
//2313991
//CPSC 236-03
//jowisdom@chapman.edu
//Project 07: Avoider
//This is my own work, and I did not cheat on this assignment.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAvoider : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("AvoiderGame");
    }
}
