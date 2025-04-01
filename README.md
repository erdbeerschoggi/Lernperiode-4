# Lern-Periode 4

14.2 bis 4.4

## Beschreibung

Ein Essensgenerator, wo man 3 Optionen auswählen kann und anhand dieser Optionen 2 Gerichte vorgeschlagen bekommt.

## Grob-Planung

Da mir vorgeschlagen wurde eine Frage aus dem Alltag auszuwählen und etwas zu Programmieren, dachte ich mir ich könnte eine Essensauswahl programmieren. Wenn man z.B. nicht weisst auf was man Lust hat zu essen oder man schon die ganze zeit das gleiche isst dann kann dieses Programm bei der Auswahl helfen. 
Das Programm soll folgend funktionieren: Man wird mehrere Fragen nacheinander gefragt, z.B. auf was man lust hat, wo man essen will usw. Dann werden Gerichte vorgeschlagen die man Kochen kann.

## Projekt
In dieser Lernperiode habe ich einen einfachen Essensgenerator erstellt. Der Essensgenerator enthält 3 Kategorien, aus denen man auswählen kann. In jeder Kategorie wählt man eine Option aus. Nachdem man alle 3 Optionen ausgewählt hat, klickt man auf "OK", um die Eingabe zu speichern und die Gerichte zu generieren. Danach erhält man einen Schlüssel für die ausgewählten Optionen und bekommt Gerichtsvorschläge in einer Messagebox angezeigt. Wenn man fertig ist, klickt man auf "OK" in der Messagebox, um zur Form zurückzukehren. Wenn man erneut Gerichte generieren möchte, muss man auf "Restart" klicken, um die Auswahl zurückzusetzen und erneut Optionen auszuwählen.

