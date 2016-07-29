using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLibrary.combo
{
    public class CharacterListBox : ListBox
    {
        public CharacterListBox() : base()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            if (e.Index < 0) { return; }
            e.DrawBackground();
            if (Items[e.Index] is 角色)
            {
                角色 product = this.Items[e.Index] as 角色;
                Font font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
                Brush brush = new SolidBrush(product.Color);
                e.Graphics.DrawString(product.ToString(), font, brush, e.Bounds.X, e.Bounds.Y);
            }
        }
    }
}