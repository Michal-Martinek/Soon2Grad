
# 10 - Posloupnosti a řady


## definice
- uspořádaná řada čísel - číslovaná přirozenými N
- vzorcem pro n-tý člen
- rekurentním vzorcem

## vlastnosti 
### nekonečná, konečná
- počet členů

### rostoucí, klesající
- každý další člen je větší než předchozí

### omezená
- všechny členy jsou pod určitou mezí

## rekurentní vzorec
- podle n-tého určuje n+1-ní

## aritmetická a geometrická posloupnost
- aritmetická: členy se liší o diferenci __d__
	- n-tý člen: `a_n = a_1 + d(n - 1)`
	- r-tý člen z s-tého: `a_r = a_s + d(r - s)`
	- součet prvních _n_: `s_n = n/2 * (a_n + a_1)`
	- součet nekonečné (limita částečných součtů) - neexistuje (je v nekonečnu)

- geometrická: členy se liší o násobek __q__
	- n-tý člen: `a_n = a_1 * q^(n - 1)`
	- součet prvních _n_: `s_n = a_1 * (1 - q^n) / (1 - q)`
	- součet nekonečné (limita částečných součtů)
		- existuje pokud |q| < 1
		- lim n -> inf: s_n = a_1 / (1 - q)

## limita

## nekonečná geometrická řada
- pokud |q| < 1: tak konverguje k 0
- pokud q <= -1: osciluje mezi + a -
- pokud q >= 1: divergentní
