open System
//C won't work because f# cannot compute a float and an int like in java.
let a1 = 
    2+5*10
printfn "%i" a1
let b1 = 
    10I * 20I
printfn "%A" b1
//let c1 = 
   // 4 + 5.6
//printfn "%A" c1
let d1 = 
    "4" + "5.6"
printfn "%A" d1