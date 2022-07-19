using Core;
using Core.Models;
using Core.Models.GameElements;

namespace WinFormsApp.Helpers;

public class DrawHelper
{
    private GameForm Form { get; set; }
    private const int GameElementWidth = 30;
    private const int GameElementHeight = 30;

    public DrawHelper(GameForm form)
    {
        Form = form;
    }
    
    public void DrawElement(object? sender, EventArgs e)
    {
        if (sender is not GameElement element)
        {
            return;
        }

        Dictionary<Type, string> elementPathDictionary = new()
        {
            {typeof(Door), "Assets/Images/door.png"},
            {typeof(Empty), "Assets/Images/empty.png"},
            {typeof(Exit), "Assets/Images/exit.gif"},
            {typeof(Key), "Assets/Images/key.png"},
            {typeof(Player), "Assets/Images/player.png"},
            {typeof(Wall), "Assets/Images/wall.png"},
        };
        
        var path = elementPathDictionary[element.GetType()];
        var pictureBox = CreatePictureBoxForElement(element, path);
        Form.panelGameField.Controls.Add(pictureBox);
        pictureBox.BringToFront();
    }

    private PictureBox CreatePictureBoxForElement(GameElement element, string pathToImage)
    {
        var pictureBox = new PictureBox();
        pictureBox.Width = GameElementWidth;
        pictureBox.Height = GameElementHeight;
        pictureBox.Margin = Padding.Empty;
        pictureBox.Location = new Point(element.X * GameElementWidth, element.Y * GameElementHeight);
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        
        var image = Image.FromFile(pathToImage);
        if (element is Door door)
        {
            using Graphics g = Graphics.FromImage(image);
            g.DrawString(door?.Letter.ToString().ToUpper(), new Font("Organetto", 60), Brushes.Yellow, 13, 50);
        }
        else if (element is Key key)
        {
            using Graphics g = Graphics.FromImage(image);
            g.DrawString(key?.Letter.ToString(), new Font("Organetto", 150), Brushes.Yellow, 30, 90);
        }
        
        pictureBox.Image = image;
        return pictureBox;
    }
}
