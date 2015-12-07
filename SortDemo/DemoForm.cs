using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortDemo
{
    public partial class DemoForm : Form
    {
        private const int ArrayLength = 50;
        private int[] array = new int [ArrayLength];
        private ArrayRepresenter bubble_array;
        private ArrayRepresenter insertion_array;
        private ArrayRepresenter quick_array;
        
        private class ArrayRepresenter
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

            public void RenderBars(Graphics gr, int width)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == swaping1)
                    {
                        gr.FillRectangle(Brushes.Yellow, 0, i * 6, array[i] * (width / array.Length), 4);
                        continue;
                    }

                    if (i == swaping2)
                    {
                        gr.FillRectangle(Brushes.YellowGreen, 0, i * 6, array[i] * (width / array.Length), 4);
                        continue;
                    }

                    gr.FillRectangle(Brushes.OrangeRed, 0, i * 6, array[i] * (width / array.Length), 4);
                }
            }

            internal int ItemAt(int idx)
            {
                return array[idx];
            }
        }
        public DemoForm()
        {
            InitializeComponent();
            
            for (int i = 0; i< array.Length; i++)
            {
                array[i] = i+1;
            }

            var random = new Random();

            for (int i = 0; i < array.Length * 4; i++)
            {
                var next = random.Next(0, array.Length);
                var temp = array[0];
                array[0] = array[next];
                array[next] = temp;
            }
            
        }

        private void bubbleSortPanel_Paint(object sender, PaintEventArgs e)
        {
            if (bubble_array != null)
            {
                bubble_array.RenderBars(e.Graphics, bubbleSortPanel.Width);
            }

        }
        private void insertionSortPanel_Paint(object sender, PaintEventArgs e)
        {
            if(insertion_array != null)
            {
                insertion_array.RenderBars(e.Graphics, insertionSortPanel.Width);
            }
        }


        private void quickSortPanel_Paint(object sender, PaintEventArgs e)
        {
            if (quick_array != null)
            {
                quick_array.RenderBars(e.Graphics, quickSortPanel.Width);
            }
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
                while(swapped)
                {
                    swapped = false;
                    for (int j = 1; j < bubble_array.Length; j++)
                    {
                        if (bubble_array.IsLessThan(j, j-1))
                        {
                            bubble_array.swap(j-1, j);
                            swapped = true;
                        }
                    }
                }
            });

            var t3 = Task.Run(() =>
            {
                PerformQuickSort(quick_array, 0, quick_array.Length - 1);
            });


            while (!t1.IsCompleted || !t2.IsCompleted)
            {
                insertionSortPanel.Refresh();
                bubbleSortPanel.Refresh();
                quickSortPanel.Refresh();
                System.Threading.Thread.Sleep(10);
            }

        }

        private void PerformQuickSort(ArrayRepresenter quick_array, int low, int high)
        {
            if(low < high)
            {
                var p = Partition(quick_array, low, high);
                PerformQuickSort(quick_array, low, p - 1);
                PerformQuickSort(quick_array, p + 1, high);
            }
        }

        private int Partition(ArrayRepresenter quick_array, int low, int high)
        {
            //var pivot = quick_array.ItemAt(high);
            var pivotIndex = high;
            var i = low;

            for(int j = low; j < high; j++)
            {
                if(quick_array.IsLessThan(j, pivotIndex))
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
