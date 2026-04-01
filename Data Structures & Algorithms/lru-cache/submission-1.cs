public class LRUCache {
    public Dictionary<int, Node> _cache;
    public int _capacity;
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
        if(!_cache.ContainsKey(key)) return -1;

        Node node = _cache[key];

        RemoveNode(node);
        AddNode(node);

        return node.value;
    }
    
    public void Put(int key, int value) {

        if(_cache.ContainsKey(key)){
            Node node = _cache[key];
            node.value = value;
            RemoveNode(node);
            AddNode(node);
        }
        else{
            Node newNode = new Node(key, value);
            AddNode(newNode);
            _cache[key] = newNode;
            if(_cache.Count > _capacity){
                var lastNode = _tail.prev;
                RemoveNode(lastNode);
                _cache.Remove(lastNode.key);
            }

        }
        
    }
    public void RemoveNode(Node node){
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    public void AddNode(Node node){
      
        node.prev = _head;
        node.next = _head.next;
         _head.next.prev = node;
        _head.next = node;

    }
}

public class Node {
    public int key;
    public int value;
    public Node next;
    public Node prev;
    public Node(int key, int value){
        this.key = key;
        this.value = value;
    }
}