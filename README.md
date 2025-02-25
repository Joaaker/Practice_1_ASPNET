Övningsuppgift 1: Enkel produktlista med Partial View

Mål:
Skapa en Razor Page som visar en lista av produkter.
Använd en Partial View för att visa en enskild produkt.




Steg 1: Skapa en produktmodell
Skapa en klass Product i mappen Models och den klassen ska innehålla ett Id, Name, och Price.


Steg 2: Skapa en services-klass för att hantera produkter
Skapa en klass ProductService i mappen Services. I denna klass ska det finnas en privat statisk lista av typen Product och lägg sedan in manuellt 3 olika produkter i listan.
Klassen ska även innehåll en metod som heter GetProducts som ska skicka tillbaka listan med produkter.




Steg 3: Registrera tjänsten i Program.cs
Lägg till denna rad i Program.cs för att göra ProductService tillgänglig i Dependency Injection (DI) och använd Singleton vid registreringen.




Steg 4: Skapa en Partial View för att visa en produkt
I mappen Pages/Partials, skapa en partial view _ProductPartial.cshtml som har en @model som är av typen Product.
Skriv sedan ut HTML kod som visar en <div class="product"> som innehåller namnet och priset.

Steg 5: Skapa en Razor Page för att visa produktlistan
I mappen Pages, skapa en ny Razor Page Products.cshtml. I din code-behind måste du registrera din service genom dependency injection.
Du ska även skapa en ny lista som är en publik Property som du döper till Products.
I OnGet() ska du populera Products med produkterna från din Service genom att anropa metoden du skapat i din ProductService.
Lägg till HTML-kod i Products.cshtml som listar ut listan med produkter från din model som är kopplat till sidan.


Testa projektet
Kör applikationen och navigera till /Products.
Se listan över befintliga produkter.


Lycka till!

