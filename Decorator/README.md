# Oppgaver tilknyttet Decorator Pattern

## ☕💸CoffeeShop💸☕
**Kontekst:** CoffeeShop har slått seg opp på kvalitetskaffe, men har i det siste oppdaget at kundene uteblir 📉. Kundene har påpekt at utvalget av kaffetyper med kombinansjonen av tilbehør oppleves noe begrenset. 

### Utfordringer med dagens løsning:
#### Forretningsutfordringer:
* Kunde kan ikke bestille hva hen ønsker, noe som gir lite penger i kassa.
#### Tekniske utfordringer:
* Slik systemet er designet i dag så må man lage ny klasse som innehar en gitt kombinasjon av kaffe og tilbehør. Det krever altså større endringer i systemet, og kan skape en eksplosjon av klasser og arv, og er veldig lite fleksibelt.

### Oppgave:
Refaktorer løsningen ved bruk av decorator pattern slik at kunden kan bestille flere typer kaffe med alle mulige kombinasjoner av tilbehør. Man ønsker med andre ord å kunne dekorere kaffetypene Dark Roast, House Blend, Espresso etc. med alle typer tilbehør. Totalpris og full beskrivelse av kaffe pluss tilbehør skal kunne vises.

1. Åpne prosjektet "CoffeeShopNoDecorator".
2. Utfør endringer iht. decorator pattern, se UML-diagrammet under.

**Tips 1:** 
* Identifiser Component, ConcreteComponents,  Decorator, ConcreteDecorators.
* Definer en base-klasse for drikke, component. Opprett kaffetyper som concrete components og tilbehør/condiments som concrete decorators. Definer en abstrakt decorator som arver fra Component.

**Tips 2:** En decorator "is-a" component og "has-a" component.
Det vil si at en decorator må arve fra component(slik at den kan behandles som en component),
og ha en instans av component(some sendes inn via konstruktør, slik at decorator kan kalle funksjoner på component som den wrapper/dekorerer). 
En decorator må delegere arbeid til component den wrapper for å så legge til ekstra funksjonalitet.


Se UML-diagrammet under, eller se oppskriften for Decorator Pattern her: https://refactoring.guru/design-patterns/decorator

Forslag til løsning ligger i prosjektet "CoffeeShopDecorator"

### Meny

|Coffees |Price |
|-|-|
|Dark roast|1.1|
|Espresso|1.2 |
|House blend|1.3|
|Decaf|1.4|

|Condiment |Price |
|-|-|
|Milk|0.2|
|Mocha|0.3 |
|Soy|0.3 |
|Whipped cream|0.4|

## UML-diagram for decorator pattern
![alt text](decorator_uml_2.png "2")