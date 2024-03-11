//abc086_a.fs
################################
################################
################################
################################
let [|a;b|] = stdin.ReadLine().Split() |> Array.map int
let solve =
    if a * b % 2 = 0
        then stdout.WriteLine("Even")
        else stdout.WriteLine("Odd")
solve 
################################
open System

let inputArray = stdin.ReadLine().Split(' ') |> Array.map int
let a = inputArray.[0]
let b: int = inputArray.[1]

let f x y = if (x*y % 2) = 0 then "Even" else "Odd"  

f a b |> printfn "%s"
################################
open System
let findValue () =
    let s = Console.ReadLine().Split() |> Array.map int
    let a = s.[0]
    let b = s.[1]
    let c = (a * b) % 2
    if c = 0 then
        Console.WriteLine("Even")
    else
        Console.WriteLine("Odd")
findValue ()
################################
