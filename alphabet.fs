open System

let checkCase () =
    printf "Enter a single alphabet character: "
    let x = Console.ReadLine()

    match x with
    | null | "" -> printfn "Invalid input: Please enter a single alphabet character."
    | _ ->
        let xLower = x.ToLower()
        if x = xLower then
            printfn "a"
        else
            printfn "A"

checkCase()
