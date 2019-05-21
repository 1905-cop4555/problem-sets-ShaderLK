let rec mul a =
    match a with 
    |[] -> 0
    |x::xs -> x * mul xs

let m =
    mul [1..10]

printfn "%A" m


let rec mult a=
    match a with 
    |[] -> 0
    |[x] -> x
    |x::xs -> x * mult xs

let t =
    mult [1..10]

printfn "%A" t