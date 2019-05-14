let rec interleave = function
| [],[] -> []
| [x],[y] -> [x;y]
 
let a = 
    interleave ([1;2;3],[4;5;6])
open System
printf "a = %A" a