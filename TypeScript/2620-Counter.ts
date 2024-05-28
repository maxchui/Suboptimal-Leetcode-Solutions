// URL: https://leetcode.com/problems/counter/
// Time Complexity: O(1)
// Space Complexity: O(1)

// Solution: Create a closure function that returns a function that increments the counter by 1 each time it is called.
function createCounter(n: number): () => number {
  let counter: number = n;

  return function () {
    return counter++;
  };
}

/**
 * const counter = createCounter(10)
 * counter() // 10
 * counter() // 11
 * counter() // 12
 */
