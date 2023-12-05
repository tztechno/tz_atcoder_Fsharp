open System

let checkString () =
    //Console.Write("Enter a string: ")
    let s = Console.ReadLine().Trim()

    let name = ["ACE"; "BDF"; "CEG"; "DFA"; "EGB"; "FAC"; "GBD"]

    match List.contains s name with
    | true  -> Console.WriteLine("Yes")
    | false -> Console.WriteLine("No")

[<EntryPoint>]
let main argv =
    checkString ()
    0 // return an integer exit code
