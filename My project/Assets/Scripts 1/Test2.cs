using UnityEngine;
// using�� ������ ���� ���� �ڵ忡�� ����ϴ� ��
// ����Ƽ���� ����Ʈ�� Ȱ���� �۾��ϴ� ��ũ��Ʈ ��� ���� �ڵ带 �ݵ�� �߰����ּ���
//���ӽ����̽��� Ư�� ����� �ϴ� Ŭ������ ��ǥ���� �̸����ν� ����մϴ�.
namespace TowerDefence
{
    //  UnityTutorial �������� ������� SampleAŬ����
    public class PlaySetting
    {
        
    }
}

public class SampleA
{

}
/// <summary>
/// ó������ ���� ����Ƽ�� ��ũ��Ʈ
/// </summary>
public class Test2 : MonoBehaviour
    //MonoBehavior Ŭ������ �����������
    // ����Ƽ���� �����ϴ� ������Ʈ�� ��ũ��Ʈ�� �����Ҽ� �ְ� ���ݴϴ�.
    // �߰������� ����Ƽ���� �������ִ� ����Ҷ� ����մϴ�.
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello");
    }
    int count = 0;
  

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{count}�¿� �ݺ��ٱ�");
        count++;// ī��Ʈ�� 1 �����Ѵ�.
    }
}
