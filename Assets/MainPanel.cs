using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlatformShoot
{
    public class MainPanel : MonoBehaviour
    {
        private Text mScoreText;
        private int ScoreNum;
        private void Start()
        {
            mScoreText = GameObject.Find("Canvas/MainPanel/ScoreText").GetComponent<Text>();
            ScoreNum = 0;
        }
        public void UpdateScoreText(int score)
        {
            ScoreNum += score;
            mScoreText.text = ScoreNum.ToString();
        }
    }

}
