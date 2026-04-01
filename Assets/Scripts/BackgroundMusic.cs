using UnityEngine;


public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic backgroundMusic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake(){
        if(backgroundMusic == null){
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);
        }

        else{
            Destroy(gameObject);
        }
    }
}
