# Anotações C\#

## Index

**1.** [Tipos de Dados](#typeofdata)
**2.** [Operadores Lógicos](#logicOperator)
**3.** [Constante](#constant)
**4.** [Var Keyword](#varKeyword)
**5.** [If Else](#ifElse)
**6.** [Switch](#switch)
**7.** [Loop While](#while)
**8.** [Loop For](#for)
**9.** [Loop Do-While](#doWhile)
**10.** [Break](#break)
**11.** [Continue](#continue)
**12.** [Operator \?](#operatorI)
**12.** [Operator \?](#operatorI)



## Comandos linux

+ dotnet new console -o Questao
+ dotnet run

## Basico

### Tipos de Dados <a name="typeOfData"></a>

+ int: Inteiro;
+ float: Número com virgula(ponto);
+ double: Um forma mais precisa do *float*;
+ char: Um único caractere;
+ bool: Booleano, true ou false;
+ string: Uma sequencia de caractere.

### Operadores Lógicos <a name="logicOperator"></a>

+ Operadores Lógicos são usados para junta expressões e retornar um valor booleano;
+ Operadores:
  | Operador | Nome |   Uso    |
  |   ---    |  --- |   ---    |
  |    &&    |  AND | x && y   |
  |   \|\|   |  OR  | x \|\| y |
  |    !     |  NOT | !x       |
  
### Constante <a name="constant"></a>

+ Constates(**const**) são *"variaveis"* que não podem ser alteradas;
+ Exemplo:

  ```const
  const double PI = 3.14;
  ```

### Var keyword <a name="varKeyword"></a>

+ A keyword *var* é uma função para que o próprio c# defina o tipo de variável;
+ Exemplo:
  
  ```var
  var num = 15;
  
  // num vai ser definido com um inteiro
  ```

### Instrução if - else if - else <a name="ifElse"></a>

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

### Instrução switch <a name="switch"></a>

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

### Loop while <a name="while"></a>

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

### Loop for <a name="for"></a>

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

### Loop do-while <a name="doWhile"></a>

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

### Break <a name="break"></a>

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

### Continue <a name="continue"></a>

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

### Operador "?" <a name="operatorI"></a>

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

#### Argumentos opicionais

+ Pode-se passar argumentos com valores padrões no método, caso esse valor não seja passado quando o método for chamado o valor padrão será usado;
+ Exemplo:
  
  ```optionalArg
  static void hello(string name, string forname = "Shepard")
  {
      System.Console.WriteLine($"Hello, {name} {forname}");
  }
  ```

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
