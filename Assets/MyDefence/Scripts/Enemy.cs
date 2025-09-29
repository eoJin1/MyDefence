using UnityEngine;

namespace MyDefence
{
    /// <summary>
    /// Enemy를 관리하는 클래스
    /// </summary>
    public class Enemy : MonoBehaviour
    {
        /*
        private Vector3 target = new Vector3(-2f, 0.5f, -16.5f);
        public float speed = 10f;
        */

        #region Variables
        //이동 목표 위치를 가지고 있는 오브젝트
        public Transform target;

        //이동 속도
        public float speed = 10f;
        #endregion

        #region 
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //초기화
            target = WayPoints.points[0];
        }

        // Update is called once per frame
        void Update()
        {
            /*
            this.transform.position = Vector3.MoveTowards(this.transform.position, target, speed * Time.deltaTime);
            */

            //타겟을 향해 이동
            Vector3 dir = target.position - this.transform.position;
            this.transform.Translate(dir.normalized * Time.deltaTime * speed);

            //도착 판정 - 타겟과 Enemy와 거리를 구한다
            float distance = Vector3.Distance(target.position, this.transform.position);
            if(distance <= 0.5f)
            {
                Arrive();
            }
        }
        #endregion

        #region Custom Method
        private void Arrive()
        {
            Destroy(this.gameObject);
            Debug.Log("도착했다");
        }



        #endregion
    }
}