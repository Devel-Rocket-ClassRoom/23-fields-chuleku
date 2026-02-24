using System;
using System.Collections.Generic;
using System.Text;
class ScoreTracker
{
    private const int MaxScore = 100;
    private const int MinScore = 0;
    private readonly string name;
    private int score = 0;
    private int bonusScore = 0;
    private int bonuscount = 0;

    public ScoreTracker(string name)
    {
        this.name = name;
    }
    public void SetScore(int score)
    {
        if (score >= 0)
        {
            if (score <= MaxScore)
            {
                this.score = score;
                Console.WriteLine($"점수를 {score}점으로 설정했습니다.");
            }
        }
        else
        {
            Console.WriteLine("점수는 0~100 사이여야 합니다.");
        }
    }
    public void AddBonus(int bonus)
    {
        bonuscount++;
        this.bonusScore = bonus;
        score += bonus;
        if (score <= MaxScore)
        {
            Console.WriteLine($"{bonusScore}점 보너스 적용! 혈재 점수: {score}");
        }
        else if (score >= MaxScore)
        {
            score = MaxScore;
            Console.WriteLine($"{bonusScore}점 보너스 적용! 현재 점수: {score} (최대 점수)");
        }
    }
    public void ShowScore()
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine($"점수: {score}/{MaxScore}");
        Console.WriteLine($"보너스 적용 횟수: {bonuscount}");
    }
}