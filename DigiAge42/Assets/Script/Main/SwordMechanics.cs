using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMechanics : MonoBehaviour
{
    private Animator anim;
    bool firstAttack;
    bool SecondAttack;
    float _time = 0f;
    public GameObject player;
    public Ground _ground;
    float maxComboDelay = 1.3f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        _time += Time.deltaTime; // sayac mantigi
        if (Input.GetMouseButtonDown(0)) // eger ki sol mouse'a basildiysa
            OnClick();
        if (_time >= maxComboDelay) // zaman max combo suresini gecti ise attacklar sifirlaniyor.
        {
            firstAttack = false;
            SecondAttack = false;
            player.GetComponent<Move>().p_speed = 4;
            _time = 0;
        }
        if (!SecondAttack && firstAttack && _time >= 0.8f) // eger ki ilk vurus yapildiysa ve ikinci vurus daha yapilmadiysa normal hiza geri doner.
            player.GetComponent<Move>().p_speed = 4;
    }

    void OnClick()
    {
        // ilk atack yapilmadiysa ilk attack'i yapar ve sureyi sifirlar ayriyeten playerin hizini yariya dusurur.
        if (!firstAttack) 
        {
            anim.SetTrigger("Attack1");
            firstAttack = true;
            if (_ground.IsGround) // havadayken hizini yavaslatmak istemedigim icin yazdim
                player.GetComponent<Move>().p_speed = 2;
            _time = 0;
        }
        // ilk atack yapildiysa ve ilk attack yapildiktan sonra 0.7 saniye gectiyse ikinci attagi yap
        // sureyi 0.8 e cek bu sayede 2. attack son kombo saniyesinde yapilsa dahi direk olarak _time sifirlanmasin.
        if (firstAttack && !SecondAttack && _time >= 0.7f)
        {
            anim.SetTrigger("Attack2");
            if (_ground.IsGround)
                player.GetComponent<Move>().p_speed = 2;
            SecondAttack = true;
            _time = 0.8f;
        }
    }
}
