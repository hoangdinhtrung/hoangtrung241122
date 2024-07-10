using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
   public void start()
   {
       SceneManager.LoadScene(1);
   }
   public void exit()
   {
       Application.Quit();
   }
}

