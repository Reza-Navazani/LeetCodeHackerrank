internal class Solution4
{
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totaltank =0, curentcost=0, startIndex =0;
        for(int i=0; i<gas.Length; i++ ){
            int sum = gas[i]-cost[i];
            totaltank += sum;
            curentcost += sum;
            if(curentcost<0){
                startIndex=i+1;
                curentcost=0;
            }
        }
        return totaltank>=0?startIndex:-1;
    }
    public static void Main()
    {
        var can = new Solution4();
        int[] gas = [1,2,3,4,5];
        int[] cost = [3,4,5,1,2];
        int res = can.CanCompleteCircuit(gas,cost);
         Console.WriteLine("Start Index: " + res);
    }
}