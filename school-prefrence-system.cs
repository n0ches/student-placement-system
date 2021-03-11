using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //The correct answers of the exam
            char[] key = new char[]        {'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'D' };
            //The correct answers of the exam

            //The answers of the candidates
            char[,] answers = new char[,] {{'A', 'D', 'B', 'B', ' ', 'C', 'A', 'A', 'B', ' ', 'A', 'B', 'A', 'A', 'A', 'A', 'C', 'A', 'C', 'D'}, 
                                           {'A', 'B', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'D', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'C', 'C'},
                                           {'A', 'D', 'A', 'B', 'D', 'C', 'A', 'A', 'B', 'C', 'A', 'B', 'A', 'B', ' ', 'C', 'C', 'A', ' ', 'D'},
                                           {'A', ' ', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', ' ', 'B', 'A', 'C', 'A', 'D', 'B'},
                                           {'C', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'D', 'C', 'A', 'A', 'A', 'A', 'B', 'D', 'C', 'A', 'B', 'D'},
                                           {'C', 'D', 'B', 'C', 'A', 'C', 'D', ' ', 'B', 'C', 'D', 'B', 'A', ' ', 'B', 'C', 'C', 'A', 'A', 'D'},
                                           {'A', 'D', 'C', 'C', 'D', 'C', 'D', 'C', 'B', 'C', 'A', 'C', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'A'},
                                           {'B', 'D', ' ', 'C', 'C', 'C', 'D', 'A', 'B', 'C', 'D', 'B', 'A', 'C', 'B', 'A', 'C', 'B', 'D', ' '},
                                           {'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'D', 'C', 'A', 'D', 'D'},
                                           {'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'D'},
                                           {'B', 'C', 'A', 'C', 'A', 'C', 'B', 'A', 'C', 'C', 'A', 'D', 'A', 'A', 'D', 'A', 'C', 'A', 'D', 'D'},
                                           {'A', 'D', 'B', 'B', ' ', 'C', 'A', 'A', 'B', ' ', 'A', 'B', 'A', 'A', 'A', 'A', 'C', 'A', 'C', 'D'},
                                           {'A', 'B', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'D', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'C', 'C'},
                                           {'A', 'D', 'A', 'B', 'D', 'C', 'A', 'A', 'B', 'C', 'A', 'B', 'A', 'B', ' ', 'C', 'C', 'A', ' ', 'D'},
                                           {'A', ' ', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', ' ', 'B', 'A', 'C', 'A', 'D', 'B'},
                                           {'C', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'D', 'C', 'A', 'A', 'A', 'A', 'B', 'D', 'C', 'A', 'B', 'D'},
                                           {'C', 'D', 'B', 'C', 'A', 'C', 'D', ' ', 'B', 'C', 'D', 'B', 'A', ' ', 'B', 'C', 'C', 'A', 'A', 'D'},
                                           {'A', 'D', 'C', 'C', 'D', 'C', 'D', 'C', 'B', 'C', 'A', 'C', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'A'},
                                           {'B', 'D', ' ', 'C', 'C', 'C', 'D', 'A', 'B', 'C', 'D', 'B', 'A', 'C', 'B', 'A', 'C', 'B', 'D', ' '},
                                           {'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'D', 'C', 'A', 'D', 'D'},
                                           {'A', 'D', 'B', 'C', 'D', 'C', 'D', 'A', 'B', 'C', 'A', 'B', 'A', 'A', 'B', 'A', 'C', 'A', 'D', 'D'},
                                           {'B', 'C', 'A', 'C', 'A', 'C', 'B', 'A', 'C', 'C', 'A', 'D', 'A', 'A', 'D', 'A', 'C', 'A', 'D', 'D'},
                                           {'A', ' ', 'B', 'B', 'A', 'C', 'B', 'A', 'C', 'C', 'A', 'D', 'A', 'A', 'D', 'A', 'C', 'A', 'D', 'D'},
                                           {'A', 'D', 'B', 'B', 'A', 'C', 'B', 'A', 'C', 'C', 'A', 'D', 'A', 'A', 'D', 'A', 'C', 'A', 'D', 'D'},};
            //The answers of the candidates

            //The candidates:                      (number,   name&surname, choice1,choice2,choice3)
            string[,] candidates = new string[,]  {{"2005", "Kadir Ozdemir","4","6","1"},
                                                   {"1844", "Hasan Guney","2","3","5"},
                                                   {"3020", "Sevilay Kıvılcım","5","6","3"},
                                                   {"2603", "Rıdvan Ozdemir","1","2","6"},
                                                   {"1903", "Mert Erdem","4","6","1"},
                                                   {"1907", "Emir Utku Bican","1","2","3"},
                                                   {"3520", "Furkan Boncuk","5","2","3"},
                                                   {"2710", "Furkan Kumustekin","4","3","5"},
                                                   {"1874", "Talha Boncuk","1","4","3"},
                                                   {"2280", "Berkay Yılmaz","5","2","1"},
                                                   {"3280", "Bilal Igdı","3","2"," "},
                                                   {"1999", "Ekrem Furkan Igdı","3","7","5"},
                                                   {"1654", "Bahadır Er","5","4","7"},
                                                   {"1724", "Talha Gulec","1","7","2"},
                                                   {"2024", "Kerem Kırgoz","1","","2"},
                                                   {"1963", "Yasin Yıldırım","1","2","6"},
                                                   {"2963", "Can Korkunç","5","1","7"},
                                                   {"2105", "Ali Terim","4","6","1"},
                                                   {"3144", "Ece Yaman","1","4","3"},
                                                   {"1020", "Ege Soylu","5","",""},
                                                   {"4280", "Ahmet Akkoyun","1","3","5"},
                                                   {"4580", "Aslı Kaymaz","7"," ","4"},
                                                   {"1320", "Gaye Solmaz","1","4","6"},
                                                   {"1523", "Haktan Ulu","2","7","1"},};
        
            //The candidates:                      (number,   name&surname, choice1,choice2,choice3)

            //The departments:                     (no,  department name)
            string[,] departments = new string[,] {{"1","COMPUTER ENGINEERING"},
                                                   {"2","ELECTRONICS ENGINEERING"},
                                                   {"3","ARCHITECTURE"},
                                                   {"4","MEDICINE"},
                                                   {"5","DENTISTRY"},
                                                   {"6","MATHEMATICS"},
                                                   {"7","PHYSICS"} };
            //The departments:                     (no,  department name)


            //Defining the score and assigning the score of the candidates
            int[] score = new int[candidates.GetLength(0)];

            int score1 = 0;
                for (int i = 0; i < answers.GetLength(0); i++)
                {
                    score1 = 0;
                    for (int j = 0; j < answers.GetLength(1); j++)
                    {
                        if (answers[i, j] == ' ')
                        {

                        }
                        else if (answers[i, j] == key[j])
                        {
                            score1 = score1 + 5;
                        }
                        else if (answers[i, j] != key[j])
                        {
                            score1 = score1 - 2;
                        }
                    }
                    score[i] = score1;
                    
                }
            //Defining the score and assigning the score of the candidates

            //Writing of candidates and their scores
            Console.WriteLine(" Number   Name&Surname      Score");
            for (int i = 0; i < candidates.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" "+candidates[i, j] + "    ");
                    
                }
                Console.Write("\n");
            }
            

            for (int i = 0; i < score.Length; i++)
            {
                Console.SetCursorPosition(29, i + 1);
                Console.WriteLine(score[i]);
            }
            //Writing of candidates and their scores

            //Ranking of candidates according to their scores
            string[,] temp = new string[1, 5]; // temp for candidates
            int temp33 = 0; //temp for scores
            for (int i = 0; i < score.Length; i++)
            {
                for (int j = 0; j < score.Length; j++)
                {
                    if (score[i] > score[j])                        //Logically, candidate who has got the highest score must be placed their first choice department, and then other
                    {                                              //candidates will be located their choices.So, I have to sort the candidates according to their scores.Thus, I   
                        temp33 = score[i];                        //can place all candidates to their choices easily.
                        score[i] = score[j];
                        score[j] = temp33;

                        for (int k = 0; k < 5; k++)
                        {
                            temp[0, k] = candidates[i, k];
                        }
                        for (int k = 0; k < 5; k++)
                        {
                            candidates[i, k] = candidates[j, k];
                        }
                        for (int k = 0; k < 5; k++)
                        {
                            candidates[j, k] = temp[0, k];
                        }
                    }
                }
            }
            //Ranking of candidates according to their scores
            
            //Defining the departments
            string[] computers = new string[4];
            string[] electronics = new string[4];
            string[] architecture = new string[4];
            string[] medicine = new string[4];
            string[] dentistry = new string[4];
            string[] mathematics = new string[4];
            string[] physics = new string[4];
            //Defining the departments

            //Defining the quota counters
            int computerCounter = 0;
            int electronicsCounter = 0;
            int architectureCounter = 0;           //Those variables count the candidates that in any department because quota of all department is 4.
            int medicineCounter = 0;              //So, if any variable of those is 4, it's deparment is full.
            int dentistryCounter = 0;
            int mathematicsCounter = 0;
            int physicsCounter = 0;
            int departCounter = 0;
            //Defining the quota counters

            //placement of candidates in departments
            for (int i = 0; i < candidates.GetLength(0); i++)
            {
                departCounter = 0;
                if (score[i] >= 50)
                {
                    for (int j = 2; j < candidates.GetLength(1); j++)
                    {
                        if (candidates[i, j] == "1" && departCounter == 0 && computerCounter <= 3)
                        {                                                                               //If candidate's first choice is 1 and candidate has not settled elsewhere before
                            if (computers[computerCounter] == null )                                   //and department quota is not full, candidate will placed here.If department  quota is full,
                            {                                                                         //program enters other else if's and check them all until candidate place any department...
                                computers[computerCounter] = candidates[i, 0];
                                computerCounter++; departCounter = 1;                                   
                            }
                            else
                            {
                                continue;
                            }

                        }
                        else if (candidates[i, j] == "2" && departCounter == 0 && electronicsCounter <= 3)
                        {
                            if (electronics[electronicsCounter] == null)                           //If candidate's first choice is 2 and candidate has not settled elsewhere before
                            {                                                                     //and department quota is not full, candidate will placed here.If department  quota is full,                 
                                electronics[electronicsCounter] = candidates[i, 0];              //program enters other else if's and check them all until candidate place any department...
                                electronicsCounter++; departCounter = 1;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        else if (candidates[i, j] == "3" && departCounter == 0 && architectureCounter <= 3)
                        {
                            if (architecture[architectureCounter] == null )
                            {                                                                               //If candidate's first choice is 3 and candidate has not settled elsewhere before
                                architecture[architectureCounter] = candidates[i, 0];                      //and department quota is not full, candidate will placed here.If department  quota is full,
                                architectureCounter++; departCounter = 1;                                 //program enters other else if's and check them all until candidate place any department...
                            }
                            else
                            {
                                continue;
                            }

                        }
                        else if (candidates[i, j] == "4" && departCounter == 0 && medicineCounter <= 3)
                        {
                            if (medicine[medicineCounter] == null )
                            {
                                medicine[medicineCounter] = candidates[i, 0];                       //If candidate's first choice is 4 and candidate has not settled elsewhere before
                                medicineCounter++; departCounter = 1;                               //and department quota is not full, candidate will placed here.If department  quota is full,
                            }                                                                       //program enters other else if's and check them all until candidate place any department...
                            else
                            {
                                continue;
                            }

                        }
                        else if (candidates[i, j] == "5" && departCounter == 0 && dentistryCounter <= 3)
                        {
                            if (dentistry[dentistryCounter] == null)
                            {                                                                       //If candidate's first choice is 5 and candidate has not settled elsewhere before
                                dentistry[dentistryCounter] = candidates[i, 0];                     //and department quota is not full, candidate will placed here.If department  quota is full,
                                dentistryCounter++; departCounter = 1;                              //program enters other else if's and check them all until candidate place any department...
                            }
                            else
                            {
                                continue;
                            }

                        }
                        else if (candidates[i, j] == "6" && departCounter == 0 && mathematicsCounter <= 3)
                        {
                            if (mathematics[mathematicsCounter] == null)                       //If candidate's first choice is 6 and candidate has not settled elsewhere before
                            {                                                                  //and department quota is not full, candidate will placed here.If department  quota is full,
                                mathematics[mathematicsCounter] = candidates[i, 0];            //program enters other else if's and check them all until candidate place any department...
                                mathematicsCounter++; departCounter = 1;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        else if (candidates[i, j] == "7" && departCounter == 0 && physicsCounter <= 3)
                        {
                            if (physics[physicsCounter] == null)                               //If candidate's first choice is 7 and candidate has not settled elsewhere before
                            {                                                                  //and department quota is not full, candidate will placed here.If department  quota is full,
                                physics[physicsCounter] = candidates[i, 0];                    //program enters other else if's and check them all until candidate place any department...
                                physicsCounter++; departCounter = 1;
                            }
                            else
                            {
                                continue;
                            }

                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            //placement of candidates in departments


            //Writing of departments and candidates (No, departments, students)
            Console.SetCursorPosition(0, candidates.GetLength(0) + 2);
            Console.WriteLine(" No       Departments                  Students");
            Console.WriteLine(" 1       Computer Engineering");
            Console.WriteLine(" 2       Electronics Engineering");
            Console.WriteLine(" 3       Architecture");
            Console.WriteLine(" 4       Medicine");
            Console.WriteLine(" 5       Dentistry");
            Console.WriteLine(" 6       Mathematics");
            Console.WriteLine(" 7       Physics");
            for (int i = 0; i < computers.Length; i++)
            {
                Console.SetCursorPosition(34 + 5*i, candidates.GetLength(0)+3);
                Console.Write(computers[i]);
            }
            for (int i = 0; i < electronics.Length; i++)
            {
                Console.SetCursorPosition(34 + 5 * i, candidates.GetLength(0) + 4);
                Console.Write(electronics[i]);
            }
            for (int i = 0; i < architecture.Length; i++)
            {
                Console.SetCursorPosition(34 + 5 * i, candidates.GetLength(0) + 5);
                Console.Write(architecture[i]);
            }
            for (int i = 0; i < medicine.Length; i++)
            {
                Console.SetCursorPosition(34 + 5 * i, candidates.GetLength(0) + 6);
                Console.Write(medicine[i]);
            }
            for (int i = 0; i < dentistry.Length; i++)
            {
                Console.SetCursorPosition(34 + 5 * i, candidates.GetLength(0) + 7);
                Console.Write(dentistry[i]);
            }
            for (int i = 0; i < mathematics.Length; i++)
            {
                Console.SetCursorPosition(34 + 5 * i, candidates.GetLength(0) + 8);
                Console.Write(mathematics[i]);
            }
            for (int i = 0; i < physics.Length; i++)
            {
                Console.SetCursorPosition(34 + 5 * i, candidates.GetLength(0) + 9);
                Console.Write(physics[i]);
            }
            //Writing of departments and candidates (No, departments, students)

            Console.ReadLine();


        }
    }
}
