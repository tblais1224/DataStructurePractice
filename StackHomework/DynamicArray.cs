using System;

namespace StackHomework
{
    public class DynamicArray
    {
        private Object[] _data;
        private int _length;
        public DynamicArray()
        {
            _data = new Object[5];
            _length = 0;
        }

        public Object GetItem(int index)
        {
            return _data[index];
        }

        public void Append(Object element)
        {
            if (_data.Length == _length)
            {
                _resize(_length * 2);
            }

            _data[_length] = element;
            _length++;
        }
        public void SetItem(int index, Object value)
        {
            if (index < 0 || index >= _length)
            {
                throw new InvalidOperationException("Index must be >= 0 and < length");
            }

            _data[index] = value;
        }

        private void _resize(int size)
        {
            if (size < _length)
            {
                throw new InvalidOperationException("size is invalid");
            }
            //doubles size of the array _data
            Object[] newArr = new object[size];
            _data.CopyTo(newArr, 0);
            _data = newArr;
        }
    }
}