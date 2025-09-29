using UnityEngine;
namespace MyDefence
{
    /// <summary>
    /// 저 스폰 및 웨이브를 관리하는 클래스
    /// </summary>
    public class WaveSpawnManager : MonoBehaviour
    {
        #region Variables
        //적 프리팹 오브젝트
        public GameObject enemyPrefab;  //prefab 오브젝트는 public으로 가져온다

        //public Transform start; == this.transform

        //스폰 타이머
        private float spawnTimer = 5f;  //5초에 한번씩(타이머 기준 시간)
        private float countdown = 0f;   //0부터 시작하는 카운트다운(시간 누적 변수)
        //웨이브 카운트
        private int waveCount = 0;
        #endregion

        #region unity Event Method

        private void Start()
        {
            //EnemySpawn();

        }

        private void Update()
        {
            //스폰(5초) 타이머
            countdown += Time.deltaTime;
            if(countdown > spawnTimer)
            {
                //타이머 기능 실행
                EnemySpawn();

                //타이머 초기화 
                countdown = 0f;
            }
        }


        #endregion

        #region Custom Method
        //시작 위치에 enemy 1개 생성
        void EnemySpawn()
        {
            Instantiate(enemyPrefab, this.transform.position, Quaternion.identity);
        }

        #endregion

    }
}