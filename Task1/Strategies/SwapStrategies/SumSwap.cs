using Strategies.OrderStrategies;
using System.Linq;
namespace Strategies.SwapStrategies;

public class SumSwap : BaseSwap
{
    public override bool NeedSwap(IOrderStrategy orderer, double[] a, double[] b)
    {
        return NeedSwap(orderer, a.Sum(), b.Sum());
    }
}