using UnityEngine;

public enum Element {
        Hydrogen,
        Helium,
        Lithium,
        Beryllium,
        Boron,
        Carbon,
        Nitrogen,
        Oxygen,
        Fluorine,
        Neon,
        Sodium,
        Magnesium,
        Aluminum,
        Silicon,
        Phosphorus,
        Sulfur,
        Chlorine,
        Argon,
        Potassium,
        Calcium,
        Scandium,
        Titanium,
        Vanadium,
        Chromium,
        Manganese,
        Iron,
        Cobalt,
        Nickel,
        Copper,
        Zinc,
        Gallium,
        Germanium,
        Arsenic,
        Selenium,
        Bromine,
        Krypton,
        Rubidium,
        Strontium,
        Yttrium,
        Zirconium,
        Niobium,
        Molybdenum,
        Technetium,
        Ruthenium,
        Rhodium,
        Palladium,
        Silver,
        Cadmium,
        Indium,
        Tin,
        Antimony,
        Tellurium,
        Iodine,
        Xenon,
        Cesium,
        Barium,
        Lanthanum,
        Cerium,
        Praseodymium,
        Neodymium,
        Promethium,
        Samarium,
        Europium,
        Gadolinium,
        Terbium,
        Dysprosium,
        Holmium,
        Erbium,
        Thulium,
        Ytterbium,
        Lutetium,
        Hafnium,
        Tantalum,
        Tungsten,
        Rhenium,
        Osmium,
        Iridium,
        Platinum,
        Gold,
        Mercury,
        Thallium,
        Lead,
        Bismuth,
        Polonium,
        Astatine,
        Radon,
        Francium,
        Radium,
        Actinium,
        Thorium,
        Protactinium,
        Uranium,
        Neptunium,
        Plutonium,
        Americium,
        Curium,
        Berkelium,
        Californium,
        Einsteinium,
        Fermium,
        Mendelevium,
        Nobelium,
        Lawrencium,
        Rutherfordium,
        Dubnium,
        Seaborgium,
        Bohrium,
        Hassium,
        Meitnerium,
        Darmstadtium,
        Roentgenium,
        Copernicium,
        Nihonium,
        Flerovium,
        Moscovium,
        Livermorium,
        Tennessine,
        Oganesson
}

public class MendeleevTable : MonoBehaviour
{
    // Struct for an element in the periodic table
    public struct ElementData
    {
        public string symbol;
        public string name;
        public int atomicNumber;
        public double atomicMass;
        public string electronConfig;
        public string category;
    }

    // Structs for the first 10 elements in the periodic table
    public ElementData hydrogen = new ElementData
    {
        symbol = "H",
        name = "Hydrogen",
        atomicNumber = 1,
        atomicMass = 1.008,
        electronConfig = "1s1",
        category = "Nonmetal"
    };

    public ElementData helium = new ElementData
    {
        symbol = "He",
        name = "Helium",
        atomicNumber = 2,
        atomicMass = 4.003,
        electronConfig = "1s2",
        category = "Noble gas"
    };

    public ElementData lithium = new ElementData
    {
        symbol = "Li",
        name = "Lithium",
        atomicNumber = 3,
        atomicMass = 6.941,
        electronConfig = "[He] 2s1",
        category = "Alkali metal"
    };

    public ElementData beryllium = new ElementData
    {
        symbol = "Be",
        name = "Beryllium",
        atomicNumber = 4,
        atomicMass = 9.012,
        electronConfig = "[He] 2s2",
        category = "Alkaline earth metal"
    };

    public ElementData boron = new ElementData
    {
        symbol = "B",
        name = "Boron",
        atomicNumber = 5,
        atomicMass = 10.81,
        electronConfig = "[He] 2s2 2p1",
        category = "Metalloid"
    };

    public ElementData carbon = new ElementData
    {
        symbol = "C",
        name = "Carbon",
        atomicNumber = 6,
        atomicMass = 12.01,
        electronConfig = "[He] 2s2 2p2",
        category = "Nonmetal"
    };

    public ElementData nitrogen = new ElementData
    {
        symbol = "N",
        name = "Nitrogen",
        atomicNumber = 7,
        atomicMass = 14.01,
        electronConfig = "[He] 2s2 2p3",
        category = "Nonmetal"
    };

    public ElementData oxygen = new ElementData
    {
        symbol = "O",
        name = "Oxygen",
        atomicNumber = 8,
        atomicMass = 16.00,
        electronConfig = "[He] 2s2 2p4",
        category = "Nonmetal"
    };

    public ElementData fluorine = new ElementData
    {
        symbol = "F",
        name = "Fluorine",
        atomicNumber = 9,
        atomicMass = 19.00,
        electronConfig = "[He] 2s2 2p5",
        category = "Halogen"
    };

    public ElementData neon = new ElementData
    {
        symbol = "Ne",
        name = "Neon",
        atomicNumber = 10,
        atomicMass = 20.18,
        electronConfig = "[He] 2s2 2p",
        category = "Noble gas"
     };
}
     
