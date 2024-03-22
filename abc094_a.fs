//abc094_a.fs
####################################
####################################
####################################
####################################
####################################
####################################
open System

[<EntryPoint>]
let main argv =
    let abx = stdin.ReadLine().Split() |> Array.map int
    let a = abx.[0]
    let b = abx.[1]
    let x = abx.[2]
    if a <= x && x <= a + b then "YES" else "NO"
    |> stdout.WriteLine
    0

####################################
stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b; x |] -> if a > x || a + b < x then "NO" else "YES"
|> printfn "%s"

####################################
open System
 
let a, b, c = Console.ReadLine().Split() |> (fun x -> int x.[0], int x.[1], int x.[2])
 
printfn (if a <= c && c <= a + b then "YES" else "NO")
####################################
open System

let findValue () =
    let S = Console.ReadLine().Split() |> Array.map int
    let a = S[0]
    let b = S[1]
    let x = S[2]
    
    if a<=x && x<=a+b then
        Console.WriteLine("YES")   
    else
        Console.WriteLine("NO")

findValue ()
####################################
