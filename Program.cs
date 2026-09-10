using System;
using System.Text;

namespace КТ2
{
    public class GameInventory
    {
        private readonly string[] _slots;

        public GameInventory(int slotsCount)
        {
            if (slotsCount < 0)
                throw new ArgumentOutOfRangeException(nameof(slotsCount), "Количество слотов не может быть отрицательным.");

            _slots = new string[slotsCount];
        }

        public string this[int slot]
        {
            get
            {
                if (slot < 0 || slot >= _slots.Length)
                    throw new ArgumentOutOfRangeException(nameof(slot), "Номер слота вне диапазона.");
                return _slots[slot];
            }
            set
            {
                if (slot < 0 || slot >= _slots.Length)
                    throw new ArgumentOutOfRangeException(nameof(slot), "Номер слота вне диапазона.");
                _slots[slot] = value;
            }
        }

        public int this[string itemName]
        {
            get
            {
                int count = 0;
                foreach (var item in _slots)
                {
                    if (item == itemName)
                        count++;
                }
                return count;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append('[');
            for (int i = 0; i < _slots.Length; i++)
            {
                sb.Append(_slots[i] ?? "-");
                if (i < _slots.Length - 1)
                    sb.Append(", ");
            }
            sb.Append(']');
            return sb.ToString();
        }
    }
}