//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"CounterfeitCoin\",\"Name\":\"MarkCounterfeitCoin\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\vb497\\\\First\\\\CounterfeitCoinAlgorithm\\\\Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"counterfeit\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CounterfeitCoin\",\"Name\":\"MarkCounterfeitCoin\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vb497\\\\First\\\\CounterfeitCoinAlgorithm\\\\Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"CounterfeitCoin\",\"Name\":\"ApplyGroverIteration\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\vb497\\\\First\\\\CounterfeitCoinAlgorithm\\\\Program.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CounterfeitCoin\",\"Name\":\"ApplyGroverIteration\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vb497\\\\First\\\\CounterfeitCoinAlgorithm\\\\Program.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"CounterfeitCoin\",\"Name\":\"FindCounterfeitCoin\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\vb497\\\\First\\\\CounterfeitCoinAlgorithm\\\\Program.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numCoins\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"counterfeit\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CounterfeitCoin\",\"Name\":\"FindCounterfeitCoin\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vb497\\\\First\\\\CounterfeitCoinAlgorithm\\\\Program.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"CounterfeitCoin\",\"Name\":\"RunFindCounterfeitCoin\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":53,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\vb497\\\\First\\\\CounterfeitCoinAlgorithm\\\\Program.qs\",\"Position\":{\"Item1\":54,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"CounterfeitCoin\",\"Name\":\"RunFindCounterfeitCoin\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\vb497\\\\First\\\\CounterfeitCoinAlgorithm\\\\Program.qs\",\"Position\":{\"Item1\":54,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
#line hidden
namespace CounterfeitCoin
{
    [SourceLocation("C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs", OperationFunctor.Body, 8, 16)]
    public partial class MarkCounterfeitCoin : Operation<(IQArray<Qubit>,Int64), QVoid>, ICallable
    {
        public MarkCounterfeitCoin(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return ((IApplyData)Data.Item1)?.Qubits;
                }
            }
        }

        String ICallable.Name => "MarkCounterfeitCoin";
        String ICallable.FullName => "CounterfeitCoin.MarkCounterfeitCoin";
        protected ICallable Length__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__Z
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> __Body__ => (__in__) =>
        {
            var (register,counterfeit) = __in__;
#line 9 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            if ((counterfeit < register.Length))
            {
#line 10 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
                Microsoft__Quantum__Intrinsic__X.Apply(register[counterfeit]);
#line 11 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
                Microsoft__Quantum__Intrinsic__Z.Controlled.Apply((register.Slice(new QRange(0L, (register.Length - 2L))), register[(register.Length - 1L)]));
#line 12 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
                Microsoft__Quantum__Intrinsic__X.Apply(register[counterfeit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Microsoft__Quantum__Intrinsic__Z = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __DataIn__((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register, Int64 counterfeit)
        {
            return __m__.Run<MarkCounterfeitCoin, (IQArray<Qubit>,Int64), QVoid>((register, counterfeit));
        }
    }

    [SourceLocation("C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs", OperationFunctor.Body, 16, 28)]
    public partial class ApplyGroverIteration : Operation<(IQArray<Qubit>,ICallable), QVoid>, ICallable
    {
        public ApplyGroverIteration(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,ICallable)>, IApplyData
        {
            public In((IQArray<Qubit>,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
                }
            }
        }

        String ICallable.Name => "ApplyGroverIteration";
        String ICallable.FullName => "CounterfeitCoin.ApplyGroverIteration";
        protected ICallable Microsoft__Quantum__Canon__ApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__Z
        {
            get;
            set;
        }

        protected ICallable Length__
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,ICallable), QVoid> __Body__ => (__in__) =>
        {
            var (register,oracle) = __in__;
#line 18 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            oracle.Apply(register);
#line 21 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__H, register));
#line 22 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__X, register));
#line 23 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            Microsoft__Quantum__Intrinsic__Z.Controlled.Apply((register.Slice(new QRange(0L, (register.Length - 2L))), register[(register.Length - 1L)]));
#line 24 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__X, register));
#line 25 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__H, register));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Canon__ApplyToEach = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Microsoft__Quantum__Intrinsic__Z = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.Z));
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __DataIn__((IQArray<Qubit>,ICallable) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register, ICallable oracle)
        {
            return __m__.Run<ApplyGroverIteration, (IQArray<Qubit>,ICallable), QVoid>((register, oracle));
        }
    }

    [SourceLocation("C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs", OperationFunctor.Body, 28, 55)]
    public partial class FindCounterfeitCoin : Operation<(Int64,Int64), Int64>, ICallable
    {
        public FindCounterfeitCoin(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "FindCounterfeitCoin";
        String ICallable.FullName => "CounterfeitCoin.FindCounterfeitCoin";
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected ICallable Microsoft__Quantum__Canon__ApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> Microsoft__Quantum__Math__Floor
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> Microsoft__Quantum__Math__PI
        {
            get;
            set;
        }

        protected ICallable<Double, Double> Microsoft__Quantum__Math__Sqrt
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> Microsoft__Quantum__Convert__IntAsDouble
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,ICallable), QVoid> ApplyGroverIteration__
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Int64), QVoid> MarkCounterfeitCoin__
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, IQArray<Result>> Microsoft__Quantum__Measurement__MultiM
        {
            get;
            set;
        }

        protected ICallable<IQArray<Result>, Int64> Microsoft__Quantum__Convert__ResultArrayAsInt
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), Int64> __Body__ => (__in__) =>
        {
            var (numCoins,counterfeit) = __in__;
#line 29 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            var result = -(1L);
#line hidden
            {
#line 31 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
                var register = Allocate__.Apply(numCoins);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 33 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
                    Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__H, register));
#line 36 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
                    var numIterations = Microsoft__Quantum__Math__Floor.Apply(((Microsoft__Quantum__Math__PI.Apply(QVoid.Instance) / 4D) * Microsoft__Quantum__Math__Sqrt.Apply(Microsoft__Quantum__Convert__IntAsDouble.Apply(numCoins))));
#line 40 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
                    foreach (var __arg2__ in new QRange(0L, (numIterations - 1L)))
#line hidden
                    {
#line 41 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
                        ApplyGroverIteration__.Apply((register, MarkCounterfeitCoin__.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,Int64)>((__arg3__) => (__arg3__, counterfeit)))));
                    }

#line 45 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
                    var measurementResults = (IQArray<Result>)Microsoft__Quantum__Measurement__MultiM.Apply(register);
#line 48 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
                    result = Microsoft__Quantum__Convert__ResultArrayAsInt.Apply(measurementResults);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(register);
                    }
                }
            }

