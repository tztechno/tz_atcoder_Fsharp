abc105_a.fs
#######################################
#######################################
#######################################
#######################################
#######################################
#######################################
#######################################
stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b |] -> if a % b = 0 then "0" else "1"
|> printfn "%s"
#######################################