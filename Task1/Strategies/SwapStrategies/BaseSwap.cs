using Strategies.OrderStrategies;

namespace Strategies.SwapStrategies;

public abstract class BaseSwap : ISwapStrategy
{
    public bool NeedSwap(IOrderStrategy orderer, double a, double b)
    {
        return orderer.Compare(a, b) == 1;
    }

    public abstract bool NeedSwap(IOrderStrategy orderer, double[] a, double[] b);
}