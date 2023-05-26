using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TextGenetatorScript : MonoBehaviour
{
    int gameLanguage = DataHolder.language;
    string gameCategory = DataHolder.myCategory;
   
    private string[] schoolCategoryEng = { "Teacher" , "Student" , "Classroom" , "Book" , "Backpack" , "Schedule" , "Vacation" , "Lesson" , "Break" , "Grade" , "Assignment" ,
                                       "School bus" , "Cafeteria" , "School uniform" , "Library" , "Summer camp" , "Principal" , "Exam" , "Diary" , "Presentation" , "PE" ,
                                       "Playground" , "Student council" , "School photo" , "Bell"}; //25

    private string[] gymCategoryEng = { "Parallel bars" , "Locker room" , "Trampoline" , "Kettlebell" , "Jump rope" , "Fitness ball" , "Back day" , "Punching bag" , "Exercise mat" , 
                                        "Trainer" , "Barbell" , "Dumbells" , "Workout" , "Exercise" , "Training program" , "Treadmill" , "Exercise bike" , "Pull-ups" , "Squats" ,
                                        "Bench press" , "Cardio" , "Stretching" , "Calf raise" , "Resistance band" , "bar" };

    private string[] petCategoryEng = { "Dog" , "Cat" , "Hamster" , "Parrot" , "Pet store" , "Turtle" , "Horse" , "Snake" , "Bird" ,
                                        "Rat" , "Toy" , "Frog" , "Pigeon" , "Hedgehog" , "Gold fish" , "Snail" , "Goose" , "Monkey" , "Veterinarian" ,
                                        "Rooster" , "Axolotl" , "Lizard" , "Treat" , "Doghouse" , "Birdcage" };

    private string[] spaceCategoryEng = { "Star" , "Planet" , "Galaxy" , "Spaceship" , "Astronaut" , "Moon" , "Sun" , "Black hole" , "Mars" ,
                                        "Satellite" , "Aliens" , "Asteroid" , "Space station" , "Universe" , "Comet" , "Gravity" , "Space telescope" , "Milky way" , "Pluto" ,
                                        "Atmosphere" , "Meteorite" , "Eclipse" , "Vacuum" , "Astronomer" , "Solar system" };

    private string[] animeCategoryEng = { "Anime" , "Manga" , "Otaku" , "Senpai" , "Kohai" , "Cosplay" , "Fandom" , "Studio" , "One piece" ,
                                        "Naruto" , "Dattebayo" , "Attack on Titan" , "Death Note" , "Fairy Tail" , "Pokemon" , "Fullmetal Alchemist" , "Tokyo ghoul" , "Cowboy Bebop" , "Dragon Ball Z" ,
                                        "One Punch Man" , "Sword Art Online" , "Basketball Kuroko" , "K-On" , "Demon Slayer" , "Blue Lock" };

    private string[] filmsCategoryEng = { "Premiere" , "Camera" , "Special Effects" , "Film Studio" , "Costumes" , "Awards" , "Genre" , "Hollywood" , "Interstellar" ,
                                        "Acter" , "Will Smith" , "Tom Hanks" , "Marvel" , "DC" , "Batman" , "Superman" , "Spider-man" , "Leonardo Dicaprio" , "Avatar" ,
                                        "Blade Runner 2049" , "Ryan Gosling" , "Green Book" , "Green Mile" , "Shawshank Redemption" , "Forest Gump" };



    private string[] schoolCategoryRus = { "�������" , "������" , "�����" , "�����" , "������" , "����������" , "��������" , "����" , "��������" , "������" , "�������� �������" ,
                                       "�������� �������" , "��������" , "�������� �����" , "����������" , "������ ������" , "��������" , "�������" , "�������" , "�����������" , "���-��" ,
                                       "���������� ��������" , "�������� �����" , "���� � �������" , "������"}; //25

    private string[] gymCategoryRus = { "������" , "����������" , "�����" , "����" , "��������" , "��� ��� �������" , "���� �����" , "���������� �����" , "�������������� ������" ,
                                        "������" , "������" , "���� ���" , "����������" , "����������" , "������������� ���������" , "������� �������" , "������������" , "������������" , "����������" ,
                                        "��� ������ ����" , "������" , "��������" , "������ �� �����" , "��������" , "����" };

    private string[] petCategoryRus= { "������" , "�����" , "�����" , "�������" , "����������" , "��������" , "������" , "����" , "�����" ,
                                        "�����" , "�������" , "�������" , "������" , "����" , "������� �����" , "������" , "����" , "��������" , "���������" ,
                                        "�����" , "���������" , "�������" , "���������" , "�����" , "������ ������"};

    private string[] spaceCategoryRus = { "������" , "�������" , "���������" , "����������� �������" , "���������" , "����" , "������" , "������ ����" , "����" ,
                                        "�������" , "���������" , "��������" , "����������� �������" , "���������" , "������" , "����������" , "����������� ��������" , "������� ����" , "������" ,
                                        "���������" , "��������" , "��������" , "������" , "��������" , "��������� �������" };

    private string[] animeCategoryRus = { "�����" , "�����" , "�����" , "������" , "�����" , "�������" , "������" , "������" , "���-���" ,
                                        "������" , "Dattebayo" , "����� �������" , "������� ������" , "����� ����" , "�������" , "�������� �������" , "��������� ����" , "������ �����" , "���������� ���" ,
                                        "���-�������" , "������� ���� ������" , "��������� ������" , "�-��" , "������, ����������� �������" , "����� ������" };

    private string[] filmsCategoryRus = { "��������" , "������" , "����������� �������" , "����������" , "�������" , "�������" , "����" , "��������" , "������������" ,
                                        "����" , "���� ����" , "��� �����" , "������" , "��" , "������" , "��������" , "�������-����" , "�������� ��������" , "������" ,
                                        "������� �� ������ 2049" , "���� �������" , "������ �����" , "������ ����" , "����� �� ��������" , "������� ����" };

    public Text mainText;
    private int wordIndex;

    public void Awake()
    {
        wordIndex = Random.Range(0, 25);
        if (gameLanguage == 1)
        {
            switch (gameCategory)
            {
                case "School":
                    generateWord(schoolCategoryEng);
                    break;
                case "Gym":
                    generateWord(gymCategoryEng);
                    break;
                case "Pets":
                    generateWord(petCategoryEng);
                    break;
                case "Space":
                    generateWord(spaceCategoryEng);
                    break;
                case "Films":
                    generateWord(filmsCategoryEng);
                    break;
                case "Anime":
                    generateWord(animeCategoryEng);
                    break;

            }
        }
        else
        {
            switch (gameCategory)
            {
                case "School":
                    generateWord(schoolCategoryRus);
                    break;
                case "Gym":
                    generateWord(gymCategoryRus);
                    break;
                case "Pets":
                    generateWord(petCategoryRus);
                    break;
                case "Space":
                    generateWord(spaceCategoryRus);
                    break;
                case "Films":
                    generateWord(filmsCategoryRus);
                    break;
                case "Anime":
                    generateWord(animeCategoryRus);
                    break;

            }
        }
    }
    public void generateWord(string [] category)
    {
        mainText.text = category[wordIndex];
        Debug.Log(mainText.text);
        while (mainText.text == DataHolder.repeatWord)
        {
            wordIndex = Random.Range(0, 25);
            mainText.text = category[wordIndex];
        }
        Debug.Log(mainText.text);
        DataHolder.repeatWord = mainText.text;
    }
}
