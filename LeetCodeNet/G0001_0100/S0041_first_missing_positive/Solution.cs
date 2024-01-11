namespace LeetCodeNet.G0001_0100.S0041_first_missing_positive {

// #Hard #Top_100_Liked_Questions #Top_Interview_Questions #Array #Hash_Table #Udemy_Arrays
// #Big_O_Time_O(n)_Space_O(n) #2024_01_11_Time_178_ms_(36.64%)_Space_57.6_MB_(32.67%)

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] <= 0 || nums[i] > nums.Length || nums[i] == i + 1) {
                continue;
            }
            Dfs(nums, nums[i]);
        }
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != i + 1) {
                return i + 1;
            }
        }
        return nums.Length + 1;
    }

    private void Dfs(int[] nums, int val) {
        if (val <= 0 || val > nums.Length || val == nums[val - 1]) {
            return;
        }
        int temp = nums[val - 1];
        nums[val - 1] = val;
        Dfs(nums, temp);
    }
}
}
