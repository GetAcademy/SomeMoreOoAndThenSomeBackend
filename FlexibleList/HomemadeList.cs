namespace FlexibleList
{
    internal class HomemadeList<T>
    {
        private T[] _numbers = new T[4];
        private int _count = 0;

        public void Add(T number)
        {
            var index = _count;
            if (index >= _numbers.Length)
            {
                var newNumbers = new T[_numbers.Length * 2];
                Array.Copy(_numbers, newNumbers, _numbers.Length);
                _numbers = newNumbers;
            }
            _numbers[index] = number;
            _count++;
        }

        public void Show()
        {
            Console.WriteLine($"Count={_count} Numbers={string.Join(',', _numbers)}");

        }
    }
}
