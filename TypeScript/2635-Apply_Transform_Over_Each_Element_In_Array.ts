// URL: https://leetcode.com/problems/apply-transform-over-each-element-in-array/
// Time Complexity: O(n)
// Space Complexity: O(n)

function map(arr: number[], fn: (n: number, i: number) => number): number[] {
  const transformedArr: number[] = [];

  arr.forEach((num, index) => {
    transformedArr[index] = fn(num, index);
  });

  return transformedArr;
}
