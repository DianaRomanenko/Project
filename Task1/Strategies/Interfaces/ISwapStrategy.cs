using Strategies.OrderStrategies;

namespace Strategies.SwapStrategies;

public interface ISwapStrategy
{
    bool NeedSwap(IOrderStrategy orderer, double a, double b);
    bool NeedSwap(IOrderStrategy orderer, double[] a, double[] b);
}