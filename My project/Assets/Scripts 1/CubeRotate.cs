using UnityEngine;
/// <summary>
/// ť�긦 ȸ�� ��Ű�� 
/// </summary>
public class CubeRotate : MonoBehaviour
{
    #region �ʱ⳻��
    // �ڷ���(type)
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // ������
    #endregion

    #region ����
    public float x;//����Ƽ���� �����Ǵ� ���� 
    public float z;
    private int sample; // ����Ƽ �����Ϳ��� ������ �ȵǴ� ����
    // ����ϴ� ����� �Ǽ��ұ�� ���º���
    #endregion

    #region �Լ�
    void Start()
    {
        sample = 10; //������ ������ϰ�� �ڵ� ���ο��� �����Ǵ� ��찡 ����.
        Debug.Log(sample);
        // "" ���� ������ ������ �� ���� ���� ���
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x*Time.deltaTime,0,z*Time.deltaTime));//���Ӽ���
        //FPS(FramePer Second) : �� �� ������
        //deltaTime: �� �������� �Ϸ�Ǳ���� �ɸ��� �ð� 
    }
    #endregion �Լ�
}
