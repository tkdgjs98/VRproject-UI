using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Metronome : MonoBehaviour
{
    AudioSource playTik;
    public AudioClip tik;
    public TextMeshProUGUI txt_BPM;
    public TMP_InputField metro_Field;
    public Slider metro_Slider;
    public float musicBPM = 120f;           // ������ BPM
    private float volume = 1f;
    private float stdBPM = 60f;
    private float musicBeat = 4f;           // ������ ����
    private float stdBeat = 4f;             // ������ �и� ��, musicTempo = 4f, std Tempo = 8f�� 4/8 ���ڰ� �ȴ�.
    private float tikTime = 0;
    private float nextTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        playTik = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        tikTime = (stdBPM / musicBPM) * (musicBeat / stdBeat);
        nextTime += Time.deltaTime;
        playTik.volume = volume;

        if (nextTime > tikTime)
        {
            StartCoroutine(PlayTik());
            nextTime = 0;
        }
    }

    IEnumerator PlayTik()
    {
        playTik.PlayOneShot(tik);   // ���� ���
        yield return null;
    }

    public void PlusBPM()
    {
        if(musicBPM >= 310)
            return;
        ++musicBPM;
        txt_BPM.text = musicBPM.ToString();
    }

    public void MinusBPM()
    {
        if (musicBPM <= 10)
            return;
        --musicBPM;
        txt_BPM.text = musicBPM.ToString();
    }

    public void OnAndOff()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

    public void RegulateVolume()
    {
        volume = metro_Slider.value / 100f;
        metro_Field.text = ((int)metro_Slider.value).ToString();
    }
}