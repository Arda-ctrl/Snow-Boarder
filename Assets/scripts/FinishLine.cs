
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadSceneSecond = 2f;

    [SerializeField] ParticleSystem finisheffect;

    [SerializeField] AudioClip finishSound;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            finisheffect.Play();
            FindAnyObjectByType<torque>().DisableControls();
            AudioSource.PlayClipAtPoint(finishSound,Camera.main.transform.position);
            
            Invoke("ReloadScene",loadSceneSecond);
            
        }
    }
        void ReloadScene()
        {
            SceneManager.LoadScene("Level1");
        }
        

}
