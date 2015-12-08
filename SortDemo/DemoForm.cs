using SortDemo.Util;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortDemo
{
    public partial class DemoForm : Form
    {
        private const int ArrayLength = 25;
        private int[] array = new int[ArrayLength];
        private ArrayRepresenter bubble_array;
        private ArrayRepresenter insertion_array;
        private ArrayRepresenter quick_array;

        public DemoForm()
        {
            InitializeComponent();
            CreateSortedArray();
            RanodomizeArray();
        }

        private void RanodomizeArray()
        {
            var random = new Random();
            for (int i = 0; i < array.Length * 4; i++)
            {
                var next = random.Next(0, array.Length);
                var temp = array[0];
                array[0] = array[next];
                array[next] = temp;
            }
        }

        private void CreateSortedArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
        }

        private void bubbleSortPanel_Paint(object sender, PaintEventArgs e)
        {

            bubble_array?.RenderBars(e.Graphics, e.ClipRectangle);

        }
        private void insertionSortPanel_Paint(object sender, PaintEventArgs e)
        {
            insertion_array?.RenderBars(e.Graphics, e.ClipRectangle);
        }


        private void quickSortPanel_Paint(object sender, PaintEventArgs e)
        {
            quick_array?.RenderBars(e.Graphics, e.ClipRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertion_array = new ArrayRepresenter((int[])array.Clone());
            bubble_array = new ArrayRepresenter((int[])array.Clone());
            quick_array = new ArrayRepresenter((int[])array.Clone());

            var t1 = Task.Run(() =>
            {
                for (int i = 0; i < insertion_array.Length; i++)
                {
                    for (int j = i; j < insertion_array.Length; j++)
                    {
                        if (insertion_array.IsLessThan(j, i))
                        {
                            insertion_array.swap(i, j);
                        }
                    }
                }
            });

            var t2 = Task.Run(() =>
            {
                var swapped = true;
                while (swapped)
                {
                    swapped = false;
                    for (int j = 1; j < bubble_array.Length; j++)
                    {
                        if (bubble_array.IsLessThan(j, j - 1))
                        {
                            bubble_array.swap(j - 1, j);
                            swapped = true;
                        }
                    }
                }
            });

            var t3 = Task.Run(() =>
            {
                PerformQuickSort(quick_array, 0, quick_array.Length - 1);
            });

            while (!t1.IsCompleted || !t2.IsCompleted || !t3.IsCompleted)
            {
                insertionSortPanel.Refresh();
                bubbleSortPanel.Refresh();
                quickSortPanel.Refresh();
                System.Threading.Thread.Sleep(10);
            }

        }

        private void PerformQuickSort(ArrayRepresenter quick_array, int low, int high)
        {
            if (low < high)
            {
                var p = Partition(quick_array, low, high);
                PerformQuickSort(quick_array, low, p - 1);
                PerformQuickSort(quick_array, p + 1, high);
            }
        }

        private int Partition(ArrayRepresenter quick_array, int low, int high)
        {
            var pivotIndex = high;
            var i = low;

            for (int j = low; j < high; j++)
            {
                if (quick_array.IsLessThan(j, pivotIndex))
                {
                    quick_array.swap(i, j);
                    i++;
                }
            }

            quick_array.swap(i, high);
            return i;
        }

    }
}
