namespace CounterfeitCoin {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Convert;
     open Microsoft.Quantum.Math;

    operation MarkCounterfeitCoin(register : Qubit[], counterfeit : Int) : Unit {
        if (counterfeit < Length(register)) {
            X(register[counterfeit]);
            Controlled Z(register[0..Length(register) - 2], register[Length(register) - 1]);
            X(register[counterfeit]);
        }
    }

    operation ApplyGroverIteration(register : Qubit[], oracle : (Qubit[] => Unit)) : Unit {
        
        oracle(register);

       
        ApplyToEach(H, register);
        ApplyToEach(X, register);
        Controlled Z(register[0..Length(register) - 2], register[Length(register) - 1]);
        ApplyToEach(X, register);
        ApplyToEach(H, register);
    }

    operation FindCounterfeitCoin(numCoins : Int, counterfeit : Int) : Int {
        mutable result = -1;

        using (register = Qubit[numCoins]) {
            
            ApplyToEach(H, register);

            
            let numIterations = Floor(PI() / 4.0 * Sqrt(IntAsDouble(numCoins)));

            
            // Apply Grover's algorithm
            for (_ in 0..numIterations - 1) {
                ApplyGroverIteration(register, MarkCounterfeitCoin(_, counterfeit));
            }

           
            let measurementResults = MultiM(register);

         
            set result = ResultArrayAsInt(measurementResults);
        }

        return result;
    }

    @EntryPoint()
    operation RunFindCounterfeitCoin() : Unit {
        let numCoins = 8;
        let counterfeit = 3; // The index of the counterfeit coin

        let foundCounterfeit = FindCounterfeitCoin(numCoins, counterfeit);
        Message($"Distinguished  counterfeit coin by group: {foundCounterfeit}");
    }
}