using UnityEngine;
using UnityEngine.UIElements;
using System.Collections;
namespace Sample
{
    public class PrefabTest : MonoBehaviour
    {
        #region Variables
        //프리팹 오브젝트
        public GameObject prefab;

        //맵 타일의 부모 오브젝트
        //public Transform parent;

        #endregion

        #region Unity Event Method
        private void Start()
        {
            //[1]
            //Instantiate(prefab)
            //위치: (5,0,8) 맵타일 생성하기
            //Instantiate(prefab, 위치, 방향);

            //Vector3 position = new Vector3(5f, 0f, 8f);
            //Instantiate(prefab, position, Quaternion.identity);

            //위와 같음
            //Instantiate(prefab, new Vector3(5f, 0f, 8f), Quaternion.identity);

            //10행 10열 타일맵 찍기
            //row(10)행*column(10)열 타일맵 찍기
            //GenerateMap(10, 10);
            //GenerateMapTile(10, 10);

            //랜덤 타일 찍기
            //GenerateRandomMapTile();

            //랜덤 타일을 1초 간격으로 10개 찍는다
            //타일 하나 찍고 -> 1초 쉬었다가 -> 타일 하나 찍고 -> 1초 쉬었다가(딜레이)... 10번 반복


        }
        #endregion

        #region Custom Method
        void GenerateMap(int row, int column)   //row행과 column열
        {
            /*
            //10행 10열 타입맵 찍기, 타일간 간격은 1이다
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) //이중 for 문. 10 * 10 = 100을 만든다
                {
                    Vector3 position = new Vector3(i * 5f, 0f, j * -5f);    //x, z좌표를 증가
                    Instantiate(prefab, position, Quaternion.identity);
                }
             */

            //row와 column을 대신 넣음. 위의 GenerateMap(); 에 몇 행 몇 열을 넣을건지 교체만 해주면 됨
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Vector3 position = new Vector3(i * 5f, 0f, j * -5f);
                    Instantiate(prefab, position, Quaternion.identity);
                }
            }

        }

        //맵 제네레이터를 부모로 지정하여 맵 타일 찍기
        void GenerateMapTile(int row, int column)
        {

            //row와 column을 대신 넣음. 위의 GenerateMapTile(); 에 몇 행 몇 열을 넣을건지 교체만 해주면 됨
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    //인스턴스시 위치 지정
                    //Vector3 position = new Vector3(i * 5f, 0f, j * -5f);
                    //Instantiate(prefab, position, Quaternion.identity, this.transform);

                    //인스턴스 후 위치 지정 - 생성된 게임 오브젝트 객체 가져오기
                    GameObject go = Instantiate(prefab, this.transform);
                    go.transform.position = new Vector3(i * 5f, 0f, j * -5f);
                }

                //row(10)행 * column(10)열 중에 랜덤한 위치에 타일 하나 찍기

                void GenerateRandomMapTile()
                {
                    //int row = Random.Range(0, 10);
                    //int column = Random.Range(0, 10);

                    //0 1 2 3... => r: 0 c: 0~9
                    //10 11 12 13... =>r: 1 C: 0~9
                    //20 21 22 23... =>r: 2 c: 0~9
                    int randomNumber = Random.Range(0, 100);
                    int row = randomNumber / 10;
                    int column = randomNumber % 10;

                    Vector3 position = new Vector3(row * 5f, 0f, column * -5f);
                    Instantiate(prefab, position, Quaternion.identity, this.transform);
                }

                IEnumerator CreateMapTile()
                {
                    GenerateRandomMapTile();

                    yield return new WaitForSeconds(1.0f);

                    yield return null;
                }



                #endregion
            }

        }
    }
}
/*
코루틴 함수 : 지연 함수
하나 이상의 yield return 문이 꼭 있어야 한다
yield return 문에서 지연 시간 지정한다
시간(초)지연 : yield return new WaitForSeconds(지연시간(초));


형식
Imumerator 함수이름()
{
    //...
    yield return .. //하나 이상의 yield return 문이 꼭 있어야 한다
}

코루틴 함수 호출
StartCoroutine(코루틴함수이름);

*/