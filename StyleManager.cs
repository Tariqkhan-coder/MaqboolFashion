using System.Drawing;
using System.Windows.Forms;

namespace MaqboolFashion
{
    public static class StyleManager
    {
        public static void button1_Click(Button btn)
        {
            btn.BackColor = Color.Maroon;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Height = 35;
            btn.Width = 150;
        }

        public static void Confirm_Click(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.DarkRed;
            btn.Font = new Font("Segoe UI", 9, FontStyle.Underline);
            btn.Cursor = Cursors.Hand;
        }
    }
}
