using UnityEngine;
namespace Sample
{
    public class TargetTest : MonoBehaviour
    {
        #region Variable
        public int a = 10;
        public int b = 20;
        #endregion

        #region Unity Event Method
        private void Start()
        {
            //필드 초기화
            b = 20;
        }
        #endregion

        #region Custom Method
        public int GetB()
        {
            return b;
        }
        #endregion

    }
}