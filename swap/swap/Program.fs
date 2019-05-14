let swap (a,b) = (b,a)

let s = 
    swap (10, 10.5)
let s2 =
    swap ("Hello", 50)
let s3 =
    swap ((10,"l",2.2222), "k")
let s4 =
    swap (("Goodbye",[10.2;52.2;892.2],-98), 2)

open System
printfn "Swap 10 and 10.5: %A" s
printfn "Swap Hello and 50: %A" s2
printfn "Swap (10,l,2.2222) and k: %A" s3
printfn "Swap (Goodbye,[10.2;52.2;892.2],-98) and 2: %A" s4