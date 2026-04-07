public class Twitter {
    private int timestamp = 0;
    private PriorityQueue<Tweet, int> pq;
    private Dictionary<int, HashSet<int>> followerMap;
    public Twitter() {
        pq = new PriorityQueue<Tweet, int>();
        followerMap = new Dictionary<int, HashSet<int>>();
    }
    
    public void PostTweet(int userId, int tweetId) {
        timestamp++;
        var tweet = new Tweet(userId, tweetId, timestamp);
        pq.Enqueue(tweet, -timestamp);
    }
    
    public List<int> GetNewsFeed(int userId) {
        var feed = new List<int>();

        var tempPq = new PriorityQueue<Tweet, int>();
        int count = 0;
        while(count < 10 && pq.Count>0){
            var tweet = pq.Dequeue();

            if(tweet.UserId == userId || (followerMap.ContainsKey(userId) && followerMap[userId].Contains(tweet.UserId))){
                feed.Add(tweet.TweetId);
                count++;
            }
            tempPq.Enqueue(tweet, -tweet.Timestamp);
        }

        while(tempPq.Count > 0){
            var t = tempPq.Dequeue();
            pq.Enqueue(t, -t.Timestamp);
        }

        return feed;
        
    }
    
    public void Follow(int followerId, int followeeId) {
           if (!followerMap.ContainsKey(followerId)) {
            followerMap[followerId] = new HashSet<int>();
        }
        followerMap[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
         if (followerMap.ContainsKey(followerId)) {
            followerMap[followerId].Remove(followeeId);
        }
    }
}
public class Tweet {
    public int UserId { get; }
    public int TweetId { get; }
    public int Timestamp { get; }

    public Tweet(int userId, int tweetId, int timestamp) {
        UserId = userId;
        TweetId = tweetId;
        Timestamp = timestamp;
    }
}
