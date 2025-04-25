
# 1 - Funkce a její vlastnosti

# definice
- předpis, přizazuje každému číslu z _definičního oboru_ právě jednu hodnotu z _oboru hodnot_
	- x - nezávislá proměnná
	- y - závislá proměnná

# definiční obor a obor hodnot
- D_f množina povolených x
- H_f množina možných y

# graf + vlastnosti
- zobrazení funkce na grafu - x, y

### rostoucí / klesající
- rostoucí:
> ∀x_1, x_2 ∈ D_f: x_1 < x_2 ⟹ f(x_1) < f(x_2)

### prostá
- pro zádná dvě různá x není stejné y
- má inverse

### sudá
- sudá: f(x) = f(-x)
- lichá: f(-x) = -f(x)

### periodická
- po periodě se opakuje
- f(x + kT) = f(x)

### omezená
- znamená omezená __zdola__ i __zhora__
- omezená __zhora__:
	- její hodnota nikdy nepřesáhne danou hodnotu y

### monotónnost
- furt klesá / stoupá

### extrémy
- maximální / minimální hodnota na __D_f__ _nebo_ intervalu
> f-ce nemá maximum když se blíží zespoda do nevlastního bodu (kde není definovaná)
- v extrému buď končí __D_f__ nebo je `f'(x)=0`
	- _tzv._ __stacionární bod__
	- + není tam inflexní bod

### konvexní / konkávní
- "ohýbá" se nahoru nebo dolu
- konvexní - nahoru
	- tečna k grafu je pod grafem
- konvexní - dolů
	- `f''(x) <= 0`

- __inflexní bod__
	- z konvexní na konkávní
	- 2. derivace = 0

### spojitá
- f-ce nemá díry
- jak v D_f
- tak neskáče v hodnotách
- 3 podmínky: limity z obou směrů = hodnota v bodě

# užití diferenciálního počtu - pro vyšetření průběhu funkce
- f'(x) -> stacionární body
- f''(x) -> inflexní / lokální extrémy
