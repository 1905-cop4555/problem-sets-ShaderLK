let rec prod ns =
    if List.isEmpty ns then 1
    else List.head ns * prod (List.tail ns)

let rec div ms =
    if List.isEmpty ms then 1.0
    else div (List.tail ms) / List.head ms 

let rec add os =
    if List.isEmpty os then 0
    else List.head os + add (List.tail os)

let rec sub ps =
    if List.isEmpty ps then 0
    else sub (List.tail ps) - List.head ps 

open System

let a = 
    prod [1..3]
let b = 
    div [1.0..10.0]
let c = 
    add [1..3]
let d = 
    sub [10;5;5;5]

printfn "Product of 1 to 3 inclusive is: %A" a
printfn "Division of 1 to 3 inclusive is: %A" b
printfn "Addition of 1 to 3 inclusive is: %A" c
printfn "Subtraction of 1 to 3 inclusive is: %A" d