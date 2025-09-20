using Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction : MonoBehaviour
{
    //��ҵ����Բ����ӿ�
    IAttribute _playerAttribute;
    //���ｻ���ӿ�
    public IReaction _monsterReaction;

    private void Awake()
    {
        _playerAttribute = GetComponent<IAttribute>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            Debug.Log("collision");
            _monsterReaction = collision.gameObject.GetComponent<IReaction>();
            _monsterReaction?.Attacked(_playerAttribute);
        }
    }


}
