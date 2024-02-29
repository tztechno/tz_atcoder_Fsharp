//abc169_a multiplication.fs
################################
################################
stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.reduce (*)
|> printfn "%d"
################################
stdin.ReadLine().Split()
|> Array.map int
|> fun x -> x.[0] * x.[1]
|> stdout.WriteLine
################################
let ab = stdin.ReadLine().Split() |> Array.map int64
printfn "%d" (ab.[0] * ab.[1])
################################
open System
let findValue () =
    let S = Console.ReadLine().Split() |> Array.map int
    let A = S[0]
    let B = S[1]
    Console.WriteLine(S[0]*S[1])
findValue ()
################################
