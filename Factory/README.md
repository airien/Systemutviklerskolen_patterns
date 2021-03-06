﻿Oppgaver tilknyttet Factory Pattern

## Logistic
**Kontekst:** Vi har implementert en løsning for å hjelpe Supertransport å digitalisere transportfirmaet sitt. 🚚

De begynte å transportere ting med lastebiler, og har begynt på å få inn transport med båter. Vi ser at koden vår har mye gjentagelser, det kan gjøre at vi lager mye bugs og vi vil i fremtiden også støtte å transportere med fly. Koden er ikke veldig grei å utvide.

### Utfordringer med dagens løsning:
#### Forretningsutfordringer:
* Kunde vil gjerne bestille flytransport i dag, men den digitale løsningen venter på seg. Dette gjør at det blir vanskelig å utvide driften.
#### Tekniske utfordringer:
* Slik systemet er designet i dag så må man lage ny klasse for hver transporttype, som gjør transport på sin måte, uten at vi har noe gjenbruk

### Oppgave:
Diskutre i grupper, og kom frem til en løsning på hvordan vi kan få til å enkelt legge til transportlogistikk ved å bruke factorypattern.
Refaktorer løsningen ved bruk av Factory Pattern slik at vi enkelt kan lage nye måter å transportere på.

1. Åpne prosjektet "LogisticsNoFactory"
2. Utfør endringer slik at vi kan enkelt utvide med nye transportmetoder, og det blir mindre gjentagelser i kode
3. Legg til transportmetoden for fly

**Tips 1:** 
* Identifiser mulige superklasser, se hvor man kan innføre factoryklasse. Diskuter i gruppen hva dere tror løsningen er.
* Opprett nye transportmetoder som arver fra superklasse.


**Tips 2:** En factorty er en statisk klasse som kan lage konkrete objekter utifra parametre.


Forslag til løsning ligger i prosjektet "LogisticsFactory"

## UML-diagram for factory pattern
![alt text](uml.png "Title")