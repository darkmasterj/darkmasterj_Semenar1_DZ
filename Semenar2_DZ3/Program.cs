Console.Write(" Давай узнаем выходной день или нет  "); 
            while (true) 
            { 
                Console.Write("\n Введите номер дня недели  "); 
                int num = int.Parse(Console.ReadLine()); 
                if (num >= 1 && num <= 5) 
                { 
                    Console.Write(" Нет, это не выходной"); 
                } 
 
                else if (num >= 6 && num <= 7) 
                { 
                    Console.Write(" Да, это выходной"); 
                } 
                else Console.Write(" В неделе всего 7 дней! Давай по новой!"); 
            } 