open System

let padString (input: string) =
    let n = input.Length
    match n with
    | _ when n < 4 -> printfn "%s" ("0" + input.PadLeft(3, '0'))
    | _ when n > 4 -> printfn "%s" (input.Substring(0, 4))
    | _ -> printfn "%s" input

[<EntryPoint>]
let main argv =
    let userInput = Console.ReadLine()
    padString userInput
    0 // return an integer exit code
