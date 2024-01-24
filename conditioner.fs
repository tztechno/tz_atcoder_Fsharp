//abc174_a conditioner.fs

####################################
sopen System

let checkString () =
    Console.ReadLine()
    |> int
    |> (fun x -> if x >= 30 then "Yes" else "No")
    |> printfn "%s"

checkString()
####################################
open System

let checkString () =
    let inputString = Console.ReadLine().Trim()
    let X = int inputString
    let judge = X >= 30
    let ANS = [| "No"; "Yes" |]
    Console.WriteLine(ANS.[if judge then 1 else 0])

checkString()
####################################
open System

let checkString () =
    let inputString = Console.ReadLine().Trim()
    let inputNumber = int inputString
    if inputNumber >= 30 then
        Console.WriteLine("Yes")
    else
        Console.WriteLine("No")   

checkString()
####################################
