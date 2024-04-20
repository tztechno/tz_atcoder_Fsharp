abc073_b.fs
#######################################
#######################################
#######################################
#######################################
#######################################
let n = int (stdin.ReadLine())
[for _ in 1..n -> stdin.ReadLine().Split() |> fun x -> int x.[1] - int x.[0] + 1] |> List.sum |> printfn "%d"
#######################################
let readInt _ = stdin.ReadLine() |> int

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readInt
|> fun x -> [ 1 .. x ]
|> List.map readIntArray
|> List.sumBy (fun [| a; b |] -> b - a + 1)
|> printfn "%d"
#######################################
[my AC]
open System

let checkString () =
    let N = Console.ReadLine().Trim() |> int
    let mutable T = 0
    for i = 1 to N do
        let X = Console.ReadLine().Split() |> Array.map int
        let L = X.[0]
        let R = X.[1]
        T <- T + R - L + 1
    Console.WriteLine(T)

checkString()
#######################################
