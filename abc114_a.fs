abc114_a.fs
##########################################
##########################################
##########################################
##########################################
##########################################
##########################################
##########################################
let X = stdin.ReadLine() |> int
if X=7||X=5||X=3 then
    printfn "YES"   
else
    printfn "NO"

##########################################
let X = stdin.ReadLine() |> int
if (X-7)*(X-5)*(X-3)=0 then
    printfn "YES"   
else
    printfn "NO"

##########################################
[python]
X=int(input())
if (X-7)*(X-5)*(X-3)==0:
  print('YES')
else:
  print('NO')
##########################################
