using System;

namespace Module18_Task
{
    class UserAnswerHandler
    {
        public static void GetUserAnswer()
        {
            Console.WriteLine("Введите цифру 1, если желаете посмотреть информацию о видео, цифру 2, если желаете скачать видео, нажмите 3 для выхода");

            var sender = new Sender();
            var reciver = new Reciever();
            var commandShow = new CommandShowInfo(reciver);
            var commandDown = new CommandDownoadVideo(reciver);

            while (true)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        sender.SetCommand(commandShow);
                        sender.Run();
                        break;
                    case '2':
                        sender.SetCommand(commandDown);
                        sender.Run();
                        break;
                    case '3':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nЧто-что?");
                        break;
                }
            }

        }
    }
}
