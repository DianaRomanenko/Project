using Strategies.OrderStrategies;
using Strategies.SwapStrategies;

namespace Strategies.SortStrategies;

public class BubbleSort : ISortStrategy
{
    private void Swap(ref double a, ref double b)
    {
        (a, b) = (b, a);
    }

    private void Swap(ref double[] a, ref double[] b)
    {
        int len = Math.Min(a.Length, b.Length);
        for (int i = 0; i < len; i++)
        {
            Swap(ref a[i], ref b[i]);
        }
    }
    
    public void Sort(ref double[][] arr, IOrderStrategy orderer, ISwapStrategy swaper)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (swaper.NeedSwap(orderer, arr[i], arr[j]))
                {
                    Swap(ref arr[i], ref arr[j]);
                }
            }
        }
    }
}