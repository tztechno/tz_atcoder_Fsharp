abc077_b.fs
##############################################
let m:int = int (Math.Sqrt(float n)) 
##############################################
##############################################
##############################################
let readInt _ = stdin.ReadLine() |> int

readInt ()
|> fun x ->
    seq { x .. -1 .. 1 }
    |> Seq.filter (fun a ->
        a
        |> float
        |> System.Math.Sqrt
        |> int
        |> pown
        <| 2
        |> (=) a)
    |> Seq.head
|> printfn "%d"

##############################################
let findMaxSquare x = sqrt x |> int |> (fun x -> x * x)

let thresholdFloatFromInput = stdin.ReadLine() |> float

[<EntryPoint>]
let main argv =
    let threshold = thresholdFloatFromInput
    let m = findMaxSquare threshold
    printfn "%d" m

    0
##############################################
open System

let inputArray = stdin.ReadLine().Split(' ') |> Array.map int
let n: int = inputArray.[0]
let m:int = int (Math.Sqrt(float n)) 
let ans: int = m*m
ans |> printfn "%d"

##############################################
[python]
import math
n=int(input())
m=int(math.sqrt(n))
print(m**2)
##############################################
