using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingBlocks.Abstractions.Core.Paging;

public interface IPageList<T> where T : class
{
    int CurentPageSize { get; }
    int CurentStartIndex { get; }
    int CurrentEndIndex { get; }
    int TotalPages { get; }
    bool HasNext { get; }
    bool HasPrev { get; }
    IReadOnlyList<T> Items { get; init; }

    int TotalCount { get; }
    int PageNumber { get; }

    int PageSize { get; }

    IPageList<TR> MapTo<TR>(Func<T, TR> map)
        where TR : class;

}
