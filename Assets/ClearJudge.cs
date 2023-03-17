using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ClearJudge : InstanceSystem<ClearJudge>
{
    string[][] _judgeNum = { new string[] { "","",""}, new string[] {"","",""}, new string[] {"","",""} };
    public string[][] JudeNum { get => _judgeNum; set => _judgeNum = value; }
    bool _isEnd;


    public void Judge()
    {
        for(int i = 0; i < 3; i++)
        {
            if (string.Join("", _judgeNum[i]) == "ZZZ")
            {
                _isEnd = true;
                Debug.Log("Z‚ÌŸ—˜");
            }
            if(string.Join("", _judgeNum[i]) == "~~~")
            {
                _isEnd = true;
                Debug.Log("~‚ÌŸ—˜");
            }
        }
        if (!_isEnd)
        {
            for (int i = 0; i < 3; i++)
            {
                string[] vertical = Enumerable.Repeat("",3).ToArray();
                for (int j = 0; j < 3; j++)
                {
                    vertical[i] = _judgeNum[j][i];
                }
                if (string.Join("", vertical) == "ZZZ")
                {
                    _isEnd = true;
                    Debug.Log("Z‚ÌŸ—˜");
                }
                if (string.Join("", vertical) == "~~~")
                {
                    _isEnd = true;
                    Debug.Log("~‚ÌŸ—˜");
                }
            }
        }
        if(!_isEnd)
        {
            string[] leftUp = Enumerable.Repeat("", 3).ToArray();
            string[] rightUp = Enumerable.Repeat("", 3).ToArray();
            for(int i = 0; i < 3; i++)
            {
                leftUp[i] = _judgeNum[i][i];
                rightUp[i] = _judgeNum[i][3 - i];
            }
            if (string.Join("", leftUp) == "ZZZ" || string.Join("", rightUp) == "ZZZ")
            {
                Debug.Log("Z‚ÌŸ—˜");
            }
            if (string.Join("", leftUp) == "~~~" || string.Join("", rightUp) == "~~~")
            {
                Debug.Log("~‚ÌŸ—˜");
            }
        }
    }
}
