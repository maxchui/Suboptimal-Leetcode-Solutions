// URL: https://leetcode.com/problems/filter-elements-from-array/
// Time Complexity: O(n)
// Space Complexity: O(n)

type Fn = (n: number, i: number) => any;

function filter(arr: number[], fn: Fn): number[] {
  const tempArr: number[] = [];

  arr.forEach((element, index) => {
    if (fn(element, index)) {
      tempArr.push(element);
    }
  });

  return tempArr;
}
