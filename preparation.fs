open System

let findMinValue () =
    let A = Console.ReadLine().Split() |> Array.map int
    let minVal = Array.min A
    Console.WriteLine(minVal)

findMinValue ()
