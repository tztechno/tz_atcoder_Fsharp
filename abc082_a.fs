abc082_a.fs
##########################################
##########################################
##########################################
##########################################
stdin.ReadLine().Split(" ")
|> Array.map float
|> Array.average
|> System.Math.Ceiling
|> int
|> printfn "%d"
##########################################
open System
[<EntryPoint>]
let main argv =
    let abx = stdin.ReadLine().Split() |> Array.map int
    let a = abx.[0]
    let b = abx.[1]
    (a+b+1)/2
    |> stdout.WriteLine
    0
##########################################
[python]
import math
a,b=map(int,input().split())
print( (a+b+1)//2 )
##########################################
