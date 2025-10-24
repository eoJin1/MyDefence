using Unity.VisualScripting;
using UnityEngine;

namespace MyDefence
{
    /// <summary>
    /// 일정 시간 간격으로 파티클 이펙트를 플레이 시켜주는 클래스
    /// </summary>
    public class IntervalParticleSystemPlay : MonoBehaviour
    {
        #region Variables
        //연출 파티클 
        public ParticleSystem particleToPlay;

        //플레이 타이머
        [SerializeField]
        private float playTimer = 5f;   //5초 간격으로 플레이
        private float countdown = 0f;

        #endregion

        #region Unity Event Method
        private void Start()
        {
            //일정 시간(PlayTimer)마다 한번씩 지정하는 함수를 호출
            InvokeRepeating("PlayParticleSystem", 0f, 5f);     //InvokeRepeating(메소드 이름, 시작 시간(카운트다운), 반복 시간)
        }


        private void Update()
        {
            countdown += Time.deltaTime;
            if (countdown >= playTimer)
            {
                //타이머 기능
                PlayParticleSystem();
                //타이머 초기화
                countdown = 0f;
            }
        }
        #endregion

        #region Custom Method
        private void PlayParticleSystem()
        {
            if (particleToPlay == null) //파티클이 없으면 플레이 안 함
                return;

            particleToPlay.Play();
        }
        #endregion
    }
}