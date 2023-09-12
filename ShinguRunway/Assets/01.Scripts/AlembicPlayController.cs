using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Formats.Alembic.Importer;

public class AlembicPlayController : MonoBehaviour
{
    private AlembicStreamPlayer streamPlayer;               //AlembicStream 플레이어 가져오기

    void Start()
    {
        Application.targetFrameRate = 60;                   //프레임레이트 60 설정
        QualitySettings.vSyncCount = 0;                     //vSync 옵션 설정   (0 비활성화, 1 활성화 <기본값>, 2 더블 버퍼링)

        streamPlayer = GetComponent<AlembicStreamPlayer>(); //AlembicStream 컴포넌트 참조
    }

    void FixedUpdate()
    {
        streamPlayer.CurrentTime += Time.deltaTime;
    }
}
