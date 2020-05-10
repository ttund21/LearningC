# Anotações C\#

## Index

1. [Tipos de Dados](#Tipos-de-Dados)
2. [Operadores Lógicos](#Operadores-Lógicos)
3. [Constante](#Constante)
4. [Var Keyword](#Var-keyword)
5. [Instrução If](#Instrução-if)
6. [Switch](#Instrução-switch)
7. [Loop While](#Loop-while)
8. [Loop For](#Loop-for)
9. [Loop Do-While](#Loop-do-while)
10. [Break](#Break)
11. [Continue](#Continue)
12. [Operator \?](#Operador-Condicional)
13. [Método](#Métodos)
14. [Parâmetro](#Parâmetro)
15. [Argumento Opcional](#Argumentos-opicionais)
16. [Argumento Nomeado](#Argumento-Nomeado)
17. [Passando Argumentos](#Passando-Argumentos)
18. [Overloading](#Overloading)
19. [Classes & Objects](#classes--objects)
20. [Exemplo de class](#exemplo-de-class)
21. [Encapsulation](#encapsulation)

---

## Comandos linux

+ dotnet new console -o Questao
+ dotnet run

## Basico

### Tipos de Dados

+ int: Inteiro;
+ float: Número com virgula(ponto);
+ double: Um forma mais precisa do *float*;
+ char: Um único caractere;
+ bool: Booleano, true ou false;
+ string: Uma sequencia de caractere.

[<<< Back to index](#index)

### Operadores Lógicos

+ Operadores Lógicos são usados para junta expressões e retornar um valor booleano;
+ Operadores:
  | Operador | Nome |   Uso    |
  |   ---    |  --- |   ---    |
  |    &&    |  AND | x && y   |
  |   \|\|   |  OR  | x \|\| y |
  |    !     |  NOT | !x       |

[<<< Back to index](#index)
  
### Constante

+ Constates(**const**) são *"variaveis"* que não podem ser alteradas;
+ Exemplo:

  ```const
  const double PI = 3.14;
  ```

[<<< Back to index](#index)

### Var keyword

+ A keyword *var* é uma função para que o próprio c# defina o tipo de variável;
+ Exemplo:
  
  ```var
  var num = 15;
  
  // num vai ser definido com um inteiro
  ```

[<<< Back to index](#index)

### Instrução if

+ Usado para verificar uma condição;
+ Exemplo de uso:
  
  ```if
  int x = 33;

  if(x == 8) {
     Console.WriteLine("O valor de x é 8");
  }
  else if(x == 18) {
     Console.WriteLine("O valor de x é 18");
  }
  else if(x == 33) {
     Console.WriteLine("O valor de x é 33");
  }
  else {
     Console.WriteLine("Sem correspondência");
  }
  
  // Saídas "O valor de x é 33"
  ```

[<<< Back to index](#index)

### Instrução switch

+ Usado para testar uma variavel;
+ Exemplo de uso:
  
  ```switch
  int num = 3;
  switch (num)
  {
    case 1:
     Console.WriteLine("one");
     break;
    case 2:
     Console.WriteLine("two");
     break;
    case 3:
     Console.WriteLine("three");
     break;
    default:
     Console.WriteLine("Valor Inválido!");
     break;
  }
  // Resultados "três"
  ```

[<<< Back to index](#index)

### Loop while

+ Executa um bloco de código, enquanto condição for **true**;
+ Exemplo de uso:
  
  ```while
  int num = 0;
  while(++num < 6)
  Console.WriteLine(num);
  /*
  1
  2
  3
  4
  5
  */
  ```

[<<< Back to index](#index)

### Loop for

+ Executa um bloco de código em número de vezes especifico;
+ Forma de uso:
  
  ```forForma
  for (init; condition; increment){
     statement(s);
  }
  ```

+ Exemplo de uso:
  
  ```forLoop
  for (int x = 0; x < 10; x+=3)
  {
    Console.WriteLine(x);
  }

  /* Outputs
  0
  3
  6
  9
  */
  ```

[<<< Back to index](#index)

### Loop do-while

+ Similar ao *while*, exceto que é garantido que ele vai executar pelo menos uma vez;
+ Exemplo de uso:
  
  ```doWhile
  int a = 0;
  do {
    Console.WriteLine(a);
    a++;
  } while(a < 5);

  /* Outputs
  0
  1
  2
  3
  4
  */
  ```

[<<< Back to index](#index)

### Break

+ Usado para para um loop imediatamente;
+ Exemplo de uso:
  
  ```break
  int num = 0;
  while (num < 20)
  {
     if (num == 5)
       break;

     Console.WriteLine(num);
     num++;
  }

  /* Outputs:
  0
  1
  2
  3
  4
  */
  ```

[<<< Back to index](#index)

### Continue

+ Parecido com o *break*, com a única diferença que ele volta para o inicio do loop imediatamente;
+ Exemplo de uso:
  
  ```continue
  for (int i = 0; i < 10; i++) {
    if (i == 5)
      continue;

    Console.WriteLine(i);
  }
  /* Outputs:
  0
  1
  2
  3
  4
  6
  7
  8
  9
  */
  ```

[<<< Back to index](#index)

### Operador Condicional

+ O operador **?** é um outro jeito de validar uma condicional;
+ O **?** funcionado seguinte jeito:
  
  ```?operator
  (condicional)?"True":"False"
  ```

+ Será julgado uma condicional se for verdadeira a primeira sentença será exposta e se for falsa a segunda setença será exposta;
+ Exemplo:

  ```?exemplo
  string resp, msg;

  System.Console.WriteLine("Capital Brasil?");
  resp = Console.ReadLine();

  msg = (resp == "brasilia")?"Acertou":"Errou";
  System.Console.WriteLine(msg);
  ```

[<<< Back to index](#index)

## Métodos

+ Para usar o método, primeiro é necessário declara-lo e depois chama-lo;
+ Cada declaração de método inclui:
  + Tipo de retorno;
  + Nome do método;
  + Uma lista de parâmetro opicional.
+ Exemplo de declaração:
  
  ```methodDeclaration
  <tipo de retorno(tipo de dado)> nome(tipo1 item1, tipo2 item2, ...,typeN itemN)
  {
    bloco de código
  }
  ```

+ Exemplo prático:

  ```methodPrat
  int Sqr(int x)
  {
    int result = x*x;
    return result;
  }
  ```

+ Obs:
  + **void**: é um tipo de dado que indica que é o método não retorna nada;
  + **static**: é usada para fazer os métodos ficarem acessiveis pelo método Main.

[<<< Back to index](#index)

### Parâmetro

+ Parâmetros são "variáveis" que vão ser passadas quando a função for chamada;
+ Para passar um parâmetro para seu método é só por ele dentro dos pararênteses do seu método;
+ Exemplo:
  
  ```parameter
  static void hello(string name)
  {
    Console.WriteLine($"Hello, {name}.");
  }
  ```

[<<< Back to index](#index)

#### Argumentos opicionais

+ Pode-se passar argumentos com valores padrões no método, caso esse valor não seja passado quando o método for chamado o valor padrão será usado;
+ Exemplo:
  
  ```optionalArg
  static void hello(string name, string forname = "Shepard")
  {
      System.Console.WriteLine($"Hello, {name} {forname}");
  }
  ```

[<<< Back to index](#index)

#### Argumento Nomeado

+ Ao chamar o método podemos nomear os argumentos para não precisarmos lembra a ordem do nosso método;
+ Exemplo:
  
  ```namedArg
  static void hello(string name, string forname = "Sherpard")
  {
      System.Console.WriteLine($"Hello, {name} {forname}");
  }

  static void Main(string[] args)
  {
      hello(forname: "de Assis", name: "Machado");
  }

  Output:
  Hello, Machado de Assis
  ```

[<<< Back to index](#index)

#### Passando Argumentos

+ Há 3 maneiras de passar argumento quando um nétodo chamado: por **valor**, por **referência** e por **saída**;

##### Valor

+ Por **valor** vai-se copiar o argumento para dentro do método e executá-lo, ele é usado por padrão pelo C#;
+ Exemplo:
  
  ```value
  static void func(int valor)
  {
    valor = valor * 2;
  }

  static void Main(string[] args)
  {
    int x = 5;
    func(x);
    System.Console.WriteLine(x);
  }

  Output:
  5
  ```

+ *Nessa tipo de passar o argumento o valor de x não irá mudar;*

[<<< Back to index](#index)

##### Reference

+ Por **referência** a variável passada para o método será afetada;
+ Para criar um método de referência usa-se **ref**;
+ Exemplo:

  ```reference
  static void func(ref int valor)
  {
    valor = valor * 2;
  }

  static void Main(string[] args)
  {
    int x = 5;
    func(ref x);
    System.Console.WriteLine(x);
  }

  Output:
  10
  ```

[<<< Back to index](#index)

##### Output

+ **Output** é similar ao reference, exceto que ele tranfere o dado para fora do método;
+ Ele é definido usando a keyword **out**;
+ Exemplo:

  ```output
  static void func(ref int valor)
  {
    valor = 80;
  }

  static void Main(string[] args)
  {
    int x = 5;
    func(ref x);
    System.Console.WriteLine(x);
  }

  Output:
  80
  ```

[<<< Back to index](#index)

#### Overloading

+ Overload é usado para quando queremos usar o mesmo método mas diferentes tipos de dados;
+ Basicamente deve-se repetir o mesmo método usando um tipo de dado diferente;
+ Exemplo:

  ```overloading
  static void func(int x)
  {
    System.Console.WriteLine(x + x);
  }

  static void func(string x)
  {
    System.Console.WriteLine(x);
  }

  static void Main(string[] args)
  {
    func("teste");
  }

  Output:
  teste
  ```

[<<< Back to index](#index)

## Classes & Objects

+ **Classes:** Em programação orientada a objeto, classe é um tipo de dado que define um set de variáveis e métodos para um objeto;
+ **Objects:** Objetos são entidades concretas baseadas em classes, as vezes é referenciada como instancia de uma classe.

### Exemplo de class

+ Criando um class carro:

  ```classCar
  class Carro
  {
    int portas = 2;
    string nome = "Calhambeque";
    public void buzina()
    {
      System.Console.WriteLine("Bip Bip");
    }

    static void Main(string[]args)
    {
      Carro c1 = new Carro();
      c1.buzina();
    }
  }
  ```

+ O código acima cria uma classe carro, aonde tem variáveis *portas* e *nome* e um método chamado *buzina* que mostra na tela uma representação de buzina;
+ Um membro da class definido com o *public* pode ser acessado fora da classe;
+ O operador *new* instancia um objeto e retorna uma referencia para seu local de origem;
+ A linha *Carro p1 = new Carro();* declara que um objeto da classe carro chamada de c1;
+ Então na proxima linha *c1.buzina();* ele chama o método **publico** *buzina()*;

+ Exemplo de variáveis públicas:

  ```classPublicVars
  class Carro
  {
    public int portas;
    public string nome;
    public void buzina()
    {
      System.Console.WriteLine("Bip Bip");
    }

    static void Main(string[]args)
    {
      Carro c1 = new Carro();
      c1.portas = 2;
      c1.nome = "Calhambeque";
      c1.buzina();
    }
  }
  ```

[<<< Back to index](#index)

### Encapsulation

+ Encapsulação significa restringir acesso ao funcionamento interno;
+ Encapsulação é implementado usando **access modifiers**;
+ Um access modifier difine o escopo e visibilidade de um membro da classe.
+ C# suporta os seguintes tipos de modificadores de acesso(access modifier):
  + public: deixa o membro acessivel fora da classe;
  + private: deixa acessivel somente dentro da classe;
  + protected;
  + internal;
  + protected internal;

[<<< Back to index](#index)