#line 51 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            return result;
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Canon__ApplyToEach = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Math__Floor = this.__Factory__.Get<ICallable<Double, Int64>>(typeof(global::Microsoft.Quantum.Math.Floor));
            this.Microsoft__Quantum__Math__PI = this.__Factory__.Get<ICallable<QVoid, Double>>(typeof(global::Microsoft.Quantum.Math.PI));
            this.Microsoft__Quantum__Math__Sqrt = this.__Factory__.Get<ICallable<Double, Double>>(typeof(global::Microsoft.Quantum.Math.Sqrt));
            this.Microsoft__Quantum__Convert__IntAsDouble = this.__Factory__.Get<ICallable<Int64, Double>>(typeof(global::Microsoft.Quantum.Convert.IntAsDouble));
            this.ApplyGroverIteration__ = this.__Factory__.Get<ICallable<(IQArray<Qubit>,ICallable), QVoid>>(typeof(ApplyGroverIteration));
            this.MarkCounterfeitCoin__ = this.__Factory__.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(MarkCounterfeitCoin));
            this.Microsoft__Quantum__Measurement__MultiM = this.__Factory__.Get<ICallable<IQArray<Qubit>, IQArray<Result>>>(typeof(global::Microsoft.Quantum.Measurement.MultiM));
            this.Microsoft__Quantum__Convert__ResultArrayAsInt = this.__Factory__.Get<ICallable<IQArray<Result>, Int64>>(typeof(global::Microsoft.Quantum.Convert.ResultArrayAsInt));
        }

        public override IApplyData __DataIn__((Int64,Int64) data) => new In(data);
        public override IApplyData __DataOut__(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 numCoins, Int64 counterfeit)
        {
            return __m__.Run<FindCounterfeitCoin, (Int64,Int64), Int64>((numCoins, counterfeit));
        }
    }

    [SourceLocation("C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs", OperationFunctor.Body, 55, -1)]
    public partial class RunFindCounterfeitCoin : Operation<QVoid, QVoid>, ICallable
    {
        public RunFindCounterfeitCoin(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RunFindCounterfeitCoin";
        String ICallable.FullName => "CounterfeitCoin.RunFindCounterfeitCoin";
        public static EntryPointInfo<QVoid, QVoid> Info => new EntryPointInfo<QVoid, QVoid>(typeof(RunFindCounterfeitCoin));
        protected ICallable<(Int64,Int64), Int64> FindCounterfeitCoin__
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> __Body__ => (__in__) =>
        {
#line 56 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            var numCoins = 8L;
#line 57 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            var counterfeit = 3L;
#line 59 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            var foundCounterfeit = FindCounterfeitCoin__.Apply((numCoins, counterfeit));
#line 60 "C:\\Users\\vb497\\First\\CounterfeitCoinAlgorithm\\Program.qs"
            Message__.Apply(String.Format("Distinguished  counterfeit coin by group: {0}", foundCounterfeit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.FindCounterfeitCoin__ = this.__Factory__.Get<ICallable<(Int64,Int64), Int64>>(typeof(FindCounterfeitCoin));
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<RunFindCounterfeitCoin, QVoid, QVoid>(QVoid.Instance);
        }
    }
}