﻿// 29.Skriv en klass som representerar en bil.
// Varje bil ska kunna ha en färg som representeras av en enum (det ska finnas minst 5 olika färger på bilar), samt en längd.
// När man instansierar en bil så ska den få en random färg, och en random längd (mellan 3 och 5 meter).
// Instansiera 1000 bilar och spara i en array. Skriv sedan ut den sammanlagda längden av alla gröna bilar.



using Övningar_29_30;

Car[] cars=new Car[10];

for (int i = 0; i <10; i++)
{
    cars[i] = new Car();
    
}

int combinedLength = 0;

foreach (var item in cars)
{
    if (item.Color==Car.ColorEnum.GrassGreen)
    {
        combinedLength++;
    }
}





