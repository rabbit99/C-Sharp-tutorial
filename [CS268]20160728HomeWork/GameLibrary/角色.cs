using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class 角色
    {
        public string Name { get; set; }
        public float Hp { get; set; }
        public string status { get; set; }

        public Color Color
        {
            get
            {
                switch (this.status)
                {
                    case "角色":
                        return Color.Red;

                    case "戰士":
                        return Color.Green;

                    case "法師":
                        return Color.Blue;

                    default:
                        return Color.Black;
                };
            }
        }

        public virtual void Attack()
        {
            Console.WriteLine("我還沒有學會技能");
        }

        public override string ToString()
        {
            return string.Format("職業={0},HP={1}", this.Name, this.Hp);
        }
    }
}