abc069_b.fs
#########################################
#########################################
#########################################
#########################################
#########################################
let readCharArray _ = stdin.ReadLine().ToCharArray()
()
|> readCharArray
|> fun x ->
    (x.[0] |> string)
    + (x.Length |> (-) <| 2 |> string)
    + (x.[x.Length - 1] |> string)
|> printfn "%s"
#########################################
open System
let s = stdin.ReadLine()
s.[0..0] + ((s.Length - 2) |> string) + s.[s.Length-1..s.Length-1]
|> printfn "%s"
#########################################
let s = stdin.ReadLine()
[(s |> Seq.head |> string);((s.Length - 2) |> string);(s |> Seq.rev |> Seq.head |> string)] |> String.concat "" |> printfn "%s"
#########################################
open System
let checkString () =
    let S = Console.ReadLine().Trim()
    let n = S.Length
    Console.WriteLine(string(S.[0]) + string(n - 2) + string(S.[n - 1]))
checkString()
#########################################
