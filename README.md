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
En värdetyp är en form av datatyp och innehåller värden som heltal, siffror med decimaltecken, sant eller falskt och bokstäver. 
De lagras direkt i minnet där variabeln är deklarerad och tar oftast mindre plats i minnet jämfört med referenstyper. 
De går att skapa egna värdetyper med hjälp av nyckelordet ```struct```.

Exempel på värdetyper är:
- int
- decimal
- double
- bool
- char
- enums

#### Reference Types
En referenstyp är en annan form av datatyp som alltid lagras på heapen. 
Till skillnad mot värdetyper, som lagrar värdet direkt i minnet där variabeln deklareras, så håller referenstyper istället en referens till en plats i minnet där värdet sparats.

Exempel på referenstyper är:
- class
- interface
- string
- delegate

### 3. Följande metoder (se bild nedan) genererar olika svar. Den första returnerar 3, den andra returnerar 4, varför?
![image](https://github.com/johnkallstrom/MemoryManagement/assets/54977209/ded6a599-9896-476e-83bc-d14a823d8d53)

Den första metoden returnerar 3 därför att när raden ```y = x``` körs så kopieras värdet ```3``` från ```x``` direkt över till ```y``` eftersom de är värdetyper. När sen variabeln ```y``` får ett nytt värde på nästa rad är det inget som påverkar ```x``` utan den behåller sitt ursprungsvärde vilket är ```3```.

Anledningen till att den andra metoden returnerar 4 är för att när raden ```y = x``` körs så skriver objekt ```x``` över objekt ```y``` och nu pekar båda variablerna på samma objekt i minnet.
Så när nästa rad ```y.MyValue = 4``` körs så får inte bara ```y.MyValue``` värdet ```4``` utan även ```x.MyValue``` får samma värde.

### Övning 1: ExamineList()

#### 1. Skriv klart implementationen av ExamineList-metoden så att undersökningen blir genomförbar.
#### 2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
Så fort kapaciteten är uppnådd och ett nytt element ska läggas till, dvs när antalet element i listan är lika mycket som kapaciteten

#### 3. Med hur mycket ökar kapaciteten?
Den dubbleras. Så om kapaciteten i listan är 4 så ökar den till 8. 

#### 4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
För det är så man valt att implementera list-klassen.
Koden är skriven på ett sånt sätt så att kapaciteten kommer inte öka efter varje nytt element läggs till utan bara när den är uppnådd. 

#### 5. Minskar kapaciteten när element tas bort ur listan?
Nej, det gör den inte.

#### 6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
När man vill ha ett bestämt antal element i sin kollektion/array/lista eller när man bara vill ha bättre kontroll över kapaciteten, när den ska öka, med hur mycket m.m. 

### Övning 2: ExamineQueue()

### Övning 3: ExamineStack()
#### 1. Simulera ännu en gång ICA-kön på papper. Denna gång med en stack. Varför är det inte så smart att använda en stack i det här fallet?
Därför att en stack följer FILO principen, först in sist ut, så om man skulle använda en stack i det här fallet så skulle den personen som är först in i kassan behöva vänta tills alla andra är klara innan den kan lämna och gå ut. 
Vilket blir lite knasigt och ineffektivt.

### Övning 4: CheckParenthesis()
