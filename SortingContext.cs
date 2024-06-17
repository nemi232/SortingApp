
using System;

// Zastosowanie wzorca Strategia 
using SortingTask;

public class Context<T> 
    {
        private ISorts<T> strategyContext;

        public Context(ISorts<T> strategy)
        {
            strategyContext = strategy;
        }

        public IEnumerable<T> ExecuteStrategy(List<T> data)
        {
            return strategyContext.Sort(data);
        }
    }