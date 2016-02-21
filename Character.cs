using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace EvenFunnerGame
{
    class Character
    {
        public Sprite char_sprite;
        public int char_health = 10;
        public int char_speed = 5;
        public int char_attack = 10;
        public int char_defence = 10;
        public int char_dexterity = 10;

        public string char_name = "Jarrod";
        public int char_x { get; set; }
        public int char_y { get; set; }
        Texture2D char_texture;
        // Initialization //
        public Character(int x, int y)
        {
            char_x = x;
            char_y = y;
        }
        // This is where assets such as textures are loaded into the game
        public void Load(ContentManager content)
        {
            char_texture = content.Load<Texture2D>("char_jarrod.png");
            // The sprite class is initialized, it's parameters are (texture2d, the frames of the sprite sheet(columns), the levels of the sprite sheet (rows), it's x coordinate, it's y coordinate)
            char_sprite = new Sprite(char_texture, 4, 1, char_x, char_y);
        }
        // This method is called every tick
        public void Update()
        {

        }
        // This is where the game's content is drawn
        public void Draw()
        {

        }
    }
}
