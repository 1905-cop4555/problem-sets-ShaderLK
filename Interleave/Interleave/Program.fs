let rec interleave = function
| [],[] -> []
| [x],[y] -> [x;y]
| x::xs, y::ys -> let small = interleave(xs,ys) 
                                x::y::small
| _,_ -> failwith "not equal"


                       