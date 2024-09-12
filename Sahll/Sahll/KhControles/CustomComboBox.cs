using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomComboBox : ComboBox
{
    public CustomComboBox()
    {
        // Ensure OwnerDraw mode is enabled
        this.DrawMode = DrawMode.OwnerDrawFixed;
        this.DropDownStyle = ComboBoxStyle.DropDownList; // Optional: Keeps the dropdown list style
        this.ItemHeight = 30; // Adjust item height as needed
        this.IntegralHeight = false;
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        base.OnDrawItem(e);

        if (e.Index < 0)
            return;

        // Draw the item background
        e.DrawBackground();
        using (Brush brush = new SolidBrush(e.BackColor))
        {
            e.Graphics.FillRectangle(brush, e.Bounds);
        }

        // Draw the item text
        using (Brush brush = new SolidBrush(e.ForeColor))
        {
            e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, brush, e.Bounds);
        }

        // Draw the dropdown arrow with a white background
        if ((e.State & DrawItemState.ComboBoxEdit) == 0)
        {
            Rectangle arrowRectangle = new Rectangle(this.Width - 20, 0, 20, this.Height);
            using (Brush brush = new SolidBrush(Color.White))
            {
                e.Graphics.FillRectangle(brush, arrowRectangle);
            }

            // Draw the arrow
            using (Pen pen = new Pen(Color.Black))
            {
                e.Graphics.DrawLine(pen, this.Width - 15, this.Height / 2 - 3, this.Width - 5, this.Height / 2 - 3);
                e.Graphics.DrawLine(pen, this.Width - 10, this.Height / 2, this.Width - 5, this.Height / 2 + 3);
            }
        }
    }
}
