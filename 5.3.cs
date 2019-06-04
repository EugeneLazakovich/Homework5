using System;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] field = new char[11][];
            Random medRnd = new Random();
            Random bombRnd = new Random();
            int med;
            int bomb;
            char medCh = '+';
            char bombCh = '*';
            char check;
            int hp = 100;
            Boolean flag = true;
            for(int i = 0; i < field.Length; i++)
            {
                if (i == 0)
                {
                    med = medRnd.Next(1, field.Length - 1);
                }
                else
                {
                    med = medRnd.Next(0, field.Length - 1);
                }
                do
                {
                    bomb = bombRnd.Next(0, field.Length - 1);
                } while (med == bomb);
                field[i] = new char[11];
                for(int j = 0; j < field[i].Length; j++)
                {
                    field[0][0] = '@';
                    if (i == field.Length - 1)
                    {
                        field[i][j] = ' ';
                    }
                    else
                    {
                        field[i][j] = '_';
                        field[i][med] = medCh;
                        field[i][bomb] = bombCh;
                        field[i][field[i].Length - 1] = ' ';
                    }
                }
            }
            for(int i = 0; i < field.Length; i++)
            {
                for(int j = 0; j < field.Length; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(" hp=" + hp);
            for (int i = 0; i < 1000; i++)
            {
                string button = Console.ReadLine();
                Console.Clear();
                if (button == "d")
                {
                    for(int j = 0; j < field.Length; j++)
                    {
                        for(int k = 0; k < field[j].Length; k++)
                        {
                            if (field[j][k] == '@')
                            {                                
                                if (k == field[j].Length - 2)
                                {                                    
                                    if (field[j][0] == '+')
                                    {
                                        field[j][0] = '_';
                                        hp += 40;
                                    }
                                    if (field[j][0] == '*')
                                    {
                                        field[j][0] = '_';
                                        hp -= 40;
                                    }
                                    check = field[j][k];
                                    field[j][k] = field[j][0];
                                    field[j][0] = check;
                                    break;
                                }
                                if (field[j][k + 1] == '+')
                                {
                                    field[j][k + 1] = '_';
                                    hp += 40;
                                }
                                if (field[j][k + 1] == '*')
                                {
                                    field[j][k + 1] = '_';
                                    hp -= 40;
                                }
                                check = field[j][k];                                
                                field[j][k] = field[j][k + 1];
                                field[j][k + 1] = check;
                                if (j == field.Length - 2 && k == field[j].Length - 3)
                                {
                                    flag = false;
                                }
                                break;
                            }                            
                        }
                    }
                    hp -= 5;                    
                }
                if (button == "a")
                {
                    for (int j = 0; j < field.Length; j++)
                    {
                        for (int k = 0; k < field[j].Length; k++)
                        {
                            if (field[j][k] == '@')
                            {                                
                                if (k == 0)
                                {                                    
                                    if (field[j][field[j].Length - 2] == '+')
                                    {
                                        field[j][field[j].Length - 2] = '_';
                                        hp += 40;
                                    }
                                    if (field[j][field[j].Length - 2] == '*')
                                    {
                                        field[j][field[j].Length - 2] = '_';
                                        hp -= 40;
                                    }
                                    check = field[j][k];
                                    field[j][k] = field[j][field[j].Length - 2];
                                    field[j][field[j].Length - 2] = check;
                                    if (j == field.Length - 2)
                                    {
                                        flag = false;
                                    }
                                    break;
                                }                                
                                if (field[j][k - 1] == '+')
                                {
                                    field[j][k - 1] = '_';
                                    hp += 40;
                                }
                                if (field[j][k - 1] == '*')
                                {
                                    field[j][k - 1] = '_';
                                    hp -= 40;
                                }
                                check = field[j][k];
                                field[j][k] = field[j][k - 1];
                                field[j][k - 1] = check;                                
                                break;
                            }
                        }
                    }
                    hp -= 5;
                }
                if (button == "w")
                {
                    for (int j = 0; j < field.Length; j++)
                    {
                        Boolean flagCh = false;
                        for (int k = 0; k < field[j].Length; k++)
                        {
                            if (field[j][k] == '@')
                            {
                                flagCh = true;                               
                                if (j == 0)
                                {                                    
                                    if (field[field.Length - 2][k] == '+')
                                    {
                                        field[field.Length - 2][k] = '_';
                                        hp += 40;
                                    }
                                    if (field[field.Length - 2][k] == '*')
                                    {
                                        field[field.Length - 2][k] = '_';
                                        hp -= 40;
                                    }
                                    check = field[j][k];
                                    field[j][k] = field[field.Length-2][k];
                                    field[field.Length-2][k] = check;
                                    if (k == field[j].Length - 2)
                                    {
                                        flag = false;
                                    }
                                    break;
                                }                                
                                if (field[j - 1][k] == '+')
                                {
                                    field[j - 1][k] = '_';
                                    hp += 40;
                                }
                                if (field[j - 1][k] == '*')
                                {
                                    field[j - 1][k] = '_';
                                    hp -= 40;
                                }
                                check = field[j][k];
                                field[j][k] = field[j - 1][k];
                                field[j - 1][k] = check;                                
                                break;
                            }
                        }
                        if (flagCh == true)
                        {
                            break;
                        }
                    }
                    hp -= 5;
                }
                if (button == "s")
                {
                    for (int j = 0; j < field.Length; j++)
                    {
                        Boolean flagCh = false;
                        for (int k = 0; k < field[j].Length; k++)
                        {
                            if (field[j][k] == '@')
                            {
                                flagCh = true;                                
                                if (j == field.Length - 2)
                                {                                    
                                    if (field[j][k] == '+')
                                    {
                                        field[j][k] = '_';
                                        hp += 40;
                                    }
                                    if (field[j][k] == '*')
                                    {
                                        field[j][k] = '_';
                                        hp -= 40;
                                    }
                                    check = field[j][k];
                                    field[j][k] = field[0][k];
                                    field[0][k] = check;
                                    break;
                                }
                                if (field[j + 1][k] == '+')
                                {
                                    field[j + 1][k] = '_';
                                    hp += 40;
                                }
                                if (field[j + 1][k] == '*')
                                {
                                    field[j + 1][k] = '_';
                                    hp -= 40;
                                }
                                check = field[j][k];
                                field[j][k] = field[j + 1][k];
                                field[j + 1][k] = check;
                                if (j == field.Length - 3 && k == field[j].Length - 2)
                                {
                                    flag = false;
                                }
                                break;
                            }
                        }
                        if (flagCh)
                        {
                            break;
                        }
                    }
                    hp -= 5;
                }
                if (hp > 100)
                {
                    hp = 100;
                }
                if (hp <= 0)
                {
                    flag = false;
                }                
                for (int j = 0; j < field.Length; j++)
                {
                    Console.Write(field[j]);
                    Console.WriteLine();
                }
                Console.WriteLine(" hp=" + hp);
                if (flag == false)
                {
                    Console.WriteLine("GAME OVER!!!");
                    break;
                }
            }            
        }
    }
}
