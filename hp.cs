using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hp : MonoBehaviour
{

    public UnityEngine.UI.Text hpcounter;
    public GameObject DamageAudioGameObject;
    public Texture hpiconImage, hpiconImage2, hpiconImage3;
    private int hpcount = 3;
    public float x, y, z, zz, zz2, zz3 = 0;
    public float xpower, ypower, zpower = 0;

    public GameObject PlayerExplosion;
    public Image DamagePanaelFlash;
    public Material mate;
    public GameObject GameOverText;
    //public GameObject MutekiGameObject;
    //----------------------------------------------------------------------------------
    //HP
    void Update()
    {
        //HPが０になったら死亡
        hpcounter.text = hpcount.ToString();
        if (hpcount == 0)
        {
            AudioManager.Main.PlayNewSound("sen_ge_bom14");
            Destroy(gameObject);
            Instantiate(PlayerExplosion, transform.position, transform.rotation);
            GameOverText.SetActive(true);
        }
    }
    //----------------------------------------------------------------------------------
    void OnGUI()
    {
        if (hpcount == 1)
        {
            GUI.DrawTexture(new Rect(Screen.width / zz, x, y, z), hpiconImage);
        }
        if (hpcount == 2)
        {
            GUI.DrawTexture(new Rect(Screen.width / zz, x, y, z), hpiconImage);
            GUI.DrawTexture(new Rect(Screen.width / zz2, x, y, z), hpiconImage2);

        }
        if (hpcount == 3)
        {
            GUI.DrawTexture(new Rect(Screen.width / zz, x, y, z), hpiconImage);
            GUI.DrawTexture(new Rect(Screen.width / zz2, x, y, z), hpiconImage2);
            GUI.DrawTexture(new Rect(Screen.width / zz3, x, y, z), hpiconImage3);
        }
    }

    //----------------------------------------------------------------------------------
    void OnTriggerEnter(Collider other)
    {
        // 接触したオブジェクトのタグが"Enemy"の場合
        if (other.gameObject.CompareTag("Enemy"))
        {
            hpcount--;
            //HPが減ったら音と画面が赤くなるで！
            //タグが一度はずれて、Enemyとぶつからなくなる。●秒後に元に戻る
            AudioManager.Main.PlayNewSound("electric_chain");
            DamagePanaelFlash.enabled = true;
            gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            StartCoroutine(DamageEffectMethod(3.0f, () =>
            {
                DamagePanaelFlash.enabled = false;
                gameObject.layer = LayerMask.NameToLayer("Player");
            }));
        }
        //----------------------------------------------------------------------------------
        if (other.gameObject.CompareTag("StageEnemy"))
        {  
            hpcount--;
            hpcounter.text = hpcount.ToString();
            //TrigeerEnterのせいでなぜか破壊されないバクの修正用
            //ステージエネミーのレイヤーを変えると通り抜けるバグができるから、一時的にタグを変える
            AudioManager.Main.PlayNewSound("electric_chain");
            DamagePanaelFlash.enabled = true;

            other.gameObject.tag = ("Untagged");
            gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            StartCoroutine(DamageEffectMethod(3.0f, () =>
            {
                DamagePanaelFlash.enabled = false;
                gameObject.layer = LayerMask.NameToLayer("Player");
                other.gameObject.tag = ("StageEnemy");
            }));
            //----------------------------------------------------------------------------------
            if (hpcount == 0)
            {
                Destroy(gameObject);
                Instantiate(PlayerExplosion, transform.position, transform.rotation);
                //AudioManager.Main.PlayNewSound("sen_ge_bom14");
                GameOverText.SetActive(true);
                AudioManager.Main.PlayNewSound("gameover 1",interrupts:true);
            }
        }
        //----------------------------------------------------------------------------------
        if (other.gameObject.CompareTag("Kaihuku"))
        {
            AudioManager.Main.PlayNewSound("MediumItem");
            hpcount++;

            if (hpcount > 3)
            {
                hpcount = 3;
            }
        }
    }

    //----------------------------------------------------------------------------------
    public void NotEnemyDamage()
    {
        hpcount--;
        DamagePanaelFlash.enabled = true;
        StartCoroutine(DamageEffectMethod(3.0f, () =>
        {
            DamagePanaelFlash.enabled = false;
        }));
    }

    //----------------------------------------------------------------------------------
    //とりあえずでおいてある
    public IEnumerator DamageEffectMethod(float waitTime, Action action)
    {
        yield return new WaitForSeconds(waitTime);
        action();
    }


}

                //while文を10回ループ
                //int count = 10;
                //while (count > 0)
                //{
                //    //透明にする

                //    GetComponent<Renderer>().material = new Material(mate);
                //    //0.05秒待つ
                //    //new WaitForSeconds(0.1f);
                //    ////元に戻す
                //    //GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0);
                //    ////0.05秒待つ
                //    //new WaitForSeconds(0.1f);
                //    //count--;
                //}