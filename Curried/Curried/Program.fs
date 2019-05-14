let cadd a = 
    (fun b -> a+b)
let ab = 
    cadd 10 7

let csub s =
    (fun d -> s-d)
let cb = 
    csub 10 7

let kmulti k =
    (fun j -> k*j)
let jb = 
    kmulti 10 7

let udiv u =
    (fun w -> u/w)
let ub = 
    udiv 10.0 7.0

open System
printfn "Curried addition of 10 and 7: %A" ab
printfn "Curried subtract of 10 and 7: %A" cb
printfn "Curried multiplication of 10 and 7: %A" jb
printfn "Curried division of 10 and 7: %A" ub
