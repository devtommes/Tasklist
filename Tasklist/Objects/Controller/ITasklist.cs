using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasklist.DBModel;

namespace Tasklist.Controller
{
    interface ITasklist : IEnumerator
    {
        void Put(Task t);
        Task PullLast();
        Task PullFirst();
        Task Pull(int index);
        
    }
}
