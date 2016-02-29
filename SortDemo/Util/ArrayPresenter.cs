using System.Drawing;

namespace SortDemo.Util
{
    public class ArrayRepresenter
    {
        private readonly int[] array;
        private int swaping1;
        private int swaping2;
        public int numberOfSwap = 0;
        public int numberOfCompare = 0;
        public int Length { get { return array.Length; } }

        public ArrayRepresenter(int[] array)
        {
            this.array = array;
        }

        public void swap(int idx1, int idx2)
        {
            var temp = array[idx1];
            array[idx1] = array[idx2];
            array[idx2] = temp;

            swaping1 = idx1;
            swaping2 = idx2;

            numberOfSwap++;

            System.Threading.Thread.Sleep(20);
        }

        public bool IsLessThan(int idx1, int idx2)
        {
            numberOfCompare++;
            System.Threading.Thread.Sleep(4);
            return array[idx1] < array[idx2];
        }

        public void RenderBars(Graphics gr, Rectangle area)
        {
            var barWidth = (area.Height / array.Length) - 1;
            var barLengthUnit = (area.Width / array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                var brush = Brushes.OrangeRed;
                if (i == swaping1)
                {
                    brush = Brushes.Yellow;
                }

                if (i == swaping2)
                {
                    brush = Brushes.YellowGreen;
                }

                DrawBar(gr, barWidth, barLengthUnit, i, brush);
            }
        }

        private void DrawBar(Graphics gr, int barWidth, int barLengthUnit, int i, Brush brush)
        {
            gr.FillRectangle(brush, 0, i * (barWidth + 2), array[i] * barLengthUnit, barWidth);
        }
    }
}
