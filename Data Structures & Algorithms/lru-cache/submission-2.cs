public class LRUCache {
    public int _capacity;
    public TreeNode _head;
    public TreeNode _tail;
    public Dictionary<int, TreeNode> _cache;

    public LRUCache(int capacity) {
        _capacity = capacity;
        _cache = new Dictionary<int, TreeNode>();
        _head = new TreeNode(0,0);
        _tail = new TreeNode(0,0);

        _head.next = _tail;
        _tail.prev = _head;
    }
    
    public int Get(int key) {
        if(!_cache.ContainsKey(key)) return -1;

        TreeNode node = _cache[key];

        RemoveNode(node);
        AddNode(node);

        return node.value;
        
    }
    
    public void Put(int key, int value) {
        if(_cache.ContainsKey(key)){
            TreeNode node = _cache[key];

            node.value = value;
            RemoveNode(node);
            AddNode(node);
        }
        else{
            _cache[key] = new TreeNode(key, value);
            var node = _cache[key];
            AddNode(node);
            if(_cache.Count > _capacity){
                var lastNode = _tail.prev;

                RemoveNode(lastNode);
                _cache.Remove(lastNode.key);
            }

            
        }
    }

    public void RemoveNode(TreeNode node){

        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    public void AddNode(TreeNode node){
       node.prev = _head;
        node.next = _head.next;
         _head.next.prev = node;
        _head.next = node;

    }
}


public class TreeNode{
    public int key;
    public int value;
    public TreeNode next;
    public TreeNode prev;

    public TreeNode(int key, int value){
        this.key = key;
        this.value = value;
    }
}