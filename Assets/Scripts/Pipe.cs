using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float timeTodestroy = 7f;
    void Start()
    {
        Destroy(this.gameObject, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.ScoreUpdate();
    }
}
