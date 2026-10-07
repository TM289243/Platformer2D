using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    [SerializeField] private PlayerScript player;
    private Animator animator;
    private bool reachedCheckpoint = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.tag == "Checkpoint" && collision.gameObject.tag == "Player")
        {
            player.reachCheckpoint();
            reachedCheckpoint = true;
        }
    }
}
