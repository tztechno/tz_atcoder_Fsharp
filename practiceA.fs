//practiceA.fs
##################################
1
2 3
test
##################################
##################################
##################################
let a = Int(readLine()!)!
let bc = readLine()!.split(separator: " ").map { Int(String($0))! }
let s = readLine()!
let sum = a + bc[0] + bc[1]
print(sum, s)
##################################
let a = stdin.ReadLine() |> int
let b, c = stdin.ReadLine().Split(' ') |> Array.map int |> (fun i -> i.[0], i.[1])
let d = stdin.ReadLine()
printf "%d %s" (a + b + c) d
##################################
let a = stdin.ReadLine() |> int
// let b,c = stdin.ReadLine().Split() |> Array.map int |> fun array -> array.[0], array.[1]
let [|b;c|] = stdin.ReadLine().Split() |> Array.map int
let s = stdin.ReadLine()

printfn "%d %s" (a + b + c) s
##################################
let readInt () = 
    stdin.ReadLine() |> int

let readInts n =
    stdin.ReadLine().Split() |> Array.map int

[<EntryPoint>]
let main args =
    let a = readInt()
    let [|b;c|] = readInts()
    let s = stdin.ReadLine()
    printfn "%d %s" (a + b + c) s
    0
##################################
let a = stdin.ReadLine() |> int64

// 入力行を分割してint64に変換
let inputs = stdin.ReadLine().Split() |> Array.map int64

// 入力が2つの要素を含む場合のみ処理を実行
match inputs with
| [|b; c|] ->
    let m = stdin.ReadLine()
    printfn $"{a + b + c} {m}"
| _ ->
    // 適切なエラーメッセージまたは他の処理
    printfn "Error: Invalid input format"
##################################
