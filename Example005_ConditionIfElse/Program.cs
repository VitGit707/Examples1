// Console.WriteLine("Example005_ConditionIfElse!");

Console.WriteLine("Введите Имя Пользователя: "); // Делаем приглашение ко вводу (просим ввести имя пользователя) 
string username = Console.ReadLine(); // Считываем данныем мы при помощи Console.ReadLine()

if (username.ToLower() == "маша")  // Мы хотим сделать проверку имени ползователя
{
    Console.WriteLine("Ура, это же Маша!!!!!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

