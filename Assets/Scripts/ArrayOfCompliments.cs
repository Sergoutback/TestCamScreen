using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrayOfCompliments : MonoBehaviour
{
    public Text TextArrOfCompl;
    public string text;


    public void TextArr()
    {
        // TextArrOfCompl.text = ("Script2 start").ToString();
        List<string> myArr = new List<string>
            {
            "Yes, of course! You are so beauty!",
            "Your mind is just as sexy as your beauty",
            "I miss your smile",
            "You’re an amazing friend",
            "I can’t believe I found someone like you",
            "I get excited every time I see you",
            "I love making you laugh",
            "You’re my best friend",
            "I’ll always have your back",
            "I love every inch of you— even your toes",
            "You’ve got a sexy personality",
            "You’re my queen",
            "I miss you even when you haven’t left yet",
            "I feel lucky to be with you",
            "You always know how to make me feel at home",
            "I can fully be myself with you",
            "I love your style",
            "I love when you take care of me, now it’s your turn",
            "You complete everything I’ve ever wanted in a woman",
            "You look beautiful even when you don’t try",
            "You make me want to be my best because you deserve the best",
            "You’re even sexy when you’re bossy",
            "The more I learn about you, the more I fall",
            "You’re even more beautiful in the morning",
            "I love talking to you",
            "I wouldn’t mind growing old and fat with you",
            "Your lips always look kissable",
            "I could kiss you forever",
            "I could have sex with you forever",
            "You’re a great kisser",
            "You’re the best at cuddling",
            "You could pick your nose and I still wouldn’t be turned-off",
            "You deserve the world",
            "I never knew what it meant to be a man until I met you",
            "The best part of my day is waking up next to you",
            "I have fun just being beside you doing nothing",
            "You have my heart",
            "You’re the better part of me",
            "You showed me I’m capable of having the best relationship in the world",
            "I won the jackpot with you",
            "You deserve the most beautiful things",
            "You’re a gem",
            "You’re my family",
            "Even when you’re grouchy, I love you",
            "I’d climb a mountain for you",
            "If we were in the Middle Ages, I’d fight a dragon for you",
            "I’m always looking forward to our next adventure",
            "You make me happy",
            "You have all my respect",
            "You make me feel like I can touch the sky",
            "The hardest part of hugging you is letting you go",
            "You have the sweetest heart",
            "You taught me the difference between a girl and a woman",
            "I love looking at you",
            "You light up my life like nobody else",
            "Your cooking is amazing",
            "I never thought it could be this good",
            "I feel most alive by your side",
            "I smile thinking about you when I’m alone",
            "You make commitment feel easy",
            "You’re everything to me",

            };
        System.Random rand = new System.Random();

        for (int i = myArr.Count; i > 0; i--)
        {
            int flag = rand.Next(myArr.Count);
            TextArrOfCompl.text = (myArr[flag]);
            myArr.RemoveAt(flag);
        }
    }
}
