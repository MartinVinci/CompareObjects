using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    static class Extensions
    {
        public static List<Variance> DetailedCompare<T>(this T val1, T val2)
        {
            List<Variance> variances = new List<Variance>();
            List<List<Variance>> variancesList = new List<List<Variance>>();

            PropertyInfo[] fi = val1.GetType().GetProperties();
            foreach (PropertyInfo f in fi)
            {
                //var info = f.FieldType.GetFields();
                // If starts with System.Collections -> Continue

                var fname = f.Name;
                var fType = f.PropertyType;

                if (f.PropertyType.AssemblyQualifiedName.StartsWith("System.Collections"))
                {
                    continue;
                }
                if (!f.PropertyType.AssemblyQualifiedName.StartsWith("System"))
                {
                    continue;
                }
                Variance v = new Variance();
                v.prop = f.Name;
                v.valA = f.GetValue(val1);
                v.valB = f.GetValue(val2);

                if (v.valA == null && v.valB == null)
                {
                    continue;
                }

                // Gör else om valA är null
                if (v.valA == null)
                {
                    if (!v.valB.Equals(v.valA))
                    {
                        variances.Add(v);
                    }
                }
                else
                {
                    if (!v.valA.Equals(v.valB))
                    {
                        variances.Add(v);
                    }
                }


            }
            return variances;
        }


    }
}
