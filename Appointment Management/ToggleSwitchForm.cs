using System;
using System.Drawing;
using System.Windows.Forms;

public class ToggleSwitch : CheckBox
{
    public ToggleSwitch()
    {
        InitializeToggleSwitch();
    }

    private void InitializeToggleSwitch()
    {
        this.Appearance = Appearance.Button;
        this.AutoSize = false;
        this.Size = new Size(60, 30);
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.CheckedChanged += ToggleSwitch_CheckedChanged;
        this.Paint += ToggleSwitch_Paint;
    }

    private void ToggleSwitch_CheckedChanged(object sender, EventArgs e)
    {
        Invalidate(); // Force repaint to update appearance
    }

    private void ToggleSwitch_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        int toggleWidth = Width / 2;

        // Draw the background
        g.FillRectangle(Checked ? Brushes.Green : Brushes.Gray, ClientRectangle);

        // Draw the toggle
        Rectangle toggleRect = Checked
            ? new Rectangle(toggleWidth, 0, toggleWidth, Height)
            : new Rectangle(0, 0, toggleWidth, Height);
        g.FillRectangle(Brushes.White, toggleRect);

        // Optionally draw border
        g.DrawRectangle(Pens.Black, ClientRectangle);
    }
}
