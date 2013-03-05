#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
#endregion


namespace Shooty_Thing
{
    interface IEntity
    {
        void LoadContent(ContentManager mContentManager);
        void UnloadContent();

        void Update(GameTime mGameTime);

        void Draw(SpriteBatch mSpriteBatch);

        void Collision(IEntity with);

        Vector2 Position { get; }
        Rectangle BoundingBox { get; }
    }
}
