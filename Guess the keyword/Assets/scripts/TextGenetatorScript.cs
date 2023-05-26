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



    private string[] schoolCategoryRus = { "Учитель" , "Ученик" , "Класс" , "Книга" , "Рюкзак" , "Расписание" , "Каникулы" , "Урок" , "Перемена" , "Оценка" , "Домашние задание" ,
                                       "Школьный автобус" , "Столовая" , "Школьная форма" , "Библеотека" , "Летний лагерь" , "Директор" , "Экзамен" , "Дневник" , "Презентация" , "Физ-ра" ,
                                       "Спортивная площадка" , "Школьный совет" , "Фото с классом" , "Звонок"}; //25

    private string[] gymCategoryRus = { "Брусья" , "Раздевалка" , "Батут" , "Гиря" , "Скакалка" , "Мяч для фитнеса" , "День спины" , "Боксерская груша" , "Гимнастический коврик" ,
                                        "Тренер" , "Штанга" , "День ног" , "Тренировка" , "Упражнение" , "Тренировочная программа" , "Беговая дорожка" , "Велотренажер" , "Подтягивания" , "Приседания" ,
                                        "Жим штанги лежа" , "Кардио" , "Растяжка" , "Подъем на носки" , "Эспандер" , "Гриф" };

    private string[] petCategoryRus= { "Собака" , "Кошка" , "Хомяк" , "Попугай" , "Зоомагазин" , "Черепаха" , "Лошадь" , "Змея" , "Птица" ,
                                        "Крыса" , "Игрушка" , "Лягушка" , "Голубь" , "Ёжик" , "Золотая рыбка" , "Улитка" , "Гусь" , "Обезьяна" , "Ветеринар" ,
                                        "Петух" , "Аксолотль" , "Ящерица" , "Лакомство" , "Будка" , "Птичья клетка"};

    private string[] spaceCategoryRus = { "Звезда" , "Планета" , "Галактика" , "Космический корабль" , "Астронавт" , "Луна" , "Солнце" , "Черная дыра" , "Марс" ,
                                        "Спутник" , "Прищельцы" , "Астероид" , "Космическая станция" , "Вселенная" , "Комета" , "Гравитация" , "Космический телескоп" , "Млечный путь" , "Плутон" ,
                                        "Атмосфера" , "Метеорит" , "Затмение" , "Вакуум" , "Астроном" , "Солнечная система" };

    private string[] animeCategoryRus = { "Аниме" , "Манга" , "Отаку" , "Сенпай" , "Кохай" , "Косплей" , "Фандом" , "Студия" , "Ван-пис" ,
                                        "Наруто" , "Dattebayo" , "Атака Титанов" , "Тетрадь Смерти" , "Фейри Тейл" , "Покемон" , "Стальной Алхимик" , "Токийский Гуль" , "Ковбой Бебоп" , "Драгонболл Зет" ,
                                        "Ван-Панчмен" , "Мастера меча онлайн" , "Баскетбол Куроко" , "К-Он" , "Клинок, рассекающий демонов" , "Синия Тюрьма" };

    private string[] filmsCategoryRus = { "Премьера" , "Камера" , "Специальные эффекты" , "Киностудия" , "Костюмы" , "Награды" , "Жанр" , "Голливуд" , "Интерстеллар" ,
                                        "Актёр" , "Уилл Смит" , "Том Хенкс" , "Марвел" , "ДС" , "Бэтмен" , "Супермэн" , "Человек-паук" , "Леонардо Дикаприо" , "Аватар" ,
                                        "Бегущий по лезвию 2049" , "Раян Гослинг" , "Зелёная книга" , "Зелёная миля" , "Побег из Шоушенка" , "Форрест Гамп" };

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
