﻿using System.Collections.Generic;

namespace prep.utility.sorting
{
  public class ReverseComparer<T> : IComparer<T>
  {
    IComparer<T> to_reverse;

    public ReverseComparer(IComparer<T> to_reverse)
    {
      this.to_reverse = to_reverse;
    }

    public int Compare(T x, T y)
    {
      return -to_reverse.Compare(x, y);
    }
  }
}