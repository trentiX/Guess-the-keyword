using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class TextGenetatorScript : MonoBehaviour
{
    int gameLanguage = DataHolder.language;
    string gameCategory = DataHolder.myCategory;

    private string[][] categoriesEng = {
        new string[] { "Teacher" , "Student" , "Classroom" , "Book" , "Backpack" , "Schedule" , "Vacation" , "Lesson" , "Break" , "Grade" , "Assignment" ,
            "School bus" , "Cafeteria" , "School uniform" , "Library" , "Summer camp" , "Principal" , "Exam" , "Diary" , "Presentation" , "PE" ,
            "Playground" , "Student council" , "School photo" , "Bell" }, // School
        new string[] { "Parallel bars" , "Locker room" , "Trampoline" , "Kettlebell" , "Jump rope" , "Fitness ball" , "Back day" , "Punching bag" , "Exercise mat" , 
            "Trainer" , "Barbell" , "Dumbells" , "Workout" , "Exercise" , "Training program" , "Treadmill" , "Exercise bike" , "Pull-ups" , "Squats" ,
            "Bench press" , "Cardio" , "Stretching" , "Calf raise" , "Resistance band" , "bar" }, // Gym
        new string[] { "Dog" , "Cat" , "Hamster" , "Parrot" , "Pet store" , "Turtle" , "Horse" , "Snake" , "Bird" ,
            "Rat" , "Toy" , "Frog" , "Pigeon" , "Hedgehog" , "Gold fish" , "Snail" , "Goose" , "Monkey" , "Veterinarian" ,
            "Rooster" , "Axolotl" , "Lizard" , "Treat" , "Doghouse" , "Birdcage" }, // Pets
        new string[] { "Star" , "Planet" , "Galaxy" , "Spaceship" , "Astronaut" , "Moon" , "Sun" , "Black hole" , "Mars" ,
            "Satellite" , "Aliens" , "Asteroid" , "Space station" , "Universe" , "Comet" , "Gravity" , "Space telescope" , "Milky way" , "Pluto" ,
            "Atmosphere" , "Meteorite" , "Eclipse" , "Vacuum" , "Astronomer" , "Solar system" }, // Space
        new string[] { "Anime" , "Manga" , "Otaku" , "Senpai" , "Kohai" , "Cosplay" , "Fandom" , "Studio" , "One piece" ,
            "Naruto" , "Dattebayo" , "Attack on Titan" , "Death Note" , "Fairy Tail" , "Pokemon" , "Fullmetal Alchemist" , "Tokyo ghoul" , "Cowboy Bebop" , "Dragon Ball Z" ,
            "One Punch Man" , "Sword Art Online" , "Basketball Kuroko" , "K-On" , "Demon Slayer" , "Blue Lock" }, // Anime
        new string[] { "Premiere" , "Camera" , "Special Effects" , "Film Studio" , "Costumes" , "Awards" , "Genre" , "Hollywood" , "Interstellar" ,
            "Acter" , "Will Smith" , "Tom Hanks" , "Marvel" , "DC" , "Batman" , "Superman" , "Spider-man" , "Leonardo Dicaprio" , "Avatar" ,
            "Blade Runner 2049" , "Ryan Gosling" , "Green Book" , "Green Mile" , "Shawshank Redemption" , "Forest Gump" } // Films
    };

    private string[][] categoriesRus = {
        new string[] { "Ó÷èòåëü", "Ó÷åíèê", /*...*/ "Çâîíîê" }, // School
        new string[] { "Áðóñüÿ", "Ðàçäåâàëêà", /*...*/ "Ãðèô" }, // Gym
        new string[] { "Ñîáàêà", "Êîøêà", /*...*/ "Ïòè÷üÿ êëåòêà" }, // Pets
        new string[] { "Çâåçäà", "Ïëàíåòà", /*...*/ "Ñîëíå÷íàÿ ñèñòåìà" }, // Space
        new string[] { "Àíèìå", "Ìàíãà", /*...*/ "Ñèíèÿ Òþðüìà" }, // Anime
        new string[] { "Ïðåìüåðà", "Êàìåðà", /*...*/ "Ôîððåñò Ãàìï" } // Films
    };

    public Text mainText;
    private int wordIndex;

    void Awake()
    {
        string[] selectedCategory = SelectCategory();
        if (selectedCategory != null)
        {
            GenerateWord(selectedCategory);
        }
    }

    string[] SelectCategory()
    {
        if (gameLanguage == 1) // English
        {
            switch (gameCategory)
            {
                case "School": return categoriesEng[0];
                case "Gym": return categoriesEng[1];
                case "Pets": return categoriesEng[2];
                case "Space": return categoriesEng[3];
                case "Anime": return categoriesEng[4];
                case "Films": return categoriesEng[5];
            }
        }
        else // Russian
        {
            switch (gameCategory)
            {
                case "School": return categoriesRus[0];
                case "Gym": return categoriesRus[1];
                case "Pets": return categoriesRus[2];
                case "Space": return categoriesRus[3];
                case "Anime": return categoriesRus[4];
                case "Films": return categoriesRus[5];
            }
        }
        return null;
    }

    void GenerateWord(string[] category)
    {
        DataHolder.categoryOfWord = category;
        do
        {
            wordIndex = Random.Range(0, category.Length);
            mainText.text = category[wordIndex];
        } while (mainText.text == DataHolder.repeatWord);

        DataHolder.repeatWord = mainText.text;
        Debug.Log(mainText.text);
    }
}
