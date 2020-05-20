using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Keluar : MonoBehaviour
{
    [SerializeField] GameObject exitPanel;
    
    void Update()
    {
    if (Input.GetKeyDown (KeyCode.Escape))
        if(SceneManager.GetActiveScene().buildIndex!=2){
            SceneManager.LoadScene("Menu");
        } else {
            if (exitPanel) {
                exitPanel.SetActive (true);
            }
        }   
    }

    public void onUserClickYesNo(int pilihan)
    {//pilihan==0 tidak     pilihan==1 ya
        if(pilihan == 1){
            Application.Quit();
        } else if(pilihan == 0){
            exitPanel.SetActive(false);
        }
        
    }

}
