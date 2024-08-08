
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour
{
   [SerializeField] float loadSceneSecond = 2f;

   [SerializeField] ParticleSystem deathEffect;

   [SerializeField] AudioClip deathSound;
   void OnTriggerEnter2D(Collider2D other) 
   {
        if(other.tag=="ground")
        {
        deathEffect.Play(); 
        FindAnyObjectByType<torque>().DisableControls();
          AudioSource.PlayClipAtPoint(deathSound,Camera.main.transform.position);
        Invoke("ReloadScene",loadSceneSecond);
        } 
   }
   void ReloadScene()
   {
        SceneManager.LoadScene("Level1");
   }
}
