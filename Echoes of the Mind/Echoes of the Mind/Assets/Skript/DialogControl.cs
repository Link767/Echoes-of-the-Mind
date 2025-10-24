using UnityEngine;

public class DialogControl : MonoBehaviour
{
    [SerializeField] private GameObject _HitE;
    [SerializeField] private GameObject _DialogUI;
    private bool _IsPalyer = false;

    void Update()
    {
        if(_IsPalyer == true && Input.GetKey(KeyCode.E))
        {
            _HitE.SetActive(false);
            _DialogUI.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _HitE.SetActive(true);
            _IsPalyer = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        _HitE.SetActive(false);
        _DialogUI.SetActive(false);
    }
}
