abc097_a.fs
#########################################
#########################################
#########################################
#########################################
#########################################
#########################################
open System
 
let (a, b, c, d) = Console.ReadLine().Split() |> (fun x -> int x.[0], int x.[1], int x.[2], int x.[3])
printfn (if abs (a - c) <= d || abs (a - b) <= d && abs (b - c) <= d then "Yes" else "No")

#########################################
open System

let findValue () =
    let s = Console.ReadLine().Split() |> Array.map int
    let a = s.[0]
    let b = s.[1]
    let c = s.[2]
    let d = s.[3]

    if (abs (c - a) <= d) || ((abs (a - b) <= d) && (abs (b - c) <= d)) then
        Console.WriteLine("Yes")
    else
        Console.WriteLine("No")

findValue ()
#########################################
