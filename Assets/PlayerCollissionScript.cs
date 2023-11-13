using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollissionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadSceneAsync(2);
            //SceneManager.LoadSceneAsync("Scene2");
        }
    }
}
