using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const long N = 200002;
            List<long>[] g = new List<long>[N];
            List<long>[] v = new List<long>[N];
            for (long i = 0; i < N; i++)
            {
                g[i] = new List<long>();
                v[i] = new List<long>();
            }


            long[] w = new long[N],
                tin = new long[N],
                fup = new long[N],
                d = new long[N],
                cl = new long[N],
                sz = new long[N],
                dp = new long[N],
                fp = new long[N];
            bool[] used = new bool[N], f = new bool[N];
            long timer = 0, n, m, step, top; 
            void dfs (long v1, long p = -1) {
                used[v1] = true;
                tin[v1] = fup[v1] = timer++;
                foreach(var to in g[v1]) if(to != p)
                {
                    if (used[to])
                        fup[v1] = Math.Min (fup[v1], tin[to]);
                    else {
                        dfs (to, v1);
                        fup[v1] = Math.Min (fup[v1], fup[to]);
                    }

                }
            }
            void paint(long  x,long y, long k)
            {
                used[x] = true;
                d[k] += w[x];
                cl[x] = k;
                sz[k]++;
                foreach(var to in g[x]) if(to != y && !used[to])
                {
                    if(fup[to] > tin[x])
                    {
                        ++step;
                        v[step].Add(k);
                        v[k].Add(step);
                        paint(to, x, step);
                    } else paint(to, x, k);
                }
            }
            void finl(long  x,long  y)
            {
                foreach(var to in v[x]) if(to != y)
                {
                    finl(to, x);
                    if(f[to]) dp[x] += dp[to];
                    fp[x] = Math.Max(fp[x], fp[to]);
                    f[x] |= f[to];
                }
                f[x] |= (sz[x] > 1);
                if(!f[x]) fp[x] += d[x];
                else dp[x] += d[x];
            }

            string[] bufer = Console.ReadLine().Split(' ');
            n = Convert.ToInt32(bufer[0]);
            m = Convert.ToInt32(bufer[1]);
            bufer = Console.ReadLine().Split(' ');
            for(long i = 1; i <= n; i++)
            {
                w[i] = Convert.ToInt32(bufer[i - 1]);
            }
            
            for(long i = 1; i <= m; i++)
            {
                long x, y;
                 bufer = Console.ReadLine().Split(' ');
                x = Convert.ToInt32(bufer[0]);
                y = Convert.ToInt32(bufer[1]);
                
                g[x].Add(y);
                g[y].Add(x);
            }
            bufer = Console.ReadLine().Split(' ');
            top = Convert.ToInt32(bufer[0]);
            
             for(long i = 1; i <= n; i++) if(!used[i]) dfs(i);
             
            for(long i = 1; i <= n; i++) used[i] = false; 
            step = 0;
            for(long i = 1; i <= n; i++) if(!used[i]) paint(i, i, ++step);
            top = cl[top];
            finl(top, top);
            Console.WriteLine(dp[top] + fp[top]);
        }
    }
}   