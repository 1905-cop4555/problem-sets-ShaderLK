let rec power (m,n) =
    if n = 0
        then 1.0
        else m * power(m, n-1)

open System
let a=
    power (2.0, 10)
printfn "2.0 to the power of 10 is: %f" a