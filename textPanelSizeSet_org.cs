using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//�e�L�X�g���q�ɂ��AtextPanel�̃T�C�Y���@�q�̂s�d�w�s�ɂ΂����荇�킹��B
//���̃I�u�W�F�̃A���J�[���X�g���b�`�ɂ���Ƃ��܂������Ȃ��B
public class textPanelSizeSet_org: MonoBehaviour {
    Text kodomoText;
    RectTransform Rt;
    GameObject kodomoObj;
    public float yohaku=10;
	// Use this for initialization
	void Start () {
        kodomoObj = this.gameObject.transform.GetChild(0).gameObject;
        kodomoText = kodomoObj.GetComponent<Text>();
        Rt = this.gameObject.GetComponent<RectTransform>();
        
    }

    // Update is called once per frame
    void Update () {
        //�A���J�[���X�g���b�`�ȊO�Ȃ�X�N���[�����W�̒l�Ńp�l���̕��A������
        //�w��ł���B
        Rt.sizeDelta
            = new Vector2(kodomoText.preferredWidth + yohaku
            , kodomoText.preferredHeight + yohaku);
        //Debug.Log("textPanelSizeSize_org:::"+kodomoText.preferredWidth);
    }
}
