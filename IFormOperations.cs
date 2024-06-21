using System.Collections.Generic;
using System.Windows.Forms;

namespace Zadanie
{
    public interface IFormOperations
    {
        void AddItemsToZakupy(List<string> items);
        ListBox CartListBox { get; }
    }
}
