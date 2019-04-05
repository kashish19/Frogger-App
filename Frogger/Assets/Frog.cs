using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
    public int a;
	void Update () {

        if (Input.GetKeyDown(KeyCode.RightArrow))
            moveRight();
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            moveLeft();
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            moveUp();
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            moveDown();

	}
    public void moveUp()
    {
        rb.MovePosition(rb.position + Vector2.up);
    }
    public void moveDown()
    {
        rb.MovePosition(rb.position + Vector2.down);
    }

    public void moveLeft()
    {
        rb.MovePosition(rb.position + Vector2.left);
    }

    public void moveRight()
    {
        rb.MovePosition(rb.position + Vector2.right);
    }

    void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			Debug.Log("WE LOST!");
			Score.CurrentScore = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
