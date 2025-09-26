using UnityEngine;
namespace Sample
{
    public class MoveTest : MonoBehaviour
    {
        //이동 목표 지정 변수 선언 및 초기화
        private Vector3 target = new Vector3(7f, 1f, 7f);

        //이동 목표 위치에 있는 오브젝트의 트랜스폼 인스턴스
        private Transform Target;

        //이동 속도를 저장하는 변수를 선언하고 초기화
        public float speed = 10f;  //1초에 가는 거리

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //this.gameObject.transform     
            //this.transform.gameObject     
            //this.transform.position = new Vector3(7f, 1f, 7f);

            //Debug.Log(this.Target.position);
            //this.transform.position = Target.position;
        }

        // Update is called once per frame
        void Update()
        {
            //플레이어의 위치를 앞으로 계속 이동 : z축 값이 증가한다 
            //this.transform.position 연산으로 구현 - Vector3를 이용
            //this.transform.position = this.transform.position + new Vector3(0f, 0f, 1f);    //z축값을 계속 추가(앞으로 이동)
            //this.transform.position += new Vector3(1f, 0f, 0f);      //x축값을 계속 추가(오른쪽으로 이동)
            //앞, 뒤, 좌, 우, 위, 아래 이동
            /*
            this.transform.position += new Vector3(0f, 0f, 1f);     Vector3.forward
            this.transform.position += new Vector3(0f, 0f, -1f);    Vector3.back
            this.transform.position += new Vector3(-1f, 0f, 0f);    Vector3.left
            this.transform.position += new Vector3(1f, 0f, 0f);     Vector3.right
            this.transform.position += new Vector3(0f, 1f, 0f);     Vector3.up
            this.transform.position += new Vector3(0f, -1f, 0f);    Vector3.down

            this.transform.position += new Vector3(1f, 1f, 1f);    Vector3.one 단위벡터
            this.transform.position += new Vector3(0f, -0f, 0f);   Vector3.zero
            */

            //앞 방향으로 1초에 1unit만큼 이동하라
            //this.transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime;
            //this.transform.position += Vector3.forward = Time.deltaTime;

            //앞 방향으로 1초에 5만큼 이동하라
            //this.transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime * speed;
            //(위치 옮기기 : ) (값을 계속 더하기)   (방향 지정)    (속도 지정)    (속도 결정)

            //Translate
            //dir(방향) : 이동할 방향
            //Time.deltaTime : 동일한 시간에 동일한 거리를 이동하게 해준다
            //speed : 이동의 빠르기 지정
            //dir * Time.deltaTime * speed //연산의 결과는 Vector3
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);

            //이동방향 구하기 : (목표지점 - 현재지점) (도착위치 - 현재위치)
            //dir.normalized    : 단위벡터, 길이가 1인 벡터, 정규화된 벡터
            //dir.magnitude     : 벡터의 실제 길이, 크기
            //Vector3 dir = target.position - this.transform.position;
            this.transform.position = Vector3.MoveTowards(this.transform.position, target, speed * Time.deltaTime);

            //this.transform.Translate(dir.normalized * Time.deltaTime * speed);
            //this.transform.Translate(dir.normalized * Time.deltaTime * speed, Space.Self);  //위와 같음, 생략된걸 표기

            //Space.Self, Space.World
            //this.transform.Translate(dir.normalized * Time.deltaTime * speed, Space.World);   //글로벌 기준 앞으로
            //this.transform.Translate(dir.normalized * Time.deltaTime * speed, Space.Self);    //로컬 기준 앞으로


        }
    }
}

/*
n프레임: 1 초마다 n번 실행
20프레임
this.transform.position += new Vector3(0f, 0f, 1f);

Time.deltaTime : 한 프레임 돌아오는데 걸리는 시간

성능좋은컴
10프레임 - 1초에 10 unit 이동
Time.deltaTime : 0.1초

this.transform.position += new Vector3(0f, 0f, 1f); * Time.deltaTime;   //0.1씩 증가
this.transform.position += new Vector3(0f, 0f, 1f); * Time.deltaTime;
this.transform.position += new Vector3(0f, 0f, 1f); * Time.deltaTime;
this.transform.position += new Vector3(0f, 0f, 1f); * Time.deltaTime;
this.transform.position += new Vector3(0f, 0f, 1f); * Time.deltaTime;
this.transform.position += new Vector3(0f, 0f, 1f); * Time.deltaTime;
this.transform.position += new Vector3(0f, 0f, 1f); * Time.deltaTime;
this.transform.position += new Vector3(0f, 0f, 1f); * Time.deltaTime;
this.transform.position += new Vector3(0f, 0f, 1f); * Time.deltaTime;
this.transform.position += new Vector3(0f, 0f, 1f); * Time.deltaTime;

성능나쁜컴
2프레임 - 1초에 2 unit 이동 //Time.deltaTime를 고려하지 않음
Time.deltaTime : 0.5초
2프레임 - 1초에 1 unit 이동 //Time.deltaTime를 고려

Time.deltaTime이 어떤 컴이든 동일한 시간에 동일한 거리를 움직이게 해준다

this.transform.position += new Vector3(0f, 0f, 1f); //0.5씩 증가
this.transform.position += new Vector3(0f, 0f, 1f); * Time.deltaTime;   //0.1씩 증가



*/