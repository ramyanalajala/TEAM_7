class Solution:
    def find_counterfeit_coins(coins, k):
        counterfeit = []
        N = len(coins)

        def weigh_coins(i, j):
            if j - i <= k:
                counterfeit.append(coins[i:j])
                return

            balanced = (i+j) // 2
            left_coin_weights = coins[i:balanced]
            right_coin_weights = coins[balanced:j]

            total_weight_left_coins = sum(left_coin_weights)
            total_weight_right_coins = sum(right_coin_weights)

            if total_weight_left_coins == total_weight_right_coins:
                weigh_coins(balanced, j)
                weigh_coins(i, balanced)
            elif left_coin_weights < right_coin_weights:
                weigh_coins(i, balanced)

            else:
                weigh_coins(balanced, j)

        weigh_coins(0, N)

        return counterfeit[:k]

if __name__ == "__main__":
    coins = [2, 2, 1, 2, 2, 2, 2, 2, 2, 4, 4]

    solution = Solution.find_counterfeit_coins(coins, 3)

    print(solution)
