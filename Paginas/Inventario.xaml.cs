using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFantasy.Paginas
{
    /// <summary>
    /// Lógica de interacción para Inventario.xaml
    /// </summary>
    public partial class Inventario : Page
    {
        public Inventario()
        {
            InitializeComponent();

            Things Copper_Armor = new Things();
            Things Tunic = new Things();
            Things Magic_Barite = new Things();
            Things Potion_Of_Strength = new Things();

            Copper_Armor SA = new Copper_Armor();
            Tunic T = new Tunic();
            Magic_Barite MB = new Magic_Barite();
            Potion_Of_Strength POS = new Potion_Of_Strength();


            Copper_Armor.itemName = $"{SA.Name}";
            Copper_Armor.itemDescription = $"Durability = {SA.Durability} , Resistance = {SA.Resistance} , Health = {SA.Health}";

            Tunic.itemName = $"{T.Name}";
            Tunic.itemDescription = $"Durability = {T.Durability} , Resistance = {T.Resistance} , Healt = {T.Health} , Intelligence = {T.Intelligence}";

            Magic_Barite.itemName = $"{MB.Name}";
            Magic_Barite.itemDescription = $"Durability = {MB.Durability} , Resistance = {MB.Resistance} , Hurt = {MB.Hurt}";

            Potion_Of_Strength.itemName = $"{POS.Name}";
            Potion_Of_Strength.itemDescription = "- Increase the " + POS.Health + "% of its strength.";


            DataGrid.Items.Add(Copper_Armor);
            DataGrid.Items.Add(Tunic);
            DataGrid.Items.Add(Magic_Barite);
            DataGrid.Items.Add(Potion_Of_Strength);

        }
        public class Things
        {
            public string itemName { get; set; }
            public string itemDescription { get; set; }
        }
        public class Additional
        {

            private string name;
            private int durability;
            private int resistance;
            private int health;
            private int hurt;
            private int intelligence;

            public string Name { get => name; set => name = value; }
            public int Durability { get => durability; set => durability = value; }
            public int Resistance { get => resistance; set => resistance = value; }
            public int Health { get => health; set => health = value; }
            public int Hurt { get => hurt; set => hurt = value; }
            public int Intelligence { get => intelligence; set => intelligence = value; }
        }
        public class Copper_Armor : Additional
        {
            public Copper_Armor()
            {
                Name = "Copper Armor";
                Durability = 65;
                Resistance = 40;
                Health = 40;
            }

        }
        public class Tunic : Additional
        {
            public Tunic()
            {
                Name = "Tunic";
                Durability = 25;
                Resistance = 50;
                Health = 62;
                Intelligence = 50;
            }
        }
        public class Magic_Barite : Additional
        {
            public Magic_Barite()
            {
                Name = "Magic Barite";
                Hurt = 12;
                Durability = 30;
                Resistance = 35;
            }
        }
        public class Potion_Of_Strength : Additional
        {
            public Potion_Of_Strength()
            {
                Name = "Potion Of Strength";
                Health = 50;

            }

        }
    }
}