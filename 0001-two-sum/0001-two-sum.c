/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* twoSum(int* nums, int numsSize, int target, int* returnSize) {
    int diffList[numsSize];
    int targetIndex = -1;
    for (int i = 0; i < numsSize; i++) {
        for (int j = 0; j < i; j++) {
            if (nums[i] == diffList[j]) {
                printf("Found!");
                int* result = (int*) calloc(2,sizeof(int));
                result[0] = j;
                result[1] = i;
                *returnSize = 2;
                return result;
            }
        }
        int diff = target - nums[i];
        diffList[i] = diff;
    }
    return ((int*) calloc(2, sizeof(int)));
    
}