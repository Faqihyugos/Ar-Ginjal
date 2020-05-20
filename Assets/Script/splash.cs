using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splash : MonoBehaviour
{
	public float timer = 5; //lama waktu ynag dibutuhkan sebelum pindah scene

	public void Update(){
		timer -= Time.deltaTime; //timer dihitung mundur
		if (timer > 0){
	    	Debug.Log(timer);
	  	}else {
	     	SceneManager.LoadScene("Penggunaan"); // jika timer < 0 maka secara otomatis berpindah scene
	    }
	}
}
