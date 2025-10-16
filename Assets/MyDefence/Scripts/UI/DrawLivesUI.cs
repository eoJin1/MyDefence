using MyDefence;
using TMPro;
using UnityEngine;

public class DrawLivesUI : MonoBehaviour
{
    #region Variables
    //라이프 UI
    public TextMeshProUGUI livesCount;
    #endregion

    #region Unity Event Method
    private void Update()
    {
        //라이프 데이터 및 UI 갱신
        livesCount.text = PlayerStats.Lives.ToString();


    }
    #endregion
}