![Aufzeichnung 2025-04-01 111741](https://github.com/user-attachments/assets/29b7365c-3eea-4f82-bc74-334b57348fa3)


## Reflexion

Ich fand, dass ich in dieser Lernperiode nur mäßig gearbeitet habe. Die Lernpakete waren nicht so gut, und an vielen Stellen wusste ich nicht genau, wie ich vorgehen sollte. Ich hatte auch Probleme bei der Gerichtsausgabe und musste diese auf weniger Gerichtsvorschläge und weniger Auswahl reduzieren, sonst hätte ich viel zu viel schreiben müssen. Ich bin zwar nicht ganz zufrieden mit dem, was ich am Ende gemacht habe, aber ich wollte mehrere Optionen anbieten, damit man etwas Passenderes auswählen kann. In dieser Lernperiode wurde alles auch strukturiert geplant, also zuerst der Prototyp, dann die Kernfunktionalität, usw. Ich habe mich jedoch nicht so gut daran gehalten und habe das Gefühl, dass der Prozess viel besser gewesen wäre, wenn ich mich daran gehalten hätte. Ich hatte auch noch zum schluss ein Problem und zwar bei der Option "Anderes"

## 14.2: Explorativer Wegwerf-Prototyp

- [ ] Alle funktionen des programms entscheiden (also was genau will ich das das Programm macht)
- [x] Anfangen das Programm Grob zu programmieren

Heute habe ich mir überlegt was ich genau machen möchte. Dann dauerte es eine Weile bis ich drauskamm wie ich vorgehen sollte. Nachdem fing ich an auf der Form buttons und Textfelder drauftun um zu testen, ob das was ich mir überlegt habe sinn macht. (Ich bin leider nicht weit gekommen heute)


## 21.2: Explorativer Wegwerf-Prototyp

- [x] Alle nötigen Abfragen finden (offline Paket)
- [x] Forms erstellen
- [ ] Grob programmieren, also die funktion der Buttons 
- [x] M164, SQL

Heute habe ich alle nötogen Fragen die ich den User Abfragen will mir ausgedacht. Dann habe ich angefangen die forms zu erstellen, da ich ohne diese nicht wirklich den code programmieren kann. Dann hatte ich mir noch vorgenommen meinem Fehler in SQL zu finden, da wir eine LB dazu bearbeiten und bei mir die ganze Zeit ein Fehler war beim Daten importieren.


## 28.2: Kern-Funktionalität
- [x] Speicherung der Benutzereingabe erstellen
- [x] Code grob programmieren
- [ ] Ausgabe nach der Benutzereingabe erstellen 
- [ ] Alle Forms richtig aufzeigen

Heute habe ich rechechiert wie genau ich die Abspeicherung von den Eingaben des Benutzer speichern kann. Ich habe mehrere Varianten ausprobiert undhabe jetzt eine Variante behalten die noch nicht komplett richtig ist. Deswegen  muss ich es noch überarbeiten. Ich habe auch noch alle nötige Forms erstellt für die erste Click Variante (Wenn man Zuhause essen klickt).

## 7.3: Kern-Funktionalität
- [x] Kern Funktioninalität -> Speicherung von Benutzer Eingabe und Ausgabe anhand der Eingaben. (Wie ich die Abspeicherung machen möchte)
- [ ] Essens Ideen sammeln für die Ausgabe vom Generator
- [ ] Ausgabe nach der Benutzereingabe programmieren
- [x] Alle Forms für den Generator erstellen

Heute habe ich die speicherung von der Benutzereingabe grob programmiert. Ich erstellte ein neues projekt um zu programmieren, weil das vorherige hatte viele neue Fehler & ich habe mir einen besseren Aufbau für den Essensgenerator überlegt und zwar anstatt 5+ Forms zu haben einfach alle Fragen auf einer abfragen, da ich so kein durcheinander bekomme. Deswegen habe ich neue Forms erstellt und die Buttons hinzugefügt.

## 14.3: Architektur ausbauen
- [x] Code organisieren, so das er übersichtlicher ist
- [ ] Essens Ideen sammeln für die Ausgabe vom Generator
- [x] Das etwas ausgegeben wird. (Einfach so das man etwas heraus bekommt. Z.B. Kein Gericht vorhanden)
- [ ] Die Ausgabe der Gerichte programmieren nach Auswahl vom Benutzer.

Heute habe ich die Benutzerausgabe probiert zu programmieren. Ich habe die voraussetzungen dazu programmiert und wann was ausgegeben werden soll. Doch wenn ich etwas eingebe bei dem ich Gerichte habe, kommt heraus das es keine Gerichte vorhanden hat. Das heisst ich muss noch an der Kernfunktionalität arbeiten, da ich noch ¨keine¨ Ausgaben bekomme. Dann habe ich noch den Code einwenig organisiert, so das alles übersichtlicher ist für mich.

## 21.3: Architektur ausbauen
- [ ] Essens Ideen sammeln für die Ausgabe vom Generator.
- [x] Die Ausgabe der Gerichte programmieren nach Auswahl vom Benutzer.
- [x] Das Problem finden bei der Ausgabe.
- [ ] Für jede mögloche Auswahlmindestens 3 Gerichte haben.

Heute habe ich die Ausgabe der gerichte programmiert + mir überlegt wie ich die abspeicherung der Auswahl verbessern könnte. Bei der verbesserung von der Abspeicherung ging jedoch nichts besser als zuvor. Deswegen liess ich es bei der originellen abspeicherung so das ich meinen code nicht noch mehr chaotisch mache. Die Ausgabe der Gerichte habe ich jetzt so gestalltet das sie nicht in der Form2 heruasgegeben werden sondern durch eine Message box.

## 28.3: Auspolieren
- [x] Essens Ideen sammeln für die Ausgabe vom Generator.
- [ ] Für jede mögliche Auswahl mind. 2 Gerichte ausgeben.
- [x] Die Form mit schöner gestallten.
- [x] Das Problem bei dem 3ten gericht finden. (Da wenn ich es anklicke kommt ein 2 egal wo nicht angeglickt wurde)

Heute habe ich Essensideen gesammelt.Ich wollte eigentlich für jede  Kombination 2 Gerichte erstellen doch als ich mir ungefähr das ausgerechnette merkte ich das es um die 800 Kombinationen wären. Ich habe jetzt also nur wenige Kombinationen, das heisst man kann nicht für alle möglichkeiten einen vorschlag bekommen kann was etwas schade ist. Ich habe der Form einbisschen Farbe hinugefügt und das Proble gefunden da ich 2 mal Egal gespeichert hatte und da die beiden keinen unterschied hatten wurden beide aufgenommen.

## 4.4: Auspolieren & Abschluss
- [x] Mehr Gerichte Hinzufügen
- [x] Code Organisieren (evtl. bessere abkürzungen erstellen, unnötige kommentare entfernen, usw.)

Heute habe ich noch einwenig mein Projekt poliert und zwar in dem ich folgendes gemacht habe: Zuerst habe ich eine grosse Auswahl gehabt, also was man alles anklicken kann um ein gericht vorzuschlagen bekommen. Das Problem war jedoch das es sonst über 800 optionen gäbe also reduzierte ich die Auswahl auf 3 Kategorien. Weil ich das so gemacht habe, hat es für alles einen vorschlag. Ich bin jedoch im Problem begegnet wo mir die zeit nicht gereicht hat und zwar wenn man Anderes anwählt bei der Hauptzutat bekommt man nicht den richtigen schlüssel raus für das gericht und es wird nichts vorgeschlagen. Dann zum schluss habe ich noch den code einwenig organisiert so das die reihenfolge einwenig mehr sinn macht. 
