let rec prod ns =
    if List.isEmpty ns then 1
    else List.head ns * prod (List.tail ns)

let rec div ms =
    if List.isEmpty ms then 1.0
    else div (List.tail ms) / List.head ms 

let rec add os =
    if List.isEmpty os then 0
    else List.head os + add (List.tail os)

let rec sub_help ans = function
| [] -> ans
| x::xs -> sub_help (ans - x) xs

let sub_new list = function
| [] -> 0
| x::xs -> sub_help x xs

let rec sub ps =
    if List.isEmpty ps then 0
    else List.head ps - add (List.tail ps)

open System

let a = 
    prod [1..10]
let b = 
    div [1.0..10.0]
let c = 
    add [1..10]
let d = 
    sub [1..10]
let e = 
    sub_new [1..10]

printfn "Product of 1 to 10 inclusive is: %A" a
printfn "Division of 1 to 10 inclusive is: %A" b
printfn "Addition of 1 to 10 inclusive is: %A" c
printfn "Subtraction of 1 to 10 inclusive is: %A" d
printfn "Subtraction of 1 to 10 inclusive is: %A" e