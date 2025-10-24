using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyDefence
{
    public class MainMenuUI : MonoBehaviour
    {
        #region Variables
        [SerializeField]
        private string loadToScene = "PlayScene";
        #endregion

        #region Custom Method
        //플레이 클릭시 호출
        public void Play()
        {
            Debug.Log("Goto PlayScene");
            SceneManager.LoadScene(loadToScene);
        }
        //나가기 클릭시 호출
        public void Quit()
        {
            Debug.Log("Game Quit!!");
            Application.Quit(); //에디터에서는 명령 무시, 실제 기기에서는 명령 실행
        }
        #endregion
    }
}
