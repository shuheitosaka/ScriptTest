using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;// 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //初期魔力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic(int magic_consumption)
    {
        // 残りmpを減らす
        this.mp -= magic_consumption;
        //残りmpに応じて挙動分岐
        if (this.mp >= 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
            this.mp += magic_consumption;
        }
    }

}



public class Test : MonoBehaviour
{
    int magicattack_number = 13;
    // Use this for initialization
    void Start()
    {
        // 配列を初期化する
        int[] array = { 10, 20, 30, 40, 50 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
                Debug.Log(array[i]);
                Debug.Log(array[array.Length - i - 1]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法攻撃用の関数を指定回数呼び出す
        for (int i = 0; i < this.magicattack_number; i++)
        {
            lastboss.Magic(5);
        }

    }
}