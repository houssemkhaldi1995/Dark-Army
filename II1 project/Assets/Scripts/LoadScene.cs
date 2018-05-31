using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour {
    int nbr;

    private void Awake()
    {
        getnbr();
    }

    public void RepeatGame()
    {
        SceneManager.LoadScene(nbr - 1 );
    }


		public void StartGame()
		{
			SceneManager.LoadScene(1);
		}

   void getnbr()
    {
        nbr = PlayerPrefs.GetInt("hinbr");
        Debug.Log(nbr);
    }
}
