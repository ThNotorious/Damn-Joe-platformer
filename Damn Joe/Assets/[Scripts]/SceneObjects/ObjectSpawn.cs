using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private AudioClip _audioClip;
    
   
    /// <summary>
    /// Спавн объекта
    /// </summary>
    public void Spawn()
    {
        spawnObject = Instantiate(spawnObject, transform.position, transform.rotation);
        _audioSource.PlayOneShot(_audioClip);
        spawnObject.transform.position = new Vector2(spawnObject.transform.position.x, spawnObject.transform.position.y + 0.1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(GlobalStringVars.PlayerTag))
        {
            Destroy(spawnObject);
        }
    }
}
