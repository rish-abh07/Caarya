using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PageChange : MonoBehaviour
{
    
    // Start is called before the first frame update
    public GameObject[] image;
    public GameObject canvas2;
    public Text buttonText;
    int i = 1;
    public void imageChanges()
    {
        if (i == image.Length)
        {
            i = 1;
            canvas2.SetActive(false); 
        }
        else
        {
            if (i < (image.Length - 1))
            {
                image[i].SetActive(true);
                
            }
            else
            {
                buttonText.text = "Exit";
                
            }
            i++;
        }
    }
}
