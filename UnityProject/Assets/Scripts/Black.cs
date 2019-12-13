using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    public int HP;
    public Text TextHp;
    [Header("音效區域")]
    public AudioSource Aud;
    public AudioClip SoundHit;
    #endregion
    private void Start()
    {
        TextHp.text = HP.ToString();
    }
    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col)
        {
            HP--;
            TextHp.text = HP.ToString();
            Aud.PlayOneShot(SoundHit);
            if (HP <= 0)
            {
                Destroy(this.gameObject,0.115f);
            }
        }
    }
    
}
