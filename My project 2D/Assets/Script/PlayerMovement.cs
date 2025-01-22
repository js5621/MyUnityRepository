using System;
using TMPro;
using UnityEngine;
// 플레이어의 이동 (리지드 바디)
// 해당 기능을 통해 이 스크립트를 컴포넌트로써 사용할 경우
// 적어놓은 컴포넌트를 요구하게됩니다.
//1. 해당 컴포넌트가 없는 오브젝트가 연결할 경우에는 자동으로 견결을 진행해줍니다.
//2. 스크립트가 연결된 상태라면 그 오브젝튼 대상의 컴포넌트를 제거 할 수 없습니다.
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]TextMeshPro ScoreText;
    
    public int a = 10;
    int coinGetScore = 0;
    public float speed = 2.0f; // 소수점을 적을때는 마지막에 f기호를 사용합니다.
    // 소수점 약 자리까지 정확하게 계산 
    public double jump_force = 3.5;  // f붙이지 않음
    //소수점 약 15자리까지 정확하게 계산 
    public bool isJump = false;

    private Rigidbody2D rigid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        //GetComponent<T> 타입
        //해당 컴포넌트의 값을 얻어오는 기능
        //T부분에는 컴포넌트의 형태를 작성
        //컴포넌트의 형태가 다르다면 오류 발생
        // 해당 데이터가 존재하지 않을 경우라면 null을 반환
        //
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        //GetAxisRaw("키 이름");은 인풋매니저의 키를 얻어오면서 
        // 클릭에 따라 -1,0,1의 수치로 값을 얻어옵니다.

        //위의 코드를 통해 움직일 방향을 계산 
        Vector3 velocity = new Vector3 (x, y, 0)*speed *Time.deltaTime;
        //속력 = 방향 *속도

        transform.position += velocity;
    }
    private void Jump()
    { // 사용자가 키보드 Space키를 입력한다면
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //조건의 결과가 true일 경우 false
            if (!isJump)// 점프 상태가 아닌 경우 점프 상태로 변경합니다.
            {
                isJump = true;
                rigid.AddForce(Vector3.up * (float)jump_force, ForceMode2D.Impulse);
                //타입캐스팅
                // 단 캐스팅이 가능한 범위에서만 진행

                // 주로 int -> float같은 경우는 가능
                // 데이터 타입이 서로 호환 되지 않은 경우라면 사용불가

            }
           

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Finish")
        {
            Debug.Log("골인!!");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // a==b: a는 b와 크기가 같습니다.(값이 같다)
        
        //충돌체의 게임 오브젝트이 레이어가 7과 비교했을때 크기가 같다면
        if(collision.gameObject.layer == 7)
        {
            isJump = false;

        }

        if(collision.gameObject.tag =="Coin")
        {
            coinGetScore += 1;
            ScoreText.text =  "Score :"+coinGetScore.ToString();
        }
        Debug.Log("땅을 밟았습니다!");
        
    }
   
}
