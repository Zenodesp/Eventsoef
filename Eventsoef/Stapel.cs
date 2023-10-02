using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventsoef
{
    internal class Stacky<T>
    {
        public event EventHandler stackChange;

        void ifStackChange(string message)
        {
            if (stackChange != null)
            {
                stackChange(message);
            }
        }

        List<T> stack = new List<T>();

        public void AddObject(T addthis)
        {
            stack.Add(addthis);
            ifStackChange("the following object has been added: " + addthis.ToString());
        }

        public void RemoveObject()
        {
            T place = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            ifStackChange("the following object has been removed: " + place.ToString());
        }

        public void Clear()
        {
            stack.Clear();
            ifStackChange("the stack has been cleared");
        }

        public string Show()
        {
            return stack.ToString();
        }
        public override string ToString()
        {
            string content = "";
            foreach (T t in stack)
                content += t.ToString() + "; ";
            return content;
        }
    }
}
