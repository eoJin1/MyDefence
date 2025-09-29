using UnityEngine;
namespace MyDefence
{
    /// <summary>
    /// WayPoints(적이 지나가는 길의 분기점)을 관리하는 클래스
    /// </summary>
    public class WayPoints : MonoBehaviour
    {
        #region Variable
        //WayPoints(적이 지나가는 길의 분기점)들의 오브젝트를 저장하는 배열
        private Transform[] points;
        #endregion

        #region unity Event Method

        private void Start()
        {
            //초기화
            //WayPoints 배열 요소수 생성 - /WayPoints 갯수 가져오기
            points = new Transform[this.transform.childCount];
            for (int i = 0; i < points.Length; i++)
            {
                ///WayPointdml transform을 순서대로 가져와서 배열에 저장하기
                points[i] = this.transform.GetChild(i);
            }
        }
        #endregion
    }
}