public class MedianFinder {
    SortedList<int, int> sortedList;
    int p = -1;

    public MedianFinder() {
        sortedList = new(Comparer<int>.Create((a, b) => { return a == b ? 1 : b - a; })); // use sortedList
    }
    
    public void AddNum(int num) {
        sortedList.Add(num, num); // auto sorted when add;
    }
    
    public double FindMedian() {
        int size = sortedList.Count;
        if (size % 2 != 0) return sortedList.GetKeyAtIndex(size / 2);
        return (sortedList.GetKeyAtIndex(size / 2) + sortedList.GetKeyAtIndex((size - 1) / 2)) / (double)2;
    }
}
// [[],[6],[],[10],[],[2],[],[6],[],[5],[],[0],[],[6],[],[3],[],[1],[],[0],[],[0],[]]

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */