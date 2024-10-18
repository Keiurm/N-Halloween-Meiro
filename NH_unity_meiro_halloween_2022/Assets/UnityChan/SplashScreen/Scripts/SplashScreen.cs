using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace UnityChan
{
	[ExecuteInEditMode]
	public class SplashScreen : MonoBehaviour
	{
		void NextLevel ()
		{
            //古い記述
			//Application.LoadLevel (Application.loadedLevel + 1);
            //書き直したが合ってるか要検証（2019-02-07)by shinji okumura
            SceneManager.LoadScene(1,LoadSceneMode.Additive);
		}
	}
}