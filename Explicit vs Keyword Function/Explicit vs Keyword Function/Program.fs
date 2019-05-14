let rec prod = function
| [] -> 1
| x::xs -> x * prod xs

let rec xprod xp =
    match xp with
    | [] -> 1
    | n::ns -> n * xprod ns

let p =
    prod [100;5;2]

let xp =
    xprod [100;5;2]

open System
printfn "%i" p
printfn "%i" xp