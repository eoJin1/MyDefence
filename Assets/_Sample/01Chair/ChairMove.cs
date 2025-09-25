using UnityEngine;
namespace Sample
{
    public class ChairMove : MonoBehaviour
    {
        public int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //의자를 이동하라
            Debug.Log("앞으로 이동하기");  //Start가 아닌 Update로 옮김.

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}