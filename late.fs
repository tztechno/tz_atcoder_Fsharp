//ABC177_A late

open System

let findValue () =
    let S = Console.ReadLine().Split() |> Array.map int
    let D = S[0]
    let T = S[1]
    let S = S[2]
    
    if D<=T*S then
        Console.WriteLine("Yes")   
    else
        Console.WriteLine("No")

findValue ()
