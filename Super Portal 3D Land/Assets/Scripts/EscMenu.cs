using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscMenu : MonoBehaviour
{
   public GameObject canvas;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            canvas.SetActive(true);
            

        }
        else if (Input.GetButtonUp("Cancel"))
        {
           canvas.SetActive(false);
        }
            
            



    }
}
