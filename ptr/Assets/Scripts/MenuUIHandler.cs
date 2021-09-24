using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public void Abstraction()
    {
        SceneManager.LoadScene(1);
    }

    public void Encapsulation()
    {
        SceneManager.LoadScene(2);
    }

    public void Polymorphism()
    {
        SceneManager.LoadScene(3);
    }

    public void Inheritance()
    {
        SceneManager.LoadScene(4);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}

