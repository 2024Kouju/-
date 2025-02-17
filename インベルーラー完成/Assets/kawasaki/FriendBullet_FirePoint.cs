using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendBullet_FirePoint : MonoBehaviour
{
    public GameObject bulletPrefab;         // 発射する弾のプレハブ
    public Transform firePoint;             // 弾を発射する位置
    public float fireRate = 0.5f;           // 発射間隔（秒）
    private float nextFireTime = 0f;        // 次に弾を発射できる時間
    public float damage = 10f;              // 弾の攻撃力

    void Update()
    {
        // 現在の時間が次の発射時間を超えていたら発射
        if (Time.time >= nextFireTime)
        {
            Shoot();  // 弾を発射
            nextFireTime = Time.time + fireRate;  // 次の発射時間を設定
        }
    }

    void Shoot()
    {
        // 弾を生成し、firePointの位置と向きで発射
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
