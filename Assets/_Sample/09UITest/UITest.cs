using UnityEngine;
namespace Sample
{
    /// <summary>
    /// UI 버튼 호출 함수 구현
    /// </summary>
    public class UITest : MonoBehaviour
    {
        #region Custom Method
        //Fire 버튼 클릭시 호출되는 함수
        public void Fire()
        {
            Debug.Log("발사하였습니다");
        }

        public void Jump()
        {
            Debug.Log("점프하였습니다");
        }


        #endregion
    }
}