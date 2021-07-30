using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HazardCollisionFunctions : MonoBehaviour {

    #region Variables
    //Public

    //Private
    #endregion

    #region UnityFunctions
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    #endregion

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")  
        {
            this.gameObject.SetActive(false);     
        }

        if(collision.gameObject.tag == "Playerr")   
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
        }
    }
}