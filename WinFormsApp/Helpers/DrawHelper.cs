using Core.Models;

namespace WinFormsApp.Helpers;

public class DrawHelper
{
    private GameForm Form { get; set; }
    
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
        var pictureBox = new PictureBox();
        var image = Image.FromFile(path);
        pictureBox.Width = 30;
        pictureBox.Height = 30;
        pictureBox.Margin = Padding.Empty;
        pictureBox.Location = new Point(element.X * 30, element.Y * 30);
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        if (element is Door)
        {
            using Graphics g = Graphics.FromImage(image);
            g.DrawString((element as Door)?.Letter.ToString().ToUpper(), new Font("Organetto", 60), Brushes.Yellow, 13, 50);
        }
        else if (element is Key)
        {
            using Graphics g = Graphics.FromImage(image);
            g.DrawString((element as Key)?.Letter.ToString(), new Font("Organetto", 150), Brushes.Yellow, 30, 90);
        }
        
        pictureBox.BringToFront();
        pictureBox.Image = image;
        Form.panelGameField.Controls.Add(pictureBox);
        pictureBox.BringToFront();
    }
}
