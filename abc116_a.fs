abc116_a.fs
###########################################
###########################################
###########################################
###########################################
###########################################
###########################################
###########################################
stdin.ReadLine().Split() |> Array.map int |> (fun [|a;b;c|] -> a * b / 2) |> printfn "%d"
###########################################
open System
let a, b, c = Console.ReadLine().Split() |> (fun x -> int x.[0], int x.[1], int x.[2])
printfn (a*b/2)
###########################################
[python]
a,b,c=map(int,input().split())
print(a*b//2)
###########################################
