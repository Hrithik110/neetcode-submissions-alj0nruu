public class LRUCache {
    public int Capacity;
    public Dictionary<int, LruNode> Cache;
    public LruNode Head;
    public LruNode Tail;
    public LRUCache(int capacity) {
        Capacity = capacity;

        Cache = new Dictionary<int, LruNode>();

        Head = new LruNode(0, 0);
        Tail = new LruNode(0, 0);
        Head.Next = Tail;
        Tail.Prev = Head;
    }
    
    public int Get(int key) {
        if(!Cache.ContainsKey(key)) return -1;

        var node = Cache[key];

        RemoveNode(node);
        AddNode(node);

        return node.Value;
    }
    
    public void Put(int key, int value) {
        if(Cache.ContainsKey(key)){
            var node = Cache[key];
            node.Value = value;

            RemoveNode(node);
            AddNode(node);
        }
        else{
            Cache[key] = new LruNode(key, value);
            AddNode(Cache[key]);

            if(Cache.Count > Capacity){
                var lastNode = Tail.Prev;
                RemoveNode(lastNode);
                Cache.Remove(lastNode.Key);
            }
        }
    }

    public void AddNode(LruNode node){
        node.Prev = Head;
        node.Next = Head.Next;
        Head.Next.Prev = node;
        Head.Next = node;
       
    }

    public void RemoveNode(LruNode node){
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
    }
}


public class LruNode {
    public int Key;
    public int Value;
    public LruNode Prev;
    public LruNode Next;

    public LruNode(int key, int value){
        Key = key;
        Value = value;
    }
}