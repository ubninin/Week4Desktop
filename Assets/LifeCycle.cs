using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //void Awake() { Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�."); }
    //void OnEnable() { Debug.Log("�÷��̾� �α���"); }
    //void Start() { Debug.Log("��� ��� ì����ϴ�."); }
    //void FixedUpdate() { Debug.Log("�̵�~"); }
    //void Update() { Debug.Log("���� ���!!"); }
    //void LateUpdate() { Debug.Log("Exp"); }
    //void OnDisable() { Debug.Log("�÷��̾� �α׾ƿ�"); }
    //void OnDestroy() { Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�."); }
    //void Update() {

    //    if (Input.anyKeyDown) Debug.Log("�ƹ�Ű");
    //    if (Input.GetKeyDown(KeyCode.Return)) Debug.Log("item");
    //    if (Input.GetKey(KeyCode.LeftArrow)) Debug.Log("left moving");
    //    if (Input.GetKeyUp(KeyCode.RightArrow)) Debug.Log("right stop");

    //    if (Input.GetMouseButtonDown(0)) Debug.Log("�̻��Ϲ߻�");
    //    if (Input.GetMouseButton(0)) Debug.Log("�̻���������");
    //    if (Input.GetMouseButtonUp(0)) Debug.Log("������̻��Ϲ߻�");

    //    if (Input.GetButtonDown("Jump")) Debug.Log("����");
    //    if (Input.GetButtonDown("Horizontal")) Debug.Log("Ⱦ �̵���..."+Input.GetAxis("Horizontal"));
    //
    void Start()
    {

        
    }
    //void Update()
    //{
    //    Vector3 vec = new Vector3(0, 0.1f, 0);
    //    transform.Translate(vec);

    //}
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0);
        transform.Translate(vec);

    }
}
