Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Title = "FilaZero - sistema de login";


Desenhatela();
ExecutarLogin();

static void Desenhatela()
{
    Console.WriteLine("╔═══════════════════════════════════════════════╗");
    Console.WriteLine("║                                               ║");
    Console.WriteLine("║              FilaZero - Login                 ║");
    Console.WriteLine("║                                               ║");
    Console.WriteLine("╚═══════════════════════════════════════════════╝");
}
static void ExecutarLogin()
{
    Console.Write("Digite seu nome de usuário: ");
    string username = Console.ReadLine();

    Console.Write("Digite sua senha: ");
    string password = Console.ReadLine();

    // Aqui você pode adicionar a lógica de autenticação, por exemplo, verificando um banco de dados
    if (username == "admin" && password == "senha123")
    {
        Console.WriteLine("Login bem-sucedido! Bem-vindo, admin.");
    }
    else
    {
        Console.WriteLine("Login falhou! Nome de usuário ou senha incorretos.");
    }
}
Console.ReadLine();