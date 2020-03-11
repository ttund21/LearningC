# Anotações C\#

### Tipos de Dados

+ int: Inteiro;
+ float: Número com virgula(ponto);
+ double: Um forma mais precisa do *float*;
+ char: Um único caractere;
+ bool: Booleano, True ou False;
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
