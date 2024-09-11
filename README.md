# tz_atcoder_Fsharp

### latest

---
```

```
---
```

```
---
```

```
---
```

```
---
```
open System
let checkString () =
    let input = Console.ReadLine().Trim() 
    let result =
        match input with
        | "A" -> "T"
        | "T" -> "A"
        | "C" -> "G"
        | "G" -> "C"
        | _ -> "Invalid input"
    printfn "%s" result
checkString ()
```
---
```
let mutable result = "Christmas"
```
---
```
let X = stdin.ReadLine() |> int
```
---
```
if文の構造
if xxxxxx then
else
```
---
