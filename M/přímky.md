# Přímky

## defice
- dvěma body: **B - A** - směrový vektor
- bodem a vektorem - _počáteční bod, směrový vektor_

## vyjádření
### parametrické
- **X = A + tU**
	- X - bod na přímce
	- t - parametr

- je vidět počáteční bod, směrový vektor

### obecná rovnice
_ax + by + c = 0_
- **a, b** - souřadnice _normálového vektoru_

### směrnicový tvar
- **k** - směrnice = tan α = u_y / u_x
- y = kx + q ~ _lineární funkce_
- s posunutím: y - a2 = (x - a1) * u2 / u1
- nedokáže vyjádřit svislé přímky (x = _konst._)

### úsekový tvar
- důležité průsečíky s osami __x, y__
- jen přímky různoběžné s oběma osami  
- _x / p + y / q = 1_
	- **p** - _x_ průsečíku s osou __x__, **q** - _y_ průsečíku s osou __y__

## vzájemná poloha dvou přímek
srovnáním směrového (normálového) vektoru zjistím:
1) rovnoběžné ⇔ vektory jsou si navzájem násobky
	- **totožné**? - porovnám jestli bod jedné leží i na druhé
		- u _obecné_ pokud je jedna rovnice násobkem druhé
	- **vzdálenost** - [vzdálenost přímky od bodu](#vzdálenost-přímky-od-bodu) ležícího na druhé přímce

2) různoběžné 
	- __kolmé__? - vektory kolmé
	- #### průsečík
		- řešit jako soustavu rovnic

	- #### odchylka přímek
		- využití _skalárního součinu_
		- cos α = |u • v| / |u| * |v|
			- _abs_ nahoře ⟹ menší z odchylek

## vzdálenost přímky od bodu
- vzorec z obecné rovnice:  
_v(P[X, Y], p) = |aX + bY + c| / √(a^2 + b^2)_
