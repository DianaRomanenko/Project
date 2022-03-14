using Strategies.OrderStrategies;
using Strategies.SwapStrategies;

namespace Strategies.SortStrategies;

public interface ISortStrategy
{ 
    void Sort(ref double[][] arr, IOrderStrategy orderer, ISwapStrategy swaper);
}