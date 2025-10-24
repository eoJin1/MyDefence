using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace MyDefence
{
    /// <summary>
    /// 터렛을 회전시켜주는 클래스
    /// </summary>
    public class Rotater : MonoBehaviour
    {
        #region Variables
        [SerializeField]
        private Vector3 rotationSpeed;
        #endregion

        #region Unity Event Method
        private void Update()
        {
            transform.localEulerAngles += rotationSpeed;
        }
        #endregion
    }
}

