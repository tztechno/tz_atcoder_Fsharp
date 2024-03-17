//abc093_a.fs
####################################
####################################
####################################
####################################
####################################
####################################
####################################
let s = System.Console.ReadLine()
printfn "%s" <|
  if ["a";"b";"c"] |> List.forall s.Contains then "Yes" else "No"
####################################
open System

[<EntryPoint>]
let main argv =
    if (stdin.ReadLine() |> Seq.distinct |> Seq.length) = 3 then "Yes" else "No"
    |> stdout.WriteLine
    0
####################################
open System

let checkString s =
   if s |> String.exists (fun c -> c = 'a')
      && s |> String.exists (fun c -> c = 'b')
      && s |> String.exists (fun c -> c = 'c') then
       printfn "Yes"
   else
       printfn "No"

[<EntryPoint>]
let main argv =
   let input = Console.ReadLine()
   match input with
   | null -> printfn "Invalid input"
   | input -> checkString input
   0
####################################
