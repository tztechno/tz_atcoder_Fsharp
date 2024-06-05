abc112_a.fs
#######################################
if文の構造
if xxxxxx then
else
#######################################
#######################################
#######################################
#######################################
#######################################
#######################################
#######################################
let N = stdin.ReadLine() |> int

if N = 1 then
    "Hello World"
else
    let A = stdin.ReadLine() |> int
    let B = stdin.ReadLine() |> int
    (A + B).ToString()
|> stdout.WriteLine
#######################################
let readInt () = 
    stdin.ReadLine() |> int

let readInts n =
    stdin.ReadLine().Split() |> Array.map int

[<EntryPoint>]
let main args =
    let n = readInt()
    if n=1 then
        printfn "%s" "Hello World"
    else    
        let a = readInt()
        let b = readInt()
        printfn "%d" (a + b)
    0
#######################################
[python]
N=int(input())
if N==1:
    print("Hello World")
else:
    a=int(input())
    b=int(input())
    print(a+b) 
#######################################
