Console.Write("Olá, digite seu nome: ");
string name = Console.ReadLine();

Console.Write($"Muito obrigado, {name}. Agora, por favor, insira o ano de seu nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = 2022 - year;

    if(age > 110){
        Console.WriteLine($"Wow! {name}, {age} anos! Praticamente um matusalém!");
    }else if(age < 110 && age >= 100){
        Console.WriteLine($"{name}, {age} anos!? Batendo o século hein?");
    }else if(age < 100 && age >= 18){
        Console.WriteLine($"{name}, você tem {age} anos, portanto, é maior de idade.");
    }else if(age < 18 && age >= 0){
        Console.WriteLine($"{name} possui apenas {age} anos, portanto, é menor de idade.");
    }else if(age < 0){
        Console.WriteLine($"Nossa!, {name}, ou você é um viajante do tempo ou errou esse número aí =)");
    }

