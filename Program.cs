//*****************************************************************************
//** 3011. Find if Array Can Be Sorted    leetcode                           **
//*****************************************************************************


int countSetBits(int num) {
    int count = 0;
    while (num) {
        count += num & 1;
        num >>= 1;
    }
    return count;
}

bool canSortArray(int* nums, int numsSize) {
    int preMx = -404;  
    int i = 0;
    
    while (i < numsSize) {
        int j = i + 1;
        int cnt = countSetBits(nums[i]);  
        int mi = nums[i];                 
        int mx = nums[i];                 

        while (j < numsSize && countSetBits(nums[j]) == cnt) {
            if (nums[j] < mi) {
                mi = nums[j];
            }
            if (nums[j] > mx) {
                mx = nums[j];
            }
            j++;
        }
        
        if (preMx > mi) {
            return false;
        }
        
        preMx = mx;  
        i = j;       
    }
    
    return true;
}