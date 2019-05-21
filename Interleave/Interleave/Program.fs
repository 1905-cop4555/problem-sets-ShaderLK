let rec interleave xs ys =
    match xs, ys with
    | [], ys -> ys
    | xs, [] -> xs
    | x::xs, y::ys -> x::y::interleave xs ys

let i =
    interleave [5;6;7] [1;2;3]
    
printfn "%A" i

                       