using Strategies.OrderStrategies;
using System.Linq;
namespace Strategies.SwapStrategies;

public class MinSwap : BaseSwap
{
    public override bool NeedSwap(IOrderStrategy orderer, double[] a, double[] b)
    {
        return NeedSwap(orderer, a.Min(), b.Min());
    }
}