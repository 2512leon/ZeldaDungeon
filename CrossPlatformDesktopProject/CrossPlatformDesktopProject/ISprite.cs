﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace CrossPlatformDesktopProject
{
    public interface ISprite
    {
     
        void Update();


        void Draw(SpriteBatch spriteBatch, Vector2 location);
    }
}
