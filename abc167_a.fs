//abc167_a.fs
################################
################################
################################
################################
################################
open System
let S = Console.ReadLine()
let T = Console.ReadLine()
if T.Remove(T.Length - 1, 1) = S then
    "Yes"
else 
    "No"
|> printfn "%s"
################################
let s = stdin.ReadLine()
let t = stdin.ReadLine()
match (t.Length = s.Length + 1)
      && (s = t.[0..s.Length - 1]) with
| true -> "Yes"
| false -> "No"
|> printfn "%s"
################################
let b = stdin.ReadLine()
stdin.ReadLine().ToCharArray()
|> Array.toList
|> List.rev
|> (fun (x :: xx) -> xx)
|> List.rev
|> List.toArray
|> System.String
|> (fun x -> if x = b then "Yes" else "No")
|> printfn "%s"
################################
open System
let checkString () =
    let S = Console.ReadLine().Trim()
    let T = Console.ReadLine().Trim()
    let n = S.Length
    let ANS =
        if S = T.[0..n-1] then
            "Yes"
        else
            "No"   
    Console.WriteLine(ANS)
checkString()
################################
