**Логинов Евгений Александрович**
=================================
Группа: ИП-20-7К
---------------------------------
Тема: Web API-Склад моторов
---------------------------------
![image](https://github.com/dr4matic/SkladMotors/assets/104574470/c99aa8f6-0a32-4e27-a2a6-69697959bfb2)
---------------------------------
```mermaid
erDiagram
    Pokupatel ||--o{ Nakladnaya : places
    Pokupatel {
        string Name
        string Adres
        int Number
        string Email
    }
  
    Nakladnaya {
        int PokupatelId
        int PostavshikId
    }
  Motor ||--o{ Nakladnaya: is
    Motor {
        string Name
        int Cilindr
        int Value
 
    }
 Postavshik ||--o{ Nakladnaya: is
  Postavshik {
    string Name
    string Adres
    int Index
    string Email
    int Inn  
    int RS
   }
```
