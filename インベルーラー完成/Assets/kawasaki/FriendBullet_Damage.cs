using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendBullet_Damage : MonoBehaviour
{
    public float speed = 20f;     // 弾の速度
    public float lifeTime = 2f;   // 弾の寿命
    public static float damage = 3f; // 弾のダメージ

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.forward * speed;

        // 弾の威力をPlayerPrefsから読み込む
        damage = PlayerPrefs.GetFloat("BulletFriendDamage", 3f);

        Destroy(gameObject, lifeTime);  // 一定時間後に弾を削除
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // 敵に当たったかどうかをチェック
        USA_normal_HP enemy = collision.GetComponent<USA_normal_HP>();
        if (enemy != null)
        {
            // 敵にダメージを与える
            enemy.TakeDamage(damage);
            // 弾を破壊する
            Destroy(gameObject);
        }

        Russia_normal_HP enemy1 = collision.GetComponent<Russia_normal_HP>();
        if (enemy1 != null)
        {
            // 敵にダメージを与える
            enemy1.TakeDamage(damage);
            // 弾を破壊する
            Destroy(gameObject);
        }

        Japan_normal_HP enemy2 = collision.GetComponent<Japan_normal_HP>();
        if (enemy2 != null)
        {
            // 敵にダメージを与える
            enemy2.TakeDamage(damage);
            // 弾を破壊する
            Destroy(gameObject);
        }
        Japan_Hard_HP enemy3 = collision.GetComponent<Japan_Hard_HP>();
        if (enemy3 != null)
        {
            // 敵にダメージを与える
            enemy3.TakeDamage(damage);
            // 弾を破壊する
            Destroy(gameObject);
        }

        USA_hardHP enemy4 = collision.GetComponent<USA_hardHP>();
        if (enemy4 != null)
        {
            // 敵にダメージを与える
            enemy4.TakeDamage(damage);
            // 弾を破壊する
            Destroy(gameObject);
        }

        Russia_hard_HP enemy5 = collision.GetComponent<Russia_hard_HP>();
        if (enemy5 != null)
        {
            // 敵にダメージを与える
            enemy5.TakeDamage(damage);
            // 弾を破壊する
            Destroy(gameObject);
        }
    }
}
