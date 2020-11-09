using System;
using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Armors;
using FirstFantasy.Classes.Player;
using FirstFantasy.Interfaces;
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
using FirstFantasy.Paginas;

namespace FirstFantasy.Paginas
{
    /// <summary>
    /// Lógica de interacción para PaginaR.xaml
    /// </summary>
    public partial class PaginaR : Page
    {
        public PaginaR()
        {
            InitializeComponent();
        }

        private void btnAInventory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Inventario());
        }

        Character myCharacter;

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            TxtOutput.Text = "";

            switch (CboxClass.SelectedIndex)
            {
                case 1:
                    myCharacter = new Cleric();
                    break;

                case 2:
                    myCharacter = new Fighter();
                    break;

                case 3:
                    myCharacter = new Rouge();
                    break;

                case 4:
                    myCharacter = new Wizard();
                    break;

                default:
                    myCharacter = null;
                    MessageBox.Show("select a type");
                    break;

            }
            switch (CboxWeapon.SelectedIndex)
            {
                case 1:
                    myCharacter.Weapon = new Axe();
                    break;

                case 2:
                    myCharacter.Weapon = new Bow();
                    break;

                case 3:
                    myCharacter.Weapon = new Sword();
                    break;

                default:

                    MessageBox.Show("select a weapon");
                    break;

            }
            switch (CboxArmor.SelectedIndex)
            {
                case 1:
                    myCharacter.Armor = new Gold();
                    break;

                case 2:
                    myCharacter.Armor = new Silver();
                    break;

                case 3:
                    myCharacter.Armor = new Wooden();
                    break;

                default:

                    MessageBox.Show("You MUST select a weapon");
                    break;

            }
            TxtOutput.Text = "Name: " + txtName.Text + "\n" + "Class: " + CboxClass.Text + "\n" + "Weapon: " + CboxWeapon.Text + "\n" + "Armor: " + CboxArmor.Text;

            BtnCreate.IsEnabled = false;
            btnAttack.IsEnabled = true;
        }



        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            if (myCharacter != null)
            {

                txtAttackInformation.Text = txtName.Text + "Se causó " + myCharacter.Hurt() + "de daño con el arma: " + CboxWeapon.Text;

            }
        }
    }
}

