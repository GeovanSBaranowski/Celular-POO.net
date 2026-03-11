📱 Celular - POO em C#

Projeto desenvolvido para praticar Programação Orientada a Objetos (POO) utilizando C# e .NET.

O objetivo deste projeto é simular o funcionamento de diferentes modelos de smartphones utilizando conceitos fundamentais da POO, como herança, encapsulamento, classes abstratas e polimorfismo.

🚀 Tecnologias utilizadas

C#

.NET

Programação Orientada a Objetos (POO)

🧠 Conceitos de POO aplicados

Este projeto demonstra os seguintes conceitos:

✔ Classes e Objetos

✔ Encapsulamento

✔ Herança

✔ Polimorfismo

✔ Classes abstratas

✔ Sobrescrita de métodos (override)

📂 Estrutura do projeto
Celular-POO.net
│
├── Models
│   ├── Smartphone.cs
│   ├── Nokia.cs
│   └── Iphone.cs
│
└── Program.cs
📌 Descrição das classes

Smartphone (classe abstrata)
Define os atributos e comportamentos comuns a todos os celulares.

Propriedades:

Numero

Modelo

IMEI

Memoria

Métodos:

Ligar()

ReceberLigacao()

InstalarAplicativo()

Nokia

Classe que herda de Smartphone e implementa o comportamento específico para instalação de aplicativos.

Iphone

Classe que herda de Smartphone e implementa sua própria forma de instalar aplicativos.

⚙️ Exemplo de uso
Nokia nokia = new Nokia("111111", "Nokia Tijolão", "123456", 64);
Iphone iphone = new Iphone("222222", "Iphone 15", "7891011", 128);

Console.WriteLine(nokia.InstalarAplicativo("WhatsApp"));
Console.WriteLine(iphone.InstalarAplicativo("Instagram"));

Saída esperada:

Instalando o aplicativo WhatsApp
Instalando o aplicativo Instagram
▶️ Como executar o projeto

Clone o repositório:

git clone https://github.com/GeovanSBaranowski/Celular-POO.net.git

Entre na pasta do projeto:

cd Celular-POO.net

Execute o projeto:

dotnet run
📚 Objetivo do projeto

Este projeto faz parte do estudo de Programação Orientada a Objetos com C#, com foco em entender como estruturar aplicações utilizando classes, herança e abstração.

👨‍💻 Autor

Geovan Baranowski

GitHub
https://github.com/GeovanSBaranowski