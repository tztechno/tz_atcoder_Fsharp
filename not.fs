#ABC178_A Not

open System

let findValue () =
    let S = Console.ReadLine().Split() |> Array.map int
    let N = S[0]

    if N = 0 then
        Console.WriteLine(1)    
    else
        Console.WriteLine(0)

findValue ()
