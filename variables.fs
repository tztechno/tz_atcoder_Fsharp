//abc170_a variables.fs
#####################################
#####################################
stdin.ReadLine().Split() |> Array.map int |> Array.findIndex (fun v -> v = 0) |> (+) 1 |> printfn "%d"
#####################################
open System
let xs = stdin.ReadLine().Split() |> Array.map int
let isZero (x:int) = 
    x = 0
let index x = Array.findIndex (fun elem -> isZero elem) x
let res = index xs
printf "%i" (res+1)
#####################################
[<EntryPoint>]
let main argv =
    let s = stdin.ReadLine().Split(' ') |> Array.map int
    let num = s |> Array.findIndex (fun x -> x = 0)
    printfn "%d" (num + 1)
    0
#####################################
open System
let findValue () =
    let X = Console.ReadLine().Split() |> Array.map int
    for i in 0 .. 4 do
        if X[i] = 0 then 
            Console.WriteLine(i + 1)
findValue ()
#####################################
