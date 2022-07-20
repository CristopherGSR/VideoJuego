using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenas : MonoBehaviour
{
    // Start is called before the first frame update
    
   public void loadscenes(){
        SceneManager.LoadScene("Low Poly Road Pack Demo");
   }
}
