
# 17 - Kombinatorika a pravděpodobnost


## kombinatorická pravidla součtu a součinu
- součin je nezávislý výběr
- součet je 'nebo' - vyberu si to nebo to

### kombinace
> kombinace k-té třídy z n prvků
- nezáleží na pořadí
- `K_k(n) = n! / k! * (n - k)!`
<!-- - s opakováním: `K'(k, n) = P′(k,n−1) = (k+n−1)!/k!(n−1)! = (n+k−1;k)`
- [zdroj](https://www.karlin.mff.cuni.cz/~portal/kombinatorika/?page=03kombinace_s_opakovanim) -->

### variace
> variace k-té třídy z n prvků
- záleží na pořadí
- `V_k(n) = k! * K_n(n)`
- s opakováním `V_k'(n) = n^k`

### permutace
- počet možných seřazení n prvků
- `P(n) = n!`

## sčítání pravděpodobností
- `P(A ∪ B) = P(A) + P(B) - P(A ∩ B)`

### nezávislé jevy
Dva jevy jsou nezávislé, když platí:  
- P(A∩B)=P(A)×P(B)

## binomické rozdělení
Používá se, když se provádí n nezávislých pokusů a hledá se pravděpodobnost přesného počtu úspěchů k.

Vzorec:
- vychází z (p + 1 - p)^n
- `P(X=k) = (n nad k)p^k * (1−p)^(n−k)`


