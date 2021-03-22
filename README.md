# bostadskostnadDesktop

Project creted by Erik Dahlen at 2021-03-09.

Created thanks to input from: https://rikatillsammans.se/forum/t/samskapa-en-kalkyl-hyra-eller-kopa-ett-boende/12427/76

License: MIT

All kod är på svenska, för lite omväxlingsskull.

Gå in i mappen \BoendekostnadetDesktop\bin\Release\netcoreapp3.1 och kör sedan BoendekostnadetDesktop.exe för att starta programmet.

Tolka resultaten rätt.
Först kommer 3 stycken uträkningar som beskriver den "Lägsta bostadsutgifter..." under perioden. Det är en summering hur mycket det hade kostat under alla åren att välja boendeformen, kostnader som man inte kan välja bort.

Sedan kommer 3 stycken uträkningar som beskriver den "Förmögenheten..." om man istället hade investerat allt man sparade genom att välja en billigare bostadslösning. (Alltså den totala alternativkostnaden för de andra alternativen får man fram genom att jämföra de olika förmögenheterna.)

Alternativkostnaden beräknas genom att man jämför de olika boendeformerna och låter de 2 som just det året är billigare investera mellanskillnaden på börsen.

För att porta koden till en nya applikation krävs att följande classer tas med:

BeräknaBoendekostnaden.cs (Den som genomför själva uträkningen.)

Bostadsrätt.cs (Den håller saker kopplad till denna boendeformen.)

Hus.cs (Den håller saker kopplad till denna boendeformen.)

Hyresrätt.cs (Den håller saker kopplad till denna boendeformen.)

Parametrar.cs (Där alla parametrar finns som måste var med.)

SvarBeräkning.cs (Där svaret från BeräknaBoendekostnaden.cs kommer.)
