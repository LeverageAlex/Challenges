import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;

public class nPrimeNumber {

    public nPrimeNumber() throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        PrintWriter writer = new PrintWriter(System.out);

        int t = Integer.parseInt(reader.readLine());
        int[] nbrs = new int[t];



        int max = 0;
        for (int i = 0; i < t; i++) {
            nbrs[i] = Integer.parseInt(reader.readLine());
            if(nbrs[i] > max) {
                max = nbrs[i];
            }
        }
        long[] primes = new long[max+1];
        primes[0] = 2;

        int foundPrimes = 1;
        boolean flag = false;
        //Calc Primes
        outerLoop:
        for (long i = 3; foundPrimes < primes.length; i+=2) {

            flag = true;
            innerLoop:
            for (int j = 0; j < foundPrimes; j++) {
                if(i % primes[j] == 0) {
                    flag = false;
                    break innerLoop;
                }
            }
            if(flag) {
                primes[foundPrimes] = i;
                foundPrimes++;
            }

        }

        for (int i = 0; i < nbrs.length; i++) {
            writer.write(String.valueOf(primes[nbrs[i]]) + "\n");
        }
        writer.flush();






    }

    public static void main(String[] args) throws IOException {
        new nPrimeNumber();
    }
}
