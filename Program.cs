namespace ConsoleLearn
{
    public class Program
    {
        static void Main()
        {
            int countStudents;
            do
            {
                Console.WriteLine("Введите количество студентов (2<=n<=100):");
                countStudents = Convert.ToInt32(Console.ReadLine());
            } while (!(2 <= countStudents && countStudents <= 100));
            int[] studentsCountMessage = new int[countStudents + 1];
            for (int i = 1; i < studentsCountMessage.Length; i++)
            {
                Console.WriteLine($"Введите количество сообщений для {i}-го студента:");
                studentsCountMessage[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (studentsCountMessage.Sum() < countStudents)
            {
                Console.WriteLine($"-1");
            }
            else
            {
                int[] news = new int[countStudents + 1];
                for (int i = 0; i < news.Length; i++)
                {
                    news[i] = 0;//Новостью никто не владеет
                }
                news[1] = 1; //Староста узнал о новости

                for (int i = 1; (i < studentsCountMessage.Length && news[i] ==1 ); i++)
                {
                    for (int j = 0; j < studentsCountMessage[i]; j++)
                    {
                        if ((i + 1 + j) < news.Length && news[i + 1 + j] == 0)
                        {
                            news[i + 1 + j] = 1; Console.WriteLine($"Студент № {i} отправил сообщение студенту №{i + 1 + j}");
                        }
                        else
                        {
                            studentsCountMessage[i] = studentsCountMessage[i] + 1;
                        }

                    }

                }

            }
        }

    }
}

