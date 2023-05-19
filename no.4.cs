using System;

class MainClass {
    public static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        input = Console.ReadLine().Split(' ');
        int[] population = new int[N];
        for (int i = 0; i < N; i++) {
            population[i] = int.Parse(input[i]);
        }

        int maxCustomers = GetMaxCustomers(population, N, K);
        Console.WriteLine(maxCustomers);
    }

    static int GetMaxCustomers(int[] population, int N, int K) {
        int maxCustomers = 0;
        
        for (int i = 0; i < N; i++) {
            int customers = 0;
            
            for (int j = i - K; j <= i + K; j++) {
                if (j >= 0 && j < N) {
                    customers += population[j];
                }
            }
            
            if (customers > maxCustomers) {
                maxCustomers = customers;
            }
        }
        
        return maxCustomers;
    }
}
