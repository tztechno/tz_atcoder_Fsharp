abc072_b.fs
######################################
######################################
######################################
######################################
######################################
######################################
######################################
stdin.ReadLine().ToCharArray() 
|> Array.mapi (fun i c -> (i, c)) 
|> Array.filter (fun (i, c) -> i % 2 = 0) 
|> Array.map (fun (i, c) -> c |> string) 
|> String.concat "" 
|> printfn "%s"
######################################
let readCharArray _ = stdin.ReadLine().ToCharArray()

()
|> readCharArray
|> Array.indexed
|> Array.filter (fun (i, _) -> i % 2 = 0)
|> Array.map (fun (_, c) -> c)
|> System.String
|> printfn "%s"

######################################
open System

let main () =
    let S = Console.ReadLine()
    let S_list = S.ToCharArray()
    let n = S_list.Length
    let ANS = [| for i in 0 .. 2 .. n-1 -> S_list.[i] |]
    let result = String(ANS)
    Console.WriteLine(result)

main()
######################################
