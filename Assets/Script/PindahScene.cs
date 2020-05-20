using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    // pindah scene
    // Menjaga kesehatan
    public void menjagaKesehatan(){
        SceneManager.LoadScene("Kesehatan");
    }
    // Tampilan ginjal
    public void tampilanGinjal(){
        SceneManager.LoadScene("Ginjal");
    }

     // Petunjuk Info Aplikasi
    public void infoAplikasi(){
        SceneManager.LoadScene("Info");
    }

     // Tampilan AR
    public void tampilanAR(){
        SceneManager.LoadScene("AR");
    }

     // Tampilan menu
    public void tampilanMenu(){
        SceneManager.LoadScene("Menu");
    }

}
