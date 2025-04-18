# 🎨 Bezier Surface Renderer

Aplikacja desktopowa do renderowania i wizualizacji powierzchni Béziera 3. stopnia w przestrzeni 3D z obsługą oświetlenia, tekstur i mapowania normalnych. Projekt zrealizowany w ramach przedmiotu **Grafika Komputerowa 2**.

---

## 🚀 Funkcjonalności

- ✅ **Wczytywanie powierzchni Béziera** z pliku tekstowego (16 punktów kontrolnych)
- ✅ **Triangulacja powierzchni** (dokładność regulowana suwakiem)
- ✅ **Obrót powierzchni** wokół osi Z (kąt α) i X (kąt β)
- ✅ **Rzut prostokątny** na płaszczyznę XY
- ✅ **Tryby wyświetlania**: tylko siatka, tylko wypełnienie lub oba
- ✅ **Model oświetlenia**: Lambert (rozproszenie) + Phong (odbicie zwierciadlane)
- ✅ **Obsługa tekstur** oraz **map wektorów normalnych**
- ✅ **Animowane źródło światła** poruszające się po spirali
- ✅ **Interpolacja barycentryczna** wektorów normalnych i współrzędnej Z wewnątrz trójkąta
- ✅ **Interfejs graficzny** z suwakami do ustawiania kd, ks, m i kątów obrotu

---

## 📄 Format pliku wejściowego

Plik tekstowy zawierający 16 linii – każda odpowiada jednemu punktowi kontrolnemu powierzchni Béziera. Każda linia zawiera 3 liczby zmiennoprzecinkowe:
| Punkt | X    | Y    | Z    |
|-------|------|------|------|
| P00   | X00  | Y00  | Z00  |
| P01   | X01  | Y01  | Z01  |
| ...   | ...  | ...  | ...  |
| P33   | X33  | Y33  | Z33  |


## 🧠 Etapy renderowania

1. **Wczytanie danych wejściowych**:
   - Punkty kontrolne powierzchni Béziera (16 sztuk)
   - Tekstura (opcjonalnie)
   - Mapa normalnych (opcjonalnie)

2. **Obliczenie punktów powierzchni Béziera** na podstawie parametrów `u, v`

3. **Generowanie siatki trójkątów** (triangulacja powierzchni z wybraną dokładnością)

4. **Obliczenie normalnych, stycznych i punktów dla każdego wierzchołka**:
   - `P`, `Pu`, `Pv`, `N`

5. **Modyfikacja wektora normalnego** przy użyciu mapy wektorów normalnych (jeśli opcja jest włączona):
   - Z tekstury odczytywany jest wektor `Ntekstury` na podstawie koloru piksela (RGB)
   - Przekształcenie: `N' = M * Ntekstury`, gdzie `M = [Pu Pv Npowierzchni]`

6. **Obrót powierzchni** wokół osi Z (kąt α) i X (kąt β)

7. **Rzut prostokątny** na płaszczyznę XY (używane tylko `x` i `y`)

8. **Interpolacja wewnątrz trójkątów** (barycentryczna dla `z`, `N`, parametrów `u, v`)

9. **Wyznaczenie koloru dla każdego piksela** na podstawie modelu oświetlenia:
   - Kolor z tekstury lub stały kolor
   - Model Lambert + Phong (z uwzględnieniem modyfikowanych normalnych)

10. **Rysowanie na canvasie** w zależności od trybu (siatka, wypełnienie, oba)


## 💡 Model oświetlenia

Wzór oparty na modelu Lamberta + Phonga:




