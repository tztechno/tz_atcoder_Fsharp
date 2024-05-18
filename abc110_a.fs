abc110_a.fs
###########################################
###########################################
###########################################
###########################################
open System
[<EntryPoint>]
let main argv =
    let abc = Console.ReadLine().Split() |> Array.map int
    (abc |> Array.sum) + (abc |> Array.max) * 9
    |> Console.WriteLine
    0
###########################################
open System
let findValue () =
    let s = Console.ReadLine().Split() |> Array.map int
    let a = s.[0]
    let b = s.[1]
    let c = s.[2]
    let maxVal = max (max a b) c
    let ans = (a + b + c) + maxVal * 9
    Console.WriteLine(ans)
findValue ()
###########################################
[python]
a,b,c=map(int,input().split())
ans=(a+b+c)+max(a,b,c)*9
print(ans)
###########################################
