public class SnapshotArray {

    Dictionary<int,Dictionary<int,int>> snapshot;
    Dictionary<int,int> arr;
    int snapshotid;
    
    public SnapshotArray(int length) {
        arr = new Dictionary<int,int>();
        snapshot = new Dictionary<int,Dictionary<int,int>>();
        snapshotid = 0;
    }
    
    public void Set(int index, int val) {
        if(arr.ContainsKey(index)){
            arr[index] = val;
        }
        else{
            arr.Add(index,val);
        }
    }
    
    public int Snap() {
        snapshot.Add(snapshotid, new Dictionary<int,int>(arr));
        int prevsnapshotid = snapshotid;
        snapshotid++;
        return prevsnapshotid;
    }
    
    public int Get(int index, int snap_id) {
        if(snapshot[snap_id].ContainsKey(index)){
            return snapshot[snap_id][index];
        }
        return 0;
    }
}

/**
 * Your SnapshotArray object will be instantiated and called as such:
 * SnapshotArray obj = new SnapshotArray(length);
 * obj.Set(index,val);
 * int param_2 = obj.Snap();
 * int param_3 = obj.Get(index,snap_id);
 */