abc067_b.fs
#########################################
#########################################
#########################################
#########################################
#########################################
#########################################
#########################################
let n, k = stdin.ReadLine().Split() |> fun x -> int x.[0], int x.[1]
let l = stdin.ReadLine().Split() |> Array.map int |> Array.sortDescending |> Array.take k |> Array.sum |> printfn "%d"
#########################################
let k_n = stdin.ReadLine().Split(' ') |> Array.map int
let mutable a = stdin.ReadLine().Split(' ') |> Array.map int
a <- Array.sort(a)
a <- Array.rev(a)
let mutable ans = 0
for i in [0..k_n.[1]-1]do
ans<-ans+a.[i]
done;;
printfn "%d" ans
#########################################
open System

let findValue () =
    let S = Console.ReadLine().Split() |> Array.map int
    let n = S.[0]
    let k = S.[1]
    let L = Console.ReadLine().Split() |> Array.map int
    
    Array.sortInPlace L
    let sum = Array.rev L |> Array.take k |> Array.sum
    Console.WriteLine(sum)

findValue ()
#########################################
