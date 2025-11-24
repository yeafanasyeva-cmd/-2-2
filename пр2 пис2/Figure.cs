using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр2_пис2
{
    public abstract class Figure
    {
        public virtual string Draw()
        {
            return "Фигура";
        }

        public virtual string GetFigureType()
        {
            return "Базовая фигура";
        }

        public virtual int GetPointCount()
        {
            return 0;
        }

        public virtual List<Point2D> GetPoints()
        {
            return new List<Point2D>();
        }

        public override string ToString()
        {
            return Draw();
        }
    }
}
