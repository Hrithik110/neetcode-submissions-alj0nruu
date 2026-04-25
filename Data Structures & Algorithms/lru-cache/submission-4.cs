public class LRUCache {
    private int _capacity;
    private Dictionary<int, Node> _cache;
    public Node _head;
    public Node _tail;
    public LRUCache(int capacity) {
        _capacity = capacity;
        _cache = new Dictionary<int, Node>();
        _head = new Node(0, 0);
        _tail = new Node(0, 0);

        _head.next = _tail;
        _tail.prev = _head;
    }
    
    public int Get(int key) {
        if(!_cache.ContainsKey(key)){
            return -1; //Or throw Invalid Operation Error
        }
        var node = _cache[key];

        RemoveNode(node);
        AddNode(node);
        return node.Value;
    }
    
    public void Put(int key, int value) {
        if(_cache.ContainsKey(key)){
            Node node = _cache[key];

            node.Value = value;

            RemoveNode(node);
            AddNode(node);
        }
        else{
            _cache[key] = new Node(key, value);
            AddNode(_cache[key]);
            
            if(_cache.Count > _capacity){
                var leastNode = _tail.prev;
                RemoveNode(leastNode);
                _cache.Remove(leastNode.Key);
            }

        }
    }

    public void AddNode(Node node){
        node.prev = _head;
        node.next = _head.next;
        _head.next.prev = node;
        _head.next = node;
    }

    public void RemoveNode(Node node){
        node.prev.next = node.next;

        node.next.prev = node.prev;
    }
}


public class Node{
    public int Key;
    public int Value;
    public Node next;
    public Node prev;

    public Node(int key, int val){
        Key = key;
        Value = val;
    }
}