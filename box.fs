#ABC180_A
#box

open System
let findValue () =
    let S = Console.ReadLine().Split() |> Array.map int
    let N = S[0]
    let A = S[1]
    let B = S[2]
    Console.WriteLine(N-A+B)
findValue ()
