using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
   public void level1()
   {
       SceneManager.LoadScene(2);
   }
   public void level2()
   {
       SceneManager.LoadScene(3);
   }
   public void level3()
   {
       SceneManager.LoadScene(4);
   }
}
