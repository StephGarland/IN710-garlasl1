using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        Dictionary<string, Character> characterList;

        public Form1()
        {
            InitializeComponent();
            characterList = new Dictionary<string, Character>();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            if(txtName.Text != null)
            {
                string newName = txtName.Text;

                if(!characterList.ContainsKey(newName))
                {
                    string newType = GetCheckedRadioText(groupBox1);

                    Character newCharacter = CharacterCreater.CreateCharacter(newName, newType);
                    characterList.Add(newName, newCharacter);

                    ListCharacters();
                }
                else
                {
                    //TODO: feedback: character name is taken
                }
            }
            else
            {
                //TODO: feedback: name your character pls
            }
        }

        public void ListCharacters()
        {
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();

            foreach (string name in characterList.Keys)
            {
                checkedListBox1.Items.Add(name);
                checkedListBox2.Items.Add(name);
            }
        }

        string GetCheckedRadioText(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio.Text;
                }
            }
            return null;
        }

        List<string> GetCheckedListBoxText(CheckedListBox listbox)
        {
            List<string> checkedCharacter = new List<string>();
            if (listbox.CheckedItems.Count != 0)
            {
                for (int x = 0; x <= listbox.CheckedItems.Count - 1; x++)
                {
                    checkedCharacter.Add(listbox.CheckedItems[x].ToString());
                }
            }
            return checkedCharacter;
        }

        private void btnChangeWeapon_Click(object sender, EventArgs e)
        {
            List<string> characters = GetCheckedListBoxText(checkedListBox2);
            string newWeapon = GetCheckedRadioText(groupBox2);

            foreach (string character in characters)
            {
                if(characterList.ContainsKey(character))
                {
                    characterList[character].Weapon = WeaponCreator.CreateWeapon(newWeapon);
                }
            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> characters = GetCheckedListBoxText(checkedListBox1);
            //make the character statename, then declaim, then use weapon
            foreach (string character in characters)
            {
                if (characterList.ContainsKey(character))
                {
                    listBox1.Items.Add(characterList[character].StateName());
                    listBox1.Items.Add(characterList[character].Declaim());
                    listBox1.Items.Add(characterList[character].Weapon.UseWeapon());
                    listBox1.Items.Add("");
                }
            }
        }
    }
}
