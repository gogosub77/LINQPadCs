<Query Kind="Statements" />

string s = "こんにちは。";

//sがnullでないことを確認
if (s != null)
{
    //文字数を取得
    int len = s.Length;

    //結果を表示
    Console.WriteLine("「{0}」は {1}文字 です", s, len);
    //「こんにちは。」は 6文字 です
}