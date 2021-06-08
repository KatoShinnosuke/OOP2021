namespace Section01 {
    internal class SampleCodeBase {
        public int Count(int num) {
            var number = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            int count = 0;
            foreach (var n in number) {
                if (n == num) {
                    count++;
                }
                return count;
            }
        }
    }
}