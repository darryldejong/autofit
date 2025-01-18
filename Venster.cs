using System;
using System.Windows.Forms;

public class AutofitWindow : Form
{
    public AutofitWindow()
    {
        var screenWidth = Screen.PrimaryScreen.Bounds.Width;
        var screenHeight = Screen.PrimaryScreen.Bounds.Height;

        this.ClientSize = new System.Drawing.Size(screenWidth, screenHeight);

        var label = new Label();
        label.Text = "Venster";
        label.Font = new System.Drawing.Font("Arial", 24);
        label.Location = new System.Drawing.Point(screenWidth / 4, screenHeight / 4);
        this.Controls.Add(label);
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new AutofitWindow());
    }
}
