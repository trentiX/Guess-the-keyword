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



    private string[] schoolCategoryRus = { "Ó÷èòåëü" , "Ó÷åíèê" , "Êëàññ" , "Êíèãà" , "Ðþêçàê" , "Ðàñïèñàíèå" , "Êàíèêóëû" , "Óðîê" , "Ïåðåìåíà" , "Îöåíêà" , "Äîìàøíèå çàäàíèå" ,
                                       "Øêîëüíûé àâòîáóñ" , "Ñòîëîâàÿ" , "Øêîëüíàÿ ôîðìà" , "Áèáëåîòåêà" , "Ëåòíèé ëàãåðü" , "Äèðåêòîð" , "Ýêçàìåí" , "Äíåâíèê" , "Ïðåçåíòàöèÿ" , "Ôèç-ðà" ,
                                       "Ñïîðòèâíàÿ ïëîùàäêà" , "Øêîëüíûé ñîâåò" , "Ôîòî ñ êëàññîì" , "Çâîíîê"}; //25

    private string[] gymCategoryRus = { "Áðóñüÿ" , "Ðàçäåâàëêà" , "Áàòóò" , "Ãèðÿ" , "Ñêàêàëêà" , "Ìÿ÷ äëÿ ôèòíåñà" , "Äåíü ñïèíû" , "Áîêñåðñêàÿ ãðóøà" , "Ãèìíàñòè÷åñêèé êîâðèê" ,
                                        "Òðåíåð" , "Øòàíãà" , "Äåíü íîã" , "Òðåíèðîâêà" , "Óïðàæíåíèå" , "Òðåíèðîâî÷íàÿ ïðîãðàììà" , "Áåãîâàÿ äîðîæêà" , "Âåëîòðåíàæåð" , "Ïîäòÿãèâàíèÿ" , "Ïðèñåäàíèÿ" ,
                                        "Æèì øòàíãè ëåæà" , "Êàðäèî" , "Ðàñòÿæêà" , "Ïîäúåì íà íîñêè" , "Ýñïàíäåð" , "Ãðèô" };

    private string[] petCategoryRus= { "Ñîáàêà" , "Êîøêà" , "Õîìÿê" , "Ïîïóãàé" , "Çîîìàãàçèí" , "×åðåïàõà" , "Ëîøàäü" , "Çìåÿ" , "Ïòèöà" ,
                                        "Êðûñà" , "Èãðóøêà" , "Ëÿãóøêà" , "Ãîëóáü" , "¨æèê" , "Çîëîòàÿ ðûáêà" , "Óëèòêà" , "Ãóñü" , "Îáåçüÿíà" , "Âåòåðèíàð" ,
                                        "Ïåòóõ" , "Àêñîëîòëü" , "ßùåðèöà" , "Ëàêîìñòâî" , "Áóäêà" , "Ïòè÷üÿ êëåòêà"};

    private string[] spaceCategoryRus = { "Çâåçäà" , "Ïëàíåòà" , "Ãàëàêòèêà" , "Êîñìè÷åñêèé êîðàáëü" , "Àñòðîíàâò" , "Ëóíà" , "Ñîëíöå" , "×åðíàÿ äûðà" , "Ìàðñ" ,
                                        "Ñïóòíèê" , "Ïðèùåëüöû" , "Àñòåðîèä" , "Êîñìè÷åñêàÿ ñòàíöèÿ" , "Âñåëåííàÿ" , "Êîìåòà" , "Ãðàâèòàöèÿ" , "Êîñìè÷åñêèé òåëåñêîï" , "Ìëå÷íûé ïóòü" , "Ïëóòîí" ,
                                        "Àòìîñôåðà" , "Ìåòåîðèò" , "Çàòìåíèå" , "Âàêóóì" , "Àñòðîíîì" , "Ñîëíå÷íàÿ ñèñòåìà" };

    private string[] animeCategoryRus = { "Àíèìå" , "Ìàíãà" , "Îòàêó" , "Ñåíïàé" , "Êîõàé" , "Êîñïëåé" , "Ôàíäîì" , "Ñòóäèÿ" , "Âàí-ïèñ" ,
                                        "Íàðóòî" , "Dattebayo" , "Àòàêà Òèòàíîâ" , "Òåòðàäü Ñìåðòè" , "Ôåéðè Òåéë" , "Ïîêåìîí" , "Ñòàëüíîé Àëõèìèê" , "Òîêèéñêèé Ãóëü" , "Êîâáîé Áåáîï" , "Äðàãîíáîëë Çåò" ,
                                        "Âàí-Ïàí÷ìåí" , "Ìàñòåðà ìå÷à îíëàéí" , "Áàñêåòáîë Êóðîêî" , "Ê-Îí" , "Êëèíîê, ðàññåêàþùèé äåìîíîâ" , "Ñèíèÿ Òþðüìà" };

    private string[] filmsCategoryRus = { "Ïðåìüåðà" , "Êàìåðà" , "Ñïåöèàëüíûå ýôôåêòû" , "Êèíîñòóäèÿ" , "Êîñòþìû" , "Íàãðàäû" , "Æàíð" , "Ãîëëèâóä" , "Èíòåðñòåëëàð" ,
                                        "Àêò¸ð" , "Óèëë Ñìèò" , "Òîì Õåíêñ" , "Ìàðâåë" , "ÄÑ" , "Áýòìåí" , "Ñóïåðìýí" , "×åëîâåê-ïàóê" , "Ëåîíàðäî Äèêàïðèî" , "Àâàòàð" ,
                                        "Áåãóùèé ïî ëåçâèþ 2049" , "Ðàÿí Ãîñëèíã" , "Çåë¸íàÿ êíèãà" , "Çåë¸íàÿ ìèëÿ" , "Ïîáåã èç Øîóøåíêà" , "Ôîððåñò Ãàìï" };

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
    
    public void CheckTheWord(string[] category, string answer)
    {
        int l = 0, r = category.Length - 1; 
  
        // Loop to implement Binary Search 
        while (l <= r) { 
  
            // Calculatiing mid 
            int m = l + (r - l) / 2; 
  
            int res = answer.CompareTo(category[m]); 
  
            // Check if x is present at mid 
            if (res == 0) 
                win(); 
  
            // If x greater, ignore left half 
            if (res > 0) 
                l = m + 1; 
  
            // If x is smaller, ignore right half 
            else
                r = m - 1; 
        } 
  
        return; 
    }
    public void win()
    {
        
    }
}
