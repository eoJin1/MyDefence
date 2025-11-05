using UnityEngine;
namespace MyDefence
{
    /// <summary>
    /// Waypoint의 노드 클래스
    /// </summary>
    public class Node : MonoBehaviour
    {
        //선택지(2개)
        [SerializeField] 
        private Node next1;
        [SerializeField]
        private Node next2;

        public Node GetNextNode()
        {
            if (next1 == null && next2 == null)
                return null;

            if (next1 != null && next2 == null)
                return next1;

            if (next2 != null && next1 == null)
                return next2;

            //랜덤 선택
            int randomValue = Random.Range(0, 2);
            return randomValue == 0 ? next1 : next2;
        }
    }

}