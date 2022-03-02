using game.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        Swordsman swordsmanHero = new Swordsman();
        Wizard wizardHero = new Wizard();

        bool isGameOver;
        bool goLeftWizard, goRightWizard, jumpingWizard, takeWaponWizard, dropWeaponWizard, changeWeaponWizard;
        bool goLeftSwordsman, goRightSwordsman, jumpingSwordsman, takeWeaponSwordsman, dropWeaponSwordman, changeWeaponSwordsman;

        int jumpSpeedWizard, jumpSpeedSwordsman;
        int force;
        int wizardSpeed = 7;
        int swordsmanSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int dragonSpeed = 5;
        int wizardDragonHealth = 150;
        int swordsmanDragonHealth = 150;
        int spiderSpeed = 3;
        int wizardSpiderHealth = 150;
        int swordsmanSpiderHealth = 150;

        enum dragonAttacks { strikes, spitsFire };
        enum spiderAttacks { strikes, bites }

        public Form1()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            wizard.Top += jumpSpeedWizard;
            swordsman.Top += jumpSpeedSwordsman;

            wizardHealth.Text = "Helath: " + wizardHero.Health;
            swordsmanHealth.Text = "Health: " + swordsmanHero.Health;

            dragonWizardHealth.Text = "Dragon health: " + wizardDragonHealth;
            spiderWizardHealth.Text = "Spider health: " + wizardSpiderHealth;

            dragonSwordsmanHealth.Text = "Dragon health: " + swordsmanDragonHealth;
            spiderSwordsmanHealth.Text = "Spider health: " + swordsmanSpiderHealth;

            //wizard
            if (goLeftWizard == true)
            {
                wizard.Left -= wizardSpeed;
            }
            if (goRightWizard == true)
            {
                wizard.Left += wizardSpeed;
            }

            if (jumpingWizard == true && force < 0)
            {
                jumpingWizard = false;
            }
            if (jumpingWizard == true)
            {
                jumpSpeedWizard = -8;
                force -= 1;
            }
            else
            {
                jumpSpeedWizard = 10;
            }


            //swordsman
            if (goLeftSwordsman == true)
            {
                swordsman.Left -= swordsmanSpeed;
            }
            if (goRightSwordsman == true)
            {
                swordsman.Left += swordsmanSpeed;
            }

            if (jumpingSwordsman == true && force < 0)
            {
                jumpingSwordsman = false;
            }
            if (jumpingSwordsman == true)
            {
                jumpSpeedSwordsman = -8;
                force -= 1;
            }
            else
            {
                jumpSpeedSwordsman = 10;
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {

                    if ((string)x.Tag == "platform")
                    {
                        if (wizard.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            wizard.Top = x.Top - wizard.Height;

                            if ((string)x.Name == "horizontalPlatform" && goLeftWizard == false || (string)x.Name == "horizontalPlatform" && goRightWizard == false)
                            {
                                wizard.Left -= horizontalSpeed;
                            }

                        }
                        if (swordsman.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            swordsman.Top = x.Top - swordsman.Height;

                            if ((string)x.Name == "horizontalPlatform" && goLeftSwordsman == false || (string)x.Name == "horizontalPlatform" && goRightSwordsman == false)
                            {
                                swordsman.Left -= horizontalSpeed;
                            }

                        }
                        x.BringToFront();
                    }

                    if((string)x.Tag == "weapons")
                    {
                        if (wizard.Bounds.IntersectsWith(x.Bounds))
                        {
                            wizard.BringToFront();

                            if (takeWaponWizard)
                            {
                                string message = wizardHero.TakeWeapon((string)x.Name, x.TabIndex);
                                if (message == "Taken")
                                {
                                    x.Visible = false;
                                    wizardHero.ActiveWeapon = x.TabIndex;
                                    string backpack = "";
                                    foreach (KeyValuePair<int, string> weapon in wizardHero.Backpack)
                                    {
                                        backpack += weapon.Value + " ";
                                    }
                                    wizardBackpack.Text = "Backpack: " + backpack;
                                    wizardActiveWeapon.Text = "Active weapon: " + (string)x.Name;
                                }
                                else
                                {
                                    wizardMessage.Text = message;
                                }
                                takeWaponWizard = false;
                            }

                        }

                        if (swordsman.Bounds.IntersectsWith(x.Bounds))
                        {
                            swordsman.BringToFront();

                            if (takeWeaponSwordsman)
                            {
                                string message = swordsmanHero.TakeWeapon((string)x.Name, x.TabIndex);
                                if (message == "Taken")
                                {
                                    x.Visible = false;
                                    swordsmanHero.ActiveWeapon = x.TabIndex;
                                    string backpack = "";
                                    foreach (KeyValuePair<int, string> weapon in swordsmanHero.Backpack)
                                    {
                                        backpack += weapon.Value + " ";
                                    }
                                    swordsmanBackpack.Text = "Backpack: " + backpack;
                                    swordsmanActiveWeapon.Text = "Active weapon: " + (string)x.Name;
                                }
                                else
                                {
                                    swordsmanMessage.Text = message;
                                }
                                takeWeaponSwordsman = false;
                            }

                        }

                        
                    }

                    if((string)x.Tag == "monsters")
                    {
                        if (wizard.Bounds.IntersectsWith(x.Bounds))
                        {
                            wizard.BringToFront();

                            //fight between dragon and wizard
                            if (x.Name == "dragon")
                            {
                                if (wizardHero.ActiveWeapon != 0 && dragon.Visible == true)
                                {
                                    Random random = new Random();
                                    int howAttack = random.Next(0, 101); // under 50 heroe attack. under 100 monster attack

                                    if (howAttack <= 50)
                                    {
                                        if (wizardActiveWeapon.Text.Contains("magic"))
                                        {
                                            wizardDragonHealth -= 20;
                                            dragonWizardHealth.Text = "Dragon health: " + wizardDragonHealth;
                                        }

                                        if (wizardDragonHealth < 0)
                                        {
                                            wizardMessage.Text = "You killed dragon";
                                            dragonWizardHealth.Text = "Dragon health: 0";
                                            dragon.Visible = false;
                                        }

                                    }
                                    else
                                    {
                                        Type type = typeof(dragonAttacks);

                                        Array values = type.GetEnumValues();

                                        int index = random.Next(values.Length);
                                        dragonAttacks value = (dragonAttacks)values.GetValue(index);

                                        if (value.ToString() == "strikes")
                                        {
                                            wizardHero.Health -= 5;
                                            wizardHealth.Text = "Health: " + wizardHero.Health;
                                        }
                                        else
                                        {
                                            wizardHero.Health -= 20;
                                            wizardHealth.Text = "Health: " + wizardHero.Health;
                                        }

                                        if (wizardHero.Health < 0)
                                        {
                                            gameTimer.Stop();
                                            isGameOver = true;
                                            wizardHealth.Text = "Helth: 0";
                                            wizardMessage.Text = "You are dead";
                                            swordsmanMessage.Text = "You won";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (wizardHero.ActiveWeapon != 0 && spider.Visible == true)
                                {
                                    Random random = new Random();
                                    int howAttack = random.Next(0, 101); // under 50 heroe attack. under 100 monster attack

                                    if (howAttack <= 50)
                                    {
                                        if (wizardActiveWeapon.Text.Contains("magic"))
                                        {
                                            wizardSpiderHealth -= 20;
                                            spiderWizardHealth.Text = "Spider health: " + wizardSpiderHealth;
                                        }

                                        if (wizardSpiderHealth < 0)
                                        {
                                            wizardMessage.Text = "You killed spider";
                                            spiderWizardHealth.Text = "Spider health: 0";
                                            spider.Visible = false;
                                        }

                                    }
                                    else
                                    {
                                        Type type = typeof(spiderAttacks);

                                        Array values = type.GetEnumValues();

                                        int index = random.Next(values.Length);
                                        spiderAttacks value = (spiderAttacks)values.GetValue(index);

                                        if (value.ToString() == "strikes")
                                        {
                                            wizardHero.Health -= 5;
                                            wizardHealth.Text = "Health: " + wizardHero.Health;
                                        }
                                        else
                                        {
                                            wizardHero.Health -= 8;
                                            wizardHealth.Text = "Health: " + wizardHero.Health;
                                        }

                                        if (wizardHero.Health < 0)
                                        {
                                            gameTimer.Stop();
                                            isGameOver = true;
                                            wizardHealth.Text = "Helth: 0";
                                            wizardMessage.Text = "You are dead";
                                            swordsmanMessage.Text = "You won";
                                        }
                                    }
                                }
                            }
                        }

                        if (swordsman.Bounds.IntersectsWith(x.Bounds))
                        {
                            swordsman.BringToFront();

                            if(x.Name == "dragon")
                            {
                                if (swordsmanHero.ActiveWeapon != 0 && dragon.Visible == true)
                                {
                                    Random random = new Random();
                                    int howAttack = random.Next(0, 101); // under 50 heroe attack. under 100 monster attack

                                    if (howAttack <= 50)
                                    {
                                        if (swordsmanActiveWeapon.Text.Contains("sword"))
                                        {
                                            swordsmanDragonHealth -= 10;
                                            dragonSwordsmanHealth.Text = "Dragon health: " + swordsmanDragonHealth;
                                        }
                                        else
                                        {
                                            swordsmanDragonHealth -= 15;
                                            dragonSwordsmanHealth.Text = "Dragon health: " + swordsmanDragonHealth;
                                        }

                                        if (swordsmanDragonHealth < 0)
                                        {
                                            swordsmanMessage.Text = "You killed dragon";
                                            dragonSwordsmanHealth.Text = "Dragon health: 0";
                                            dragon.Visible = false;
                                        }

                                    }
                                    else
                                    {
                                        Type type = typeof(dragonAttacks);

                                        Array values = type.GetEnumValues();

                                        int index = random.Next(values.Length);
                                        dragonAttacks value = (dragonAttacks)values.GetValue(index);

                                        if (value.ToString() == "strikes")
                                        {
                                            swordsmanHero.Health -= 5;
                                            swordsmanHealth.Text = "Health: " + swordsmanHero.Health;
                                        }
                                        else
                                        {
                                            swordsmanHero.Health -= 20;
                                            swordsmanHealth.Text = "Health: " + swordsmanHero.Health;
                                        }

                                        if (swordsmanHero.Health < 0)
                                        {
                                            gameTimer.Stop();
                                            isGameOver = true;
                                            swordsmanHealth.Text = "Helth: 0";
                                            swordsmanMessage.Text = "You are dead";
                                            wizardMessage.Text = "You won";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (swordsmanHero.ActiveWeapon != 0 && spider.Visible == true)
                                {
                                    Random random = new Random();
                                    int howAttack = random.Next(0, 101); // under 50 heroe attack. under 100 monster attack

                                    if (howAttack <= 50)
                                    {
                                        if (swordsmanActiveWeapon.Text.Contains("sword"))
                                        {
                                            swordsmanSpiderHealth -= 10;
                                            spiderSwordsmanHealth.Text = "Spider health: " + swordsmanSpiderHealth;
                                        }
                                        else
                                        {
                                            swordsmanSpiderHealth -= 15;
                                            spiderSwordsmanHealth.Text = "Spider health: " + swordsmanSpiderHealth;
                                        }

                                        if (swordsmanSpiderHealth < 0)
                                        {
                                            swordsmanMessage.Text = "You killed spider";
                                            spiderSwordsmanHealth.Text = "Spider health: 0";
                                            spider.Visible = false;
                                        }

                                    }
                                    else
                                    {
                                        Type type = typeof(spiderAttacks);

                                        Array values = type.GetEnumValues();

                                        int index = random.Next(values.Length);
                                        spiderAttacks value = (spiderAttacks)values.GetValue(index);

                                        if (value.ToString() == "strikes")
                                        {
                                            swordsmanHero.Health -= 5;
                                            swordsmanHealth.Text = "Health: " + swordsmanHero.Health;
                                        }
                                        else
                                        {
                                            swordsmanHero.Health -= 8;
                                            swordsmanHealth.Text = "Health: " + swordsmanHero.Health;
                                        }

                                        if (swordsmanHero.Health < 0)
                                        {
                                            gameTimer.Stop();
                                            isGameOver = true;
                                            swordsmanHealth.Text = "Helth: 0";
                                            swordsmanMessage.Text = "You are dead";
                                            wizardMessage.Text = "You won";
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }

            horizontalPlatform.Left -= horizontalSpeed;

            if (horizontalPlatform.Left < 0 || horizontalPlatform.Left + horizontalPlatform.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            verticalPlatform.Top += verticalSpeed;

            if (verticalPlatform.Top < 548 || verticalPlatform.Top > 740)
            {
                verticalSpeed = -verticalSpeed;
            }

            if (dropWeaponWizard)
            {
                string result = wizardHero.DropWeapon(wizardHero.ActiveWeapon);
                if (result == "Empty")
                {
                    wizardMessage.Text = "Wizard backpack is empty.";
                }
                else
                {
                    string weaponName = "";
                    foreach (KeyValuePair<int, string> weapon in wizardHero.Backpack)
                    {
                        weaponName = weapon.Value;
                        wizardHero.ActiveWeapon = weapon.Key;
                        break;
                    }
                    wizardActiveWeapon.Text = "Active weapon: " + weaponName;
                    if(weaponName == "")
                    {
                        wizardBackpack.Text = "Backpack: empty";
                    }
                    else
                    {
                        wizardBackpack.Text = "Backpack: " + weaponName;
                    }
                    
                    foreach (Control x in this.Controls)
                    {
                        if(x is PictureBox)
                        {
                            if(x.Name == result)
                            {
                                x.Visible = true;
                            }
                        }
                    }
                 }
                dropWeaponWizard = false;
            }

            if (dropWeaponSwordman)
            {
                string result = swordsmanHero.DropWeapon(swordsmanHero.ActiveWeapon);
                if (result == "Empty")
                {
                    swordsmanMessage.Text = "Swordsman backpack is empty.";
                }
                else
                {
                    string weaponName = "";
                    foreach (KeyValuePair<int, string> weapon in swordsmanHero.Backpack)
                    {
                        weaponName = weapon.Value;
                        swordsmanHero.ActiveWeapon = weapon.Key;
                        break;
                    }
                    swordsmanActiveWeapon.Text = "Active weapon: " + weaponName;
                    if (weaponName == "")
                    {
                        swordsmanBackpack.Text = "Backpack: empty";
                    }
                    else
                    {
                        swordsmanBackpack.Text = "Backpack: " + weaponName;
                    }

                    foreach (Control x in this.Controls)
                    {
                        if (x is PictureBox)
                        {
                            if (x.Name == result)
                            {
                                x.Visible = true;
                            }
                        }
                    }
                }
                dropWeaponSwordman = false;
            }

            if (changeWeaponWizard)
            {
                string result = wizardHero.ChangeWeapon();
                if(result == "NoWeapon")
                {
                    wizardMessage.Text = "No taken weapon";
                }else if(result != null)
                {
                    wizardActiveWeapon.Text = "Active weapon: " + result;
                }
                changeWeaponWizard = false;
            }

            if (changeWeaponSwordsman)
            {
                string result = swordsmanHero.ChangeWeapon();
                if (result == "NoWeapon")
                {
                    swordsmanMessage.Text = "No taken weapon";
                }
                else if (result != null)
                {
                    swordsmanActiveWeapon.Text = "Active weapon: " + result;
                }
                changeWeaponSwordsman = false;
            }

            dragon.Left -= dragonSpeed;

            if (dragon.Left < pictureBox4.Left || dragon.Left + dragon.Width > pictureBox4.Left + pictureBox4.Width)
            {
                dragonSpeed = -dragonSpeed;
            }

            spider.Left += spiderSpeed;

            if (spider.Left < pictureBox5.Left || spider.Left + spider.Width > pictureBox5.Left + pictureBox5.Width)
            {
                spiderSpeed = -spiderSpeed;
            }

            if (wizard.Top + wizard.Height > this.ClientSize.Height + 50)
            {
                wizardHealth.Text = "Helth: 0";
                wizardMessage.Text = "You fell to your death!";
            }

            if (swordsman.Top + swordsman.Height > this.ClientSize.Height + 50)
            {
                swordsmanHealth.Text = "Helth: 0";
                swordsmanMessage.Text = "You fell to your death!";
            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            //wizard
            if(e.KeyCode == Keys.Left)
            {
                goLeftWizard = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRightWizard = true;
            }
            if(e.KeyCode == Keys.X)
            {
                takeWaponWizard = true;
            }
            if(e.KeyCode == Keys.Z)
            {
                dropWeaponWizard = true;
            }
            if(e.KeyCode == Keys.C)
            {
                changeWeaponWizard = true;
            }
            if(e.KeyCode == Keys.Up && jumpingWizard == false)
            {
                jumpingWizard = true;
            }

            //swordsman
            if(e.KeyCode == Keys.A)
            {
                goLeftSwordsman = true;
            }
            if(e.KeyCode == Keys.D)
            {
                goRightSwordsman = true;
            }
            if (e.KeyCode == Keys.Q)
            {
                takeWeaponSwordsman = true;
            }
            if(e.KeyCode == Keys.E)
            {
                dropWeaponSwordman = true;
            }
            if(e.KeyCode == Keys.R)
            {
                changeWeaponSwordsman = true;
            }
            if (e.KeyCode == Keys.W && jumpingSwordsman == false)
            {
                jumpingSwordsman = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //wizard
            if (e.KeyCode == Keys.Left)
            {
                goLeftWizard = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRightWizard = false;
            }
            if (e.KeyCode == Keys.X)
            {
                takeWaponWizard = false;
            }
            if (e.KeyCode == Keys.Z)
            {
                dropWeaponWizard = false;
            }
            if (e.KeyCode == Keys.C)
            {
                changeWeaponWizard = false;
            }
            if (jumpingWizard)
            {
                jumpingWizard = false;
            }

            //swordsman
            if (e.KeyCode == Keys.A)
            {
                goLeftSwordsman = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRightSwordsman = false;
            }
            if (e.KeyCode == Keys.Q)
            {
                takeWeaponSwordsman = false;
            }
            if (e.KeyCode == Keys.E)
            {
                dropWeaponWizard = false;
            }
            if (e.KeyCode == Keys.R)
            {
                changeWeaponSwordsman = false;
            }
            if (jumpingSwordsman)
            {
                jumpingSwordsman = false;
            }

            //reset game
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                ResetGame();
            }
        }

        private void ResetGame()
        {
            jumpingWizard = false;
            jumpingSwordsman = false;
            goLeftWizard = false;
            goLeftSwordsman = false;
            goRightWizard = false;
            goRightSwordsman = false;
            isGameOver = false;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            wizard.Left = 27;
            wizard.Top = 655;

            swordsman.Left = 549;
            swordsman.Top = 655;

            dragon.Left = 313;
            spider.Left = 729;

            gameTimer.Start();
        }
    }
}
