using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace EvenFunnerGame
{
    class Character
    {
        public Sprite char_sprite;
        public int char_health = 10;
        public float char_currentspeed = 0;
        public float char_speed = 4;
        public int char_attack = 10;
        public int char_defence = 10;
        public int char_dexterity = 10;
        
        public string char_name = "Jarrod";
        public float char_x { get; set; }
        public float char_y { get; set; }
        private bool is_walking = false;
        private KeyboardState currentKeyboard;
        private KeyboardState previousKeyboard;
        Texture2D char_texture;
        // Initialization //
        public Character(float x, float y)
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
            is_walking = false;
            previousKeyboard = currentKeyboard;
            currentKeyboard = Keyboard.GetState();
            // Basic Vector Based Movement//
            if (currentKeyboard.IsKeyDown(Keys.W))
            {
                is_walking = true;
                char_sprite.Location.Y -= char_currentspeed;
            }
            if (currentKeyboard.IsKeyDown(Keys.S))
            {
                is_walking = true;
                char_sprite.Location.Y += char_currentspeed;
            }
            if (currentKeyboard.IsKeyDown(Keys.A))
            {
                is_walking = true;
                char_sprite.Location.X -= char_currentspeed;
            }
            if (currentKeyboard.IsKeyDown(Keys.D))
            {
                is_walking = true;
                char_sprite.Location.X += char_currentspeed;
            }
            if (is_walking)
            {
                Momentum();
                char_sprite.IsAnimated = true;
            }
            else
            {
                char_currentspeed = 0;
                char_sprite.IsAnimated = false;
            }
            char_x = char_sprite.Location.X;
            char_y = char_sprite.Location.Y;


            char_sprite.Update();
        }
        public void Momentum()
        {
            if (char_currentspeed <= char_speed)
            {
                char_currentspeed += 0.4f;
            }
        }
        // This is where the game's content is drawn
        public void Draw(SpriteBatch spriteBatch)
        {
            char_sprite.Draw(spriteBatch);
        }
    }
}
