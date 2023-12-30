//ABC179_A 
//plural

open System

let padString (S: string) =
    let n = S.Length
    match S.[n-1] with
    | 's' -> printfn "%s" (S + "es")
    | _ -> printfn "%s" (S + "s")

[<EntryPoint>]
let main argv =
    let userInput = Console.ReadLine()
    padString userInput
    0
