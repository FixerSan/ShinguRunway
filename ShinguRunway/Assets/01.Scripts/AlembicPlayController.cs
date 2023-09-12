using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Formats.Alembic.Importer;

public class AlembicPlayController : MonoBehaviour
{
    private AlembicStreamPlayer streamPlayer;               //AlembicStream �÷��̾� ��������

    void Start()
    {
        Application.targetFrameRate = 60;                   //�����ӷ���Ʈ 60 ����
        QualitySettings.vSyncCount = 0;                     //vSync �ɼ� ����   (0 ��Ȱ��ȭ, 1 Ȱ��ȭ <�⺻��>, 2 ���� ���۸�)

        streamPlayer = GetComponent<AlembicStreamPlayer>(); //AlembicStream ������Ʈ ����
    }

    void FixedUpdate()
    {
        streamPlayer.CurrentTime += Time.deltaTime;
    }
}
