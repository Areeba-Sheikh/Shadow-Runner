using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegementGenerator : MonoBehaviour
{
    public GameObject segmentMap01;
    public GameObject segmentMap02;
    public GameObject segmentMap03;
    public GameObject segmentMap04;
    public GameObject segmentMap05;
    public GameObject segmentMap06;
    public GameObject segmentMap07;
    public GameObject segmentMap08;
    public GameObject segmentMap09;
    public GameObject segmentMap10;
    public GameObject segmentMap11;
    public GameObject segmentMap12;
    public GameObject segmentMap13;

    void Start()
    {
        StartCoroutine(SegmentGen());
    }

    IEnumerator SegmentGen()
    {
        yield return new WaitForSeconds(1);
        segmentMap02.SetActive(true);
        yield return new WaitForSeconds(1);
        segmentMap03.SetActive(true);
        yield return new WaitForSeconds(1);
        segmentMap04.SetActive(true);
         yield return new WaitForSeconds(1);
        segmentMap05.SetActive(true); 
        yield return new WaitForSeconds(1);
        segmentMap06.SetActive(true);
        yield return new WaitForSeconds(1);
        segmentMap07.SetActive(true);
        yield return new WaitForSeconds(1);
        segmentMap08.SetActive(true);
        yield return new WaitForSeconds(1);
        segmentMap09.SetActive(true);
        yield return new WaitForSeconds(1);
        segmentMap10.SetActive(true);
        yield return new WaitForSeconds(1);
        segmentMap11.SetActive(true);
         yield return new WaitForSeconds(1);
        segmentMap12.SetActive(true);
         yield return new WaitForSeconds(1);
        segmentMap13.SetActive(true);


    }

}

