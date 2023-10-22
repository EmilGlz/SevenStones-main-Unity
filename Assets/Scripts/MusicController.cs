using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    public void ButtonClick()
    {
        if (Settings.SounOn)
            AudioManager.Instance.Play(5); 
    }

    public void ButtonClickExit()
    {
        if (Settings.SounOn)
            AudioManager.Instance.Play(6);
    }

    public void PlayButtonClick()
    {
        if (Settings.SounOn)
            AudioManager.Instance.Play(7);
    }


    //public void BuyCrystalCoin()
    //{
    //    AudioManager.Instance.Play("BuyCrys");
    //}

    //public void BuySSCoin()
    //{
    //    AudioManager.Instance.Play("BuyCrys");
    //}

    //public void BuyClick()
    //{
    //    AudioManager.Instance.Play("Buy");
    //}

    //public void ImproveSkill()
    //{
    //    AudioManager.Instance.Play("UpSkill");
    //}


    //public void LevelUp()
    //{
    //    AudioManager.Instance.Play("LevelUp");
    //}


}
