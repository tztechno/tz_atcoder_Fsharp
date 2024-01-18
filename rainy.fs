//abc175_a rainy.fs

############################################
let S = stdin.ReadLine() |> Seq.toList
let r = 'R'
let s = 'S'

S
|> function
| 'R' :: 'R' :: ['R'] -> 3
| 'S' :: 'R' :: ['R'] -> 2
| 'R' :: 'S' :: ['R'] -> 1
| 'R' :: 'R' :: ['S'] -> 2
| 'S' :: 'S' :: ['R'] -> 1
| 'S' :: 'R' :: ['S'] -> 1
| 'R' :: 'S' :: ['S'] -> 1
| 'S' :: 'S' :: ['S'] -> 0
| _                   -> 0
|> stdout.WriteLine

############################################
open System

let main s = 
    match s with
    | "RRR" -> 3
    | "RRS" | "SRR" -> 2
    | "SSS" -> 0
    | nonematch -> 1

let input = Console.ReadLine()

main input |> printfn "%d"
############################################
open System

let checkString () =
    let A = Console.ReadLine().Trim()
    let DP = [|0; 0; 0; 0|]
    let ans = ref 0

    for i in 0 .. A.Length - 1 do
        if A.[i] = 'R' then
            DP.[i + 1] <- DP.[i] + 1
            if DP.[i + 1] > !ans then
                ans := DP.[i + 1]

    Console.WriteLine(!ans)

checkString()
############################################
