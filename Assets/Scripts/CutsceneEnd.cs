using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitCour());
    }

    IEnumerator WaitCour()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("Endscene");

    }

}
