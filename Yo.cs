using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yo : MonoBehaviour
{
    public Animator transition;

    public float transitiontime;

    void Update()
    {
        if (lmao == true)
        {
            Bobux();
        }

        if (Bulit == true)
        {
            Bullit();
        }

        if (hailm == true)
        {
            Halim();
        }

        if (gaphin == true)
        {
            Gapin();
        }
    }

    public bool lmao;

    public bool Bulit;

    public bool hailm;

    public bool gaphin;

    public void PlayGame()
    {
        lmao = true;
    }

    public void Bullitt()
    {
        Bulit = true;
    }

    public void halmi()
    {
        hailm = true;
    }

    public void gahpin()
    {
        gaphin = true;
    }


    public void Bobux()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void Bullit()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void Halim()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
    }

    public void Gapin()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 3));
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene(levelIndex);
    }
}

