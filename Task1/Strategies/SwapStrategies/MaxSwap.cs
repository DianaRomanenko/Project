using Strategies.OrderStrategies;
using System.Linq;
namespace Strategies.SwapStrategies;

public class MaxSwap : BaseSwap
{
    public override bool NeedSwap(IOrderStrategy orderer, double[] a, double[] b)
    {
        return NeedSwap(orderer, a.Max(), b.Max());
    }
}