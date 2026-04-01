public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars = position.Select((pos, i) => new {pos, speed = speed[i]}).OrderByDescending(x=>x.pos).ToList();

        double prevTime = 0;
        int fleets = 0;

        foreach(var car in cars){
            double time = (double) (target - car.pos) / car.speed;

            if(time>prevTime){
                prevTime = time;
                fleets++;
            }
        }

        return fleets;
    }
}
