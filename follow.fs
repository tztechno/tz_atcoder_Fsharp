//ABC182_A
//Follow
//input= 200 300

open System

let findValue () =
    let S = Console.ReadLine().Split() |> Array.map int
    let A = S[0]
    let B = S[1]
    let XB = 2*A+100
    Console.WriteLine(XB-B)

findValue ()
