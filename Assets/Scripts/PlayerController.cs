using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float Speed;
    public GUIText CountText;
    public GUIText WinText;

    private int _count;

    void Start()
    {
        _count = 0;
        SetCountText();
        WinText.text = "";
    }

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0f, moveVertical);

		rigidbody.AddForce (movement * Speed * Time.deltaTime);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            _count++;
            if (_count >= 10)
            {
                WinText.text = "YOU WIN!";
            }
            SetCountText();
        }
    }

    void SetCountText()
    {
        CountText.text = "Count: " + _count;
    }
}
