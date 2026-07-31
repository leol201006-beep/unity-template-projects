using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtomainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackToTheMainMenu()
    {
        SceneManager.LoadScene("Landon");
    }


}