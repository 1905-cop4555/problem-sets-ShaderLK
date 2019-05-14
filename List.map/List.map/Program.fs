let a =
    List.map (fun n -> n*n) [1;2;3]@[4;5;6]

let b =
    List.map (fun m -> m*m) ([1;2;3]@[4;5;6])

open System
printfn "a = %A" a
printfn "b = %A" b