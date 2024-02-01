//abc173_a payment.fs
##############################
open System
let R T = stdin.ReadLine()|> T
let RS T = stdin.ReadLine().Split()|>Array.map T
let R2 T U = RS string|>fun c-> (c.[0]|>T),(c.[1]|>U)
let R3 T U V = RS string|>fun c-> (c.[0]|>T),(c.[1]|>U),(c.[2]|>V)
let R4 T U V W = RS string|>fun c-> (c.[0]|>T),(c.[1]|>U),(c.[2]|>V),(c.[3]|>W)
let R5 T U V W X = RS string|>fun c-> (c.[0]|>T),(c.[1]|>U),(c.[2]|>V),(c.[3]|>W),(c.[4]|>X)
let outl s = stdout.WriteLine(s|>string)
let outsep ls = stdout.WriteLine(String.concat " " (ls|>Array.map string))
let outsepl ls = stdout.WriteLine(String.concat "\n" (ls|>Array.map string))
[<EntryPoint>]
let main argv =
    R int
    |>fun c->(1000-(c%1000))%1000
    |>stdout.WriteLine
    0
##############################
let solve n = (10000 - n) % 1000
[<EntryPoint>]
let main argv =
    stdin.ReadLine() |> int |> solve |> printfn "%d"
    0
##############################
stdin.ReadLine()
|> int
|> fun n -> (1000 - (n % 1000)) % 1000
|> stdout.WriteLine
##############################
open System
let input = stdin.ReadLine() |> int
let n' = (input |> float |> (/) <| 1000.0) |> Math.Ceiling |> int |> (*) <| 1000
n' - input |> stdout.WriteLine
##############################
open System

let checkString () =
    let inputString = Console.ReadLine().Trim()
    let N = int inputString
    let A=(1000-N%1000)%1000
    Console.WriteLine(A)   
checkString()
##############################
