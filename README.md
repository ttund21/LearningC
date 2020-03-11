# Anotações C\#

### Tipos de Dados

+ int: Inteiro;
+ float: Número com virgula(ponto);
+ double: Um forma mais precisa do *float*;
+ char: Um único caractere;
+ bool: Booleano, true ou false;
+ string: Uma sequencia de caractere.

### Constante

+ Constates(**const**) são *"variaveis"* que não podem ser alteradas;
+ Exemplo:
  ```const
  const double PI = 3.14;
  ```

### Var keyword

+ A keyword *var* é uma função para que o próprio c# defina o tipo de variável;
+ Exemplo:
  ```var
  var num = 15;
  
  // num vai ser definido com um inteiro
  ```

### Instrução if - else if - else

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
  } 
  // Resultados "três"
  ```

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

### break

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

### continue

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

### Operadores Lógicos

+ Operadores Lógicos são usados para junta expressões e retornar um valor booleano;
+ Operadores:
  | Operador | Nome |   Uso    |
  |   ---    |  --- |   ---    |
  |    &&    |  AND | x && y   |
  |   \|\|   |  OR  | x \|\| y |
  |    !     |  NOT | !x       |


### Operador ?