using System;
///과제 1: 필드가 있는 클래스 만들기
/*Player player = new Player();
player.showstatus();

class Player
{
    string name;
    int health;

    public void showstatus()
    {
        Console.WriteLine("이름: "+name);
        Console.WriteLine("체력: "+health);
    }
}*/

/// 과제 2: public 필드

/*Character hero = new Character();
hero.name = "용사";
hero.level = 10;
Console.WriteLine(hero.name);
Console.WriteLine(hero.level);
class Character
{
    public string name;
    public int level;
}*/
///과제 3: private 필드
/*Character hero = new Character();
hero.SetInfo("용사", 10);
hero.ShowInfo();

class Character
{
    private string name;
    private int level;
    public void SetInfo(string n, int lv)
    {
        name = n; 
        level = lv;
    }
    public void ShowInfo()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("레벨: " + level);
    }
}*/
///과제 4: 선언과 동시에 초기화
/*Player player = new Player();
player.ShowStatus();
class Player
{
    private string name = "이름없음";
    private int Health = 100;
    private int level = 1;

    public void ShowStatus()
    {
        Console.WriteLine("이름: " + name);
        Console.WriteLine("체력: " + Health);
        Console.WriteLine("레벨: " + level);
    }
}*/
///과제 5; 필드 이니셜라이저
/*say say = new say();
say.hi();
class say
{
    private string message = "안녕하세요.";
    public void hi()
    {
        message = "반갑습니다.";
        Console.WriteLine(message);
    }
}*/
///과제 6: 배열 필드 초기화
/*schedule schedule = new schedule();
schedule.printweakDays();
class schedule
{
    private string[] weak = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
    public void printweakDays()
    {
        foreach (string s in weak)
        {
            Console.Write(s + "\t");
        }
        Console.WriteLine();
    }
}*/
///과제 7: 기본값 확인
/*DefaultValues dv = new DefaultValues();
dv.ShowDefaults();
class DefaultValues
{
    private int number;
    private bool flag;
    private string text;
    public void ShowDefaults()
    {
        Console.WriteLine("number: "+number);
        Console.WriteLine("flag: "+flag);
        Console.WriteLine("Text: " + (text == null ? "null" : text));
    }
}*/
///과제 8: 정적 필드 선언과 사용
/*counter c1 =  new counter();
Console.WriteLine("현재 카운트: "+ counter.count);
counter c2 =  new counter();
Console.WriteLine("현재 카운트: "+ counter.count);
counter c3 =  new counter();
Console.WriteLine("현재 카운트: "+ counter.count);
class counter
{
    public static int count = 0;

    public counter()
    {
        count++;
    }
}*/
///과제 9: 인스턴스 필드 vs 정적 필드
/*Player p1 = new Player("용사");
Player p2 = new Player("마법사");
Player p3 = new Player("궁수");
Console.WriteLine(p1.name);
Console.WriteLine(p2.name);
Console.WriteLine(p3.name);
Console.WriteLine("총 플레이어 수: "+Player.totalcount);
class Player
{
    public string name;
    public static int totalcount;

    public Player(string n)
    {
        name = n;
        totalcount++;
    }
}*/
///과제 10: readonly 필드
/*GameConfig config = new GameConfig(4);
config.ShowConfig();

class GameConfig
{
    public readonly string version = "1.0.0";
    public readonly int maxPlayers;

    public GameConfig(int max)
    {
        maxPlayers = max;
    }

    public void ShowConfig()
    {
        Console.WriteLine("버전: " + version);
        Console.WriteLine("최대 플레이어: " + maxPlayers);
    }
}*/
///과제 11; readonly vs const비교
/*Example ex = new Example();
ex.Showvalues();

class Example
{
    private const double Pi = 3.14159;
    private readonly DateTime createdAt = DateTime.Now;

    public void Showvalues()
    {
        Console.WriteLine("원주율: "+Pi);
        Console.WriteLine("생성 시간: "+createdAt);
    }
}*/
///과제 12: this 키워드
/*Player player = new Player();
player.setinfo("용사", 10);
player.showinfo();
class Player
{
    private string name;
    private int level;

    public void setinfo(string name, int level)
    {
        this.name = name;
        this.level = level;
    }
    public void showinfo()
    {
        Console.WriteLine("이름: "+this.name);
        Console.WriteLine("레벨: "+this.level);
    }
}*/
///과제 13: 다양한 필드 타입 활용
/*Person p = new Person();
p.showprofile();
class Person
{
    private string name = "홍길동";
    private const int age = 21;
    private readonly string nickname = "길동이";
    private string[] site = { "네이버", "구글" };

    public void showprofile()
    {
        Console.WriteLine("이름: "+name);
        Console.WriteLine("나이: "+age);
        Console.WriteLine("닉네임: "+nickname);
        Console.WriteLine("사이트: "+string.Join(",",site));
    }
}*/
///과제 14: 게임 캐릭터 클래스
GameCharacter hero = new GameCharacter("용사",15);
GameCharacter mage = new GameCharacter("마법사", 25);
hero.showstatus();
Console.WriteLine();
mage.showstatus();
Console.WriteLine();

hero.takedamage(30);
hero.takedamage(50);
hero.takedamage(50);
Console.WriteLine();
GameCharacter.showtotalcharacher();
class GameCharacter
{
    private string name;
    private int Health;
    private int Attack;
    private static int charchercount = 0;
    private readonly int MaxHealth = 100;
    private const int minHealth = 0;

    public GameCharacter(string name,int attack)
    {
        this.name = name;
        this.Health = MaxHealth;
        Attack = attack;
        charchercount++;
    }
    public void takedamage(int damage)
    {
        Health = Health - damage;
        if (Health < minHealth)
        {
            Health = minHealth;
        }
        Console.WriteLine($"{name}이(가) {damage} 데미지를 받음! 남은체력: {Health} ");
    }
    public void showstatus()
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine($"체력: {Health}/{MaxHealth}");
        Console.WriteLine($"공격력: {Attack}");
    }
    public static void showtotalcharacher()
    {
        Console.WriteLine("총 캐릭터의 수: "+charchercount);
    }
    
}