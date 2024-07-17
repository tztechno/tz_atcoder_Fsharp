abc115_a.fs
##########################################
let mutable result = "Christmas"
##########################################
##########################################
##########################################
##########################################
Array.create (stdin.ReadLine() |> int |> (-) 25) "Eve"
|> Array.append [|"Christmas"|]
|> String.concat " "
|> printfn "%s"
##########################################
[after fix:AC]
open System
let checkString () =
    let D = Console.ReadLine().Trim() |> int
    let mutable result = "Christmas"
    for i = 1 to (25 - D) do
        result <- String.Concat(result, " Eve")
    Console.WriteLine(result)

checkString()
##########################################
[before fix]
open System
let checkString () =
    let D = Console.ReadLine().Trim() |> int
    let result = "Christmas"
    for i = 1 to (25-D) do
      result = String.Concat(result," Eve")
    Console.WriteLine(result) 
checkString()
##########################################
[error]
open System
let checkString () =
    let D = Console.ReadLine().Trim() |> int
    Console.WriteLine("Christmas"+" Eve"*(25-D))
checkString()
##########################################
[python]
D=int(input())
print("Christmas"+" Eve"*(25-D))
##########################################
