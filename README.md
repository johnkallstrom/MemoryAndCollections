# Övning 4 - Minneshantering

### 1. Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess grundläggande funktion

#### Stack
Stacken är en del av minnet där värdetyper som till exempel lokala variabler och metod parametrar lagras. 
Man kan se den som en hög med lådor staplade på varandra. 
Stacken har en bestämd storlek och det är den översta lådan som tas bort när en ny ska in (sist in, först ut). 

![stack drawio](https://github.com/johnkallstrom/MemoryManagement/assets/54977209/3a5b7b44-1bf3-43b8-ba10-5593da95d9e0)

#### Heap
Heapen är en annan del av minnet där referenstyper som klasser, objekt, interfaces och delegater lagras. 
Varje gång ett nytt objekt skapas upp med nyckelordet new så läggs de på heapen. 
När objektet inte längre behövs är det upp till Garbage Collector att komma in och rensa bort det. 
Heapen har ingen bestämd storlek och det som lagras där är hela tiden tillgängligt.

![heap drawio](https://github.com/johnkallstrom/MemoryManagement/assets/54977209/09a18f79-e740-4e41-b190-32a3859b1147)

### 2. Vad är Value Types respektive Reference Types och vad skiljer dem åt?

#### Value Types
En värdetyp lagras med sitt värde direkt i minnet. Om tex vi skapar variabeln int number = 10; så kommer plats i minnet skapas upp för variabeln "number" och dess värde "10". 

- bools
- byte		
- char		
- decimal		
- double
- enum
- float
- int
- long
- sbyte
- short
- struct
- uint
- ulong
- ushort

#### Reference Types
En refenrenstyp lagras inte med sitt värde direkt i minnet, utan med en referens till en plats i minnet där värdet ligger.

- class
- interface
- delegate
- string

### 3. Följande metoder (se bild nedan) genererar olika svar. Den första returnerar 3, den andra returnerar 4, varför?
![image](https://github.com/johnkallstrom/MemoryManagement/assets/54977209/ded6a599-9896-476e-83bc-d14a823d8d53)

