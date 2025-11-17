using UnityEngine;

public class pistol : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject bulletPrefab;
    public Transform Firepoint;
    public float bulletSpeed = 100f;
    public float bulletLifetime = 5f;
    public AudioClip clip;
    private AudioSource source;
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        source.PlayOneShot(clip);

        if (rb != null)
        {
            rb.velocity = Firepoint.forward * bulletSpeed;
        }

        Destroy(bullet, bulletLifetime);
    }
}
