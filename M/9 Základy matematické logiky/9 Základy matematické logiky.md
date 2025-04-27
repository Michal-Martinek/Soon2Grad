
# 9 - Základy matematické logiky


# výroky
- tvrzení u něhož má smysl určovat pravdivostní hodnotu

## negace
- "není pravda, že A"

## složené výroky
- konjunkce `A ∧ B` - _A a zároveň B_
- disjunkce `A ∨ B` - _A nebo B_
- implikace `A ⟹ B` - _pokud A, tak B_ (předpoklad ⟹ tvrzení)
	- platí i pokud je předpoklad nesprávný
	- obrácená implikace - `B ⟹ A`
		- nemá stejnou pravdivostní hodnotu
	- obměněná implikace - `¬B ⟹ ¬A`
		- stejná pravdivostní hodnota

- ekvivalence - `A právě tehdy když B`

## kvantifikátory
- pro všechny
- existuje

### tabulka pravdivostních hodnot

### tautologie / kontradikce
- výraz je vždy pravdivý
- opak - kontradikce

## typy důkazů
### přímý
- používáme sled pravdivých implikací
- z pravdivého předpokladu dojdeme k dokazovanému tvrzení

### sporem
- předpokládáme opak dokazovaného tvrzení
- dokážeme že neplatí - objeví se spor (pokud platí A tak neplatí A)
- to znamená že předpoklad byl nesprávný - důkaz

### indukcí
- základní tvrzení
- indukční hypotéza
	- pokud platí pro **k**, tak platí i pro **k + 1**

### obměněnou implikací
- dokazujeme [obměněnou implikaci](#složené-výroky)
