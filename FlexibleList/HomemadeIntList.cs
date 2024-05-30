namespace FlexibleList
{
    internal class HomemadeIntList
    {
        private int[] _numbers = new int[4];
        private int _count = 0;

        public void Add(int number)
        {
            var index = _count;
            if (index >= _numbers.Length)
            {
                var newNumbers = new int[_numbers.Length * 2];
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
