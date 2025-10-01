using UnityEngine;
namespace Sample
{

    public class RotateTest : MonoBehaviour
    {
        #region Variable
        //축 회전 누적 값을 저장하는 변수
        float x = 0f;

        //회전 속도
        public float rotateSpeed = 10f;

        //이동 속도
        public float moveSpeed = 5f;

        //타겟
        public Transform target;
        #endregion

        #region Unity Event Method
        void Start ()
        {
            //회전값 설정
            //this.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            //this.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
            //this.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        }

        private void Update()
        {
            //x, y, z축으로 회전 구현
            //x += 1;
            //this.transform.rotation = Quaternion.Euler(x, 0, 0);    //x축 기준
            //this.transform.rotation = Quaternion.Euler(0, x, 0);    //y축 기준
            //this.transform.rotation = Quaternion.Euler(0, 0, x);    //z축 기준

            //[1] Rotate(자전)
            //this.transform.Rotate(Vector3.right * Time.deltaTime * rotateSpeed);    //회전 - 방향*초속*속도
            //[1-2] RotateAround(타겟 기준으로 공전) 
            //this.transform.RotateAround(target.position, Vector3.up, Time.deltaTime * 20f);

            //타겟을 향해 회전
            //타겟을 향한 방향을 구한다 : 타겟위치 - 현재위치
            Vector3 dir = target.position - this.transform.position;
            //타겟 방향에 대한 회전값 구하기
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            //this.transform.rotation = lookRotation;
            Quaternion lerpRotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * rotateSpeed);

            //회전값(x, y, z, w)에서 Euler(x, y, z)값을 얻어옴
            Vector3 eulerValue = lerpRotation.eulerAngles;
            //Euler(x, y, z)에서 회전값(x, y, z, w)을 얻어옴 - y축 값만 연산해서 적용
            this.transform.rotation = Quaternion.Euler(0f, eulerValue.y, 0f);
            //this.transform.rotation = lerpRotation;

            //타겟을 향해 이동
            this.transform.Translate(dir.normalized * Time.deltaTime * moveSpeed);

            //도착 판정
            //타겟과 Enemy와 거리를 구해서 일정거리안에 들어오면 도착이라고 판정한다
            float distance = Vector3.Distance(target.position, this.transform.position);
            if (distance <= 0.5f)
            {
                Arrive();
            }
        }
            //도착 후 파괴
            private void Arrive()
        {
            Destroy(this.gameObject);
        }
    }

        #endregion


    }