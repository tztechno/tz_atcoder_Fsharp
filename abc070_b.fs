abc070_b.fs
##############################
let t = max (min b d - max a c) 0
##############################
##############################
##############################
##############################
let solve a b c d =
    match min b d - max a c with
    | t when t > 0 -> t
    | _ -> 0

match stdin.ReadLine().Split() |> Array.map int with
| [| a; b; c; d |] -> solve a b c d |> printfn "%d"
| _ -> ()

##############################
stdin.ReadLine()
|> fun x -> x.Split(' ')
|> Array.map int
|> fun x -> x.[0], x.[1], x.[2], x.[3]
|> fun (a, b, c, d) -> (max a c), (min b d)
|> fun (s, e) -> e - s
|> max 0
|> printfn "%d"

##############################
open System

let findValue () =
    let input = Console.ReadLine().Split() |> Array.map int
    let a = input.[0]
    let b = input.[1]
    let c = input.[2]
    let d = input.[3]
    let t = max (min b d - max a c) 0
    Console.WriteLine(t)

findValue ()
##############################
