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
I = kd * IL * IO * cos(N, L) + ks * IL * IO * (cos(V, R))^m

Gdzie:
- `kd`, `ks` – współczynniki rozproszenia i odbicia zwierciadlanego (od 0 do 1)
- `IL` – kolor światła (domyślnie biały)
- `IO` – kolor obiektu (stały lub z tekstury)
- `N`, `L`, `V`, `R` – znormalizowane wektory
- `m` – współczynnik połysku (1–100)

> Ujemne wartości cosinusów są przycinane do zera.

---

## 🗺️ Mapowanie normalnych (Normal Mapping)

Opcjonalna modyfikacja normalnych powierzchni za pomocą mapy wektorów normalnych:

- Kolor pikseli z tekstury normalnej (RGB) przekształcany na wektor:
  - Przykład: `RGB(127,127,255)` → `N = [0,0,1]`
- Wektor modyfikowany macierzą M = `[Pu Pv N]` w celu dopasowania do powierzchni

> Współrzędne tekstury (`u, v`) skalowane do przedziału [0, 1]

## 🎛️ Sterowanie (GUI)

- 🎚️ **Dokładność siatki** – suwak
- 🔁 **Obrót powierzchni**:
  - Kąt α (wokół osi Z) – suwak w zakresie od -45° do 45°
  - Kąt β (wokół osi X) – suwak w zakresie od 0° do 10°
- 💡 **Parametry oświetlenia**:
  - `kd`, `ks` – suwaki (0.0 – 1.0)
  - `m` – suwak połysku (1 – 100)
- 🎨 **Kolor obiektu**:
  - Radiobutton: stały kolor lub tekstura
- 🖼️ **Wczytywanie tekstur i map normalnych** z plików graficznych
- ✅ **Tryby wyświetlania**:
  - Tylko siatka
  - Tylko wypełnienie
  - Siatka + wypełnienie
- 🌈 **Źródło światła**:
  - Animacja ruchu po spirali na płaszczyźnie `z = const`
  - Suwak pozycji `z`
- 🧭 **Modyfikacja wektora normalnego** (checkbox): aktywacja mapy normalnych

## 📦 Możliwe rozszerzenia

- 💾 Eksport powierzchni do formatu `.obj`
- 🧮 Implementacja cieniowania per-pixel (np. Phong lub Gouraud)
- 🖱️ Obsługa sterowania kamerą: obrót, zoom, przesuwanie (myszą lub klawiszami)
- 💡 Obsługa różnych typów źródeł światła (np. punktowe, kierunkowe, spotlight)
- 🔧 Dynamiczne generowanie powierzchni Béziera przez użytkownika
- 📸 Zrzut ekranu i eksport sceny do pliku graficznego

## 👤 Autor

Projekt stworzony przez **Mikołaj Karbowski**  
w ramach przedmiotu **Grafika Komputerowa**  
na **Politechnice Warszawskiej**, semestr zimowy 2024/2025




