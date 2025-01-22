using System;
using TMPro;
using UnityEngine;
// �÷��̾��� �̵� (������ �ٵ�)
// �ش� ����� ���� �� ��ũ��Ʈ�� ������Ʈ�ν� ����� ���
// ������� ������Ʈ�� �䱸�ϰԵ˴ϴ�.
//1. �ش� ������Ʈ�� ���� ������Ʈ�� ������ ��쿡�� �ڵ����� �߰��� �������ݴϴ�.
//2. ��ũ��Ʈ�� ����� ���¶�� �� ������ư ����� ������Ʈ�� ���� �� �� �����ϴ�.
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]TextMeshPro ScoreText;
    
    public int a = 10;
    int coinGetScore = 0;
    public float speed = 2.0f; // �Ҽ����� �������� �������� f��ȣ�� ����մϴ�.
    // �Ҽ��� �� �ڸ����� ��Ȯ�ϰ� ��� 
    public double jump_force = 3.5;  // f������ ����
    //�Ҽ��� �� 15�ڸ����� ��Ȯ�ϰ� ��� 
    public bool isJump = false;

    private Rigidbody2D rigid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        //GetComponent<T> Ÿ��
        //�ش� ������Ʈ�� ���� ������ ���
        //T�κп��� ������Ʈ�� ���¸� �ۼ�
        //������Ʈ�� ���°� �ٸ��ٸ� ���� �߻�
        // �ش� �����Ͱ� �������� ���� ����� null�� ��ȯ
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
        //GetAxisRaw("Ű �̸�");�� ��ǲ�Ŵ����� Ű�� �����鼭 
        // Ŭ���� ���� -1,0,1�� ��ġ�� ���� ���ɴϴ�.

        //���� �ڵ带 ���� ������ ������ ��� 
        Vector3 velocity = new Vector3 (x, y, 0)*speed *Time.deltaTime;
        //�ӷ� = ���� *�ӵ�

        transform.position += velocity;
    }
    private void Jump()
    { // ����ڰ� Ű���� SpaceŰ�� �Է��Ѵٸ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //������ ����� true�� ��� false
            if (!isJump)// ���� ���°� �ƴ� ��� ���� ���·� �����մϴ�.
            {
                isJump = true;
                rigid.AddForce(Vector3.up * (float)jump_force, ForceMode2D.Impulse);
                //Ÿ��ĳ����
                // �� ĳ������ ������ ���������� ����

                // �ַ� int -> float���� ���� ����
                // ������ Ÿ���� ���� ȣȯ ���� ���� ����� ���Ұ�

            }
           

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Finish")
        {
            Debug.Log("����!!");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // a==b: a�� b�� ũ�Ⱑ �����ϴ�.(���� ����)
        
        //�浹ü�� ���� ������Ʈ�� ���̾ 7�� �������� ũ�Ⱑ ���ٸ�
        if(collision.gameObject.layer == 7)
        {
            isJump = false;

        }

        if(collision.gameObject.tag =="Coin")
        {
            coinGetScore += 1;
            ScoreText.text =  "Score :"+coinGetScore.ToString();
        }
        Debug.Log("���� ��ҽ��ϴ�!");
        
    }
   
}
