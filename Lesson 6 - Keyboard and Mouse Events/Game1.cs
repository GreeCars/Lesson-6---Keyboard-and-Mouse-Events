using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lesson_6___Keyboard_and_Mouse_Events
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D pacTexture;
        Rectangle pacLocation;
        Vector2 pacSpeed;

        KeyboardState keyboardState;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            pacLocation = new Rectangle(10, 10, 75, 75);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            pacTexture = Content.Load<Texture2D>("PacRight");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            pacSpeed = new Vector2();
            keyboardState = Keyboard.GetState();
            pacSpeed = Vector2.Zero;
            if (keyboardState.IsKeyDown(Keys.Up))
            {
                pacSpeed.Y -= 2;
            }
            if (keyboardState.IsKeyDown(Keys.Down))
            {
                pacSpeed.Y += 2;
            }
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                pacSpeed.X -= 2;
            }
            if (keyboardState.IsKeyDown(Keys.Right))
            {
                pacSpeed.X += 2;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
