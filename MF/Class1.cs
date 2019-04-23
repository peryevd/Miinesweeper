using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF
{
        class Field
        {
            int[,] masField;
            int length, height, bomb_count;

            public Field(int dlin, int shir, int kol)
            {
                length = dlin;
                height = shir;
                bomb_count = kol;

                masField = new int[length, height];

                Random rand = new Random();

                //разбрасывание бомб
                while (bomb_count > 0)
                {
                    int i_rand = rand.Next(0, length);
                    int j_rand = rand.Next(0, height);

                    if (masField[i_rand, j_rand] != bomb_count)
                    {
                        masField[i_rand, j_rand] = 10;
                        bomb_count--;
                    }
                    else bomb_count++;
                }

                //заполнение остальных значений нулями
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (masField[i, j] != 10) masField[i, j] = 0;
                    }
                }

                //заполнение остальных ячеек
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (masField[i, j] == 10)
                        {
                            if (i > 0 && j > 0) if (masField[i - 1, j - 1] != 10) masField[i - 1, j - 1]++;//ЛВ
                            if (j > 0) if (masField[i, j - 1] != 10) masField[i, j - 1]++;//СВ
                            if (i < length - 1 && j > 0) if (masField[i + 1, j - 1] != 10) masField[i + 1, j - 1]++;//ПВ

                            if (i > 0) if (masField[i - 1, j] != 10) masField[i - 1, j]++;//ЛС
                            if (i < length - 1) if (masField[i + 1, j] != 10) masField[i + 1, j]++;//ПС

                            if (i > 0 && j < height - 1) if (masField[i - 1, j + 1] != 10) masField[i - 1, j + 1]++;//ЛН
                            if (j < height - 1) if (masField[i, j + 1] != 10) masField[i, j + 1]++;//СН
                            if (i < length - 1 && j < height - 1) if (masField[i + 1, j + 1] != 10) masField[i + 1, j + 1]++;//ПН             
                        }
                    }
                }
            }

            public int[,] get()
            {
                return masField;
            }

            public void Out()
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Console.Write(" " + masField[i, j] + " ");
                    }
                    Console.Write("\n");
                }
            }
        }
 
}
