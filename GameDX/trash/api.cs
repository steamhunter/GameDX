using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dwtdxna;
using System.IO;
/*using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;*/
using Engine;
using Engine.Error;



namespace dwtdxna
{
  /*  class detect1
    {

        public static int detect(int x, int y, string level, bool ens1, bool ens2)
        {
            int enemy1y = api.carcord(0, 'y');
            int enemy1x = api.carcord(0, 'x');
            int enemy2x = api.carcord(1, 'x');
            int enemy2y = api.carcord(1, 'y');
            bool enemy1gstat = false;
            bool enemy2gstat = false;
            if (level == "start")
            {
                if (y - enemy1y <= config.detectrange && y - enemy1y >= -config.detectrange && x - enemy1x <= config.detectrange && x - enemy1x >= -config.detectrange && ens1 == true)
                {
                    if (enemy1gstat == true)
                    {
                        // battlestat.Default.isgrouped = true;
                    }
                    fight fight = new fight();
                    fight.Show();
                    ens1 = false;
                    return 1;

                }
                if (y - enemy2y <= config.detectrange && y - enemy2y >= -config.detectrange && x - enemy2x <= config.detectrange && x - enemy2x >= -config.detectrange && ens2 == true)
                {
                    if (enemy2gstat == false)
                    {
                        //battlestat.Default.isgrouped = false;
                    }
                    fight fight = new fight();
                    fight.Show();
                    return 2;

                }
            }
            return 0;
        }
    }*/
    class api
    {

        public static int detect(int x, int y, string level, bool ens1, bool ens2)
        {
            int enemy1y = 128;
            int enemy1x = 32;
            int enemy2x = 576;
            int enemy2y = 128;
            bool enemy1gstat = false;
            bool enemy2gstat = false;
            if (level == "start")
            {
                if (y - enemy1y <= 32 && y - enemy1y >= -32 && x - enemy1x <= 32 && x - enemy1x >= -32 && ens1 == true)
                {
                    if (enemy1gstat == true)
                    {
                        // battlestat.Default.isgrouped = true;
                    }
                   // fight fight = new fight();
                  //  fight.Show();
                    ens1 = false;
                    return 1;

                }
                if (y - enemy2y <= 32 && y - enemy2y >= -32 && x - enemy2x <= 32 && x - enemy2x >= -32 && ens2 == true)
                {
                    if (enemy2gstat == false)
                    {
                        // battlestat.Default.isgrouped = false;
                    }
                    //fight fight = new fight();
                   // fight.Show();
                    return 2;

                }
            }
            return 0;
        }

        public static bool afterbattle(string level, int enemyid, bool ens1, bool ens2)
        {
            if (level == "start")
            {
                if (enemyid == 0)
                {
                    if (ens1 == false)
                    {
                        return true;
                    }
                }
                if (enemyid == 1)
                {
                    if (ens2 == false)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public static int carcord(int carid, char axis)
        {
            int enemy1y = 128;
            int enemy1x = 32;
            int enemy2x = 576;
            int enemy2y = 128;
            if (carid == 0 && axis == 'x')
            {
                return enemy1x;
            }
            else if (carid == 0 && axis == 'y')
            {
                return enemy1y;
            }
            else if (carid == 1 && axis == 'x')
            {
                return enemy2x;
            }
            else if (carid == 1 && axis == 'y')
            {
                return enemy2y;
            }
            else
            {
               PathFinder.Error.error.basicError(2);
            }




            return 0;
        }

    }
    class worldclass
    {
       /* public static void genworld(string level)
        {
            PictureBox[,] pbo;
            const int maxx = 25;
            const int maxy = 14;

            pbo = new PictureBox[maxy, maxx];


            for (int i = 0; i < maxy; i++)
            {
                for (int j = 0; j < maxx; j++)
                {
                    pbo[i, j] = new PictureBox();

                    pbo[i, j].BackgroundImage = Properties.Resources.terraincell;
                    pbo[i, j].Width = 32;
                    pbo[i, j].Height = 32;
                    pbo[i, j].Top = i * 32;
                    pbo[i, j].Left = j * 32;
                    pbo[i, j].SendToBack();

                    //MessageBox.Show(Form2.ActiveForm.ToString());
                    pbo[i, j].Parent = Form1.ActiveForm;


                }
            }


        }*/
    }
    


}