public class SnapshotArray {

    Dictionary<int,int>[] snapshot;
    int snapshotid;
    
    public SnapshotArray(int length) {
        snapshot = new Dictionary<int,int>[length];
        for(int i = 0; i < length; i++){
            snapshot[i] = new Dictionary<int,int>();
            snapshot[i].Add(0,0);
        }
        
        snapshotid = 0;
    }
    
    public void Set(int index, int val) {
        if(!snapshot[index].ContainsKey(snapshotid)){
            snapshot[index].Add(snapshotid, val);
        }
        else{
            snapshot[index][snapshotid] = val;
        }
    }
    
    public int Snap() {
        return snapshotid++;
    }
    
    public int Get(int index, int snap_id) {
       if(!snapshot[index].ContainsKey(snap_id)){
           List<int> sortedSnapShotIds = snapshot[index].Keys.ToList();
           snap_id = sortedSnapShotIds.BinarySearch(snap_id);
           if(snap_id < 0){
               snap_id = ~snap_id;
               snap_id = sortedSnapShotIds[snap_id-1];
           }
       }
        
        return snapshot[index][snap_id];
    }
}

/**
 * Your SnapshotArray object will be instantiated and called as such:
 * SnapshotArray obj = new SnapshotArray(length);
 * obj.Set(index,val);
 * int param_2 = obj.Snap();
 * int param_3 = obj.Get(index,snap_id);
 */