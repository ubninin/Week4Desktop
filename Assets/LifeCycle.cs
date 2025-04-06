using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //void Awake() { Debug.Log("플레이어 데이터가 준비되었습니다."); }
    //void OnEnable() { Debug.Log("플레이어 로그인"); }
    //void Start() { Debug.Log("사냥 장비를 챙겼습니다."); }
    //void FixedUpdate() { Debug.Log("이동~"); }
    //void Update() { Debug.Log("몬스터 사냥!!"); }
    //void LateUpdate() { Debug.Log("Exp"); }
    //void OnDisable() { Debug.Log("플레이어 로그아웃"); }
    //void OnDestroy() { Debug.Log("플레이어 데이터를 해제하였습니다."); }
    //void Update() {

    //    if (Input.anyKeyDown) Debug.Log("아무키");
    //    if (Input.GetKeyDown(KeyCode.Return)) Debug.Log("item");
    //    if (Input.GetKey(KeyCode.LeftArrow)) Debug.Log("left moving");
    //    if (Input.GetKeyUp(KeyCode.RightArrow)) Debug.Log("right stop");

    //    if (Input.GetMouseButtonDown(0)) Debug.Log("미사일발사");
    //    if (Input.GetMouseButton(0)) Debug.Log("미사일충전중");
    //    if (Input.GetMouseButtonUp(0)) Debug.Log("레전드미사일발사");

    //    if (Input.GetButtonDown("Jump")) Debug.Log("점프");
    //    if (Input.GetButtonDown("Horizontal")) Debug.Log("횡 이동중..."+Input.GetAxis("Horizontal"));
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
