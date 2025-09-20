using Components;
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
        _playerAttribute = GetComponentInParent<IAttribute>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            CharacterMoveComponent moveComponent = GetComponentInParent<CharacterMoveComponent>();
            _monsterReaction = collision.gameObject.GetComponent<IReaction>();
            moveComponent.OnMove(Vector2.zero);
            _monsterReaction?.Attacked(_playerAttribute);

        }
    }

}
